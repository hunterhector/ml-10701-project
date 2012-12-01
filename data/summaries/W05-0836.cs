Metric This paper focuses on the BLEU metric as presented in (Papineni et al., 2002).
P02-1040
Kumar and Byrne (2004) suggest that if any n-grams are not matched then the pairwise BLEU score is set to zero.
N04-1022
Details regarding n-best list generation from decoder output can be found in (Ueffing et al., 2002).
W02-1021
Using the log-linear form to model pλ(e|f) gives us the flexibility to introduce overlapping features that can represent global context while decoding (searching the space of candidate translations) and rescoring (ranking a set of candidate translations before performing the argmax operation), albeit at the cost of the traditional source-channel generative model of translation proposed in (Brown et al., 1993).
J93-2003
Minimum Bayes Risk Decision Rule The Minimum Bayes Risk Decision Rule as proposed by (Mangu et al., 2000) for the Word Error Rate Metric in speech recognition, and (Kumar and Byrne, 2004) when applied to translation, changes the decision rule in (2) to select the translation that has the lowest expected loss E[Loss(e,r)], which can be estimated by considering a weighted Loss between e and the elements of the n-best list, the approximation to E, as described in (Mangu et al., 2000).
N04-1022
In the following, we summarize the optimization algorithm for the unsmoothed error counts presented in (Och, 2003) and the implementation detailed in (Venugopal and Vogel, 2005).
P03-1021
In this paper we will compare and evaluate several aspects of these techniques, focusing on Minimum Error Rate (MER) training (Och, 2003) and Minimum Bayes Risk (MBR) decision rules, within a novel training environment that isolates the impact of each component of these methods.
P03-1021
As discussed in (Och, 2003), the direct translation model represents the probability of target sentence ’English’ e = e1...eI being the translation for a source sentence ’French’ f = f1 ...fJ through an exponential, or log-linear model pλ(e|f) = exp( summationtextm k=1 λk ∗ hk(e,f))summationtext eprime∈E exp( summationtextm k=1 λk ∗ hk(eprime,f)) (1) where e is a single candidate translation for f from the set of all English translations E, λ is the parameter vector for the model, and each hk is a feature function of e and f.
P03-1021
The resulting decision rule is: translλ(f) = argmin e∈Gen(f) summationdisplay eprime∈Gen(f) Loss(e,eprime)pλ(eprime|f) . (4) (Kumar and Byrne, 2004) explicitly consider selecting both e and a, an alignment between the English and French sentences.
N04-1022
• The piecewise linearity observation made in (Papineni et al., 2002) is no longer applicable since we cannot move the log operation into the expected value.
P02-1040
For further information on these parameter settings, confer (Koehn et al., 2003).
N03-1017
Kumar and Byrne (2004) represent this decision explicitly, since the Loss metrics considered in their work evaluate alignment information as well as lexical (word) level output.
N04-1022
The first system is the Pharaoh decoder provided by (Koehn et al., 2003) for the shared data task.
N03-1017
Error Rate Training The predominant approach to reconciling the mismatch between the MAP decision rule and the evaluation metric has been to train the parameters λ of the exponential model to correlate the MAP choice with the maximum score as indicated by the evaluation metric on a development set with known references (Och, 2003).
P03-1021
Under a phrase based translation model (Koehn et al., 2003; Marcu and Wong, 2002), this distinction is important and will be discussed in more detail.
N03-1017 W02-1018
