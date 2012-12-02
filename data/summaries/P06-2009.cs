and Results We use the standard corpus for this task, the Penn Treebank (Marcus et al., 1993).
J93-2004
In other contexts, this is similar to the approach of (Roth and Yih, 2004) in that scoring each edge depends only on the raw data observed and not on the classi cations of other edges, and that global considerations can be used to overwrite the local (edge-based) decisions.
W04-2401
(Punyakanok et al., 2005; Marciniak and Strube, 2005) also address some aspects of this problem.
W05-0618
The POS tags for the evaluation data sets were provided by the tagger of (Toutanova et al., 2003) (which has an accuracy of 97.2% section 70 23 of the Penn Treebank).
N03-1033
Policy #Shift #Left #Right Start over 156545 26351 27918 Stay 117819 26351 27918 Step back 43374 26351 27918 Table 1: The number of actions required to build all the trees for the sentences in section 23 of Penn Treebank (Marcus et al., 1993) as a function of the focus point placement policy.
J93-2004
E.g., (Roth and Yih, 2004) suggests a model in which global constraints are taken into account in a later stage to x mistakes due to the pipeline.
W04-2401
When evaluating the result, we exclude the punctuation marks, as done in (McDonald et al., 2005) and (Yamada and Matsumoto, 2003).
P05-1012
In the context of DPs, this edge based factorization method was proposed by (Eisner, 1996).
C96-1058
We use the same evaluation metrics as in (McDonald et al., 2005).
P05-1012
Dependency structures are more ef cient to parse (Eisner, 1996) and are believed to be easier to learn, yet they still capture much of the predicate-argument information needed in applications (Haghighi et al., 2005), which is one reason for the recent interest in learning these structures (Eisner, 1996; McDonald et al., 2005; Yamada and Matsumoto, 2003; Nivre and Scholz, 2004).
C04-1010 C96-1058 H05-1049 P05-1012
A somewhat similar approach was used in (Nivre and Scholz, 2004) to develop a hybrid bottom-up/topdown approach; there, the edges are also labeled with semantic types, yielding lower accuracy than the works mentioned above.
C04-1010
(Ratnaparkhi, 1997), in that the classi ers are trained on individual decisions rather than on the overall quality of the parser, and chained to yield the global structure.
W97-0301
(McDonald et al., 2005) build on this work, and use a global discriminative training approach to improve the edges’ scores, along with Eisner’s algorithm, to yield the expected improvement.
P05-1012
