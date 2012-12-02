An important distinction we should make is the notion of supported versus unsupported features (Sha and Pereira, 2003).
N03-1028
This algorithm is really an extension of Viterbi to the case when scores factor over dynamic substrings of the text (Sarawagi and Cohen, 2004; McDonald et al., 2005a).
H05-1124 P05-1012
We follow the method of McDonald et al.(2005b) and create constraints only on the k compressions that currently have the highest score, bestk(x;w).
H05-1124 P05-1012
We call this soft syntactic evidence since the deep trees are not used as a strict goldstandard inourmodelbutjustasmoreevidence for 300 root0 saw2 on4 after6 Mary1 Ralph3 Tuesday5 lunch7 S VP PP PP NP NP NP NP NNP VBD NNP IN NNP IN NN Mary1 saw2 Ralph3 on4 Tuesday5 after6 lunch7 Figure 2: An example dependency tree from the McDonald et al.(2005b) parser and phrase structure tree from the Charniak (2000) parser.
A00-2018 H05-1124 P05-1012
Averaging has been shown to reduce overfitting (Collins, 2002) as well as reliance on the order of the examples during training.
W02-1001
Collins. 2002.
W02-1001
Recently Turner and Charniak (2005) presented supervised and semi-supervised versions of the Knight and Marcu noisy-channel model.
P05-1036
w = v/(N ∗T) Figure 3: MIRA learning algorithm as presented by McDonald et al.(2005b). best performance, though varying k did not have a major impact overall.
H05-1124 P05-1012
Riezler et al.(2003) present a discriminative sentence compressor over the output of an LFG parser that is a packed representation of possible compressions.
N03-1026
Charniak. 2000.
A00-2018
We focus on the particular instantiation of sentence compression when the goal is to produce the compressed version solely by removing words or phrases from the original, which is the most common setting in the literature (Knight and Marcu, 2000; Riezler et al., 2003; Turner and Charniak, 2005).
N03-1026 P05-1036
To do this we parse every sentence twice, once with a dependency parser (McDonald et al., 2005b) and once with a phrase-structure parser (Charniak, 2000).
A00-2018 H05-1124 P05-1012
A possible direction of research is to investigate multilabel learning techniques for structured data (McDonald et al., 2005a) that learn a scoring function separating a set of valid answers from all invalid answers.
H05-1124 P05-1012
