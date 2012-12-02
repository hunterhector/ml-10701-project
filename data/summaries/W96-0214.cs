\[Bod, 1995a\] Rens Bod.
E95-1015
\[Schabes et al., 1993\] Yves Schabes, Michal Roth, and Randy Osborne.
E93-1040
Bod (1993c) shows how to approximate this most probable parse using a Monte Carlo algorithm.
E93-1006
\[Goodman, 1996\] Joshua Goodman.
P96-1024
There are two ways to define a STSG: either as a Stochastic Tree Adjoining Grammar (Schabes, 1992) restricted to substitution operations, or as an extended PCFG in which entire trees may occur on the right hand side, instead of just strings of terminals and nonterminals.
C92-2066
A formal derivation of a very similar algorithm is given elsewhere (Goodman, 1996); only the intuition is given here.
P96-1024
We have previously performed a detailed comparison between the most likely parse, and the Maximum Constituents Parse for Probabilistic Context Free Grammars (Goodman, 1996); we showed that the two have very similax performance on a broad range of measures, with at most a 10% difference in error rate (i.e., a change from 10% error rate to 9% error rate).
P96-1024
For instance, Bod (1993b) compares these results to Schabes (1993), in which, for short sentences, 30% of the sentences have no crossing brackets (a much easier measure than exact match).
E93-1006 E93-1040
Even Bod's thesis (Bod, 1995a) does not contain enough information to replicate his results.
E95-1015
\[Schabes, 1992\] Y.
C92-2066
Schabes. 1992.
C92-2066
\[Pereira and Schabes, 1992\] Fernando Pereira and Yves Schabes.
C92-2066 P92-1017
\[Bod, 1993b\] Rens Bod.
E93-1006
\[Bod, 1993a\] Rens Bod.
E93-1006
According to his thesis (Bod, 1995a, page 64), only one of his 75 test sentences had a correct parse which could not be generated from the training data.
E95-1015
We use the reduction and algorithm to parse held out test data, comparing these results to a replication of Pereira and 143 S NP VP PN PN V NP DET N Figure 1: Training corpus tree for DOP example Schabes (1992) on the same data.
C92-2066 P92-1017
Cambridge, MA 02138 goodman@das.harvard.edu Abstract Excellent results have been reported for DataOriented Parsing (DOP) of natural language texts (Bod, 1993c).
E93-1006
\[Bod, 1993c\] Rens Bod.
E93-1006
Experimental Results and Discussion We are grateful to Bod for supplying the data that he used for his experiments (Bod, 1995b, Bod, 1995a, Bod, 1993c).
E93-1006 E95-1015
\[Hemphill et al., 1990\] Charles T.
H90-1021
Ten data sets were constructed by randomly splitting minimally edited ATIS (Hemphill et al., 1990) sentences into a 700 sentence training set, and 88 sentence test set, then discarding sentences of length > 30.
H90-1021
This differs significantly from the results reported by Bod, and is comparable to results from a duplication of Pereira and Schabes's (1992) experiment on the same data.
C92-2066 P92-1017
\[Bod, 1995b\] Rens Bod.
E95-1015
It takes about 6 seconds per sentence to run our algorithm on an HP 9000/715, versus 3.5 hours to run Bod's algorithm on a Sparc 2 (Bod, 1995b).
E95-1015
Unfortunately, Bod (1993c, 1992) was not able to find an efficient exact * I would like to acknowledge support from National Science Foundation Grant IRI-9350192 and a National Science Foundation Graduate Student Fellowship.
E93-1006
Bod (1993a, 1995a) shows that the most probable derivation does not perform as well as the most probable parse for the DOP model, getting 65% exact match for the most probable derivation, versus 96% correct for the most probable parse.
E93-1006 E95-1015
