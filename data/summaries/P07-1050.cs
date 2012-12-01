A second labeling stage can be applied to get labeled dependency structures as described in (McDonald et al., 2006).
E06-1011 W06-2932
3The work of McDonald et al.(2005b) would also benefit from a k-best non-projective parser for training.
H05-1066 P05-1012
Many of the features above were introduced in McDonald et al.(2005a); specifically, the nodetype, inside, and edge features.
H05-1066 P05-1012
McDonald et al.(2005b) introduced a model for dependency parsing based on the Edmonds/Chu-Liu algorithm.
H05-1066 P05-1012
Training We have adopted the conditional Maximum Entropy (MaxEnt) modeling paradigm as outlined in Charniak and Johnson (2005) and Riezler et al.(2002). We can partition the training examples into independent subsets, Ys: for the edge-factored MST models, each set represents a word and its candidate parents; for the reranker, each set represents the k-best trees for a particular sentence.
P02-1035 P05-1022
Other DP solutions use constituencybasedparserstoproducephrase-structuretrees,from which dependency structures are extracted (Collins et al., 1999).
P99-1065
The DP algorithms are generally variants of the CKY bottom-up chart parsing algorithm such as that proposed by Eisner (1996).
C96-1058
These models are limited to relatively simple features which exclude linguistic constructs such as verb sub-categorization/valency, lexical selectional preferences, etc.2 In order to explore a rich set of syntactic features in the MST framework, we can either approximate the optimal non-projective solution as in McDonald and Pereira (2006), or we can use the constrained MST model to select a subset of the set of dependency parses to which we then apply lessconstrained models.
E06-1011 W06-2932
An efficient algorithm for generating the k-best parse trees for a constituencybased parser was presented in Huang and Chiang (2005); a variation of that algorithm was used for generating projective dependency trees for parsing in Dreyer et al.(2006) and for training in McDonald et al.(2005a). However, prior to this paper, an efficient non-projective k-best MST dependency parser has not been proposed.3 In this paper we show that the na¨ıve edge-factored models are effective at selecting sets of parses on which the oracle parse accuracy is high.
H05-1066 P05-1012 W05-1506 W06-2929
In order to incorporate second-order features (specifically, sibling features), McDonald et al.proposed a dependency parser based on the Eisner algorithm (McDonald and Pereira, 2006).
E06-1011 W06-2932
Unlike the training procedure employed by McDonald et al.(2005b) and McDonald and Pereira (2006), we provide positive and negative examples in the training data.
E06-1011 H05-1066 P05-1012 W06-2932
The Maximum Spanning Tree algorithm1 was recently introduced as a viable solution for nonprojective dependency parsing (McDonald et al., 2005b).
H05-1066 P05-1012
Many of the model features have been inspired by the constituency-based features presented in Charniak and Johnson (2005).
P05-1022
