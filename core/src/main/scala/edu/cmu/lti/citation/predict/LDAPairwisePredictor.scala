package edu.cmu.lti.citation.predict

import java.io.File
import io.Source
import edu.cmu.lti.citation.util.PaperIdConverter
import org.apache.commons.logging.LogFactory
import scala.collection.mutable

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/3/12
 * Time: 3:10 PM
 */
class LDAPairwisePredictor(ldaSimFile:File,measure:String, conv:PaperIdConverter) extends Predictor{

  override def getName = "LDA Pairwise Predictor"

  val LOG = LogFactory.getLog(this.getClass)

  val simMapAll = Source.fromFile(ldaSimFile).getLines().filterNot(_.trim()=="").map(_.split("_")).
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

  LOG.debug(String.format("Initialization of [%s] successful",getName))

  def predict(t: List[(Int, Int, Float)], s: Int, k: Int):List[(Double,Int)] = {
    val simWithSource = simMapAll(s)

    val rankedList =

    if (measure == "cosine")
      simWithSource.toList.sortBy(_._2._1).reverse.map(a => (a._2._1,a._1))
    else
      simWithSource.toList.sortBy(_._2._2).map(a => (a._2._1,a._1))

    //rankedList.take(10).foreach(LOG.debug(_))

    if (k>0) rankedList.take(k) else rankedList
  }
}
