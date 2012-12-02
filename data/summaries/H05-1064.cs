Previous work has generally relied on two approaches to representation: explicitly hand–crafted features (e.g., in Charniak and Johnson (2005)) or features defined through kernels (e.g., see Collins and Duffy (2002)).
P02-1034 P02-1062 P05-1022
However, even with these restrictions, finding argmaxtsummationtexthp(t,h|s,Θ) is NP–hard, and the Viterbi approximation argmaxt,hp(t,h|s,Θ) — or other approximations — would have to be used (see Matsuzaki et al.(2005)). 6.3 Empirical Analysis of the Hidden Values Our model makes no assumptions about the interpretation of the hidden values assigned to words: during training, the model simply learns a distribution over global hidden–value assignments that is useful in improving the log–likelihood of the training data.
P05-1010
Bikel (2000) has done previous work on incorporating the WordNet hierarchy into a generative parsing model; however, this approach requires data with word–sense annotations whereas our model deals with word–sense ambiguity through unsupervised discriminative training.
W00-1320
Supersense (Pre–Built Ontology) We borrow the idea of using WordNet lexicographer filenames as broad “supersenses” from Ciaramita and Johnson (2003).
W03-1022
In our experiments, we made use of features such as those in Figure 2 in combination with the following four definitions of the hidden–value 3We also performed some experiments using the conjugate gradient descent algorithm (Johnson et al., 1999).
P99-1069
Riezler et al.(2002) describe a discriminative LFG parsing model that is trained on standard (syntax only) treebank annotations by treating each tree as a full LFG analysis with an observed c-structure and hidden f-structure.
P02-1035
Brown et al.(1992) or Pereira et al.(1993)) have typically leveraged distributional similarity.
J92-4003 P93-1024
Another area for future research is to investigate the use of unlabeled data within the approach, for example by making use of clusters derived from large amounts of unlabeled data (e.g., see Miller et al.(2004)). Finally, future work may apply the models to NLP tasks other than parsing.
N04-1043
Clark and Curran (2004) present an alternative CCG parsing approach that divides each CCG parse into a dependency structure (observed) and a derivation (hidden).
P04-1014
We discuss this point further in Section 6.1. 2 Related Work Various machine–learning methods have been used within reranking tasks, including conditional log– linear models (Ratnaparkhi et al., 1994; Johnson et al., 1999), boosting methods (Collins, 2000), variants of the perceptron algorithm (Collins, 2002; Shen et al., 2004), and generalizations of support– vector machines (Shen and Joshi, 2003).
N04-1023 P02-1034 P02-1062 P99-1069 W03-0402
More recently, Matsuzaki et al.(2005) introduce a probabilistic CFG augmented with hidden information at each nonterminal, which gives their model the ability to tailor itself to the task at hand.
P05-1010
Reranking approaches have given improvements in accuracy on a number of NLP problems including parsing (Collins, 2000; Charniak and Johnson, 2005), machine translation (Och and Ney, 2002; Shen et al., 2004), information extraction (Collins, 2002), and natural language generation (Walker et al., 2001).
N01-1003 N04-1023 P02-1034 P02-1038 P02-1062 P05-1022
