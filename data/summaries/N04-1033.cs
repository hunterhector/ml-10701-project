The alignment template system uses discriminative training of the model scaling factors as described in (Och and Ney, 2002).
P02-1038
Some examples are the alignment template system in (Och et al., 1999; Och and Ney, 2002) that we used for comparison.
P02-1038 W99-0604
In statistical machine translation, we are given a source language (‘French’) sentence fJ1 = f1 :::fj :::fJ, which is to be translated into a target language (‘English’) sentence eI1 = e1 :::ei :::eI: Among all possible target language sentences, we will choose the sentence with the highest probability: ˆeI1 = argmax eI1 'Pr(eI 1jf J 1 ) “ (1) = argmax eI1 'Pr(eI 1)¢Pr(f J 1 je I 1) “ (2) The decomposition into two knowledge sources in Equation 2 is known as the source-channel approach to statistical machine translation (Brown et al., 1990).
J90-2002
In (Koehn et al., 2003), various aspects of phrase-based systems are compared, e.g. the phrase extraction method, the underlying word alignment model, or the maximum phrase length.
N03-1017
This method has the advantage that it is not limited to the model scaling factors as the method described in (Och, 2003).
P03-1021
The alignment template system (Och et al., 1999) is similar to the system described in this work.
W99-0604
For details, see (Tillmann and Ney, 2003).
J03-1005
Alternatively, one can train them with respect to the final translation quality measured by some error criterion (Och, 2003).
P03-1021
BP(fJ1 ;eI1;A) = n‡ fj2j1 ;ei2i1 · : 8(j;i) 2 A : j1 • j • j2 $ i1 • i • i2 ^9(j;i) 2 A : j1 • j • j2 ^i1 • i • i2 o This criterion is identical to the alignment template criterion described in (Och et al., 1999).
W99-0604
Och. 2003.
P03-1021
(Marcu and Wong, 2002) presents a joint probability model for phrase-based translation.
W02-1018
Using a log-linear model (Och and Ney, 2002), we obtain: Pr(eI1jfJ1 ) = exp ˆ MX m=1 ‚mhm(eI1;fJ1 ) ! ¢Z(fJ1 ) Here, Z(fJ1 ) denotes the appropriate normalization constant.
P02-1038
The model scaling factors are optimized on the development corpus with respect to mWER similar to (Och, 2003).
P03-1021
