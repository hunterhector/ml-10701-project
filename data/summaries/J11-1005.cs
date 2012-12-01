(Nivre et al. 2006), although our parser is different from MaltParser in two aspects.
W06-2933
binarized trees. In the deterministic parser of Wang et al. (2006), the highest scoring
W06-0121
Row Huang 2010 shows the recent work of Huang and Sagae (2010), which applies
P10-1110
We also use the early-update strategy of Collins and Roark (2004), which is a
P04-1015
proach (Sagae and Lavie 2006), which was reported to be useful in improving depen-
N06-2033
using a different model from projective dependency parsing (McDonald et al. 2005), it
H05-1066 P05-1012
and Manning (2003), Xiong et al. (2005), Bikel (2004), Chiang and Bikel (2002), the SVM
C02-1126 I05-1007
transition-based parser lags behind the current state-of-the-art (Sagae and Lavie 2005).
W05-1513
Zhang, Yue and Stephen Clark. 2007.
J07-4004 P07-1106
SHIFT and REDUCE, and the graph-based method (Collins 1999; Charniak 2000), which
A00-2018
with Zhang and Clark (2007)
J07-4004 P07-1106
Sagae, Kenji and Alon Lavie. 2005. A
W05-1513
We use several pruning methods from Zhang and Clark (2008a), most of which serve
D08-1059 P08-1101
Petrov and Klein (2007) reported LR and LP of 85:7% and 86:9% for sentences
N07-1051
models in the literature. Following Ng and Low (2004), we partition the sentences in
W04-3236
algorithms of the framework to give higher accuracies. Huang and Sagae (2010) have
P10-1110
Chiang, David and Daniel M. Bikel. 2002.
C02-1126
features, whereas the parser from Wang et al. (2006) is based on a local classifier that
W06-0121
The averaged perceptron algorithm (Collins 2002) is a standard way of reducing
W02-1001
gave comparable accuracies in the CoNLL-X shared task (Buchholz and Marsi 2006).
W06-2920
search decoder, and MaltParser (Nivre et al. 2006) is a transition-based parser with
W06-2933
Briscoe, Ted and John Carroll. 1993.
J93-1002
Smith, David and Jason Eisner. 2008.
D08-1016
(Martins, Smith, and Xing 2009), and forest reranking for phrase-structure parsing
P09-1039
Buchholz, Sabine and Erwin Marsi. 2006.
W06-2920
In Zhang and Clark (2007) we fixed the number of training iterations to six for
J07-4004 P07-1106
shown in Table 22. The rows represent the model from Bikel and Chiang (2000) and
W00-1201
Bikel, Daniel M. and David Chiang. 2000.
W00-1201
posed in Zhang and Clark (2007). We compare the accuracies of this segmentor and
J07-4004 P07-1106
and Uchimoto (2007), rows J08a and J08b refer to the models of Jiang et al. (2008) and
C08-1049 P08-1102
Wang 2006 SVM 87:2% 88:3% 87:8%
W06-0121
of Collins (2002) with beam-search. Like McDonald, Crammer, and Pereira (2005), we
H05-1066 P05-1012 W02-1001
2008 and Chen 2009 represent the models of Koo, Carreras, and Collins (2008) and
D09-1060 P08-1068 W08-2102
for structural prediction that consists of the generalized perceptron (Collins 2002) and
W02-1001
complex than this; the full set can be found in Zhang and Clark (2009). Wang et al.(2006) give a detailed example showing how a segmented and POS-tagged sentence can
N06-2049 W06-0121 W09-3825
Chen 2009 93.2 47.2
D09-1060
Zhang, Yue and Stephen Clark. 2010. A fast
D10-1082
Nakagawa and Uchimoto (2007) proposed a hybrid model for word segmentation
P07-2055
dency parsing (Hall et al. 2007). A more recent approach (Nivre and McDonald 2008)
D07-1097 P08-1108
correspond to “Zhang 2007*” in Tables 4 and 5.
P07-1106
parses. Templates 1–6 are taken from MSTParser (McDonald and Pereira 2006), a
E06-1011
Huang 2010 85.52 78.32 33.72
P10-1110
POS-tagging using feature templates from Collins (2002), it gave similar accuracy to the
W02-1001
Zhang, Yue and Stephen Clark. 2008a. Joint
D08-1059 P08-1101
McDonald, Ryan and Joakim Nivre. 2007.
D07-1013 D07-1096
correct word segmentation (Sproat et al. 1996). Also, specific NLP tasks may require
J96-3004
et al. (2006). However, Wang et al. (2006) used a polynomial kernel function with an
W06-0121
segmentor of Zhang and Clark (2007) has. We implement this decoder for segmentation
J07-4004 P07-1106
method was used by Carreras, Surdeanu, and Marquez (2006) in their parsing model.
W06-2925
Chinese, which is based on the transition process of Wang et al. (2006). Rather than
W06-0121
We showed in Zhang and Clark (2008a) that a naive single-beam decoder which
D08-1059 P08-1101
Emerson, Thomas. 2005. The second
I05-3017
parsing (Smith and Eisner 2008), integer linear programming for dependency parsing
D08-1016
model. The standard feature set is that defined by Ng and Low (2004), though other
W04-3236
Collins, Michael and Brian Roark. 2004.
P04-1015
features. The term global feature vector is used by Collins (2002) to distinguish between
W02-1001
dynamic-programming decoder of Collins (2002). All these experiments suggest that the
W02-1001
Sagae, Kenji and Alon Lavie. 2006. Parser
N06-2033
and Emerson 2003; Emerson 2005) to compare the accuracies to other models in the
I05-3017
Huang 2010 represents the model of Huang and Sagae (2010), which applies dynamic-
P10-1110
theoretical differences (McDonald and Nivre 2007). By combining graph-based and
D07-1013 D07-1096
Petrov, Slav and Dan Klein. 2007. Improved
N07-1051
Zhang 2008 97.82 93.62
D08-1059 P08-1101
with beam-search decoding. In Zhang and Clark (2007) we performed the standard
J07-4004 P07-1106
model from Wang et al. (2006), the ensemble system from Wang et al. (2006), and the
W06-0121
Both our parser and the parser from Collins and Roark (2004) use a global discrim-
P04-1015
(Huang 2008).
P08-1067
dency structures, and they can be found in Zhang and Clark (2008a). Like Duan, Zhao,
D08-1059 P08-1101
Graph-based (McDonald, Crammer, and Pereira 2005; Carreras, Surdeanu, and
H05-1066 P05-1012
Kruengkrai et al. (2009) made use of character type knowledge for spaces, numerals,
P09-1058
Compared with Ng and Low (2004), our baseline model gave slightly better accu-
W04-3236
Zhang 2007* 95.0 95.1 94.6 97.3 95.5 95.6
P07-1106
The generalized perceptron algorithm, adapted from Collins (2002).
W02-1001
Roark, Brian. 2001. Probabilistic top–down
J01-2004
it gives comparable accuracies to our previous work (Zhang and Clark 2008a), while
D08-1059 P08-1101
F-scores than the state-of-the-art C&C CCG parser (Clark and Curran 2007). The range of
J07-4004
dresses these problems. In Zhang and Clark (2008a) we proposed a joint word segmen-
D08-1059 P08-1101
Huang, Liang and Kenji Sagae. 2010.
P10-1110
and Wang et al. (2006), and therefore it can be classified as a transition-based parser
W06-0121
Results Using CTB5. We follow Kruengkrai et al. (2009) and split the CTB5 into
P09-1058
In Zhang and Clark (2007) we proposed a word-based approach to segmentation,
J07-4004 P07-1106
Our parser is based on the shift-reduce parsing process from Sagae and Lavie (2005)
W05-1513
found in Zhang and Clark (2008a). In this article, we report only the final test accu-
D08-1059 P08-1101
beam system (Zhang and Clark 2008a). This was designed to help keep likely partial
D08-1059 P08-1101
and ensemble models from Wang et al. (2006). However, comparison with Table 22
W06-0121
Levy 2003 79:2% 78:4% 78:8% -
P03-1056
Chiang 2002 78:8% 81:1% 79:9% 75:2% 78:0% 76:6% -
C02-1126
Feng, and McCallum (2004), and Wang et al. (2006), which use maximum entropy and
W06-0121
Bikel (2004), the SVM and ensemble models from Wang et al. (2006), and our parser,
W06-0121
Zhang and Clark (2008a) we showed that the combined parser also significantly outperformed the
D08-1059 P08-1101
Jiang, Wenbin, Haitao Mi, and Qun Liu. 2008.
C08-1049 P08-1102
each task in turn, based on conference papers including Zhang and Clark (2007, 2008a,
D08-1059 J07-4004 P07-1106 P08-1101
the early-update strategy of Collins and Roark (2004) is used.
P04-1015
information simultaneously in a single perceptron model. Recently, Kruengkrai et al.(2009) developed this hybrid model further by scoring characters and words in the same
P09-1058
model from Peng, Feng, and McCallum (2004), row “Zhang 2007” represents our model
C04-1081 P07-1106
templates 1–6 from Table 14 (McDonald and Pereira 2006), respectively. Rows Transition
E06-1011
way to Ng and Low (2004). In comparison, our model handles character and word
W04-3236
McDonald, Crammer, and Pereira 2005; Clark and Curran 2007; Carreras, Collins, and
D07-1013 H05-1066 J07-4004 P05-1012
(Nivre et al. 2006). An important difference between our parser and the Wang et al.(2006) parser is that our parser is based on a discriminative learning model with global
W06-0121 W06-2933
Four training and testing corpora were used in the second bakeoff (Emerson 2005),
I05-3017
Huang 2010 92.1 –
P10-1110
The Bracket row shows bracket-related features, which were inspired by Wang et al.(2006). Here brackets refer to left brackets including “x8”, “x1c”, and “xa” and right brackets
W06-0121
Our system of Zhang and Clark (2008a) was based on the perceptron and a multiple-
D08-1059 P08-1101
Bikel 2000 76:8% 77:8% 77:3% 73:3% 74:6% 74:0% -
W00-1201
this section, we give a description of our system of Zhang and Clark (2008a), and discuss
D08-1059 P08-1101
Sagae and Lavie (2005) and Wang et al. (2006), with slight modifications. The input
N06-2033 W05-1513 W06-0121
and show the accuracies in row “Zhang 2007*”.
P07-1106
In Zhang and Clark (2008b) we proposed a graph-based parser and a transition-
D08-1059 P08-1101
update method of Collins and Roark (2004), as described in Section 2, is used. It ensures
P04-1015
Table 23. The rows in the table represent the models from Bikel and Chiang (2000), Levy
W00-1201
We chose to follow Ng and Low (2004) and split the sentences evenly to facilitate further
W04-3236
shown in a row, where Ng represents the models from Ng and Low (2004), which
W04-3236
Emerson (2005), as well as the sub-word-based model of Zhang, Kikui, and Sumita
I05-3017
Matsumoto 2003; Nivre et al. 2006) parsing algorithms offer two different approaches
W06-2933
Huang, Liang. 2008. Forest reranking:
P08-1067
model in the discriminative model, as did Collins and Roark (2004).
P04-1015
with Multiple-Beam Search (Zhang and Clark 2008a)
D08-1059 P08-1101
Jiang, Mi, and Liu (2008) proposed a reranking system that builds a pruned word
C08-1049 P08-1102
Ng, Hwee Tou and Jin Kiat Low. 2004.
W04-3236
Chen et al. (2009), which perform semi-supervised learning by word-clustering and
D09-1060
Koo. 2008. Tag, dynamic programming,
P08-1068
In Zhang and Clark (2009) we proposed a transition-based constituent parser for
W09-3825
POS-tagger of Zhang and Clark (2008a), which can be seen as the perceptron tagger
D08-1059 P08-1101
Marquez 2006; McDonald and Pereira 2006) and transition-based (Yamada and
E06-1011
Zhang, Yue and Stephen Clark. 2009.
W09-3825
Zhang, Yue and Stephen Clark. 2008b.
D08-1059 P08-1101
multiple-beam system in Zhang and Clark (2008a), and a speed that is over an order of
D08-1059 P08-1101
Koo 2008 93.2 –
P08-1068
Zhang 2007* 96.9 94.6 94.1 95.2 95.5
P07-1106
problems (Lafferty, McCallum, and Pereira 2001; Collins 2002; Collins and Roark 2004;
P04-1015 W02-1001
*Zhang 2007 with the (Carreras, Surdeanu, and Marquez 2006) method applied (see text for
N06-2049 N06-2049 P07-1106 P07-1106 W06-2925 W06-2925
decoder we proposed in Zhang and Clark (2008a) can be seen as a means to ensure
D08-1059 P08-1101
literature, including our segmentor of Zhang and Clark (2007).
J07-4004 P07-1106
(McDonald, Crammer, and Pereira 2005; Crammer et al. 2006) are also commonly used
E06-1011 H05-1066 P05-1012
Multiple-Beam Search Decoder. In Zhang and Clark (2008a) we proposed a
D08-1059 P08-1101
Zhang 2007 94.6 95.1 94.5 97.2 95.4 95.6
P07-1106
Zhang 2007 96.5 94.6 94.0 95.0 95.5
P07-1106
Jiang, Mi, and Liu (2008), and row K09 refers to the models of Kruengkrai et al. (2009).
C08-1049 P08-1102 P09-1058
algorithm of Zhang and Clark (2008a).
D08-1059 P08-1101
our joint segmentation and tagging systems of Zhang and Clark (2008a) and this article
D08-1059 P08-1101
the early-update strategy of Collins and Roark (2004) is used. The intuition is to improve
P04-1015
in the other in a stacking framework. Both Hall et al. (2007) and Nivre and McDonald
D07-1097
the CoNLL shared tasks on dependency parsing (Buchholz and Marsi 2006; Nivre et al.2007) most data sets contain only 1–2% non-projective arcs, and projective dependency
D07-1096 W06-2920
MSTParser (McDonald and Pereira 2006) is a graph-based parser with an exhaustive
E06-1011
feature sets are reported to improve the accuracy (Zhao, Huang, and Li 2006). Zhao,
W06-0127
as reported in Zhang and Clark (2007), and the last two rows represent our model in
J07-4004 P07-1106
and Roark, like Roark (2001), follow a top–down derivation strategy, whereas we chose
J01-2004
conditional random field models, and Jiang et al. (2008), which uses the perceptron
C08-1049 P08-1102
Both the segmentor of this article and our segmentor of Zhang and Clark (2007) use
J07-4004 P07-1106
to decide the number of training iterations for our system of Zhang and Clark (2007),
J07-4004 P07-1106
for Chinese (Wang et al. 2006). In addition, we did not include a generative baseline
W06-0121
single-beam decoder, which runs an order of magnitude faster (Zhang and Clark 2010).
D10-1082
Peng, F., F. Feng, and A. McCallum. 2004.
C04-1081
Collins, Michael. 2002. Discriminative
W02-1001
However, for Chinese constituent parsing using the Chinese Treebank, Wang et al.(2006) have shown that a shift-reduce parser can give competitive accuracy scores to-
W06-0121
Koo 2008; Finkel, Kleeman, and Manning 2008).
P08-1068 P08-1109
Charniak, Eugene. 2000. A
A00-2018
Xiong 2005 78:7% 80:1% 79:4% -
I05-1007
Ng and Low (2004) mapped the joint segmentation and POS-tagging task into a
W04-3236
Multiple-Beam System of Zhang and Clark (2008a). The decoder of our multiple-
D08-1059 P08-1101
Wang 2006 Stacked 88:3% 88:1% 88:2%
W06-0121
experiments were performed using the Zhang and Clark (2007) feature set and single-beam decoder,
J07-4004 P07-1106
