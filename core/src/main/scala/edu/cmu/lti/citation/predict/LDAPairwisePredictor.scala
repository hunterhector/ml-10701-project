package edu.cmu.lti.citation.predict

import java.io.File
import io.Source
import edu.cmu.lti.citation.util.PaperIdConverter

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/3/12
 * Time: 3:10 PM
 */
class LDAPairwisePredictor(ldaSimFile:File,measure:String) extends Predictor{

  override def getName = "LDA Pairwise Predictor"

  def predict(t: List[(Int, Int, Float)], s: Int, k: Int, conv:PaperIdConverter):List[(Double,Int)] = {
    val simWithSource = Source.fromFile(ldaSimFile).getLines().filterNot(_.trim()=="").map(_.split("_")).filter(_.length == 4).
      map(fields => (conv.toGraphIndex(fields(0)),conv.toGraphIndex(fields(1)),fields(2).toDouble,fields(3).toDouble)).filter(fields => fields._1 == s).toList

    val rankedList =

    if (measure == "cosine")
      simWithSource.sortBy(_._3).reverse.map(fields => (fields._3,fields._1))
    else
      simWithSource.sortBy(_._4).map(fields => (fields._4,fields._1))

    rankedList
  }
}
