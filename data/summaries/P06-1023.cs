Our parser also ranks highest in terms of the co-indexation accuracy with 77.4% f-score, again outperforming the system of Campbell (2004) by 0.7%.
P04-1082
In our experiments, we used the BitPar parser (Schmid, 2004) and a PCFG which was extracted from a version of the PENN treebank that was automatically annotated with features in the style of (Klein and Manning, 2003).
C04-1024 P03-1054
Table 7 compares the empty category prediction results of our parser with those reported in Johnson (2001), Dienes and Dubey (2003b) and Campbell (2004).
P03-1055 P04-1082 W03-1005
prec. recall f-score this paper 86.0 82.3 84.1 Campbell 85.2 81.7 83.4 Dienes & Dubey 86.5 72.9 79.1 Johnson 85 74 79 Table 5: Accuracy of empty category prediction on section 23 The good performance of our parser on the empty element recognition task is remarkable considering the fact that its performance on the labeled bracketing task is 3% lower than that of the Charniak (2000) parser used by Campbell (2004).
A00-2018 P04-1082
However, most broad-coverage statistical parsers (Collins, 1997; Charniak, 2000, and others) which are trained on the PENN treebank generate parse trees without empty categories.
A00-2018 P97-1003
Empty categories (also called null elements) are used in the annotation of the PENN treebank (Marcus et al., 1993) in order to represent syntactic phenomena like constituent movement (e.g.
J93-2004
In an evaluation on the PENN treebank (Marcus et al., 1993), the parser outperformed other unlexicalized PCFG parsers in terms of labeled bracketing fscore.
J93-2004
Besides the slash features, we used other features in order to improve the parsing accuracy of the PCFG, inspired by the work of Klein and Manning (2003).
P03-1054
The gap and domV features described above were also used by Klein and Manning (2003).
P03-1054
On the empty category prediction task, our parser outperforms the best previously reported system (Campbell, 2004) by 0.7% reaching an f-score of 84.1%, although the general parsing accuracy of our unlexicalized parser is 3% lower than that of the parser used by Campbell (2004).
P04-1082
NP-SBJ/3s/domV_<S> NP/base/3s/expl PRP/expl It S_<S> -NONE-_<S> *EXP*_#<S> VP/3s+<S> VBZ/pst ’s PP/V IN/up up PP/PP TO to NP/base PRP you S/to/gap+#<S> NP-SBJ -NONE* VP/to TO to VP/inf VV/r protect NP/refl/base PRP/refl yourself Figure 5: An Annotated Parse Tree the following technique which was adopted from Klein and Manning (2003).
P03-1054
(ii) post-processing of the parse trees with a pattern matcher which adds empty categories after parsing (Johnson, 2001; Campbell, 2004; Levy and Manning, 2004) (iii) in-processing of the empty categories with a slash percolation mechanism (Dienes and Dubey, 2003b; Dienes and Dubey, 2003a).
P03-1055 P04-1042 P04-1082 W03-1005
Table 7 shows the trace prediction accuracies of our parser, Johnson’s (2001) parser with parser input and perfect input, and Campbell’s (2004) parser with perfect input.
P04-1082
The grammar is extracted from a version of the PENN treebank which was automatically annotated with features in the style of Klein and Manning (2003).
P03-1054
Johnson (1998)).
J98-4004
prec. recall f-score this paper 81.7 73.5 77.4 Campbell 78.3 75.1 76.7 Dienes & Dubey (b) 81.5 68.7 74.6 Dienes & Dubey (a) 80.5 66.0 72.6 Johnson 73 63 68 Table 6: Co-indexation accuracy on section 23 Table 6 compares our co-indexation results with those reported in Johnson (2001), Dienes and Dubey (2003b), Dienes and Dubey (2003a), and Campbell (2004).
P03-1055 P04-1082 W03-1005
In order to augment such parsers with empty category prediction, three rather different strategies have been proposed: (i) pre-processing of the input sentence with a tagger which inserts empty categories into the input string of the parser (Dienes and Dubey, 2003b; Dienes and Dubey, 2003a).
P03-1055 W03-1005
The labeled bracketing f-score of 86.6% is – to our knowledge – the best f-score reported for unlexicalized PCFGs, exceeding that of Klein and Manning (2003) by almost 1%.
P03-1054
Good results have been obtained with all three approaches, but (Dienes and Dubey, 2003b) reported that in their experiments, the in-processing of the empty categories only worked with lexicalized parsing.
P03-1055 W03-1005
Campbell’s parser and our parser cannot be directly compared, but when we take the respective performance difference to Johnson’s parser as evidence, we might conclude that Campbell’s parser works particularly well on NP *, *U*, and WHNP 0, whereas our system 183 paper J1 J2 C NP * 83.2 82 91 97.5 NP *T* 86.2 81 91 96.2 0 92.3 88 96 98.5 *U* 94.5 92 95 98.6 ADVP *T* 71.7 56 66 79.9 S *T* 90.1 88 90 92.7 SBAR-S *T* 82.1 70 74 84.4 WHNP 0 60.4 47 77 92.4 WHADVP 0 60.0 – – 73.3 Table 7: Comparison of the empty category prediction accuracies for different categories in this paper (paper), in (Johnson, 2001) with parser input (J1), in (Johnson, 2001) with perfect input (J2), and in (Campbell, 2004) with perfect input.
P04-1082
precision recall f-score this paper 86.9 86.3 86.6 Klein/Manning 86.3 85.1 85.7 Table 1: Labeled bracketing accuracy on section 23 Table 1 shows the labeled bracketing accuracy of the parser on the whole section 23 and compares it to the results reported in Klein and Manning (2003) for sentences with up to 100 words.
P03-1054
Klein and Manning (2003)) by replacing long infrequent rules with a set of binary rules.
P03-1054
Campbell (2004) reports a higher recall, but lower precision.
P04-1082
