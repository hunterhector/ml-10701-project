McDonald and Pereira (2006), it was shown that non-projective dependency parsing with horizontal Markovization is FNP-hard.
E06-1011
When this analysis is coupled with the projective parsing algorithms of Eisner (1996) andPaskin (2001) we beginto get aclear picture of the complexity for data-driven dependency parsing within an edge-factored framework.
C96-1058
It is straight-forward to extend the algorithms of Eisner (1996) and Paskin (2001) to the labeled case adding only a factor of O(|L|n2).
C96-1058
For many languages, a significant portion of sentences require a non-projective dependency analysis (Buchholz et al., 2006).
W06-2920
Another generative dependency model of interest is that given by Klein and Manning (2004).
P04-1061
Recently there have also been proposals for exhaustive methods that weaken the edge-factored assumption, including both approximate methods (McDonaldandPereira, 2006)andexactmethodsthroughinteger linear programming (Riedel and Clarke, 2006) or branch-and-bound algorithms (Hirakawa, 2006).
E06-1011 P06-2047 W06-1616
It is possible to extend the model of Klein and Manning 127 (2004) to the non-projective case.
P04-1061
Nivre. 2005.
P05-1013
Define the weight of a spanning tree T = (VT,ET) as the product of the edge weights w(T) = productdisplay (i,j)k∈ET wkij It is easily shown that this formulation includes the projective model of Paskin (2001) and the nonprojective model of McDonald et al.(2005b). The definition of wkij depends on the context in which it is being used.
H05-1066 P05-1012
The discussion in this section is stated for the model in Paskin (2001); a similar treatment can be developed for the model in Klein and Manning (2004).
P04-1061
Smith. 2007.
D07-1014
Work There has been extensive work on data-driven dependency parsing for both projective parsing (Eisner, 1996; Paskin, 2001; Yamada and Matsumoto, 2003; Nivre and Scholz, 2004; McDonald et al., 2005a) and non-projective parsing systems (Nivre and Nilsson, 2005; Hall and N´ov´ak, 2005; McDonald et al., 2005b).
C04-1010 C96-1058 H05-1066 P05-1012 P05-1013
the Argmax The first problem of interest is finding the highest weighted tree for a given input sentence x T = argmax T∈T(Gx) productdisplay (i,j)k∈ET wkij McDonald et al.(2005b) showed that this can be solved in O(n2) for unlabeled parsing using the Chu-Liu-Edmonds algorithm for standard digraphs (Chu and Liu, 1965; Edmonds, 1967).
H05-1066 P05-1012
Theoretical studies of note include the work of Neuhaus and B¨oker (1997) showing that the recognition problem for a mini122 mal dependency grammar is hard.
P97-1043
Edge-factored models have many computational benefits, most notably that inference for nonprojective dependency graphs can be achieved in polynomial time (McDonald et al., 2005b).
H05-1066 P05-1012
Klein and Manning (2003) distinguish between two kinds of Markovization for unlexicalized CFG parsing.
P03-1054
FollowingtheworkofKooetal.(2007)andSmith and Smith (2007), it is possible to compute all expectations in O(n3 + |L|n2) through matrix inversion.
D07-1014 D07-1015
For grammar based models there has been limited work on empirical systems for non-projective parsing systems, notable exceptions include the work of Wang and Harper (2004).
W04-0307
For example, in the work of McDonald et al.(2005b) it is simply a linear classifier that is a function of the words in the dependency, the label of the dependency, and any contextual features of the words in the sentence.
H05-1066 P05-1012
For neighbouring parse decisions, we extend the work of McDonald and Pereira (2006) and show that modeling vertical neighbourhoods makes parsing intractable in addition to modeling horizontal neighbourhoods.
E06-1011
However, in the data-driven parsing setting this can be partially adverted by incorporating rich feature representationsovertheinput(McDonaldetal., 2005a).
H05-1066 P05-1012
Let R(T,Tprime) be the Hamming distance between two dependency graphs for an input sentence x = x0x1 ···xn, R(T,Tprime) = n − summationdisplay (i,j)k∈ET I((i,j)k,Tprime) This is a common definition of risk between two graphs as it corresponds directly to labeled dependency parsing accuracy (McDonald et al., 2005a; Buchholz et al., 2006).
E06-1011 H05-1066 P05-1012 W06-2920
In the second category are those that employ exhaustive inference algorithms, usually by making strong independence assumptions, as is the case for edge-factored models (Paskin, 2001; McDonald et al., 2005a; McDonald et al., 2005b).
H05-1066 P05-1012
2McDonald and Pereira (2006) define this as a second-order Markov assumption.
E06-1011
These include the perceptron (Collins, 2002) and its large-margin variants (Crammer and Singer, 2003; McDonald et al., 2005a).
H05-1066 P05-1012 W02-1001
These results extend the work of McDonald et al.(2005b) and help to further our understanding of when exact non-projective algorithms can be employed.
H05-1066 P05-1012
It then post-processes the resulting graph to eliminate cycles and then continues recursively until a spanning tree (or valid dependency graph) results (see McDonald et al.(2005b) for details).
H05-1066 P05-1012
It also ensures the compatibility of projective parsing algorithms with many important natural language processing methods that work within a bottom-up chart parsing framework, including information extraction (Miller et al., 2000) and syntax-based machine translation (Wu, 1996).
A00-2030 P96-1021
This result helps to relate the hardness of datadriven models to the commonly known hardness results in the grammar-driven literature given by Neuhaus and B¨oker (1997).
P97-1043
As McDonald et al.(2005b) noted, there is a one-to-one correspondence between spanning trees of Gx and labeled dependency graphs of x, i.e., T(Gx) is exactly the set of all possible projectiveandnon-projectivedependencygraphsfor sentence x.
H05-1066 P05-1012
Theseindependenceassumptions are unwarranted, as it has already been established that modeling non-local information such as arity and nearby parsing decisions improves the accuracy of dependency models (Klein and Manning, 2002; McDonald and Pereira, 2006).
E06-1011
In addition, the work of Kahane et al.(1998) provides a polynomial parsing algorithm for a constrained class of nonprojective structures.
P98-1106
Tomash will remain as a director emeritus, whichhasbeenextractedfromthe Penn Treebank (Marcus et al., 1993).
J93-2004
The work of McDonald et al.(2005b) showed that it is possible to learn a highly accurate non-projective dependency parser for multiple languages using the Chu-Liu-Edmonds algorithm for unlabeled parsing.
H05-1066 P05-1012
The work of Eisner (1996) showed that the argmax problem for digraphs could be solved in O(n3) using a bottomupdynamicprogramming algorithmsimilartoCKY.
C96-1058
Hirakawa. 2006.
P06-2047
Such models are commonly referred to as edge-factored since their parameters factor relative to individual edges of the graph (Paskin, 2001; McDonald et al., 2005a).
H05-1066 P05-1012
In the first category are those methods that employ approximate inference, typically through the use of linear time shift-reduce parsing algorithms (Yamada and Matsumoto, 2003; Nivre and Scholz, 2004; Nivre and Nilsson, 2005).
C04-1010 P05-1013
Non-local information, such as arity (or valency) and neighbouring dependencies, can be crucial to obtaining high parsing accuracies (Klein and Manning, 2002; McDonald and Pereira, 2006).
E06-1011
We start by investigating and extending the edge-factored model of McDonald et al.(2005b). In particular, we appeal to the Matrix Tree Theorem for multi-digraphs to design polynomial-time algorithms for calculating both the partition function and edge expectationsoverallpossibledependencygraphsforagiven sentence.
H05-1066 P05-1012
We assume all dependency graphs are directed trees originating out of a single node, which is a common constraint (Nivre, 2005).
P05-1013
Non-projective dependency parsing can be related to certain parsing problems defined for phrase structure representations, as for instanceimmediatedominanceCFGparsing(Barton et al., 1987) and shake-and-bake translation (Brew, 1992).
C92-2092
Independently of this work, Koo et al.(2007) and Smith and Smith (2007) showed that the MatrixTree Theorem can be used to train edge-factored log-linearmodelsofdependencyparsing.
D07-1014 D07-1015
