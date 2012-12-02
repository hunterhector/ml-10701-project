J. Nivre, J. Hall, S. Kubler, R. McDonald, J. Nilsson, S. Riedel, and D. Yuret. 2007. The CoNLL 2007 Shared Task on Dependency Parsing. In Proceedings of EMNLP-CoNLL 2007, pages 915932.
D07-1096
Ryan McDonald and Joakim Nivre. 2007. Characterizing the errors of data-driven dependency parsing mod-els. In Proceedings of EMNLP-CoNLL, pages 122131.
D07-1096
Although the CHILDES annotation scheme proposed by Sagae et al.(2004) has been used in practice for automatic parsing of child language transcripts (Sagae et al., 2004; Sagae et al., 2005), such work relied mainly on a statistical parser (Charniak, 2000) trained on the Wall Street Journal portion of the Penn Treebank, since a large enough corpus of annotated CHILDES data was not available to train a domain-specific parser.
A00-2018 P05-1025
Syntactic analysis of child language transcripts using a GR scheme of this kind has already been shown to be effective in a practical setting, namely in automatic measurement of syntactic development in children (Sagae et al., 2005).
P05-1025
This parsing approach is very similar to the one used successfully by Nivre et al.(2006), but we use a maximum entropy classifier (Berger et al., 1996) to determine parser actions, which makes parsing extremely fast.
J96-1002 W06-2933
based (McDonald and Nivre, 2007). In graph-based
D07-1096
Sabine Buchholz and Erwin Marsi. 2006. CoNLL-X shared task on multilingual dependency parsing. In Proceedings of CoNLL, pages 149164.
W06-2920
this work is that presented by Nivre et al. (2006),
W06-2933
The algorithm is essentially a dependency version of the data-driven constituent parsing algorithm for probabilistic GLR-like parsing described by Sagae and Lavie (2006).
P06-2089
trend (McDonald and Nivre, 2007). Considering
D07-1096
sults of McDonald and Nivre (2007). Secondly, both
D07-1096
Johan Hall, Jens Nilsson, Joakim Nivre, Gulsen EryigitBeata Megyesi, Mattias Nilsson, and Markus Saers. 2007. Single malt or blended? A study in multilingual parser optimization. In Proceedings of EMNLP-CoNLL.
D07-1096
Joakim Nivre, Johan Hall, Sandra Kubler, Ryan McDoald, Jens Nilsson, Sebastian Riedel, and Deniz Yuret. 2007. The CoNLL 2007 shared task on dependency parsing. In Proceedings of EMNLP-CoNLL, pages 915932.
D07-1096
Following recent work on dependency parsing (Nivre, 2007), we report two evaluation measures: labeled accuracy score (LAS) and unlabeled accuracy score (UAS).
D07-1096
Eugene Charniak. 2000. A maximum-entropy-inspired parser. In Proceedings of NAACL, pages 132139.
A00-2018
See Sagae and Tsujii (2007) for more information on the parser.
D07-1111
Despite the obvious disadvantage of using a parser trained on a completely different language genre, Sagae et al.(2005) demonstrated how current natural language processing techniques can be used effectively in child language work, achieving results that are close to those obtained by manual computation of syntactic development scores for child transcripts.
P05-1025
Kenji Sagae and Alon Lavie. 2006. Parser combination byreparsing. InProceedingsofNAACL:ShortPapers, pages 129132.
P06-2089
Generally, the syntactic structure of a sentence is represented as a tree, and parsing is carried out by maximizing the likelihood of the tree (Charniak, 2000; Uchimoto et al., 1999).
A00-2018
In recent years, many accurate phrase-structure parsers have been developed (e.g., (Collins, 1999; Charniak, 2000)).
A00-2018
the data sets, see Buchholz and Marsi (2006).
W06-2920
S. Buchholz and E. Marsi. 2006. CoNLL-X Shared Task on Multilingual Dependency Parsing. In Proceedings of CoNLL, pages 149164.
W06-2920
studyofMcDonaldandNivre(2007), whichshowed
D07-1096
edu/data/Eng-USA/brown.zip. It was used for the Domain adaptation task at the CoNLL-2007 dependency parsing shared task (Nivre, 2007).
D07-1096
Nivre (2007) showed that a detailed error analysis
D07-1096
References A.Berger, S.A.DellaPietra, andV.J.DellaPietra. 1996.
J96-1002
Sagae and Tsujii (2007) present a detailed description of the parsing approach used in our work, including the parsing algorithm.
D07-1111
model MaltParser is described in Nivre et al. (2006).
W06-2933
(Buchholz and Marsi, 2006; Nivre et al., 2007).
D07-1096 W06-2920
This dependency parser has been shown to have state-of-the-art accuracy in the CoNLL shared tasks on dependency parsing (Buchholz and Marsi, 2006; Nivre, 2007)3.
D07-1096 W06-2920
nouns and pronouns (McDonald and Nivre, 2007).
D07-1096
That work relied on a phrase-structure statistical parser (Charniak, 2000) trained on the Penn Treebank, and the output of that parser had to be converted into CHILDES grammatical relations.
A00-2018
Joakim Nivre, Johan Hall, Jens Nilsson, Gulsen Eryigitand Svetoslav Marinov. 2006. Labeled pseudo-projective dependency parsing with support vector machines. In Proceedings of CoNLL, pages 221225.
W06-2933
Dependency parsing has been actively studied in recent years (Yamada and Matsumoto, 2003; Nivre and Scholz, 2004; Isozaki et al., 2004; McDonald et al., 2005; McDonald and Pereira, 2006; Corston-Oliver et al., 2006).
W06-2933
For comparison, Sagae et al.(2005) report 86.9% LAS on about 2,000 words of Eve data, using the Charniak (2000) parser with a separate dependency-labeling step.
A00-2018 P05-1025
E. Charniak, D. Blaheta, N. Ge, K. Hall, and M. Johnson. 2000. BLLIP 198789 WSJ Corpus Release 1, LD No. LDC2000T43. Linguistic Data Consortium.
A00-2018
Although we have so far focused exclusively on English CHILDES data, dependency schemes based on functional relationships exist for a number of languages (Buchholz and Marsi, 2006), and the general parsing techniques used in the present work have been shown to be effective in several of them (Nivre et al., 2006).
W06-2920 W06-2933
Recent work (Buchholz and Marsi, 2006; Nivre
W06-2920
Marsi, 2006; Nivre et al., 2007), but McDonald and
D07-1096
BLLIP corpus (Charniak et al., 2000), which con-
A00-2018
