Table 6 shows 3An exception is Golding (1995), who uses the entire Brown corpus for training (1M words) and 3/4 of the Wall Street Journal corpus (Marcus et al., 1993) for testing.
J93-2004 W95-0104
They obtain information about noun countability by merging lexical entries from COMLEX (Grishman et al., 1994) and the ALTJ/E Japanese-to-English semantic transfer dictionary (Ikehara et al., 1991).
C94-1042
Most methods are trained and tested on Model Alta BNC Model Alta BNC f (t) 72.98 70.00 f (w1;t;w2)= f (t) 87.77 76.33 f (w1;t) 84.40 83.02 f (w1;w2;t)= f (t) 86.27 74.47 f (t;w1) 84.89 82.74 f (t;w2;w2)= f (t) 84.94 74.23 f (w1;t;w2) 89.24#*77.13 f (w1;t;w2)= f (w1;t) 80.70 73.69 f (w1;w2;t) 87.13 74.89 f (w1;t;w2)= f (t;w2) 82.24 75.10 f (t;w1;w2) 84.68 75.08 f (w1;w2;t)= f (w2;t) 72.11 69.28 f (w1;t)= f (t) 82.81 77.84 f (t;w1;w2)= f (t;w1) 75.65 72.57 f (t;w1)= f (t) 77.49 80.71# Table 5: Performance of Altavista counts and BNC counts for context sensitive spelling correction (data from Cucerzan and Yarowsky 2002) Model Accuracy Baseline BNC 70.00 Baseline Altavista 72.98 Best BNC 80.71†‡ Golding (1995) 81.40 Jones and Martin (1997) 84.26 Best Altavista 89.24†‡ Golding and Schabes (1996) 89.82 Mangu and Brill (1997) 92.79 Cucerzan and Yarowsky (2002) 92.20 Golding and Roth (1999) 94.23 Table 6: Performance comparison with the literature for context sensitive spelling correction the Brown corpus, using 80% for training and 20% for testing.3 We devised a simple, unsupervised method for performing spelling correction using web counts.
A97-1025 P96-1010 W02-1005 W95-0104
The simplest model of compound noun disambiguation compares the frequencies of the two competing analyses and opts for the most frequent one (Pustejovsky et al., Model Alta BNC Baseline 63.93 63.93 f (n1;n2) : f (n2;n3) 77.86 66.39 f (n1;n2) : f (n1;n3) 78.68# 65.57 f (n1;n2)= f (n1) : f (n2;n3)= f (n2) 68.85 65.57 f (n1;n2)= f (n2) : f (n2;n3)= f (n3) 70.49 63.11 f (n1;n2)= f (n2) : f (n1;n3)= f (n3) 80.32 66.39 f (n1;n2) : f (n2;n3) (NEAR) 68.03 63.11 f (n1;n2) : f (n1;n3) (NEAR) 71.31 67.21 f (n1;n2)= f (n1) : f (n2;n3)= f (n2) (NEAR) 61.47 62.29 f (n1;n2)= f (n2) : f (n2;n3)= f (n3) (NEAR) 65.57 57.37 f (n1;n2)= f (n2) : f (n1;n3)= f (n3) (NEAR) 75.40 68.03# Table 8: Performance of Altavista counts and BNC counts for compound bracketing (data from Lauer 1995) Model Accuracy Baseline 63.93 Best BNC 68.036 †‡ Lauer (1995): adjacency 68.90 Lauer (1995): dependency 77.50 Best Altavista 78.68†6 ‡ Lauer (1995): tuned 80.70 Upper bound 81.50 Table 9: Performance comparison with the literature for compound bracketing 1993).
P95-1007
A comparison with the literature shows that the best Altavista model outperforms Golding (1995), Jones and Martin (1997) and performs similar to Golding and Schabes (1996).
A97-1025 P96-1010 W95-0104
To compensate for this, Shaw and Hatzivassiloglou (1999) propose to compute the transitive closure of the ordering relation: if a c and c b, then a b.
P99-1018
Keller and Lapata (2003) investigated the validity of web counts for a range of predicate-argument bigrams (verbobject, adjective-noun, and noun-noun bigrams).
J03-3005
Malouf (2000) further proposes a back-off bigram model of adjective pairs for choosing among alternative orders (P(ha;bijfa;bg) vs.
P00-1012
We start by using web counts for two generation tasks for which the use of large data sets has shown promising results: (a) target language candidate selection for machine translation (Grefenstette, 1998) and (b) context sensitive spelling correction (Banko and Brill, 2001a,b).
H01-1052 P01-1005
The BNC is a static 100M word corpus of British English, which is about 1000 times smaller than the web (Keller and Lapata, 2003).
J03-3005
of Compound Nouns The first analysis task we consider is the syntactic disambiguation of compound nouns, which has received a fair amount of attention in the NLP literature (Pustejovsky et al., 1993; Resnik, 1993; Lauer, 1995).
J93-2005 P95-1007
The BNC model, on the other hand, Altavista BNC Model Count Uncount Count Uncount f (n) 87.01 90.13 87.32# 90.39# f (det;n) 88.38#6 91.22#6 51.01 50.23 f (det;n)= f (n) 83.19 85.38 50.95 50.23 Backoff 87.01 89.80 – – Table 12: Performance of Altavista counts and BNC counts for noun countability detection (data from Baldwin and Bond 2003) achieved a performance that is not significantly different from the baseline, and significantly worse than Lauer’s best model.
P03-1059
We used the same test set (2056 tokens from the Brown corpus) and confusion sets as Golding and Schabes (1996), Mangu and Brill (1997), and Cucerzan and Yarowsky (2002).
P96-1010 W02-1005
We therefore performed our evaluation using Prescher et al.’s (2000) test set of verb-object pairs.
C00-2094
Malouf (2000) extracted 263,838 individual pairs of adjectives from the BNC which he randomly partitioned into test (10%) and training data (90%) and evaluated all the above methods for ordering prenominal adjectives.
P00-1012
The models and their performance on the test set are Model Count Uncount Baseline 74.60 78.30 Best BNC 87.32†‡ 90.39†‡ Best Altavista 88.38†‡ 91.22†‡ Baldwin and Bond (2003) 93.90 95.20 Table 13: Performance comparison with the literature for noun countability detection listed in Table 12.
P03-1059
Our results therefore indicate that large data sets such as those obtained from the web are not the panacea that they are claimed to be (at least implicitly) by authors such as Grefenstette (1998) and Keller and Lapata (2003).
J03-3005
Lauer (1995) proposes an unsupervised method for estimating the frequencies of the competing bracketings based on a taxonomy or a thesaurus.
P95-1007
Each adjective pair ab is encoded as a vector of 16 features (the last eight characters of a and the last eight characters of b) and a class (ha;bi or Model Altavista BNC f (a1;a2) : f (a2;a1) 89.6# 6 ‡ 80.4#‡ f (a1;a2)= f (a2) : f (a2;a1)= f (a1) 83.2 77.0 f (a1;a2)= f (a1) : f (a2;a1)= f (a2) 80.2 80.6 Malouf (2000): memory-based – 91.0 Table 7: Performance of Altavista counts and BNC counts for adjective ordering (data from Malouf 2000) hb;ai).
P00-1012
Lauer (1995) tested both the adjacency and dependency models on 244 compounds extracted from Grolier’s encyclopedia, a corpus of 8 million words.
P95-1007
Keller and Lapata’s (2003) results suggest that webbased frequencies can be a viable alternative to bigram frequencies obtained from smaller corpora or recreated using smoothing.
J03-3005
The majority of proposals are symbolic and therefore limited to a specific domain due to the large effort involved in hand-coding semantic information (see Lauer 1995 for an extensive overview).
P95-1007
Lauer (1995) also experimented with a lexicalized version of (7) where probabilities are calculated on the basis of word (rather than concept) frequencies which Lauer obtained from Grolier’s encyclopedia heuristically via pattern matching.
P95-1007
Altavista BNC high low high low Model ambig ambig ambig ambig f (v;n) 45.74 68.73#6 45.89# 70.06# f (v;n)= f (n) 45.16#6 64.96 46.18 66.07 Table 3: Performance of Altavista counts and BNC counts for candidate selection for MT (data from Prescher et al.2000) high low Model ambig ambig Random baseline 14.20 45.90 Frequency baseline 31.90 45.50 Prescher et al.(2000): verb-argument 43.30 61.50 Best Altavista 45.16†6 ‡ 68.73†6 ‡ Best BNC 45.89†6 ‡ 70.06†6 ‡ Prescher et al.(2000): verb-object 49.40 68.20 Table 4: Performance comparison with the literature for candidate selection for MT 4 Context-sensitive Spelling Correction Context-sensitive spelling correction is the task of correcting spelling errors that result in valid words.
C00-2094
Prescher et al.(2000) concentrate on verbs and their objects.
C00-2094
The task is somewhat simplified by Grefenstette (1998) and Prescher et al.(2000) who do not produce a translation of the entire sentence.
C00-2094
Also, it remains to be shown that the web-based approach scales up to larger n-grams (e.g., trigrams), and to combinations of different parts of speech (Keller and Lapata 2003 only tested bigrams involving nouns, verbs, and adjectives).
J03-3005
The comparison with the literature shows that both the Altavista and the BNC model perform significantly worse than the best model proposed by Baldwin and Bond (2003); this is a supervised model that uses many more features than just singular/plural frequency and det-noun frequency.
P03-1059
Lauer (1995) tested the model in (7) on 282 compounds that he selected randomly from Grolier’s encyclopedia and annotated with their paraphrasing prepositions.
P95-1007
These include a variety of Bayesian classifiers (Golding, 1995; Golding and Schabes, 1996), decision lists (Golding, 1995) transformation-based learning (Mangu and Brill, 1997), Latent Semantic Analysis (LSA) (Jones and Martin, 1997), multiplicative weight update algorithms (Golding and Roth, 1999), and augmented mixture models (Cucerzan and Yarowsky, 2002).
A97-1025 P96-1010 W02-1005 W95-0104
The ordering of prenominal adjectives has sparked a great deal of theoretical debate (see Shaw and Hatzivassiloglou 1999 for an overview) and efforts have concentrated on defining rules based on semantic criteria that account for different orders (e.g., age color, value dimension).
P99-1018
A simple model of compound noun paraphrasing is shown in (6): p = argmaxp P(pjn1;n2)(6) Lauer (1995) points out that the above model contains one parameter for every triple hp;n1;n2i, and as a result Model Altavista BNC f (n1; p) f (p;n2) 50.71 27.85# f (n1; p;n2) 55.71#* 11.42 f (n1; p) f (p;n2)= f (p) 47.14 26.42 f (n1; p;n2)= f (p) 55.00 10.71 Table 10: Performance of Altavista counts and BNC counts for compound interpretation (data from Lauer 1995) Model Accuracy Best BNC 27.856 †‡ Lauer (1995): concept-based 28.00 Baseline 33.00 Lauer (1995): word-based 40.00 Best Altavista 55.71†‡ Table 11: Performance comparison with the literature for compound interpretation hundreds of millions of training instances would be necessary.
P95-1007
Following Keller and Lapata (2003), web counts for ngrams were obtained using a simple heuristic based on queries to the search engine Altavista.1 In this approach, the web count for a given n-gram is simply the number of hits (pages) returned by the search engine for the queries generated for this n-gram.
J03-3005
The simplest strategy is what Shaw and Hatzivassiloglou (1999) call direct evidence.
P99-1018
We devised unsupervised models for the countability learning task and evaluated their performance on Baldwin and Bond’s (2003) test data.
P03-1059
The exception was compound noun interpretation, for which the Altavista model was significantly better than the Lauer’s (1995) model.
P95-1007
All methods use either the full set or a subset of 18 confusion sets originally gathered by Golding (1995).
W95-0104
This result is consistent with Keller and Lapata’s (2003) findings that the web yields better counts than the BNC.
J03-3005
Baldwin and Bond (2003) propose a method for automatically learning the countability of English nouns from the BNC.
P03-1059
We replicated Lauer’s (1995) results for compound noun bracketing using the same test set.
P95-1007
Lauer (1995) is the first to propose and evaluate an unsupervised probabilistic model of compound noun interpretation for domain independent text.
P95-1007
