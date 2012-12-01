This is an imbalance 1152 Languages Training size Tokens size tokens-per-sent % of NPR % of-sentence AL-1-NPR Arabic 2,900 112,000 38.3 0.4 10.1 Basque 3,200 51,000 15.8 2.9 26.2 Catalan 15,000 431,000 28.8 0.1 2.9 Chinese 57,000 337,000 5.9 0.0 0.0 Czech 25,400 432,000 17.0 1.9 23.2 English 18,600 447,000 24.0 0.3 6.7 Greek 2,700 65,000 24.2 1.1 20.3 Hungarian 6,000 132,000 21.8 2.9 26.4 Italian 3,100 71,000 22.9 0.5 7.4 Turkish 5,600 65,000 11.6 0.5 33.3 Table 4: The data used in the multilingual track (Nivre et al., 2007).
D07-1096
The learning methods using in discriminative parsing are Perceptron (Collins, 2002) and online large-margin learning (MIRA) (Crammer and Singer, 2003).
W02-1001
The performance of MIRA based parsing achieves the state-ofthe-art performance in English data (McDonald et al., 2005a; McDonald et al., 2006).
H05-1066 P05-1012 W06-2932
We follow the edge based factorization method of Eisner (Eisner, 1996) and define the score of a dependency tree as the sum of the score of all edges in the tree, s(x,y) = summationdisplay (i,j)∈y s(i,j) = summationdisplay (i,j)∈y w ·Φ(i,j) (1) where Φ(i,j) is a high-dimensional binary feature representation of the edge from xwi to xwj . For example in Figure 1, we can present an example Φ(i,j) as follows; Φ(i,j) = braceleftBigg 1if xwi =prime hitprimeandxwj =prime ballprime 0otherwise The basic question must be answered for models of this form: how to find the dependency tree y with the highest score for sentence x?
C96-1058
The Perceptron style for natural language processing problems as initially proposed by (Collins, 2002) can provide state of the art results on various domains including text chunking, syntactic parsing, etc.
W02-1001
It is easy to see that the main difference between the PA algorithms and the Perceptron algorithm (PC) (Collins, 2002) as well as the MIRA algorithm (McDonald et al., 2005a) is in line 9.
H05-1066 P05-1012 W02-1001
The algorithms are commonly used in other online-learning dependency parsing, such as in (McDonald et al., 2005a).
H05-1066 P05-1012
For dependency parsing domain, McDonald et al (2005a) modified the MIRA learning algorithm (McDonald et al., 2005a) for structured domains in which the optimization problem can be solved by using Hidreth’s algorithm (Censor and Zenios, 1997), which is faster than the quadratic programming technique.
H05-1066 P05-1012
Averaging has been shown to help reduce overfitting (McDonald et al., 2005a; Collins, 2002).
H05-1066 P05-1012 W02-1001
The MIRA based parsing is close to maximum-margin parsing as in Taskar et al.(2004) and Tsochantaridis et al.(2005) for parsing.
W04-3201
Second, we evaluate the proposed algorithm on the multilingual data task as well as the domain adaptation task (Nivre et al., 2007).
D07-1096
Algorithm Dependency-tree parsing as the search for the maximum spanning tree (MST) in a graph was proposed by McDonald et al.(2005b). In this subsection, we briefly describe the parsing algorithms based on the first-order MST parsing.
H05-1066 P05-1012
There are some algorithms 1149 Figure 1: This is an example of dependency tree to determine these relations of each word to another words, for instance, the modified CKY algorithm (Eisner, 1996) is used to define these relations for a given sentence.
C96-1058
Eisner. 1996.
C96-1058
The two algorithms we employed in our dependency parsing model are the Eisner parsing (Eisner, 1996) and Chu-Liu’s algorithm (Chu and Liu, 1965).
C96-1058
Research on dependency parsing is mainly based on machine learning methods, which can be called history-based (Yamada and Matsumoto, 2003; Nivre et al., 2006) and discriminative learning methods (McDonald et al., 2005a; Corston-Oliver et al., 2006).
H05-1066 N06-1021 P05-1012 W06-2932 W06-2933
As a result, our method yields results above the average score on the CONLL-2007 shared task (Nivre et al., 2007).
D07-1096
The pchemtb-closed shared task (Marcus et al., 1993; Johansson and Nugues, 2007; Kulick et al., 2004) is used to illustrate our models.
J93-2004 W04-3111
This feature was particularly helpful for nouns identifying their parent (McDonald et al., 2005a).
H05-1066 P05-1012
The structured support vector machine (Tsochantaridis et al., 2005) and the maximize margin model (Taskar et al., 2004) can gain a maximize margin value for given training data by solving an optimization problem (i.e quadratic programming).
W04-3201
Results and Discussion We test our parsing models on the CONLL-2007 (Hajiˇc et al., 2004; Aduriz et al., 2003; Mart´ı et al., 2007; Chen et al., 2003; B¨ohmov´a et al., 2003; Marcus et al., 1993; Johansson and Nugues, 2007; Prokopidis et al., 2005; Csendes et al., 2005; Montemagni et al., 2003; Oflazer et al., 2003) data set on various languages including Arabic, Basque, Catalan, Chinese, English, Italian, Hungarian, and Turkish.
J93-2004
Table 5 reports experimental results by using the first order decoding method in which an MST parsing algorithm (McDonald et al., 2005b) is applied for non-projective parsing and the Eisner’s method is used for projective language data.
H05-1066 P05-1012
