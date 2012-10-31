package edu.cmu.lti.citation.util

import org.apache.commons.logging.LogFactory
import scala.io.Source
import it.unimi.dsi.webgraph.labelling._
import scala.Predef._
import java.io.File
import java.lang.IllegalArgumentException
import it.unimi.dsi.webgraph.{Transform, ImmutableGraph, BVGraph, ArrayListMutableGraph}
import it.unimi.dsi.webgraph.examples.IntegerTriplesArcLabelledImmutableGraph
import es.yrbcn.graph.weighted._

/**
 * Created with IntelliJ IDEA.
 * User: hector
 * Date: 6/11/12
 * Time: 5:00 PM
 *
 * Methods to access and to store graphs
 *
 * @author hector.liu
 */

/**
 * Class that wrap methods to create or read from WebGraph objects/files
 */
object GraphUtils {
  private val LOG = LogFactory.getLog(this.getClass)

  /**
   * Build from the integer list file an ImmutableGraph
   * @param integerListFile
   * @param numNodes
   * @return An ImmutableGraph
   */
  def buildGraph(integerListFile: File, numNodes: Int): ImmutableGraph = {
    val graph = new ArrayListMutableGraph()
    graph.addNodes(numNodes)
    LOG.debug(String.format("Creating a graph with %s number of nodes", numNodes.toString))

    Source.fromFile(integerListFile).getLines().filterNot(line => line.trim() == "").foreach(
      line => {
        val fields = line.split("\\t")

        if (fields.length == 3) {
          val src = fields(0).toInt
          val target = fields(1).toInt

          try {
            graph.addArc(src, target)
          } catch {
            case illArg: IllegalArgumentException => {
              //LOG.warn(String.format("Duplicate inlinks from %s to %s ignored", fields(0), fields(1)))
            }
          }
          //LOG.info(String.format("Added arc from %s to %s",fields(0),fields(1)))

        } else {
          LOG.error(String.format("Wrong line formatting at: \n -> \t%s Input file should be triple seperated by tabs", line))
        }
      }
    )

    LOG.debug("Done.")
    graph.immutableView()

  }

  /**
   * Build fromt he Integer list file a ArclabelledImmutableGraph, the label actually encode weight of an arc
   * @param integerListFile
   * @return an ArclabelledImmutableGraph representing the weighted graph
   */
  def buildWeightedGraphFromFile(integerListFile: File): ArcLabelledImmutableGraph = {
    LOG.info(String.format("Creating a weigted graph"))

    val weightedArcArray = Source.fromFile(integerListFile).getLines().filterNot(line => line.trim() == "").filter(line => line.split("\t").length >= 3).map(line => new WeightedArc(line)).toArray

    val aig: ArcLabelledImmutableGraph = new WeightedBVGraph(weightedArcArray)

    LOG.info(String.format("Done. Created a weighted Graph with %s nodes", aig.numNodes().toString))

    aig
  }

  /**
   * Build fromt he Integer list file a ArclabelledImmutableGraph, the label actually encode weight of an arc,
   * but it need a parameter to specify number of nodes this graph will have
   * @param integerListFile
   * @param numNodes
   * @return an ArclabelledImmutableGraph representing the weighted graph
   */
  def buildWeightedGraphFromFile(integerListFile: File, numNodes: Int): ArcLabelledImmutableGraph = {
    LOG.info(String.format("Creating a weighted graph"))

    val weightedArcArray = Source.fromFile(integerListFile).getLines().filterNot(line => line.trim() == "").filter(line => line.split("\t").length >= 3).map(line => new WeightedArc(line)).toArray

    val aig: ArcLabelledImmutableGraph = new WeightedBVGraph(weightedArcArray, numNodes)

    LOG.info(String.format("Done. Created a weighted Graph with %s nodes", aig.numNodes().toString))

    aig
  }

