(Johnson, 1998).2 We observe that in the case of reverseproperness, precision and recall are slightly better.
J98-4004
The model by (Briscoe and Carroll, 1993) however incorporated a mistake involving lookahead, which was corrected by (Inui et al., 2000).
J93-1002
This was formally proven by (Nederhof and Satta, 2004), after (Ng and Tomita, 1991) and (Wright and Wrigley, 1991) had already suggested that creating a probabilistic LR parser that is equivalent to an input PCFG is difficult in general.
P04-1069
One important assumption that is made by (Briscoe and Carroll, 1993) and (Inui et al., 2000) is that trained probabilistic LR parsers should be proper, i.e. if several transitions are applicable for a given stack, then the sum of probabilities assigned to those transitions by probability function pA should be 1.
J93-1002
(Chi, 1999) and (Nederhof and Satta, 2003), properness for CFGs does not restrict the space of probability distributions, and thereby the same holds for reverse-properness for PDTs that implement the LR parsing strategy.
J99-1004
Such preprocessing of the WSJ corpus is consistent with earlier attempts to derive CFGs from that corpus, as e.g. by (Johnson, 1998).
J98-4004
The LR parsing strategy was originally devised for programming languages (Sippu and SoisalonSoininen, 1990), but has been used in a wide range of other areas as well, such as for natural language processing (Lavie and Tomita, 1993; Briscoe and Carroll, 1993; Ruland, 2000).
C00-2098 J93-1002
(See also (Nederhof and Satta, 2004)).
P04-1069
(Chitrao and Grishman, 1990; Johnson, 1998), who also demonstrated that this may significantly improve accuracy.
J98-2005 J98-4004
See (Nederhof and Satta, 2004) for a discussion of a property that is shared by left-corner parsing but not by LR parsing, and which explains the above difference.
P04-1069
The probability function can be obtained on the basis of a treebank, as proposed by (Briscoe and Carroll, 1993) (see also (Su et al., 1991)).
J93-1002
See also a related formulation of tabular LR parsing by (Nederhof and Satta, 1996).
P96-1032
This even holds if the input grammar is non-tight, meaning that probability mass is lost in ‘infinite derivations’ (S´anchez and Bened´ı, 1997; Chi and Geman, 1998; Chi, 1999; Nederhof and Satta, 2003).
J98-2005 J99-1004
(Back-off for probabilistic LR parsing has been proposed by (Ruland, 2000)).
C00-2098
