Most work on ellipsis (Fiengo and May, 1994; Lappin, 1993; Dalrymple et al., 1991; Kehler, 1993; Shieber et al., 1996) is aimed at discerning the procedures and the level of language processing at which ellipsis resolution takes place, or ambiguous and difficult cases.
E93-1025
Adding empty category information gives 88%, compared to previous results of 48% (Hardt, 1997) † Re-parsing the Treebank data, top performance is 63%, raised to 68% using extra features † Parsing the BNC, top performance is 71%, raised to 72% using extra features † Combining the parsed data, top performance is 67%, raised to 71% using extra features The results demonstrate that the method can be applied to practical tasks using free text.
J97-4002
work Hardt’s (1997) algorithm for detecting VPE in the Penn Treebank (see Section 3) achieves precision levels of 44% and recall of 53%, giving an F11 of 48%, using a simple search technique, which relies on the parse annotation having identified empty expressions correctly.
J97-4002
Algorithm Recall Precision F1 Auxiliary-final VP 72.54 35.23 47.43 MBL 63.39 71.32 67.12 GIS-MaxEnt 54.90 77.06 64.12 L-BFGS-MaxEnt 71.89 76.38 74.07 Table 6: Effects of using the Auxiliary-final VP feature Empty VP Hardt (1997) uses a simple pattern check to search for empty VP’s identified by the Treebank, (VP (-NONE*?*)), which achieves 60% F1 on our test set.
J97-4002
The expanded set of results are summarised in Table 1, for Transformation Based Learning (TBL) (Brill, 1995), GIS based Maximum Entropy Modelling (GIS-MaxEnt) (Ratnaparkhi, 1998), L-BFGS based Maximum Entropy Modelling (L-BFGS-MaxEnt)2 (Malouf, 2002), Decision Tree Learning (Quinlan, 1993) and Memory Based Learning (MBL) (Daelemans et al., 2002).
J95-4004 W02-2018
The Penn Treebank (Marcus et al., 1994) has more than a hundred phrase labels, and a number of empty categories, but uses a coarser tagset.
H94-1020
Next, we will experiment with an algorithm (Johnson, 2002) that can insert empty-category information into data from Charniak’s parser, allowing replication of features that need this.
P02-1018
For most cases of ellipsis, copying of the antecedent clause is enough for resolution (Hardt, 1997).
J97-4002
While TBL gave the best results, the software we used (Lager, 1999) ran into memory problems and proved problematic with larger datasets.
W99-0705
used Charniak’s parser (2000) is a combination probabilistic context free grammar and maximum entropy parser.
A00-2018
