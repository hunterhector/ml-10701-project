Clearly the present research task is quite considerably harder than the parsing and tagging tasks undertaken in (Jelinek et al., 1994; Magerman, 1995; Black et al., 1993b), which would seem to be the closest work to ours, and any comparison between this work and ours must be approached with extreme caution.
H94-1052 P93-1005 P95-1037
For example, the feature 1 On the ATR English Grammar, see below; for a detailed description of a precursor to the Gr-r~raar, see (Black et al., 1993a).
P93-1005
How the Grammar Helps Figure 1 shows a sampling of parsed sentences from the one-million-word ATR/Lancaster 'IYeebauk of General English (Black et al., 1996), which we employ for training; smoothing and testing our parser.
C96-1020
(Wang et at., 1994) take on the problem of converting treeb~n~ conforming to their English grammar into a format conforming to a later version of the same grammar, and report a conversion accuracy of some 96% on a 141,000-word test set.
P94-1034
Probabilistic decision trees are utilized as a mea.ns of prediction, roughly as in (Jelinek et al., 1994; Magermau, 1995), and as in these references, training is supervised, and in particular is treebank-based.
H94-1052
By labelling Treeb~n~ nodes with Gr~ramar rule names, and not with phrasal and clausal n~raes, as in other (non-gr~rarnar-based) treebanks' (Eyes and Leech, 1993; Garside and McEnery, 1993; Marcus et al., 1993), we gain access to all information provided by the Grammar regarding each ~reebank node.
J93-2004
For example, the sets of tags and rule labels have been clustered by our team gr~:mm~trian, while a vocabulary of about 60,000 words has been clustered by machine (Brown et al., 1992; Ushioda~ 1996a; Ushioda, 1996b).
C96-2212 J92-4003 W96-0103
(Magerman, 1995; Black et at., 1993b), who do not employ an exact-match evaluation criterion, further obscuring possible performance comparisons.
P93-1005 P95-1037
at. for IBM Manua!s task; see Table 3 above I i I I I I I i I I I parsing results by (Jelinek et al., 1994).
H94-1052
Table 3 shows the differences between the treebank~ utilized in (Jelinek et al., 1994) on the one hand, and in the work reported here, on the other, is Table 4 shows relevant lSFigures for Average Sentence Length ('l~raLuing Corpus) and Training Set Size, for the IBM ManuaLs Corpus, are approximate, and cz~e fzom (Black et aL, 1993a).
H94-1052 P93-1005
In all other respects, our work departs from previous research on broad--coverage 16 I t I I I I I i ! I i I I I I I I I I I I I i I 1, I. I I I I i I 1 I I I I probabilistic parsing, which either attempts to learn to predict gr~rarn~tical structure of test data directly from a training treebank (Brill, 1993; Collins, 1996; Eisner, 1996; Jelinek et al., 1994; Magerman, 1995; S~kine and Orishman, 1995; Sharman et al., 1990), or employs a grammar and sometimes a dictionary to capture linguistic expertise directly (Black et al., 1993a; GrinBerg et al., 1995; Schabes; 1992), but arguably at a less detailed and informative level than in the research reported here.
C92-2066 C96-1058 H90-1054 H94-1052 P93-1005 P93-1035 P95-1037 P96-1025
Magerman. 1995.
P95-1037
Slrs Parse Base (Black et al., 1993a) is 1.76. 20 I • choose one or more most likely parts-of-speech; • estimate the probability for each tag for the first word, given the part-of-speech decision(s) made above; • choose one (or several) likely tag(s); • repeat the steps above for each word in the sentence.
P93-1005
SSee (Black et al., 1996).
C96-1020
