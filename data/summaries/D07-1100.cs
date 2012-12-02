Collins and Koo (2005) proposed a reranking method for phrase structure parsing with which any type of global features in a parse tree can be used.
J05-1003
We participated in the multilingual track of the CoNLL 2007 shared task (Nivre et al., 2007), and evaluated the system on data sets of 10 languages (Hajiˇc et al., 2004; Aduriz et al., 2003; Mart´ı et al., 2007; Chen et al., 2003; B¨ohmov´a et al., 2003; Marcus et al., 1993; Johansson and Nugues, 2007; Prokopidis et al., 2005; Csendes et al., 2005; Montemagni et al., 2003; Oflazer et al., 2003).
D07-1096 J93-2004
Riedel and Clarke (2006) suggested to use linguistic constraints such as “arguments of a coordination must have compatible word classes,” and such constraint seemed to be represented by the features in our models.
W06-1616
This feature template is almost the same as the one used by McDonald and Pereira (2006).
E06-1011
Eisner. 1996.
C96-1058
For dependency parsing, McDonald and Pereira (2006) proposed a method which can incorporate some types of global features, and Riedel and Clarke (2006) studied a method using integer linear programming which can incorporate global linguistic constraints.
E06-1011 W06-1616
Solving largescale multi-class classification problem with SVMs requires substantial computational resources, so we use the revision learning method (Nakagawa et al., 2002).
P02-1063
All of these data sets except Italian contain relatively a large number of non-projective sentences (the percentage of sentences with at least one non-projective relation in the training data is over 20% (Nivre et al., 2007)), though the Greek data set, on which the Eisner algorithm performed better, also contains many non-projective sentences (20.3%).
D07-1096
The best projective parse tree is obtained using the Eisner algorithm (Eisner, 1996) with the scores, and the best non-projective one is obtained using the ChuLiu-Edmonds (CLE) algorithm (McDonald et al., 2005b).
C96-1058 H05-1066 P05-1012
In order to find a solution using the marginal distribution, we adopt the maximum spanning tree (MST) framework proposed by McDonald et al.(2005a). In this framework, scores for possible edges in dependency graphs are defined, and the optimal dependency tree is found as the MST in which the summation of the edge scores is maximized.
H05-1066 P05-1012
