8However, it has to be said that the pure statistical or machine-learning based approaches to POS tagging still significantly underperform some sophisticated manually constructed systems, such as the English shallow parser based on Constraint Grammars developed at the Helsinki University (Samuelsson and Voutilainen, 1997).
P97-1032
DeRose. 1988.
J88-1003
In that table, TBL stands for Brill's transformation-based error-driven tagget (Brill, 1995), ME stands for a tagger based on the ma×imum entropy modelling (Ratnaparkhi, 1996), SPATTER stands for a statistical parser based on decision trees (Magerman, 1996), IGTREE stands for the memory-based tagger by Daelemans et al.(1996), and, finally, TComb stands for a tagger that works by combination of a statistical trigram-based tagger, 59 Tagger TBL ME SPATTER IGTREE TComb STT+(CPD+ENS) Train Test 950 Kw 150 Kw 963 Kw 193 Kw ~975 Kw 47 Kw 2,000 kw 200 Kw 1,i00 Kw 265 Kw Overall Known Unknown 96.6% -82.2% 96.5% -86.2% 96.5% --96.4% 96.7% 90.6% 97.2% --Ambig 998 Kw 175 Kw 97.2% 97.5% 84.5% 92.8% Table 6: Comparison of different tuggers on the WSJ corpus TBL and ME (Brill and Wu, 1998).
J95-4004 P98-1029 W96-0102 W96-0213
2.2 STT: A Statistical Tree-based Tagger The aim of statistical or probabilistic tagging (Church, 1988; Cutting et al., 1992) is to assign the most likely sequence of tags given the observed sequence of words.
A88-1019 A92-1018
Church. 1988.
A88-1019
Very similar to Brill's lexical patterns (Brill, 1995), we also have included features to capture collocational information.
J95-4004
However, we are now more interested on experimenting with the inclusion of our tagger as a component in an ensemble of preexisting tuggers, in the style of (Brill and Wu, 1998; van Halteren et al., 1998).
P98-1029 P98-1081
More recently, two parallel works (van Halteren et al., 1998; Brill and Wu, 1998) combined, with a remarkable success, the output of a set of four tuggers based on different principles and feature modelling.
P98-1029 P98-1081
The last group of features are inspired in those applied by Brill (1995) when addressing unknown words.
J95-4004
