By using a statistical parser (Charniak, 2000) and memorybased learning tools for classification (Daelemans et al., 2004), we obtain high precision and recall of several GRs.
A00-2018
Nivre (2004) reports a labeled (GR) dependency accuracy of 84.4% on modified Penn Treebank data.
C04-1010
This lexicalization procedure is commonly used in statistical parsing (Collins, 1996) and produces a dependency tree.
P96-1025
Although we need manually labeled data to train the classifier for labeling dependencies, the size of this training set is far smaller than what would be necessary to train a parser to find labeled dependen3Klein and Manning (2002) offer an informal argument that constituent labels are much more easily separable in multidimensional space than constituents/distituents.
P02-1017
Briscoe and Carroll (2002) achieve a 76.5% F-score on a very rich set of GRs in the more heterogeneous and challenging Susanne corpus.
C02-1013
Carroll. 2002.
C02-1013
This dependency extraction procedure from constituent trees gives us a straightforward way to obtain unlabeled dependencies: use an existing statistical parser (Charniak, 2000) trained on the Penn Treebank to produce constituent trees, and extract unlabeled dependencies using the aforementioned head-finding rules.
A00-2018
Unlabeled dependencies can be readily obtained by processing constituent trees, such as those in the Penn Treebank (Marcus et al., 1993), with a set of rules to determine the lexical heads of constituents.
J93-2004
We are currently working on a framework for soft-labeling of GRs, which will allow us to manipulate the precision/recall trade-off as discussed in (Carroll and Briscoe, 2002).
C02-1013
