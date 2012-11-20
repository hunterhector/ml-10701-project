package edu.cmu.lti.citation.predict

import org.apache.commons.logging.LogFactory
import io.Source
import edu.cmu.lti.citation.util.{PaperIdConverter, GraphUtils}
import edu.cmu.lti.citation.graph.AanCitationGraph
import java.io.File
import collection.mutable
import it.unimi.dsi.fastutil.doubles.DoubleArrayList

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/4/12
 * Time: 5:04 PM
 */
class LDAPreferredRandomWalkPredictor (ldaPairwiseFile:File,measure:String,conv: PaperIdConverter) extends Predictor {
  val LOG = LogFactory.getLog(this.getClass)

  override def getName = "LDA Preferred Random Walk Predictor"

  val simMapAll = Source.fromFile(ldaPairwiseFile).getLines().filterNot(_.trim()=="").map(_.split("_")).
    filter(_.length == 4).filter(fields => (conv.containsPaper(fields(0)) && conv.containsPaper(fields(1)))).
    map(fields => (conv.toGraphIndex(fields(0)),conv.toGraphIndex(fields(1)),fields(2).toDouble,fields(3).toDouble)).
    foldLeft(Map[Int,mutable.Map[Int,(Double,Double)]]()){
    case (m,(s,d,cos,e)) =>{
      val newEntry = (d -> (cos,e))
      val m1 = if (m.contains(s)){
        m(s) += newEntry
        m
      }else{
        val a = mutable.Map(newEntry)
        m + (s -> a)
      }

      val reEntry = (s -> (cos,e))
      if (m1.contains(d)){
        m1(d) += reEntry
        m1
      }else{
        val a = mutable.Map(reEntry)
        m1 + (d -> a)
      }
    }
  }

  var alpha = 0.2
  var beta = 0.8

  def setParameters(a:Int,b:Int){
    alpha = a
    beta = b
  }


  def predict(t: List[(Int, Int, Float)], s: Int, k: Int) = {
    val simWithSource = simMapAll(s)

    val g= GraphUtils.buildWeightedGraphFromTriples(t)

    val nodeNumber = g.numNodes()

    val zeroArray = Array.fill[Double](nodeNumber)(0)

    val preferenceVector: DoubleArrayList = new DoubleArrayList(zeroArray) //initial with no preference

    val startPreference = beta

    preferenceVector.set(s,startPreference)

    val topicPreference = 1 - beta

    val simSum = simWithSource.foldLeft(0.0){
      case (sum,(t,(cos,ecul))) => {
        sum + cos
      }
    }/topicPreference

    simWithSource.foreach{
      case (t,(cos,ecul)) =>{
        preferenceVector.set(t,cos/simSum)
      }
    }

    val fullRankedList = AanCitationGraph.prPredict(g,s,k,alpha,preferenceVector,null)
    fullRankedList.toList
  }
}
