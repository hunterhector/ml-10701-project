Special emphasis is placed on linear classifiers with data-defined kernels for reranking (Henderson and Titov, 2005), because they do not require any additional domain knowledge not already encoded in the probabilistic model, and they have demonstrated significant improvement over the baseline probabilistic model for the parse reranking task.
P05-1023
The n-best parsing algorithm (Huang and Chiang, 2005) can be used to efficiently produce candidate lists as large as 106 R P F1∗ CB 0C 2C CO99 88.1 88.3 88.2 1.06 64.0 85.1 TK 88.6 88.9 88.7 0.99 66.5 86.3 TK-Estim 89.0 89.5 89.2 0.91 66.6 87.4 * F1 for previous models may have rounding errors.
W05-1506
We apply the same method as used in the TRK-Estim model above to the Tree Kernel (Collins and Duffy, 2002), which we call the TK-Estim model.
P02-1034
The reranking approach is widely used in parsing (Collins and Koo, 2005; Koo and Collins, 2005; Henderson and Titov, 2005; Shen and Joshi, 2003) as well as in other structured classification problems.
H05-1064 J05-1003 N03-1014 P05-1023 W03-0402
For the last set of experiments, we used the probabilistic model described in (Collins, 1999) (model 2), and the Tree Kernel (Collins and Duffy, 2002).
P02-1034
We trained the Voted Perceptron (VP) modification described in (Henderson and Titov, 2005) with the TOP Reranking kernel.
P05-1023
The results for the MBR decoding method (TKEstim), defined in section 3.3, along with the standard Tree Kernel VP results (Collins and Duffy, 2002) (TK) and the probabilistic baseline (Collins, 1999) (CO99) are presented in table 3.
P02-1034
Evaluation To perform empirical evaluations of the proposed methods, we considered the task of parsing the Penn Treebank Wall Street Journal corpus (Marcus et al., 1993).
J93-2004
563 This parsing model is a good candidate for our experiments because it achieves state-of-the-art results on the standard Wall Street Journal (WSJ) parsing problem (Henderson, 2003), and datadefined kernels derived from this parsing model have recently been used with the Voted Perceptron algorithm on the WSJ parsing task, achieving a significant improvement in accuracy over the neural network parser alone (Henderson and Titov, 2005).
N03-1014 P05-1023
The probabilistic model of parsing in (Henderson, 2003) has two levels of parameterization.
N03-1014
Standard measures of parsing accuracy, plus complete match accuracy, are shown in table 1.3 As the baselines, the table includes the results of the standard TOP reranking kernel (TRK) (Henderson and Titov, 2005) and the baseline probabilistic model (SSN) (Henderson, 2003).
N03-1014 P05-1023
The resulting accuracies of this model are presented in table 2, together with results of the TOP Reranking kernel VP (Henderson and Titov, 2005) and the SSN probabilistic model (Henderson, 2003).
N03-1014 P05-1023
with TOP Kernels for Reranking The TOP Reranking kernel was defined in (Henderson and Titov, 2005), as a generalization of the TOP kernel (Tsuda et al., 2002) proposed for binary classification tasks.
P05-1023
We replicated the parse reranking experimental setup used for the evaluation of the Tree Kernel in (Collins and Duffy, 2002), where the candidate list was provided by the generative probabilistic model (Collins, 1999) (model 2).
P02-1034
Use of probability estimates is not a serious limitation of this approach because in practice candidates are normally provided by some probabilistic model and its probability estimates are used as additional features in the reranker (Collins and Koo, 2005; Shen and Joshi, 2003; Henderson and Titov, 2005).
H05-1064 J05-1003 P05-1023 W03-0402
We used a publicly available tagger (Ratnaparkhi, 1996) to provide the part-of-speech tags for each word in the sentence.
W96-0213
It is also interesting to note that the best result on the validation set for estimation 4We measured significance of all the experiments in this paper with the randomized significance test (Yeh, 2000).
C00-2137
1The first component logP(x, y|ˆθ) is not in the strict sense part of the Fisher score, but usually added to kernel features in practice (Henderson and Titov, 2005).
P05-1023
However, their approach is limited to binarized PCFG models and, consequently, is not applicable to state-of-the-art parsing methods (Charniak and Johnson, 2005; Henderson, 2004; Collins, 2000).
P04-1013 P05-1022
565 R P F1 Henderson, 2003 88.8 89.5 89.1 Henderson&Titov, 2005 89.1 90.1 89.6 TRK-Estim 89.5 90.5 90.0 Table 2: Percentage labeled constituent recall (R), precision (P), combination of both (F1) on the testing set.
N03-1014 P05-1023
A very different use of loss functions was considered in the areas of signal processing and machine translation, where direct minimization of expected loss (Minimum Bayes Risk decoding) on word sequences was considered (Kumar and Byrne, 2004; Stolcke et al., 1997).
N04-1022
A publicly available efficient implementation of the Tree Kernel was utilized to speed up computations (Moschitti, 2004).
P04-1043
We replicate completely the setup of experiments in (Henderson and Titov, 2005).
P05-1023
2In (Shen and Joshi, 2003) it was proposed to use an ensemble of SVMs trained the Wall Street Journal corpus, but the generalization performance of the resulting classifier might be compromised in this approach.
W03-0402
We trained VP using the same parameters for the Tree Kernel and probability feature weighting as described in (Collins and Duffy, 2002).
P02-1034
To tackle this problem, several approaches have been proposed to accommodate loss functions in learning algorithms (Tsochantaridis et al., 2004; Taskar et al., 2004; Henderson and Titov, 2005).
P05-1023 W04-3201
For a detailed description of the experiment setup, we refer the reader to (Henderson and Titov, 2005).
P05-1023
The TOP reranking kernel has been demonstrated to perform better than the Fisher kernel for the parse reranking task (Henderson and Titov, 2005).
P05-1023
This linear classifier has been shown to converge, assuming estimation of the discriminative probability in the candidate list can be in the form of the logistic sigmoid (Titov and Henderson, 2005): P(x, y)summationtext yprime∈G(x) P(x, yprime) ≈ (10) 1 1 + exp(−wstarT φTKˆθ (x, y)) for some choice of the decision vector w = wstar with the first component equal to one.
P05-1023
We apply them to the parse reranking problem where the baseline probabilistic model is a neural network parser (Henderson, 2003), and to parse reranking of candidates provided by the (Collins, 1999) model.
N03-1014
These experimental results demonstrate that the loss approximation reranking approaches proposed in this paper demonstrate significant improvement over the baseline models, achieving about the same relative error reduction as previously achieved with data-defined kernels (Henderson and Titov, 2005).
P05-1023
For our first set of experiments, we choose to use a publicly available neural network based probabilistic model of parsing (Henderson, 2003).
N03-1014
The only attempt to use Minimum Bayes Risk (MBR) decoding in parsing was made in (Goodman, 1996), where a parsing algorithm for constituent recall minimization was constructed.
P96-1024
