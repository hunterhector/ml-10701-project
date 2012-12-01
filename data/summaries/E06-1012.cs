For the parsing models that will be described below, the relevant statistical parameters needed have been estimated from the Turkish treebank (Oflazer et al., 2003).
J03-4001
Collins (1996) employs this distance ∆i,H(i) in the computation of word-toword dependency probabilities P(dep(wi,wH(i))|S) ≈ (2) P(link(wi,wH(i))|∆i,H(i)) suggesting that distance is a crucial variable when deciding whether two words are related, along with other features such as intervening punctuation.
P96-1025
With the emergence of the important role of word-to-word relations in parsing (Charniak, 2000; Collins, 1996), dependency grammars have gained acertain popularity; e.g., Yamada and Matsumoto (2003) for English, Kudo and Matsumoto (2000; 2002), Sekine et al.(2000) for Japanese, Chung and Rim (2004) for Korean, Nivre et al.(2004) for Swedish, Nivre and Nilsson (2005) for Czech, among others.
A00-2018 C00-2109 P05-1013 P96-1025 W00-1303 W02-2016 W04-2407
We have also been encouraged by the success of the unlexicalized parsers reported recently (Klein and Manning, 2003; Chung and Rim, 2004).
P03-1054
Collins et al.(1999) applied the parser of Collins (1997) developed for English, to Czech, and found thatthe performance wassubstantially lower when compared to the results for English.
P97-1003 P99-1065
For parsing, we use a version of the Backward Beam Search Algorithm (Sekine et al., 2000) developed for Japanese dependency analysis adapted to our representations of the morphological structureofthewords.
C00-2109
And again with minor exceptions, the dependency links between the IGs, when drawn above the IG sequence, do not cross.3 Figure 3 from Oflazer (2003) shows a dependency tree for a Turkish sentence laid on top of the words segmented along IG boundaries.
J03-4001
This is a modified version of the backed-off smoothing used by Collins (1996) to alleviate sparse data problems.
P96-1025
3Only 2.5% of the dependencies in the Turkish treebank (Oflazer et al., 2003) actually cross another dependency link.
J03-4001
