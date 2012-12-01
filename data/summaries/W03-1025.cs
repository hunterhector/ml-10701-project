Xu et al.(2002) reports an overall F-measure a15a4a17 a3a108 a7 when the same training and test set as (Bikel and Chiang, 2000) are used.
P00-1058 W00-1201
Work Bikel and Chiang (2000) and Xu et al.(2002) construct word-based statistical parsers on the rst release of Chinese Treebank, which has about 100K words, roughly half of the training data used in this study.
P00-1058 W00-1201
Parsers described in (Bikel and Chiang, 2000) and (Xu et al., 2002) operate at word-level with the assumption that input sentences are pre-segmented.
P00-1058 W00-1201
Chinese word segmentation is a well-known problem that has been studied extensively (Wu and Fung, 1994; Sproat et al., 1996; Luo and Roukos, 1996) and it is known that human agreement is relatively low.
A94-1030 J96-3004 P96-1019
Each component model takes the exponential form: a37a55a38a57a56 a51 a42a6a44a59a58a60a56 a61 a51a64a63a65a53a67a66 a53 a45a46a70 a71a16a72a21a73a75a74a77a76a79a78a81a80 a78a16a82a11a78 a38a83a44a59a58a60a56a84a61 a51a64a63a65a53a67a66 a53 a58a60a56 a51 a45a86a85 a87 a38a83a44a59a58a60a56a84a61 a51a64a63a65a53a67a66 a53 a45 a58 (2) where a87 a38a83a44a59a58a60a56 a61 a51a41a63a65a53a67a66 a53 a45 is a normalization term to ensure that a37a55a38a57a56 a51a42a6a44a88a58a60a56a62a61 a51a41a63a65a53a67a66 a53 a45 is a probability, a82a11a78 a38a83a44a59a58a60a56 a61 a51a64a63a65a53a67a66 a53 a58a60a56 a51 a45 is a feature function (often binary) and a80 a78 is the weight ofa82a21a78 . Given a set of features and a corpus of training data, there exist ef cient training algorithms (Darroch and Ratcliff, 1972; Berger et al., 1996) to nd the optimal parameters a89 a80 a78a14a90 . The art of building a maximum entropy parser then reduces to choosing good features.
J96-1002
Sproat et al.(1996) employs stochastic nite state machines to nd word boundaries.
J96-3004
Luo and Roukos (1996) proposes to use a language model to select from ambiguous wordsegmentations.
P96-1019
3.1 Language-Independent Feature Templates The maximum entropy parser (Ratnaparkhi, 1997) parses a sentence in three phases: (1) it rst tags the input sentence.
W97-0301
Low agreement between humans affects directly evaluation of machines’ performance (Wu and Fung, 1994) as it is hard to de ne a gold standard.
A94-1030
After Linguistic Data Consortium (LDC) released the Chinese Treebank (CTB) developed at UPenn (Xia et al., 2000), various statistical Chinese parsers (Bikel and Chiang, 2000; Xu et al., 2002) have been built.
P00-1058 W00-1201
Abouta15 a181a21a7 F-measure is reported in (Bikel and Chiang, 2000).
P00-1058 W00-1201
Bikel and Chiang (2000) in fact contains two parsers: one is a lexicalized probabilistic contextfree grammar (PCFG) similar to (Collins, 1997); the other is based on statistical TAG (Chiang, 2000).
P00-1058 P97-1003 W00-1201
and Features The maximum entropy parser (Ratnaparkhi, 1997) is used in this study, for it offers the exibility of integrating multiple sources of knowledge into a model.
W97-0301
Palmer (1997) uses transform-based learning (TBL) to correct an initial segmentation.
P97-1041
A maximum entropy parser (Ratnaparkhi, 1997) parser is then built and tested.
W97-0301
There are multiple studies (Wu and Fung, 1994; Sproat et al., 1996; Luo and Roukos, 1996) showing that the agreement between two (untrained) native speakers is about upper a15 a12a14a7 to lower a0a4a12a14a7. The agreement between multiple human subjects is even lower (Wu and Fung, 1994).
A94-1030 J96-3004 P96-1019
