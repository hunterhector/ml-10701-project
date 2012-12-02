and instance weighting The classifier we used was TiMBL, a memory based learner due to Daelemans et al.(2003). One reason for this choice was that memory based learning has shown to perform well in previous word sense disambiguation tasks, including some best performers in SENSEVAL, such as (Hoste et al., 2001; Decadt et al., 2004; Mihalcea and Faruque, 2004).
W04-0827 W04-0838
Although these classes are based on syntactic properties unlike those in WORDNET, it has been shown that they can be used in automatic classifications (Stevenson and Merlo, 2000).
C00-2118
In the typical setting, supervised learning needs training data created for each and every polysemous word; Ng (1997) estimates an effort of 16 personyears for acquiring training data for 3,200 significant words in English.
W97-0201
vious observations (Hoste et al., 2001; Decadt et al., 2004) that combining classifiers, each using different features, can yield good performance.
W04-0827
Yarowsky (1992) used Roget’s Thesaurus categories as classes for word senses.
C92-2070
The generic classes we learned can be mapped to System Recall Simil-Prime 0.661 GAMBL-AW-S (Decadt et al., 2004) 0.652 SenseLearner (Mihalcea and Faruque, 2004) 0.646 Baseline (WORDNET first sense) 0.642 Table 8: Results for SENSEVAL-3 English all words data for all parts of speech and fine grained scoring.
W04-0827 W04-0838
However, previously reported results such as (Hoste et al., 2001) and (Decadt et al., 2004) have shown that optimizing the voting process helps improve the results.
W04-0827
Resnik (1997) described a method to acquire a set of conceptual classes for word senses, employing selectional preferences, based on the idea that certain linguistic predicates constraint the semantic interpretation of underlying words into certain classes.
W97-0209
Figure 1 shows the performance of this transformed fine-grained classifier (CG) for nouns and verbs with SENSEVAL-2 and 3 English all words task data (marked as S2 and S3 respectively), along with the baseline WORDNET first sense (BL), and the best-performer classifiers at each SENSEVAL excercise (CL), SMUaw (Mihalcea, 2002) and GAMBL-AW (Decadt et al., 2004) respectively.
W04-0827 W04-0838
For training and testing, we used publicly available data sets, namely SEMCOR corpus (Miller et al., 1993) and SENSEVAL English all-words task data.
H93-1061
We believe that the chances for such a high accuracy in a coarse-grained sense classifier is better, for several reasons: • previously reported good performance for coarse grained systems (Yarowsky, 1992) • better availability of data, due to the possibility of reusing data created for different words.
C92-2070
Korhonen (2002) proposed a method for mapping WORDNET entries into Levin classes.
W02-1108
To simulate this classifier on SENSEVAL English all-words tasks’ data (Edmonds and Cotton, 2001; Snyder and Palmer, 2004), we mapped the finegrained senses from official answer keys to their respective beginners.
W04-0811
