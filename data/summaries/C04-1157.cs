Most work on ellipsis (Fiengo and May, 1994; Lappin, 1993; Dalrymple et al., 1991; Kehler, 1993; Shieber et al., 1996) is aimed at discerning the procedures and the level of language processing at which ellipsis resolution takes place, or focuses on ambiguous and di–cult cases.
E93-1025
The expanded set of results are summarised in Table 1, for Transformation Based Learning (TBL) (Brill, 1995), GIS based Maximum Entropy Modelling (GIS-MaxEnt)2 (Ratnaparkhi, 1998), L-BFGS based Maximum Entropy Modelling (L-BFGSMaxEnt)3 (Malouf, 2002), Decision Tree Learning (Quinlan, 1993) and Memory Based Learning (MBL) (Daelemans et al., 2002).
J95-4004 W02-2018
Algorithm Recall Precision F1 Auxiliary-flnal VP 72.54 35.23 47.43 MBL 63.39 71.32 67.12 GIS-MaxEnt 54.90 77.06 64.12 L-BFGS-MaxEnt 71.89 76.38 74.07 Table 6: Efiects of using the Auxiliary-flnal VP feature Empty VP Hardt (1997) uses a simple pattern check to search for empty VP’s identifled by the Treebank, (VP (-NONE*?*)), which is to say a ...
J97-4002
While Charniak’s parser does not generate empty category information, Johnson (2002) has developed an algorithm that extracts patterns from the Treebank which can be used to insert empty Words + POS + features Algorithm Recall Precision F1 Recall Precision F1 MBL 56.05 63.02 59.33 78.32 79.39 78.85 GIS-MaxEnt 40.00 57.03 47.02 65.06 68.64 66.80 L-BFGS-MaxEnt 60.08 70.77 64.99 78.92 87.27 82.88 Table 9: Cross-validation on the Treebank categories into the parser’s output.
P02-1018
The Penn Treebank (Marcus et al., 1994) has more than a hundred phrase labels, and a number of empty categories, but uses a coarser tagset.
H94-1020
work Hardt’s (1997) algorithm for detecting VPE in the Penn Treebank (see Section 3) achieves recall levels of 53% and precision of 44%, giving an F11 of 48%, using a simple search tech1Precision, recall and F1 are deflned as : Recall = No(correct ellipses found)No(all ellipses in test) (1) nique, which relies on the parse annotation having identifled empty expressions correctly.
J97-4002
For most cases of ellipsis, copying of the antecedent clause is enough for resolution (Hardt, 1997).
J97-4002
While TBL gave the best results, the software we used (Lager, 1999) ran into memory problems and proved problematic with larger datasets.
W99-0705
used Charniak’s parser (2000) is a combination probabilistic context free grammar and maximum entropy parser.
A00-2018
