As described in Gao et al.(2002), headwords are defined as the content words of the sentence.
W02-1032
In our implementation, we use the shrinkage method suggested by Schapire and Singer (1999) and Collins and Koo (2005).
J05-1003
It is shown in Freund et al.(1998) and Collins and Koo (2005) that there exist gradient search procedures that converge to the right solution.
J05-1003
Recently, it has been shown that a linear model estimated using discriminative training methods, such as the boosting and perceptron algorithms, outperforms significantly a traditional word trigram model trained using maximum likelihood estimation (MLE) on several tasks such as speech recognition and Asian language text input (Bacchiani et al.2004; Roark et al.2004; Gao et al.2005; Suzuki and Gao 2005).
H05-1027 H05-1034 N04-4006
21-24. Collins, Michael and Terry Koo 2005.
J05-1003
Suzuki. 2005.
H05-1034
In this study, the LM task for IME is formulated under the framework of linear models (e.g., Duda et al.2001). We use the following notation, adapted from Collins and Koo (2005): • Training data is a set of example input/output pairs.
J05-1003
For each phonetic string A in adaptation training data, we produced a lattice of candidate word strings W using the baseline system described in (Gao et al.2002), which uses a word trigram model trained via MLE on the Nikkei Newspaper corpus.
W02-1032
As suggested by Collins and Koo (2005), this ensures that the contribution of the log-likelihood feature f 0 is well-calibrated with respect to ExpLoss.
J05-1003
Our implementation takes the form of linear interpolation as described in Bacchiani et al.(2004): P(w i |h) = λ P b (w i |h) + (1-λ )P a (w i |h), where P b is the probability of the background model, P a is the probability trained on adaptation data using MLE and the history h corresponds to two preceding words (i.e.
N04-4006
This section gives a brief review of the boosting algorithm, following the description of some recent work (e.g., Schapire and Singer 1999; Collins and Koo 2005).
J05-1003
We therefore applied the techniques described in Collins and Koo (2005) to speed up the training procedure.
J05-1003
