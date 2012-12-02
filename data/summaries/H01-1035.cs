Melamed. 1999.
J99-1003
Use of Och and Ney’s recently released and enhanced GIZA++ word-alignment models (Och and Ney, 2000) should improve performance for all of the applications studied in this paper, as would iterative realignments using richer alignment features (including lemma and part-of-speech) derived from this research.
P00-1056
Additional details are provided in Yarowsky and Ngai (2001).
N01-1006 N01-1026
Additional details of this algorithm are given in Yarowsky and Ngai (2001).
N01-1006 N01-1026
Brill, 1995) to annotate the English side of the parallel corpus.
J95-4004
While any supervised morphological analysis technique is possible here, we employ a trie-based modeling technique where the probability of a given stem-change (from the inventory observed in the MProj-paired training data) is modeled hierarchically using variable suffix context, as described in Yarowsky and Wicentowski (2000): a22a23a18 roota19 inflectiona20a67a66a117a22a23a18a52a118a120a119a104a19a118a122a121a71a20a67a66a72a22a23a18a52a121 a36 a119a104a19a118a122a121a71a20a67a66 a123 a49a125a124 a49a85a22a23a18a52a121 a36 a119a126a19a127a107a49a128a20 for a127a107a49a54a66 suffixa18a52a129a50a55a50a118a130a121a131a20 For example: a22a23a18 commencera19 commenc¸aa20a71a66a117a22a23a18 c¸a a36 cer a19 commenc¸aa20a71a66 a124a107a132 a22a23a18 c¸a a36 cer a20a133a75 a124 a53a43a22a23a18 c¸a a36 cer a19 aa20a116a75 a124a135a134 a22a23a18 c¸a a36 cer a19 c¸aa20a50a75 a75 a124a107a136 a22a23a18 c¸a a36 cera19nc¸aa20a116a75 a124a107a137 a22a23a18 c¸a a36 cera19enc¸aa20a133a75a77a56a59a56a59a56 a22a23a18 ployera19 ploiea20a71a66a72a22a23a18 ie a36 yer a19 ploiea20a125a66 a124a107a132 a22a23a18 ie a36 yer a20a133a75 a124 a53a43a22a23a18 ie a36 yer a19ea20a133a75 a124a135a134 a22a23a18 ie a36 yer a19 iea20a50a75 a75 a124a107a136 a22a23a18 ie a36 yer a19 oiea20a76a75 a124a107a137 a22a23a18 ie a36 yer a19 loiea20a116a75a117a56a59a56a59a56 An important property of the trie-based models is their effectiveness at clustering words that exhibit similar morphological behavior, both reducing model size and facilitating generalization to previously unseen examples.
P00-1027
For a given second-language word FW and all English words a61a62a27a63a49 aligned to it: a22a23a18 NEclassa64a65a19 FWa20a67a66a69a68 a49 a22a23a18 NEclassa64a65a19 EWa49 a20a70a22 a16 a18 EWa49 a19 FWa20 a22a23a18 PLACEa19 Cor´eea20a71a66a72a22a23a18 PLACEa19Koreaa20a73a22a54a16a74a18 Koreaa19 Cor´eea20a76a75a77a56a58a56a59a56 The co-training-based algorithm given in Cucerzan and Yarowsky (1999) was then used to train a stand-alone named entity tagger from the projected data.
W99-0612
Projection Methodology The projection process begins by automatically tagging and bracketing the English data, using Brill (1995) and Ramshaw & Marcus (1994), respectively.
J95-4004
Brill. 1995.
J95-4004
Further details, including the handling of 1-to-N phrasal alignment projections, are given in Yarowsky and Ngai (2001).
N01-1006 N01-1026
Ngai. 2001.
N01-1006
Wu (1995, 1997) investigated the use of concurrent parsing of parallel corpora in a transduction inversion framework, helping to resolve attachment ambiguities in one language by the coupled parsing state in the second language.
J97-3002 P95-1033
Wu. 1995.
P95-1033
All corpora were automatically word-aligned by the now publicly available EGYPT system (Al-Onaizan et al., 1999), based on IBM’s Model 3 statistical MT formalism (Brown et al., 1990).
J90-2002
Training Algorithm For stand-alone tool development, the Ramshaw & Marcus IOB bracketing framework and a fast transformation-based learning system (Ngai and Florian, 2001) were applied to the noisy baseNPprojected data described above.
N01-1006
Wu. 1997.
J97-3002
