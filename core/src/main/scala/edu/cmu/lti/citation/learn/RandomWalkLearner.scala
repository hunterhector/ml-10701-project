package edu.cmu.lti.citation.learn

import breeze.linalg._
import edu.cmu.lti.citation.predict.Predictor
import org.apache.commons.logging.LogFactory
import edu.cmu.lti.citation.util.GraphUtils
import edu.cmu.lti.citation.io.AanCitationNetworkReader
import java.io.File

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/18/12
 * Time: 10:02 PM
 */
class RandomWalkLearner (rootFolder:File) {
  private val LOG = LogFactory.getLog(this.getClass)

  private val reader = new AanCitationNetworkReader(rootFolder)

  val x = DenseVector.zeros[Double](5)

  private val sTrain = reader.trainData
  private val citationNetworkContent = reader.getCitationContent

  /**
   * Remove all links from test source
   * @return  Graph without links from test source
   */
  private def buildGraphForTraining() = {
    val tripleList = citationNetworkContent.filterNot(i => {sTrain.contains(i._1)}).toList
    GraphUtils.buildWeightedGraphFromTriples(tripleList)
  }

  def train(predictors:List[Predictor]){
    predictors.foreach {
      p =>
        LOG.info(String.format("Training [%s], please wait...",p.getName))

    }
  }
}
