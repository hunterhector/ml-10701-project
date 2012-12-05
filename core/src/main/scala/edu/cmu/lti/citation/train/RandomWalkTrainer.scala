package edu.cmu.lti.citation.train

import breeze.linalg._
import org.apache.commons.logging.LogFactory
import edu.cmu.lti.citation.util.GraphUtils
import edu.cmu.lti.citation.io.AanCitationNetworkReader
import java.io.File
import util.Random
import io.Source
import collection.immutable.HashMap
import it.unimi.dsi.webgraph.labelling.{ArcLabelledImmutableGraph, ArcLabelledNodeIterator}
import breeze.optimize.{DiffFunction, LBFGS}

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/18/12
 * Time: 10:02 PM
 */
class RandomWalkTrainer (rootFolder:File, featureFile:File) {
  private val LOG = LogFactory.getLog(this.getClass)

  //The follwoing is a few tunable stuff
  private val trainRatio = 50  //the ratio of L/D, this is tunable
  private val restartAlpha = 0.2 //restart probability to the source node
  private val restartBeta = 0.8 //restart probability for the jumping to topical groups
  private val maxIter = 1000; //iteration for calculating derivative \partial p/ \partial w
  private val lambda = 1; //lambda for regulization
  private val wmwLossB = 0.5;//a parameter for WMW loss

  //The following could be changed, but actually not worth tuning
  private val derStop = 10e-12            //stopping criteria
  private val ptderStopRatio = 0.1          //the value of those are really small.....so use ratio, but 0.1 could be a little bit high

  LOG.info("Reading AAN data...")
  private val reader = new AanCitationNetworkReader(rootFolder)
  private val conv = reader.getConverter

  LOG.info(String.format("%s training sources and %s training candidates prepared",reader.trainSource.size.toString,reader.trainCandidates.size.toString))

  LOG.info("Reading feature files...")

  private val featuresLines = Source.fromFile(featureFile).getLines().toList

  private val numSamples = featuresLines.length - 1   //first line is table header
  private val numFeatures = featuresLines(0).split(",").length - 2

  private val initialW = DenseVector.zeros[Double](numFeatures)    //initialize by unweighted random walk (so all zero)

  private val featureMap = featuresLines.slice(1,numSamples+1).foldLeft(HashMap[(Int,Int),DenseVector[Double]]()){
    case (m,l) =>{
      val fields = l.split(",")
      if (conv.containsPaper(fields(0)) && conv.containsPaper(fields(1))){
        val from = conv.toGraphIndex(fields(0))
        val to = conv.toGraphIndex(fields(1))
        val features = new DenseVector(fields.slice(2,fields.length).map(_.toDouble).toArray)
        m + ((from,to)->features)
      }else{
        m
      }
    }
  }

  LOG.info(String.format("Feature files read, %s samples, each with %s features",numSamples.toString,numFeatures.toString))

  def logistic(x:Double) ={
    1/(1 + math.exp(-x))
  }

  def edgeValue(f:DenseVector[Double],w:DenseVector[Double]):Double ={
    if (f.length != w.length)  LOG.error(String.format("Feature length is %s, but W length is %s.",f.length.toString,w.length.toString))
    f.dot(w)
  }

  def edgeFeature(from:Int,to:Int):DenseVector[Double] ={
    if (featureMap.contains((from,to))){
      featureMap((from,to))
    }else{
      LOG.error(String.format("Feature between %s -> %s not found!",conv.fromGraphIndex(from),conv.fromGraphIndex(to)))
      throw new Exception("Feature not found!")      // now i want to make sure everything matches, in real experiment we'd better comment it.
    }
  }

  def edgeStrength(x:Double):Double = {
    logistic(x)
  }

  def edgeStrengthDer(x:Double):Double = {
    logistic(x)*(1-logistic(x))
  }

  def loss(x:Double):Double = {
    1/(1 + math.exp(-x/wmwLossB))
  }

