Decomposing the translational equivalence relations in the training data into smaller units of knowledge can improve a model’s ability to generalize (Zhang et al., 2006).
N06-1033
The inevitable noise in the data motivated us to focus on lower bounds, complementary to Fox (2002), who wrote that her results “should be looked on as more of an upper bound.” (p.
W02-1039
Unlike Fox (2002) and Galley et al.(2004), we measured failure rates per corpus rather than per sentence pair or per node in a constraining tree.
N04-1035 W02-1039
We parsed the English side of each bilingual bitext and both sides of each English/English bitext using an off-the-shelf syntactic parser (Bikel, 2004), which was trained on sections 02-21 of the Penn English Treebank (Marcus et al., 1993).
J93-2004 W04-3224
So unlike some other studies (Zens and Ney, 2003; Zhang et al., 2006), we used manually annotated alignments instead of automatically generated ones.
N06-1033 P03-1019
Analogous techniques for tree-structured translation models involve either allowing each nonterminal to generate both terminals and other nonterminals (Groves et al., 2004; Chiang, 2005), or, given a constraining parse tree, to “flatten” it (Fox, 2002; Zens and Ney, 2003; Galley et al., 2004).
C04-1154 N04-1035 P03-1019 P05-1033 W02-1039
The Romanian/English and Hindi/English data came from Martin et al.(2005). For Chinese/English and Spanish/English, we used the data from Ayan et al.(2005). The French/English data were those used by Mihalcea and Pedersen (2003).
H05-1024 W03-0301 W05-0809
Wu (1997) has “been unable to find real examples” of cases where hierarchical alignment would fail under these conditions, at least in “fixed-word-order languages that are lightly inflected, such as English and Chinese.” (p.
J97-3002
The other monolingual bitext, labeled “fiction,” consists of two independent translations from French to English of Jules Verne’s novel 20,000 Leagues Under the Sea, sentencealigned by Barzilay and McKeown (2001).
P01-1008
A hierarchical alignment algorithm is a type of synchronous parser where, instead of constraining inferences by the production rules of a grammar, the constraints come from word alignments and possibly other sources (Wu, 1997; Melamed and Wang, 2005).
J97-3002
For example, Koehn et al.(2003) reported that “requiring constituents to be syntactically motivated does not lead to better constituent pairs, but only fewer constituent pairs, with loss of a good amount of valuable knowledge.” This statement is consistent with our findings.
N03-1017
For example, Callison-Burch et al.(2005) have advocated for longer phrases in finite-state phrase-based translation models.
P05-1032
is relevant to finite-state phrase-based models that use no parse trees (Koehn et al., 2003), tree-tostring models that rely on one parse tree (Yamada and Knight, 2001), and tree-to-tree models that rely on two parse trees (Groves et al., 2004, e.g.).
C04-1154 N03-1017 P01-1067
2. Each word-to-word link is generated from a separate nonterminal.2 Our measure of alignment complexity is analogous to what Melamed et al.(2004) call “fanout.”3 The least complex alignments on this measure — those that can be generated with zero gaps — are precisely those that can be generated by an 2If we imagine that each word is generated from a separate nonterminal as in GCNF (Melamed et al., 2004), then constraint 2 becomes a special case of constraint 1.
P04-1084
More generally, for any positive integer k, it is possible to construct a word alignment that cannot be generated using binary production rules whose nonterminals all have fewer than k gaps (Satta and Peserico, 2005).
H05-1101
Our study suggests that there might be some benefits to an alternative approach using discontinuous constituents, as proposed, e.g., by Melamed et al.(2004) and Simard et al.(2005). The large differences in failure rates between the first and second columns of Table 3 are largely independent of the tightness of our lower bounds.
H05-1095 P04-1084
Zhang and Gildea (2004) found that their alignment method, which did not use external syntactic constraints, outperformed the model of Yamada and Knight (2001).
C04-1060 P01-1067
This design decision is one of the main differences between our study and that of Fox (2002), who treated links to the same word conjunctively.
W02-1039
Following Wu (1997), the prevailing opinion in the research community has been that more complex patterns of word alignment in real bitexts are mostly attributable to alignment errors.
J97-3002
Simard et al.(2005) give examples such as English verb-particle constructions, and the French negation ne.
H05-1095
We would expect the opposite effect with hand-aligned data (Galley et al., 2004).
N04-1035
The aligner linked two words to each other only if neither of them was on the function word list and their longest common subsequence ratio (Melamed, 1995) was at least 0.75.
W95-0115