In all the evaluations reported in this paper we test our parser over a gold-standard set of relational dependencies compatible with our parser output derived (Briscoe and Carroll, 2006) from the PARC 700 Dependency Bank (DepBank, henceforth).
P06-4020
These somewhat negative results, in contrast to those of Pereira and Schabes (1992), suggest that EM techniques require fairly determinate training data to yield useful models.
P92-1017
Elworthy (1994) and Merialdo (1994) demonstrated that Baum-Welch does not necessarily improve the performance of an HMM part-ofspeech tagger when deployed in an unsupervised or semi-supervised setting.
A94-1009 J94-2001
An immediate benefit of this work is that (re)training parsers with incrementally-modified grammars based on different linguistic frameworks should be much more straightforward – see, for example Oepen et al.(2002) for a good discussion of the problem.
C02-2025
More recently, both Riezler et al.(2002) and Clark and Curran (2004) have successfully trained maximum entropy parsing models utilizing all derivations in the model consistent with the annotation of the WSJ PTB, weighting counts by the normalized probability of the associated derivation.
P02-1035 P04-1014
For instance, Gildea (2001) reports that WSJ-derived bilexical parameters in Collins’ (1999) Model 1 parser contribute about 1% to parse selection accuracy when test data is in the same domain, but yield no improvement for test data selected from the Brown Corpus.
W01-0521
Our findings support those of Elworthy (1994) and Merialdo (1994) for POS tagging and suggest that EM is not always the most suitable semi-supervised training method (especially when some in-domain training data is available).
A94-1009 J94-2001
The microaveraged F1 score for the baseline system using this evaluation scheme is 75.61%, which – over similar sets of relational dependencies – is broadly comparable to recent evaluation results published by King and collaborators with their state-of-theart parsing system (Briscoe et al., 2006).
P06-4020
These findings may not hold if the level of bracketing available does not adequately constrain the parses considered – see Hwa (1999) for a related investigation with EM.
P99-1010
Following Pereira and Schabes (1992) given t = (s,U), a node’s span in the parse forest is valid if it does not overlap with any span outlined in U, and hence, a derivation is correct if the span of every node in the derivation is valid in U.
P92-1017
The graphs of EM performance from iteration 1 illustrate the same ‘classical’ and ‘initial’ patterns observed by Elworthy (1994).
A94-1009
corresponding normalized inside-outside weight for each node (Watson et al., 2005).
W05-1517
24 constructed from this backbone (Tomita, 1987).
J87-1004
However, Pereira and Schabes (1992) adapted the IOA to apply over semi-supervised data (unlabeled bracketings) extracted from the PTB.
P92-1017
We therefore, following Gildea (2001) and others, consider S, and also the baseline training data, B, as out-ofdomain training data.
W01-0521
