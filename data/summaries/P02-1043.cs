We therefore ran the dependency model on a test corpus tagged with the POS-tagger of Ratnaparkhi (1996), which is trained on the original Penn Treebank (see HWDep (+ tagger) in Table 3).
W96-0213
The following table compares the two parsers according to the evaluation of surface and deep dependencies given in Clark et al.(2002). We use Clark et al.’s parser to generate these dependencies from the output of our parser (see Clark and Hockenmaier (2002)) 4 . LP LR UP UR Clark 81.9% 81.8% 89.1% 90.1% Hockenmaier 83.7% 84.2% 90.5% 91.1% 6 Performance on specific constructions One of the advantages of CCG is that it provides a simple, surface grammatical analysis of extraction and coordination.
P02-1042
We present a number of models over syntactic derivations of Combinatory Categorial Grammar (CCG, see Steedman (2000) and Clark et al.(2002), this conference, for introduction), estimated from and tested on a translation of the Penn Treebank to a corpus of CCG normal-form derivations.
P02-1042
For further discussion we refer the reader to Clark and Hockenmaier (2002) . 3 CCGbank—a CCG treebank CCGbank is a corpus of CCG normal-form derivations obtained by translating the Penn Treebank trees using an algorithm described by Hockenmaier and Steedman (2002).
P02-1042
to the smaller grammar and lexicon of Clark et al., our parser can only be evaluated on slightly over 94% of the sentences in section 23, whereas the figures for Clark et al.(2002) are on 97%.
P02-1042
The impact of the grandparent feature Johnson (1998) showed that a PCFG estimated from a version of the Penn Treebank in which the label of a node’s parent is attached to the node’s own label yields a substantial improvement (LP/LR: from 73.5%/69.7% to 80.0%/79.2%).
J98-4004
As is well known (Abney, 1997), DAG-like dependencies cannot in general be modeled with a generative approach of the kind taken here 3 . 5.6 Comparison with Clark et al.(2002) Clark et al.(2002) presents another statistical CCG parser, which is based on a conditional (rather than generative) model of the derived dependency structure, including non-surface dependencies.
J97-4005 P02-1042
lexical information Gildea (2001) shows that removing the lexical dependencies in Model 1 of Collins (1997) (that is, not conditioning on w h when generating w s )decreases labeled precision and recall by only 0.5%.
P97-1003 W01-0521
In order to compare our performance with the parser of Clark et al.(2002), we also evaluate our best model according to the dependency evaluation introduced for that parser.
P02-1042
Distance measures for CCG Our distance measures are related to those proposed by Goodman (1997), which are appropriate for binary trees (unlike those of Collins (1997)).
P97-1003
of the current model Unlike Clark et al.(2002), our parser does not always model the dependencies in the logical form.
P02-1042
Like the models of Goodman (1997), the additional features in our model are generated probabilistically, whereas in the parser of Collins (1997) distance measures are assumed to be a function of the already generated structure and are not generated explicitly.
P97-1003
In contrast to Gildea (2001), we find a significant improvement from modeling wordword dependencies.
W01-0521
