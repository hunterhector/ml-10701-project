More recently, it has been applied with good results to lexicalized phrase structure parsing by Sagae and Lavie (2005).
W05-1513
History-based models for predicting the next parser action (Black et al., 1992; Magerman, 1995; Ratnaparkhi, 1997; Collins, 1999) 3.
H92-1026 P95-1037 W97-0301
Deterministic parsing algorithms for building dependency graphs (Kudo and Matsumoto, 2002; Yamada and Matsumoto, 2003; Nivre, 2003) 2.
W02-2016
It was first used for unlabeled dependency parsing by Kudo and Matsumoto (2002) (for Japanese) and Yamada and Matsumoto (2003) (for English).
W02-2016
Based on results from previous optimization experiments (Nivre et al., 2004), we use the modified value difference metric (MVDM) to determine distances between instances, and distance-weighted class voting for determining the class of a new instance.
C04-1010 W04-2407
Compared to the state of the art in dependency parsing, the unlabeled attachment scores obtained for Swedish with model Φ5, for both MBL and SVM, are about 1 percentage point higher than the results reported for MBL by Nivre et al.(2004). For the English data, the result for SVM with model Φ5 is about 3 percentage points below the results obtained with the parser of Charniak (2000) and reported by Yamada and Matsumoto (2003).
A00-2018 C04-1010 W04-2407
These parsers can be enhanced by using a discriminative model, which reranks the analyses output by the parser (Johnson et al., 1999; Collins and Duffy, 2005; Charniak and Johnson, 2005).
J05-1003 P05-1022 P99-1069
Support vector machines (SVM), which combine the maximum margin strategy introduced by Vapnik (1995) with the use of kernel functions to map the original feature space to a higher-dimensional space, have been used by Kudo and Matsumoto (2002), Yamada and Matsumoto (2003), and Sagae and Lavie (2005), among others.
W02-2016 W05-1513
Mainstream approaches in statistical parsing are based on nondeterministic parsing techniques, usually employing some kind of dynamic programming, in combination with generative probabilistic models that provide an n-best ranking of the set of candidate analyses derived by the parser (Collins, 1997; Collins, 1999; Charniak, 2000).
A00-2018 P97-1003
It was extended to labeled dependency parsing by Nivre et al.(2004) (for Swedish) and Nivre and Scholz (2004) (for English).
C04-1010 W04-2407
The English data are from the Wall Street Journal section of the Penn Treebank II (Marcus et al., 1994).
H94-1020
Memory-based learning (MBL), which is based on the idea that learning is the simple storage of experiences in memory and that solving a new problem is achieved by reusing solutions from similar previously solved problems (Daelemans and Van den Bosch, 2005), has been used primarily by Nivre et al.(2004), Nivre and Scholz (2004), and Sagae and Lavie (2005).
C04-1010 W04-2407 W05-1513
By using other kernel functions, such as polynomial or radial basis function (RBF), feature vectors are mapped into a higher dimensional space (Vapnik, 1998; Kudo and Matsumoto, 2001).
N01-1025
Cheng et al.(2005b) report that SVM outperforms MaxEnt models in Chinese dependency parsing, using the algorithms of Yamada and Matsumoto (2003) and Nivre (2003), while Sagae and Lavie (2005) find that SVM gives better 316 performance than MBL in a constituency-based shift-reduce parser for English.
I05-3003 W05-1513
Magerman. 1995.
P95-1037
Alternatively, discriminative models can be used to search the complete space of possible parses (Taskar et al., 2004; McDonald et al., 2005).
P05-1012 W04-3201
For Chinese, finally, the accuracy for SVM with model Φ5 is about one percentage point lower than the best reported results, achieved with a deterministic classifier-based approach using SVM and preprocessing to detect root nodes (Cheng et al., 2005a), although these results are not based on exactly the same dependency conversion and data split as ours.
I05-3003
Discriminative learning to map histories to parser actions (Kudo and Matsumoto, 2002; Yamada and Matsumoto, 2003; Nivre et al., 2004) In this section we will define dependency graphs, describe the parsing algorithm used in the experiments and finally explain the extraction of features for the history-based models.
C04-1010 W02-2016 W04-2407
