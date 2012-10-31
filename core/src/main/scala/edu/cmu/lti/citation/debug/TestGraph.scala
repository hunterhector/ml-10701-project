package edu.cmu.lti.citation.debug

import edu.cmu.lti.citation.util.GraphUtils

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 10/31/12
 * Time: 12:24 PM
 */
object TestGraph {
      def main(args: Array[String]){
        val tripleList = List((0,1,1.0.toFloat),(1,2,1.0.toFloat),(7,8,1.0.toFloat))

        tripleList.foreach(println)

        val g = GraphUtils.buildWeightedGraphFromTriples(tripleList)

        GraphUtils.dumpLabelledGraph(g)
      }
}
