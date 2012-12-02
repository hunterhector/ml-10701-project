Our approach is similar to the recent work of (Meyers et al., 1998) where transfer rules are also derived after aligning the source and target nodes of corresponding parses.
P98-2139
We ran off-the-shelf parsers on each half of the corpus, namely the Korean parser developed by Yoon et al.(1997) and the English parser developed by Collins (1997).
P97-1003
The first difference concerns the content of parses and the resulting transfer rules; in (Meyers et al., 1998), parses contain only lexical labels and syntactic roles (as arc labels), while our approach uses parses containing lexical labels, syntactic roles, and any other syntactic information provided by parsers (tense, number, person, etc.).
P98-2139
The second difference concerns the node alignment; in (Meyers et al., 1998), the alignment of source and target nodes is designed in a way that preserves node dominancy in the source and target parses, while our approach does not have such restriction.
P98-2139
The fourth third difference is in the level of abstraction of transfer rules candidates; in (Meyers et al., 1998), the source and target patterns of each transfer rule are fully lexicalized (except possibly the terminal nodes), while in our approach the nodes of transfer rules do not have to be lexicalized.
P98-2139
The third difference is in the process of identification of transfer rules candidates; in (Meyers et al., 1998), the identification is done by using the exact tree fragments in the source and target parse that are delimited by the alignment, while we use all source and target tree sub-patterns matching a subset of the parse features that satisfy a customizable set of alignment constraints and attribute constraints.
P98-2139
We automatically converted the phrase structure output of the Collins parser into the syntactic dependency representation used by our syntactic realizer, RealPro (Lavoie and Rambow, 1997).
A97-1039
However, it also differs from (Meyers et al., 1998) in several important points.
P98-2139
One of the reasons for this difference is due to the different language pairs under study; (Meyers et al., 1998) deals with two languages that are closely related syntactically (Spanish and English) while we are dealing with languages that syntactically are quite divergent, Korean and English (Dorr, 1994).
J94-4004 P98-2139
We suggest that alignment constraints such as this one can be used to define most of the possible syntactic divergences between languages (Dorr, 1994), and that only a handful of them are necessary for two given languages (we have identified 11 general alignment constraints necessary for Korean to English transfer so far).
J94-4004
Our approach can be considered a generalization of syntactic approaches to example-based machine translation (EBMT) such as (Nagao, 1984; Sato and Nagao, 1990; Maruyama and Watanabe, 1992).
C90-3044
