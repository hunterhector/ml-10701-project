package edu.cmu.lti.citation.predict

import edu.cmu.lti.citation.util.PaperIdConverter

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/3/12
 * Time: 2:41 PM
 */
abstract class Predictor {
  def getName = "Abstract Predictor"

  def predict(t: List[(Int, Int, Float)], s: Int, k: Int):List[(Double,Int)]
}
