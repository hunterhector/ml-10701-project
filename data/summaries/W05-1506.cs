Work As pointed out by Charniak and Johnson (2005), the major difficulty in k-best parsing is dynamic programming.
P05-1022
It does support k-best parsing, but, following Collins’ parse-reranking work (Collins, 2000) (see also Section 5.1.2), it accomplishes this by simply abandoning dynamic programming, i.e., no items are considered equivalent (Charniak and Johnson, 2005).
P05-1022
Again, the equivalence relation will in general not be compatible with the parsing algorithm, so the k-best lists can be used to approximate f prime, as in Data Oriented Parsing (Bod, 2000) and in speech recognition (Mohri and Riley, 2002).
C00-1011
More generally, hypergraphs can be used to represent the search space of most weighted deductive system (Nederhof, 2003).
J03-1006
Collins (2000), in his parse-reranking experiments, used his Model 2 parser (Collins, 2003) with a beam width of 10−3 together with a cell limit of 100 to obtain k-best lists; the average number of parses obtained per sentence was 29.2, the maximum, 101.7 Charniak and Johnson (2005) use coarse-tone parsing on top of the Charniak (2000) parser and get 50-best lists for section 23.
A00-2018 J03-4003 P05-1022
A typical example is discriminative reranking on k-best lists from a generative module, such as (Collins, 2000) for parsing and (Shen et al., 2004) for translation, where the reranking model has nonlocal features that cannot be computed during parsing proper.
N04-1023
Another example is minimum-Bayes-risk decoding (Kumar and Byrne, 2004; Goodman, 1998),where, assuming fprime de nes a probability distribution over all candidates, one seeks the candidate with the highest expected score according to an arbitrary metric (e.g., PARSEVAL or BLEU); since in general the metric will not be compatible with the parsing algorithm, the k-best lists can be used to approximate the full distribution f prime.
N04-1022
For algorithms whose packed representations are graphs, such as Hidden Markov Models and other nitestate methods, Ratnaparkhi’s MXPARSE parser (Ratnaparkhi, 1997), and many stack-based machine translation decoders (Brown et al., 1995; Och and Ney, 2004), the k-best paths problem is well-studied in both pure algorithmic context (see (Eppstein, 2001) and (Brander and Sinclair, 1995) for surveys) and NLP/Speech community (Mohri, 2002; Mohri and Riley, 2002).
J04-4002 W97-0301
We also implemented Algorithms 2 and 3 in a parsing-based MT decoder (Chiang, 2005) and report results on decoding speed.
P05-1033
For each production rule X ! YZ in P and three free indices i < j < k, we have a hyperarc h((Y,i,k),(Z,k, j)),(X,i,k), fi corresponding to the instantiation of the inference rule C in the deductive system of (Shieber et al., 1995), and the weight function f is de ned as f (a,b) = ab¢Pr(X ! YZ), which is the same as in (Nederhof, 2003).
J03-1006
For this experiment, we used sections 02 21 of the Penn Treebank (PTB) (Marcus et al., 1993) as the training data and section 23 (2416 sentences) for evaluation, as is now standard.
J93-2004
All these experiments suggest that our k-best parses are of better quality than those from previous k-best parsers, 7The reason the maximum is 101 and not 100 is that Collins merged the 100-best list using a beam of 10¡3 with the 1-best list using a beam of 10¡4 (Collins, p.c.). 60 86 88 90 92 94 96 98 1 2 5 10 20 30 50 70 100 Oracle F-score k (Charniak and Johnson, 2005) This work with beam width 10-4(Collins, 2000) (Ratnaparkhi, 1997) (a) Oracle Reranking 0 2 4 6 8 10 1 2 5 10 20 30 50 70 100 Percentage of Improvement over 1-best k (Charniak and Johnson, 2005) This work with beam width 10-4(Collins, 2000) (Ratnaparkhi, 1997) (b) Relative Improvement Figure 9: Absolutive and Relative F-scores of oracle reranking for the top k (• 100) parses for section 23, compared to (Charniak and Johnson, 2005), (Collins, 2000) and (Ratnaparkhi, 1997).
A00-2018 P05-1022 W97-0301
For example, Och (2003) shows how to train a log-linear translation model not by maximizing the likelihood of training data, but maximizing the BLEU score (among other metrics) of the model on 53 the data.
P03-1021
Any algorithm expressible as a weighted deductive system (Shieber et al., 1995; Goodman, 1999; Nederhof, 2003) falls into this class.
J03-1006 J99-4004
The simplest method is to abandon dynamic programming and rely on aggressive pruning to maintain tractability, as is used in (Collins, 2000; Bikel, 2004).
J04-4004
0: nacurrency1 ve Following (Goodman, 1999; Mohri, 2002), we isolate two basic operations in line 4 of the 1-best algorithm that 56 can be generalized in order to extend the algorithm: rst, the formation of the derivation he,1i out of jej best subderivations (this is a generalization of the binary operator › in a semiring); second, minprecedesequal, which chooses the better of two derivations (same as the ' operator in an idempotent semiring (Mohri, 2002)).
J99-4004
This generalization is not only of theoretical importance, but also critical in the application to state-of-theart parsers such as (Collins, 2003) and (Charniak, 2000).
A00-2018 J03-4003
Although generative models, being probabilitybased, do not suffer from this problem, more general models (e.g., log-linear models) may require negative edge costs (McDonald et al., 2005; Taskar et al., 2004).
P05-1012 W04-3201
Ratnaparkhi (1997) introduced the idea of oracle reranking: suppose there exists a perfect reranking scheme that magically picks the best parse that has the highest F-score among the top k parses for each sentence.
W97-0301
Since the original design of the algorithm described below, we have become aware of two efforts that are very closely related to ours, one by Jim·enez and Marzal (2000) and another done in parallel to ours by Charniak and Johnson (2005).
P05-1022
For probabilistic parsing, we implemented Algorithms 0, 1, and 3 on top of a widely-used parser (Bikel, 2004) and conducted experiments on parsing efficiency and the quality of the k-best-lists.
J04-4004
For example, McDonald et al.(2005) nd that k = 5 gives optimal parsing accuracy.
P05-1012
2: MT decoder Our second experiment was on a CKY-based decoder for a machine translation system (Chiang, 2005), implemented in Python 2.4 accelerated with Psyco 1.3 (Rigo, 2004).
P05-1033
We ran Bikel’s parser using its settings to emulate Model 2 of (Collins, 2003).
J03-4003
1: Bikel Parser Bikel’s parser (2004) is a state-of-the-art multilingual parser based on lexicalized context-free models (Collins, 2003; Eisner, 2000).
J03-4003 J04-4004
5.1.2). Gildea and Jurafsky (2002) described an O(k2)-overhead extension for the CKY algorithm and reimplemented Collins’ Model 1 to obtain k-best parses with an average of 14.9 parses per sentence.
J02-3001
So we might want to postpone some disambiguation by propagating k-best lists to subsequent phases, as in joint parsing and semantic role labeling (Gildea and Jurafsky, 2002; Sutton and McCallum, 2005), information extraction and coreference resolution (Wellner et al., 2004), and formal semantics of TAG (Joshi and Vijay-Shanker, 1999).
J02-3001 W05-0636
We demonstrate this by comparing our k-best lists to those in (Ratnaparkhi, 1997), (Collins, 2000) and the parallel work by Charniak and Johnson (2005) in several ways, including oracle reranking and average number of found parses.
P05-1022 W97-0301
Our work, based on the Viterbi algorithm, is still applicable as long as the hypergraph is acyclic, and is used by McDonald et al.(2005) to get the k-best parses.
P05-1012
We have presented here a general-purpose algorithm for k-best parsing and applied it to two state-of-the-art, large-scale NLP systems: Bikel’s implementation of Collins’ lexicalized PCFG model (Bikel, 2004; Collins, 2003) and Chiang’s synchronous CFG based decoder (Chiang, 2005) for machine translation.
J03-4003 J04-4004 P05-1033
They apply this method to the Charniak (2000) parser to get 50-best lists for reranking, yielding an improvement in parsing accuracy.
A00-2018
and similar quality to those from (Charniak and Johnson, 2005) which has so far the highest F-score after reranking, and this might lead to better results in real parse reranking.
P05-1022
In our experiments, we apply the algorithms to the lexicalized PCFG parser of Bikel (2004), which is very similar to Collins’ Model 2 (Collins, 2003), and to a synchronous CFG based machine translation system (Chiang, 2005).
J03-4003 J04-4004 P05-1033
Similarly, Chiang (2005) uses the k-best parsing algorithm described below in a CFG-based log-linear translation model in order to learn feature weights which maximize BLEU.
P05-1033
