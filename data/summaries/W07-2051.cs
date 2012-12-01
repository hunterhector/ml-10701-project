Miller. 1993.
H93-1103
Notice that our calculation of the MFS is based on the frequencies in the SemCor corpus (Miller et al., 1993), as we exploit WordNet sense rankings.
H93-1103
Constituency trees are provided by the Charniak-Johnson?s Max-Ent reranking parser (Charniak and Johnson, 2005).
P05-1022
parsers and corpora The Charniak-Lease parser is a statistical constituency parser developed by Charniak and Lease (2005).
P05-1022
One solution to this is to use a state-of-the-art probabilistic parser that accepts untokenized input (such as Charniak and Johnson, 2005) and retrain it as described in Section 4.
P05-1022
Compared with WordNet (Miller et al., 1993)?? which has been used widely in QA?FrameNet, PropBank and VerbNet are still relatively new, and therefore their usefulness for QA has still to be proven.
H93-1103
Yarowsky (1995), Collins and Singer (1999), Riloff and Jones (1999)).
P95-1026
Finally, to assess the practical value of the conversion method and of the BioInfer syntactic annotation in the Stanford scheme, we compare the Charniak-Lease constituency parser2 (Charniak and Lease, 2005) and BioLG,3 an adaptation of LG (Pyysalo et al., 2006), on the newly unified dataset combining the constituency-annotated GENIA Treebank with the dependency-annotated BioInfer corpus.
P05-1022
The fact that the error rate more than doubles when the seeds in Yarowsky's (1995) experiments are reduced from a sense's best collocations to just one word per sense suggests that the error rate would increase further if no seeds were provided.
P95-1026
Most systems did not use sense tagged data for disambiguation though MELB did use SemCor (Miller et al., 1993b) for filtering infrequent synonyms and UNT used a semi-supervised word sense disambiguation combined with a host of other techniques, including machine translation engines.
H93-1103
This result is particularly interesting as a supersense tagger can easily provide a satisfactory accuracy (Ciaramita and Altun, 2006).
W06-1670
Thus, some research has been focused on deriving different sense groupings to overcome the fine?? grained distinctions of WN (Hearst and Schutze, 1993) (Peters et al., 1998) (Mihalcea and Moldovan, 2001) (Agirre et al., 2003) and on using predefined sets of sense-groupings for learning class-based classifiers for WSD (Segond et al., 1997) (Ciaramita and Johnson, 2003) (Villarejo et al., 2005) (Curran, 2005) (Ciaramita and Altun, 2006).
W06-1670
Chunking An in-house chunker implemented with fnTBL, a transformation based learner (Ngai and Florian, 2001), and trained on the British National Corpus (BNC).1 Parsing Charniak?s re-ranking parser, version August, 2006 (Charniak and Johnson, 2005).
N01-1006 P05-1022
work, e.g., (Cohn and Blunsom, 2005; Jousse et al.,
P05-1002
The average performance of the SVD-based representations of 83% to 91% is satisfactory, although inferior by about 5% to 10%, to disambiguation with minimal manual intervention (e.g., Yarowsky \[1995\]).
P95-1026
Usually these experts are designed to 4 See (Cohn et al., 2005) for a scaling method allowing the full POS tagging task with CRFs.
P05-1002
The second parser is that described in Charniak and Johnson (2005).
P05-1022
Features The collocation features were inspired by the one-sense-per-collocation heuristic proposed by Yarowsky (1995).
P95-1026
Eugene Charniak and Mark Johnson. 2005. Coarse-to-fine n-best parsing and maxent discriminative reranking. In ACL 43, pages 173180.
P05-1022
Named entity extraction A statistical NER system described in Cohn et al.(2005). Supersense tagging A WordNet-based supersense tagger (Ciaramita and Altun, 2006).
P05-1002 W06-1670
Existing hand-annotated corpora like SemCor (Miller et al., 1993), which is annotated with WordNet senses (Fellbaum, 1998) allow for a small improvement over the simple most frequent sense heuristic, as attested in the all-words track of the last Senseval competition (Snyder and Palmer, 2004).
H93-1103
Yarowsky has proposed an algorithm that requires as little user input as one seed word per sense to start the training process (Yarowsky 1995).
P95-1026
Charniak. 2005.
P05-1022
In previous research on natural language processing, many methodologies for extracting various relations from corpora have been developed, such as the ?is-a??relation (Hearst 1992), ?part-of??relation (Berland and Charniak 1999), causal relation (Girju 2003), and entailment relation (Geffet and Dagan 2005).
P05-1022
Trevor Cohn and Philip Blunsom. 2005. Semantic role labelling with tree conditional random fields. In CoNLL 2005.
P05-1002
In this paper, we use reranking architecture, which was successfully applied to the task of natural language parsing (Collins, 2000; Charniak and 209 Johnson, 2005), to address the problem.
P05-1022
Bag of WordNet synsets The WordNet (Miller, 1993) synonym sets and their hypernyms of all the open class words that occur in the same sentence as the target preposition.
H93-1103
detection P =summationtext mwsysi?MWsys 1 if mwi exists at i |MWsys| (9) detection R =summationtext mwsysi?MW 1 if mwi exists at i |MW| (10) identification P = summationtext mwsysi?MWsys 1 if mwsysi = mwi |MWsys| (11) 50 identification R = summationtext mwsysi?MW 1 if mwsysi = mwi |MW| (12) 3.1 Baselines We produced baselines using WordNet 2.1 (Miller et al., 1993a) and a number of distributional similarity measures.
H93-1103
(unlab.) Total XLE Parses (/140) 119 0 86 135 139 139 F-Score of Subset 81.57 0 86.57 78.72 53.96 75.64 Overall F-Score 72.01 0 58.04 76.13 53.48 *74.98 Table 2: Bikel (2002) and Charniak and Johnson (2005) out-of-the-box baseline results the PARC 700 Dependency Bank.
P05-1022
George Miller, Richard Beckwith, Christine Fellbaum, David Gross, and Katherine Miller, 1993a.
H93-1103
