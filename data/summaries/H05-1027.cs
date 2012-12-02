Sample Risk 3.1 Problem Definition We follow the general framework of linear discriminant models described in (Duda et al.2001). In the rest of the paper we use the following notation, adapted from Collins (2002).
W02-1001
Gao et al.2002), presumably due to the large amount of training data we used, and to the similarity between the training and the test data.
W02-1032
See (Suzuki and Gao 2005) for a detailed report.
H05-1034
Language modeling (LM) is fundamental to a wide range of applications, such as speech recognition and Asian language text input (Jelinek 1997; Gao et al.2002). The traditional approach uses a parametric model with maximum likelihood estimation (MLE), usually with smoothing methods to deal with data sparseness problems.
W02-1032
We also compared the MSR algorithm to two of the state-of-the-art discriminative training methods: Boosting in Row 3 is an implementation of the improved algorithm for the boosting loss function proposed in (Collins 2000), and Perceptron in Row 4 is an implementation of the averaged perceptron algorithm described in (Collins 2002).
W02-1001
Line Search Our implementation of a grid search is a modified version of that proposed in (Och 2003).
P03-1021
Work Discriminative models have recently been proved to be more effective than generative models in some NLP tasks, e.g., parsing (Collins 2000), POS tagging (Collins 2002) and LM for speech recognition (Roark et al.2004). In particular, the linear models, though simple and non-probabilistic in nature, are preferred to their probabilistic coun215 terpart such as logistic regression.
W02-1001
The modifications are made to deal with the efficiency issue due to the fact that there is a very large number of features and training samples in our task, compared to only 8 features used in (Och 2003).
P03-1021
Gao et al.2002). Similar to speech recognition, IME is viewed as a Bayes decision problem.
W02-1032
For each A, we produced a word lattice using the baseline system described in (Gao et al.2002), which uses a word trigram model trained via MLE on anther 400,000-sentence subset of the Nikkei Newspaper corpus.
W02-1032
The basic training algorithm described in Section 3.2 follows the general framework of multidimensional optimization (e.g., Press et al.1992). The line search is an extension of that described in (Och 2003; Quirk et al.2005. The extension lies in the way of handling large number of features and training samples.
P03-1021 P05-1034
