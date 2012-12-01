However, the feature used by Soon et al.(2001) is neither sufficient nor language dependent, the one used by Vieira and Poesio (2000) is not cheap since it relies on a syntactic analysis.
J00-4003 J01-4004
They only used pairs of anaphors and their closest antecedents as positive examples in training, but evaluated according to Vilain et al.(1995). Cardie and Wagstaff (1999) describe an unsupervised clustering approach to noun phrase coreference resolution in which features are assigned to single noun phrases only.
M95-1005 W99-0611
McCarthy and Lehnert (1995) achieved results of about 86% F-measure (evaluated according to Vilain et al.(1995)) on the MUC-5 data set.
M95-1005
4.5 MUC-style results It is common practice to evaluate coreference resolution systems according to a scheme originally developed for MUC evaluation by (Vilain et al., 1995).
M95-1005
the weak string identity feature as used by Soon et al.(2001)), domain dependent (their alias feature or similar features used by Cardie and Wagstaff (1999)), or relied on information on the syntactic structure (Vieira and Poesio, 2000).
J00-4003 J01-4004 W99-0611
The texts were POS-tagged using TnT (Brants, 2000).
A00-1031
The feature semantic class used by Cardie and Wagstaff (1999) seems to be a domain-dependent one which can only be used for the MUC domain and similar ones.
W99-0611
Aone and Bennett (1995), working on reference resolution in Japanese newspaper articles, use 66 features.
P95-1017
Cardie and Wagstaff (1999) report a performance of 53,6% F-measure (evaluated according to Vilain et al.(1995)). 3 Data 3.1 Text Corpus Our corpus consists of 242 short German texts (total 36924 tokens) about sights, historic events and persons in Heidelberg.
M95-1005 W99-0611
An unsupervised approach to the resolution of definite NPs was applied by Cardie and Wagstaff (1999).
W99-0611
Aone and Bennett (1995) report that their best classifier achieved an F-measure of about 77% after training on 250 documents.
P95-1017
Supervised machine learning algorithms have been used for pronoun resolution (Ge et al., 1998) and for the resolution of definite NPs (Aone and Bennett, 1995; McCarthy and Lehnert, 1995; Soon et al., 2001).
J01-4004 P95-1017 W98-1119
Soon et al.(2001) use twelve features (see Table 1).
J01-4004
Decision tree algorithms were used for reference resolution by Aone and Bennett (1995, C4.5), McCarthy and Lehnert (1995, C4.5) and Soon et al.(2001, C5.0).
J01-4004 P95-1017
Soon et al.(2001) removed determiners before comparing the strings.
J01-4004
Soon et al.(2001) show a part of their decision tree in which the weak string identity feature (i.e.
J01-4004
The reliability of the annotations was checked using the kappa statistic (Carletta, 1996).
J96-2004
It was criticized (Soon et al., 2001) that the features used by McCarthy and Lehnert (1995) are highly idiosyncratic and applicable only to one particular domain.
J01-4004
Other researchers like Vieira and Poesio (2000) used information about the syntactic structure and compared only the syntactic heads of the phrases.
J00-4003
NPs) was obtained by using the NP-Chunker Chunkie (Skut and Brants, 1998).
W98-1117
Once a text has been completely processed, the resulting coreference classes are evaluated by comparing them to the original annotation according to the scheme proposed by (Vilain et al., 1995).
M95-1005
Soon et al.(2001) include all noun phrases returned by their NP identifier and report an F-measure of 62.6% for MUC-6 data and 60.4% for MUC-7 data.
J01-4004
