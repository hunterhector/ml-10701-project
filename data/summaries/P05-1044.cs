Work Foremost for future work is the “minimally supervised” paradigm in which a small amount of labeled data is available (see, e.g., Clark et al.(2003)). Unlike well-known “bootstrapping” approaches (Yarowsky, 1995), EM and CE have the possible advantage of maintaining posteriors over hidden labels (or structure) throughout learning; bootstrapping either chooses, for each example, a single label, or remains completely agnostic.
P95-1026 W03-0407
Klein and Manning (2002) argue for CL on grounds of accuracy, but see also Johnson (2001).
P01-1042 W02-1002
Even when they avoid local maxima (e.g., through clever initialization) they typically deviate from human ideas of what the “right” structure is (Merialdo, 1994).
J94-2001
1). joint likelihood (JL) productdisplay i p parenleftBig xi,y∗i | vectorθ parenrightBig conditional likelihood (CL) productdisplay i p parenleftBig y∗i | xi,vectorθ parenrightBig classification accuracy (Juang and Katagiri, 1992) summationdisplay i δ(y∗i, ˆy(xi)) expected classification accuracy (Klein and Manning, 2002) summationdisplay i p parenleftBig y∗i | xi,vectorθ parenrightBig negated boosting loss (Collins, 2000) − summationdisplay i p parenleftBig y∗i | xi,vectorθ parenrightBig−1 margin (Crammer and Singer, 2001) γ s.t. bardbl vectorθbardbl ≤ 1;∀i,∀y negationslash= y∗i, vectorθ · (vectorf(xi,y∗i ) − vectorf(xi,y)) ≥ γ expected local accuracy (Altun et al., 2003) productdisplay i productdisplay j p parenleftBig lscriptj(Y ) = lscriptj(y∗i ) | xi,vectorθ parenrightBig Table 1: Various supervised training criteria.
W02-1002 W03-1019
Because “CRF” implies CL estimation, we use the term “WFSA.” 356 putation, like random sampling (see, e.g., Abney, 1997), will not help to avoid this difficulty; in addition, convergence rates are in general unknown and bounds difficult to prove.
J97-4005
with EM Our experiments are inspired by those in Merialdo (1994); we train a trigram tagger using only unlabeled data, assuming complete knowledge of the tagging dictionary.5 In our experiments, we varied the amount of data available (12K–96K words of WSJ), the heaviness of smoothing, and the estimation criterion.
J94-2001
These gains dwarf the performance of EM on over 1.1M words (66.6% as reported by Smith and Eisner (2004)), even when the latter uses improved search (70.0%).
P04-1062
In future we might wish to apply techniques for avoiding local optima, such as deterministic annealing (Smith and Eisner, 2004).
P04-1062
An alternative is to restrict the neighborhood to the set of observed training examples rather than all possible examples (Riezler, 1999; Johnson et al., 1999; Riezler et al., 2000): productdisplay i bracketleftBigg u parenleftBig xi | vectorθ parenrightBigslashBiggsummationdisplay j u parenleftBig xj | vectorθ parenrightBigbracketrightBigg (8) Viewed as a CE method, this approach (though effective when there are few hypotheses) seems misguided; the objective says to move mass to each example at the expense of all other training examples.
P00-1061 P99-1069
Smith and Jason Eisner Department of Computer Science / Center for Language and Speech Processing Johns Hopkins University, Baltimore, MD 21218 USA {nasmith,jason}@cs.jhu.edu Abstract Conditional random fields (Lafferty et al., 2001) are quite effective at sequence labeling tasks like shallow parsing (Sha and Pereira, 2003) and namedentity extraction (McCallum and Li, 2003).
N03-1028 W03-0430
To compute this, intersect the WFSA and the lattice, obtaining a new acyclic WFSA, and sum the u-scores of all its paths (Eisner, 2002) using a simple dynamic programming algorithm akin to the forward algorithm.
P02-1001
We have shown that for unsupervised sequence modeling, this technique is efficient and drastically outperforms EM; for POS tagging, the gain in accuracy over EM is twice what we would get from ten times as much data and improved search, sticking with EM’s criterion (Smith and Eisner, 2004).
P04-1062
