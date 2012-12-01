The proper extraction of translation equivalents requires special pre-processing: • sentence alignment; we used a slightly modified version of CharAlign described by Gale and Church (1993). • tokenization; the segmenter we used (MtSeg, developed by P.
J93-1004
The segmenter comes with tokenization resources for several Western European languages, further enhanced in the MULTEXT-EAST project (Dimitrova et al (1998), Erjavec et al (1998), Tufis et al (1998)) with corresponding resources for Bulgarian, Czech, Estonian, Hungarian, Romanian and Slovene.
P98-1050
The assumptions we made were the following: • a lexical token in one half of the translation unit (TU) corresponds to at most one non-empty lexical unit in the other half of the TU; this is the 1:1 mapping assumption which underlines the work of many other researchers (Ahrenberg et al (2000), Brew and McKelvie (1996), Hiemstra (1996), Kay and Röscheisen (1993), Tiedmann (1998), Melamed (2001) etc); • a polysemous lexical token, if used several times in the same TU, is used with the same meaning; this assumption is explicitly used by Gale and Church (1991), Melamed (2001) and implicitly by all the previously mentioned authors; • a lexical token in one part of a TU can be aligned to a lexical token in the other part of the TU only if the two tokens have compatible types (part-of-speech); in most cases, compatibility reduces to the same POS, but it is also possible to define other compatibility mappings (e.g.
H91-1026 J93-1006
and BETA Evaluations We conducted experiments on the "1984" multilingual corpus (Dimitrova et al (1998)) containing 6 translations of the English original.
P98-1050
The estimating approach such as Brown et al.(1993), Kay and Röscheisen (1993), Kupiec (1993), Hiemstra (1997) etc.
J93-1006 J93-2003 P93-1003
The hypotheses-testing methods such as Gale and Church (1991), Smadja et al.(1996), Tiedmann (1998), Ahrenberg (2000), Melamed (2001) etc.
H91-1026 J96-1001
