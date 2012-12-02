E. Charniak 2000.
A00-2018
Vector Machine Approach In the SVM (Vapnik, 1995) approach, we first form a training and a testing file using all standard features for each sense following (Lee and Ng, 2002) (one classifier per sense).
W02-1006
Similarly, (Ando, 2006) exploits data from related tasks, using all labeled examples irrespective of target words for learning each sense using the Alternating Structure Optimization (ASO) algorithm (Ando and Zhang, 2005a; Ando and Zhang, 2005b).
P05-1001 W06-2911
Bayes (Soft Tag) 68.9 SVM-Topic 66.0 SVM baseline 65.2 NB baseline 63.4 ASO(best configuration)(Ando, 2006) 68.1 Classifier Combination(Florian, 2002) 66.5 Polynomial KPCA(Wu et al., 2004) 65.8 SVM(Lee and Ng, 2002) 65.4 Senseval-2 Best System 64.2 Table 4: Results (best configuration) compared to previous best systems on Senseval-2 English lexical sample task.
P04-1081 W02-1004 W02-1006 W06-2911
1020 Bayes (Soft Tag) 73.6 SVM-topic 73.0 SVM baseline 72.4 NB baseline 69.8 ASO(Ando, 2006) 74.1 SVM-LSA (Strapparava et al., 2004) 73.3 Senseval-3 Best System(Grozea, 2004) 72.9 Table 5: Results compared to previous best systems on Senseval-3 English lexical sample task.
W04-0831 W04-0856 W06-2911
C. Grozea 2004.
W04-0831
The features used in these systems usually include local features, such as part-of-speech (POS) of neighboring words, local collocations, syntactic patterns and global features such as single words in the surrounding context (bag-of-words) (Lee and Ng, 2002).
W02-1006
Although SVM with topic features shows limited success with only a 0.6% improvement, the Bayesian network approach has again demonstrated a good improvement of 3.8% over its baseline and is better than previous reported best systems except ASO(Ando, 2006).
W06-2911
Syntactic Relations We adopt the same syntactic relations as (Lee and Ng, 2002).
W02-1006
Bayes (Soft Tag) 66.3 NB baseline 63.7 SMUaw (Mihalcea, 2002) 69.0 Simil-Prime (Kohomban and Lee, 2005) 66.4 Senseval-2 Best System 63.6 (CNTS-Antwerp (Hoste et al., 2001)) Table 6: Results compared to previous best systems on Senseval-2 English all-words task.
P05-1005
Bayes (Soft Tag) 66.1 NB baseline 64.6 Simil-Prime (Kohomban and Lee, 2005) 66.1 Senseval-3 Best System 65.2 (GAMBL-AW-S(Decadt et al., 2004)) Senseval-3 2nd Best System (SenseLearner 64.6 (Mihalcea and Faruque, 2004)) Table 7: Results compared to previous best systems on Senseval-3 English all-words task.
P05-1005 W04-0827 W04-0838
A. Ratnaparkhi 1996.
W96-0213
Unsupervised learning is introduced primarily to deal with the problem, but with limited success (Snyder and Palmer, 2004).
W04-0811
Ando. 2006.
W06-2911
In (Kohomban and Lee, 2005), the classifier is trained using grouped senses for verbs and nouns according to WordNet top-level synsets and thus effectively pooling training cases across senses within the same synset.
P05-1005
We adopt the same 11 collocation features as (Lee and Ng, 2002), namely C−1,−1, C1,1, C−2,−2, C2,2, C−2,−1, C−1,1, C1,2, C−3,−1, C−2,1, C−1,2, and C1,3.
W02-1006
We use MXPOST tagger (Adwait, 1996) for POS tagging, Charniak parser (Charniak, 2000) for extracting syntactic relations, SVMlight1 for SVM classifier and David Blei’s version of LDA2 for LDA training and inference.
A00-2018
Compared to (Lee and Ng, 2002), the only difference is that for each training and testing case, we have additional L∗K LDA features, since there are L bag-of-words and each has a topic distribution represented by K values.
W02-1006
