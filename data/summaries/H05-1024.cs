The standard method to overcome this problem to use the model in both directions (interchanging the source and target languages) and applying heuristic-based combination techniques to produce a refined alignment (Och and Ney, 2000; Koehn et al., 2003)—henceforth referred to as “RA.” Several researchers have proposed algorithms for improving word alignment systems by injecting additional knowledge or combining different alignment models.
J03-1002 N03-1017 P00-1056
Word-level alignment is a critical component of a wide range of NLP applications, such as construction of bilingual lexicons (Melamed, 2000), word sense disambiguation (Diab and Resnik, 2002), projection of language resources (Yarowsky et al., 2001), and statistical machine translation.
H01-1035 J00-2004 P02-1033
Work One of the major problems with the IBM models (Brown et al., 1993) and the HMM models (Vogel et al., 1996) is that they are restricted to the alignment of each source-language word to at most one targetlanguage word.
C96-2141 J93-2003
For our experiments, we chose GIZA++ (Och and Ney, 2000) and the RA approach (Koehn et al., 2003)— the best known alignment combination technique— as our initial aligners.1 4.2 TBL Templates Our templates consider consecutive words (of size 1, 2 or 3) in both languages.
J03-1002 N03-1017 P00-1056
These approaches include an enhanced HMM alignment model that uses part-ofspeech tags (Toutanova et al., 2002), a log-linear combination of IBM translation models and HMM models (Och and Ney, 2003), techniques that rely on dependency relations (Cherry and Lin, 2003), and a log-linear combination of IBM Model 3 alignment probabilities, POS tags, and bilingual dictionary coverage (Liu et al., 2005).
J03-1002 P03-1012 P05-1057 W02-1012
In our experiments, we used a dependency parser only in English (a version of the Collins parser (Collins, 1997) that has been adapted for building dependencies) but not in the other language.
P97-1003
Specifically, three features are used to instantiate the templates: • POS tags on both sides: We assign POS tags using the MXPOST tagger (Ratnaparkhi, 1996) for English and Chinese, and Connexor for Spanish.
W96-0213
We computed precision, recall and error rate on the entire set for each data set.6 For an initial alignment, we used GIZA++ in both directions (E-to-F and F-to-E, where F is either Chinese (C) or Spanish (S)), and also two different combined alignments: intersection of E-to-F and F-to-E; and RA using a heuristic combination approach called grow-diag-final (Koehn et al., 2003).
N03-1017
In our approach, we adapt transformation-based learning (TBL) (Brill, 1995; Brill, 1996) to the problem of word alignment.
J95-4004
