Wellner et al.(2004), Finkel et al.(2005)). For many real-world NLP applications, however, the required graph structure can be very complex, and computing the global normalization factor even approximately can be extremely hard.
P05-1045
Ng and Cardie (2002)).
P02-1014
Configuration: We follow Ng and Cardie (2002) for feature vector construction for each pair of mentions, 8 and Finley and Joachims (2005) for constructing a training/testing instance for each document: a training/testing instance consists of all pairs of mentions in a document.
P02-1014
Ng and Cardie (2002) reports 70.4% of MUC-score using hand-selected features.
P02-1014
McCallum and Wellner (2004), Roth and Yih (2005)) 1, or (2) opted for a 1 Both McCallum and Wellner (2004) and Roth and Yih (2005) used the voted perceptron algorithm (Collins, 2002) to train intractable CRFs.
W02-1001
But without the global normalization, the maximumlikelihood criterion motivated by the maximum entropy principle (Berger et al., 1996) is no longer a feasible option as an optimization criterion.
J96-1002
For the MUC6 data set, we extract noun phrases (mentions) automatically, but for MPQA, we assume mentions for coreference resolution are given as in Stoyanov and Cardie (2006).
W06-1640
Training via the voted perceptron algorithm (Collins, 2002) or using a max-margin criterion also correspond to the first option (e.g.
W02-1001
Finkel et al.(2005), Roth and Yih (2005)), and (2) full-blown global training can often perform worse due to insufficient training data (e.g.
P05-1045
particular, our feature set corresponds to “All Features” in Ng and Cardie (2002), and we discretized numeric values.
P02-1014
Using the same feature set, Ng and Cardie (2002) reports 64.5% of MUC-score, while our system achieved 69.9%.
P02-1014
