package edu.cmu.lti.citation.graph

import edu.cmu.lti.citation.util.{GraphUtils, PaperIdConverter}
import org.apache.commons.logging.LogFactory
import java.io.File
import io.Source
import it.unimi.dsi.webgraph.labelling.ArcLabelledImmutableGraph
import es.yrbcn.graph.weighted.WeightedPageRank
import it.unimi.dsi.fastutil.doubles.DoubleArrayList

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 10/23/12
 * Time: 4:37 PM
 */
class AanGraph (rootFolder:File) {
    val LOG = LogFactory.getLog(this.getClass)
    val networkFolder = "networks"
    val paperIdFile = new File(rootFolder.getAbsolutePath + "/" + "paper_ids.txt")
    val citationNetworkFile = new File(rootFolder.getAbsolutePath + "/" + networkFolder + "/" + "paper-citation-network.txt")

  if (! isValid) {
    throw new IllegalArgumentException("Should use the AAN 2011 release folder as input!")
  }

  private def buildGraph() = {
    val conv = new PaperIdConverter(rootFolder)
    val tripleList = Source.fromFile(citationNetworkFile).getLines().filterNot(_.trim()=="").map(_.split(" ==> ")).map(fields => ((conv.toGraphIndex(fields(0)),conv.toGraphIndex(fields(1)),1.0.toFloat))).toList
    GraphUtils.buildWeightedGraphFromTriples(tripleList)

  }

  def predict(targetIndex:Int) {
    val graph = buildGraph()
    runPageRankWithRestart(graph,targetIndex)
  }

  /**
   * make the vector Stochastic (L1 norm equal to 1) so that the WeightedPageRank method will accept it
   *
   *
   * @param vector the initial vector
   * @return the resulted stochatic vector
   */
  private def makeStochastic(vector:DoubleArrayList):DoubleArrayList = {
    val l1Sum = l1Norm(vector)
    if (l1Sum == 0) return vector //if the l1 norm is 0 than actually it can't be stochastic. It will be simply returned

    (0 to vector.size-1)foreach(idx => {
      val ori = vector.get(idx)
      vector.set(idx,ori/l1Sum)
    })
    vector
  }

  /**
   * Calculate the L1Norm (sum of the abs of value in the list)
   * @param a The list to be examined
   * @return
   */
  private def l1Norm (a: DoubleArrayList): Double ={
    a.toDoubleArray.foldLeft(0.0)((norm,v)=>{
      norm + math.abs(v)
    })
  }


  private def runPageRankWithRestart(g: ArcLabelledImmutableGraph, restartIndex: Int) : Array[Double] = {
    LOG.debug("Preparing page rank...")

    val nodeNumber = g.numNodes()

    val uniformArray = Array.fill[Double](nodeNumber)(1/nodeNumber)       //actually already stochastic

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

  def isValid : Boolean = {
    if (! rootFolder.isDirectory)  return false

    if (! paperIdFile.exists())    return false

    if (! citationNetworkFile.exists()) return false

    true
  }

  def main(args: Array[String]){
    if(args.length != 1) LOG.error("Please specify the AAN data folder.")

    val aanFolder = args(0)
    val ag = new AanGraph(new File(aanFolder))

    ag.predict(0)
  }

}
