package edu.cmu.lti.citation.eval

import java.io.File
import edu.cmu.lti.citation.util.GraphUtils
import edu.cmu.lti.citation.graph.AanGraph
import org.apache.commons.logging.LogFactory

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/1/12
 * Time: 11:48 AM
 */
class RandomWalkEvaluator (rootFolder:File) extends Evaluator(rootFolder){

  @Override
  def predict(t: List[(Int, Int, Float)], s: Int, k: Int):List[(Double,Int)]  = {
    val g= GraphUtils.buildWeightedGraphFromTriples(t)
    val fullRankedList = AanGraph.prPredict(g,s,k)
    fullRankedList.toList
  }
}

object RandomWalkEvaluator{
  private val LOG = LogFactory.getLog(this.getClass)

  def main(args: Array[String]) {
    if(args.length != 1) LOG.error("Please locate AAN data release folder  (2011 release preferable).")

    val aanFolder = args(0)
    val ag = new RandomWalkEvaluator(new File(aanFolder))

    ag.train()
    ag.test()
    //ag.prPredictByPaperId("C00-2128",50)
  }
}