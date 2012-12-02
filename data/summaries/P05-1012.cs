The Eisner (1996) algorithm can be modified to find the k-best trees while only adding an additional O(k logk) factor to the runtime (Huang and Chiang, 2005).
C96-1058
Ratnaparkhi. 1996.
W96-0213
c©2005 Association for Computational Linguistics Online Large-Margin Training of Dependency Parsers Ryan McDonald Koby Crammer Fernando Pereira Department of Computer and Information Science University of Pennsylvania Philadelphia, PA {ryantm,crammer,pereira}@cis.upenn.edu Abstract We present an effective training algorithm for linearly-scored dependency parsers that implements online largemargin multi-class training (Crammer and Singer, 2003; Crammer et al., 2003) on top of efficient parsing techniques for dependency trees (Eisner, 1996).
C96-1058
We also implemented an averaged perceptron system (Collins, 2002) (another online learning algorithm) for comparison.
W02-1001
Dependency trees capture important aspects of functional relationships between words and have been shown to be useful in many applications including relation extraction (Culotta and Sorensen, 2004), paraphrase acquisition (Shinyama et al., 2002) and machine translation (Ding and Palmer, 2005).
P04-1054 P05-1067
A more common approach is to factor the structure of the output space to yield a polynomial set of local constraints (Taskar et al., 2003; Taskar et al., 2004).
W04-3201
Collins and Roark (2004) presented a linear parsing model trained with an averaged perceptron algorithm.
P04-1015
We compared our system to the Bikel re-implementation of the Collins parser (Bikel, 2004; Collins, 1999) trained with the same head rules of our system.
J04-4004 P04-1015 P99-1065
Y&M2003 is the SVM-shiftreduce parsing model of Yamada and Matsumoto (2003), N&S2004 is the memory-based learner of Nivre and Scholz (2004) and MIRA is the the system we have described.
C04-1010
Our system assumes POS tags as input and uses the tagger of Ratnaparkhi (1996) to provide tags for the development and evaluation sets.
W96-0213
Eisner (1996) made the observation that if the head of each chart item is on the left or right periphery, then it is possible to parse in O(n3).
C96-1058
Eisner and Satta (1999) give a cubic algorithm for lexicalized phrase structures.
P99-1059
Eisner (1996) gave a generative model with a cubic parsing algorithm based on an edge factorization of trees.
C96-1058
Bikel. 2004.
J04-4004
Algorithm Given a feature representation for edges and a weight vector w, we seek the dependency tree or 92 h1 h1 h2 h2 ⇒ s h1 h1 r r+1 h2 h2 t h1 h1 h2 h2 ⇒ s h1 h1 h2 h2 t h1 h1 s h1 h1 t Figure 2: O(n3) algorithm of Eisner (1996), needs to keep 3 indices at any given stage.
C96-1058
In particular, we used the method of Collins et al.(1999) to simplify part-of-speech tags since the rich tags used by Czech would have led to a large but rarely seen set of POS features.
P99-1065
Discriminatively trained parsers that score entire trees for a given sentence have only recently been investigated (Riezler et al., 2002; Clark and Curran, 2004; Collins and Roark, 2004; Taskar et al., 2004).
P02-1035 P04-1014 P04-1015 W04-3201
Our approach is related to those of Collins and Roark (2004) and Taskar et al.(2004) for phrase structure parsing.
P04-1015 W04-3201
We tested our methods experimentally on the English Penn Treebank (Marcus et al., 1993) and on the Czech Prague Dependency Treebank (Hajiˇc, 1998).
J93-2004
To create dependency structures from the Penn Treebank, we used the extraction rules of Yamada and Matsumoto (2003), which are an approximation to the lexicalization rules of Collins (1999).
P99-1065
Eisner. 1996.
C96-1058
The Czech parser of Collins et al.(1999) was run on a different data set and most other dependency parsers are evaluated using English.
P99-1065
However, generative models make complicated and poorly justified independence assumptions and estimations, so we might expect better performance from discriminatively trained models, as has been shown for other tasks like document classification (Joachims, 2002) and shallow parsing (Sha and Pereira, 2003).
N03-1028
Phrase Structure Parsers It is well known that dependency trees extracted from lexicalized phrase structure parsers (Collins, 1999; Charniak, 2000) typically are more accurate than those produced by pure dependency parsers (Yamada and Matsumoto, 2003).
A00-2018 P99-1065
Collins. 1999.
P99-1065
Averaging has been shown to help reduce overfitting (Collins, 2002).
W02-1001
Yet, they can be parsed in O(n3) time (Eisner, 1996).
C96-1058
The best phrase-structure parsing models represent generatively the joint probability P(x,y) of sentence x having the structure y (Collins, 1999; Charniak, 2000).
A00-2018 P99-1065
We follow the edge based factorization method of Eisner (1996) and define the score of a dependency tree as the sum of the score of all edges in the tree, s(x,y) = summationdisplay (i,j)∈y s(i,j) = summationdisplay (i,j)∈y w · f(i,j) where f(i,j) is a high-dimensional binary feature representation of the edge from xi to xj.
C96-1058
Nivre and Scholz (2004) developed a history-based learning model.
C04-1010
Taskar et al.(2004) formulate the parsing problem in the large-margin structured classification setting (Taskar et al., 2003), but are limited to parsing sentences of 15 words or less due to computation time.
W04-3201
