Stevenson and Wilks (2001) investigated the interaction of knowledge sources, such as part-of-speech, dictionary definition, subject codes, etc.
J01-3001
To represent this knowledge source of local collocations, we extracted 11 features corresponding to the following collocations: a52 a4a14a13a59a53a58a4a14a13, a52 a13a59a53a58a13, a52 a4a7a12a57a53a58a4a7a12, a52 a12a57a53a12, a52 a4a7a12a57a53a58a4a14a13, a52 a4a14a13a59a53a58a13, a52 a13a59a53a12, a52 a4a7a6a57a53a58a4a14a13, a52 a4a7a12a57a53a58a13, a52 a4a14a13a59a53a12, and a52 a13a59a53a6 . This set of 11 features is the union of the collocation features used in Ng and Lee (1996) and Ng (1997).
P96-1006 W97-0323
For these words, we first used a POS tagger (Ratnaparkhi, 1996) to determine the correct POS.
W96-0213
1(a) attention (noun) 1(b) He turned his attention to the workbench . 1(c) a24 turned, VBD, active, lefta41 2(a) turned (verb) 2(b) He turned his attention to the workbench . 2(c) a24 he, attention, PRP, NN, VBD, activea41 3(a) green (adj) 3(b) The modern tram is a green machine . 3(c) a24 machine, NNa41 Table 1: Examples of syntactic relations (assuming no feature selection) 3.4 Syntactic Relations We first parse the sentence containing a2 with a statistical parser (Charniak, 2000).
A00-2018
Mooney. 1996.
W96-0208
41-48. Proceedings of the Conference on Empirical Methods in Natural learning algorithms (Mooney, 1996; Pedersen and Bruce, 1997) tend to base their comparison on only one word or at most a dozen words.
W96-0208
In SENSEVAL-2, the various Duluth systems (Pedersen, 2001b) attempted to investigate whether features or learning algorithms are more important.
N01-1011
Ng and Lee (1996) reported the relative contribution of different knowledge sources, but on only one word “interest”.
P96-1006
Escudero et al.(2000) evaluated k-nearest neighbor, Naive Bayes, Winnow-based, and LazyBoosting algorithms on the DSO corpus.
W00-1322
Ng (1997) compared two learning algorithms, k-nearest neighbor and Naive Bayes, on the DSO corpus (191 words).
W97-0323
3.1 Part-of-Speech (POS) of Neighboring Words We use 7 features to encode this knowledge source: a3a5a4a7a6a9a8a10a3a11a4a7a12a9a8a10a3a5a4a14a13a15a8a10a3a17a16a9a8a10a3a5a13a15a8a10a3a18a12a9a8a10a3a17a6, wherea3a19a4a21a20 (a3a22a20 ) is the POS of the a23 th token to the left (right) of a2, and a3 a16 is the POS of a2. A token can be a word or a punctuation symbol, and each of these neighboring tokens must be in the same sentence as a2 . We use a sentence segmentation program (Reynar and Ratnaparkhi, 1997) and a POS tagger (Ratnaparkhi, 1996) to segment the tokens surrounding a2 into sentences and assign POS tags to these tokens.
A97-1004 W96-0213
tilburg used a k-nearest neighbor algorithm with features similar to those used by (Ng and Lee, 1996).
P96-1006
The recent work of Pedersen (2001a) and Zavrel et al.(2000) evaluated a variety of learning algorithms on the SENSEVAL1 data set.
N01-1011
This parameter is also used by (Ng and Lee, 1996).
P96-1006
