package edu.cmu.lti.citation.io

import java.io.File
import org.apache.commons.logging.LogFactory
import edu.cmu.lti.citation.util.{GraphUtils, AclUtils, PaperIdConverter}
import io.Source
import collection.mutable
import it.unimi.dsi.webgraph.labelling.ArcLabelledImmutableGraph
import collection.mutable.ListBuffer
import util.Random

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/19/12
 * Time: 2:54 PM
 */

/**
 * Handle the input of ACL anthology network data
 * @param rootFolder
 */
class AanCitationNetworkReader (rootFolder: File) {
  private val LOG = LogFactory.getLog(this.getClass)
  private val networkFolder = "networks"
  private val paperIdFile = new File(rootFolder.getAbsolutePath + "/" + "paper_ids.txt")
  private val citationNetworkFile = new File(rootFolder.getAbsolutePath + "/" + networkFolder + "/" + "paper-citation-network_fixed.txt")

  private val aclMetadataFile = new File(rootFolder.getAbsolutePath + "/" + "acl-metadata.txt")

  val id2YearMap = AclUtils.getIdYearMapping(aclMetadataFile)

  private val conv = new PaperIdConverter(citationNetworkFile,id2YearMap)

  //private val citationNetworkContent =  Source.fromFile(citationNetworkFile).getLines().filterNot(_.trim()=="").map(_.split(" ==> ")).
  //  map(fields => ((conv.toGraphIndex(fields(0)),conv.toGraphIndex(fields(1)),1.0.toFloat))).toList

  private val citationNetworkWithMeta =  Source.fromFile(citationNetworkFile).getLines().filterNot(_.trim()=="").map(_.split(" ==> ")).
    filter(fields => (id2YearMap.contains(fields(0)) && id2YearMap.contains(fields(1)))).
    map(fields => ((conv.toGraphIndex(fields(0)),conv.toGraphIndex(fields(1)),1.0.toFloat))).toList

  //Data for training and testing, make sure all are contained in the metadata
  private val allData = splitData()

  val trainSource = allData._1
  val testSource = allData._2
  val trainCandidates = allData._3
  val testCandidates = allData._4

  LOG.info("Reading Network data successful!")

  if (! isValid) {
    throw new IllegalArgumentException("Should use the AAN 2011 release folder as input!")
  }

  /**
   * Fail fast!
   * @return   check whether the folder is valid
   */
  private def isValid : Boolean = {
    if (! rootFolder.isDirectory)  return false
    if (! paperIdFile.exists())    return false
    if (! citationNetworkFile.exists()) return false
    true
  }

  def getConverter = conv

 // if (!conv.containsPaper("P87-1009")) throw new Exception("Shit 1")
 // if (!conv.containsPaper("J79-1033c")) throw new Exception("Oh shit 2!")

  private def splitData():(Set[Int],Set[Int],Set[Int],Set[Int]) = {
    LOG.info("Preparing training and testing data")

    val sourcePapersForTest = new mutable.HashSet[Int]()

    val paperPoolForTest = new mutable.HashSet[Int]()

    val sourcePapersForTraining = new mutable.HashSet[Int]()

    val paperPoolForTraining = new mutable.HashSet[Int]()

    val testyear = 2011
    val trainyear = 2000

    id2YearMap.foreach{
      case (id,year) =>{
        if (conv.containsPaper(id)) //some paper exists in meta data are not in network, currently omitted
        {
          if (year == testyear)  {
            //LOG.debug("Adding paper "+id)
            sourcePapersForTest += conv.toGraphIndex(id)
          }else if(year < testyear){
            paperPoolForTest += conv.toGraphIndex(id)
          }

          if (year == trainyear) {
            sourcePapersForTraining += conv.toGraphIndex(id)
          }else if (year < trainyear){
            paperPoolForTraining += conv.toGraphIndex(id)
          }
        }
      }
    }

    val numPapers = id2YearMap.size

    LOG.info(String.format("From acl meta data. Totally %s papers, %s from year %s (some will be chosen for test), %s from year %s (some will be chosen for training), %s from the rest",
      numPapers.toString,sourcePapersForTest.size.toString,testyear.toString,sourcePapersForTraining.size.toString, trainyear.toString, paperPoolForTraining.size.toString))

    val trainingSource = sourcePapersForTraining.toSet
    val testingSource = sourcePapersForTest.toSet
    val trainingCandidates = paperPoolForTraining.toSet
    val testCandidates = sourcePapersForTest.toSet

    (trainingSource,testingSource,trainingCandidates,testCandidates)
  }

  /**
   * Random hide some links and store them in golden standard
   * Make sure papers in the returned graph all have metadata
   * @param s the source paper index that you wanna target for
   * @return Return the citation network with some links randomly missed from source paper and the corresponding golden data
   */
   def buildListWithHiddenLinks(s: Int) = {
    val gold = new mutable.HashSet[Int]()
    var numPreservedLinks = 0
    //the triple list actually contains the network links (hence all candidates), with some links hidden
    val tripleList = citationNetworkWithMeta.filterNot{
      case (idx1, idx2, w)=>{
        if (idx1 == s){
          if (Random.nextBoolean()&&Random.nextBoolean())  //double random boolean gives 25% chance
          {
            gold += idx2
            // LOG.debug(String.format("Arc %s -> %s is filtered",idx1.toString,idx2.toString))
            true   //with some probability, this link is filtered, so it is missing
          }else{
            numPreservedLinks += 1
            false // some links could still preserve
          }
        }
        else false //all other links are not filtered
    }}.toList

    // (GraphUtils.buildWeightedGraphFromTriples(tripleList),gold.toSet,numPreservedLinks)
    (tripleList,gold.toSet,numPreservedLinks)
  }

  /**
   * Essentially save the AAN graph with some links randomly removed into WebGraph format
   * Can save to disk to allow future usage
   * @param targetIndex
   * @return
   */
  def buildGraphWithMissingLink(targetIndex:Int):ArcLabelledImmutableGraph = {
    var missingLinks = new ListBuffer[Int]()
    val tripleList = citationNetworkWithMeta.
      //use double random to make the prob 25% -> filter less links out
      filterNot({case (idx1,idx2,w)=>{if (idx1 == targetIndex) {if (Random.nextBoolean()&&Random.nextBoolean()) {missingLinks += idx2; true} else false} else false}}).toList

    LOG.info("Missing links are :")
    missingLinks.foreach(l => LOG.info(conv.fromGraphIndex(l)))
    GraphUtils.buildWeightedGraphFromTriples(tripleList)
  }

}
