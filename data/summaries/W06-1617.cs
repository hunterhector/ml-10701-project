and feature selection 4.1 Baseline NomBank SRL features Table 1 lists the baseline features we adapted from previous PropBank-based SRL systems (Pradhan et al., 2005; Xue and Palmer, 2004).
N04-4036 W04-3212
The work in (Pradhan et al., 2004) experimented with an automatic SRL system developed using a relatively small set of manually selected nominalizations from FrameNet and Penn Chinese TreeBank.
N04-4036
Feature a7 was also proposed by the system in (Pradhan et al., 2004).
N04-4036
of NomBank The NomBank (Meyers et al., 2004c; Meyers et al., 2004b) annotation project originated from the NOMLEX (Macleod et al., 1997; Macleod et al., 1998) nominalization lexicon developed under the New York University Proteus Project.
W04-2705
PropBank and NomBank SRL Work in (Pustejovsky et al., 2005) discussed the possibility of merging various Treebank annotation efforts including PropBank, NomBank, and others.
W05-0302
Since its introduction to the Natural Language Processing (NLP) community (Berger et al., 1996), ME-based classifiers have been shown to be effective in various NLP tasks.
J96-1002
Litkowski. 2004.
W04-0803
Most of these nominal predicates are DEFREL relational nouns (Meyers et al., 2004c).
W04-2705
Automatic Semantic Role Labeling (SRL) systems, made possible by the availability of PropBank (Kingsbury and Palmer, 2003; Palmer et al., 2005), and encouraged by evaluation efforts in (Carreras and Marquez, 2005; Litkowski, 2004), have been shown to accurately determine the argument structure of verb predicates.
J05-1004 W04-0803 W05-0620
For NomBank SRL fea140 Baseline Features (Pradhan et al., 2005) b1 predicate: stemmed noun b2 subcat: grammar rule that expands the predicate’s parent b3 phrase type: syntactic category of the constituent b4 head word: syntactic head of the constituent b5 path: syntactic path from the constituent to the predicate b6 position: to the left or right of the predicate b11 first or last word/POS spanned by the constituent (b11FW, b11LW, b11FP, b11LP) b12 phrase type of the left or right sister (b12L, b12R) b13 left or right sister’s head word/POS (b13LH, b13LP, b13RH, b13RP) b14 phrase type of parent b15 parent’s head word or its POS (b15H, b15P) b16 head word of the constituent if its parent has phrase type PP b17 head word or POS tag of the rightmost NP node, if the constituent is PP (b17H, b17P) b18 phrase type appended with the length of path b19 temporal keyword, e.g., ”Monday” b20 partial path from the constituent to the lowest common ancestor with the predicate b21 projected path from the constituent to the highest NP dominating the predicate Baseline Combined Features (Xue and Palmer, 2004) b31 b1 & b3 b32 b1 & b4 b33 b1 & b5 b34 b1 & b6 Table 1: Baseline features for NomBank SRL tures, we use this set of more specific mappings to replace the morphological mappings based on WordNet.
W04-3212
During testing, the algorithm of enforcing nonoverlapping arguments by (Toutanova et al., 2005) is used.
P05-1073
Baseline Features (Pradhan et al., 2005) b1 replacement b2 NP → NP NN b3 NP b4 Bernanke b5 NP↑S↓VP↓VP↓PP↓NP↓NN b6 left b11 Ben, Bernanke, NNP, NNP b12 NULL, VP b13 NULL, NULL, was, VBD b14 S b15 was, VBD b16 NULL b17 NULL, NULL b18 NP-7 b19 NULL b20 NP↑S b21 NP↑S↓VP↓VP↓PP↓NP Baseline Combined Features (Xue and Palmer, 2004) b31 replacement & NP b32 replacement & Bernanke b33 replacement & NP↑S↓VP↓VP↓PP↓NP↓NN b34 replacement & left Table 2: Baseline feature instantiations, assuming the current constituent is “NP-Ben Bernanke” in Figure 1.
W04-3212
arguments The research of (Jiang et al., 2005; Toutanova et al., 2005) has shown the importance of capturing information of the global argument frame in order to correctly classify the local argument.
P05-1073
The inter-annotator agreement for PropBank reported in (Palmer et al., 2005) is above 0.9 in terms of the Kappa statistic (Sidney and Castellan Jr., 1988).
J05-1004
NomBank frames combine various lexical resources (Meyers et al., 2004a), including an extended NOMLEX and PropBank frames, and form the basis for annotating the argument structures of common nouns.
W04-2705
The recent release of NomBank (Meyers et al., 2004c; Meyers et al., 2004b), a databank that annotates argument structure for instances of common nouns in the Penn Treebank II corpus, made it possible to develop automatic SRL systems that analyze the argument structures of noun predicates.
W04-2705
Preliminary consistency tests reported in (Meyers et al., 2004c) shows that NomBank’s interannotator agreement rate is about 85% for core arguments and lower for adjunct arguments.
W04-2705
We also experimented with various feature combinations, inspired by the features used in (Xue and Palmer, 2004).
W04-3212 W04-3212
We relax this assumption by using the re-ranking parser presented in (Charniak and 143 Johnson, 2005) to automatically generate the syntactic parse trees for both training and test data.
P05-1022
