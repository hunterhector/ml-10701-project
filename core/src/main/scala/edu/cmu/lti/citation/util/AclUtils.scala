package edu.cmu.lti.citation.util

import java.io.File
import io.Source
import collection.immutable.HashMap

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 10/31/12
 * Time: 4:21 PM
 */
object AclUtils{

  //actually papers we got is from 1965 2011
  def getIdYearMapping(aclMetaDatFile:File):HashMap[String,Int] = {

     //in ubuntu, use this line
//     val idYearMap = Source.fromFile(aclMetaDatFile)(io.Codec("UTF-8")).getLines().foldLeft((HashMap[String,Int](),"")){

    //in mac os, use this line
     val idYearMap = Source.fromFile(aclMetaDatFile).getLines().foldLeft((HashMap[String,Int](),"")){
        case ((m,s),l)=>
        {
          if (l.startsWith("id")){
            val pattern = "\\{.*?\\}".r
            val id = pattern findFirstIn l getOrElse("") replaceAll("\\{|\\}","")
            (m,id)
          }else if (l.startsWith("year")){
            val year = l.slice(8,12)
            (m + (s->year.toInt),year)
          }else (m,s)
        }
     // }._1
      }._1.filter{case(id,year)=>year<=1985}

    idYearMap
  }
}
