Box 90153, NL-5000 LE Tilburg, The Netherlands S.V.M.Canisius@uvt.nl Erik Tjong Kim Sang ISLA, University of Amsterdam, Kruislaan 403, NL-1098 SJ Amsterdam, The Netherlands erikt@science.uva.nl Abstract We present an adaptation of constraint satisfaction inference (Canisius et al., 2006b) for predicting dependency trees.
W06-2602 W06-2924
The ’06 columns show the gain/loss with respect to the parser of Canisius et al.(2006a). number of variables, and thus in the length of the sentence.
W06-2602 W06-2924
Predicting constraints of type Cdep is essentially what is done by Canisius et al.(2006a); a classifier is trained to predict a relation label, or a symbol signalling the absence of a relation, for each pair of tokens in a sentence2.
W06-2602 W06-2924
Like the CoNLL-2006 shared task, the 2007 shared task focuses on dependency parsing and aims at comparing state-of-the-art machine learning algorithms applied to this task (Nivre et al., 2007).
D07-1096
The method is an adaptation of earlier work using constraint satisfaction techniques for predicting sequential outputs (Canisius et al., 2006b).
W06-2602 W06-2924
While in comparison with the system of Canisius et al.(2006a) the addition of extra constraints has clearly shown its use, we expect the Cdep classifier still to be the performance bottleneck of the system.
W06-2602 W06-2924
In addition, we show the increase/decrease in performance when compared with the parser of Canisius et al.(2006a); for all languages but Turkish, there is a consistent increase, mostly somewhere between 1.0 and 2.0 percent in labelled attachment score.
W06-2602 W06-2924
To evaluate the effect of each of these constraints, Language ’06 Cdep Cmod/dep Cdir/dep all Arabic 59.13 +0.3 +0.9 +0.9 +1.2 Basque 63.17 +0.3 +0.4 +0.9 +1.1 Catalan 75.44 +0.8 +1.2 +1.4 +1.9 Chinese 70.45 +0.4 +1.2 +0.4 +1.3 Czech 56.14 +0.5 +0.5 +1.1 +1.4 English 77.27 +0.4 +1.4 +1.2 +2.2 Greek 60.35 +0.4 +0.6 +1.6 +2.0 Hungarian 64.31 +1.9 +1.3 +2.8 +2.6 Italian 75.57 +0.2 +1.0 +1.1 +1.5 Turkish 68.09 -0.2 -0.3 -0.3 -0.3 Table 2: Performance of the parser by Canisius et al.(2006a) and the performance gain of the constraint satisfaction inference parser with various constraint configurations.
W06-2602 W06-2924
However, in general such solvers have a time complexity exponential in the 2For reasons of efficiency and to avoid having too many negative instances in the training data, we follow the approach of Canisius et al.(2006a) of limiting the maximum distance between a potential head and modifier.
W06-2602 W06-2924
The method is evaluated in Section 3, in which we will also present a brief error 1Hajiˇc et al.(2004), Aduriz et al.(2003), Mart´ı et al.(2007), Chen et al.(2003), B¨ohmov´a et al.(2003), Marcus et al.(1993), Johansson and Nugues (2007), Prokopidis et al.(2005), Csendes et al.(2005), Montemagni et al.(2003), Oflazer et al.(2003) analysis.
J93-2004
The parser by Canisius et al.(2006a) can be considered a rudimentary implementation of constraint satisfaction inference that only uses Cdep constraints.
W06-2602 W06-2924
For our official submission, we used the dependency parser described by Canisius et al.(2006a). In this paper, we present a novel approach to dependency parsing based on constraint satisfaction.
W06-2602 W06-2924
Satisfaction Inference for Dependency Trees The parsing algorithm we used is an adaptation for dependency trees of the constraint satisfaction inference method for sequential output structures proposed by Canisius et al.(2006b). The technique uses standard classifiers to predict a weighted constraint satisfaction problem, the solution to which is the complete dependency tree.
W06-2602 W06-2924
