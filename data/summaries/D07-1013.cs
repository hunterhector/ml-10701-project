To learn arc scores, these models use large-margin structured learning algorithms (McDonald et al., 2005a), which optimize the parameters of the model to maximize the score margin between the correct dependency graph and all incorrect dependency graphs for every sentence in a training set.
H05-1066 P05-1012
Syntactic dependency representations have a long history in descriptive and theoretical linguistics and many formal models have been advanced (Hudson, 1984; Mel’ˇcuk, 1988; Sgall et al., 1986; Maruyama, 1990).
P90-1005
The specific model studied in this work is that presented by McDonald et al.(2006), which factors scores over pairs of arcs (instead of just single arcs) and uses near exhaustive search for unlabeled parsing coupled with a separate classifier to label each arc.
W06-2932
The first is what Buchholz and Marsi(2006)callthe“all-pairs”approach, whereevery possible arc is considered in the construction of the optimal parse.
W06-2920
For example, Sagae and Lavie (2006) displayed that combining the predictions of both parsing models can lead to significantly improved accuracies.
N06-2033
It was already known that the two systems make different errors through the work of Sagae and Lavie (2006).
N06-2033
Thespecificmodelstudiedinthisworkisthatpresented by Nivre et al.(2006), which uses labeled pseudo-projective parsing with support vector machines.
E06-1010 W06-2933
This technique is similar to the parser voting methods used by Sagae and Lavie (2006).
N06-2033
Ensemble systems: The error analysis presented in this paper could be used as inspiration for more refined weighting schemes for ensemble systems of the kind proposed by Sagae and Lavie (2006), making the weights depend on a range of linguistic and graph-based factors.
N06-2033
Maruyama. 1990.
P90-1005
As evident from the CoNLL-X shared task on dependency parsing (Buchholz and Marsi, 2006), there are currently two dominant models for data-driven dependency parsing.
W06-2920
The degree of a dependency arc from word w to word u is defined here as the number of words occurring between w and u that are not descendants ofw and modify a word that does not occur between w and u (Nivre, 2006).
E06-1010 W06-2933
Nivre and Nilsson (2005) showed how the restriction to projective dependency graphs could be lifted by using graph transformation techniques to preprocess training data and post-process parser output, so-called pseudo-projective parsing.
P05-1013
CoNLL-X Shared Task The CoNLL-X shared task (Buchholz and Marsi, 2006)wasa large-scale evaluationofdata-drivendependency parsers, with data from 13 different languages and 19 participating systems.
W06-2920
However, both models obtain similar parsing accuracies 122 McDonald Nivre Arabic 66.91 66.71 Bulgarian 87.57 87.41 Chinese 85.90 86.92 Czech 80.18 78.42 Danish 84.79 84.77 Dutch 79.19 78.59 German 87.34 85.82 Japanese 90.71 91.65 Portuguese 86.82 87.60 Slovene 73.44 70.30 Spanish 82.25 81.29 Swedish 82.55 84.58 Turkish 63.19 65.68 Overall 80.83 80.75 Table 1: Labeled parsing accuracy for top scoring systems at CoNLL-X (Buchholz and Marsi, 2006).
W06-2920
on a variety of languages, as seen in Table 1, which shows results for the two top performing systems in the CoNLL-X shared task, McDonald et al.(2006) (“all-pairs”) and Nivre et al.(2006) (“stepwise”).
E06-1010 W06-2932 W06-2933
Nivre. 2006.
E06-1010 W06-2933
If the arc score function is known a priori, then the parsing problem can be stated as, 123 G = argmax G∈D(Gx) s(G) = argmax G∈D(Gx) summationdisplay (i,j,l)∈A s(i,j,l) This problem is equivalent to finding the highest scoring directed spanning tree in the graph Gx originatingoutoftherootnode0, whichcanbesolvedfor both the labeled and unlabeled case in O(n2) time (McDonald et al., 2005b).
H05-1066 P05-1012
ACL. R.McDonald, F.Pereira, K.Ribarov, andJ.Hajiˇc. 2005b.
H05-1066 P05-1012
Syntactic dependency graphs have recently gained a wide interest in the computational linguistics community and have been successfully employed for many problems ranging from machine translation (Ding and Palmer, 2004) to ontology Figure 1: Example dependency graph.
W04-1513
