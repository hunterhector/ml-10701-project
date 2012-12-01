Briefly, after ensuring the corpora were sentence-aligned, we tokenized the English texts and performed word segmentation on the Chinese texts (Low et al., 2005).
I05-3025
Based on Event Term Clustering 2.1 Event Term Graph We introduce VerbOcean (Chklovski and Pantel, 2004), a broad-coverage repository of semantic verb relations, into event-based summarization.
W04-0802
Och. 2000.
P00-1056
In (Och and Ney, 2000a), the word null is introduced to generate the French words that don't align to any English words.
P00-1056
Alignments of both directions are generated and then are combined by heuristic rules described in (Och and Ney 2000b).
P00-1056
of 6.18. 2.4 Inter-Annotator Agreement Recent estimations of the inter-annotator agreement when using the WordNet inventory report figures of 72.5% agreement in the preparation of the English all-words test set at Senseval-3 (Snyder and Palmer, 2004) and 67.3% on the Open Mind Word Expert annotation exercise (Chklovski and Mihalcea, 2002).
W02-0817
The classical approaches to word alignment are based on IBM models 1-5 (Brown et al., 1994) and the HMM based alignment model (Vogel et al., 1996) (Och and Ney, 2000a, 2000b), while recently discriminative approaches (Moore, 2006) and syntax based approaches (Zhang and Gildea, 2005) for word alignment are also studied.
P00-1056
also tested "self-training with bagging", which Ng and Cardie (2003) used for co-reference resolution.
P03-1058
In order to improve transition models in the HMM based alignment, Och and Ney (2000a) extended the transition models to be word-class dependent.
P00-1056
Och and Ney (2000a) have suggested estimating word-class based transition models so as to provide more detailed transition probabilities.
P00-1056
(Radev et al., 2000; Ng et al., 2001; Harabagiu et al., 2003).
P03-1058
Previous best results: FIJZ03 (Florian et al., 2003), CN03 (Chieu and Ng, 2003), KSNM03 (Klein et al., 2003).
P03-1058
The Multilingual Chinese-English lexical sample task is designed following the leading ideas of the Senseval-3 Multilingual English-Hindi lexical sample task (Chklovski et al., 2004).
W04-0802
Finally, we further smooth transition probabilities with a uniform distribution as described in (Och and Ney, 2000a), __ 1 (|,) (1 )(|,) jj jj p aa I paa I I ??=??????.
P00-1056
Using this annotation, we report the word alignment performance in terms of alignment error rate (AER) as defined by Och and Ney (2000a): |||| 1 |||| A SAP AER AS ????
P00-1056
Chklovski and Pantel (2004) introduce a 5-class set, designed specifically for characterizing verb-verb semantic relations.
W04-0802
and Test Data from Different Documents In our previous work (Ng et al., 2003), we conducted experiments on the nouns of SENSEVAL-2 English lexical sample task.
P03-1058
Briefly, training a Hiero model proceeds as follows: ??GIZA++ (Och and Ney, 2000) is run on the parallel corpus in both directions, followed by an alignment refinement heuristic that yields a many-to-many alignment for each parallel sentence.
P00-1056
Franz J. Och and Hermann Ney. 2000. Improved statis-
P00-1056
Tests sentencepairs were manually aligned and were marked with both sure and possible alignments (Och and Ney 2000a).
P00-1056
This transformation searches an adequate monotonic segmentation for each of the m source-target language pairs on the basis of bilingual alignments such as those given by GIZA++ (Och, 2000).
P00-1056
An effort to alleviate the training data bottleneck is the Open Mind Word Expert (OMWE) project (Chklovski and Mihalcea, 2002) to collect sense-tagged data from Internet users.
W02-0817
In this paper, we present improvements to the HMM based alignment model originally proposed by (Vogel et al., 1996, Och and Ney, 2000a).
P00-1056
This is thus similar to the multilingual lexical sample task in SENSEVAL-3 (Chklovski et al., 2004), except that our training and test examples are collected without manually annotating each individual ambiguous word occurrence.
W04-0802
Examples from Parallel Corpora To gather examples from parallel corpora, we followed the approach in (Ng et al., 2003).
P03-1058
In the next section we briefly review modeling of transition probabilities in a conventional HMM alignment model (Vogel et al., 1996, Och and Ney, 2000a).
P00-1056
HMM alignment model We briefly review the HMM based word alignment models (Vogel, 1996, Och and Ney, 2000a).
P00-1056
We also trained IBM model 4 using GIZA++ provided by Och and Ney (2000c), where 5 iterations of model 4 training was performed after 5 iterations of model 1 plus 5 iterations of HMM.
P00-1056
Fig. 1 only presents AER results that are calculated after combination of word alignments of both E??F and F??E directions based on a set of heuristics proposed by Och and Ney (2000b).
P00-1056
ISL Phrase-Based MT System 2.1 Word and Phrase Alignment Phrase-to-phrase translation pairs are extracted by training IBM Model-4 word alignments in both directions, using the GIZA++ toolkit (Och and Ney, 2000), and then extracting phrase pair candidates which are consistent with these alignments, starting from the intersection of both alignments.
P00-1056
We then made use of the GIZA++ software (Och and Ney, 2000) to perform word alignment on the parallel corpora.
P00-1056
Our past research in (Ng et al., 2003; Chan and Ng, 2005) has shown that examples gathered from parallel texts are useful for WSD.
P03-1058
Corpus Since not all interested participants may have access to the LDC corpus described in the previous subsection, the second track of this task makes use of English-Chinese documents gathered from the URL pairs given by the STRAND Bilingual Databases.3 STRAND (Resnik and Smith, 2003) is a system that acquires document pairs in parallel translation automatically from the Web.
J03-3002
As described in (Ng et al., 2003), when several senses of an English word are translated by the same Chinese word, we can collapse these senses to obtain a coarser-grained, lumped sense inventory.
P03-1058
ZA++ (Och and Ney, 2000) on the training corpus 
P00-1056
