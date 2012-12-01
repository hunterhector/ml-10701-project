The MAP framework is general enough to include some previous model adaptation approaches, such as corpus mixing in Gildea (2001), for example.
W01-0521
We will show below that weighted count merging is a special case of MAP adaptation; hence the approach of Gildea (2001) cited above is also a special case of MAP Edmonton, May-June 2003 Main Papers, pp.
W01-0521
2See Johnson (1998) for a presentation of the transform/detransform paradigm in parsing.
J98-4004
Further, as in Roark (2001a; 2003), the production probabilities are conditioned on the label of the left-hand side of the production, as well as on features from the left-context.
J01-2004
We will compare our supervised adaptation performance with the results presented in Gildea (2001).
W01-0521
Hwa (1999) used a variant of the inside-outside algorithm presented in Pereira and Schabes (1992) to exploit a partially labeled out-of-domain treebank, and found an advantage to adaptation over direct grammar induction.
P92-1017 P99-1010
In contrast to the results in Gildea (2001), we show F-measure parsing accuracy gains of as much as 2.5% for high accuracy lexicalized parsing through the use of out-of-domain treebanks, with the largest gains when the amount of indomain data is small.
W01-0521
The PCFG is a Markov grammar (Collins, 1997; Charniak, 2000), i.e. the production probabilities are estimated by decomposing the joint probability of the categories on the right-hand side into a product of conditionals via the chain rule, and making a Markov assumption.
A00-2018 P97-1003
Johnson and Riezler (2000) looked at adding features to a maximum entropy model for stochastic unification-based grammars (SUBG), from corpora that are not annotated with the SUBG, but rather with simpler treebank annotations for which there are much larger treebanks.
A00-2021 C00-1052
Hwa (2001) demonstrated how active learning techniques can reduce the amount of annotated data required to converge on the best performance, by selecting from among the candidate strings to be annotated in ways which promote more informative examples for earlier annotation.
W01-0710
Gildea (2001) simply added the out-of-domain treebank to his in-domain training data, and derived a very small benefit for his high accuracy, lexicalized parser, concluding that even a large amount of out-of-domain data is of little use for lexicalized parsing.
W01-0521
Hwa (1999) and Gildea (2001) looked at adapting parsing models trained on large amounts of annotated data from outside of the domain of interest (out-of-domain), through the use of a relatively small amount of in-domain annotated data.
P99-1010 W01-0521 W01-0710
In this direction, Gildea (2001) also reported very small improvements when adding in the out-of-domain treebank.
W01-0521
Whereas Gildea (2001) reported parsing results just for sentences of length less than or equal to 40, our results are for all sentences.
W01-0521
and parser For the empirical trials, we used a top-down, left-to-right (incremental) statistical beam-search parser (Roark, 2001a; Roark, 2003).
J01-2004
Collins. 1997.
P97-1003
Chi and Geman (1998) proved that this condition is met if the rule probabilities are estimated using relative frequency estimation from a corpus.
J98-2005
For the Brown corpus portion, we obtained the training and evaluation sections used in Gildea (2001).
W01-0521
Gildea (2001) merged the two corpora, which just adds the counts from the out-ofdomain treebank to the in-domain treebank, i.e.
W01-0521
The trees are transformed with a selective left-corner transformation (Johnson and Roark, 2000) that has been flattened as presented in Roark (2001b).
A00-2021 C00-1052 J01-2004
Model interpolation in this case perSystem Training Heldout LR LP MAP Brown;T Brown;H 76.0 75.4 MAP Brown;T WSJ;24 76.9 77.1 Gildea WSJ;2-21 86.1 86.6 MAP WSJ;2-21 WSJ;24 86.9 87.1 Charniak (1997) WSJ;2-21 WSJ;24 86.7 86.6 Ratnaparkhi (1999) WSJ;2-21 86.3 87.5 Collins (1999) WSJ;2-21 88.1 88.3 Charniak (2000) WSJ;2-21 WSJ;24 89.6 89.5 Collins (2000) WSJ;2-21 89.6 89.9 Table 4: Parser performance on WSJ;23, baselines.
A00-2018
Table 3 presents our baseline performance, compared with the Gildea (2001) results.
W01-0521
The conclusion in Gildea (2001), that out-of-domain treebanks are not particularly useful in novel domains, was premature.
W01-0521
