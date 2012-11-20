package edu.cmu.lti.citation.predict

import edu.cmu.lti.citation.util.{GraphUtils, PaperIdConverter}
import java.io.File
import io.Source
import edu.cmu.lti.citation.graph.AanCitationGraph
import org.apache.commons.logging.LogFactory

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/3/12
 * Time: 4:06 PM
 */
class LDAWeightedRandomWalkPredictor(ldaNetworkFile:File,measure:String,conv: PaperIdConverter) extends Predictor{
  val LOG = LogFactory.getLog(this.getClass)

  override def getName = "LDA Weighted Random Walk Predictor"

  def predict(t: List[(Int, Int, Float)], s: Int, k: Int) = {
    val simWithSource = Source.fromFile(ldaNetworkFile).getLines().filterNot(_.trim()=="").map(_.split("_")).filter(_.length == 4).
      map(fields => (conv.toGraphIndex(fields(0)),conv.toGraphIndex(fields(1)),fields(2).toFloat,fields(3).toFloat)).toList

    val weightMap = if (measure == "cosine") simWithSource.map(f => ((f._1,f._2),f._3)).toMap else simWithSource.map(f => ((f._1,f._2),1/f._4)).toMap

    //replace weights to LDA weights
    val weightedList = t.map(i =>
      {
        if (weightMap.contains(i._1,i._2)){
          (i._1,i._2,weightMap((i._1,i._2)))
        }else{
          //LOG.warn(String.format("LDA weight file does not contain %s => %s",conv.fromGraphIndex(i._1),conv.fromGraphIndex(i._2)))
          (i._1,i._2,1.0.toFloat)

        }
      }
    )

    val g= GraphUtils.buildWeightedGraphFromTriples(weightedList)

    val fullRankedList = AanCitationGraph.prPredict(g,s,k,0.2)
    fullRankedList.toList
  }
}
