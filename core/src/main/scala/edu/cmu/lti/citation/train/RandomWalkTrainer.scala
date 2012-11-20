package edu.cmu.lti.citation.train

import breeze.linalg._
import edu.cmu.lti.citation.predict.Predictor
import org.apache.commons.logging.LogFactory
import edu.cmu.lti.citation.util.GraphUtils
import edu.cmu.lti.citation.io.AanCitationNetworkReader
import java.io.File
import collection.mutable
import util.Random

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/18/12
 * Time: 10:02 PM
 */
class RandomWalkTrainer (rootFolder:File) {
  private val LOG = LogFactory.getLog(this.getClass)

  private val reader = new AanCitationNetworkReader(rootFolder)
  private val conv = reader.getConverter

  val x = DenseVector.zeros[Double](5)

  private val sTrain = reader.trainData

  def train(predictors:List[Predictor]){
    //create a test set with golden
    val trainWithGolden = sTrain.foldLeft(List[(Int,List[(Int,Int,Float)],Set[Int])]())((tg,s)=>{
      val t = reader.buildListWithHiddenLinks(s)
      val tripleList = t._1
      val gold = t._2
      val numPreservedLinks = t._3

      if (gold.size !=0 && numPreservedLinks > 0){
        tg ::: List((s,tripleList,gold))   //make sure 2 things: 1)Some links are removed 2)Not all links are removed
      }else{
        tg
      }
    })

    trainWithGolden.foreach{
      case (s,triples,gold) => {     // foreach of these training instances
        LOG.debug("Training from "+conv.fromGraphIndex(s))

      }
    }
  }
}
