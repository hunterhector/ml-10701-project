The cross-pair similarity model uses: (1) a tree similarity measure KT(?1,?2) (Collins and Duffy, 2002) that counts the subtrees that ?1 and ?2 have in common; (2) a substitution function t(,c) that changes names of the placeholders in a tree according to a set of correspondences between placeholders c.
P02-1034
Chklovski and Pantel (2004) introduce a 5-class set, designed specifically for characterizing verb-verb semantic relations.
W04-3205
Ryan McDonald, Kevin Lerman, and Fernando Pereira. 2006. Multilingual dependency analysis with a two-stage discriminative parser. In Proceedings of CoNLL, pages 216220.
E06-1011
Based on Event Term Clustering 2.1 Event Term Graph We introduce VerbOcean (Chklovski and Pantel, 2004), a broad-coverage repository of semantic verb relations, into event-based summarization.
W04-3205
tron (Freund and Schapire, 1999; Collins, 2002),
P02-1034
The 2007 TempEval competition tries to address this question by establishing a common corpus on which research systems can compete to find temporal relations (Verhagen et al., 2007).
W07-2014
Donald et al., 2005a; McDonald and Pereira, 2006).
E06-1011
2005a; McDonald and Pereira, 2006).
E06-1011
Parsing research has also begun to adopt discriminative methods from the Machine Learning literature, such as the perceptron (Freund and Schapire, 1999; Collins and Roark, 2004) and the largemargin methods underlying Support Vector Machines (Taskar et al., 2004; McDonald, 2006).
E06-1011
Okanohara et al.(2006) applied semiCRFs (Sarawagi and Cohen, 2004), which can treat multiple words as corresponding to a single state.
W04-3240
Kudo et al.(2004) studied Japanese word segmentation and POS tagging using conditional random fields (CRFs) and rulebased unknown word processing.
W04-3239
Ryan McDonald. 2006. Discriminative Learning and Spanning Tree Algorithms for Dependency Parsing. Ph.D. thesis, University of Pennsylvania.
E06-1011
For this reason, each preposition and verb was assigned a weight based on the proportion of occurrences of that word in the Penn Treebank (Marcus et al., 1993) which are labelled with a spatial meaning.
J93-2004
Finally, word similarity can be computed from structural features like head-modifier relationships (Grefenstette 1994b; Ruge 1992; Dagan, Marcus, and Markovitch 1993; Pereira, Tishby, and Lee 1993; Dagan, Pereira, and Lee 1994).
J93-2004
Tag sets for English are derived from the Penn Treebank (Marcus et al., 1993).
J93-2004
annotation For manual syntactic annotation of collected data (see Section 4), we followed the syntactic annotation conventions of the well-known Penn Treebank (Marcusetal., 1993).
J93-2004
Mitchell P. Marcus, Beatrice Santorini, and Mary Ann Marcinkiewicz. 1993. Building a large annotated corpus of English: The Penn Treebank. Computational Linguistics, 19(2):313330.
J93-2004
We also tried to use features in verb ontology such as VERBOCEAN (Chklovsky and Pantel, 2004) which is used in (Mani et al., 2006).
P06-1095
M. Collins. 2002. Discriminative Training Methods for Hidden Markov Models: Theory and Experiments with Perceptron Algorithms. In Proceedings of EMNLP, pages 18.
P02-1034
The Multilingual Chinese-English lexical sample task is designed following the leading ideas of the Senseval-3 Multilingual English-Hindi lexical sample task (Chklovski et al., 2004).
W04-3205
In the tagging domain, Collins (2002) compared log-linear and perceptron training for HMM-style tagging based on dynamic programming.
P02-1034
Collins (2002) introduced the averaged perceptron, as a way of reducing overfitting, and it has been shown to perform better than the non-averaged version on a number of tasks.
P02-1034
Penn treebank (PTB) (Marcus et al., 1993). We used
J93-2004
McDonaldandPereira(2006) 85.2
E06-1011
Cohen. 2004.
W04-3240
In the algorithm, parsing states are represented by triples ?S,I,A?? where S is the stack that keeps the words being under consideration, I is the list of reDA RA CR (Yamada and Matsumoto, 2003) 90.3 91.6 38.4 (Nivre and Scholz, 2004) 87.3 84.3 30.4 (Isozaki et al., 2004) 91.2 95.7 40.7 (McDonald et al., 2005) 90.9 94.2 37.5 (McDonald and Pereira, 2006) 91.5 N/A 42.1 (Corston-Oliver et al., 2006) 90.8 93.7 37.6 Our Base Parser 90.9 92.6 39.2 Table 2: Comparison of parser performance.
E06-1011
For example, ?amerika32 ??wa:Ken22?? is used as the feature of the given pair ?Ken22??and ?amerika32?? 2.5 Classification Algorithm There are several structure-based learning algorithms proposed so far (Collins and Duffy, 2001; Suzuki et al., 2003; Kudo and Matsumoto, 2004).
W04-3239
KT(?prime,?primeprime), as defined in (Collins and Duffy, 2002), computes the number of common subtrees between ?prime and ?primeprime.
P02-1034
The highest score reported on Timebank achieved 62.5% accuracy when using gold-standard features as marked by humans (Mani et al., 2006).
P06-1095
McDonald and Pereira, 2006; Carreras, 2007).
E06-1011
Solely for comparison with Mani, we add the 73 documentOpinionCorpus(Manietal., 2006)tocreate a larger dataset called the OTC.
P06-1095
M.P. Marcus, B. Santorini, and M. Marcinkiewicz. 1993. Building a Large Annotated Corpus of English: The Penn Treebank. ComputationalLinguistics, 19(2):313330.
J93-2004
Penn Treebank (Marcus et al., 1993), using a stan-
J93-2004
In a survey of the idiomatic phrases listed in the Collins Cobuild Dictionary of Idioms, Villavicencio and Copestake (2002) found this kind of idiom to account for more of the entries than any other.
P02-1034
We chose the perceptron for the training algorithm because it has shown good performance on other NLP tasks; in particular, Collins (2002) reported good performance for a perceptron tagger compared to a Maximum Entropy tagger.
P02-1034
There is work on discriminative models for dependency parsing (McDonald, 2006); since there are efficient decoding algorithms available (Eisner, 1996b), complete resources such as the Penn Treebank can used for estimation, leading to accurate parsers.
E06-1011
Empirical evaluation has been done with the ERG on a small set of texts from the Wall Street Journal Section 22 of the Penn Treebank (Marcus et al., 1993).
J93-2004
for dependency parsing by McDonald (2006), who
E06-1011
We trained the parser on the Penn Treebank (Marcus et al., 1993).
J93-2004
We parsed the TimeEval data using MSTParser v0.2 (McDonald and Pereira, 2006), which is trained with all Penn Treebank (Marcus et al., 1993) without dependency label.
E06-1011 J93-2004
Dependency parsing has been actively studied in recent years (Yamada and Matsumoto, 2003; Nivre and Scholz, 2004; Isozaki et al., 2004; McDonald et al., 2005; McDonald and Pereira, 2006; Corston-Oliver et al., 2006).
E06-1011
TRUE. These gold-standard event and time features are similar to those used by Mani and colleagues (2006).
P06-1095
R. McDonald and F. Pereira. 2006. Online Learning of Approximate Dependency Parsing Algorithms. In Proceedings of EACL, pages 8188.
E06-1011
work is that presented by McDonald et al. (2006),
E06-1011
overcome this, McDonald and Pereira (2006) use a
E06-1011
This is thus similar to the multilingual lexical sample task in SENSEVAL-3 (Chklovski et al., 2004), except that our training and test examples are collected without manually annotating each individual ambiguous word occurrence.
W04-3205
TimeML and TimeBank have already been used as the basis for automatic time, event and temporal relation annotation tasks in a number of research projects in recent years (Mani et al., 2006; Boguraev et al., forthcoming).
P06-1095
Training The parsing problem is to find a mapping from a set of sentences x ??X to a set of parses y ??Y. We assume that the mapping F is represented through a feature vector (x,y) ??Rd and a parameter vector  ??Rd in the following way (Collins, 2002): F(x) = argmax y?GEN(x) (x,y) (1) where GEN(x) denotes the set of possible parses for sentence x and (x,y)   = summationtexti ii(x,y) is the inner product.
P02-1034
McDonald et al., 2006). The score of an arc is de-
E06-1011
Naturally, it would be effective to introduce point-wise tree-based classifiers such as Tree Kernels in SVM (Collins and Duffy, 2002; Vishwanathan and Smola, 2002) and boosting for classification of trees (Kudo and Matsumoto, 2004).
P02-1034 W04-3239
Like Collins (2002), the decoder is the same for both the perceptron and the log-linear parsing models; the only change is the method for setting the weights.
P02-1034
In recent years there have been many studies on text classification using general methods (Sebastiani, 2002; Yang and Liu, 1999) semi-structured texts (Kudo and Matsumoto, 2004), and XML classification (Zaki and Aggarwal, 2003).
W04-3239
They are estimated by an Averaged Perceptron described in (Collins, 2002).
P02-1034
Donald et al. (2005a); MD2 = McDonald and Pereira (2006); suffix -L = labeled parser. Unlabeled parsers are scored
E06-1011
McDonald and Pereira (2006) defines parts for sib-
E06-1011
McDonald and Pereira, 2006), we used the train-
E06-1011
