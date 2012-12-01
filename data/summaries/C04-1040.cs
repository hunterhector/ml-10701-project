Here, we extract part-of-speech tags from the Collins parser’s output (Collins, 1997) for section 23 instead of reinventing a tagger.
P97-1003
According to the document, it is the output of Ratnaparkhi’s tagger (Ratnaparkhi, 1996).
W96-0213
Eisner (1996) proposed probabilistic models of dependency parsing.
C96-1058
It is also studied by other researchers (Sleator and Temperley, 1991; Hockenmaier and Steedman, 2002).
P02-1043
However, the accuracy of Yamada’s analyzer is lower than state-of-the-art phrase structure parsers such as Charniak’s Maximum-Entropy-Inspired Parser (MEIP) (Charniak, 2000) and Collins’ Model 3 parser.
A00-2018
Collins and Duffy (2002) improved Collins’ Model 2 parser by reranking possible parse trees.
P02-1034
Figure 1: A word dependency tree ferent tasks of Natural Language Processing (Kudo and Matsumoto, 2001; Isozaki and Kazawa, 2002).
C02-1054 N01-1025 W02-2016
A base NP chunker: We implemented an SVM-based base NP chunker, which is a simplified version of Kudo’s method (Kudo and Matsumoto, 2001).
N01-1025
Dependency Analyzer PP-Attachment Resolver Root-Node Finder Base NP Chunker (POS Tagger) = SVM, = Preference Learning Figure 2: Module layers in the system That is, we use Penn Treebank’s Wall Street Journal data (Marcus et al., 1993).
J93-2004
(Since we used Isozaki’s methods (Isozaki and Kazawa, 2002), the run-time complexity is not a problem.) Kudo and Matsumoto (2002) proposed an SVMbased Dependency Analyzer for Japanese sentences.
C02-1054 W02-2016
Shen and Joshi (2003) also used the preference kernel K(xi: ; xj: ) for reranking.
W03-0402
(Suzuki et al., 2003; Sudo et al., 2003) Recently, Yamada and Matsumoto (2003) proposed a trainable English word dependency analyzer based on Support Vector Machines (SVM).
P03-1005 P03-1029
