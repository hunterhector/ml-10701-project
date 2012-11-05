package edu.cmu.lti.citation.predict

import edu.cmu.lti.citation.util.{PaperIdConverter, GraphUtils}
import edu.cmu.lti.citation.graph.AanGraph

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/1/12
 * Time: 11:48 AM
 */
class RandomWalkPredictor (alpha:Double) extends Predictor{
//class RandomWalkPredictor (rootFolder:File, outputFolder:File){
  override def getName = "Random Walk Predictor"

  def predict(t: List[(Int, Int, Float)], s: Int, k: Int):List[(Double,Int)]  = {
    val g= GraphUtils.buildWeightedGraphFromTriples(t)
    val fullRankedList = AanGraph.prPredict(g,s,k,alpha)
    fullRankedList.toList
  }

}

//object RandomWalkPredictor{
//  private val LOG = LogFactory.getLog(this.getClass)
//
//  def main(args: Array[String]) {
//    if(args.length != 1) LOG.error("Please locate AAN data release folder  (2011 release preferable).")
//
//    val aanFolder = args(0)
//    val outputFolder = args(1)
//    val re = new RandomWalkPredictor(new File(aanFolder),new File(outputFolder))
//
//    //ag.prPredictByPaperId("C00-2128",50)
//  }
//}