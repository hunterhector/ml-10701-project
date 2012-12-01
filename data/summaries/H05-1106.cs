This is equivalent to the likelihood of nding a true positive by blindly picking from one of the different sets (see Subsection 3.2). 10Studies on collocation extraction (e.g., by Evert and Krenn (2001)) also point out the inadequacy of such evaluation methods.
P01-1025
This is in line with our previous work on generallanguage collocation extraction (Wermter and Hahn, 2004), in which we showed that a linguistically motivated criterion based on the limited syntagmatic modi ability of collocations outperforms alternative standard association measures as well.
C04-1141
We compare our P -Mod algorithm against the t-test measure,11 which, of all standard measures, yields the best results in general-language collocation extraction studies (Evert and Krenn, 2001), and also against the widely used C-value, which aims at enhancing the common frequency of occurrence measure by making it sensitive to nested terms (Frantzi et al., 2000).
P01-1025
also Evert and Krenn (2001)), we de ned different frequency cut-off thresholds, c, for the bigram, trigram and quadgram candidate sets and only considered candidates above these thresholds.
P01-1025
Work The automatic extraction of complex multi-word terms from domain-speci c corpora is already an active eld of research (cf., e.g., for the biomedical domain Rind esch et al.(1999), Collier et al.(2002), Bodenreider et al.(2002), or Nenadi·c et al.(2003)). Typically, in all of these approaches term candidates are collected from texts by various forms of linguistic ltering (part-of-speech tagging, phrase chunking, etc.), through which candidates obeying various linguistic patterns are identi ed (e.g., noun-noun, adjective-noun-noun combinations).
W02-0308
Other potential association measures are mutual information (Damerau, 1993) and the whole battery of statistical and information-theoretic measures (t-test, loglikelihood, entropy) which are typically employed for the extraction of general-language collocations (Manning and Schcurrency1utze, 1999; Evert and Krenn, 2001).
P01-1025
These candidates are then submitted to frequencyor statistically-based evidence measures 1Nakagawa and Mori (2002) claim that more than 85% of domain-speci c terms are multi-word units.
W02-1407
and Experiments 3.1 Text Corpus We collected a biomedical training corpus of approximately 513,000 MEDLINE abstracts using the following query composed of MESH terms from the biomedical domain: transcription factors, blood cells and human.3 We then annotated the resulting 104-million-word corpus with the GENIA partof-speech tagger4 and identi ed noun phrases (NPs) with the YAMCHA chunker (Kudo and Matsumoto, 2001).
N01-1025
While these measures have their statistical merits in terminology identi cation, it is interesting to note that they only make little use of linguistic properties inherent to complex terms.2 More linguistically oriented work on ATR by Daille (1996) or on term variation by Jacquemin (1999) builds on the deep syntactic analysis of term candidates.
P99-1044
