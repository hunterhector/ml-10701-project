Other work has attempted to exploit translational equivalences of WordNet senses in other languages, for example using foreign language WordNet interlingual indexes (Gonzalo et al., 1998; Chugur et al., 2002).
W02-0805 W98-0705
A wide variety of semantic and syntactic criteria were used to produce the SENSEVAL-2 groupings (Palmer et al., 2004; Palmer et al., 2005); this data covers all senses of 411 nouns, 519 verbs, and 257 adjectives, and has been used as gold standard sense clustering data in previous work (Agirre and Lopez, 2003; McCarthy, 2006)2.
W04-2807 W06-2503
Much work has gone into methods for measuring synset similarity; early work in this direction includes (Dolan, 1994), which attempted to discover sense similarities between dictionary senses.
C94-2113
Finally, we use as a feature the mappings produced in (Navigli, 2006) of WordNet senses to Oxford English Dictionary senses.
P06-1014
We use eight similarity measures implemented within the WordNet::Similarity package5, described in (Pedersen et al., 2004); these include three measures derived from the paths between the synsets in WordNet: HSO (Hirst and St-Onge, 1998), LCH (Leacock and Chodorow, 1998), and WUP (Wu and Palmer, 1994); three measures based on information content: RES (Resnik, 1995), LIN (Lin, 1998), and JCN (Jiang and Conrath, 1997); the gloss-based Extended Lesk Measure LESK, (Banerjee and Pedersen, 2003), and finally the gloss vector similarity measure VECTOR (Patwardan, 2003).
N04-3012 P94-1019 P98-2127
Additionally, we use the WordNet domain dataset described in (Magnini and Cavaglia, 2000; Bentivogli et al., 2004).
W04-2214
Finally, we compare against the mapping from WordNet to the Oxford English Dictionary constructed in (Navigli, 2006), equivalent to clustering based solely on the OED feature.
P06-1014
1007 not consider this as a valid estimate of interannotator agreement; nonetheless the F-score for the two datasets on the overlapping set of sense judgments (50.6% for nouns and 50.7% for verbs) is roughly in the same range as those observed in (McCarthy, 2006).
W06-2503
Of the methods we compare against, only the WordNet-based similarity measures, (Mihalcea and Moldovan, 2001), and (Navigli, 2006) provide a method for predicting verb similarities; our learned measure widely outperforms these methods, achieving a 13.6% F-score improvement over the LESK similarity measure.
P06-1014
In order to evaluate the entire sense-clustered taxonomy, we have employed an evaluation method inspired by Word Sense Disambiguation (this is similar to an evaluation used in Navigli, 2006, however we do not remove monosemous clusters).
P06-1014
In this work we focus on two datasets of hand-labeled sense groupings for WordNet: first, a dataset of sense groupings over nouns, verbs, and adjectives provided as part of the SENSEVAL-2 English lexical sample WSD task (Kilgarriff, 2001), and second, a corpus-driven mapping of nouns and verbs in WordNet 2.1 to the Omega Ontology (Philpot et al., 2005), produced as part of the ONTONOTES project (Hovy et al., 2006).
N06-2015
Due to a lack of interannotator agreement data for this dataset, (McCarthy, 2006) performed an annotation study using three labelers on a 20-noun subset of the SENSEVAL-2 groupings; the three labelers were given the task of deciding whether the 351 potentially-related sense pairs were “Related”, “Unrelated”, or “Don’t Know”.3 In this task the pair2In order to facilitate future work in this area, we have made cleaned versions of these groupings available at http://ai.stanford.edu/∼rion/swn along with a “diff” with the original files.
W06-2503
(Navigli, 2006) presents an automatic approach for mapping between sense inventories; here similarities in gloss definition and structured relations between the two sense inventories are exploited in order to map between WordNet senses and distinctions made within the coarser-grained Oxford English Dictionary.
P06-1014
Other attempts in 1006 this vein include mappings between WordNet and PropBank (Palmer et al., 2004) and mappings to Levin classes (Levin, 1993; Palmer et al., 2005).
W04-2807
Other corpus-based techniques developed specifically for sense clustering include (McCarthy, 2006), which uses a combination of word-to-word distributional similarity combined with the JCN WordNet-based similarity measure, and work by (Chugur et al., 2002) in finding co-occurrences of senses within documents in sense-tagged corpora.
W02-0805 W06-2503
Only the measures provided by LESK, HSO, VEC, (Mihalcea and Moldovan, 2001), and (Navigli, 2006) provide a method for predicting adjective similarities; of these, only LESK and VEC outperform the uninformed baseline on adjectives, while our learned measure achieves a 4.0% improvement over the LESK measure on adjectives.
P06-1014
For language learners, a fine-grained set of word senses may help in learning subtle distinctions, while coarsely-defined senses are probably more useful in NLP tasks like information retrieval (Gonzalo et al., 1998), query expansion (Moldovan and Mihalcea, 2000), and WSD (Resnik and Yarowsky, 1999; Palmer et al., 2005).
W98-0705
A variety of synset similarity measures based on properties of WordNet itself have been proposed; nine such measures are discussed in (Pedersen et al., 2004), including gloss-based heuristics (Lesk, 1986; Banerjee and Pedersen, 2003), information-content based measures (Resnik, 1995; Lin, 1998; Jiang and Conrath, 1997), and others.
N04-3012 P98-2127
(Peters et al., 1998) uses the COUSIN relation defined in WordNet 1.5 to cluster hyponyms of categorically related noun synsets, e.g., “container/quantity” (e.g., for clustering senses of “cup” or “barrel”) or ”organization/construction” (e.g., for the building and institution senses of “hospital” or “school”); other approaches based on systematic polysemy include the hand-constructed CORELEX database (Buitelaar, 1998), and automatic attempts to extract patterns of systematic polysemy based on minimal description length principles (Tomuro, 2001).
N01-1010
The ONTONOTES data is much cleaner in this respect, most likely due to the stricter annotation standard (Hovy et al., 2006); we found only one transitive closure disagreement 1009 in the OntoNotes data, specifically WordNet 2.1 synsets (head#n#2, lead#n#7: “be in charge of”) and (head#n#3, lead#v#4: “travel in front of”) are clustered under head but not under lead.
N06-2015
A large body of work has attempted to capture corpus-based estimates of word similarity (Pereira et al., 1993; Lin, 1998); however, the lack of large sense-tagged corpora prevent most such techniques from being used effectively to compare different senses of the same word.
P93-1024 P98-2127
We consider the outputs of the top 3 allwords WSD systems that participated in Senseval-3: Gambl (Decadt et al., 2004), SenseLearner (Mihalcea and Faruque, 2004), and KOC University (Yuret, Nouns Verbs Adjectives F-SCORE 0.4228 0.4319 0.4727 Feature F-Score Ablation Difference TOPSIG 0.0403 — — OED 0.0355 0.0126 -0.0124 DERIV 0.0351 0.0977 0.0352 RES 0.0287 0.0147 — TWIN 0.0285 0.0109 -0.0130 MN 0.0188 0.0358 — LESK 0.0183 0.0541 -0.0250 SENSENUM 0.0155 0.0146 -0.0147 SENSECNT 0.0121 0.0160 0.0168 DOMAIN 0.0119 0.0082 -0.0265 LCH 0.0099 0.0068 — WUP 0.0036 0.0168 — JCN 0.0025 0.0190 — ANTONYM 0.0000 0.0295 0.0000 MAXMN -0.0013 0.0179 — VEC -0.0024 0.0371 -0.0062 HSO -0.0073 0.0112 -0.0246 LIN -0.0086 0.0742 — COUSIN -0.0094 — — VERBGRP — 0.0327 — VERBFRM — 0.0102 — PERTAINYM — — -0.0029 Table 4: Feature ablation study; F-score difference obtained by removal of the single feature 2004).
W04-0827 W04-0838
