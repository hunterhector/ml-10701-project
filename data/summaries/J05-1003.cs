However there has recently been much work drawing connections between the two methods (Friedman, Hastie, and Tibshirani 2000; Lafferty 1999; Duffy and Helmbold 1999; Mason, Bartlett, and Baxter 1999; Lebanon and Lafferty 2001; Collins, Schapire, and Singer 2002); in this section we review this work.
P02-1034 P02-1062 W02-1001
The central question in learning is how to set the parameters ¯a, given the training examples b ðx 1, y 1 Þ,ðx 2, y 2 Þ, :::,ðx n, y n Þ À . Logistic regression and boosting involve different algorithms and criteria for training the parameters ¯a, but recent work (Friedman, Hastie, and Tibshirani 2000; Lafferty 1999; Duffy and Helmbold 1999; Mason, Bartlett, and Baxter 1999; Lebanon and Lafferty 2001; Collins, Schapire, and Singer 2002) has shown that the methods have strong similarities.
P02-1034 P02-1062 W02-1001
Model C20 40 Words (2,245 sentences) LR LP CBs 0 CBs 2 CBs Charniak 1997 87.5% 87.4% 1.00 62.1% 86.1% Collins 1999 88.5% 88.7% 0.92 66.7% 87.1% Charniak 2000 90.1% 90.1% 0.74 70.1% 89.6% ExpLoss 90.2% 90.4% 0.73 71.2% 90.2% Model C20 100 Words (2,416 sentences) LR LP CBs 0 CBs 2 CBs Charniak 1997 86.7% 86.6% 1.20 59.5% 83.2% Ratnaparkhi 1998 86.3% 87.5% 1.21 60.2% — Collins 1999 88.1% 88.3% 1.06 64.0% 85.1% Charniak 2000 89.6% 89.5% 0.88 67.6% 87.7% ExpLoss 89.6% 89.9% 0.86 68.7% 88.3% Collins and Koo Discriminative Reranking for NLP 5.4.2 The Effect of the S i,j Weights on Examples.
A00-2018
Johnson et al.(1999) and Riezler et al.(2002) do not use a feature selection technique, employing instead an objective function which includes a Table 4 Values of Savings (a, b) for various values of a, b.
P02-1035 P99-1069
6. Related Work 6.1 History-Based Models with Complex Features Charniak (2000) describes a parser which incorporates additional features into a previously developed parser, that of Charniak (1997).
A00-2018
Maximum-entropy models are a very popular method within the computational linguistics community; see, for example, Berger, Della Pietra, and Della Pietra (1996) for an early article which introduces the models and motivates them.
J96-1002
See also Sha and Pereira (2003) for more recent work on CRFs.
N03-1028
Shen, Sarkar, and Joshi (2003) describe support vector machine approaches to ranking problems and apply support vector machines (SVMs) using tree-adjoining grammar (Joshi, Levy, and Takahashi 1975) features to the parsing data sets we have described in this article, with good empirical results.
W03-1012
This is a problem for parameter estimation, in which an estimate of the denominator is required, and Monte Carlo methods have been proposed (Della Pietra, Della Pietra, and Lafferty 1997; Abney 1997; Rosenfeld 1997) as a technique for estimation of this value.
J97-4005
Whereas the feature selection approach leads to around 11,000 (2%) of the features in our model having nonzero parameter values, log-linear models with Gaussian priors typically have very few nonzero parameters (see, e.g., Riezler and Vasserman 2004).
W04-3223
Ratnaparkhi (1997) describes the use of maximum-entropy techniques applied to parsing.
W97-0301
For a full derivation of the modified updates and for quite technical convergence proofs, see Collins, Schapire and Singer (2002).
P02-1034 P02-1062 W02-1001
In particular, previous work (Ratnaparkhi, Roukos, and Ward 1994; Abney 1997; Della Pietra, Della Pietra, and Lafferty 1997; Johnson et al.1999; Riezler et al.2002) has investigated the use of Markov random fields (MRFs) or log-linear models as probabilistic models with global features for parsing and other NLP tasks.
J97-4005 P02-1035 P99-1069 W97-0301
Collins and Koo Discriminative Reranking for NLP Della Pietra 1996; Della Pietra, Della Pietra, and Lafferty 1997), or conjugate gradient methods (Malouf 2002).
W02-2018
The method gives very similar accuracy to the model of Charniak (2000), which also uses a rich set of initial features in addition to Charniak’s (1997) original model.
A00-2018
The boosting approach to ranking has been applied to named entity segmentation (Collins 2002a) and natural language generation (Walker, Rambow, and Rogati 2001).
N01-1003 P02-1034 P02-1062 W02-1001
2. History-Based Models Before discussing the reranking approaches, we describe history-based models (Black et al.1992). They are important for a few reasons.
H92-1026
Similar methods have also been proposed for machine translation (Och and Ney 2002) and language understanding in dialogue systems (Papineni, Roukos, and Ward 1997, 1998).
P02-1038
More recent work (McCallum 2003; Zhou et al.2003; Riezler and Vasserman 2004) has considered methods for speeding up the feature selection methods described in Berger, Della Pietra, and Della Pietra (1996), Ratnaparkhi (1998), and Della Pietra, Della Pietra, and Lafferty (1997).
J96-1002 W03-1020 W04-3223 W97-0301
Log-Linear Models Ratnaparkhi, Roukos, and Ward (1994), Johnson et al.(1999), and Riezler et al.(2002) suggest training log-linear models (i.e., the LogLoss function in equation (9)) for parsing problems.
P02-1035 P99-1069
The model in Charniak (2000) is quite different, however.
A00-2018
The boosting algorithm we use is related to the generalization of boosting methods to ranking problems in Freund et al.(1998); we also introduce an approach related to the conditional log-linear models of Ratnaparkhi, Roukos, and Ward (1994), Papineni, Roukos, and Ward (1997, 1998), Johnson et al.(1999), Riezler et al.(2002), and Och and Ney (2002).
P02-1035 P02-1038 P99-1069 W97-0301
Section 3 describes previous work (Friedman, Hastie, and Tibshirani 2000; Duffy and Helmbold 1999; Mason, Bartlett, and Baxter 1999; Lebanon and Lafferty 2001; Collins, Schapire, and Singer 2002) that derives connections between boosting and maximum-entropy models for the simpler case of classification problems; this work forms the basis for the reranking methods.
P02-1034 P02-1062 W02-1001
Even with large values of k in the approach of McCallum (2003) and Riezler and Vasserman (2004) (e.g., k = 1,000), the approach we describe is likely to be at least as efficient as these alternative approaches.
W04-3223
As suggested by Ratnaparkhi, Roukos, and Ward (1994) and Johnson et al.(1999), the conditional probability of x i,q being the correct parse for the ith sentence is defined as Pðx i,q j s i, ¯aÞ¼ e Fðx i,q, ¯aÞ P n i j¼1 e Fðx i,j, ¯aÞ Given a new test sentence s, with parses x j for j =1,:::, N, the most likely tree is arg max x j e Fðx j,¯aÞ P N q¼1 e Fðx q,¯aÞ ¼ arg max x j Fðx j, ¯aÞ Hence once the parameters are trained, the ranking function is used to order candidate trees for test examples.
P99-1069
In terms of simplicity, the methods in McCallum (2003) and Riezler and Vasserman (2004) require selection of a number of free parameters governing the behavior of the algorithm: the value for k, the value for a regularizer constant (used in both McCallum [2003] and Riezler and Vasserman [2004]), and the precision with which the model is optimized at each stage of feature selection (McCallum [2003] describes using ‘‘just a few BFGS iterations’’ at each stage).
W04-3223
Appendix B gives a sketch of one such approach, which is based on results from Collins, Schapire, and Singer (2002).
P02-1034 P02-1062 W02-1001
section 6.4 we discuss our approach in comparison to these earlier methods for feature selection, as well as the more recent work of McCallum (2003); Zhou et al.(2003); and Riezler and Vasserman (2004).
W03-1020 W04-3223
Until now, we have defined BestLossðk, ¯aÞ to be the minimum of the loss given that the kth feature is updated an optimal amount: BestLossðk, ¯aÞ¼min d LogLossðUpdð¯a,k,dÞÞ In this section we sketch a different approach, based on results from Collins, Schapire, and Singer (2002), which leads to an algorithm very similar to that for ExpLoss in Figures 3 and 4.
P02-1034 P02-1062 W02-1001
Collins (2002b) gives convergence proofs for the methods; Collins (2002a) directly compares the boosting and perceptron approaches on a named entity task; and Collins and Duffy (2001, 2002) use a reranking approach with kernels, which allow representations of parse trees or labeled sequences in very-high-dimensional spaces.
P02-1034 P02-1062 W02-1001
Altun, Hofmann, and Johnson (2003) describe how dynamic programming methods can be used to calculate gradients of the ExpLoss function even in cases in which the set of candidates again includes all possible tagged sequences, a set which grows exponentially in size with the length of the sentence being tagged.
W03-1019
5. Experimental Evaluation 5.1 Generation of Parsing Data Sets We used the Penn Wall Street Journal treebank (Marcus, Santorini, and Marcinkiewicz 1993) as training and test data.
J93-2004
In contrast, the feature selection method of Berger, Della Pietra, and Della Pietra (1996), also described in section 3.3, would involve updating parameter values for all selected features at step 2b.
J96-1002
The additional features are incorporated using a method inspired by maximum-entropy models (e.g., the model of Ratnaparkhi [1997]).
W97-0301
Results in Altun, Johnson, and Hofmann (2003) suggest that the choice of ExpLoss versus LogLoss does not have a major impact on accuracy for the tagging task in question.
W03-1019
See Ratnaparkhi (1997) for one example of a method using this approach.
W97-0301
This is around 1,000 times as much computation as that required for the efficient boosting algorithm applied to our data, suggesting that the feature selection methods in Berger, Della Pietra, and Della Pietra (1996), Ratnaparkhi (1998), and Della Pietra, Della Pietra, and Lafferty (1997) are not sufficiently efficient for the parsing task.
J96-1002 W97-0301
The Gaussian prior (i.e., the P k a 2 k =7 2 k penalty) has been found in practice to be very effective in combating overfitting of the parameters to the training data (Chen and Rosenfeld 1999; Johnson et al.1999; Lafferty, McCallum, and Pereira 2001; Riezler et al.2002). The function in equation (28) can be optimized using variants of gradient descent, which in practice require tens or at most hundreds of passes over the training data (see, e.g., Sha and Pereira 2003).
N03-1028 P02-1035 P99-1069
See Collins (2002a, 2002b) and Collins and Duffy (2001, 2002) for applications of the perceptron algorithm.
P02-1034 P02-1062 W02-1001
See Collins (2002a) for an application of the boosting approach to named entity recognition, and Walker, Rambow, and Rogati (2001) for the application of boosting techniques for ranking in the context of natural language generation.
N01-1003 P02-1034 P02-1062 W02-1001
We applied the boosting method to parsing the Wall Street Journal (WSJ) treebank (Marcus, Santorini, and Marcinkiewicz 1993).
J93-2004
Selection Methods A number of previous papers (Berger, Della Pietra, and Della Pietra 1996; Ratnaparkhi 1998; Della Pietra, Della Pietra, and Lafferty 1997; McCallum 2003; Zhou et al.2003; Riezler and Vasserman 2004) describe feature selection approaches for log-linear models applied to NLP problems.
J96-1002 W03-1020 W04-3223 W97-0301
Zhou et al.(2003) use a different heuristic that avoids having to recompute the gain for every feature at every iteration.
W03-1020
Riezler and Vasserman (2004) test a variety of values for k, finding that k = 100 gives optimal performance.
W04-3223
In the parsing problem x is a sentence, and 1 Note, however, that log-linear models which employ regularization methods instead of feature selection—see, for example, Johnson et al.(1999) and Lafferty, McCallum, and Pereira (2001)—are likely to be comparable in terms of efficiency to our feature selection approach.
P99-1069
Our features are in many ways similar to those of Charniak (2000).
A00-2018
Feature selection methods have been proposed in the maximum-entropy literature by several authors (Ratnaparkhi, Roukos, and Ward 1994; Berger, Della Pietra, and Della Pietra 1996; Della Pietra, Della Pietra, and Lafferty 1997; Papineni, Roukos, and Ward 1997, 1998; McCallum 2003; Zhou et al.2003; Riezler and Vasserman 2004).
J96-1002 W03-1020 W04-3223
Earlier work (Berger, Della Pietra, and Della Pietra 1996; Ratnaparkhi 1998; Della Pietra, Della Pietra, and Lafferty 1997) suggested methods that added a feature at a time to the model and updated all parameters in the current model at each step (for more detail, see section 3.3). 60 Computational Linguistics Volume 31, Number 1 61 Assuming that selection of a feature takes one pass over the training set and that fitting a model takes p passes over the training set, these methods require f C2ðp +1Þ passes over the training set, where f is the number of features selected.
J96-1002 W97-0301
McCallum (2003) and Riezler and Vasserman (2004) describe approaches that add k features at each step, where k is some constant greater than one.
W04-3223
The earlier methods for maximum-entropy feature selection methods (Ratnaparkhi, Roukos, and Ward 1994; Berger, Della Pietra, and Della Pietra 1996; Della Pietra, Della Pietra, and Lafferty 1997; Papineni, Roukos, and Ward 1997, 1998) require several full passes over the training set for each round of feature selection, suggesting that at least for the parsing data, the improved boosting algorithm is several orders of magnitude more efficient.
J96-1002
The most basic approach—for example see Ratnaparkhi, Roukos, and Ward (1994) and Berger, Della Pietra, and Della Pietra (1996)—involves selection of a single feature at each iteration, followed by an update to the entire model, as follows: Step 1: Throughout the algorithm, maintain a set of active features.
J96-1002
Log-Linear Models Abney (1997) describes the application of log-linear models to stochastic headdriven phrase structure grammars (HPSGs).
J97-4005
Results from Collins, Schapire and Singer (2002) show that under these definitions the following guarantee holds: LogLossðUpdð¯a,k, BestWtðk, ¯aÞÞÞ C20 BestLossðk, ¯aÞ So it can be seen that the update from ¯a to Updð¯a, k, BestWtðk, ¯aÞÞ is guaranteed to decrease LogLoss by at least ﬃﬃﬃﬃﬃﬃﬃﬃ W þ k q C0 ﬃﬃﬃﬃﬃﬃﬃﬃ W C0 k qC16C17 2 . From these results, the algorithms in Figures 3 and 4 could be altered to take the revised definitions of W þ k and W C0 k into account.
P02-1034 P02-1062 W02-1001
First, several of the best-performing parsers on the WSJ treebank (e.g., Ratnaparkhi 1997; Charniak 1997, 2000; Collins 1997, 1999; Henderson 2003) are cases of history-based models.
A00-2018 N03-1014 P97-1003 W97-0301
In the next section we describe feature selection methods, as described in Berger, Della Pietra, and Della Pietra (1996) and Della Pietra, Della Pietra, and Lafferty (1997).
J96-1002
Altun, Hofmann, and Johnson (2003) and Altun, Johnson, and Hofmann (2003) describe experiments on tagging tasks using the ExpLoss function, in contrast to the LogLoss function used in Lafferty, McCallum, and Pereira (2001).
W03-1019
