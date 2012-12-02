Wordsc = {Word~\[Wor& has sense subsumed by c} Freqc = E Countw w E Words= Pc = Freqc N sim(wi, wj) = max \[-log Jbc\] cEsubsumers(w~,wi) Figure 5: Calculation of similarity (Resnik, 1995) match-similarity(synset, concept) for each pair of nouns wi, wj from the definitions sims,# = calc-sim(w~, wj) misi,j = most-informative~subsumer(wi, wj) if misij E subsumers(synset) then increase synset-support by sim~,j increase normalization by simij score is synset-support scaled by normalization Figure 6: Similarity-based heuristic 3.3 Miscellaneous matching heuristics The remaining heuristics are similar in that they each are based on degree of overlap in word-based matching.
W95-0105
The following table indicates the amount of effort that was required for developing the initial Spanish lexicon entries from scratch (Viegas et al., 1996): 6798 word-sense entries (as of 29 Mar 1996) Average of 1.2 meaning per word form Acquisition rate: 45 entries/day per person Acquisition effort: 4 person years Like many research centers, we don't have the human resources to construct the entire lexicons manually, so we are investigating several different ways to automate lexicon acquisition.
P96-1005
Chang and Chen (1996) describe an algorithm for augmenting LDO£'E with information from Longman's Lexicon of Contemporary English (LLOCE).
W96-0305
This is based on a technique for disambiguating noun groups using WordNet by Resnik (1995).
W95-0105
Viegas et al.(1996) discuss one approach at this through the use of lexical rules, such as for generating the morpho-semantic derivatives of Spanish verbs.
P96-1005
This is based on the technique Resnik (1995) uses for disambiguating noun groups.
W95-0105
