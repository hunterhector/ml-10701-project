package edu.cmu.lti.citation.eval

import java.io.{FileWriter, File}
import org.apache.commons.logging.LogFactory
import edu.cmu.lti.citation.util.{GraphUtils, PaperIdConverter,AclUtils}
import it.unimi.dsi.webgraph.labelling.ArcLabelledImmutableGraph
import io.Source
import collection.mutable.ListBuffer
import util.Random
import edu.cmu.lti.citation.io.AanCitationNetworkReader
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

  private val kTop = 20

  private val sTest = reader.testData
  private val conv = reader.getConverter

  val reader = new AanCitationNetworkReader(rootFolder)
  val citationNetworkContent = reader.getCitationContent

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
            if (Random.nextBoolean()&&Random.nextBoolean())  //double random boolean gives 25% chance
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
      val ldaWeightRW = new LDAWeightedRandomWalkPredictor(new File("/Users/hector/Documents/projects/ml-10701-project/data/ldasimilarityfiles/sim_all_3k"),"cosine",e.conv)
      val ldaPair = new LDAPairwisePredictor(new File("/Users/hector/Documents/projects/ml-10701-project/data/simpairwise_3k"),"cosine",e.conv)
      val ldaPreferRW = new LDAPreferredRandomWalkPredictor(new File("/Users/hector/Documents/projects/ml-10701-project/data/simpairwise_3k"),"cosine",e.conv)
      out.write(a.toString+"\t")
      e.test(List(rp),out)
    })
  }
}

