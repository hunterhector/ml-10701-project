We refer to this below as the HanC system, because it uses a Hand-crafted Dictionary 2.Wechangedthisso that a learned dictionary consisting of wordassociations (Moore 2001) with parts of speech and a function word only bilingual dictionary (prepositions, conjunctions and pronouns) replaces the previous combination both at training and at runtime 3 . We refer to this as the 1 In both French-English and French-Spanish, we use a hand-crafted bilingual function word dictionary of about 500 entries.
W01-1411
Systran The finisher is treated like three individual racks, 4.1.4 Creation of the learned bilingual dictionary The learned dictionary with parts of speech was created by the same method (Moore, 2001) as the previously used word-association file, with the exception that parts of speech were appended to lemmas in the first step of the process.
W01-1411
With the advent of bitexts, efforts to derive bilingual lexicons have led to substantial research (Melamed 1996, Moore 2001 for discussion), including resources for semi-automatic creation of bilingual lexica such as SABLE (Melamed 1997), used for instance in Palmer et al.(1998). Statistical MT systems have relied on bi-texts to automatically create word-alignments; in many statistical MT systems however, the authors state that use of a conventional bilingual dictionary enhances the performance of the system (Al-Onaizan et al.1999, Koehn & Knight 2001).
W01-0504 W01-1411
The transfer component, described in detail in Menezes (2001), consists of high-quality transfer patterns automatically acquired from sentence-aligned bilingual corpora.
W01-1406
A complete description of the evaluation method is given in Richardson (2001), and repeated in Appendix A.
W01-1402
The architecture of the MT system as described elsewhere (Richardson et al.2001) used both a traditional bilingual dictionary and an automatically derived word-association file at training time, but it used only the traditional bilingual dictionary at runtime.
W01-1402
