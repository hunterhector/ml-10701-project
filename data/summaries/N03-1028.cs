This forced the best sequential classi er systems to resort to heuristic combinations of forward-moving and backward-moving sequential classi ers (Kudo and Matsumoto, 2001).
N01-1025
We also used a development test set, provided by Michael Collins, derived from WSJ section 21 tagged with the Brill (1995) POS tagger.
J95-4004
The relative slowness of iterative scaling is also documented in a recent evaluation of training methods for maximum-entropy classi cation (Malouf, 2002).
W02-2018
The sequential classi cation approach can handle many correlated features, as demonstrated in work on maximum-entropy (McCallum et al., 2000; Ratnaparkhi, 1996) and a variety of other linear classi ers, including winnow (Punyakanok and Roth, 2001), AdaBoost (Abney et al., 1999), and support-vector machines (Kudo and Matsumoto, 2001).
N01-1025 W96-0213 W99-0606
On the application side, (log-)linear parsing models have the potential to supplant the currently dominant lexicalized PCFG models for parsing by allowing much richer feature sets and simpler smoothing, while avoiding the label bias problem that may have hindered earlier classi er-based parsers (Ratnaparkhi, 1997).
W97-0301
The pioneering work of Ramshaw and Marcus (1995) introduced NP chunking as a machine-learning problem, with standard datasets and evaluation metrics.
W95-0107
An earlier study indicates that L-BFGS performs well in maximum-entropy classi er training (Malouf, 2002).
W02-2018
The generalized perceptron proposed by Collins (2002) is closely related to CRFs, but the best CRF training methods seem to have a slight edge over the generalized perceptron.
P02-1034 W02-1001
We compare those algorithms to generalized iterative scaling (GIS) (Darroch and Ratcliff, 1972), non-preconditioned CG, and voted perceptron training (Collins, 2002).
P02-1034 W02-1001
Following Ramshaw and Marcus (1995), the input to the NP chunker consists of the words in a sentence annotated automatically with part-of-speech (POS) tags.
W95-0107
Collins (2002) reported and we con rmed that this averaging reduces overtting considerably.
P02-1034 W02-1001
The task was extended to additional phrase types for the CoNLL2000 shared task (Tjong Kim Sang and Buchholz, 2000), which is now the standard evaluation task for shallow parsing.
W00-0726
Yeh (2000) examined randomized tests for estimating the signi cance of F scores, and in particular the bootstrap over the test set (Efron and Tibshirani, 1993; Sang, 2002).
C00-2137
Erik Tjong Kim Sang, who has created the best online resources on shallow parsing, helped us with details of the CoNLL-2000 shared task.
W00-0726
Preparation NP chunking results have been reported on two slightly different data sets: the original RM data set of Ramshaw and Marcus (1995), and the modi ed CoNLL-2000 version of Tjong Kim Sang and Buchholz (2000).
W00-0726 W95-0107
Model F score SVM combination 94.39% (Kudo and Matsumoto, 2001) CRF 94.38% Generalized winnow 93.89% (Zhang et al., 2002) Voted perceptron 94.09% MEMM 93.70% Table 2: NP chunking F scores 5 Results All the experiments were performed with our Java implementation of CRFs,designed to handle millions of features, on 1.7 GHz Pentium IV processors with Linux and IBM Java 1.3.0.
N01-1025
In contrast, generative models are trained to maximize the joint probability of the training data, which is 1Ramshaw and Marcus (1995) used transformation-based learning (Brill, 1995), which for the present purposes can be tought of as a classi cation-based method.
J95-4004 W95-0107
However, work in that direction has so far addressed only parse reranking (Collins and Duffy, 2002; Riezler et al., 2002).
P02-1034 P02-1035 W02-1001
In the present work, we show that CRFs beat all reported single-model NP chunking results on the standard evaluation dataset, and are statistically indistinguishable from the previous best performer, a voting arrangement of 24 forwardand backward-looking support-vector classi ers (Kudo and Matsumoto, 2001).
N01-1025
Full discriminative parser training faces signi cant algorithmic challenges in the relationship between parsing alternatives and feature values (Geman and Johnson, 2002) and in computing feature expectations.
P02-1036
Minor variants support voted perceptron (Collins, 2002) and MEMMs (McCallum et al., 2000) with the same ef cient feature encoding.
P02-1034 W02-1001
Perceptron Unlike other methods discussed so far, voted perceptron training (Collins, 2002) attempts to minimize the difference between the global feature vector for a training instance and the same feature vector for the best-scoring labeling of that instance according to the current model.
P02-1034 W02-1001
Those methods are very simple and guaranteed to converge, but as Minka (2001) and Malouf (2002) showed for classi cation, their convergence is much slower than that of general-purpose convex optimization algorithms when many correlated features are involved.
W02-2018
The published F score for voted perceptron is 93.53% with a different feature set (Collins, 2002).
P02-1034 W02-1001
To avoid over tting, we penalize the likelihood with a spherical Gaussian weight prior (Chen and Rosenfeld, 1999): L0 = X k [ F(yk; xk) log Z (xk)] k k 2 2 2 + const with gradient rL0 = X k F(y k; xk) Ep (Y jxk)F(Y ; xk) 2 3 Training Methods Lafferty et al.(2001) used iterative scaling algorithms for CRF training, following earlier work on maximumentropy models for natural language (Berger et al., 1996; Della Pietra et al., 1997).
J96-1002
On the machine-learning side, it would be interesting to generalize the ideas of large-margin classi cation to sequence models, strengthening the results of Collins (2002) and leading to new optimal training algorithms with stronger guarantees against over tting.
P02-1034 W02-1001
