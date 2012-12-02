All experiments are conducted using 10-fold cross validation on the same data splitting used in (Bunescu et al., 2005; Bunescu and Mooney, 2005b).
H05-1091
corpus The first data set used in the experiments is the AImed corpus4, previously used for training protein interaction extraction systems in (Bunescu et al., 2005; Bunescu and Mooney, 2005b).
H05-1091
In (Bunescu and Mooney, 2005b), the authors present a generalized subsequence kernel that works with sparse sequences containing combinations of words and PoS tags.
H05-1091
Bunescu and Mooney (2005a) present an alternative approach which uses information concentrated in the shortest path in the dependency tree between the two entities.
H05-1091
As in (Bunescu et al., 2005; BunescuandMooney,2005b),thegraphpointsare obtained by varying the threshold on the classifi6http://www.csie.ntu.edu.tw/˜cjlin/ libsvm/ 405 OAOD Kernel Precision Recall F1 KGC 57.7 60.1 58.9 KLC 37.3 56.3 44.9 KSL 60.9 57.2 59.0 OARD Kernel Precision Recall F1 KGC 58.9 66.2 62.2 KLC 44.8 67.8 54.0 KSL 64.5 63.2 63.9 ERK 65.0 46.4 54.2 Table 1: Performance on the AImed data set using the two evaluation methodologies, OAOD and OARD.
H05-1091
parse trees) and are compared by the kernel function (Zelenko et al., 2003; Culotta and Sorensen, 2004; Zhao and Grishman, 2005).
P04-1054 P05-1052
Culotta and Sorensen (2004) describe a slightly generalized version of this kernel based on dependency trees, in which a bag-ofwords kernel is used to compensate for errors in syntactic analysis.
P04-1054
Different works (Gliozzo et al., 2005; Zhao and Grishman, 2005; Culotta and Sorensen, 2004) empirically demonstrate the effectiveness of combining kernels in thisway, showingthatthecombinedkernelalways improves the performance of the individual ones.
P04-1054 P05-1050 P05-1052
The whole sentence where the entities appear (global context) is used to discover the presence of a relation between two entities, similarly to what was done by Bunescu and Mooney (2005b).
H05-1091
We first give an evaluation of the kernel combination and then we compare our results with the Subsequence Kernel for Relation Extraction (ERK) described in (Bunescu and Mooney, 2005b).
H05-1091
As mentioned in Section 1, another relevant approach is presented in (Roth and Yih, 2002).
C02-1151
Our global context kernels operate on the patterns above, where each pattern is represented using a bag-of-words instead of sparse subsequences of words, PoS tags, entity and chunk types, or WordNet synsets as in (Bunescu and Mooney, 2005b).
H05-1091
A further extension is proposed by Zhao and Grishman (2005).
P05-1052
WereportinFigure4theprecision-recallcurves ofERKandKSL usingOARDevaluationmethodology (the evaluation performed by Bunescu and Mooney (2005b)).
H05-1091
Context Kernel In (Bunescu and Mooney, 2005b), the authors observed that a relation between two entities is generally expressed using only words that appear simultaneously in one of the following three patterns: Fore-Between: tokens before and between the two candidate interacting entities.
H05-1091
The approach has some resemblance with what was proposed by Roth and Yih (2002).
C02-1151