  /**
   * Build a weighted graph from triples list,
   * @param triples
   * @return an ArclabelledImmutableGraph representing the weighted graph
   */
  def buildWeightedGraphFromTriples(triples:List[(Int,Int,Float)]): ArcLabelledImmutableGraph = {
    LOG.debug("Creating a weighted graph")

    val weightedArcArray = triples.map(tuple => new WeightedArc(tuple._1,tuple._2,tuple._3)).toArray

    val aig: ArcLabelledImmutableGraph = new WeightedBVGraph(weightedArcArray)

    LOG.debug(String.format("Done. Created a weighted Graph with %s nodes", aig.numNodes().toString))

    aig
  }

  /**
   * Build a weighted graph from triples list,
   * but it need a parameter to specify number of nodes this graph will have
   * @param triples
   * @param numNodes
   * @return an ArclabelledImmutableGraph representing the weighted graph
   */
  def buildWeightedGraphFromTriples(triples:List[(Int,Int,Float)], numNodes:Int): ArcLabelledImmutableGraph = {
    LOG.debug("Creating a weighted graph")

    val weightedArcArray = triples.map(tuple => new WeightedArc(tuple._1,tuple._2,tuple._3)).toArray

    val aig: ArcLabelledImmutableGraph = new WeightedBVGraph(weightedArcArray, numNodes)

    LOG.debug(String.format("Done. Created a weighted Graph with %s nodes", aig.numNodes().toString))

    aig
  }

  def buildArcLabelledGraph(integerListFile: File): ArcLabelledImmutableGraph = {
    LOG.info("Creating an Arc labelled graph")

    val arcArray = Source.fromFile(integerListFile).getLines().filterNot(line => line.trim() == "").filter(line => line.split("\t").length >= 3).map(line => line.split("\t").map(str => str.toFloat.toInt)).toArray

    val alg: ArcLabelledImmutableGraph = new IntegerTriplesArcLabelledImmutableGraph(arcArray)

    LOG.info(String.format("Done. Created a Arc Labelled Graph with %s nodes", alg.numNodes().toString))

    alg
  }

  /**
   * Dump a labelled graph, for debugging purpose
   * @param g The graph to be dumped
   */
  def dumpLabelledGraph(g: ArcLabelledImmutableGraph) {
    LOG.debug("Dumping the labelled graph for debug purposes")

    val nodeIterator: ArcLabelledNodeIterator = g.nodeIterator

    var count = 0
    while (nodeIterator.hasNext) {
      val curr = nodeIterator.nextInt
      val out = nodeIterator.outdegree()
      val suc = nodeIterator.successorArray
      val lab = nodeIterator.labelArray
      (0 to out).foreach(i => LOG.debug(curr + "\t" + suc(i).toString() + "\t" + lab(i).getFloat.toString()))
      count +=1
    }

    LOG.debug(String.format("Finished Dumping %s",count.toString))
  }

  /**
   * Dump a labelled graph, for debugging purpose
   * @param g The graph to be dumped
   */
  def dumpLabelledGraphSuccessorOnly(g: ArcLabelledImmutableGraph) {
    LOG.debug("Dumping the labelled graph for debug purposes")

    val nodeIterator: ArcLabelledNodeIterator = g.nodeIterator

    var count = 0
    while (nodeIterator.hasNext) {
      val curr = nodeIterator.nextInt
      val out = nodeIterator.outdegree()
      val suc = nodeIterator.successorArray
      (0 to out).foreach(i => LOG.debug(curr + "\t" + suc(i).toString()))
      count +=1
    }

    LOG.debug(String.format("Finished Dumping %s",count.toString))
  }


  /**
   * Store the immutable graph as BVGraph
   * @param g The input immutable graph
   * @param path The path to which the graph should be stored
   * @param baseName The basename of the graph to be stored as
   */
  def storeGraph(g: ImmutableGraph, path:String, baseName: String) {
    val fullPath = path + baseName

    LOG.info("Storing Graph to " + fullPath)
    BVGraph.store(g, fullPath + ArcLabelledImmutableGraph.UNDERLYINGGRAPH_SUFFIX)
    LOG.info("Graph generated.")
  }

