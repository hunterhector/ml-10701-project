As evaluation measure, we used a pair-wise measure which calculates precision, recall and a harmonic fscore as follows: Each verb pair in the cluster analysis was compared to the verb pairs in the gold standard classes, and evaluated as true or false positive (Hatzivassiloglou and McKeown, 1993).
P93-1023
There are various possibilities to determine corpus-based features that potentially cover the associations; we decided in favour of feature types which have been suggested in related work: a) Grammar-based relations: Previous work on distributional similarity has focused either on a speci c word-word relation (such as Pereira et al.(1993) and Rooth et al.(1999) referring to a direct object noun for describing verbs), or used any syntactic relationship detected by a chunker or a parser (such as Lin (1998) and McCarthy et al.(2003)). We used a statistical grammar (Schulte im Walde, 2003) to lter all verb-noun pairs where the nouns represent nominal heads in NPs or PPs in syntactic relation to the verb (subject, object, adverbial function, etc.), and to lter all verb-adverb pairs where the adverbs modify the verbs.
P93-1024 P98-2127 P99-1014 W03-1810
In larger-scale classi cations such as (Korhonen et al., 2003; Stevenson and Joanis, 2003; Schulte im Walde, 2003), which model verb classes with similarity at the syntax-semantics interface, it is not clear which features are the most salient.
E03-1040 P03-1009 W03-0410
were considered as verb features, such as Lin (1998) and McCarthy et al.(2003). Of the adverb associations, we nd only a small proportion among the parsed adverbs.
P98-2127 W03-1810
(Stevenson and Joanis, 2003; Korhonen et al., 2003).4 Accuracy is determined in two steps: 4Note that we can use accuracy for the evaluation because we have a xed cut in the hierarchy as based on the gold standard, as opposed to the evaluation in Section 3 where we explored the optimal cut level.
E03-1040 P03-1009 W03-0410
GermaNet as the German WordNet (Kunze, 2000), and the German counterpart of FrameNet in the Salsa project (Erk et al., 2003).
P03-1068
This insight con rms the assumption in previous work where only direct object nouns were used as salient features in distributional verb similarity, such as Pereira et al.(1993). However, the proportions are all below 10%.
P93-1024
(Merlo and Stevenson, 2001; Joanis and Stevenson, 2003; Korhonen et al., 2003; Stevenson and Joanis, 2003; Schulte im Walde, 2003; Ferrer, 2004).
E03-1040 J01-3003 P03-1009 P04-2007 W03-0410
For example, Merlo and Stevenson (2001) classify 60 English verbs which alternate between an intransitive and a transitive usage, and assign them to three verb classes, according to the semantic role assignment in the frames; their verb features are chosen such that they model the syntactic frame alternation proportions and also heuristics for semantic role assignment.
J01-3003
