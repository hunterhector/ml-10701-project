7 Next, a word-to-word translation model (Melamed 2000) was trained on the dictionary.
J00-2004
Using the manually set thresholds for dp and n, we have obtained 100% precision and 68.6% recall in an experiment using STRAND to find English-French Web pages (Resnik 1999).
P99-1068
E-mail: nasmith@cs.jhu.edu 350 Computational Linguistics Volume 29, Number 3 Melamed 1997; Menezes and Richardson 2001), and the like.
W01-1406 W97-0311
The value of the parameter-tuning process is dramatically confirmed by comparing the learned parameters with STRAND’s default parameters (manually determined by Resnik [1999]).
P99-1068
The training procedure was an expectationmaximization (EM) procedure like that used by Melamed (2000), except that maximum weighted bipartite matching was used instead of competitive linking.
J00-2004
Smith (2002) suggested a bootstrapping paradigm for the construction of parallel corpora.
W02-1013
They represent resources for automatic lexical acquisition (e.g., Gale and Church 1991; Melamed 1997), they provide indispensable training data for statistical translation models (e.g., Brown et al.1990; Melamed 2000; Och and Ney 2002), and they can provide the connection between vocabularies in cross-language information retrieval (e.g., Davis and Dunning 1995; Landauer and Littman 1990; see also Oard 1997).
H91-1026 J00-2004 J90-2002 P02-1038 W97-0311
As noted by Melamed (2000), the problem of finding the best set of links is the maximum-weighted bipartite matching (MWBM) problem: Given a weighted bipartite graph G =(V 1 ∪ V 2, E) with edge weights c i,j (i ∈ V 1, j ∈ V 2 ), find a matching M ⊆ E such that each vertex has at most one edge in M and summationtext e∈M c i,j is maximized.
J00-2004
The test set contains 293 of the 326 pairs in Resnik’s (1999) test set.
P99-1068
362 Computational Linguistics Volume 29, Number 3 Melamed (2000) used a greedy approximation to MWBM called competitive linking.
J00-2004
Translational Similarity We define a cross-language similarity score, tsim, for two texts by starting with a generative, symmetric word-to-word model of parallel texts (Melamed’s [2000] Method A).
J00-2004
We have demonstrated that the tsim score can be used to extract translationally equivalent English-Chinese sentence pairs from even a noisy space with high precision (Smith 2002).
W02-1013
In earlier work (Smith 2002), we sought to show how multiple linguistic resources could be exploited in combination to recognize translation, and how the equiprobability assumption allowed straightforward combination of resources (i.e., set union of translation lexicon entries).
W02-1013
Using the enhanced, weighted lexicon as a Dirichlet prior (containing 77,699 entries and a total count of 85,332), a word-to-word translation model (Melamed 2000) was trained on a verse-aligned Bible (15,548 verses, averaging 25.5 English words, 23.4 French words after tokenization).
J00-2004
Resnik, Oard, and Levow (2001) showed that a translation lexicon automatically extracted from the French-English STRAND data could be combined productively with a bilingual French-English dictionary in order to improve retrieval results using a standard cross-language IR test collection (English queries against the CLEF-2000 French collection, which contains approximately 21 million words from articles in Le Monde).
H01-1033
This approach to minimally supervised classifier construction has been widely studied (Yarowsky 1995), especially in cases in which the features of interest are orthogonal in some sense (e.g., Blum and Mitchell 1998; Abney 2002).
P02-1046 P95-1026
Things have improved somewhat, but it is still fair to say that for all but a relatively few language pairs, parallel corpora tend to be accessible only in specialized forms such as United Nations proceedings (e.g., via the Linguistic Data Consortium, 〈http://www.ldc.upenn.edu〉), religious texts (Resnik, Olsen, and Diab 1999), localized versions of software manuals (Resnik and ∗ Department of Linguistics and Institute for Advanced Computer Studies, University of Maryland, College Park, MD 20742.
P99-1068
At different thresholds, Cohen’s κ score of agreement (with each of Resnik’s (1999) two judges and their intersection) may be computed for comparison with STRAND, along with recall and precision against a gold standard (for which we use the intersection of the judges: the set of examples 8 There is some circularity here; the cognates were derived using weighted word pairs from the Bible, then used again in the prior distribution.
P99-1068
2. The STRAND Web-Mining Architecture STRAND (Resnik 1998, 1999) is an architecture for structural translation recognition, acquiring natural data.
P99-1068
It presents, in revised and considerably extended form, our early work on mining the Web for bilingual text (STRAND) (Resnik 1998, 1999), incorporating new work on content-based detection of translations (Smith 2001, 2002), and efficient exploitation of the Internet Archive.
H01-1033 P99-1068 W02-1013
More recently, researchers at Johns Hopkins University and the University of Maryland have been exploring new ways to exploit parallel corpora in order to develop monolingual resources and tools, using a process of annotation, projection, and training: Given a parallel corpus in English and a less resource-rich language, we project English annotations across the parallel corpus to the second language, using word-level alignments as the bridge, and then use robust statistical techniques in learning from the resulting noisy annotations (Cabezas, Dorr, and Resnik 2001; Diab and Resnik 2002; Hwa et al.2002; Lopez et al.2002; Yarowsky, Ngai, and Wicentowski 2001; Yarowsky and Ngai 2001; Riloff, Schafer, and Yarowsky 2002).
C02-1070 H01-1033 H01-1035 N01-1026 P02-1033 P02-1050
We note that this threshold differs from that reported in Smith (2002); it was chosen by the same procedure, though the translation lexicon is different, moving the distribution of tsim scores into a higher range.
W02-1013
For all these reasons, it is difficult to follow the “more data are better data” advice of Church and Mercer (1993), abandoning balance in favor of volume, with respect to parallel text.
J93-1001
The Arabic texts were tokenized at punctuation, then romanized and converted to root forms using a morphological analysis tool (Darwish 2002).
W02-0506
We add to this dictionary a list of English-French cognate pairs, identified using the method of Tiedemann (1999).
W99-0626