  /**
   * Store the weighted graph as BVGraph and the labels
   * @param g The weighted graph to be stored
   * @param path The path to which the graph going to be stored
   * @param baseName The base name of the graph to be stored as
   */
  def storeWeightedGraph(g: ArcLabelledImmutableGraph, path: String, baseName: String) {
    val fullPath = path + baseName

    LOG.info("Storing Weighted Graph to " + fullPath)

    LOG.info("Storing Labels")
    BitStreamArcLabelledImmutableGraph.store(g, fullPath, baseName + ArcLabelledImmutableGraph.UNDERLYINGGRAPH_SUFFIX)

    LOG.info("Compressing Graph")
    BVGraph.store(g, fullPath + ArcLabelledImmutableGraph.UNDERLYINGGRAPH_SUFFIX)

    LOG.info("Graph generated.")
  }

  /**
   * Load graph as a BVGraph
   * @param path  path to the graph
   * @param baseName basename of the graph
   * @return the BVGraph
   */
  def loadBVGraph(path:String, baseName: String) = {
    val fullPath = path + baseName

    LOG.info("Loading the Graph from " + fullPath)
    val g = BVGraph.load(fullPath)
    LOG.info("Done.")
    g
  }

  /**
   * Load graph as Immutable graph
   * @param path path to the graph
   * @param baseName basename of the graph
   * @param offline whether to load it on disk (offline) or in memory
   * @return The loaded Immutable graph
   */
  def loadAsImmutable(path:String, baseName:String, offline: Boolean) = {
    val fullPath = path + baseName

    LOG.info("Loading the graph from "+fullPath+" as ImmutableGraph")
    val g = if (offline) ImmutableGraph.loadOffline(fullPath) else ImmutableGraph.load(fullPath)
    LOG.info("Done")
    g
  }


  /**
   * Load graph as Arc labelled Immutable graph
   * @param path path to the graph
   * @param baseName basename of the graph
   * @param offline whether to load it on disk (offline) or in memory
   * @return The loaded Immutable graph
   */
  def loadAsArcLablelled(path:String, baseName:String, offline: Boolean) = {
    val fullPath = path + baseName
    LOG.info("Loading the graph from "+fullPath+" as ArcLablelledGraph")
    val g = if (offline) ArcLabelledImmutableGraph.loadOffline(fullPath) else ArcLabelledImmutableGraph.load(fullPath)
    LOG.info("Done")
    g
  }

  /**
   * Get the transpose graph of a labelled graph
   * @param g The input graph
   * @param batchSize Number of nodes to be loaded into memory at one time.
   * @return
   */
  def transpose(g:ArcLabelledImmutableGraph,batchSize:Int) = {
    LOG.info("Trasposing the graph...")
    val tg = Transform.transposeOffline(g,batchSize)
    LOG.info("Done.")
    tg
  }

  def main(args:Array[String]){
    LOG.info("Testing graph loading")
//    val immutableG = loadAsImmutable("graph/occs/occsGraph",false)
//    println(immutableG.randomAccess())
//    println(immutableG.numNodes())

//    val archG = loadAsArcLablelled("graph/occs/occsGraph",false)
//    val revArchG = Transform.transposeOffline(archG,100000)
//    println(revArchG.randomAccess())
//
//    storeWeightedGraph(revArchG,"/home/hector/Researches/nlp/DBpedia_Spotlight/dbpedia-spotlight/collective/graph/occs/occTransposeGraph")
    val revArchRandomG = loadAsArcLablelled("/home/hector/Researches/nlp/DBpedia_Spotlight/dbpedia-spotlight/collective/graph/occs/","occTransposeGraph",false)
    println(revArchRandomG.randomAccess())
    println(revArchRandomG.numNodes())

    val i2 = revArchRandomG.nodeIterator(159)
    val outdegree = i2.outdegree()
    println(outdegree)
    val labelArr = i2.labelArray()
    val succ = i2.successorArray()
    (0 to outdegree).foreach(i => {
      println (labelArr(i))
      println (succ(i))
    })
  }
}