  def lossDer(x:Double):Double = {
    (1/wmwLossB * math.exp(-x/wmwLossB))/math.pow(1+math.exp(-x/wmwLossB),2)
  }

  def checkStochastic(m:DenseMatrix[Double]) {
    (0 to m.rows-1).foreach(
      i => {
        val a = m(i,::)
        if (math.abs(a.sum -1) > 1e-10 ) throw new Exception(conv.fromGraphIndex(i))
        //LOG.debug(String.format("Checking row sum of transition matrix: %s",a.sum.toString))
      }
    )
  }

  def powerDerivative(Q:DenseMatrix[Double],arcWeights:DenseMatrix[Double],wtder:Array[DenseMatrix[Double]],numOfFeatures:Int) = {
    LOG.debug("Using power derivative to calculate d(p/w)")
    val dim = Q.rows

    //eigen vector for each iter
    val pt = Array.fill(maxIter+1){DenseVector.fill[Double](dim)(1.0/dim).t}

    LOG.debug("Doing Pagerank iterations:")

    var delta = 1.0
    var t = 0
    //doing pagerank power
    while(delta > derStop && t < maxIter){
      pt(t+1) = pt(t)*Q
      val diffV = (pt(t+1) - pt(t)).t
      delta = diffV(::,0).norm(2)
      LOG.debug(String.format("iter = %s, delta = %s",t.toString,delta.toString))
      t += 1
    }
    LOG.debug("Output the eigen vector for this calculation")
    LOG.debug(pt(t-1))

    // then start to the derivatives

    //derivatives
    val pdelt = Array.fill(maxIter+1){DenseMatrix.zeros[Double](numOfFeatures,dim)}

    val wtsum = DenseVector.zeros[Double](dim)
    val wtsumsq  = DenseVector.zeros[Double](dim)

    // LOG.debug("Doing wtsum")
    (0 to arcWeights.rows -1).foreach(i => {
      wtsum(i) = arcWeights(i,::).sum
      wtsumsq(i) = wtsum(i)*wtsum(i)
      //   LOG.debug("wtsum: "+wtsum(i)+" wtsumsq: "+wtsumsq(i))
    })

    val dwtSum = DenseMatrix.zeros[Double](numOfFeatures,dim)


    // LOG.debug("Dong wtder")
    //    wtder.foreach{
    //      LOG.debug(_)
    //    }

    // LOG.debug("Doing dwtSum")
    (0 to numOfFeatures-1).foreach(i =>{
      (0 to dim-1).foreach(j=>{
        var sm = 0.0
        (0 to dim-1).foreach(l => {
          //      LOG.debug("Adding "+ sm + " by "+wtder(i)(j,l))
          sm = sm + wtder(i)(j,l)
        })
        dwtSum(i,j) = sm
      })
    })

    // LOG.debug(dwtSum)

    var delQ = Array.fill(numOfFeatures){DenseMatrix.zeros[Double](dim,dim)}

    // LOG.debug("Doing delQ")
    (0 to dim-1).foreach(j => {
      (0 to dim-1).foreach(k => {
        if (arcWeights(j,k) != 0){
          (0 to numOfFeatures-1).foreach(i => {
            val sm = wtder(i)(j,k)*wtsum(j)
            val sm1 = arcWeights(j,k)*dwtSum(i,j)
            val term1 = sm - sm1
            delQ(i)(j,k) = (1-restartAlpha)*term1/wtsumsq(j)
            if (delQ(i)(j,k).isNaN) {
              LOG.info("arcWeights(j,k) is "+arcWeights(j,k))
              LOG.error(String.format("Del Q calcuation by (1-%s)*%s/%s",restartAlpha.toString,term1.toString,wtsumsq(j).toString))
              throw new Exception("Get a NaN")
            }
          })
        }else{
          (0 to numOfFeatures-1).foreach(i => {   //so when arcWeights_{j,k} is 0, it is does not depend on w so derivative should also be 0
            delQ(i)(j,k) = 0
          })
        }
      })
    })

    //    delQ.foreach(
    //      LOG.debug(_)
    //    )

    LOG.debug("Doing derivative iterations:")


    (0 to numOfFeatures-1).foreach(k =>{
      LOG.debug("Doing feature "+k)
      var ratio = 1.0
      t = 0
      while (ratio > ptderStopRatio && t < maxIter){
        (0 to dim-1).foreach(j =>{
          var prod = 0.0
          (0 to dim-1).foreach( l =>{
            prod += pdelt(t)(k,j) * Q(j,l) + pt(t)(0,j)*delQ(k)(j,l)
            if (pdelt(t)(k,j).isNaN)  {
              LOG.error(String.format("Get a NaN bcuz pdelt(%s)(%s,%s)",t.toString,k.toString,j.toString))
              throw new Exception("Get a NaN")
            }
            if (Q(j,l).isNaN)  {
              LOG.error(String.format("Get a NaN at Q(%s,%s)",j.toString,l.toString))
              throw new Exception("Get a NaN")
            }
            if (pt(t)(0,j).isNaN)  {
              LOG.error(String.format("Get a NaN at pt(%s)(%s,%s)",t.toString,0.toString,j.toString))
              throw new Exception("Get a NaN")
            }
            if (delQ(k)(j,l).isNaN)  {
              LOG.error(String.format("Get a NaN at delQ(%s)(%s,%s)",k.toString,j.toString,l.toString))
              throw new Exception("Get a NaN")
            }
            //LOG.debug(String.format("Doing %s*%s+%s*%s",pdelt(t)(k,j).toString, Q(j,l).toString, pt(t)(0,j).toString,delQ(k)(j,l).toString))
          })
          pdelt(t+1)(k,j) = prod
          //LOG.debug("Result is: "+prod)
        })
        //LOG.debug(String.format("So new derivative sums to : %s",pdelt(t+1)(k,::).sum.toString))
        //LOG.debug(String.format("Previous derivative: %s, current derivative: %s",pdelt(t)(k,::),pdelt(t+1)(k,::)))
        val lastDer = pdelt(t)(k,::).t
        val newDer = pdelt(t+1)(k,::).t
        val diffV = newDer - lastDer
        //val diffV = (pdelt(t+1)(k,::) - pdelt(t)(k,::)).t
        //LOG.debug(String.format("Diff is: %s",diffV))
        delta = diffV(::,0).norm(2)
        val lastNorm = lastDer(::,0).norm(2)
        ratio = if(lastNorm == 0) 1 else delta/lastNorm   //beware of the 1st iteration, previous is zero
        LOG.debug(String.format("iter = %s, delta = %s, ratio = %s",t.toString, (delta).toString, ratio.toString))
        t += 1
      }
    })

    //try to free memory
    delQ = null
    //LOG.debug("Output the partial p/w for this calculation")
    //LOG.debug(pdelt(t-1))
    pdelt(t-1)
  }

