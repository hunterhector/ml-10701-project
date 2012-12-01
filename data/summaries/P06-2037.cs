We have computed the BLEU score (accumulated up to 4-grams) (Papineni et al., 2001), the NIST score (accumulated up to 5-grams) (Doddington, 2002), the General Text Matching (GTM) F-measure (e = 1,2) (Melamed et al., 2003), and the METEOR measure (Banerjee and Lavie, 2005).
N03-2021 W05-0909
We used the GIZA++ SMT Toolkit4 (Och and Ney, 2003) to generate word alignments We applied the phraseextract algorithm, as described by Och (2002), on the Viterbi alignments output by GIZA++.
J03-1002
The discussion of the significance of the results will be based on the BLEU score, for which we computed a bootstrap resampling test of significance (Koehn, 2004b).
W04-3250
Although moderate, this boost in performance is statistically significant according to the bootstrap resampling test described by Koehn (2004b) and applied to the BLEU metric.
W04-3250
We measured the statistical signficance of the overall improvement in BLEU.n4 attained with respect to the baseline results by applying the bootstrap resampling technique described by Koehn (2004b).
W04-3250
Regarding the arg-max search, we used the Pharaoh beam search decoder (Koehn, 2004a), which naturally fits with the previous tools.
W04-3250
Brown et al.(1988) suggested that MT can be statistically approximated to the transmission of information through a noisy channel.
C88-1016
