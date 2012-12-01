Pre-compiled taxonomies such as WordNet 1 and text corpora have been used in previous work on semantic similarity (Lin, 1998a; Resnik, 1995; Jiang and Conrath, 1998; Lin, 1998b).
P98-2127
Page counts-based measures do not consider the context in which the words appear in a page, thus cannot disambiguate Table 4: Comparison with taxonomy based methods Method correlation Human replication 0.901 Resnik (1995) 0.745 Lin (1998) 0.822 Li et al (2003) 0.891 Edge-counting 0.664 Information content 0.745 Jiang & Conrath (1998) 0.848 proposed (SVM) 0.834 the multiple senses.
J03-3002 P98-2127
Entity Clustering Measuring semantic similarity between named entities is vital in many applications such as query expansion (Sahami and Heilman, 2006) and community mining (Matsuo et al., 2006a).
W06-1664
Terra and Clarke (2003) compare various similarity scores for measuring similarity between words in a corpus.
N03-1032
Matsuo et al., (2006a) propose the use of Web hits for the extraction of communities on the Web.
W06-1664
Proposed method (SVM) re6Pearson correlation coefficient is invariant against a linear transformation 344 Table 3: Semantic Similarity of Human Ratings and baselines on Miller-Charles dataset Word Pair MillerWeb Web Web Web Sahami Chen (CODC) Proposed Charles Jaccard Dice Overlap PMI (2006) (2006) (SVM) cord-smile 0.13 0.102 0.108 0.036 0.207 0.090 0 0 rooster-voyage 0.08 0.011 0.012 0.021 0.228 0.197 0 0.017 noon-string 0.08 0.126 0.133 0.060 0.101 0.082 0 0.018 glass-magician 0.11 0.117 0.124 0.408 0.598 0.143 0 0.180 monk-slave 0.55 0.181 0.191 0.067 0.610 0.095 0 0.375 coast-forest 0.42 0.862 0.870 0.310 0.417 0.248 0 0.405 monk-oracle 1.1 0.016 0.017 0.023 0 0.045 0 0.328 lad-wizard 0.42 0.072 0.077 0.070 0.426 0.149 0 0.220 forest-graveyard 0.84 0.068 0.072 0.246 0.494 0 0 0.547 food-rooster 0.89 0.012 0.013 0.425 0.207 0.075 0 0.060 coast-hill 0.87 0.963 0.965 0.279 0.350 0.293 0 0.874 car-journey 1.16 0.444 0.460 0.378 0.204 0.189 0.290 0.286 crane-implement 1.68 0.071 0.076 0.119 0.193 0.152 0 0.133 brother-lad 1.66 0.189 0.199 0.369 0.644 0.236 0.379 0.344 bird-crane 2.97 0.235 0.247 0.226 0.515 0.223 0 0.879 bird-cock 3.05 0.153 0.162 0.162 0.428 0.058 0.502 0.593 food-fruit 3.08 0.753 0.765 1 0.448 0.181 0.338 0.998 brother-monk 2.82 0.261 0.274 0.340 0.622 0.267 0.547 0.377 asylum-madhouse 3.61 0.024 0.025 0.102 0.813 0.212 0 0.773 furnace-stove 3.11 0.401 0.417 0.118 1 0.310 0.928 0.889 magician-wizard 3.5 0.295 0.309 0.383 0.863 0.233 0.671 1 journey-voyage 3.84 0.415 0.431 0.182 0.467 0.524 0.417 0.996 coast-shore 3.7 0.786 0.796 0.521 0.561 0.381 0.518 0.945 implement-tool 2.95 1 1 0.517 0.296 0.419 0.419 0.684 boy-lad 3.76 0.186 0.196 0.601 0.631 0.471 0 0.974 automobile-car 3.92 0.654 0.668 0.834 0.427 1 0.686 0.980 midday-noon 3.42 0.106 0.112 0.135 0.586 0.289 0.856 0.819 gem-jewel 3.84 0.295 0.309 0.094 0.687 0.211 1 0.686 Correlation 1 0.259 0.267 0.382 0.548 0.579 0.693 0.834 ports the highest correlation of 0.8129 in our experiments.
P06-1127
Our implementation of Co-occurrence Double Checking (CODC) measure (Chen et al., 2006) reports the second best correlation of 0.6936.
P06-1127
Since most named entities are not covered by WordNet, similarity measures based on WordNet alone cannot be Table 5: Performance of named entity clustering Method Precision Recall F Measure WebJaccard 0.5926 0.712 0.6147 WebOverlap 0.5976 0.68 0.5965 WebDice 0.5895 0.716 0.6179 WebPMI 0.2649 0.428 0.2916 Sahami (2006) 0.6384 0.668 0.6426 Chen (2006) 0.4763 0.624 0.4984 Proposed 0.7958 0.804 0.7897 used in such tasks.
P06-1127
Automatically extracted lexico-syntactic patterns have been successfully employed in various term extraction tasks (Hearst, 1992).
C92-2082
Chen et al., (2006) propose a web-based double341 checking model to compute semantic similarity between words.
P06-1127
Similarity We score the word-pairs in Miller-Charles dataset using the page counts-based similarity measures, previous work on web-based semantic similarity measures (Sahami (2006), Chen (2006)) and the proposed method (SVM).
P06-1127
Resnik and Smith (2003) extract bilingual sentences from the Web to create parallel corpora for machine translation.
J03-3002
Such indicative phrases have been successfully applied in various tasks such as synonym extraction, hyponym extraction (Hearst, 1992) and fact extraction (Pasca et al., 2006).
C92-2082
Simple, unsupervised models have shown to perform better when n-gram counts are obtained from the Web rather than from a large corpus (Keller and Lapata, 2003; Lapata and Keller, 2005).
J03-3005
Semantic similarity measures are vital for various applications in natural language processing such as word sense disambiguation (Resnik, 1999), language modeling (Rosenfield, 1996), synonym extraction (Lin, 1998a) and automatic thesaurus extraction (Curran, 2002).
P98-2127 W02-1029
We employed the B-CUBED metric (Bagga and Baldwin, 1998) to evaluate the clustering results.
P98-1012
