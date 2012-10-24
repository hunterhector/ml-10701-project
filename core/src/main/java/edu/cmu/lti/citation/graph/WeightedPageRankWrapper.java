package edu.cmu.lti.citation.graph;

import es.yrbcn.graph.weighted.WeightedPageRank;
import es.yrbcn.graph.weighted.WeightedPageRankPowerMethod;
import it.unimi.dsi.fastutil.doubles.DoubleList;
import it.unimi.dsi.webgraph.labelling.ArcLabelledImmutableGraph;

import java.io.IOException;

/**
 * Created with IntelliJ IDEA.
 * User: hector
 * Date: 7/1/12
 * Time: 3:00 AM
 */
public class WeightedPageRankWrapper {

    public static double[] run(ArcLabelledImmutableGraph g, double alpha, boolean stronglyPreferential, double threshold, int maxIter, DoubleList start, DoubleList preference) throws IOException {
        WeightedPageRankPowerMethod pr = new WeightedPageRankPowerMethod(g);

        pr.alpha = alpha;
        pr.stronglyPreferential = stronglyPreferential;
        pr.start = start;
        pr.preference = preference;

        WeightedPageRank.NormDeltaStoppingCriterion deltaStop = new WeightedPageRank.NormDeltaStoppingCriterion(threshold);
        WeightedPageRank.IterationNumberStoppingCriterion iterStop = new WeightedPageRank.IterationNumberStoppingCriterion(maxIter);
        WeightedPageRank.StoppingCriterion finalStop = WeightedPageRank.or(deltaStop, iterStop);

        pr.stepUntil(finalStop);
        return pr.rank;
    }
}
