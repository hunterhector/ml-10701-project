More recent work has attempted to group verbs into classes based on alternations, usually taking Levin’s classes as a gold standard (McCarthy 2000; Merlo and Stevenson 2001; Schulte im Walde 2000; Schulte im Walde and Brew 2002).
A00-2034 J01-3003
Table 8 shows the PropBank semantic role labels for thesubjectsofeachverbineachclass.MerloandStevenson(2001)aimto automatically classify verbs into one of three categories: unergative, unaccusative, and object-drop.
J01-3003
Gildea and Jurafsky (2002) describe a statistical system trained on the data from the FrameNet project to automatically assign semantic roles.
J02-3001 P02-1031
We begin the annotation process by running a rule-based argument tagger (Palmer, Rosenzweig, and Cotton 2001) on the corpus.
H01-1010
This indicates that systems capable of recovering traces (Johnson 2002; Dienes and Dubey 2003) could improve semantic-role labeling.
P02-1018 W03-1005
Most recently, the Gildea and Palmer (2002) scores presented here have been improved markedly through the use of support-vector machines as well as additional features for named entity tags, headword POS tags, and verb clusters for back-off (Pradhan et al.2003) and using maximum-entropy classifiers (He and Gildea 2004, Xue and Palmer 2004).
J02-3001 P02-1031 W04-2807 W04-3212
Our experiments working with a flat, ‘‘chunked’’ representation of the input sentence, described in more detail in Gildea and Palmer (2002), test this finite-state hypothesis.
J02-3001 P02-1031
As a guideline for interpreting these results, with 8,167 observations, the threshold for statistical significance with p < .05 is a 1.0% absolute difference in performance (Gildea and Jurafsky 2002).
J02-3001 P02-1031
Participants in the 2004 CoNLL semantic-labeling shared task (Carreras and Ma`rquez 2004) have reported higher results for chunk-based systems, but to date chunk-based systems have not closed the gap with the state-of-the-art results based on parser output.
W04-2412
It is interesting to note that the semantic frames are a helpful way of generalizing between predicates; words in the same frame have been found frequently to share the same syntactic argument structure (Gildea and Jurafsky 2002).
J02-3001 P02-1031
Next, the probabilities Pðr i j F i,pÞ are combined with the probabilities Pðfr 1 :::n gjpÞ for a set of roles appearing in a sentence given a predicate, using the following formula: Pðr 1 :::n jF 1 :::n, pÞ, Pðfr 1 :::n gjpÞ Y i Pðr i jF i,pÞ Pðr i jpÞ This approach, described in more detail in Gildea and Jurafsky (2002), allows interaction among the role assignments for individual constituents while making certain independence assumptions necessary for efficient probability estimation.
J02-3001 P02-1031
A more complete description of the FrameNet project can be found in Baker, Fillmore, and Lowe (1998) and Johnson et al.(2002), and the ramifications for automatic classification are discussed more thoroughly in Gildea and Jurafsky (2002).
J02-3001 P02-1018 P02-1031 P98-1013
While learning syntactic subcategorization frames from corpora has been shown to be possible with reasonable accuracy (Manning 1993; Brent 1993; Briscoe and Carroll 1997), this work does not address the semantic roles associated with the syntactic arguments.
A97-1052 J93-2002 P93-1032
We base this analysis on previous work by Merlo and Stevenson (2001).
J01-3003
Roles Total Four most common syntactic positions (%) Other positions (%) Arg1 35,112 Obj 51.7 S 21.9 Subj 17.9 NP 5.2 3.4 Arg0 30,459 Subj 96.9 NP 2.4 S 0.2 Obj 0.2 0.2 Arg2 7,433 NP 35.7 Obj 28.6 Subj 12.1 S 10.2 13.4 TMP 6,846 ADVP 26.2 PP-in 16.2 Obj 14.6 SBAR 11.9 31.1 MOD 4,102 MD 98.9 ADVP 0.8 NN 0.1 RB 0.0 0.1 ADV 3,137 SBAR 30.6 S 27.4 ADVP 19.4 PP-in 3.1 19.5 LOC 2,469 PP-in 59.1 PP-on 10.0 PP-at 9.2 ADVP 6.4 15.4 MNR 2,429 ADVP 54.2 PP-by 9.6 PP-with 7.8 PP-in 5.9 22.5 Arg3 1,762 NP 56.7 Obj 9.7 Subj 8.9 ADJP 7.8 16.9 DIS 1,689 ADVP 69.3 CC 10.6 PP-in 6.2 PP-for 5.4 8.5 Table 8 Semantic roles of verbs’ subjects, for the verb classes of Merlo and Stevenson (2001).
J01-3003
The parser, described in detail in Hockenmaier and Steedman (2002), is trained on a version of the Penn Treebank automatically converted to CCG representations.
P02-1043
One of the systems evaluated for the Message Understanding Conference task (Miller et al.1998) made use of an integrated syntactic and semantic model producing a full parse tree and achieved results comparable to other systems that did not make use of a complete parse.
M98-1009
Gildea and Hockenmaier (2003) present a system for labeling PropBank’s semantic roles based on a statistical parser for combinatory categorial grammar (CCG) (Steedman 2000).
W03-1008
Using the CCGbased parser, Gildea and Hockenmaier (2003) find a 2% absolute improvement over the Collins parser in identifying core or numbered PropBank arguments.
W03-1008
In many cases, the additional information that VerbNet provides for each class has caused it to subdivide, or use intersections of, Levin’s original classes, adding an additional level to the hierarchy (Dang et al.1998). We are also extending the coverage by adding new classes (Korhonen and Briscoe 2004).
P98-1046 W04-2606
Chen and Rambow (2003) make use of extracted tree-adjoining grammars.
W03-1006
Over the past decade, most work in the field of information extraction has shifted from complex rule-based systems designed to handle a wide variety of semantic phenomena, including quantification, anaphora, aspect, and modality (e.g., Alshawi 1992), to more robust finite-state or statistical systems (Hobbs et al.1997; Miller et al.1998). These newer systems rely on a shallower level of semantic representation, similar to the level we adopt for the Proposition Bank, but have also tended to be very domain specific.
M98-1009
In our first set of experiments, the features and probability model of the Gildea and Jurafsky (2002) system were applied to the PropBank corpus.
J02-3001 P02-1031
Researchers were able to construct a reasonable IE system by simply mapping specific Arg labels for a set of verbs to template slots, completely avoiding the necessity of building explicit regular expression pattern matchers (Surdeanu et al.2003). There is equal hope for advantages for machine translation, and proposition banks in Chinese (Xue and Palmer 2003) and Korean are already being built, focusing where possible on parallel data.
P03-1002 W03-1707
(wsj_2300) Our chunks were derived from the treebank trees using the conversion described by Tjong Kim Sang and Buchholz (2000).
W00-0726
FrameNet and PropBank The PropBank project and the FrameNet project at the International Computer Science Institute (Baker, Fillmore, and Lowe 1998) share the goal of documenting the syntactic realization of arguments of the predicates of the general English lexicon by annotating a corpus with semantic roles.
P98-1013
1. Introduction Robust syntactic parsers, made possible by new statistical techniques (Ratnaparkhi 1997; Collins 1999, 2000; Bangalore and Joshi 1999; Charniak 2000) and by the availability of large, hand-annotated training corpora (Marcus, Santorini, and Marcinkiewicz 1993; Abeille´ 2003), have had a major impact on the field of natural language processing in recent years.
A00-2018 J93-2004 J99-2004 W97-0301
2 (For other extensions of Levin, see also Dorr and Jones [2000] and Korhonen, Krymolowsky, and Marx [2003]).
P03-1009
Each grouping in turn corresponds to several WordNet 1.7 senses (Palmer, Babko-Malaya, and Dang 2004).
W04-2704 W04-2807
