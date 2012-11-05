package edu.cmu.lti.citation.eval

import java.io.{FileWriter, File}
import org.apache.commons.logging.LogFactory
import edu.cmu.lti.citation.util.{GraphUtils, PaperIdConverter,AclUtils}
import it.unimi.dsi.webgraph.labelling.ArcLabelledImmutableGraph
import io.Source
import collection.mutable.ListBuffer
import util.Random
import edu.cmu.lti.citation.graph.AanGraph
import collection.mutable
import edu.cmu.lti.citation.predict._

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 10/31/12
 * Time: 3:40 PM
 */
class Evaluator (rootFolder: File,outputFolder:File) {
  private val LOG = LogFactory.getLog(this.getClass)
  private val networkFolder = "networks"
  private val paperIdFile = new File(rootFolder.getAbsolutePath + "/" + "paper_ids.txt")
  private val citationNetworkFile = new File(rootFolder.getAbsolutePath + "/" + networkFolder + "/" + "paper-citation-network_fixed.txt")

  private val aclMetadataFile = new File(rootFolder.getAbsolutePath + "/" + "acl-metadata.txt")
  private val conv = new PaperIdConverter(rootFolder)

  private val citationNetworkContent =  Source.fromFile(citationNetworkFile).getLines().filterNot(_.trim()=="").map(_.split(" ==> ")).
    map(fields => ((conv.toGraphIndex(fields(0)),conv.toGraphIndex(fields(1)),1.0.toFloat))).toList

  private val kTop = 20

  if (! isValid) {
    throw new IllegalArgumentException("Should use the AAN 2011 release folder as input!")
  }

  private val sources = splitTrainData()
  private val sTrain = sources._1
  private val sTest = sources._2

  LOG.info("Initialization successful!")

  def isValid : Boolean = {
    if (! rootFolder.isDirectory)  return false

    if (! paperIdFile.exists())    return false

    if (! citationNetworkFile.exists()) return false

    true
  }

  private def splitTrainData():(Set[Int],Set[Int]) = {
    LOG.info("Preparing training and testing data")
     val id2YearMap = AclUtils.getIdYearMapping(aclMetadataFile)

     val sourcePapersForTest = new mutable.HashSet[Int]()

     val paperPoolForTest = new mutable.HashSet[Int]()

     val sourcePapersForTraining = new mutable.HashSet[Int]()

     val paperPoolForTraining = new mutable.HashSet[Int]()

     id2YearMap.foreach{
       case (id,year) =>{
           if (conv.containsPaper(id)) //some paper exists in meta data are not in network, currently omitted
           {
             if (year == 2011)  {
               sourcePapersForTest += conv.toGraphIndex(id)
             }else{
               paperPoolForTest += conv.toGraphIndex(id)
             }

             if (year == 2010) {
               sourcePapersForTraining += conv.toGraphIndex(id)
             }else if (year < 2010){
               paperPoolForTraining += conv.toGraphIndex(id)
             }
           }
       }
     }


    LOG.info(String.format("From acl meta data. Totally %s papers, %s from year 2011 (some will be chosen for test), %s from year 2010 (some will be chosen for training), %s from the rest",
      id2YearMap.size.toString,sourcePapersForTest.size.toString,sourcePapersForTraining.size.toString, paperPoolForTraining.size.toString))

    val training = sourcePapersForTraining.toSet
    val testing = sourcePapersForTest.toSet

    (training,testing)
  }

  /**
   * This one build a full graph with everything, not really useful though
   * @return The resulting graph
   */
  private def buildGraph():ArcLabelledImmutableGraph = {
    //val numPaper = conv.getNumberOfPaper
    //tripleList.foreach(LOG.debug)
    GraphUtils.buildWeightedGraphFromTriples(citationNetworkContent)
  }

  /**
   * Build a graph with some random missing links for one index
   * @param targetIndex
   * @return
   */
  private def buildGraphWithMissingLink(targetIndex:Int):ArcLabelledImmutableGraph = {
    var missingLinks = new ListBuffer[Int]()
    val tripleList = citationNetworkContent.
      //use double random to make the prob 25% -> filter less links out
      filterNot({case (idx1,idx2,w)=>{if (idx1 == targetIndex) {if (Random.nextBoolean()&&Random.nextBoolean()) {missingLinks += idx2; true} else false} else false}}).toList

    LOG.info("Missing links are :")
    missingLinks.foreach(l => LOG.info(conv.fromGraphIndex(l)))
    GraphUtils.buildWeightedGraphFromTriples(tripleList)
  }

  private def getConverter = {
    conv
  }

  /**
   * Remove all links from test source
   * @return  Graph without links from test source
   */
  private def buildGraphForTraining() = {
    val tripleList = citationNetworkContent.filterNot(i => {sTest.contains(i._1)}).toList
    GraphUtils.buildWeightedGraphFromTriples(tripleList)
  }

