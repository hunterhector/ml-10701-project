A number of studies are related to the work we presented, most specifically work on parallel-text based “information projection” for parsing (Hwa et al., 2002), but also grammar induction work based on constituent/distituent information (Klein and Manning, 2002) and (language-internal) alignmentbased learning (van Zaanen, 2000).
C00-2139 P02-1017
We use the Europarl corpus (Koehn, 2002), and the statistical word alignment was performed with the GIZA++ toolkit (Al-Onaizan et al., 1999; Och and Ney, 2003).1 For the current experiments we assume no preexisting parser for any of the languages, contrary to the information projection scenario.
J03-1002
From the resulting (noisy) dependency treebank, a dependency parser is trained using the techniques of (Collins, 1999).
P99-1065
For each span in the chart, we get a weight factor that is multiplied with the parameter-based expectations.9 4 Experiments We applied GIZA++ (Al-Onaizan et al., 1999; Och and Ney, 2003) to word-align parts of the Europarl corpus (Koehn, 2002) for English and all other 10 languages.
J03-1002
We follow an evaluation criterion that (Klein and Manning, 2002, footnote 3) discuss for the evaluation of a not fully supervised grammar induction approach based on a binary grammar topology: bracket multiplicity (i.e., non-branching projections) is collapsed into a single set of brackets (since what is relevant is the constituent structure that was induced).11 For comparison, we provide baseline results that a uniform left-branching structure and a uniform right-branching structure (which encodes some nontrivial information about English syntax) would give rise to.
P02-1017
In the “information projection” approach (e.g., (Yarowsky and Ngai, 2001)), statistical word alignment is applied to a parallel corpus of English and some other language a0 for which no tagger/morphological analyzer/chunker etc.
N01-1026
(Wu, 1997) also includes a brief discussion of crossing constraints that can be derived from phrase structure correspondences.
J97-3002
(Klein and Manning, 2002)).
P02-1017
(Koehn et al., 2003) show that exploiting all contiguous word blocks in phrase-based alignment is better than focusing on syntactic constituents only.
N03-1017
