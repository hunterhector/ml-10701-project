The (Chiang, 2000) model had the following additional modifications.
P00-1058
In the BB.N model, as with Model 2 of (Collins, 1997), modifying nonterminals are generated conditioning both on the parent P and its head child H.
P97-1003
During training each example is broken into elementary trees using head rules and argument/adjunct rules similar to those of (Collins, 1997).
P97-1003
Multiple modifier trees can adjoin at the same place, in the spirit of (Schabes and Shieber, 1994).
J94-1004
Model The model of (Chiang, 2000) is based on stochastic TAG (Resnik, 1992; Schabes, 1992).
C92-2065 C92-2066 P00-1058
The BBN model had the following additional modifications: • As with the (Chiang, 2000) model, we similarly lowered the unknown word threshold of the BBN model from its default 5 to 2.
P00-1058
For brevity, we omit the smoothing details of BBN's model (see (Miller et al., 1998) for a complete description); we note that all smoothing weights are computed via the technique described in (Bikel et al., 1997).
A97-1029
The reader will note that the modified BBN model does significantly poorer than (Chiang, 2000) on Chinese.
P00-1058
The success of statistical methods in particular has been quite evident in the area of syntactic parsing, most recently with the outstanding results of (Charniak, 2000) and (Colhns, 2000) on the now-standard English test set of the Penn Treebank (Marcus et al., 1993).
A00-2018 J93-2004
Bikel. 2000.
W00-1320
Unlike Model 2 of (Collins, 1997), they are also generated conditioning on the previously generated modifying nonterminal, L/-1 or Pq-1, and there is no subcat frame or distance feature.
P97-1003
and Modifications We will briefly describe the two parsing models employed (for a full description of the BBN model, see (Miller et al., 1998) and also (Bikel, 2000); for a full description Of the TAG model, see (Chiang, 2000)).
P00-1058 W00-1320
2 of (Collins, 1997) Both parsing models discussed in this paper inherit a great deal from this model, so we briefly describe its "progenitive" features here, describing only how each of the two models of this paper differ in the subsequent two sections.
P97-1003
A different rule is used for extracting auxiliary trees; see (Chiang, 2000) for details.
P00-1058
We have employed two models, one extracted and adapted from BBN's SIFT System (Miller et al., 1998) and a TAGbased parsing model, adapted from (Chiang, 2000).
P00-1058
Ever since the success of HMMs' application to part-of-speech tagging in (Church, 1988), machine learning approaches to natural language processing have steadily become more widespread.
A88-1019
While the BBN model does not perform at the level of Model 2 of (Collins, 1997) on Wall Street Journal text, it is also less language-dependent, eschewing the distance metric (which relied on specific features of the English Treebank) in favor of the "bigrams on nonterminals" model.
P97-1003
See (Chiang, 2000) for more details.
P00-1058
The lexicalized PCFG that sits behind Model 2 of (Collins, 1997) has rules of the form P ~ LnLn-I"'" LIHRI"".Rn-IRn (1) S(will-MD) NP(AppI,~NNP) VP(wilI-MD) NNP I Apple MD VP (buy-VB) VB PRT(out-RP) NP(Microsoft--NNP) I \[ I buy RP NNP I I out Microsoft Figure 1: A sample sentence with parse tree.
P97-1003
