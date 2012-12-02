Indeed, sequential classification approaches with kernel support vector machines offer competitive performance in POS tagging and chunking (Gimenez and Marquez, 2003; Kudo and Matsumoto, 2001).
N01-1025
provided by (Toutanova et al., 2003) except for complex features such as crude company-name detection features because they are specific to the Penn Treebank and we could not find the exact implementation details.
N03-1033
The best accuracy is 97.24% achieved by bidirectional dependency networks (Toutanova et al., 2003) with a richer set of features that are carefully designed for the corpus.
N03-1033
Method Recall Precision F-score SVM (Kudoh and Matsumoto, 2000) 93.51 93.45 93.48 SVM voting (Kudo and Matsumoto, 2001) 93.92 93.89 93.91 Regularized Winnow (with basic features) (Zhang et al., 2002) 93.60 93.54 93.57 Perceptron (Carreras and Marquez, 2003) 93.29 94.19 93.74 Easiest-first (IOB2, second-order) 93.59 93.68 93.63 Full Bidirectional (Start/End, first-order) 93.70 93.65 93.70 Table 6: Chunking F-scores on the test set (Section 20 of the WSJ, 2012 sentences).
N01-1025 W00-0730
For this purpose, we use the maximum entropy modeling with inequality constraints (Kazama and Tsujii, 2003).
W03-1018
The algorithm for the first-order case is an adaptation of the algorithm for decoding the best sequence on a bidirectional dependency network introduced by (Toutanova et al., 2003), which originates from the Viterbi decoding algorithm for second-order markov models.
N03-1033
A perceptron algorithm gives 97.11% (Collins, 2002).
W02-1001
To make use of the information about future tags, Toutanova et al.proposed a tagging algorithm based on bidirectional dependency networks 467 (Toutanova et al., 2003) and achieved the best accuracy on POS tagging on the Wall Street Journal corpus.
N03-1033
A common choice for the local probabilistic classifier is maximum entropy classifiers (Berger et al., 1996).
J96-1002
Entropy Classifier For local classifiers, we used a maximum entropy model which is a common choice for incorporating various types of features for classification problems in natural language processing (Berger et al., 1996).
J96-1002
4.1 Part-of-speech tagging experiments We split the Penn Treebank corpus (Marcus et al., 1994) into training, development and test sets as in (Collins, 2002).
W02-1001
Kudo et al.(2001) attained performance improvement in chunking by conducting weighted voting of multiple SVMs trained with distinct chunk representations.
N01-1025
Networks (Toutanova et al., 2003) 97.24 Perceptron (Collins, 2002) 97.11 SVM (Gimenez and Marquez, 2003) 97.05 HMM (Brants, 2000) 96.48 Easiest-first 97.10 Full Bidirectional 97.15 Table 3: POS tagging accuracy on the test set (Sections 22-24 of the WSJ, 5462 sentences).
A00-1031 N03-1033 W02-1001
We tested the proposed bidirectional methods, conventional unidirectional methods and the bidirectional dependency network proposed by Toutanova (Toutanova et al., 2003) for comparison.
N03-1033
(Collins, 2002) and used POS-trigrams as well.
W02-1001
Shen et al.(2003) reported a 4.9% error reduction of supertagging by 472 Representation Method Order Recall Precision F-score Speed (tokens/sec) IOB2 Left-to-right 1 93.17 93.05 93.11 1,775 2 93.13 92.90 93.01 989 Right-to-left 1 92.92 92.82 92.87 1,635 2 92.92 92.74 92.87 927 Dependency Networks 1 92.71 92.91 92.81 2,534 2 92.61 92.95 92.78 1,893 Easiest-first 1 93.17 93.04 93.11 2,441 2 93.35 93.32 93.33 1,248 Full Bidirectional 1 93.29 93.14 93.21 712 2 93.26 93.12 93.19 48 Start/End Left-to-right 1 92.98 92.69 92.83 861 2 92.96 92.67 92.81 439 Right-to-left 1 92.92 92.83 92.87 887 2 92.89 92.74 92.82 451 Dependency Networks 1 87.10 89.56 88.32 1,894 2 87.16 89.44 88.28 331 Easiest-first 1 93.33 92.95 93.14 1,950 2 93.31 92.95 93.13 1,016 Full Bidirectional 1 93.52 93.26 93.39 392 2 93.44 93.20 93.32 4 Table 5: Chunking F-scores on the development set.
P03-1064