  def train() = {
    LOG.info("Training... this may take... well...")

    val f = new DiffFunction[DenseVector[Double]] {
      def calculate(w:DenseVector[Double]) = {
        //do training for each source paper, we use the sum of the source papers at objective so that we got things

        //fwSum for the sum of all F(w) over all s
        //fwDersum for the sum of all /partial F(w) over all s
        var sourceCount = 1
        val res = reader.trainSource.foldLeft(0.0,DenseVector.zeros[Double](w.length)){case((fwSum,fwDerSum),s)  =>{
          //get an incomplete graph and the golden standard
          val t = reader.buildListWithHiddenLinks(s)
          val tripleList = t._1
          val gold = t._2
          val numPreservedLinks = t._3

          if (gold.size !=0 && numPreservedLinks > 0){ //require there should be some links removed but not all
            LOG.debug("Calculating training statistics from "+conv.fromGraphIndex(s)+" , node number is "+s)
            LOG.debug(String.format("This is the %s paper of totally %s papers",sourceCount.toString,reader.trainSource.size.toString))
            sourceCount += 1

            val setC = reader.trainCandidates -- gold  //set of all incorrect candidates
            val setD = gold    //set of true desitinations

            val lSize = setD.size * trainRatio // number of negative candidates to use
            val pPick = lSize.toFloat / setC.size //probability to take one element from set C

            //a better idea than random is probabily choose by some criteria, haven't think of any
            val setL = setC.filter(c =>{(Random.nextFloat() < pPick)})  //pick approximately lSize number of negative data points from C

            def cartesian(acc:Set[Int], set:Set[Int]) = for (a <- acc; s <- set) yield {
              (a,s)
            }

            val trainingInstances = cartesian(setL,setD)

            LOG.debug(String.format("Set D size: %s, set L size: %s, # instances pairs: %s",setD.size.toString, setL.size.toString ,trainingInstances.size.toString) )

            //build the graph and start to compute the stat
            val g = GraphUtils.buildWeightedGraphFromTriples(tripleList)

            val nodeNum = g.numNodes()

            val R = DenseMatrix.zeros[Double](nodeNum,nodeNum)
            R(::,s) := DenseVector.fill[Double](nodeNum)(restartAlpha) // R = \alpha 1(v=s)

            LOG.debug("Try allocate so many matrices")
            var Q =  DenseMatrix.zeros[Double](nodeNum,nodeNum)
            LOG.debug("Main Trainsition Matrix...")
            var arcWeights = DenseMatrix.zeros[Double](nodeNum,nodeNum)
            LOG.debug("Arc Weights")
            //val arcWeightsDer = DenseMatrix.zeros[Double](nodeNum,nodeNum)
            //LOG.debug("Arc Weights Derivatives")
            var wtder = Array.fill(numFeatures){DenseMatrix.zeros[Double](nodeNum,nodeNum)}
            LOG.debug("Final Derivatives")

            LOG.debug("Wow, we get the matrices")
            //checkStochastic(Q)

            LOG.debug("Preparing matrix statistics for derivatives calculation")

            val nodeIterator: ArcLabelledNodeIterator = g.nodeIterator

            while (nodeIterator.hasNext) {
              val curr = nodeIterator.nextInt
              val out = nodeIterator.outdegree()
              val suc = nodeIterator.successorArray
              //val lab = nodeIterator.labelArray
              var nor = 0.0

              //if (out == 0) throw new Exception(String.format("Got zero outdegree for: %s",conv.fromGraphIndex(curr)))

              (0 to out-1).foreach(i =>
              {
                val feature = edgeFeature(curr,suc(i))
//                LOG.debug(curr+" "+suc(i))
//                LOG.debug(feature)
//                LOG.debug(w)
                val value = edgeValue(feature,w)

                val strength = edgeStrength(value)
                val strengthDer = edgeStrengthDer(value)
                nor += strength
                Q(curr,suc(i)) = strength
                arcWeights(curr,suc(i))=strength
                //arcWeightsDer(curr,suc(i))=strengthDer

                var j = 0
                feature.foreach(v =>{
                  wtder(j)(curr,suc(i)) = strengthDer*feature(j)
                  j += 1
                })
              })

              (0 to out-1).foreach(j =>
              {
                Q(curr,suc(j)) *= ((1-restartAlpha)/nor)     //Q =  (1- \alpha) Q^'
              })

            }

            Q += R  // Q = (1- \alpha) Q^' + \alpha 1(v=s)

            //checkStochastic(Q)  //make sure rows sum to 1
            //now there are some row sum is only alpha, which are actually papers that have zero outdegrees, hope that won't be a problem
            LOG.debug("Matrices prepared.")

            //now comes to the hard part
            //start to do the computation on the derivatives
            val dpw = powerDerivative(Q,arcWeights,wtder,numFeatures)

            //gather the small derivative from all different training instances
            val hLossDer = trainingInstances.foldLeft(DenseVector.zeros[Double](w.length)){
              case (wDer,(l,d)) =>{
                val pl = Q(s,l)
                val pd = Q(s,d)
                val dLoss = lossDer(pl - pd)     //\partial h / \partial \sigma

                val dpwDiff =  dpw(::,l) - dpw(::,l)
                dpwDiff.foreachValue(x => x*dLoss)

                dpwDiff
              }
            }

            //this is the derivative for the L2 norm
            val w2 = DenseVector(Array.tabulate[Double](w.length)(i=>{w(i)*2}))

            //the F(w) value for each, this is easy to compute
            val hLoss = trainingInstances.foldLeft(0.0){
              case (lossSum,(l,d))=>{
                lossSum + loss(Q(s,l) - Q(s,d))
              }
            }
            val fw = w.norm(2) + lambda*hLoss

            //sum the up with the previous derivatives then we are done
            val currentDerivative = (fwSum+fw,fwDerSum + w2 + hLossDer)

            LOG.debug("Done with this paper! Will you free some memory?")
            //maybe free some memory please?
            Q = null
            arcWeights = null

            currentDerivative
          }else{ //when not fullfilled the requirement, it means this will not be used for training, so simply ignore it
            (fwSum,fwDerSum)
          }
        }}
        res
      }
    }

    val lbfgs = new LBFGS[DenseVector[Double]](maxIter=maxIter,m=3)  //m from 3 to 7, the larger m, the more memory
    val w = initialW
    val trainedW = lbfgs.minimize(f,w)

    LOG.info("After training, W is : "+trainedW)

    trainedW
  }
}

