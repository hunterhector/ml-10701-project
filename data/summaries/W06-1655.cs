(Tseng et al., 2005; Asahara et al., 2005) While the CRF is quite effective compared with other models designed for CWS, one wonders whether it may be limited by its restrictive independence assumptions on non-adjacent labels: an order-M CRF satisfies the order-M Markov assumption that, globally conditioned on the input sequence, each label is independent of all other labels given the M labels to its left and right.
I05-3018 I05-3027
Similarly, the machine translation system of Och and Ney uses log-probabilities of phrasal translations and other events as features in a log-linear model (Och and Ney, 2002; Och and Ney, 2004).
J04-4002 P02-1038
The data used was the Microsoft Research Beijing corpus from the Second International Chinese Word Segmentation Bakeoff (Emerson, 2005), and we used the same train/test split used in the competition.
I05-3017
The first two of these were also used by Tseng et al.(2005). For label bigrams (Li,Li+1), we use the same templates, but extending the range of positions by one to the right.7 Each label unior bigram also has a “prior” feature that always fires for that label configuration.
I05-3027
Our best model, combining all features, resulted in an error reduction of 12% over the highest score on this dataset from the 2005 Sighan closed test competition (96.4%), achieved by the pure CRF system of Tseng et al.(2005). 3.3 Discussion Our results indicate that both Markov-type and semi-Markov-type features are useful for generalization to unseen data.
I05-3027
CRFs using this technique have been shown to be very successful at the task of Chinese word segmentation (CWS), starting with the model of Peng et al.(2004). In the Second International Chinese Word Segmentation Bakeoff (Emerson, 2005), two of the highest scoring systems in the closed track competition were based on a CRF model.
C04-1081 I05-3017
We did not explicitly test the utility of CRF-type features for improving recall on out-of-vocabulary items, but we note that in the Bakeoff, the model of Tseng et al.(2005), which was very similar to our CRF-only system (only containing a few more feature templates), was consistently among the best performing systems in terms of test OOV recall (Emerson, 2005).
I05-3017 I05-3027
to Previous Work There is a significant volume of work exploring the use of CRFs for a variety of chunking tasks, including named-entity recognition, gene prediction, shallow parsing and others (Finkel et al., 2005; Culotta et al., 2005; Sha and Pereira, 2003).
N03-1028 P05-1045
