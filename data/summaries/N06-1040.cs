This condition is roughly equivalent to the h = 1,v = 2 in Klein and Manning 314 (2003b)3.
N03-1016 P03-1054
Klein and Manning (2003b) showed that, by making certain linguistically-motivated node label annotations, but avoiding certain other kinds of state splits (mainly lexical annotations) models of relatively high accuracy can be built without resorting to smoothing.
N03-1016 P03-1054
Producing a “coarse” chart as efficiently as possible is thus crucial (Charniak et al., 1998; Blaheta and Charniak, 1999), making these factorizations particularly useful.
P99-1066 W98-1115
niak parser (Charniak, 2000; Charniak and Johnson, 2005) uses a Markov order-3 baseline PCFG in the initial pass, with a best-first algorithm that is run past the first parse to populate the chart for use by the richer model.
A00-2018 P05-1022
We also present a result using parent annotation (Johnson, 1998) with a 2nd-order Markov assumption.
J98-4004
Finally, Section 4 reports the results of parsing experiments using our exhaustive k-best CYK parser with the concise PCFGs induced from the Penn WSJ treebank (Marcus et al., 1993).
J93-2004
We then trained a MaxEnt reranker on sections 2-21, using the approach outlined in Charniak and Johnson (2005), via the publicly available reranking code from that paper.6 We used the default features that come with that package.
P05-1022
While we have demonstrated exhaustive parsing efficiency, our model could be used with any of the efficient search best-first approaches documented in the literature, from those used in the Charniak parser (Charniak et al., 1998; Blaheta and Charniak, 1999) to A∗ parsing (Klein and Manning, 2003a).
N03-1016 P03-1054 P99-1066 W98-1115
One common strategy in statistical parsing is what can be termed an approximate coarse-to-fine approach: a simple PCFG is used to prune the search space to which richer and more complex models are applied subsequently (Charniak, 2000; Charniak and Johnson, 2005).
A00-2018 P05-1022
We used the k-best decoding algorithm of Huang and Chiang (2005) with our CYK parser, using on-demand k-best backpointer calculation.
W05-1506
Probability estimates of the RHS given the LHS are often smoothed by making a Markov assumption regarding the conditional independence of a category on those more than k categories away (Collins, 1997; Charniak, 2000): P(X → Y1...Yn)= P(Y1|X) nY i=2 P(Yi|X,Y1 ···Yi−1) ≈ P(Y1|X) nY i=2 P(Yi|X,Yi−k ···Yi−1).
A00-2018 P97-1003
Even with special modifications to the basic CYK algorithm, such as those presented by Eisner and Satta (1999), improvements to the stochastic model are obtained at the expense of efficiency.
P99-1059
For example, the parent of the left-hand side (LHS) can be annotated onto the label of the LHS category (Johnson, 1998), hence differentiating, for instance, between expansions of a VP with parent S and parent VP.
J98-4004
perceptron-trained tagger, using the tagger documented in Hollingshead et al.(2005). The number of tagger candidates k for all trials reported in this paper was 0.2n, where n is the length of the string.
H05-1099
Johnson. 1998.
J98-4004
