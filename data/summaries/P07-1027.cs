Ando. 2006.
W06-2911
For a more complete description, see (Ando and Zhang, 2005a).
P05-1001
Assuming there are k target problems and m auxiliary problems, it is shown in (Ando and Zhang, 2005a) that by performing one round of minimization, an approximate solution of Θ can be obtained from (4) by the following algorithm: 1.
P05-1001
ASO has been demonstrated to be an effective semi-supervised learning algorithm (Ando and Zhang, 2005a; Ando and Zhang, 2005b; Ando, 2006).
P05-1001 W06-2911
While (Ando and Zhang, 2005b) uses “predicting used features” (previous/current/next word) as auxiliary problems with good results in named entity recognition, the use of similar observable auxiliary problems in our work gives no statistically significant improvements.
P05-1001
This is a simplified version of the definition in (Ando and Zhang, 2005a), made possible because the same λ is used for all auxiliary problems.
P05-1001
First, we train the various classifiers on sections 2 to 21 using gold argument labels and automatic parse trees produced by Charniak’s reranking parser (Charniak and Johnson, 2005), and test them on section 23 with automatic parse trees.
P05-1022
A large number of SRL systems have been evaluated and compared on the standard data set in the CoNLL shared tasks (Carreras and Marquez, 2004; Carreras and Marquez, 2005), and many systems have performed reasonably well.
W04-2412 W05-0620
More recently, for the word sense disambiguation (WSD) task, (Ando, 2006) experimented with both supervised and semi-supervised auxiliary problems, although the auxiliary problems she used are different from ours.
W06-2911
Noun predicates also appear in FrameNet semantic role labeling (Gildea and Jurafsky, 2002), and many FrameNet SRL systems are evaluated in Senseval-3 (Litkowski, 2004).
J02-3001 W04-0803
This is the same configuration as reported in (Pradhan et al., 2005; Jiang and Ng, 2006).
W06-1617
(Note that the same is not done on the test data.) A diverse set of 28 features is used in (Jiang and Ng, 2006) for argument classification.
W06-1617
Unlike in (Jiang and Ng, 2006), we do not prune arguments dominated by other arguments or those that overlap with the predicate in the training data.
W06-1617
identification Eighteen baseline features and six additional features are proposed in (Jiang and Ng, 2006) for NomBank argument identification.
W06-1617
In this paper, we apply Alternating Structure Optimization (ASO) (Ando and Zhang, 2005a) to the semantic role labeling task on NomBank.
P05-1001
To find a smaller set of effective features, we start with all the features considered in (Jiang and Ng, 2006), in (Xue and Palmer, 2004), and various combinations of them, for a total of 52 features.
W04-3212 W06-1617
1Note that this definition deviates slightly from the one in (Ando and Zhang, 2005a).
P05-1001
So far we are aware of only one English NomBank-based SRL system (Jiang and Ng, 2006), which uses the maximum entropy classifier, although similar efforts are reported on the Chinese NomBank by (Xue, 2006) 208 and on FrameNet by (Pradhan et al., 2004) using a small set of hand-selected nominalizations.
N04-4036 N06-1055 W04-3212 W06-1617
In recent years, the availability of large human-labeled corpora such as PropBank (Palmer et al., 2005) and FrameNet (Baker et al., 1998) has made possible a statistical approach of identifying and classifying the arguments of verbs in natural language texts.
J05-1004 P98-1013
The J&N column presents the result reported in (Jiang and Ng, 2006).
W06-1617
Litkowski. 2004.
W04-0803
Accordingly, we do not maximize the probability of the entire labeled parse tree as in (Toutanova et al., 2005).
P05-1073
Our results outperform those reported in (Jiang and Ng, 2006).
W06-1617
A variety of auxiliary problems are tested in (Ando and Zhang, 2005a; Ando and Zhang, 2005b) in the semi-supervised settings, i.e., their auxiliary problems are generated from unlabeled data.
P05-1001
In this work, we use a modification of Huber’s robust loss function, similar to that used in (Ando and Zhang, 2005a): L(p,y) =    4py if py < 1 (1 py)2 if 1 py < 1 0 if py 1 (2) We fix the regularization parameter λ to 10−4, similar to that used in (Ando and Zhang, 2005a).
P05-1001
J&N maxent linear aso identification 82.50 83.58 81.34 85.32 classification 87.80 88.35 87.86 89.17 combined 72.73 75.35 72.63 77.04 auto parse (t&t) 69.14 69.61 67.38 72.11 auto parse (test) 71.19 69.05 72.83 Table 3: F1 scores of various classifiers on NomBank SRL Our maximum entropy classifier consistently outperforms (Jiang and Ng, 2006), which also uses a maximum entropy classifier.
W06-1617
This relationship is modeled by ul = wl + ΘTvl (3) The parameters [fwl,vlg,Θ] may then be found by joint empirical risk minimization over all the m problems, i.e., their values should minimize the combined empirical risk: msummationdisplay l=1 parenleftBigg 1 n nsummationdisplay i=1 L parenleftBig (wl + ΘTvl)TXli,Y li parenrightBig + λkwlk2 parenrightBigg (4) 3.2 The ASO algorithm An important observation in (Ando and Zhang, 2005a) is that the binary classification problems used to derive Θ are not necessarily those problems we are aiming to solve.
P05-1001
Second, we achieve accuracy higher than that reported in (Jiang and Ng, 2006) and advance the state of the art in SRL research.
W06-1617
The J&N column presents the result reported in (Jiang and Ng, 2006) using both baseline and additional features.
W06-1617
ASO has been shown to be effective on the following natural language processing tasks: text categorization, named entity recognition, part-of-speech tagging, and word sense disambiguation (Ando and Zhang, 2005a; Ando and Zhang, 2005b; Ando, 2006).
P05-1001 W06-2911
