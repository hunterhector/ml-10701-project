For instance, with the advent of news aggregator services such as “Google News”, one can readily collect multiple news stories covering the same news item (Dolan et al., 2004).
C04-1051
Dolan et al.(2004) used Web-aggregated news stories to learn both sentence-level and word-level alignments.
C04-1051
Barzilay and Elhadad (2003) apply a 4-step algorithm: 1.
W03-1004
Second, there can be large segments that diverge from the linear order predicted by a global alignment, as illustrated by the oval in Figure 3 (Figure 2, (Barzilay and Elhadad, 2003)).
W03-1004
The Britannica corpus, collected and annotated by Barzilay and Elhadad (2003), consists of 103 pairsofcomprehensive andelementary encyclopedia entries describing major world cities.
W03-1004
The Decomposition method (Jing, 2002) relies on the observation that document summaries are often constructed by extracting sentence fragments from the document.
J02-4006
The paper reports the precision at 55.8% recall, since the Decomposition method (Jing, 2002) only produced results at this level of recall, as some of the method’s parameters were hard-coded.
J02-4006
In subsequent work, the same authors (Quirk et al., 2004) used such matched sentence pairs to train Giza++ (Och and Ney, 2003) on word-level alignment.
J03-1002 W04-3219
Precision/recall values atthis threshold are also indicated in the figure.6 1 0.9 0.8 0.7 0.6 0.7 0.6 0.558 0.5 0.4 0.3 Precision Recall TF*IDF + Align Precision TF*IDF Precision Precision @ 55.8 Recall PrecisionPrecision Precision/Recall @ th Figure 5: Precision/Recall curves for the Britannica corpus Comparative results with previous algorithms are given in Table 1, in which the results for Barzilay and Elhadad’s algorithm and previous ones are taken from Barzilay and Elhadad (2003).
W03-1004
Dolan. 2004.
C04-1051
For bilingual texts, Gale and Church (1991) demonstrated the extraordinary effectiveness of a global alignment dynamic programming algorithm, where the basic similarity score wasbasedonthedifference insentence lengths, measured in characters.
P91-1023
As noted by Quirk et al.(2004), these are very likely to be matched, as verified on our training set as well.
W04-3219
The hope is, however, that such mappings could be learned by amassing a large corpus of accurately sentence-aligned documents, and then applying a word-alignment algorithm, as proposed by Quirk et al.(2004). Incidentally, examining sentence pairs withhigh TF*IDFsimilarity scores, there are some striking cases that appear to have been missed by the human judges.
W04-3219
Barzilay and Elhadad (2003) suggested that these disadvantages could be at least partially offset by the recurrence of the same lexical items in document pairs.
W03-1004
SimFinder (Hatzivassiloglou et al., 1999; Hatzivassiloglou et al., 2001) examined 43 different features that could potentially help determine the similarity of two short text units (sentences or paragraphs).
W99-0625
Several authors have suggested that large-scale aligned monolingual corpora could be similarly used to advance the performance of monolingual text-to-text rewriting systems, for tasks including summarization (Knight and Marcu, 2000; Jing, 2002) and paraphrasing (Barzilay and Elhadad, 2003; Quirk et al., 2004).
J02-4006 W03-1004 W04-3219
word overlap to TF*IDF Barzilay and Elhadad (2003) use a cosine measure of word-overlap as a baseline for the task.
W03-1004
