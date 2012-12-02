The generative probabilities of case frames and case assignments are estimated from case frames themselvesinthesamewayas(KawaharaandKurohashi, 2006b).
N06-1023
In particular, Sassano added some features to improve his parser by enabling it to detect coordinate structures (Sassano, 2004).
C04-1002
The generative probability of a coordinate structure, P(relihi|fi), is deﬁned as follows: P(relihi|fi) = P(relihi|ki) (9) We classiﬁed coordination keys into 52 classes according to the classiﬁcation proposed by (Kurohashi and Nagao, 1994).
J94-4001
Kurohashi and Nagao proposed a Japanese parsing method that included coordinate structure detection (Kurohashi and Nagao, 1994).
J94-4001
We used two baseline systems for comparative purposes: the rule-based dependency parser, KNP (Kurohashi and Nagao, 1994), and the probabilistic model of syntactic and case structure analysis (Kawahara and Kurohashi, 2006b), in which coordination disambiguation is the same as that of KNP.
J94-4001 N06-1023
We plan to apply discriminative reranking to the n-best parsesproducedbyourgenerativemodelinthesame way as (Charniak and Johnson, 2005).
P05-1022
Kurohashi and Nagao proposed a similarity-based method to resolve both of the two tasks for Japanese (Kurohashi and Nagao, 1994).
J94-4001
A similarity value between two bunsetsus is calculated on the basis of POS matching, exact word matching, and their semantic closeness in a thesaurus tree (Kurohashi and Nagao, 1994).
J94-4001
Some examples of the case frames are listed in Table 1 (Kawahara and Kurohashi, 2006a).
N06-1023
The latter is the probability of generating function words including topic markers and punctuation marks, and is estimated using a syntactically annotated corpus in the same way as (Kawahara and Kurohashi, 2006b).
N06-1023
Charniak and Johnson used some features of syntactic parallelism in coordinate structures for their MaxEnt reranking parser (Charniak and Johnson, 2005).
P05-1022
We used KNP2 (Kurohashi and Nagao, 1994) as the parser and a web corpus consisting of 470M Japanese sentences (Kawahara and Kurohashi, 2006a).
J94-4001 N06-1023
Previous work on coordination disambiguation has focused on the task of addressing the scope ambiguity (e.g., (Agarwal and Boggess, 1992; Goldberg, 1999; Resnik, 1999; Chantree et al., 2005)).
P92-1003 P99-1081
syn syn+case syn+case+coord all 3,833/4,436 (86.4%) 3,852/4,436 (86.8%) 3,893/4,436 (87.8%) NB→PB 1,637/1,926 (85.0%) 1,664/1,926 (86.4%) 1,684/1,926 (87.4%) NB→NB 1,032/1,136 (90.8%) 1,029/1,136 (90.6%) 1,037/1,136 (91.3%) PB→PB 654/817 (80.0%) 647/817 (79.2%) 659/817 (80.7%) PB→NB 510/557 (91.6%) 512/557 (91.9%) 513/557 (92.1%) To compare our results with a state-of-the-art discriminative dependency parser, we input the same testcorpusintoanSVM-basedJapanesedependency parser, CaboCha6(Kudo and Matsumoto, 2002).
W02-2016
In this table, “syn” represents the rule-based dependency parser, KNP, “syn+case” represents the probabilistic parser of syntactic and case structure (Kawahara and Kurohashi, 2006b), and “syn+case+coord” represents our proposed model.
N06-1023
Dubey et al.proposed an unlexicalized PCFG parser that modiﬁed PCFG probabilities to condition the existence of syntactic parallelism (Dubey et al., 2006).
P06-1053
The integrated model is based on a fullylexicalized probabilistic model for Japanese syntactic and case structure analysis (Kawahara and Kurohashi, 2006b).
N06-1023
Goldberg applied a cooccurrence-based probabilistic model to determine the attachments of ambiguous coordinate phrases with the form “n1 p n2 cc n3” (Goldberg, 1999).
P99-1081
Among them, the best parsers are the SVM-based dependency analyzers (Kudo and Matsumoto, 2002; Sassano, 2004).
C04-1002 W02-2016
Agarwal and Boggess proposed a method for identifying coordinate conjuncts (Agarwal and Boggess, 1992).
P92-1003
Therefore, we use a method to calculate the similarity between two whole coordinate conjuncts (KurohashiandNagao, 1994).
J94-4001
