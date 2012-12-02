In fact, left-corner parsing can be simulated by a top-down parser by transforming the grammar, as was done in Roark and Johnson (1999), and so an approach very similar to the one outlined here could be used in that case.
P99-1054 P99-1069
Figure 6 shows the observed time at our standard base beam of 10 -11 with the full conditioning regimen, alongside an approximation of the reported observed (linear) time in Ratnaparkhi (1997).
W97-0301
It has been shown repeatedly--e.g., Briscoe and Carroll (1993), Charniak (1997), Collins (1997), Inui et al.(1997), Johnson (1998)--that conditioning the probabilities of structures on the context within which they appear, for example on the lexical head of a constituent (Charniak 1997; Collins 1997), on the label of its parent nonterrninal (Johnson 1998), or, ideally, on both and many other things besides, leads to a much better parsing model and results in higher parsing accuracies.
J93-1002 J98-4004 P97-1003 W98-1115
Paper Perplexity Trigram Baseline Model Interpolation, A = .36 Chelba and Jelinek (1998a) 167.14 158.28 Chelba and Jelinek (1998b) 167.14 153.76 Current results 167.02 152.26 148.90 147.70 137.26 count of the conditioning words in the training corpus, and maximum likelihood mixing coefficients were calculated for each bin, to mix the trigram with bigram and unigram estimates.
P98-1035
LR and LP are part of the standard set of PARSEVAL measures of parser quality (Black et al.1991). From this set of measures, we will also include the crossing bracket scores: average crossing brackets (CB), percentage of sentences with no crossing brackets (0 CB), and the percentage of sentences with two crossing brackets or fewer (< 2 CB).
H91-1060
Table 4 compares the perplexity of our model with Chelba and Jelinek (1998a, 1998b) on the same training and testing corpora.
P98-1035
3. Previous Work There have been attempts to jump over adjacent words to words farther back in the left context, without the use of dependency links or syntactic structure, for example Saul and Pereira (1997) and Rosenfeld (1996, 1997).
W97-0309
Accuracy and Efficiency The first set of results looks at the performance of the parser on the standard corpora for statistical parsing trials: Sections 2-21 (989,860 words, 39,832 sentences) of the Penn Treebank (Marcus, Santorini, and Marcinkiewicz 1993) served as the training data, Section 24 (34,199 words, 1,346 sentences) as the held-out data for parameter estimation, and Section 23 (59,100 words, 2,416 sentences) as the test data.
J93-2004
These parsers can calculate word probabilities based upon the parser state--as in Chelba and Jelinek (1998a)--but such a distribution is not generative from the probabilistic grammar.
P98-1035
This procedure yields conditional probability distributions of 10 Johnson et al.(1999), Henderson and Brill (1999), and Collins (2000) demonstrate methods for choosing the best complete parse tree from among a set of complete parse trees, and the latter two show accuracy improvements over some of the parsers cited above, from which they generated their candidate sets.
P99-1069 W99-0623
Like the nonlexicalized parser in Roark and Johnson (1999), we found that the search efficiency, in terms of number of rule expansions considered or number of analyses advanced, also improved as we increased the amount of conditioning.
P99-1054 P99-1069
String prefix probabilities can be straightforwardly used to compute conditional word probabilities by definition: P(Wj+l I wg) = P(wg+l) P(wg) (7) Stolcke and Segal (1994) and Jurafsky et al.(1995) used these basic ideas to estimate bigram probabilities from hand-written PCFGs, which were then used in language models.
J95-2002 P94-1011
There are efficient algorithms in the literature (Jelinek and Lafferty 1991; Stolcke 1995) for calculating exact string prefix probabilities given a PCFG.
J91-3004 J95-2002
The parsers with the highest published broad-coverage parsing accuracy, which include Charniak (1997, 2000), Collins (1997, 1999), and Ratnaparkhi (1997), all utilize simple and straightforward statistically based search heuristics, pruning the search-space quite dramatically.
A00-2018 P97-1003 W97-0301
Thus,,~(Wio_l) = ~0 if ~dcH~,~it P(d) = 0 (17) t .999 otherwise Chelba and Jelinek (1998a, 1998b) also used a parser to help assign word probabilities, via the structured language model outlined in Section 3.2.
P98-1035
The differences between a k-best and a beam-search parser (not to mention the use of dynamic programming) make a running time difference unsur17 Our score of 85.8 average labeled precision and recall for sentences less than or equal to 100 on Section 23 compares to: 86.7 in Charniak (1997), 86.9 in Ratnaparkhi (1997), 88.2 in Collins (1999), 89.6 in Charniak (2000), and 89.75 in Collins (2000).
A00-2018 W97-0301
In addition, we show the average number of rule expansions considered per word, that is, the number of rule expansions for which a probability was calculated (see Roark and Charniak \[2000\]), and the average number of analyses advanced to the next priority queue per word.
A00-2018
Chi and Geman (1998) proved that any PCFG estimated from a treebank with the relative frequency estimator is tight.
J98-2005
The leftfactorization transform that we use is identical to what is called right binarization in Roark and Johnson (1999).
P99-1054 P99-1069
Top-Down Parsing and Language Modeling Statistically based heuristic best-first or beam-search strategies (Caraballo and Charniak 1998; Charniak, Goldwater, and Johnson 1998; Goodman 1997) have yielded an enormous improvement in the quality and speed of parsers, even without any guarantee that the parse returned is, in fact, that with the maximum likelihood for the probability model.
J98-2004 J98-4004 W97-0302 W98-1115
This is how Johnson (1998) conditioned the probabilities of productions: the left-hand side is no longer, for example, S, but rather STSBAR, i.e., an S with SBAR as parent.
J98-4004
Examples of this are bilexical grammars--such as Eisner and Satta (1999), Charniak (1997), Collins (1997)--where the lexical heads of each constituent are annotated on both the rightand left-hand sides of the context-free rules, under the constraint that every constituent inherits the lexical head from exactly one of its children, and the lexical head of a POS is its terminal item.
P97-1003 P99-1059
The structured language model (SLM) used in Chelba and Jelinek (1998a, 1998b, 1999), Jelinek and Chelba (1999), and Chelba (2000) is similar to that of Goddeau, except that (i) their shift-reduce parser follows a nondeterministic beam search, and (ii) each stack entry contains, in addition to the nonterminal node label, the headword of the constituent.
P98-1035
