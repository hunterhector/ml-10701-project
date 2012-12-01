Recent work has shown how to define probability distributions over the parses of UBGs (Abney, 1997) and efficiently estimate and use conditional probabilities for parsing (Johnson et al., 1999).
J97-4005 P99-1069
We discarded the unambiguous sentences in each corpus for both training and testing (as explained in Johnson et al.(1999), pseudolikelihood estimation ignores unambiguous sentences), leaving us with a corpus of 324 ambiguous sentences in the Verbmobil corpus and 481 sentences in the Homecentre corpus; these sentences had a total of 3,245 and 3,169 parses respectively.
P99-1069
In order to avoid sparse data problems we smoothed this distribution over tuples as described in (Rooth et al., 1999).
P99-1014
The (non-auxiliary) features used in were based on those described by Johnson et al.(1999). Different numbers of features were used with the two corpora because some of the features were generated semiautomatically (e.g., we introduced a feature for every attribute-value pair found in any feature structure), and "pseudo-constant" features (i.e., features whose values never differ on the parses of the same sentence) are discarded.
P99-1069
As Abney (1997) showed, under these circumstances the relative frequency estimator is in general inconsistent, even if one restricts attention to rule features.
J97-4005
Apart from the auxiliary distributions, we based our 155 features on those used in Johnson et al.(1999), which should be consulted for further details.
P99-1069
For the reasons explained in Johnson et al.(1999) we actually estimate )~ by maximizing a regularized version of the log pseudo-likelihood (5), where aj is 7 times the maximum value of fj found in the training corpus: m ~2 logPL~(~) ~ 2"~2 (5) j=l vj See Johnson et al.(1999) for details of the calculation of this quantity and its derivatives, and the conjugate gradient routine used to calculate the )~ which maximize the regularized log pseudo-likelihood of the training corpus.
P99-1069
The maximum likelihood estimates are the )~ which maximize (2), or equivalently, which make (3) zero, but as Johnson et al.(1999) explain, there seems to be no practical way of computing these for realistic SUBGs since evaluating (2) and its derivatives (3) involves integrating over all syntactic structures ft.
P99-1069
selectional preferences The auxiliary distribution we used here is based on the probabilistic model of lexical selectional preferences described in Rooth et al.(1999). An existing broad-coverage parser was used to find shallow parses (compared to the LFG parses) for the 117 million word British National Corpus (Carroll and Rooth, 1998).
P99-1014
