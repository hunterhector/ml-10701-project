Brown et al.(1990, 1993) use a stochastic language model based on techniques used in speech recognition, combined with translation probabilities compiled on the aligned corpus, to do sentence translation.
J90-2002 J93-2003
(Brown et al.1991; Dagan, Itai, and Schwall 1991; Dagan and Itai 1994).
A94-1006 J94-4003 P91-1017 P91-1022 P91-1034
The work by Fung and McKeown (1994) and Fung (1995b) is notable for its use of techniques suitable to Asian/Romance language pairs as well as Romance language pairs.
P95-1032 W95-0114
This approach is quite different from those adopted for the translation of single words (Klavans and Tzoukermann 1990; Dorr 1992; Klavans and Tzoukermann 1996), since for single words polysemy cannot be ignored; indeed, the problem of sense disambiguation has been linked to the problem of translating ambiguous words (Brown et al.1991; Dagan, Itai, and Schwall 1991; Dagan and Itai 1994).
A94-1006 J94-4003 P91-1017 P91-1022 P91-1034
Note that these problems are quite similar to the difficulties in translating technical terminology, which also is usually part of a particular technical sublanguage (Dagan and Church 1994).
A94-1006 J94-4003
Thus, we draw on work done at AT&T Bell Laboratories by Gale and Church (1991a, 1991b, 1993) and at IBM by Brown, Lai, and Mercer (1991) on bilingual sentence alignment.
H91-1026 J93-1004 P91-1022 P91-1023 P91-1034 P93-1001
The AT&T group (Gale and Church 1993) defines sentence length by the number of characters in the sentences, while the IBM group (Brown, Lai, and Mercer 1991) defines sentence length by the number of words in the sentence.
J93-1004 P91-1022 P91-1034 P93-1001
The assumption of a single meaning per collocation was based on our previous experience with English collocations (Smadja 1993), is supported for less opaque collocations by the fact that their constituent words tend to have a single sense when they appear in the collocation (Yarowsky 1993), and was verified during our evaluation of Champollion (Section 7).
H93-1052
Other recent related work aims at using statistical techniques to produce translations of single words (Fung and McKeown 1994; Wu and Xia 1994; Fung 1995b) Smadja, McKeown, and Hatzivassiloglou Translating Collocations for Bilingual Lexicons as opposed to collocations or phrases.
P95-1032 W95-0114
Their system, Candide, uses little linguistic and no semantic information and currently produces good quality translations for short sentences containing high frequency vocabulary, as measured by individual human evaluators (see Berger et al.\[1994\] for information on recent results).
H94-1028
By doing so, we lost an estimated 10% of the text (Brown, Lai, and Mercer 1991), which was not problematic since we had enough data.
P91-1022 P91-1034
Related Work The recent availability of large amounts of bilingual data has attracted interest in several areas, including sentence alignment (Gale and Church 1991b; Brown, Lai, and Mercer 1991; Simard, Foster and Isabelle 1992; Gale and Church 1993; Chen 1993), word alignment (Gale and Church 1991a; Brown et al.1993; Dagan, Church, and Gale 1993; Fung and McKeown 1994; Fung 1995b), alignment of groups of words (Smadja 1992; Kupiec 1993; van der Eijk 1993), and statistical translation (Brown et al.1993). Of these, aligning groups of words is most similar to the work reported here, although, as we shall show, we consider a greater variety of groups than is typical in other research.
A94-1006 H91-1026 J93-1004 J93-2003 J94-4003 P91-1022 P91-1023 P91-1034 P93-1001 P93-1002 P93-1022 P95-1032 W93-0301 W95-0114
Bilingual word correspondences extracted from nonparallel corpora with techniques such as those proposed by Fung (1995a) also look promising.
P95-1032 W95-0114
For example, the normalized chi-square measure (¢2) used in Gale and Church (1991a) shares some of the important properties of average mutual information (for example, it is completely symmetric with respect to 1-1 and 0-0 matches).
H91-1026 P91-1023
Another approach, begun more recently than our work, is taken by Dagan and Church (1994), who use statistical methods to translate technical terminology.
A94-1006 J94-4003
It has been noted in more recent work that length-based alignment programs such as these are problematic for many cases of real world parallel data, such as OCR (Optical Character Recognition) input, in which periods may not be noticeable (Church 1993), or languages where insertions or deletions are common (Shemtov 1993; Fung and McKeown 1994).
P93-1001
For example, previous work has addressed low-level tasks such as tagging a free-style corpus with part-of-speech information (Church 1988), aligning a bilingual corpus (Gale and Church 1991b; Brown, Lai, and Mercer 1991), and producing a list of collocations (Smadja 1993).
A88-1019 H91-1026 J93-1004 J93-2003 P91-1022 P91-1023 P91-1034 P93-1001
Indeed, more complex sentence alignments tend to have a much higher alignment error rate (Gale and Church 1991b).
H91-1026 P91-1023
For our experiments, we used corpora that had been aligned by Gale and Church's sentence alignment program (Gale and Church 1991b) as our input data.
H91-1026 P91-1023
