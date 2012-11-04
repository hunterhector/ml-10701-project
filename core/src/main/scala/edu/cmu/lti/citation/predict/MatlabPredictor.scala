package edu.cmu.lti.citation.predict

import java.io.{PrintStream, FileOutputStream, File}
import org.apache.commons.logging.LogFactory
import edu.cmu.lti.citation.util.{PaperIdConverter, GraphUtils}
import it.unimi.dsi.webgraph.labelling.ArcLabelledNodeIterator

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/2/12
 * Time: 10:43 PM
 */
class MatlabPredictor (outputFolder:File) extends Predictor{

  private val LOG = LogFactory.getLog(this.getClass)


  /**
   *
   * @param t A triple list, every element is a (source paper index, target paper index, weight) triple
   * @param s The source paper index that you want to predict
   * @param k Top k number of paper to be returned
   * @return
   */
  def predict(t: List[(Int, Int, Float)], s: Int, k: Int, conv:PaperIdConverter) = {
    val f = new File(outputFolder.getCanonicalPath + "/t-matrix")
    toMatrixFile(t,f)
    null
  }

  def toMatrixFile(t: List[(Int, Int, Float)],outputFile:File) = {
    LOG.info("Outputing to matlab matrix")

    val g = GraphUtils.buildWeightedGraphFromTriples(t)

    val nodeNumber = g.numNodes()

    LOG.info(String.format("Will output a %s by %s matrix",nodeNumber.toString,nodeNumber.toString))

    var matrix = Array.ofDim[Double](nodeNumber,nodeNumber)

    val fo = new FileOutputStream(outputFile)
    val foStream = new PrintStream(fo, true)

    val nodeIterator: ArcLabelledNodeIterator = g.nodeIterator

    var count = 0
    while (nodeIterator.hasNext) {
      val curr = nodeIterator.nextInt
      val out = nodeIterator.outdegree()
      //LOG.debug(String.format("Current node is %s, out degree is %s",curr.toString,out.toString))
      val suc = nodeIterator.successorArray
      val lab = nodeIterator.labelArray
      //(0 to out-1).foreach(i => LOG.debug(curr + "\t" + suc(i).toString() + "\t" + lab(i).getFloat.toString()))
      (0 to out-1).foreach(i => matrix(curr)(suc(i)) = lab(i).getDouble/out)
      count +=1
    }

    matrix.foreach(line => foStream.println(line.mkString(",")))

    LOG.info("Done")
  }

}

//object MatlabPredictor {
//  private val LOG = LogFactory.getLog(this.getClass)
//
//  def main(args: Array[String]) {
//    if(args.length != 1) LOG.error("Please locate AAN data release folder  (2011 release preferable).")
//
//    val aanFolder = args(0)
//    val outputFolder = args(1)
//    val me = new MatlabPredictor(new File(aanFolder), new File(outputFolder))
//
//    //ag.prPredictByPaperId("C00-2128",50)
//  }
//}
