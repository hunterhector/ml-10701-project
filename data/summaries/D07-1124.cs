We evaluated our system using the standard evaluation script provided by the organizers (Nivre et al., 2007).
D07-1096
CoNLL-X had a shared task on multilingual dependency parsing (Buchholz et al., 2006) by providing treebanks for 13 languages in the same dependency format.
W06-2920
We performed a beam search by carrying out a K-best search through the set of possible sequences of actions as proposed by Johansson and Nugues (2006).
W06-2930
McDonald et al.(2005) used Edge Based Factorization, where the score of a dependency tree is factored as the sum of scores of all edges in the tree.
P05-1012
McDonald et al.(2005) defines the loss of a dependency tree inferred by finding the Maximum Spanning Tree(MST), as the number of words that have incorrect parent (i.e the no.
P05-1012
Eisner. 1996.
C96-1058
The bestfirst search proposed by Sagae and Lavie (2006) was also tried out but there was similar drop in accuracy.
P06-2089
For non-projective parsing, we followed the pseudo projective parsing approach proposed by Nivre and Nilson (2005).
P05-1013
Learning McDonald (2005) applied online learning by scoring edges in a connected graph and finding the Maximum Spanning Tree (MST) of the graph.
P05-1012
However, McDonald (2006) argues that this potential weakness is balanced by the simplicity of online learning, which allows for more streamlined training methods.
W06-2932
Parsing algorithms which search the entire space (Eisner, 1996; McDonald, 2006) are restricted in the features they use to score a relation.
C96-1058 W06-2932
and Discussion The system with online learning and Nivre’s parsing algorithm was trained on the data released by CoNLL Shared Task Organizers for all the ten languages (Hajiˇc et al., 2004; Aduriz et al., 2003; Mart´ı et al., 2007; Chen et al., 2003; B¨ohmov´a et al., 2003; Marcus et al., 1993; Johansson and Nugues, 2007; Prokopidis et al., 2005; Csendes et al., 2005; Montemagni et al., 2003; Oflazer et al., 2003).
J93-2004
A look at the performance sheet in the contest shows that two systems with quite different approaches (one using deterministic parsing with SVM and the other using MIRA with nondeterministic and dynamic programming based MST approach ) performed with good results (McDonald et al., 2006; Nivre et al., 2006).
W06-2932 W06-2933
