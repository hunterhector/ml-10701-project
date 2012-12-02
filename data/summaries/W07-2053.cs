A. Ratnaparkhi, 1996.
W96-0213
Another type of WSD method uses supervised machine learning (ML) technolo41 gies (Bruce and Wiebe, 1994; Lee and Ng, 2002; Liu et al., 2002).
W02-1006
For automatic parsing, we made use of the wellknownCharniakparser(Charniak,2000).
A00-2018
Ratnaparkhi. 1996.
W96-0213 W96-0213 W96-0213
Although the CHILDES annotation scheme proposed by Sagae et al.(2004) has been used in practice for automatic parsing of child language transcripts (Sagae et al., 2004; Sagae et al., 2005), such work relied mainly on a statistical parser (Charniak, 2000) trained on the Wall Street Journal portion of the Penn Treebank, since a large enough corpus of annotated CHILDES data was not available to train a domain-specific parser.
A00-2018
So, we pre-tagged the input to the Bikel parser using the MXPOST tagger (Ratnaparkhi, 1996).
W96-0213
(Charniak, 2000; Briscoe et al., 2006), have wide coverage and yield grammatical representations capable of supporting various applications (e.g.
A00-2018
A tree kernel (Moschitti, 2004) is used to exploit the deep syntactic processing obtained using the Charniak parser (Charniak, 2000).
A00-2018
Eugene Charniak. 2000. A maximum-entropy-inspired parser. In Proceedings of NAACL, pages 132139.
A00-2018
Ratnaparkhi, 1996).
W96-0213
Generally, the syntactic structure of a sentence is represented as a tree, and parsing is carried out by maximizing the likelihood of the tree (Charniak, 2000; Uchimoto et al., 1999).
A00-2018
In contrast, methods based on Maximum Entropy (Ratnaparkhi, 1996), Conditional Random Field (Shrivastav, 2006) etc.
W96-0213
In recent years, many accurate phrase-structure parsers have been developed (e.g., (Collins, 1999; Charniak, 2000)).
A00-2018
Used The experiments reported in this paper were carried out with the News Commentary (NC) corpus as made available for the SMT workshop4 of the ACL 2007 conference.5 The Czech part of the corpus was tagged and lemmatized using the tool by Haji?c and Hladka (1998), the English part was tagged MXPOST (Ratnaparkhi, 1996) and lemmatized using the Morpha tool (Minnen et al., 2001).
W96-0213
It uses a log-linear model to define a distribution over the lexical category set for each word and the previous two categories (Ratnaparkhi, 1996) and the forward backward algorithm efficiently sums over all histories to give a distibution for each word.
W96-0213
E. Charniak 2000.
A00-2018
Lee, Y.K., & Ng, H.T. 2002.
W02-1006
Though taggers based on dependency networks (Toutanova et al., 2003), SVM (Gimenez and M`arquez, 2003), MaxEnt (Ratnaparkhi, 1996), CRF (Smith et al., 2005), and other methods may reach slightly better results, their train/test cycle is orders of magnitude longer.
W96-0213
that used in the Charniak parser (Charniak, 2000) or the various CCG parsers (Hockenmaier, 2006)).
A00-2018
A. Ratnaparkhi 1996.
W96-0213
A. Ratnaparkhi. 1996. A Maximum Entropy Model for Part-Of-Speech Tagging. In Proceedings of EMNLP, pages 133142.
W96-0213
That work relied on a phrase-structure statistical parser (Charniak, 2000) trained on the Penn Treebank, and the output of that parser had to be converted into CHILDES grammatical relations.
A00-2018
Local Collocations We adopt the same 11 collocation features as (Lee and Ng, 2002), namely C??,??, C1,1, C??,??, C2,2, C??,??, C??,1, C1,2, C??,??, C??,1, C??,2, and C1,3.
W02-1006
For comparison, Sagae et al.(2005) report 86.9% LAS on about 2,000 words of Eve data, using the Charniak (2000) parser with a separate dependency-labeling step.
A00-2018
E. Charniak, D. Blaheta, N. Ge, K. Hall, and M. Johnson. 2000. BLLIP 198789 WSJ Corpus Release 1, LD No. LDC2000T43. Linguistic Data Consortium.
A00-2018
Hence no system has reached ??in the absolute terms ??a performance comparable to English tagging (such as (Ratnaparkhi, 1996)), which stands above 97 %.
W96-0213
We use MXPOST tagger (Adwait, 1996) for POS tagging, Charniak parser (Charniak, 2000) for extracting syntactic relations, and David Blei?s version of LDA1 for LDA training and inference.
A00-2018
Algorithm SVM is an effective learning algorithm to WSD (Lee and Ng, 2002).
W02-1006
Syntactic Relations We adopt the same syntactic relations as (Lee and Ng, 2002).
W02-1006
It is interesting to note that the inclusion of prefix and suffix for all words gives better result instead of using only for rare words as is described in Ratnaparkhi (1996).
W96-0213
This parser uses a discriminative reranker that selects the most probable parse from the 50-best parses returned by a generative parser based on Charniak (2000).
A00-2018
Our SVM classifier (using SVMlight) follows that of (Lee and Ng, 2002), which ranked the third in Senseval-3 English lexical sample task.
W02-1006
The feature set used here is as same as the feature set used in (Lee and Ng, 2002) except that we did not use syntactic relations.
W02-1006
BLLIP corpus (Charniak et al., 2000), which con-
A00-2018
