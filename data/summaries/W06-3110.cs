We use a state-of-the-art phrase-based translation system as described in (Zens and Ney, 2004; Zens et al., 2005).
N04-1033
Och. 2003.
P03-1021
Among all possible target language sentences, we will choose the sentence with the highest probability: ˆeˆI1 = argmax I,eI1 braceleftbigPr(eI 1|f J 1 ) bracerightbig (1) The posterior probability Pr(eI1|fJ1 ) is modeled directly using a log-linear combination of several models (Och and Ney, 2002): Pr(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 λmhm(e I1,fJ1 ) parenrightBig summationtext I′,e′I′1 exp parenleftBigsummationtextM m=1 λmhm(e′ I′1,fJ 1 ) parenrightBig (2) The denominator is a normalization factor that depends only on the source sentence fJ1 . Therefore, we can omit it during the search process.
P02-1038
The model scaling factors λM1 are trained with respect to the final translation quality measured by an error criterion (Och, 2003).
P03-1021
5 Rescoring/Reranking A straightforward application of the posterior probabilities is to use them as additional features in a rescoring/reranking approach (Och et al., 2004).
N04-1021
(Gandrabur and Foster, 2003).
W03-0413
The common phrasebased translation systems, such as (Och et al., 1999; Koehn, 2004), do not use an explicit sentence length model.
N04-1021 W99-0604
As a decision rule, we obtain: ˆeˆI1 = argmax I,eI1 braceleftBigg Msummationdisplay m=1 λmhm(eI1,fJ1 ) bracerightBigg (3) This approach is a generalization of the sourcechannel approach (Brown et al., 1990).
J90-2002
(Gandrabur and Foster, 2003; Ueffing and Ney, 2005).
W03-0413
To measure the translation quality, we use the BLEU score (Papineni et al., 2002) and the NIST score (Doddington, 2002).
P02-1040
This idea has been adopted to estimate confidences for machine translation, e.g. see (Blatz et al., 2003; Ueffing et al., 2003; Blatz et al., 2004).
C04-1046
Length Posterior Probability The common phrase-based translation systems, such as (Och et al., 1999; Koehn, 2004), do not use an explicit sentence length model.
N04-1021 W99-0604
