This is essentially the difference between deterministic LR parsing (Knuth, 1965) and Generalized-LR parsing (Tomita, 1987; Tomita, 1990).
C90-1012 J87-1004
Tsuruoka and Tsujii (2005) developed a classifier-based parser that uses the chunk-parsing algorithm and achieves extremely high parsing speed, but somewhat low recall.
W05-1514
The previous parser action applied to the current parser state Figure 1: Features used for classification, with features 1 to 13 taken from Sagae and Lavie (2005).
W05-1513
The parser of Tsuruoka and Tsujii (Tsuruoka and Tsujii, 2005) has comparable speed, but we obtain more accurate results.
W05-1514
c©2006 Association for Computational Linguistics A Best-First Probabilistic Shift-Reduce Parser Kenji Sagae and Alon Lavie Language Technologies Institute Carnegie Mellon University Pittsburgh, PA 15213 {sagae,alavie}@cs.cmu.edu Abstract Recently proposed deterministic classifierbased parsers (Nivre and Scholz, 2004; Sagae and Lavie, 2005; Yamada and Matsumoto, 2003) offer attractive alternatives to generative statistical parsers.
C04-1010 W05-1513
A probabilistic shiftreduce LR-like model, such as the one used in our parser, is different in many ways from a lexicalized PCFG-like model (using markov a grammar), such as those used in the Collins (1999) and Charniak (2000) parsers.
A00-2018
Some of the more popular and more accurate of these approaches to data-driven parsing (Charniak, 2000; Collins, 1997; Klein and Manning, 2002) have been based on generative models that are closely related to probabilistic contextfree grammars.
A00-2018 P97-1003
While this assumption was shown to be true for the parser of Tsuruoka and Tsujii (2005), only a moderate improvement resulted from the addition of a non-greedy search strategy, and overall parser accuracy was still well below that of state-of-the-art statistical parsers.
W05-1514
Shift-Reduce Algorithm for Deterministic Constituent Parsing In its deterministic form, our parsing algorithm is the same single-pass shift-reduce algorithm as the one used in the classifer-based parser of Sagae and Lavie (2005).
W05-1513
We tested this hypothesis by using the Charniak (2000) parser in n-best mode, producing the top 10 trees with corresponding probabilities.
A00-2018
In the probabilistic LR model, probabilities are assigned to tree 696 Precision Recall F-score Time (min) Best-First Classifier-Based (this paper) 88.1 87.8 87.9 17 Deterministic (MaxEnt) (this paper) 85.4 84.8 85.1 < 1 Charniak & Johnson (2005) 91.3 90.6 91.0 Unk Bod (2003) 90.8 90.7 90.7 145* Charniak (2000) 89.5 89.6 89.5 23 Collins (1999) 88.3 88.1 88.2 39 Ratnaparkhi (1997) 87.5 86.3 86.9 Unk Tsuruoka & Tsujii (2005): deterministic 86.5 81.2 83.8 < 1* Tsuruoka & Tsujii (2005): search 86.8 85.0 85.9 2* Sagae & Lavie (2005) 86.0 86.1 86.0 11* Table 1: Summary of results on labeled precision and recall of constituents, and time required to parse the test set.
A00-2018 E03-1005 P05-1022 P97-1003 W05-1513 W05-1514 W97-0301
Training the maximum entropy classifier with such a large number (1.9 million) of training instances and features required more memory than was available (the maximum training set size we were able to train with 2GB of RAM was about 200,000 instances), so we employed the training set splitting idea used by Yamada and Matsumoto (2003) and Sagae and Lavie (2005).
W05-1513
This binarization process is similar to the one described in (Charniak et al., 1998).
W98-1115
We evaluated our classifier-based best-first parser on the Wall Street Journal corpus of the Penn Treebank (Marcus et al., 1993) using the standard split: sections 2-21 were used for training, section 22 was used for development and tuning of parameters and features, and section 23 was used for testing.
J93-2004
This work has led to the development of deterministic parsers for constituent structures as well (Sagae and Lavie, 2005; Tsuruoka and Tsujii, 2005).
W05-1513 W05-1514
These results are at the same level of accuracy as those obtained with other state-of-the-art statistical parsers, although still well below the best published results for this test set (Bod, 2003; Charniak and Johnson, 2005).
E03-1005 P05-1022
More interestingly, it parses all 2,416 sentences (more than 50,000 words) in only 46 seconds, 10 times faster than the deterministic SVM parser of Sagae and Lavie (2005).
W05-1513
Furthermore, a simple combination of the shift-reduce parsing model with an existing generative parsing model produces results with accuracy that surpasses any that of any single (nonreranked) parser tested on the WSJ Penn Treebank, and comes close to the best results obtained with discriminative reranking (Charniak and John691 son, 2005).
P05-1022
That algorithm, in turn, is similar to the dependency parsing algorithm of Nivre and Scholz (2004), but it builds a constituent tree and a dependency tree simultaneously.
C04-1010
Sagae and Lavie (2005) built two deterministic parsers this way, one using support vector machines, and one using k-nearest neighbors.
W05-1513
However, evaluations on the widely used WSJ corpus of the Penn Treebank (Marcus et al., 1993) show that the accuracy of these parsers still lags behind the state-of-theart.
J93-2004
Recently, classifier-based dependency parsing (Nivre and Scholz, 2004; Yamada and Matsumoto, 2003) has showed that deterministic parsers are capable of high levels of accuracy, despite great simplicity.
C04-1010
We present a statistical parser that is based on a shift-reduce algorithm, like the parsers of Sagae and Lavie (2005) and Nivre and Scholz (2004), but performs a best-first search instead of pursuing a single analysis path in deterministic fashion.
C04-1010 W05-1513
Finally, our parser is in many ways similar to the parser of Ratnaparkhi (1997).
W97-0301
Sagae and Lavie’s parsing algorithm is similar to the one used by Nivre and Scholz (2004) for deterministic dependency parsing (using kNN).
C04-1010
Description Our parser uses an extended version of the basic bottom-up shift-reduce algorithm for constituent structures used in Sagae and Lavie’s (2005) deterministic parser.
W05-1513
Work As mentioned in section 2, our parsing approach can be seen as an extension of the approach of Sagae and Lavie (2005).
W05-1513
One such approach is maximum entropy classification (Berger et al., 1996), which we use in the form of a library implemented by Tsuruoka1 and used in his classifier-based parser (Tsuruoka and Tsujii, 2005).
J96-1002 W05-1514
For comparison, Sagae and Lavie (2005) report that training support vector machines for one-against-all multi-class classification on the same set of features for their deterministic parser took 62 hours, and training a k-nearest neighbors classifier took 11 minutes.
W05-1513
See (Charniak, 2000) for details.
A00-2018
This produces a probabilistic shift-reduce parser that resembles a generalized probabilistic LR parser (Briscoe and Carroll, 1993), where probabilities are associated with an LR parsing table.
J93-1002
