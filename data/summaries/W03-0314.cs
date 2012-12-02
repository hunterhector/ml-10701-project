This step is conservative and the same as step 5 in Moore (2001) or step 6(b) in Kitamura and Matsumoto (1996).
W01-1411 W96-0107
However it is less favorable to “multiword accuracy” provided by Microsoft parsers, being 73-76% accuracy at 12% type coverage (Moore, 2001).
W01-1411
For general multi-word translation, our method seems more comparable to Moore (2001).
W01-1411
We use TnT (Brants, 2000) for English POS tagging and ChaSen (Matsumoto et al., 2000) for Japanese morphological analysis, and label each token to either content or functional depending on its partof-speech.
A00-1031
Our result appears much inferior to Moore (2001) and Melamed (2001) in this respect and may not reach 36% type coverage.
W01-1411
Our preliminary finding supports the work on collocation by Smadja et al.(1996) in that gapped sequences are also an important class of multi-word translations.
J96-1001
We cannot compare our word alignment result to (Moore, 2001), since the real rate of tokens that can be aligned by single-word translation pairs is not explicitly mentioned.
W01-1411
(Marcu and Wong, 2002), while non-probabilistic ones employ a greedy algorithm that extracts translation pairs that give higher association scores than a predefined threshold where the threshold is monotonically decreasing as the algorithm proceeds, e.g.
W02-1018
For this present work, we use Dunning’s log-likelihood ratio statistics (Dunning, 1993) defined as follows: sim = aloga+blogb+clogc+dlogd ¡(a+b)log(a+b)¡(a+c)log(a+c) ¡(b+d)log(b+d)¡(c+d)log(c+d) +(a+b+c+d)log(a+b+c+d) For each bilingual pattern EiJj, we compute its similarity score and qualify it as a bilingual sequence-to-sequence correspondence if no equally strong or stronger association for monolingual constituent is found.
J93-1003
One notable work is that of Marcu and Wong (2002), which is based on a joint probability model for statistical machine translation where word equivalents and phrase (rigid sequence) equivalents are automatically learned form bilingual corpora.
W02-1018
Table 2: Statistics of 150,000 parallel sentences Japanese English content (token) 2,039,656 2,257,806 content (type) 47,316 57,666 functional (token) 2,660,855 1,704,189 functional (type) 1,811 386 3.2 Evaluation Criteria We evaluate our sequence-to-sequence correspondence by accuracy and coverage, which we believe, similar criteria to (Moore, 2001) and (Melamed, 2001) 2.
W01-1411
Given different language pair, different genre of text, different evaluation criteria, we find it difficult to directly compare our result with previous high-accuracy approaches such as (Moore, 2001).
W01-1411
Kupiec (1993) focuses on noun-phrase translations only, Smadja et al.(1996) limits to find French translation of English collocation identified by his Xtract system, and Kitamura and Matsumoto (1996) can exhaustively enumerate only rigid word sequences.
J96-1001 P93-1003 W96-0107
Yamamoto et al.(2001) reports that N-gram translation candidates that do not go beyond the chunk boundary boosts performance.
W01-1412
Previous works that focus on multi-word translation correspondences from parallel corpora include noun phrase correspondences (Kupiec, 1993), fixed/flexible collocations (Smadja et al., 1996), n-gram word sequences of arbitrary length (Kitamura and Matsumoto, 1996), non-compositional compounds (Melamed, 2001), captoids (Moore, 2001), and named entities 1.
J96-1001 P93-1003 W01-1411 W96-0107
(Kitamura and Matsumoto, 1996).
W96-0107
Work Moore (2001) presents insightful work which is closest to ours.
W01-1411
