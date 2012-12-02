Ngai and Yarowsky (2000) used an ensemble based on bagging and partitioning for active learning for base NP chunking.
P00-1016
Many IE and QA systems rely on the output of parsers (Kwok et al., 2001; Attardi et al., 2001; Moldovan et al., 2003).
N03-1022
These numbers were the only ones reported in (Yates et al., 2006).
W06-1604
Alexander Yates, Stefan Schoenmackers and Oren Etzioni, 2006.
W06-1604
Many algorithms for major NLP applications such as information extraction (IE) and question answering (QA) utilize the output of statistical parsers (see (Yates et al., 2006)).
W06-1604
Dan Moldovan, Christine Clark, Sanda Harabagiu and Steve Maiorano, 2003.
N03-1022
However, we did not perform a TREC experiment, as (Yates et al., 2006) did.
W06-1604
Henderson and Eric Brill, 2000.
A00-2005
Figure 1 demonstrates these phenomena for two leading models, Collins (1999) model 2, a generative model, and Charniak and Johnson (2005), a reranking model.
J05-1003 P05-1022
Surprisingly, as far as we know there is only one previous work explicitly addressing this problem (Yates et al., 2006).
W06-1604
Terry Koo and Michael Collins, 2005.
J05-1003
Reranking algorithms (Koo and Collins, 2005; Charniak and Johnson, 2005) search the list of best parses output by a generative parser to find a parse of higher quality than the parse selected by the generative parser.
J05-1003 P05-1022
We experiment with both the generative parsing model number 2 of Collins (1999) and the reranking parser of Charniak and Johnson (2005), both when the training and test data belong to the same domain (the in-domain scenario) and in the parser adaptation scenario.
J05-1003 P05-1022
Moreover, WSJ (or Brown) sentences that contain conjunctions were avoided in the experiments of (Yates et al., 2006).
W06-1604
Work The only previous work we are aware of that explicitly addressed the problem of detecting high quality parses in the output of statistical parsers is (Yates et al., 2006).
W06-1604
Grace Ngai and David Yarowsky, 2000.
P00-1016
Setup We performed experiments with two parsing models, the Collins (1999) generative model number 2 and the Charniak and Johnson (2005) reranking model.
J05-1003 P05-1022
The third, following (Yates et al., 2006), is maximum recall (MR).
W06-1604
Following 411 (Gildea, 2001), the Brown test and development sections consist of 10% of Brown sentences (the 9th and 10th of each 10 consecutive sentences in the development and test sections respectively).
W01-0521
As Table 3 shows, on a WSJ sec 23 test set similar to that used by (Yates et al., 2006), SEPA achieves 31% error reduction compared to 20% of WOODWARD.
W06-1604
Specifically in parsing, (Henderson and Brill, 2000) applied a constituent level voting scheme to an ensemble of bagged models to increase parser performance, and (Becker and Osborne, 2005) suggested an active learning technique in which the agreement among an ensemble of bagged parsers is used to predict examples valuable for human annotation.
A00-2005
The data is the WSJ sec 23 test set usd by (Yates et al., 2006).
W06-1604
The second measure is a generalization of the filter f-score measure suggested by Yates et al.(2006). They define filter precision as the ratio of correctly parsed sentences in the filtered set (the set the algorithm choose) to total sentences in the filtered set and filter recall as the ratio of correctly parsed sentences in the filtered set to correctly parsed sentences in the 2Recall that sentence f-score is defined as: f = 2×P×R P+R,where P and R are the labeled precision and recall of the constituents in the sentence relative to another parse.
W06-1604
Table 3 compares SEPA and WOODWARD on the exact same test set used by (Yates et al., 2006) (taken from WSJ sec 23).
W06-1604
Daniel Gildea, 2001.
W01-0521
Eugene Charniak and Mark Johnson, 2005.
P05-1022
