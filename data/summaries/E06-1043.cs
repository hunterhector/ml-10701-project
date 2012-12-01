Let a0a2a1a4a3a6a5a8a7a10a9a12a11a14a13a16a15a17a9a18a5a20a19a22a21a24a23a26a25a27a23a29a28a31a30 be the set of the a28 most similar nouns to the noun a9 of the target pair a32a34a33a36a35 a9a38a37. We calculate the association strength for the target pair, and for each of its variants, a32a39a33a36a35 a9 a5 a37, using pointwise mutual information (PMI) (Church et al., 1991): a40a42a41a44a43 a7 a33a36a35 a9a46a45a47a11a48a13 a49a51a50a53a52a55a54 a7 a33a36a35 a9 a45 a11 a54 a7 a33 a11 a54 a7a10a9 a45 a11 a13 a49a51a50a53a52 a19a56a26a57a34a58a59a19a61a60a62a7 a33a36a35 a9a46a45a47a11 a60a62a7 a33a36a35a64a63 a11a62a60a65a7 a63a66a35 a9 a45 a11 (1) where a67 a23a69a68a70a23a31a28 and a9a36a71 is the target noun; a56 is the set of all transitive verbs in the corpus; a58 is the set of all nouns appearing as the direct object of some verb; a60a2a7 a33a72a35 a9 a45 a11 is the frequency of a33 and a9 a45 occurring as a verb–object pair; a60a62a7 a33a36a35a64a63 a11 is the total frequency of the target verb with any noun in a58 ; a60a2a7 a63a66a35 a9 a45 a11 is the total frequency of the noun a9 a45 in the direct object position of any verb in a56 . Lin (1999) assumes that a target expression is non-compositional if and only if its a40a73a41a74a43 value is significantly different from that of any of the variants.
P99-1041
Venkatapathy and Joshi (2005) combine aspects of the above-mentioned work, by incorporatinglexical fixedness, collocation-based, anddistributional similarity measures into a set of features which are used to rank verb+noun combinations according to their compositionality.
H05-1113
DominicWiddowsandBeateDorow. 2005.
W05-1006
Most previous work on compositionality of MWEs either treat them as collocations (Smadja, 1993), or examine the distributional similarity between the expression and its constituents (McCarthy et al., 2003; Baldwin et al., 2003; Bannard et al., 2003).
J93-1007 W03-1809 W03-1810 W03-1812
Earlier research on the lexical encoding of idioms mainly relied on the existence of human annotations, especially for detecting which syntactic variations (e.g., passivization) an idiom can undergo (Villavicencio et al., 2004).
W04-0411
Lin (1999) and Wermter and Hahn (2005) go one step further and look into a linguistic property of non-compositional compounds—their lexical fixedness—to identify them.
H05-1106 P99-1041
Inspired by Lin(1999), weexamine the strength of association between the verb and noun constituents of the target combination and its variants, as an indirect cue to their idiomaticity.
P99-1041
Nonetheless, it has proven useful in many NLP applications (Resnik, 1999; Dagan et al., 1994).
P94-1038
We use the automatically-built thesaurus of Lin (1998) to find similar words to the noun of the target expression, in order to automatically generate variants.
P98-2127
Others have also drawn on the notion of syntactic fixedness for idiom detection, though specific to a highly constrained type of idiom (Widdows and Dorow, 2005).
W05-1006
