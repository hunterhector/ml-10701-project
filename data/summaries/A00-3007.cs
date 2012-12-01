For each document d in collection read in a noun stem w from d for each synset s in which w occurs get the column b in the association matrix M that corresponds to s if the column already exists; create a new column for s otherwise for each word stem j appearing in the 100-word window around w get the row a in M that corresponds to j if the row already exists; create a new row for j otherwise add a distance-adjusted weight to M\[a\]\[b\] Figure 1: WSD Algorithm: the training phase Set value = 1 For each word w to be disambiguated get synsets of w for each synset x ofw for each wi in the context ofw (within the 100-window around w) calculate Pc(wilx) value *= ( 1 Pc(wilx)) P(context(w)lx) = 1 value Calculate pc(x) P(xlcontext(w)) = p~(x)* P(eontext(w)lx) display a ranked list of the synsets arranged according to their P(xlcontext(w)) in decreasing order Figure 2: WSD Algorithm: the sense prediction phase 37 5 Evaluation As suggested by the WSD literature, evaluation of word sense disambiguation systems is not yet standardized (Resnik and Yarowsky, 1997).
W97-0213
Some WSD evaluations have been done using the Brown Corpus as training and testing resources and comparing the results against SemCor 3, the sense-tagged version of the Brown Corpus (Agirre and Rigau, 1996; Gonzalo et al., 1998).
C96-1005 W98-0705
Others have used common test suites such as the 2094-word line data of Leacock et al.(1993). Still others have tended to use their own metrics.
H93-1051
Corpora contain examples of words that enable the development of statistical models of word senses and their contexts (Ide and Veronis, 1998; Leacock and Chodorow, 1998).
J98-1001
Yarowsky (1992) used Rogets Thesaurus categories as classes for WSD.
C92-2070
