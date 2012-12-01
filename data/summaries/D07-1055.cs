8. 2 Related Work The most common modeling approach in statistical machine translation is to use a log-linear combination of several sub-models (Och and Ney, 2002).
P02-1038
The MBR hypotheses were generated using the algorithm described in (Ehling et al., 2007) on a 10000-best list.
P07-2026
Once we specified the Bayes decision rule for statistical machine translation, we have to address three problems (Ney, 2001): • the search problem, i.e. how to find the best translation candidate among all possible target language sentences; • the modeling problem, i.e. how to structure the dependencies of source and target language sentences; • the training problem, i.e. how to estimate the free parameters of the models from the training data.
W01-1405
However, as pointed out in (Och, 2003), there is no reason to believe that the resulting parameters are optimal with respect to translation quality measured with the Bleu score.
P03-1021
2 is then: FEB−N(λM1,(ˆeˆI1,fJ1 )) = EλM 1 [BP|ˆI,fJ1 ] · 4productdisplay n=1 EλM 1 [Precn|ˆeˆI1,fJ1 ]1/4 We still have to define the estimators for the expected brevity penalty as well as the expected ngram precision: EλM 1 [BP|ˆI,fJ1 ] = summationdisplay I BP(I, ˆI) · pλM 1 (I|fJ1 ) EλM 1 [Precn|ˆeˆI1,fJ1 ] = (5) summationtext wn1 pλM 1 (wn1|fJ1 )summationtext c minc,C(wn1|ˆeˆI1)} · pλM 1 (c|wn1,fJ1 ) summationtext wn1 pλM 1 (wn1|fJ1 )summationtext c c · pλM 1 (c|wn1,fJ1 ) Here, we use the sentence length posterior probability pλM 1 (I|fJ1 ) as defined in (Zens and Ney, 2006) andthen-gramposteriorprobabilitypλM 1 (wn1|fJ1 )as described in Sec.
W06-3110
Minimum Bayes risk decoding for machine trans524 lation was introduced in (Kumar and Byrne, 2004).
N04-1022
Additionally, we will compare two decision rules, the common maximum a-posteriori (MAP) decision rule and the minimum Bayes risk (MBR) decision rule (Kumar and Byrne, 2004).
N04-1022
Tillmann and Zhang (2006) describe a perceptron style algorithm for training millions of features.
P06-1091
A popular metric for evaluating machine translation quality is the Bleu score (Papineni et al., 2002).
P02-1040
525 In the following, we will discuss the so-called training problem (Ney, 2001): how do we train the free parameters λM1 of the model?
W01-1405
It has certain shortcomings for comparing different machine translation systems, especially if comparing conceptually different systems, e.g. phrase-based versus rule-based systems, as shown in (Callison-Burch et al., 2006).
E06-1032
We define the log-likelihood (LLH) of a target language sentence eI1 given a source language sentence fJ1 as: FML−N(λM1,(eI1,fJ1 )) = Nsummationdisplay n=1 summationdisplay wn1∈eI1 logpλM 1 (wn1|fJ1 ) Here, we use the n-gram posterior probability pλM 1 (wn1|fJ1 ) as defined in (Zens and Ney, 2006).
W06-3110
It measures the loss (or errors) of a candidate translation eI1 assuming the correct translation is eprimeIprime1 . In the following, we will call this decision rule the MBR rule (Kumar and Byrne, 2004).
N04-1022
Therefore, (Och and Ney, 2002; Och, 2003) defined the translation candidate with the minimum word-error rate as pseudo reference translation.
P02-1038 P03-1021
Note that the minimum error rate training (Och, 2003) uses only the target sentence with the maximum posterior probability whereas, here, the whole probability distribution is taken into account.
P03-1021
We can therefore support the claim of (Smith and Eisner, 2006) that MBR tends to have better generalization capabilities.
P06-2101
The current state-of-the-art is to use minimum error rate training (MERT) as described in (Och, 2003).
P03-1021
The posterior probability Pr(eI1|fJ1 ) is modeled directly using a log-linear combination of several models (Och and Ney, 2002): pλM 1 (eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 λmhm(e I1,fJ1 ) parenrightBig summationtext Iprime,eprimeIprime1 exp parenleftBigsummationtextM m=1 λmhm(eprime Iprime1,fJ 1 ) parenrightBig (1) This approach is a generalization of the sourcechannel approach (Brown et al., 1990).
J90-2002 P02-1038
As we would like to avoid this problem, we use the smoothed sentence-level Bleu score as suggested in (Lin and Och, 2004).
C04-1072
There exists a variety of different metrics, e.g., word error rate, position-independent word error rate, BLEU score (Papineni et al., 2002), NIST score (Doddington, 2002), METEOR (Banerjee and Lavie, 2005), GTM (Turian et al., 2003).
P02-1040 W05-0909
In (Och and Ney, 2002), the log-linear weights were tuned to maximize the mutual information criterion (MMI).
P02-1038
An annealed minimum risk approach is presented in (Smith and Eisner, 2006) which outperforms both maximum likelihood and minimum error rate training.
P06-2101
We will show that some achieve significantly better results than the standard minimum error rate training of (Och, 2003).
P03-1021
Further experiments using MBR for Bleu were performed in (Venugopal et al., 2005; Ehling et al., 2007).
P07-2026 W05-0836
The current state-of-the-art is to optimize these parameters with respect to the final evaluation criterion; this is the so-called minimum error rate training (Och, 2003).
P03-1021
We define NλM 1 (wn1,fJ1 ) as in (Zens and Ney, 2006): NλM 1 (wn1,fJ1 ) = summationdisplay I,eI1 I−n+1summationdisplay i=1 pλM 1 (eI1|fJ1 )·δ(ei+n−1i,wn1) (4) The sum over the target language sentences is limited to an N-best list, i.e. the N best translation candidates according to the baseline model.
W06-3110
Shen et al.(2004) compared different algorithms for tuning the log-linear weights in a reranking framework and achieved results comparable to the standard minimum error rate training.
N04-1023
