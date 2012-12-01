Further details of the text grammar are given in Briscoe ~ Carroll (1994, 1995).
P94-1040
see Taylor el al., 1989; Alshawi el al., 1992), it is clear that the subsequent grammar refinement phases have led to major improvements in coverage and reductions in spurious ambiguity.
E89-1035
In contrast to previous systems taking as input fullydeterminate sequences of PoS labels, such as Fidditch (Hindle, 1989) and MITFP (de Marcken, 1990), for each word the tagger returns multiple label hypotheses, and each is thresholded before being passed on to the parser: a given label is retained if it is the highest-ranked, or, if the highestranked label is assigned a likelihood of less than 0.9, if its likelihood is within a factor of 50 of this.
P89-1015
The resulting parser is efficient, constructing a parse forest in roughly quadratic time (empirically), and efficiently returning the ranked n-most likely analyses (Carroll, 1993, 1994).
P94-1040
Schabes et al.(1993) and Magerman (1995) report results using the GEIG evaluation scheme which are numerically similar in terms of parse selection to those reported here, but achieve 100% coverage.
E93-1040 P95-1037
The remainder, together with a further set of analyses from 2285 treebank sentences that were not checked manually, were used to train a probabilistic version of the LR parser, using Good-Turing smoothing to estimate the probability of unseen transitions in the LALR(1) table (Briscoe & Carroll, 1993; Carroll, 1993).
J93-1002
Currently, the relative frequency of subcategorisation possibilities for individual lexical items is not recorded in wide-coverage lexicons, such as ANLT or COMLEX (Grishman e¢ al., 1994).
C94-1042
Training Data Size and Accuracy Statistical HMM-based part-of-speech taggers require of the order of 100K words and upwards of training data (Weischedel et al., 1993:363); taggers inducing non-probabilistic rules (e.g.
J93-2006
An LR parser (Briscoe & Carroll, 1993) was applied to unlabelled bracketed sentences from the Susanne treebank, and a new treebank of 1758 correct and complete analyses with respect to the integrated grammar was constructed semi-automatically by manually resolving the remaining ambiguities.
J93-1002
Our less-tightly integrated grammar is described in more detail in Briscoe & Carroll (1994).
P94-1040
Both corpora were retagged using the Acquilex HMM tagger (Elworthy, 1993, 1994) trained on text tagged with a slightly modified version of CLAWS-II labels (Garside et al., 1987).
A94-1009
Further details of the PoS grammar are given in Briscoe & Carroll (1994, 1995).
P94-1040
Church, 1988) for English.
A88-1019
Magerman's (1995) parser is an extension of the history-based parsing approach developed at IBM (Black et al., 1993) in which rules are conditioned on lexical and other (essentially arbitrary) information available in the parse history.
P95-1037
Briscoe ~ Carroll (1993) describe a probablistic parser using a wide-coverage unificationbased grammar of English written in the Alvey Natural Language Tools (ANLT) metagrammatical formalism (Briscoe et al., 1987), generating around 800 rules in a syntactic variant of the Definite Clause Grammar formalism (DCG, Pereira Warren, 1980) extended with iterative (Kleene) operators.
J93-1002
Nevertheless, the relationship between sentence length and processing time is fitted well by a quadratic function, supporting the findings of Carroll (1994) that in practice NL grammars do not evince worst-case parsing complexity.
P94-1040
