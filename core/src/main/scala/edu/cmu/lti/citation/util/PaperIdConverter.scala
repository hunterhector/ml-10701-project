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

    val headPointers = Source.fromFile(paperIdFile).getLines().filterNot(_.trim() == "").map(_.split("-")).zipWithIndex.foldLeft( (HashMap[String,(Int,Int)](),-1)){
      case ((heads,lastTail), (fields,graphIndex)) => {
        val head = fields(0)
        val tailVal = fields(1).toInt

        if (! heads.contains(head)){
          val tailOffset = graphIndex - tailVal
          (heads + (head -> (graphIndex,tailOffset)) , tailVal)
        }else{
          if (!(tailVal == lastTail + 1 || lastTail == -1)){
            LOG.error(String.format("Head is %s, Previous is %s, current is %s",head,tailVal.toString,lastTail.toString))
            throw new Exception("Paper Id tails are not continous.")
          }
          (heads, tailVal)
        }
      }
    }._1

  def toOriginPaperId(graphIndex:Int):String = {
     headPointers.toSeq.sortBy(_._2._1).foreach{
       case((head,(startGraphIndex,tailOffset))) => {
         if (graphIndex > startGraphIndex){
          return head + "-" + (graphIndex - tailOffset)
         }
       }
     }
     "" //return empty string if not found
  }

  def toGraphIndex(originPaperId:String): Int = {
    val fields = originPaperId.split("-")
    val head = fields(0)
    val tail = fields(1)

    val tailOffset = headPointers(head)._2

    tailOffset + tail.toInt
  }
}
