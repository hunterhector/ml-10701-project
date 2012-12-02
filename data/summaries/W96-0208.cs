A somewhat indirect comparison of applying stochastic context-free grammars (Periera & Shabes, 1992), a transformation-based method (Brill, 1993), and inductive logic programming (Zelle & Mooney, 1994) to parsing the ATIS (Airline Travel Information Service) corpus from the Penn Treebank (Marcus, Santorini, & Marcinkiewicz, 1993) indicates fairly similar performance for these three very different methods.
J93-2004 P93-1035
Learning to Disambiguate Word Senses Several recent research projects have taken a corpus-based approach to lexical disambiguation (Brown, Della-Pietra, Della-Pietra, & Mercer, 1991; Gale, Church, & Yarowsky, 1992b; Leacock et al., 1993b; Lehman, 1994).
H93-1051 P91-1034 P92-1032 P94-1013 W93-0102
Note that the results for 1,200 training examples are comparable to those obtained by Leacock et al.(1993b) for similar methods.
H93-1051 W93-0102
In addition to the results reported by Yarowsky (1994) and Mooney and Califf (1995), it provides evidence for the utility of this representation for natural-language problems.
P94-1013
A number of effective concept-learning systems have employed decision lists (Clark 84 Niblett, 1989; Quinlan, 1993; Mooney & Califf, 1995) and they have already been successfully applied to lexical disambiguation (Yarowsky, 1994).
P94-1013
Similar comparisons of a range of algorithms should also be performed on other natural language problems such as part-of-speech tagging (Church, 1988), prepositional phrase attachment (Hindle & Rooth, 1993), anaphora resolution (Anoe ~ Bennett, 1995), etc..
A88-1019 J93-1005
Also, comparisons of Bayesian, informationretrieval, neural-network, and case-based methods on word-sense disambiguation have also demonstrated similar performance (Leacock, Towell, & Voorhees, 1993b; Lehman, 1994).
H93-1051 W93-0102
Our tests are based on the corpus assembled by Leacock et al.(1993b). The task is to disambiguate the word "line" into one of six possible senses (text, formation, division, phone, cord, product) based on the words occurring in the current and previous sentence.
H93-1051 W93-0102
Since the previous results of Leacock et al.(1993b) indicated that neural networks did not benefit from hidden units on the "line" disambiguation data, we employed a simple perceptron (Rosenblatt, 1962) as a representative connectionist method.
H93-1051 W93-0102
In this paper, we present direct comparisons of a fairly wide range of general learning algorithms on the problem of discriminating six senses of the word "line" from context, using data assembled by Leacock et al.(1993b). We compare a naive Bayesian classifier (Duda & Hart, 1973), a perceptron (Rosenblatt, 1962), a decision-tree learner (Quinlan, 1993), a k nearest-neighbor classifier (Cover & Hart, 1967), logic-based DNF (disjunctive normal form) and CNF (conjunctive normal form) learners (Mooney, 1995) and a decisionlist learner (Rivest, 1987).
H93-1051 W93-0102
Leacock et al.(1993b), Leacock, Towell, and Voorhees (1993a) and Voorhees, Leacock, and Towell (1995) present results on a Bayesian method (Gale, Church, & Yarowsky, 1992a), a content vector method from information retrieval (Salton, Wong, & Yang, 1975), and a neural network trained using backpropagation (Rumelhart, Hinton, & Williams, 1986).
H93-1051 P92-1032 W93-0102
