Unlike the deterministic parsers above, this parser uses a dynamic programming algorithm (Eisner, 1996) to determine the best tree, so there is no difference between presenting the input from left-to-right or right-to-left.
C96-1058
Reparsing Experiments The parsers that were used in the constituent reparsing experiments are: (1) Charniak and Johnson’s (2005) reranking parser; (2) Henderson’s (2004) synchronous neural network parser; (3) Bikel’s (2002) implementation of the Collins (1999) model 2 parser; and (4) two versions of Sagae and Lavie’s (2005) shift-reduce parser, one using a maximum entropy classifier, and one using support vector machines.
P04-1013 P05-1022 W05-1513 W99-0623
If projectivity (no crossing branches) is desired, Eisner’s (1996) dynamic programming algorithm (similar to CYK) for dependency parsing can be used instead.
C96-1058
The deterministic shift-reduce parsing algorithm of (Nivre & Scholz, 2004) was used to create two parsers2, one that processes the input sentence from left-to-right (LR), and one that goes from right-toleft (RL).
C04-1010
the weights is discussed in section 4.1. 129 Once this graph is created, we reparse the sentence using a dependency parsing algorithm such as, for example, one of the algorithms described by McDonald et al.(2005). Finding the optimal dependency structure given the set of weighted dependencies is simply a matter of finding the maximum spanning tree (MST) for the directed weighted graph, which can be done using the Chu-Liu/Edmonds directed MST algorithm (Chu & Liu, 1965; Edmonds, 1967).
H05-1066
Zeman & Žabokrtský (2005) apply this dependency voting scheme to Czech with very strong results.
W05-1518
In our dependency parsing experiments we used unlabeled dependencies extracted from the Penn 130 Treebank using the same head-table as Yamada and Matsumoto (2003), using sections 02-21 as training data and section 23 as test data, following (McDonald et al., 2005; Nivre & Scholz, 2004; Yamada & Matsumoto, 2003).
C04-1010 H05-1066
The large-margin parser described in (McDonald et al., 2005) was used with no alterations.
H05-1066
Henderson and Brill (1999) proposed two parser combination schemes, one that picks an entire tree from one of the parsers, and one that, like ours, builds a new tree from constituents from the initial trees.
W99-0623
Much of this work has been fueled by the availability of large corpora annotated with syntactic structures, especially the Penn Treebank (Marcus et al., 1993).
J93-2004
Reparsing In dependency reparsing we focus on unlabeled dependencies, as described by Eisner (1996).
C96-1058
