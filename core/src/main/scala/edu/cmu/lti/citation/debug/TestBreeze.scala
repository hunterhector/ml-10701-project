package edu.cmu.lti.citation.debug

import breeze.linalg._

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/18/12
 * Time: 10:08 PM
 */
object TestBreeze {
  def main(args:Array[String]){
    val x = DenseVector.zeros[Double](5)
    println(x)
  }
}
