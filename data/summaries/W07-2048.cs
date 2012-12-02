Such information is available in the Penn Treebank in the form of empty categories and secondary edges, it is however not available in the output of traditional constituent parsers, although there have been some attempts to apply a post-processing step to predict it, see Ahn et al.(2004), inter alia.
W04-0814
Comparison with previous best results: KM01 (Kudoh and Matsumoto, 2001), CM03 (Carreras and Marquez, 2003), SP03 (Sha and Pereira, 2003), ZDJ02 (Zhang et al., 2002).
P03-1004
Most of the features we designed are features that have become standard for the SRL task (Gildea and Jurafsky, 2002; Xue and Palmer, 2004; Carreras and M`arquez, 2004; Carreras and M`arquez, 2005).
W04-3212
Sabine Buchholz and Erwin Marsi. 2006. CoNLL-X shared task on multilingual dependency parsing. In Proceedings of CoNLL, pages 149164.
W06-2920
Such models have already been investigated in (Pradhan et al., 2003; Moschitti et al., 2005) and their description is hereafter reported.
P05-1072
For this reason, each preposition and verb was assigned a weight based on the proportion of occurrences of that word in the Penn Treebank (Marcus et al., 1993) which are labelled with a spatial meaning.
J93-2004
Finally, word similarity can be computed from structural features like head-modifier relationships (Grefenstette 1994b; Ruge 1992; Dagan, Marcus, and Markovitch 1993; Pereira, Tishby, and Lee 1993; Dagan, Pereira, and Lee 1994).
J93-2004
Tag sets for English are derived from the Penn Treebank (Marcus et al., 1993).
J93-2004
annotation For manual syntactic annotation of collected data (see Section 4), we followed the syntactic annotation conventions of the well-known Penn Treebank (Marcusetal., 1993).
J93-2004
In addition, while the system described here is based on pipelined classification, recent research on semantic role labeling has shown that significant performance improvements can be gained by exploiting interdependencies between arguments (Toutanova et al., 2005).
P05-1073
Mitchell P. Marcus, Beatrice Santorini, and Mary Ann Marcinkiewicz. 1993. Building a large annotated corpus of English: The Penn Treebank. Computational Linguistics, 19(2):313330.
J93-2004
Pradhan et al.(2005) used a rule-based dependency parser, but the results were significantly worse than when using a constituent parser.
P05-1072
Kudo et al.(2005) and Sudo et al.(2003) both used the rightmost extension algorithm to generate subtrees.
P03-1004
In recent years there have been many studies on text classification using general methods (Sebastiani, 2002; Yang and Liu, 1999) semi-structured texts (Kudo and Matsumoto, 2004), and XML classification (Zaki and Aggarwal, 2003).
P03-1004
We chose support vector machines3(SVMs) for our classifiers as they have shown good performance on a variety of natural language processing tasks (Kudo and Matsumoto, 2001; Pradhan et al., 2005).
P05-1072
The basic feature set of our parse selection model for Japanese is defined in the same way (corresponding to the PCFG-S model of Toutanova et al.(2005)): each feature capturing a sub-tree from the deriva27 # sample features 1 ?? rel-cl-sbj-gap hd-complement noun-le?? 1 ?? frag-np rel-cl-sbj-gap hd-complement noun-le?? 1 ??
P05-1073
Ahn et al.(2004) used a post-processing step to convert constituent trees into labeled dependency trees that were then used as input to a semantic role labeler.
W04-0814
S. Buchholz and E. Marsi. 2006. CoNLL-X Shared Task on Multilingual Dependency Parsing. In Proceedings of CoNLL, pages 149164.
W06-2920
These resemble the basic semantic features used by Toutanova et al.(2005). We further simplify these by collapsing some non-informative predicates, e.g. the unknown predicate used in fragments.
P05-1073
These properties have made this model suitable for extensions (Toutanova et al., 2002) and integration in a phrase-based model (Deng and Byrne, 2005) in the past.
P05-1073
31 Pioneering work by Toutanova et al.(2005) and Baldridge and Osborne (2007) on parse selection for an English HPSG treebank used simpler semantic features without sense information, and got a far less dramatic improvement when they combined syntactic and semantic information.
P05-1073
For the closely related purpose of parse selection over the English Redwoods treebank, Toutanova et al.(2005) train a discriminative loglinear model, using features defined over derivation trees with non-terminals representing the construction types and lexical types of the HPSG grammar.
P05-1073
Parsing with the Penn Treebank The last few years have seen an increasing interest in dependency parsing (Buchholz and Marsi, 2006) with significant improvements of the state of the art, and dependency treebanks are now available for a wide range of languages.
W06-2920
Though taggers based on dependency networks (Toutanova et al., 2003), SVM (Gimenez and M`arquez, 2003), MaxEnt (Ratnaparkhi, 1996), CRF (Smith et al., 2005), and other methods may reach slightly better results, their train/test cycle is orders of magnitude longer.
N03-1033 P05-1073
Penn treebank (PTB) (Marcus et al., 1993). We used
J93-2004
Among them, we select the following subset: (a) Phrase Type, Predicate Word, Head Word, 134 Position and Voice as defined in (Gildea and Jurafsky, 2002); (b) Partial Path, No Direction Path, Head Word POS, First and Last Word/POS in Constituent and SubCategorization as proposed in (Pradhan et al., 2003); and (c) Syntactic Frame as designed in (Xue and Palmer, 2004).
W04-3212
Penn Treebank (Marcus et al., 1993), using a stan-
J93-2004
M.P. Marcus, B. Santorini, and M. Marcinkiewicz. 1993. Building a Large Annotated Corpus of English: The Penn Treebank. ComputationalLinguistics, 19(2):313330.
J93-2004
This is essentially a simple version of the strategy mooted by Toutanova at el (2003) that the traditional order of NER and tagging be reversed.
N03-1033
This result exceeds Lafferty et al.'s accuracy of 95.73% using a CRF but falls short of Toutanova et al.(2003)'s state-of-the-art 97.24%.
N03-1033
Empirical evaluation has been done with the ERG on a small set of texts from the Wall Street Journal Section 22 of the Penn Treebank (Marcus et al., 1993).
J93-2004
(Buchholz and Marsi, 2006; Nivre et al., 2007).
W06-2920
the data sets, see Buchholz and Marsi (2006).
W06-2920
This dependency parser has been shown to have state-of-the-art accuracy in the CoNLL shared tasks on dependency parsing (Buchholz and Marsi, 2006; Nivre, 2007)3.
W06-2920
We trained the parser on the Penn Treebank (Marcus et al., 1993).
J93-2004
(Gildea and Jurafsky, 2002; Xue and Palmer, 2004; Pradhan et al., 2003).
W04-3212
The systems for the other languages follow the successful models devised for English, (Gildea and Jurafsky, 2002; 95 Xue and Palmer, 2004; Pradhan et al., 2003).
W04-3212
Although we have so far focused exclusively on English CHILDES data, dependency schemes based on functional relationships exist for a number of languages (Buchholz and Marsi, 2006), and the general parsing techniques used in the present work have been shown to be effective in several of them (Nivre et al., 2006).
W06-2920
Kudoh and Matsumoto (2001), Zhang and Johnson (2003)).
P03-1004
Recent work (Buchholz and Marsi, 2006; Nivre
W06-2920
Similarly to Xue and Palmer (2004), Argumentidentification FE Supp Cop Asp Exist Null Argument None Self_mover Path etc classification Figure 3: FE extraction steps.
W04-3212
In the semantic structure extraction system, we used the Stanford part-of-speech tagger (Toutanova etal., 2003) totag the training and test sentences and MaltParser, a statistical dependency parser (Nivre et al., 2006), to parse them.
N03-1033
We used YamCha (Kudo and Matsumoto, 2003) to detect named entities, and we trained it on the SemEval full-text training sets.
P03-1004
