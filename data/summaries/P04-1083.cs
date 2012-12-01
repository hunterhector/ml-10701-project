This logic can be used with the expectation semiring (Eisner, 2002) to find the maximum likelihood estimates of the parameters of a word-to-word translation model.
P02-1001
Eisner (2002) has claimed that parsing under an expectation semiring is equivalent to the Inside-Outside algorithm for PCFGs.
P02-1001
The vehicle for the present guided tour shall be multitext grammar (MTG), which is a generalization of context-free grammar to the synchronous case (Melamed, 2003).
N03-1021
We presume that readers are familiar with declarative descriptions of inference algorithms, as well as with semiring parsing (Goodman, 1999).
J99-4004
Melamed (2003) “Multitext Grammars and Synchronous Parsers,” Proceedings of HLT/NAACL.
N03-1021
Under such an MTG, the logic of word alignment is the one in Melamed (2003)’s Parser A, but without Compose inferences.
N03-1021
Yarowsky (2001) “Multipath Translation Lexicon Induction via Bridge Languages,” Proceedings of HLT/NAACL.
N01-1026
D. Wu (1996) “A polynomial-time algorithm for statistical machine translation,” Proceedings of the ACL.
P96-1021
D. Wu (1997) “Stochastic inversion transduction grammars and bilingual parsing of parallel corpora,” Computational Linguistics 23(3):377-404.
J97-3002
We shall limit our attention to MTGs in Generalized Chomsky Normal Form (GCNF) (Melamed et al., 2004).
P04-1084
J. Eisner (2002) “Parameter Estimation for Probabilistic FiniteState Transducers,” Proceedings of the ACL.
P02-1001
Goodman (1999) shows how a parsing logic can be combined with various semirings to compute different kinds of information about the input.
J99-4004
Under the various derivation semirings (Goodman, 1999), Translator CT can store the output role templates a28 a41 a48 a49 a51 in each internal node of the tree.
J99-4004
For example, we could project a part-of-speech tagger (Yarowsky & Ngai, 2001) to improve our estimates in Equation 6.
N01-1026
To the best of our knowledge, Logic CT is the first published translation logic to be compatible with all of the semirings catalogued by Goodman (1999), among others.
J99-4004
6Although most of the literature discusses word translation models between only two languages, it is possible to combine several 2D models into a higher-dimensional model (Mann & Yarowsky, 2001).
N01-1020 N01-1026
As in Melamed (2003)’s Parser A, Parser C’s items consist of a a0 -dimensional label vector a2a50a49a51 and a a0 -dimensional d-span vector a52 a49 a51 . 2 The items contain d-spans, rather than ordinary spans, because 2Superscripts and subscripts indicate the range of dimensions of a vector.
N03-1021
Item Form: a32 a2 a49a51 a15 a52 a49 a51a16a33 Goal: a32a35a34 a49 a51 a15 a23a4a3 a12 a0a36a5 a24 a49 a51a37a33 Inference Rules Scan component d, a10a38a8 a7 a8 a0 : a39a41a40a43a42a44 a44a45 a23a25a24 a49 a5a47a46 a49 a2 a23a25a24 a5a49a48 a49 a51 a50 a23a25a24 a49 a5a47a46 a49 a20a43a5 a3a22 a23a25a24 a5a49a48 a49 a51 a51a14a52 a52 a53 a54a55 a55 a56 a23a25a24 a49 a5a47a46 a49 a2 a23a25a24 a5a49a48 a49 a51 a50 a23a25a24 a49 a5a47a46 a49a23 a19a57a24 a10a13a12 a19 a24 a23a25a24 a5a49a48 a49 a51 a58a59 a59 a60 Compose: a61a63a62a65a64 a66a68a67a69 a64 a66a71a70 a61a35a72a37a64 a66a68a67a73 a64 a66a71a70a36a74a76a75 a32a78a77 a64 a66a76a67a69 a64 a66a80a79a81a73 a64 a66 a14 a62a82a64 a66 a14 a72a37a64 a66 a33 a10 a77 a64 a66 a67a69 a64 a66a37a83 a73 a64 a66 a18 Figure 3: Logic C (“C” for CKY) These constraints are enforced by the d-span operators a84 and a85 . Parser C is conceptually simpler than the synchronous parsers of Wu (1997), Alshawi et al.(2000), and Melamed (2003), because it uses only one kind of item, and it never composes terminals.
J00-1004 J97-3002 N03-1021
Y. Matsumoto (1993) “Structural Matching of Parallel Texts,” Proceedings of the ACL.
P93-1004
This kind of synchronizer stands in contrast to more ad-hoc approaches (e.g., Matsumoto, 1993; Meyers, 1996; Wu, 1998; Hwa et al., 2002).
C96-1078 P02-1050 P93-1004 P98-2230
E.g., a53a45a54a55 is a vector spanning dimensions 1 through a56 . See Melamed (2003) for definitions of cardinality, d-span, and the operators a57 and a58 . Parser C needs to know all the boundaries of each item, not just the outermost boundaries.
N03-1021
This normal form allows simpler algorithm descriptions than the normal forms used by Wu (1997) and Melamed (2003).
J97-3002 N03-1021
J. Goodman (1999) “Semiring Parsing,” Computational Linguistics 25(4):573–305.
J99-4004
Bootstrapping a PMTG from a lower-dimensional PMTG and a word-to-word translation model is similar in spirit to the way that regular grammars can help to estimate CFGs (Lari & Young, 1990), and the way that simple translation models can help to bootstrap more sophisticated ones (Brown et al., 1993).
J93-2003
We shall consider the common synchronization scenario where a lexicalized monolingual grammar is available for at least one component.5 Also, given a tokenized set of a87 -tuples of parallel sentences, it is always possible to estimate a word-to-word translation model a0a2a1 a23a4a3 a51 a49a6a5 a3 a41 a51 a48 a49 a24 (e.g., Och & Ney, 2003).6 A word-to-word translation model and a lexicalized monolingual grammar are sufficient to drive a synchronizer.
J03-1002
For example, Melamed (2003) showed how to reduce the computational complexity of a synchronous parser by a7 a23 a0 a51 a24, just by changing the logic.
N03-1021
