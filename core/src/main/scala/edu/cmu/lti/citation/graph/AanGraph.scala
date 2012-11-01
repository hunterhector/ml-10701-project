package edu.cmu.lti.citation.graph

import edu.cmu.lti.citation.util.{GraphUtils, PaperIdConverter}
import org.apache.commons.logging.LogFactory
import java.io.File
import io.Source
import it.unimi.dsi.webgraph.labelling.ArcLabelledImmutableGraph
import es.yrbcn.graph.weighted.WeightedPageRank
import it.unimi.dsi.fastutil.doubles.DoubleArrayList
import collection.mutable.ListBuffer
import util.Random

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 10/23/12
 * Time: 4:37 PM
 */
object AanGraph {
    private val LOG = LogFactory.getLog(this.getClass)

  /**
   * Return the top k predictions, if k <=0, then return everything
   * @param g
   * @param targetIndex
   * @param k
   * @return
   */
  def prPredict(g:ArcLabelledImmutableGraph,targetIndex:Int,k:Int):Array[(Double,Int)] = {
    val ranks = runPageRankWithRestart(g,targetIndex)
    if (k > 0){
      val tops = ranks.zipWithIndex.sortBy(_._1).reverse.take(k)
      tops
    }else{
      val tops = ranks.zipWithIndex.sortBy(_._1).reverse
      tops
    }
  }

  /**
   * make the vector Stochastic (L1 norm equal to 1) so that the WeightedPageRank method will accept it
   *
   *
   * @param vector the initial vector
   * @return the resulted stochatic vector
   */
  private def makeStochastic(vector:DoubleArrayList):DoubleArrayList = {
    val l1 = l1Norm(vector)
    LOG.debug("L1 was "+l1)
    if (l1 == 0) return vector //if the l1 norm is 0 than actually it can't be stochastic. It will be simply returned

    (0 to vector.size-1)foreach(idx => {
      val ori = vector.get(idx)
      vector.set(idx,ori/l1)
    })
    vector
  }

  /**
   * Calculate the L1Norm (sum of the abs of value in the list)
   * @param a The list to be examined
   * @return
   */
  private def l1Norm (a: DoubleArrayList): Double ={
    a.toDoubleArray().foldLeft(0.0)((norm,v)=>{
      norm + math.abs(v)
    })
  }


  private def runPageRankWithRestart(g: ArcLabelledImmutableGraph, restartIndex: Int) : Array[Double] = {
    LOG.debug("Preparing page rank...")

    val nodeNumber = g.numNodes()

    val uniformArray = Array.fill[Double](nodeNumber)(1.0/nodeNumber)       //actually already stochastic

    val initialVector: DoubleArrayList = new DoubleArrayList(uniformArray)

    val zeroArray = Array.fill[Double](nodeNumber)(0)

    val preferenceVector: DoubleArrayList = new DoubleArrayList(zeroArray) //initial with no preference

    preferenceVector.set(restartIndex,1.0) //set jump probability for the restart node

    LOG.debug("Running page ranks...")

    //max number of iteration
    val maxIter = 1000

    //use the Java Wrapper to run the WeightedPageRank, running it direactly from scala generate unexpected errors
    WeightedPageRankWrapper.run(g,WeightedPageRank.DEFAULT_ALPHA,false,WeightedPageRank.DEFAULT_THRESHOLD,maxIter,makeStochastic(initialVector),preferenceVector)
  }

}
//
//object AanGraph{
//  private val LOG = LogFactory.getLog(this.getClass)
//
//  def main(args: Array[String]) {
//    if(args.length != 1) LOG.error("Please locate AAN data release folder  (2011 release preferable).")
//
//    val aanFolder = args(0)
//    val ag = new AanGraph(new File(aanFolder))
//
//    //make a test prediction on a file and get the top 5 results
//    ag.prPredict(0,5)
//
//    ag.prPredictByPaperId("C00-2128",50)
//  }
//
//}
