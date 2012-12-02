The algorithm of (Cahill et al., 2004b) translates the traces into corresponding re-entrancies in the f-structure representation (Figure 1).
P04-1041
(Manning, 1993) observes that Brent’s recognition technique is a “rather simplistic and inadequate approach to verb detection, with a very high error rate”.
P93-1032
It is a well-documented fact (Briscoe and Carroll, 1997) that subcategorisation frames (and their frequencies) vary across domains.
A97-1052
In the case of (Xia et al., 2000), invalid elementary trees produced as a result of annotation errors in the treebank are filtered out using linguistic heuristics.
W00-1307
(Briscoe and Carroll, 1997) observe that in the work of (Brent, 1993), (Manning, 1993) and (Ushioda et al., 1993), “the maximum number of distinct subcategorization classes recognized is sixteen, and only Ushioda et al.attempt to derive relative subcategorization frequency for individual predicates”.
A97-1052 J93-2002 P93-1032 W93-0109
In contrast, the system of (Briscoe and Carroll, 1997) distinguishes 163 verbal subcategorisation classes by means of a statistical shallow parser, a classifier of subcategorisation classes, and a priori estimates of the probability that any verb will be a member of those classes.
A97-1052
In order to examine the coverage of the extracted lexicon in a manner similar to (Xia et al., 2000), (Hockenmaier et al., 2002) compared the reference lexicon acquired from Sections 02-21 with a test lexicon extracted from Section 23 of the WSJ.
W00-1307
(Xia et al., 2000) and (Chen and Vijay-Shanker, 2000) extract lexicalised TAGs from the Penn Treebank.
W00-1307
Our approach is based on earlier work on LFG semantic form extraction (van Genabith et al., 1999) and recent progress in automatically annotating the Penn-II treebank with LFG f-structures (Cahill et al., 2004b).
P04-1041
Both techniques implement variations on the approaches of (Magerman, 1994) and (Collins, 1997) for the purpose of differentiating between complement and adjunct.
P97-1003
(Ushioda et al., 1993) run a finite state NP parser on a POS-tagged corpus to calculate the relative frequency of just six subcategorisation verb classes.
W93-0109
Brent. 1993.
J93-2002
(Cahill et al., 2004b) provide four sets of annotation principles, one for non-coordinate configurations, one for coordinate configurations, one for traces (long distance dependencies) and a final ‘catch all and clean up’ phase.
P04-1041
We are already using the extracted semantic forms in parsing new text with robust, wide-coverage PCFG-based LFG grammar approximations automatically acquired from the f-structure annotated Penn-II treebank (Cahill et al., 2004a).
P04-1041
(Charniak, 1996) and (Krotov et al., 1998) observed that treebank grammars (CFGs extracted from treebanks) are very large and grow with the size of the treebank.
P98-1115
In this paper we show how the extraction process can be scaled to the complete Wall Street Journal (WSJ) section of the Penn-II treebank, with about 1 million words in 50,000 sentences, based on the automatic LFG f-structure annotation algorithm described in (Cahill et al., 2004b).
P04-1041
(Cahill et al., 2004b) measure annotation quality in terms of precision and recall against manually constructed, gold-standard f-structures for 105 randomly selected trees from section 23 of the WSJ section of Penn-II.
P04-1041
We utilise the automatic annotation algorithm of (Cahill et al., 2004b) to derive a version of Penn-II where each node in each tree is annotated with an LFG functional annotation (i.e.
P04-1041
(Brent, 1993) relies on local morphosyntactic cues (such as the -ing suffix, except where such a word follows a determiner or a preposition other than to) in the untagged Brown Corpus as probabilistic indicators of six different predefined subcategorisation frames.
J93-2002
