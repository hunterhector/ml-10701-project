This allows us to ef ciently use ILP for dependency parsing and add constraints which provide a signi cant improvement over the current stateof-the-art parser (McDonald et al., 2005b) on the Dutch Alpino corpus (see bl row in Table 1).
H05-1066 P05-1012
Strong assumptions are also made in the case of McDonald et al.’s (2005b) non-projective dependency parsing model.
H05-1066 P05-1012
The CoNLL data differs slightly from the original Alpino treebank as the corpus has been part-of-speech tagged using a Memory-Based-Tagger (Daelemans et al., 1996).
W96-0102
While we expect a longer runtime than using the Chu-Liu-Edmonds as in previous work (McDonald et al., 2005b), we are interested in how large the increase is.
H05-1066 P05-1012
Deterministic dependency parsing (Nivre et al., 2004; Yamada and Matsumoto, 2003) can apply global constraints by conditioning attachment decisions on the intermediate parse built.
W04-2407
For training we use single-best MIRA (McDonald et al., 2005a).
H05-1066 P05-1012
For example, it must not contain dependency chains such as en → kom → ik → en . For a more formal definition see previous work (Nivre et al., 2004).
W04-2407
The verb krijg is incorrectly coordinated with the preposition om . work is ef cient and has also been extended to non-projective trees (McDonald et al., 2005b).
H05-1066 P05-1012
McDonald et al.(2005b) use the Chu-LiuEdmonds (CLE) algorithm to solve the maximum spanning tree problem.
H05-1066 P05-1012
The best performing system (McDonald et al.2006; note: this system is different to our baseline) achieves 79.2% labelled accuracy while our baseline system achieves 78.6% and our constrained version 79.8%.
E06-1011 W06-2932
der whether the improvements are large enough to justify further research in this direction; especially since McDonald and Pereira (2006) present an approximate algorithm which also makes more global decisions.
E06-1011 W06-2932
Dependency parsing is useful for applications such as relation extraction (Culotta and Sorensen, 2004) and machine translation (Ding and Palmer, 2005).
P04-1054 P05-1067
While we have presented signi cant improvements using additional constraints, one may won5Even when caching feature extraction during training McDonald et al.(2005a) still takes approximately 10 minutes to train.
H05-1066 P05-1012
While McDonald and Pereira (2006) address the issue of local attachment decisions by de ning scores over attachment pairs, our solution is more general.
E06-1011 W06-2932
For instance, Germann et al.(2001) present an ILP formulation of the Machine Translation (MT) decoding task in order to conduct exact inference.
P01-1030
McDonald et al.(2005a) introduce a dependency parsing framework which treats the task as searching for the projective tree that maximises the sum of local dependency scores.
H05-1066 P05-1012
Our underlying model is a modi ed labelled version2 of McDonald et al.(2005b): s(x,y) = summationdisplay (i,j,l)∈y s(i,j,l) = summationdisplay (i,j,l)∈y w·f(i,j,l) 2Note that this is not described in the McDonald papers but implemented in his software.
H05-1066 P05-1012
A similar problem also occurs in an ILP formulation for machine translation which treats decoding as the Travelling Salesman Problem (Germann et al., 2001).
P01-1030
An example of this for Dutch is illustrated in Figure 2 which was produced by the parser of McDonald et al.(2005b). Here the parse contains a coordination of incompatible word classes (a preposition and a verb).
H05-1066 P05-1012
We apply this dependency parsing approach to Dutch due to the language’s non-projective nature, and take the parser of McDonald et al.(2005b) as a starting point for our model.
H05-1066 P05-1012
However, global constraints cannot be incorporated into the CLE algorithm (McDonald et al., 2005b).
H05-1066 P05-1012
Integer Linear Programming (ILP) has recently been applied to inference in sequential conditional random elds (Roth and Yih, 2004), this has allowed the use of truly global constraints during inference.
W04-2401
Our best results on the development set were achieved using the feature set of McDonald et al.(2005a) and a set of features based on the additional attributes.
H05-1066 P05-1012
Thus far, the formulation follows McDonald et al.(2005b) and corresponds to the Maximum Spanning Tree (MST) problem.
H05-1066 P05-1012
