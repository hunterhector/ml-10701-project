Strube and M¨uller (2003) propose a similar idea, but aim instead at finding a subset of the available features with which the resulting coreference classifier yields the best clustering-level accuracy on held-out data.
P03-1022
Details can be found in Soon et al.(2001). Ng and Cardie expand Soon et al.’s feature set from 12 features to a deeper set of 53 to allow more complex NP string matching operations as well as finer-grained syntactic and semantic compatibility tests.
J01-4004
159 Decision tree learners Aone and Bennett (1995), McCarthy and Lehnert (1995), Soon et al.(2001), Learning (C4.5/C5/CART) Strube et al.(2002), Strube and M¨uller (2003), Yang et al.(2003) algorithm RIPPER Ng and Cardie (2002b) Maximum entropy Kehler (1997), Morton (2000), Luo et al.(2004) Instance McCarthy and Lehnert’s McCarthy and Lehnert (1995), Aone and Bennett (1995) creation Soon et al.’s Soon et al.(2001), Strube et al.(2002), Iida et al.(2003) method Ng and Cardie’s Ng and Cardie (2002b) Feature Soon et al.’s Soon et al.(2001) set Ng and Cardie’s Ng and Cardie (2002b) Clustering Closest-first Soon et al.(2001), Strube et al.(2002) algorithm Best-first Aone and Bennett (1995), Ng and Cardie (2002b), Iida et al.(2003) Aggressive-merge McCarthy and Lehnert (1995) Table 1: Summary of the previous work on coreference resolution that employs the learning algorithms, the clustering algorithms, the feature sets, and the training instance creation methods discussed in Section 3.1. 3.2 Learning to Rank Candidate Partitions We train an SVM-based ranker for ranking candidate partitions by means of Joachims’ (2002) SVMa0 a0a2a1a4a3a6a5 package, with all the parameters set to their default values.
J01-4004 P00-1023 P02-1014 P03-1022 P03-1023 P04-1018 P95-1017 W02-1008 W02-1040 W97-0319
We consider three learning algorithms, namely, the C4.5 decision tree induction system (Quinlan, 1993), the RIPPER rule learning algorithm (Cohen, 1995), and maximum entropy classification (Berger et al., 1996).
J96-1002
See Ng and Cardie (2002b) for details.
P02-1014 W02-1008
Finally, Strube et al.(2002) and Iida et al.(2003) have proposed new edit-distance-based string-matching features and centering-based features, respectively.
P03-1022 W02-1040
In our experiments, we use the training texts to acquire coreference classifiers and evaluate the resulting systems on the test texts with respect to two commonly-used coreference scoring programs: the MUC scorer (Vilain et al., 1995) and the B-CUBED scorer (Bagga and Baldwin, 1998).
M95-1005 P98-1012
Coreference Systems A learning-based coreference system can be defined by four elements: the learning algorithm used to train the coreference classifier, the method of creating training instances for the learner, the feature set 2Examples of such scoring functions include the DempsterShafer rule (see Kehler (1997) and Bean and Riloff (2004)) and its variants (see Harabagiu et al.(2001) and Luo et al.(2004)). 3The ranking model breaks ties randomly.
N01-1008 N04-1038 P04-1018 W97-0319
To expand our set of candidate partitions, we can potentially incorporate more high-performing coreference systems into our framework, which is flexible enough to accommodate even those that adopt knowledge-based (e.g., Harabagiu et al.(2001)) and unsupervised approaches (e.g., Cardie and Wagstaff (1999), Bean and Riloff (2004)).
N01-1008 N04-1038 W99-0611
Following previous work on using global features of candidate structures to learn a ranking model (Collins, 2002), the global (i.e., partition-based) features we consider here are simple functions of the local features that capture the relationship between NP pairs.
W02-1001
For instance, Iida et al.(2003) and Zelenko et al.(2004) have explored the use of SVM, voted perceptron, and logistic regression for training coreference classifiers.
W04-0704
Ng and Cardie (2002a) attempt to optimize their rulebased coreference classifier for clustering-level accuracy, essentially by finding a subset of the learned rules that performs the best on held-out data with respect to the target coreference scoring program.
P02-1014 W02-1008
McCallum and Wellner (2003) and Zelenko et al.(2004) have employed graph-based partitioning algorithms such as correlation clustering (Bansal et al., 2002).
W04-0704
We employ as our baseline systems two existing coreference resolvers: our duplication of the Soon et al.(2001) system and the Ng and Cardie (2002b) system.
J01-4004 P02-1014 W02-1008
ranking model using global features of an NP partition, there is some related work on partition ranking where the score of a partition is computed via a heuristic function of the probabilities of its NP pairs being coreferent.2 For instance, Harabagiu et al.(2001) introduce a greedy algorithm for finding the highest-scored partition by performing a beam search in the space of possible partitions.
N01-1008
Strube. 2002.
W02-1040
Recent research in coreference resolution — the problem of determining which noun phrases (NPs) in a text or dialogue refer to which real-world entity — has exhibited a shift from knowledgebased approaches to data-driven approaches, yielding learning-based coreference systems that rival their hand-crafted counterparts in performance (e.g., Soon et al.(2001), Ng and Cardie (2002b), Strube et al.(2002), Yang et al.(2003), Luo et al.(2004)). The central idea behind the majority of these learningbased approaches is to recast coreference resolution as a binary classification task.
J01-4004 P02-1014 P03-1022 P03-1023 P04-1018 W02-1008 W02-1040
