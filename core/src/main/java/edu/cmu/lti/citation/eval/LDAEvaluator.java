package edu.cmu.lti.citation.eval;

import scala.*;
import scala.Float;
import scala.collection.immutable.List;

import java.io.File;
import java.lang.Double;

/**
 * Created with IntelliJ IDEA.
 * User: Hector, Zhengzhong Liu
 * Date: 11/1/12
 * Time: 12:46 PM
 */
public class LDAEvaluator extends Evaluator {

    public LDAEvaluator(File rootFolder){
      super(rootFolder);
    }


    /**
     *
     * @param t A triple list, every element is a (source paper index, target paper index, weight) triple
     * @param s The source paper index that you want to predict
     * @param k Top k number of paper to be returned
     * @return
     */
      @Override
      public List<Tuple2<Object, Object>> predict(List<Tuple3<Object, Object, Float>> t, int s, int k) {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }
}
