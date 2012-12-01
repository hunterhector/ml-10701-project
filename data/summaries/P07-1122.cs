This study is concerned with two such phenomena, coordination and verb groups, for which tree transformations have been shown to improve parsing accuracy for MaltParser on Czech (Nilsson et al., 2006).
P06-1033
Nilsson et al.(2006) also show that the annotation of verb groups is not well-suited for parsing PDT using MaltParser, and that transforming the dependencystructure forverbgroupshas apositiveimpact on parsing accuracy.
P06-1033
Another example is the second-order approximate spanning tree parser developed by McDonald and Pereira (2006).
E06-1011 W06-2932
Dev Eval Niv McD SDT ASU 80.40 82.01 78.72 83.17 ASL 71.06 72.44 70.30 73.44 PADT ASU 78.97 78.56 77.52 79.34 ASL 67.63 67.58 66.71 66.91 Alpino ASU 87.63 82.85 81.35 83.57 ASL 84.02 79.73 78.59 79.19 PDT ASU 85.72 85.98 84.80 87.30 ASL 78.56 78.80 78.42 80.18 Table 7: Evaluation on CoNLL-X test data; MaltParser with all transformations (Dev = development, Eval = CoNLL test set, Niv = Nivre et al.(2006), McD = McDonald et al.(2006)) not require the pseudo-projective transformation.
E06-1011 W06-2932 W06-2933
Any details concerning the conversion from the original formats of the various treebanks to the CoNLLformat,apuredependencybasedformat,are found in documentation referred to in Buchholz and Marsi (2006).
W06-2920
We will focus on tree transformations that combine preprocessing with post-processing, and where the parser is treated as a black box, such as the pseudo-projective parsing technique proposed by Nivre and Nilsson (2005) and the tree transformations investigated in Nilsson et al.(2006). To study the influence of lan968 guage and treebank specific properties we will use data from Arabic, Czech, Dutch, and Slovene, taken from the CoNLL-X shared task on multilingual dependency parsing (Buchholz and Marsi, 2006).
P05-1013 P06-1033 W06-2920 W06-2933
A third way of treating coordination, not discussed by Nilsson et al.(2006), is used by the parser of Collins (1999), which internally represents coordination as a direct relation between the conjuncts.
P06-1033 P99-1065
Table 7 gives the results for both development (cross-validation for SDT, PADT, and Alpino; 974 development set for PDT) and final test, compared to the two top performing systems in the shared task, MSTParser with approximate second-order non-projective parsing (McDonald et al., 2006) and MaltParser with pseudo-projective parsing (but no coordination or verb group transformations) (Nivre et al., 2006).
E06-1011 W06-2932 W06-2933
For SDT, PADT and PDT, the annotation of coordination has been transformed from PS to MS, as described in Nilsson et al.(2006). For Alpino, the transformation is from PS to CS (cf.
P06-1033
Corresponding manipulations in the form of tree transformations for dependency-based parsers have recently gained more interest (Nivre and Nilsson, 2005; Hall and Nov´ak, 2005; McDonald and Pereira, 2006; Nilsson et al., 2006) but are still less studied, partly because constituency-based parsing has dominated the field for a long time, and partly because dependency structures have less structure to manipulate than constituent structures.
E06-1011 P05-1013 P06-1033 W05-1505 W06-2932 W06-2933
The first thing to note is that pseudo-projective parsing gives a significant improvement for PDT, as previously reported by Nivre and Nilsson (2005), but also for Alpino, where the improvement is even larger, presumably because of the higher proportion of non-projective dependencies in the Dutch treebank.
P05-1013
Finally, the lack of information about the share of auxiliary verbs is not due to the non-existence of such verbs in Dutch but to the fact that Alpino adopts an MS annotation of verb groups (i.e., treating main verbs as dependents of auxiliary verbs), which means that the verb group transformation of Nilsson et al.(2006) is not applicable.
P06-1033
Pure Post-processing Hall and Nov´ak (2005) propose a corrective modeling approach.
W05-1505
Bikel. 2004.
J04-4004
The motivation is that the parsers of Collins et al.(1999) and Charniak (2000) adapted to Czech are not able to create the non-projective arcs present in the treebank, which is unsatisfactory.
A00-2018 P99-1065
MSTParser instead extracts a maximum spanning tree from a dense weighted graph containing all possible dependency arcs between tokens (with Eisner’s algorithm for projective dependency structures or the Chu-Liu-Edmonds algorithm for non-projective structures), using a global discriminative model and online learning to assign weights to individual arcs.2 2The experiments in this paper are based on the first-order factorization described in McDonald et al.(2005) 971 5 Experiments The experiments reported in section 5.1–5.2 below are based on the training sets from the CoNLL-X shared task, except where noted.
H05-1066
Finally, in contrast to the results reported by Nivre and Nilsson (2005), simply projectivizing the training data (without using an inverse transformation) is not beneficial at all, except possibly for Alpino.
P05-1013
This can be seen in state-of-the-art constituency-based parsers such as Collins (1999), Charniak (2000), and Petrovetal.(2006),andtheeffectsofdifferenttransformations have been studied by Johnson (1998), KleinandManning(2003),andBikel(2004).
A00-2018 J04-4004 J98-4004 P03-1054 P06-1055 P99-1065
To study the influence of parsing methodology, we will compare two different parsers: MaltParser (Nivre et al., 2004) and MSTParser (McDonald et al., 2005).
H05-1066 P05-1013 W04-2407
The parsers used in the experiments are MaltParser (Nivre et al., 2004) and MSTParser (McDonald et al., 2005).
H05-1066 P05-1013 W04-2407
The pseudo-projective transformation proposed by Nivre and Nilsson (2005) is such an approach, which is compatible with different parser engines.
P05-1013
As the figures indicate, transforming coordination isbeneficialnotonlyforPDT,asreportedbyNilsson et al.(2006), but also for SDT, PADT, and Alpino.
P06-1033
In discussing the recovery of empty categories in data-driven constituency parsing, Campbell (2004) distinguishes between approaches based on pure post-processing and approaches based on a combination of preprocessing and post-processing.
P04-1082
The definition of non-projectivity can be found in Kahane et al.(1998). Informally, an arc is projectiveifalltokensitcoversaredescendantsofthearc’s head token, and a dependency tree is projective if all its arcs are projective.1 The full potential of dependency parsing can only be realized if non-projectivity is allowed, which pose a problem for projective dependency parsers.
P98-1106
