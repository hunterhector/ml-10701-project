package edu.cmu.lti.citation.predict

import org.apache.commons.logging.LogFactory
import io.Source
import collection.mutable
import edu.cmu.lti.citation.util.{PaperIdConverter, GraphUtils}
import it.unimi.dsi.fastutil.doubles.DoubleArrayList
import edu.cmu.lti.citation.graph.AanCitationGraph
import java.io.File
import breeze.linalg.DenseVector
import collection.immutable.HashMap

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 12/2/12
 * Time: 3:20 AM
 */
class TrainedLDAPreferredRandomWalkPredictor(ldaPairwiseFile:File,modelFile:File,featureFile:File,measure:String,conv: PaperIdConverter) extends Predictor{
  val LOG = LogFactory.getLog(this.getClass)

  override def getName = "Weighted Random Walk with LDA jump Predictor"

  val w = DenseVector(Source.fromFile(modelFile).getLines().toList(0).split(" ").map(wi=>wi.toDouble).toArray)

  private val featuresLines = Source.fromFile(featureFile).getLines().toList

  private val numSamples = featuresLines.length - 1   //first line is table header
  private val numFeatures = featuresLines(0).split(",").length - 2

  val featureMap = featuresLines.slice(1,numSamples+1).foldLeft(HashMap[(Int,Int),DenseVector[Double]]()){
    case (m,l) =>{
      val fields = l.split(",")
      val from = conv.toGraphIndex(fields(0))
      val to = conv.toGraphIndex(fields(1))
      val features = new DenseVector(fields.slice(2,fields.length).map(_.toDouble).toArray)
      m + ((from,to)->features)
    }
  }

  LOG.info(String.format("Feature files read, %s samples, each with %s features",numSamples.toString,numFeatures.toString))

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

  def logistic(x:Double) ={
    1/(1 + math.exp(-x))
  }

  def edgeValue(f:DenseVector[Double],w:DenseVector[Double]):Double ={
    if (f.length != w.length)  LOG.error(String.format("Feature length is %s, but W length is %s.",f.length.toString,w.length.toString))
    f.dot(w)
  }

  def edgeFeature(from:Int,to:Int):DenseVector[Double] ={
    if (featureMap.contains((from,to))){
      featureMap((from,to))
    }else{
      LOG.error(String.format("Feature between %s -> %s not found!",conv.fromGraphIndex(from),conv.fromGraphIndex(to)))
      throw new Exception("Feature not found!")      // now i want to make sure everything matches, in real experiment we'd better comment it.
    }
  }

  def edgeStrength(x:Double):Double = {
    logistic(x)
  }

  def predict(t: List[(Int, Int, Float)], s: Int, k: Int) = {
    val simWithSource = simMapAll(s)

    val weightedTriples = t.map{case (curr,succ,weight)=>{
      val feature = edgeFeature(curr,succ)
      val value = edgeValue(feature,w)
      (curr,succ,edgeStrength(value).toFloat)
    }}

    val g= GraphUtils.buildWeightedGraphFromTriples(weightedTriples)

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
