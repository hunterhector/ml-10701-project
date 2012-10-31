package edu.cmu.lti.citation.util

import java.io.File
import io.Source
import collection.immutable.HashMap
import org.apache.commons.logging.LogFactory

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 10/23/12
 * Time: 5:23 PM
 */
class PaperIdConverter(rootFolder:File) {
  private val LOG = LogFactory.getLog(this.getClass)

  val paperIdFile = new File(rootFolder.getAbsolutePath + "/" + "paper_ids.txt")

  private val networkFolder = "networks"

  private val citationNetworkFile = new File(rootFolder.getAbsolutePath + "/" + networkFolder + "/" + "paper-citation-network.txt")

  private val lines = Source.fromFile(citationNetworkFile).getLines().toList

 // private val linesWithIndex = Source.fromFile(paperIdFile).getLines().filterNot(_.trim() == "").zipWithIndex.toList


  private val maxIndex = lines.length

  LOG.debug(String.format("Lines read: %s",maxIndex.toString))

  private var indexCount = -1

  //reading the paper id file does not work, let's read the network file directly
  private val paperIdMap = lines.filterNot(_.trim()=="").map(_.split(" ==> ")).
    map(fields => (fields(0),fields(1))).foldLeft((HashMap[String,Int]())){
      case(paperIdMap,(id1,id2)) =>{
         //LOG.debug(String.format("Reading paper id %s %s",id1.toString,id2.toString))
        var p = new HashMap[String,Int]()
        p = paperIdMap

        if (! paperIdMap.contains(id1)){
          p += (id1 -> indexCount)
          indexCount += 1

        }

        if(! paperIdMap.contains(id2)){
          p += (id2 -> indexCount)
          indexCount += 1
        }
        p
      }
  }

  private val graphIdMap = paperIdMap.map(_.swap)


//  //Just use the paper id file as map does not work! The id file is not complete!
//  private val idMaps = linesWithIndex.foldLeft( (HashMap[String,Int](),new Array[String](maxIndex))){
//    case ((paperIdMap,graphIndexArray),(paperId,graphIndex)) =>{
//      LOG.debug(String.format("Reading Paper Id: %s",paperId))
//      graphIndexArray(graphIndex)= paperId
//      (paperIdMap + (paperId -> graphIndex),graphIndexArray)
//    }
//  }

  LOG.debug(String.format("%s or %s paper Id loaded",paperIdMap.size.toString,graphIdMap.size.toString))

  def fromGraphIndex(graphIndex:Int):String = {
    return graphIdMap(graphIndex)
  }

  def toGraphIndex(paperId:String):Int = {
    return paperIdMap(paperId)
  }


//  // I refer the Letter part of the paper id as head, Numeric part as tail, map them seperatedly save space
//    val headPointers = Source.fromFile(paperIdFile).getLines().filterNot(_.trim() == "").map(_.split("-")).zipWithIndex.foldLeft( (HashMap[String,(Int,Int)](),-1)){
//      case ((heads,lastTail), (fields,graphIndex)) => {
//        val head = fields(0)
//        val tailVal = fields(1).toInt
//
//        if (! heads.contains(head)){
//          val tailOffset = graphIndex - tailVal
//          (heads + (head -> (graphIndex,tailOffset)) , tailVal)
//        }
//        else{
//          if (!(tailVal == lastTail + 1 || lastTail == -1)){
//            //LOG.error(String.format("Head is %s, Previous is %s, current is %s",head,tailVal.toString,lastTail.toString))
//            //throw new Exception("Paper Id tails are not continous.")
//            LOG.warn("I think the paper id file is not complete")
//          }
//          (heads, tailVal)
//        }
//      }
//    }._1
//
//  def fromGraphIndex(graphIndex:Int):String = {
//     headPointers.toSeq.sortBy(_._2._1).foreach{
//       case((head,(startGraphIndex,tailOffset))) => {
//         if (graphIndex > startGraphIndex){
//          return head + "-" + (graphIndex - tailOffset)
//         }
//       }
//     }
//     "" //return empty string if not found
//  }
//
//  def toGraphIndex(originPaperId:String): Int = {
//    val fields = originPaperId.split("-")
//    val head = fields(0)
//    val tail = fields(1)
//
//    val tailOffset = headPointers(head)._2
//
//    tailOffset + tail.toInt
//  }
}
