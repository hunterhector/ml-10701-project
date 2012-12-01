Bangalore and Joshi (1999) indicated that, correct disambiguation with supertagging, i.e., assignment of lexical entries before parsing, enabled effective LTAG (Lexicalized Tree-Adjoining Grammar) parsing.
J99-2004
Roark and Bacchiani (2003) adapted a lexicalized PCFG by using maximum a posteriori (MAP) estimation for handling unlabelled adaptation data.
N03-1027
In the field of classifications, Blitzer et al.(2006) utilized unlabelled corpora to extract features of structural correspondences, and then adapted a POS-tagger to a biomedical domain.
W06-1615
Pyysalo et al.(2004) showed the experimental results that this approach improved the performance of a parser for Link Grammar.
W04-1203
McClosky et al.(2006) adapted a re-ranking parser to a target domain by self-training the parser with unlabelled data in the target domain.
P06-1043
Therefore, domain adaptation methods have recently been proposed in several NLP areas, e.g., word sense disambiguation (Chan and Ng, 2006), statistical parsing (Lease and Charniak, 2005; McClosky et al., 2006), and lexicalized-grammar parsing (Johnson and Riezler, 2000; Hara et al., 2005).
A00-2021 P06-1012 P06-1043
Ninomiya et al.(2006) also succeeded in significantly improving speed and accuracy of HPSG parsing by using supertagging probabilities.
W06-1619
HPSG parser used in this study is Ninomiya et al.(2006), which is based on Enju (Miyao and Tsujii, 2005).
P05-1011 W06-1619
Clark and Curran (2006) showed that a CCG parser trained on data derived from lexical category sequences alone was only slightly less accurate than one trained on complete dependency structures.
N06-1019
Steedman et al.(2003) utilized a co-training parser for adaptation and showed that co-training is effective even across domains.
E03-1008
The original parser, Enju, was developed on Section 0221 of the Penn Treebank (39,832 sentences) (Miyao and Tsujii, 2005; Ninomiya et al., 2006).
P05-1011 W06-1619
Titov and Henderson (2006) also took this type of approach.
W06-2902
Lexical entries of Enju were extracted from the Penn Treebank (Marcus et al., 1994), which consists of sentences collected from The Wall Street Journal (Miyao et al., 2004).
H94-1020
Clark and Curran (2004a) showed that supertagging reduced cost for training and execution of a CCG (Combinatory Categorial Grammar) parser while keeping accuracy.
C04-1041 P04-1014
The disambiguation model of Enju is based on a feature forest model (Miyao and Tsujii, 2002), which is a log-linear model (Berger et al., 1996) on packed forest structure.
J96-1002
With the revised Enju model, they achieved Table 1: Features for the probabilities of lexical entry selection surrounding words DB A0BD DB BC DB BD (word trigram) surrounding POS tags D4 A0BE D4 A0BD D4 BC D4 BD D4 BE (POS 5-gram) combinations DB A0BD DB BC BNDB BC DB BD BND4 A0BD DB BC BND4 BC DB BC BN D4 BD DB BC BND4 BC D4 BD D4 BE D4 BF BND4 A0BE D4 A0BD D4 BC BN D4 A0BD D4 BC D4 BD BND4 BC D4 BD D4 BE BND4 A0BE D4 A0BD BN D4 A0BD D4 BC BND4 BC D4 BD BND4 BD D4 BE parsing accuracy as high as Miyao and Tsujii (2005), with around four times faster parsing speed.
P05-1011
The measure is labeled precision/recall (LP/LR), which is the same measure as previous work (Clark and Curran, 2004b; Miyao and Tsujii, 2005) that evaluated the accuracy of lexicalized grammars on the Penn Treebank.
C04-1041 P04-1014 P05-1011
Johnson and Riezler (2000) suggested the possibility of the method for adapting a stochastic unification-based grammar including HPSG to another domain.
A00-2021
In this paper, we propose a method for adapting an HPSG parser (Miyao and Tsujii, 2002; Ninomiya et al., 2006) trained on the WSJ section of the Penn Treebank (Marcus et al., 1994) to a biomedical domain.
H94-1020 W06-1619
For the feature functions, instead of using unigram features adopted in Miyao and Tsujii (2005), Ninomiya et al.(2006) used “word trigram” and “POS 5-gram” features which are listed in Table 1.
P05-1011 W06-1619