  /**
   * Random hide some links and store them in golden standard
   * @param s the source paper index that you wanna test for
   * @return Return a citation network with some links randomly missed from source paper
   */
  private def buildListForTesting(s: Int) = {
    //LOG.debug(String.format("Buiding testing graph for node %s",s.toString))
    val gold = new mutable.HashSet[Int]()
    var numPreservedLinks = 0
    val tripleList = citationNetworkContent.filterNot{
        case (idx1, idx2, w)=>(
          if (idx1 == s){
            if (Random.nextBoolean()&&Random.nextBoolean())
              {
                gold += idx2
               // LOG.debug(String.format("Arc %s -> %s is filtered",idx1.toString,idx2.toString))
                true   //with some probability, this link is filtered, so it is missing
              }
            else{
              numPreservedLinks += 1
              false // some links could still preserve
            }
          }
          else false //all other links are not filtered
      )}.toList

   // LOG.debug("Pruned list length: "+tripleList.length)
    // (GraphUtils.buildWeightedGraphFromTriples(tripleList),gold.toSet,numPreservedLinks)
     (tripleList,gold.toSet,numPreservedLinks)
  }

//  /**
//   *
//   * @param t A triple list, every element is a (source paper index, target paper index, weight) triple
//   * @param s The source paper index that you want to predict
//   * @param k Top k number of paper to be returned
//   * @return
//   */
//  def predict(t:List[(Int,Int,Float)],s:Int,k:Int = -1)  :List[(Double,Int)]

  def train(predictors:List[Predictor]){
    predictors.foreach {
      p =>
      LOG.info(String.format("Training [%s], please wait...",p.getName))

    }
  }

  def test(predictors:List[Predictor],out:FileWriter) {
    var averRKL = 0.0
    var averRKF = 0.0
    var actualTest = 0

    //create a test set with golden
    val testWithGolden = sTest.foldLeft(List[(Int,List[(Int,Int,Float)],Set[Int])]())((tg,s)=>{
      val t = buildListForTesting(s)
      val tripleList = t._1
      val gold = t._2
      val numPreservedLinks = t._3

      if (gold.size !=0 && numPreservedLinks > 0){
        tg ::: List((s,tripleList,gold))   //make sure 2 things: 1)Some links are removed 2)Not all links are removed
      }else{
        tg
      }
    })

    predictors.foreach(p =>{
      LOG.info(String.format("Evaluating [%s], please wait...",p.getName))

      testWithGolden.foreach{
        case (s,triples,gold) => {
          LOG.debug("Evaluating "+conv.fromGraphIndex(s))
          val fullRankedList = p.predict(triples,s,-1)
          val result = calRankMetrics(fullRankedList,gold)
          val subRkl = result._1
          val subRkf = result._2
          LOG.debug(String.format("For %s: RKL  is %s, RKF is %s",s.toString,subRkl.toString, subRkf.toString))

          averRKF += subRkf
          averRKL += subRkl
          actualTest += 1
        }
      }


      averRKL /= sTest.size
      averRKF /= sTest.size

      out.write(String.format("%s\t%s\n",averRKF.toString,averRKL.toString))

      LOG.info(String.format("For %s papers actually tested. Overall average RKF is %s, overall average RKL is %s",actualTest.toString,averRKF.toString,averRKL.toString))
    })

    out.close()
  }

  private def calRankMetrics(prediction:List[(Double,Int)],gold:Set[Int]):(Int,Int) = {
    val numMissingLink = gold.size
    var subRkf = -1

    if (numMissingLink == 0) //for gold size is empty
      throw new IllegalArgumentException("Gold standard is empty!")

    var predictCount = 0
    prediction.zipWithIndex.foreach{
      case ((rankScore,idx),rank) =>{
        if (predictCount == numMissingLink){
          return (rank,subRkf)
        }
        if (gold.contains(idx)){
          //LOG.debug(String.format("Found paper %s at position: %s",idx.toString,rank.toString))
          predictCount += 1
          if (subRkf == -1) subRkf = rank + 1
        }
      }
    }

    LOG.error("Golden standard includes:")
    gold.foreach(g => LOG.error(conv.fromGraphIndex(g)))
    LOG.error("Predicts only contains:")
    prediction.take(10).foreach{case (score,index) => LOG.error(String.format("Paper Id: %s, Rank score: %s",conv.fromGraphIndex(index),score.toString))}
    throw new IllegalArgumentException("Rank list is not complete, does not cover golden standard!") //in case something goes wrong
  }
}

object Evaluator{
  val LOG = LogFactory.getLog(this.getClass)

  def main(args:Array[String]){

    if(args.length != 1) LOG.error("Please locate AAN data release folder  (2011 release preferable).")

    val aanFolder = args(0)
    val outputFolder = args(1)
    val e = new Evaluator(new File(aanFolder),new File(outputFolder))

    val rwAlphaFile = new File(outputFolder+"/evalRandomWalkAlpha")
    val out = new java.io.FileWriter(rwAlphaFile)

    List(0.0,0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8,0.9,1.0).foreach(a => {
      val rp = new RandomWalkPredictor(a)
      //val ldaWeightRW = new LDAWeightedRandomWalkPredictor(new File("/Users/hector/Documents/projects/ml-10701-project/data/ldasimilarityfiles/sim_all_3k"),"cosine",e.getConverter)
      //val ldaPair = new LDAPairwisePredictor(new File("/Users/hector/Documents/projects/ml-10701-project/data/simpairwise_3k"),"cosine",e.getConverter)
      //val ldaPreferRW = new LDAPreferredRandomWalkPredictor(new File("/Users/hector/Documents/projects/ml-10701-project/data/simpairwise_3k"),"cosine",e.getConverter)
      out.write(a.toString+"\t")
      e.test(List(rp),out)
    })
  }
}

