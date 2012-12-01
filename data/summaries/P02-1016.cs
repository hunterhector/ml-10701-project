Active learning has been studied in the context of many natural language processing (NLP) applications such as information extraction(Thompson et al., 1999), text classi cation(McCallum and Nigam, 1998) and natural language parsing(Thompson et al., 1999; Hwa, 2000), to name a few.
W00-1306
Words are encoded through an automatic clustering algorithm (Brown et al., 1992) while tags, labels and extensions are normally encoded using diagonal bits.
J92-4003
et al., 1997), and has been applied to text classi cation (McCallum and Nigam, 1998) and part-of-speech tagging (Dagan and Engelson, 1995), there are only a handful studies on natural language parsing (Thompson et al., 1999) and (Hwa, 2000; Hwa, 2001).
W00-1306 W01-0710
A prerequisite for building statistical parsers (Jelinek et al., 1994; Collins, 1996; Ratnaparkhi, 1997; Charniak, 1997) is the availability of a (large) corpus of parsed sentences.
H94-1052 P96-1025 W97-0301
(Sarkar, 2001) applied co-training to statistical parsing, where two component models are trained and the most con dent parsing outputs of the existing model are incorporated into the next training.
N01-1023
Let a28a24a3a29a9a30a10 be the set of tagging actions, a31a32a3a29a9a30a10 be the labeling actions and a33a34a3a29a9a11a10 be the extending actions of a9, and let a35a36a3a12 a10 be the sequence of actions ahead of the action a12, thena2a4a3a37a5a8a7a9a30a10 can be rewritten as: a2a4a3a37a5a8a7a9a30a10a39a38 a25a27a26 a40 a41a43a42 a13 a2a4a3 a12 a41 a7a9 a15a17a12a45a44 a41a37a46 a13a48a47 a13 a10 a38 a40 a49a16a50a20a51 a44a43a52 a47 a2a4a3 a12 a7a9 a15 a35a36a3 a12 a10a53a10 a40 a54 a50a20a55 a44a43a52 a47 a2a4a3a29a56a57a7a9 a15 a35a36a3a29a56a22a10a53a10 a40 a58a59a50a20a60 a44a61a52 a47 a2a4a3a29a62a20a7a9 a15 a35a36a3a6a62a22a10a59a10a64a63 (1) Note that a7a28a24a3a65a9a30a10a22a7a67a66a68a7a31a69a3a65a9a30a10a22a7a70a66a68a7a33a71a3a29a9a30a10a23a7a72a38a74a73a76a75 . The three models (1) can be trained using decision trees (Jelinek et al., 1994; Breiman et al., 1984).
H94-1052
Representation of Parse Trees A statistical parser computesa2a4a3a6a5a8a7a9a11a10, the probability of a parse a5 given a sentence a9 . Since the space of the entire parses is too large and cannot be modeled directly, a parse tree a5 is decomposed as a series of individual actions a12a14a13a16a15a17a12a19a18a20a15a22a21a23a21a22a21a24a15a17a12a19a25a27a26 . In the parser (Jelinek et al., 1994) we used in this study, this is accomplished through a bottomup-left-most (BULM) derivation.
H94-1052
(Hwa, 2000; Hwa, 2001) is related closely to our work in that both use entropy-based uncertainty scores, but Hwa does not characterize the distribution of sample space.
W00-1306 W01-0710
