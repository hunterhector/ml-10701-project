A. Ratnaparkhi, 1996.
W96-0213
Unlexicalized parsers, on the other hand, achieved accuracies almost equivalent to those of lexicalized parsers (Klein and Manning, 2003; Matsuzaki et al., 2005; Petrov et al., 2006).
P05-1010 P06-1055
J. Nivre, J. Hall, S. Kubler, R. McDonald, J. Nilsson, S. Riedel, and D. Yuret. 2007. The CoNLL 2007 Shared Task on Dependency Parsing. In Proceedings of EMNLP-CoNLL 2007, pages 915932.
D07-1096
T. Koo and M. Collins. 2005. Hidden-Variable Models for Discriminative Reranking. In Proceedings of HLTEMNLP, pages 507514.
H05-1064
McDonald et al.proposed an online large-margin method for training dependency parsers (McDonald et al., 2005).
H05-1066 P05-1012
R. McDonald, K. Crammer, and F. Pereira. 2005a. Online Large-Margin Training of Dependency Parsers. In Proceedings of ACL, pages 9198.
H05-1066 P05-1012
M. Collins, J. Hajic, L. Ramshaw, and C. Tillmann. 1999 A Statistical Parser for Czech. In Proceedings of ACL pages 505512.
P99-1065
tron (Freund and Schapire, 1999; Collins, 2002),
W02-1001
P.F. Brown, V.J. Della Pietra, P.V. deSouza, J.C. Lai, and R.L. Mercer. 1992. Class-Based n-gram Models of Natural Language. Computational Linguistics,
J92-4003
Donald et al., 2005a; McDonald and Pereira, 2006).
E06-1011
2005a; McDonald and Pereira, 2006).
E06-1011
We then describe our port of the Collins (1999) parser to Chinese.
P99-1065
the success of Miller et al. (2004), who demon-
N04-1043
Wang et al. (2005) used distributional similarity
W05-1516
by Miller et al. (2004), in the context of named-
N04-1043
Similarly, Miller et al.(2004) used word-cluster memberships induced from an unannotated corpus as features for named entity chunking.
N04-1043
J. Nivre and J. Nilsson. 2005. Pseudo-Projective Dependency Parsing. In Proceedings of ACL, pages 99106.
P05-1013
Finally, word similarity can be computed from structural features like head-modifier relationships (Grefenstette 1994b; Ruge 1992; Dagan, Marcus, and Markovitch 1993; Pereira, Tishby, and Lee 1993; Dagan, Pereira, and Lee 1994).
J93-2004
corporate hidden variables (Matsuzaki et al., 2005;
P05-1010
(Brown et al., 1992). We chose to work with the
J92-4003
Though taggers based on dependency networks (Toutanova et al., 2003), SVM (Gimenez and M`arquez, 2003), MaxEnt (Ratnaparkhi, 1996), CRF (Smith et al., 2005), and other methods may reach slightly better results, their train/test cycle is orders of magnitude longer.
W96-0213
M. Collins. 2002. Discriminative Training Methods for Hidden Markov Models: Theory and Experiments with Perceptron Algorithms. In Proceedings of EMNLP, pages 18.
W02-1001
parser, the Collins (1999) parser, ported to Chinese.
P99-1065
splitting tags (Matsuzaki et al., 2005; Petrov et al., 2006).
P05-1010 P06-1055
Yarowsky (1995), Collins and Singer (1999), Riloff and Jones (1999)).
P99-1065
Koo and Collins, 2005; Petrov et al., 2006; Titov
H05-1064 P06-1055
cess in other NLP applications (Miller et al., 2004;
N04-1043
X. Carreras. 2007. Experiments with a Higher-Order Projective Dependency Parser. In Proceedings of EMNLP-CoNLL, pages 957961.
D07-1101
Since Miller et al.(2004)'s experiments used a proprietary corpus, direct performance comparison is not possible.
N04-1043
In contrast, methods based on Maximum Entropy (Ratnaparkhi, 1996), Conditional Random Field (Shrivastav, 2006) etc.
W96-0213
McDonaldandPereira(2006) 85.2
E06-1011
(Carreras, 2007) factorizations, and labeled or unla-
D07-1101
In the algorithm, parsing states are represented by triples ?S,I,A?? where S is the stack that keeps the words being under consideration, I is the list of reDA RA CR (Yamada and Matsumoto, 2003) 90.3 91.6 38.4 (Nivre and Scholz, 2004) 87.3 84.3 30.4 (Isozaki et al., 2004) 91.2 95.7 40.7 (McDonald et al., 2005) 90.9 94.2 37.5 (McDonald and Pereira, 2006) 91.5 N/A 42.1 (Corston-Oliver et al., 2006) 90.8 93.7 37.6 Our Base Parser 90.9 92.6 39.2 Table 2: Comparison of parser performance.
E06-1011 H05-1066 P05-1012 P05-1013
Another body of related work is the literature on word clustering in computational linguistics (Brown et al.1992; Finch 1993; Pereira, Tishby, and Lee 1993; Grefenstette 1994a) and document clustering in information retrieval (van Rijsbergen 1979; Willett 1988; Sparck-Jones 1991; Cutting et al.1992). In contrast to this earlier work, we cluster contexts or, equivalently, word tokens here, not words (or, more precisely, word types) or documents.
J92-4003
M.P. Marcus, B. Santorini, and M. Marcinkiewicz. 1993. Building a Large Annotated Corpus of English: The Penn Treebank. ComputationalLinguistics, 19(2):313330.
J93-2004
10Following Collins et al. (1999), we used a coarsened ver-
P99-1065
S. Miller, J. Guinness, and A. Zamanian. 2004. Name Tagging with Word Clusters and Discriminative Training. In Proceedings of HLT-NAACL, pages 337342.
N04-1043
algorithm similar to that of McClosky et al. (2006).
N06-1020
S. Petrov, L. Barrett, R. Thibaux, and D. Klein. 2006. Learning Accurate, Compact, and Interpretable Tree Annotation. In Proceedings of COLING-ACL, pages 433440.
P06-1055
It is interesting to note that the inclusion of prefix and suffix for all words gives better result instead of using only for rare words as is described in Ratnaparkhi (1996).
W96-0213
McDonaldetal.(2005b) 84.4
H05-1066 P05-1012
I. Titov and J. Henderson. 2007. Constituent Parsing with Incremental Sigmoid Belief Networks. In Proceedings of ACL, pages 632639.
P07-1080
Many of these features required creating an automatic parse; in doing so we showed that the Collins (1999) parser when ported to Chinese achieved the best reported performance on Chinese syntactic parsing.
P99-1065
feature set of McDonald et al. (2005a), and consists
H05-1066 P05-1012
Collins parser for Chinese The Collins parser is a state-of-the-art statistical parser that has high performance on English (Collins, 1999) and Czech(Collins et al.1999). There have been attempts in applying other algorithms in Chinese parsing (Bikel and Chiang, 2000; Chiang and Bikel 2002; Levy and Manning 2003), but there has been no report on applying the Collins parser on Chinese.
P99-1065
Penn Treebank (Marcus et al., 1993), using a stan-
J93-2004
In recent years, many accurate phrase-structure parsers have been developed (e.g., (Collins, 1999; Charniak, 2000)).
P99-1065
1We augment the McDonald et al. (2005a) feature set with
H05-1066 P05-1012
the conditions of previous work (McDonald et al., 2005b; Mc-
H05-1066 P05-1012
(Buchholz and Marsi, 2006; Nivre et al., 2007).
D07-1096
D. McClosky, E. Charniak, and M. Johnson. 2006. Effective Self-Training for Parsing. In Proceedings of HLT-NAACL, pages 152159.
N06-1020
ing experiments, we used the Carreras (2007) parser.
D07-1101
A. Ratnaparkhi. 1996. A Maximum Entropy Model for Part-Of-Speech Tagging. In Proceedings of EMNLP, pages 133142.
W96-0213
et al., 2005a; Carreras, 2007), so we will not attempt
D07-1101
T. Matsuzaki, Y. Miyao, and J. Tsujii. 2005. Probabilistic CFG with Latent Annotations. In Proceedings of ACL, pages 7582.
P05-1010
Dependency parsing has been actively studied in recent years (Yamada and Matsumoto, 2003; Nivre and Scholz, 2004; Isozaki et al., 2004; McDonald et al., 2005; McDonald and Pereira, 2006; Corston-Oliver et al., 2006).
E06-1011 H05-1066 P05-1012 P05-1013
R. McDonald and F. Pereira. 2006. Online Learning of Approximate Dependency Parsing Algorithms. In Proceedings of EACL, pages 8188.
E06-1011
McDonald and Pereira, 2006; Carreras, 2007).
D07-1101 E06-1011
NivreandNilsson(2005) 80.1
P05-1013
isons with previous work (McDonald et al., 2005b;
H05-1066 P05-1012
and . in Figure 1. The Carreras (2007) parser
D07-1101
overcome this, McDonald and Pereira (2006) use a
E06-1011
clusters. Following Miller et al. (2004), we use pre-
N04-1043
sensitivity (Eisner, 2000; McDonald et al., 2005b;
H05-1066 P05-1012
been previously explored by McClosky et al. (2006),
N06-1020
monds, 1967; McDonald et al., 2005b) as our first-
H05-1066 P05-1012
those of Carreras (2007) and include indicators for
D07-1101
3As in Brown et al. (1992), we limit the clustering algorithm
J92-4003
Q.I. Wang, D. Schuurmans, and D. Lin. 2005. Strictly Lexical Dependency Parsing. In Proceedings of IWPT, pages 152159.
W05-1516
lengths used in the Miller et al. (2004) work (be-
N04-1043
Donald et al. (2005a); MD2 = McDonald and Pereira (2006); suffix -L = labeled parser. Unlabeled parsers are scored
E06-1011
R. McDonald, F. Pereira, K. Ribarov, and J. Hajic. 2005b. Non-Projective Dependency Parsing using Spanning Tree Algorithms. In Proceedings of HLT-EMNLP, pages 523530.
H05-1066 P05-1012
McDonald and Pereira (2006) defines parts for sib-
E06-1011
McDonald and Pereira, 2006), we used the train-
E06-1011
HallandNovak(2005) 85.1
W05-1505
K. Hall and V. Novak. 2005. Corrective Modeling for Non-Projective Dependency Parsing. In Proceedings of IWPT, pages 4252.
W05-1505
