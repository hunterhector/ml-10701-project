The training set for these experiments was sections 01-21 of the Penn Treebank (Marcus et al., 1993).
J93-2004
3. Given a novel sentence 8test E Ctest, combine the collection of hypotheses ti = fi(Stest) using the unweighted constituent voting scheme of Henderson and Brill (1999).
W99-0623
Abney et al.(1999) performed part-of-speech tagging and prepositional phrase attachment using AdaBoost as a core component.
W99-0606
The parser induction algorithm used in all of the experiments in this paper was a distribution of Collins's model 2 parser (Collins, 1997).
P97-1003
Haruno et al.(1998) used boosting to produce more accurate classifiers which were embedded as control 35 Set Instance P R F Gain Exact Gain Training Original Parser 96.25 96.31 96.28 NA 64.7 NA Initial 93.61 93.63 93.62 0.00 55.5 0.0 BestF(15) 96.16 95.86 96.01 2.39 62.1 6.6 Final(15) 96.16 95.86 96.01 2.39 62.1 6.6 Test Original Parser 88.73 88.54 88.63 NA 34.9 NA Initial 88.43 88.34 88.38 0.00 33.3 0.0 TrainBestF(15) 89.54 88.80 89.17 0.79 34.6 1.3 TestBestF(13) 89.55 88.84 89.19 0.81 34.7 1.4 Final(15) 89.54 88.80 89.17 0.79 34.6 1.3 Table 1: Bagging the Treebank mechanisms of a parser for Japanese.
P98-1083
Henderson and Brill (1999) showed that independent human research efforts produce parsers that can be combined for an overall boost in accuracy.
W99-0623
Abney et al.(1999) showed a similar corpus analysis technique for part of speech tagging and prepositional phrase tagging, but for parsing we must remove errors introduced by the parser as we did in Section 3.3.2 before questioning the corpus quality.
W99-0606
