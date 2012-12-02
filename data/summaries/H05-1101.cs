This has been shown for instance in (Wu and Wong, 1998; Yamada and Knight, 2001; Melamed, 2004).
P01-1067 P04-1083 P04-1084 P98-2230
Based on an example from (Yamada and Knight, 2001), we provide asampleSCFGfragmenttranslatingfromEnglishto Japanese, specified by means of the following synchronous productions: s1 : [VB → PRP(1) VB1(2) VB2(3), VB → PRP(1) VB2(3) VB1(1)] s2 : [VB2 → VB(1) TO(2), VB2 → TO(2) VB(1) ga] s3 : [TO → TO(1) NN(2), TO → NN(2) TO(1)] s4 : [PRP → he, PRP → kare ha] s5 : [VB1 → adores, VB1 → daisuki desu] s6 : [VB → listening, VB → kiku no] s7 : [TO → to, TO → wo] s8 : [NN → music, NN → ongaku] Note that in production s2 above, the nonterminals VB and TO generated from nonterminal VB2 in 804 the English component are inverted in the Japanese component, where some additional lexical material is also added.
P01-1067
context-free grammars Several definitions for synchronous context-free grammars have been proposed in the literature; see for instance (Chiang, 2004; Chiang, 2005).
P05-1033
The result could be derived from the findings in (Melamed et al., 2004) that synchronous rewriting systemsasSCFGsarerelatedtotheclassofsocalled linear context-free rewriting systems (LCFRSs) and from the result that the membership problem for 805 LCFRSs is NP-hard (Satta, 1992; Kaji and others, 1994).
P04-1083 P04-1084 P92-1012
The approach started with the so-called IBM models (Brown et al., 1988), implementing a set of elementary operations, such as movement, duplication and translation, that independently act on individual words in the source sentence.
C88-1016
Variant of this definition can be found where the input is a single parse tree for w (Yamada and Knight, 2001), or where the output is a single parse tree, chosen according to some specific criteria (Wu andWong, 1998).
P01-1067 P98-2230
Still, the generative capacity of these models lies within the realm of finite-state machinery (Kumar and Byrne, 2003), so they are unable to handle nested structures and do not provide the expressivity required to process language pairs with very different word orderings.
N03-1019
Among the several proposals, we mention here the models presented in (Wu, 1997; Wu and Wong, 1998), (Alshawi et al., 2000), (Yamada and Knight, 2001), (Gildea, 2003) and (Melamed, 2003).
J00-1004 J97-3002 N03-1021 P01-1067 P03-1011 P98-2230
This problem has been considered for instance in (Wu, 1997) for his inversion transduction grammars and has applications in the support of several tasks of automatic annotation of parallel corpora, as for instance segmentation, bracketing, phrasal and word alignment.
J97-3002
These word-toword models have been later enriched with the introduction of larger units such as phrases; see for instance (Och et al., 1999; Och and Ney, 2002).
P02-1038 W99-0604
Investigation of the computational complexity of translation models has started in (Knight, 1999) for word-to-word models.
J99-4005