object RandomWalkTrainer {
  val LOG = LogFactory.getLog(this.getClass)

  def main(args:Array[String]){

    if(args.length != 2) LOG.error("Please locate AAN data release folder and the feature file")

    val aanFolder = args(0)

    val featureFile = args(1)

    val modelFile = new File("../output/wModel")
    val out = new java.io.FileWriter(modelFile)

    val trainer = new RandomWalkTrainer(new File(aanFolder),new File(featureFile))
    val w = trainer.train()

    w.foreach(v => out.write(v.toString+" "))
//
//    val Q = DenseMatrix.zeros[Double](2,2)
//    Q(0,0) = 0.4
//    Q(0,1) = 0.6
//    Q(1,0) = 0.2
//    Q(1,1) = 0.8
//
//    val arcWeights = DenseMatrix.zeros[Double](2,2)
//   arcWeights(0,0) = 0.49
//   arcWeights(0,1) = 0.5349
//   arcWeights(1,0) = 0.5769
//   arcWeights(1,1) = 0.5449
//
//    val arcWeightsDer = DenseMatrix.zeros[Double](2,2)
//
//   arcWeightsDer(0,0) =  0.2499
//   arcWeightsDer(0,1) = 0.2488
//   arcWeightsDer(1,0) = 0.2441
//    arcWeightsDer(1,1) = 0.2480
//
//    val wtder = Array.fill(3){DenseMatrix.zeros[Double](2,2)}
//   wtder(0)(0,0) = -0.025
//   wtder(0)(0,1) = 0.0746
//   wtder(0)(1,0) = 0.0488
//   wtder(0)(1,1) = 0.0248
//
//   wtder(1)(0,0) = 0.05
//   wtder(1)(0,1) = 0.0498
//   wtder(1)(1,0) = 0.0976
//   wtder(1)(1,1) = 0.124
//
//    wtder(2)(0,0) = -0.025
//    wtder(2)(0,1) = 0.0249
//    wtder(2)(1,0) = 0.0732
//    wtder(2)(1,1) = 0.0248
//
//    trainer.powerDerivative(Q,arcWeights,arcWeightsDer,wtder,3)
  }
}
