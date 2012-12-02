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
class PaperIdConverter(citationNetworkFile:File,id2yearMap:HashMap[String,Int]) {
  private val LOG = LogFactory.getLog(this.getClass)

  private var indexCount = 0

  private val paperIdMap = Source.fromFile(citationNetworkFile).getLines().filterNot(_.trim()=="").map(_.split(" ==> ")).
    filter(fields => (id2yearMap.contains(fields(0)) && id2yearMap.contains(fields(1)))).
    map(fields => (fields(0),fields(1))).foldLeft((HashMap[String,Int]())){
      case(idMap,(id1,id2)) =>{
         //LOG.debug(String.format("Reading paper id %s %s",id1.toString,id2.toString))
        var p = new HashMap[String,Int]()
        p = idMap

        if (! idMap.contains(id1)){
          p += (id1 -> indexCount)
          indexCount += 1

        }

        if(! idMap.contains(id2)){
          p += (id2 -> indexCount)
          indexCount += 1
        }
        p
      }
  }

  private val graphIdMap = paperIdMap.map(_.swap)

  LOG.debug(String.format("From the network file and metadata, %s or %s paper Id loaded",paperIdMap.size.toString,graphIdMap.size.toString))

  def getNumberOfPaper:Int ={
    paperIdMap.size
  }

  def containsPaper(paperId:String):Boolean = {
    paperIdMap.contains(paperId)
  }

  def fromGraphIndex(graphIndex:Int):String = {
    graphIdMap(graphIndex)
  }

  def toGraphIndex(paperId:String):Int = {
    paperIdMap(paperId)
  }

}
