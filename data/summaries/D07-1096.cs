In contrasttopreviousworkwherethiswasconstrained to sibling relations of the dependent (McDonald and Pereira, 2006), here head-grandchild relations can be taken into account.
E06-1011
This includes the work of Roark and Bacchiani (2003), Florian et al.(2004), Chelba and Acero (2004), Daum´e and Marcu (2006), and Titov and Henderson (2006).
N03-1027 N04-1001 W04-3237 W06-2902
It is also worth noting that the parsing units in this treebank are in many cases larger than conventional sentences, which partly explains the high average number of tokens per “sentence” (Buchholz and Marsi, 2006).
W06-2920
It is worth noting that variants of this scheme were used in two of the participating 928 5 10 15 20 Number of Systems 80 82 84 86 88 Accuracy Unlabeled Accuracy Labeled Accuracy Figure 1: System Combination systems, the Nilsson system (Hall et al., 2007a) and the system of Sagae and Tsujii (2007).
D07-1097 D07-1102 D07-1111
Bick. 2007.
D07-1120
Mannem. 2007.
D07-1124
Data-driven grammar-based parsers, such as Bick (2007), Schneider et al.(2007), and Watson and Briscoe (2007), need preand post-processing in order to map the dependency graphs provided as training data to a format compatible with the grammar used, and vice versa.
D07-1120 D07-1128 D07-1130
It is worth noting that both these systems combine transitionbased base parsers with a graph-based method for parser combination, as first described by Sagae and Lavie (2006).
N06-2033
76.91(10)* 73.40(7) 69.81(11) 82.38(14) 82.77(4) 72.27(12) 81.93(15) 74.21(5) 74.20(11) 80.69(10) 77.42(6) Schiehlen 76.18(11) 70.08(12) 66.77(14) 85.75(9) 80.04(11) 73.86(9) 86.21(9) 72.29(12) 73.90(12) 80.46(11) 72.48(15) Johansson 75.78(12)* 71.76(9) 75.08(4) 83.33(12) 76.30(14) 70.98(13) 80.29(17) 72.77(11) 71.31(13) 77.55(14) 78.46(4) Mannem 74.54(13)* 71.55(10) 65.64(15) 84.47(11) 73.76(17) 70.68(14) 81.55(16) 71.69(13) 70.94(14) 78.67(13) 76.42(8) Wu 73.02(14)* 66.16(14) 70.71(10) 81.44(15) 74.69(16) 66.72(16) 79.49(18) 70.63(14) 69.08(15) 78.79(12) 72.52(14) Nguyen 72.53(15)* 63.58(16) 58.18(17) 83.23(13) 79.77(12) 72.54(11) 86.73(6) 70.42(15) 68.12(17) 75.06(16) 67.63(17) Maes 70.66(16)* 65.12(15) 69.05(13) 79.21(16) 70.97(18) 67.38(15) 69.68(21) 68.59(16) 68.93(16) 73.63(18) 74.03(13) Canisius 66.99(17)* 59.13(18) 63.17(16) 75.44(17) 70.45(19) 56.14(17) 77.27(19) 60.35(18) 64.31(19) 75.57(15) 68.09(16) Jia 63.00(18)* 63.37(17) 57.61(18) 23.35(20) 76.36(13) 54.95(18) 82.93(14) 65.45(17) 66.61(18) 74.65(17) 64.68(18) Zeman 54.87(19) 46.06(20) 50.61(20) 62.94(19) 54.49(20) 50.21(20) 53.59(22) 55.29(19) 55.24(20) 62.13(19) 58.10(19) Marinov 54.55(20)* 54.00(19) 51.24(19) 69.42(18) 49.87(21) 53.47(19) 52.11(23) 54.33(20) 44.47(21) 59.75(20) 56.88(20) Duan (2) 24.62(21)* 82.64(5) 86.69(7) 76.89(6) Nash 8.65(22)* 86.49(8) Shimizu 7.20(23) 72.02(20) Table 2: Labeled attachment score (LAS) for the multilingual track in the CoNLL 2007 shared task.
D07-1129
For languages with non-projective dependencies, graphs therefore need to be projectivized for training and deprojectivized for testing (Hall et al., 2007a; Johansson and Nugues, 2007b; Titov and Henderson, 2007).
D07-1097 D07-1099 D07-1102 D07-1123
The most extreme case is the top performing Nilsson system (Hall et al., 2007a), which reached rank 1 for five languages and rank 2 for two more languages.
D07-1097 D07-1102
Two other entries used MIRA (Mannem, 2007) or online passive-aggressive learning (Johansson and Nugues, 2007b) to train a globally normalized model.
D07-1123 D07-1124
In structural correspondence learning a transformation from features in the source domain to features of the target domain is learnt (Shimizu and Nakagawa, 2007).
D07-1129
Buchholz and Marsi (2006) report that “[f]or most parsers, their ranking differs at most a few places from their overall ranking”.
W06-2920
Canisius and Tjong Kim Sang (2007) cast the same type of arc-based factorization as a weighted constraint satisfaction problem.
D07-1121
Adaptation Track One well known characteristic of data-driven parsing systems is that they typically perform much worse on data that does not come from the training domain (Gildea, 2001).
W01-0521
One system(Halletal., 2007b)extendsthistwo-stageapproach to a three-stage architecture where the parser and labeler generate ann-best list of parses which in turn is reranked.6 In ensemble-based systems several base parsers provide parsing decisions, which are added together for a combined score for each potential dependency arc.
D07-1097 D07-1102
Following last year’s shared task practice (Buchholz and Marsi, 2006), we use the following definition of projectivity: An arc (i, j) is projective iff all nodes occurring between i and j are dominated by i (where dominates is the transitive closure of the arc relation).
W06-2920
We then describe the two main paradigms for learning and inference, in this year’s shared task as well as in last year’s, which we call transition-based parsers (section 5.2) and graph-based parsers (section 5.3), adopting the terminology of McDonald and Nivre (2007).5 Finally, we give an overview of the domain adaptation methods that were used (section 5.4). 5This distinction roughly corresponds to the distinction made by Buchholz and Marsi (2006) between ”stepwise” and “all-pairs” approaches.
D07-1013 D07-1096 W06-2920
The resulting data set was then converted to dependency structures using the procedure described in Johansson and Nugues (2007a).
D07-1123
Carreras. 2007.
D07-1101
It is worth noting that the parsing units in this treebank are sometimes smaller than conventional sentence units, which partly explains the low average number of tokens per “sentence” (Buchholz and Marsi, 2006).
W06-2920
The best system (Sagae and Tsujii, 2007) reaches an LAS of 81.06 (in comparison to their LAS of 89.01 for the English data set in the multilingual track).
D07-1111
This model is used by Marinov (2007) and in component parsers of the Nilsson ensemble system (Hall etal., 2007a).
D07-1097 D07-1102 D07-1125
To convert these sets to dependency structures we used the same procedure as before (Johansson and Nugues, 2007a).
D07-1123
This technique is used by Sagae and Tsujii (2007) and in the Nilsson system (Hall et al., 2007a).
D07-1097 D07-1102 D07-1111
The parser of McDonald and Pereira (2006) had been applied to English, Czech and Danish, and the parser of Nivre et al.(2007) to ten different languages.
D07-1013 D07-1096 E06-1011
Adaptation 5.4.1 Feature-Based Approaches Onewayofadaptingalearnertoanewdomainwithout using any unlabeled data is to only include features that are expected to transfer well (Dredze et al., 2007).
D07-1112
But by far the largest evaluation of multilingual dependency parsing systems so far was the 2006 shared task, where nineteen systems were evaluatedondatafromthirteenlanguages(Buchholzand Marsi, 2006).
W06-2920
Even before the 2006 shared task, the parsers of Collins (1997) and Charniak (2000), originally developed for English, had been adapted for dependency parsing of Czech, and the parsing methodology proposed by Kudo and Matsumoto (2002) and Yamada and Matsumoto (2003) had been evaluated on both Japanese and English.
P97-1003 W02-2016
To combine the outputs of each parser we used the method of Sagae and Lavie (2006).
N06-2033
Of these, Roark and Bacchiani (2003) and Titov and Henderson (2006) deal specifically with syntactic parsing.
N03-1027 W06-2902
Therefore, we use “Hall, J.” and “Hall, K.”, to disambiguate between the teams involving Johan Hall (Hall et al., 2007a) and Keith Hall (Hall et al., 2007b), respectively.
D07-1097 D07-1102
This type of scoring function is often referred to as a firstorder model.8 Several systems participating in this year’ssharedtaskusedfirst-ordermodels(Schiehlen and Spranger, 2007; Nguyen et al., 2007; Shimizu and Nakagawa, 2007; Hall et al., 2007b).
D07-1097 D07-1102 D07-1126 D07-1127 D07-1129
The first two were annotated as part of the PennBioIE project (Kulick et al., 2004) and consist of sentences drawn from either biomedical or chemical research abstracts.
W04-3111
Optionally multiple passes over the input are conducted until no tokens are left unattached (Attardi et al., 2007).
D07-1119
Adaptation Track As mentioned previously, the source data is drawn from a corpus of news, specifically the Wall Street Journal section of the Penn Treebank (Marcus et al., 1993).
J93-2004
To train these classifiers and probabilitistic models several approaches were used: SVMs (Duan et al., 2007; Hall et al., 2007a; Sagae and Tsujii, 2007), modified finite Newton SVMs (Wu et al., 2007), maximum entropy models (Sagae and Tsujii, 2007), multiclass averaged perceptron (Attardi et al., 2007) and maximum likelihood estimation (Watson and Briscoe, 2007).
D07-1097 D07-1098 D07-1102 D07-1111 D07-1119 D07-1130 D07-1131
In order to calculate a global score or probability for a transition sequence, two systems used a Markov chain approach (Duan et al., 2007; Sagae and Tsujii, 2007).
D07-1098 D07-1111
One system uses as part of their parsing pipeline a “neighbor-parser” that attaches adjacent words and a “root-parser” that identifies the root word(s) of a sentence (Wu et al., 2007).
D07-1131
Most of the graph-based parsers were trained using an online inference-based method such as passiveaggressive learning (Nguyen et al., 2007; Schiehlen and Spranger, 2007), averaged perceptron (Carreras, 2007), or MIRA (Shimizu and Nakagawa, 2007), while some systems instead used methods based on maximum conditional likelihood (Nakagawa, 2007; Hall et al., 2007b).
D07-1097 D07-1101 D07-1102 D07-1126 D07-1127 D07-1129
Finally, Schneider et al.(2007) learnt collocations and relational nouns from the unlabeled target data and used these in their parsing algorithm.
D07-1128
Thus, the systems called “Nilsson” and “Hall, J.” are both described in Hall et al.(2007a), while the systems called “Duan (1)” and “Duan (2)” are both described in Duan et al.(2007). Finally, please pay attention to the fact that there are two teams, where the first author’s last name is Hall.
D07-1097 D07-1098 D07-1102
In 2006 the shared task was multilingual dependency parsing, where participants had to train a single parser on data from thirteen different languages, which enabled a comparison not only of parsing and learning methods, but also of the performance that can be achieved for different languages (Buchholz and Marsi, 2006).
W06-2920
In a similar fashion, Watson and Briscoe (2007) used a variant of self-training to make use of the unlabeled target data.
D07-1130
Bick(2007)usedahybridapproach, whereadatadriven parser trained on the labeled training data was given access to the output of a Constraint Grammar parser for English run on the same data.
D07-1120
Similarly, two parsers trained with different learners and search directions were used in the co-learning approach of Sagae and Tsujii (2007).
D07-1111
5.4.2 Ensemble-Based Approaches Dredze et al.(2007) trained a diverse set of parsers in order to improve cross-domain performance by incorporating their predictions as features for another classifier.
D07-1112
Approaches Attardi et al.(2007) learnt tree revision rules for the target domain by first parsing unlabeled target data using a strong parser; this data was then combined with labeled source data; a weak parser was applied to this new dataset; finally tree correction rules are collected based on the mistakes of the weak parser with respect to the gold data and the output of the strong parser.
D07-1119
This type of model is used by the majority of transition-based parsers (Attardi et al., 2007; Duan et al., 2007; Hall et al., 2007a; Johansson and Nugues, 2007b; Mannem, 2007; Titov and Henderson, 2007; Wu et al., 2007).
D07-1097 D07-1098 D07-1099 D07-1102 D07-1119 D07-1123 D07-1124 D07-1131
However, Hall et al.(2007a) point out that the official results for Chinese contained a bug, and the true performance of their system was actually much higher.
D07-1097 D07-1102
Another technique used was to filter sentences of the out-of-domain corpus based on their similarity to the target domain, as predicted by a classifier (Dredze et al., 2007).
D07-1112
In the case of grammarbased parsers, a classifier is used to disambiguate in cases where the grammar leaves some ambiguity (Schneider et al., 2007; Watson and Briscoe, 2007) 5.2.3 Learning Transition-based parsers either maintain a classifier that predicts the next transition or a global probabilistic model that scores a complete parse.
D07-1128 D07-1130
Nivre. 2007.
D07-1096
Titov and Henderson (2007) used an incremental sigmoid Bayesian network to model the probability of a transition sequence and estimated model parameters using neural network learning.
D07-1099
Using these weights it is possible to search the space of possible dependency trees using directed maximum spanning tree algorithms (McDonald et al., 2005).
H05-1066
Carreras (2007) employs his own extension of Eisner’s algorithm for the case of projective trees and second-order models that include headgrandparent relations.
D07-1101
Instead of assigning HEAD and DEPREL in a single step, some systems use a two-stage approach for attaching and labeling dependencies (Chen et al., 2007; Dredze et al., 2007).
D07-1112
The most common inference technique in transitionbased dependency parsing is greedy deterministic search, guided by a classifier for predicting the next transition given the current parser state and history, processing the tokens of the sentence in sequential left-to-right order7 (Hall et al., 2007a; Mannem, 2007; Marinov, 2007; Wu et al., 2007).
D07-1097 D07-1102 D07-1124 D07-1125 D07-1131
Sometimes it is combined with an explicit probability model for transition sequences, which may be conditional (Duan et al., 2007) or generative (Titov and Henderson, 2007).
D07-1098 D07-1099
Collins. 1997.
P97-1003
Recent work by McClosky et al.(2006) and Blitzer et al.(2006) have shown that the existence of a large unlabeled corpus in the new domain can be leveraged in adaptation.
P06-1043 W06-1615
Their only outlier is for Chinese, where the system occupies rank 14, with a LAS approximately 9 percentage points below the top scoring system for Chinese (Sagae and Tsujii, 2007).
D07-1111
918 English For English we used the Wall Street Journal section of the Penn Treebank (Marcus et al., 1993).
J93-2004
The best performing system on the CHILDES corpus is an open system (Bick, 2007), but the distance to the top closed system is approximately 1 percentage point.
D07-1120
924 (Duan et al., 2007; Johansson and Nugues, 2007b; SagaeandTsujii, 2007; TitovandHenderson, 2007).
D07-1098 D07-1099 D07-1111 D07-1123
However, last year’s top scoring system for Chinese (Riedel et al., 2006), which did not participate this year, had a score that was more than 3 percentage points higher than the second best system for Chinese.
W06-2934
Format and Evaluation Metrics The data sets derived from the original treebanks (section 3) were in the same column-based format as for the 2006 shared task (Buchholz and Marsi, 2006).
W06-2920
Maximum spanning tree algorithms can be used for finding the highest scoring non-projective tree in a first-order model (Hall et al., 2007b; Nguyen et al., 2007; Canisius and Tjong Kim Sang, 2007; Shimizu and Nakagawa, 2007), while Eisner’s dynamic programming algorithm solves the problem for a first-order factorization in the projective case (Schiehlen and Spranger, 2007).
D07-1097 D07-1102 D07-1121 D07-1126 D07-1127 D07-1129
Finally, twosystemsusemodelsbased on LR parsing (Sagae and Tsujii, 2007; Watson and Briscoe, 2007).
D07-1111 D07-1130
Carreras (2007) extends the first-order model to incorporate a sum over scores for pairs of adjacent arcs in the tree, yielding a second-order model.
D07-1101
Two more outliers can be observed in the system of Johansson and Nugues (2007b), which improves from its average rank 12 to rank 4 for Basque and Turkish.
D07-1123
The greatest improvement of a system with respect to its average rank occurs for English, for which the system by Nguyen et al.(2007) improved from the average rank 15 to rank 6.
D07-1126
