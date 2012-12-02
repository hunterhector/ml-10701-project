For English, we used the Penn Treebank version 3.0 (Marcus et al., 1993) and extracted dependency relations by applying the head-finding rules of (Yamada and Matsumoto, 2003).
J93-2004
Our intended application is machine translation in the Microsoft Research Treelet Translation System (Quirk et al., 2005; Menezes and Quirk, 2005).
P05-1034
Also, we chose to average each individual perceptron (Collins, 2002) prior to Bayesian averaging.
W02-1001
Evaluation against the blind test set was performed using part-of-speech labels assigned by the tagger described in (Toutanova et al., 2003).
N03-1033
Examples include the margin perceptron (Duda et al., 2001), ALMA (Gentile, 2001), and MIRA (which is used to train the parser in (McDonald et al., 2005a)).
P05-1012
The feature types are essentially those described in (McDonald et al., 2005a).
P05-1012
to (McDonald et al., 2005b) for a detailed treatment of both algorithms.
P05-1012
We reimplemented Eisner’s decoder (Eisner, 1996), which searches among all projective parse trees, and the Chu-Liu-Edmonds’ decoder (Chu and Liu, 1965; Edmonds, 1967), which searches in the space of both projective and non-projective parses.
C96-1058
The averaged perceptron (Collins, 2002) is a variant which averages the w across all iterations; it has demonstrated good generalization especially with data that is not linearly separable, as in many natural language processing problems.
W02-1001
The graph shows the average 4 (Wang et al., 2005) report numbers for undirected dependencies on the Chinese Treebank 3.0.
W05-1516
Eisner. 1996.
C96-1058
1 3 Parser Architecture We take as our starting point a re-implementation of McDonald’s state-of-the-art dependency parser (McDonald et al., 2005a).
P05-1012
The results reported here for English and Czech are comparable to the previous best published numbers in (McDonald et al., 2005a), as Table 3 shows.
P05-1012
Perceptron 82.9 88.0 30.3 (inc punc) MIRA 83.3 88.6 31.3 Bayes Point Machine 84.0 88.8 30.9 Table 3: Comparison to previous best published results reported in (McDonald et al., 2005a).
P05-1012
For evaluation against the blind test section, we used an implementation of the tagger described in (Toutanova et al., 2003).
N03-1033
We have successfully replicated the state-of-the-art results for dependency parsing (McDonald et al., 2005a) for both Czech and English, using Bayes Point Machines.
P05-1012
For the comparison of English dependency accuracy excluding punctuation, MIRA and BPM are both statistically significantly better than the averaged perceptron result reported in (McDonald et al., 2005a).
P05-1012
Again, since neither MIRA nor BPM outperforms the other on all measures, we conclude that the results constitute a valiation of the results reported in (McDonald et al., 2005a).
P05-1012
From the fact that neither MIRA nor BPM clearly outperforms the other, we conclude that we have successfully replicated the results reported in (McDonald et al., 2005a) for English.
P05-1012
