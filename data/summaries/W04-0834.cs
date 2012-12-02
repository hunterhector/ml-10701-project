We did not attempt feature selection since our previous research (Lee and Ng, 2002) indicated that SVM performs better without feature selection.
W02-1006
Much of the description follows that of Lee and Ng (2002).
W02-1006
If a0 is a verb, we use six features: the nearest word a0 to the left ofa0 such that a0 is the parent headword of a0, the nearest word a1 to the right ofa0 such thata0 is the parent headword of a1, the POS of a0, the POS of a1, the POS of a0, and the voice ofa0 . Ifa0 is an adjective, we use two features: its parent headword a49 and the POS of a49 . Headwords are obtained from a parse tree with the script used for the CoNLL-2000 shared task (Tjong Kim Sang and Buchholz, 2000).1 Some examples are shown in Table 1.
W00-0726
3.1 Part-of-Speech (POS) of Neighboring Words We use 7 features to encode this knowledge source: a0a2a1a4a3a6a5a7a0a8a1a10a9a11a5a7a0a8a1a13a12a14a5a15a0a17a16a6a5a15a0a2a12a18a5a7a0a19a9a20a5a15a0a17a3, where a0a8a1 a21 (a0 a21 ) is the POS of thea6 th token to the left (right) ofa0, and a0a17a16 is the POS of a0 . A token can be a word or a punctuation symbol, and each of these neighboring tokens must be in the same sentence asa0 . We use a sentence segmentation program (Reynar and Ratnaparkhi, 1997) and a POS tagger (Ratnaparkhi, 1996) to segment the tokens surroundinga0 into sentences and assign POS tags to these tokens.
A97-1004 W96-0213
Relations We first parse the sentence containinga0 with a statistical parser (Charniak, 2000).
A00-2018
Previous research (Ng and Lee, 1996; Stevenson and Wilks, 2001; Florian et al., 2002; Lee and Ng, 2002) has shown that a combination of knowledge sources improves WSD accuracy.
J01-3001 P96-1006 W02-1006
All systems were based on the supervised word sense disambiguation (WSD) system of Lee and Ng (2002), and used Support Vector Machines (SVM) learning.
W02-1006
The knowledge sources used included part-ofspeech (POS) of neighboring words, single words in the surrounding context, local collocations, and syntactic relations, as described in Lee and Ng (2002).
W02-1006
To represent this knowledge source of local collocations, we extracted 11 features corresponding to the following collocations: a1 a1a45a12a46a41a44a1a45a12, a1 a12a46a41a44a12, a1 a1a10a9a7a41a44a1a10a9, a1 a9a7a41a9, a1 a1a10a9a7a41a44a1a13a12, a1 a1a13a12a36a41a44a12, a1 a12a36a41a9, a1 a1a4a3a47a41a44a1a45a12, a1 a1a48a9a18a41a44a12, a1 a1a13a12a36a41a9, and a1 a12a36a41a3 . This set of 11 features is the union of the collocation features used in Ng and Lee (1996) and Ng (1997).
P96-1006 W97-0323
