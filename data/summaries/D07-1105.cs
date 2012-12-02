(Nomoto, 2004) and (Paul et al., 2005) used translation scores, language and other models to select one of the original translations as consensus translation.
P04-1063
• Using the components of the row-vector bm as feature function values for the candidate translation em (m a16 1,...,M), the system prior weights ω can easily be trained using the Minimum Error Rate Training described in (Och, 2003).
J03-1002 P03-1021
Although system combination could be shown to result in substantial improvements in terms of translation quality (Matusov et al., 2006; Sim et al., 2007), not every possible ensemble of translation outputs has the potential to outperform the primary translation system.
E06-1005
on test BLEU BP BLEU BP pair-CI 95% BLEU BP 3 01 – 03 32.98 0.92 33.03 0.93 [ -0.23, +0.34] 33.60 0.93 4 01 – 04 33.44 0.93 33.46 0.93 [ -0.26, +0.29] 34.97 0.94 5 01 – 05 33.07 0.92 33.14 0.93 [ -0.29, +0.43] 34.33 0.93 6 01 – 06 32.86 0.92 33.53 0.93 [+0.26, +1.08] 34.43 0.93 7 01 – 07 33.08 0.93 33.51 0.93 [+0.04, +0.82] 34.49 0.93 8 01 – 08 33.12 0.93 33.47 0.93 [ -0.06, +0.75] 34.50 0.94 9 01 – 09 33.15 0.93 33.22 0.93 [ -0.35, +0.51] 34.68 0.93 10 01 – 10 33.01 0.93 33.59 0.94 [+0.18, +0.96] 34.79 0.94 11 01 – 11 32.84 0.94 33.40 0.94 [+0.13, +0.98] 34.76 0.94 12 01 – 12 32.73 0.93 33.49 0.94 [+0.34, +1.18] 34.83 0.94 13 01 – 13 32.71 0.93 33.54 0.94 [+0.39, +1.26] 34.91 0.94 14 01 – 14 32.66 0.93 33.69 0.94 [+0.58, +1.47] 34.97 0.94 15 01 – 15 32.47 0.93 33.57 0.94 [+0.63, +1.57] 34.99 0.94 16 01 – 16 32.51 0.93 33.62 0.94 [+0.62, +1.59] 35.00 0.94 3.2 Non-Uniform System Prior Weights As pointed out in Section 2.1, a useful property of the MBR-like system selection method is that system prior weights can easily be trained using the Minimum Error Rate Training (Och, 2003).
J03-1002 P03-1021
In (Matusov et al., 2006), pairwise word alignments of the original translation hypotheses were estimated for an enhanced statistical alignment model in order Table 1: Corpus statistics for two Chinese-English text translation sets: ZHEN-05 is a random selection of test data used in NIST evaluations prior to 2006; ZHEN-06 comprises the NIST portion of the Chinese-English evaluation data used in the 2006 NIST machine translation evaluation.
E06-1005
For instance, word alignment models are often trained using the GIZA++ toolkit (Och and Ney, 2003); error minimizing training criteria such as the Minimum Error Rate Training (Och, 2003) are employed in order to learn feature function weights for log-linear models; and translation candidates are produced using phrase-based decoders (Koehn et al., 2003) in combination with n-gram language models (Brants et al., 2007).
D07-1090 J03-1002 N03-1017 P03-1021
Typically, this selection is made based on translation scores, confidence estimations, language and other models (Nomoto, 2004; Paul et al., 2005).
P04-1063
Experimental results were only reported for the METEOR metric (Banerjee and Lavie, 2005).
W05-0909
(2) is equivalent to re-ranking candidate translations according to the Minimum Bayes Risk (MBR) decision rule (Kumar and Byrne, 2004), provided that the system prior weights are used as estimations of the posterior probabilities pa112ea124fa113 for a source sentence f.
N04-1022
All 60 systems applied the MBR decision rule (Kumar and Byrne, 2004), which gave an additional 0.5% gain on average on top of using the maximum aposteriori (MAP) decision rule.
N04-1022
Och. 2003.
J03-1002 P03-1021
The column “pair-CI” shows 95% confidence intervals relative to the primary system using the paired bootstrap re-sampling method (Koehn, 2004).
W04-3250
(Jayaraman and Lavie, 2005) tried to overcome this problem by using confidence scores and language models in order to rank a collection of synthetic combinations of words extracted from the original translation hypotheses.
P05-3026
For instance, changing the training procedure for word alignment models turned out to be most beneficial; for details see (Och and Ney, 2003).
J03-1002 P03-1021
The 95% confidence intervals realtive to uniform weights are computed using the paired bootstrap re-sampling method (Koehn, 2004).
W04-3250
Note that all systems were optimized using a non-deterministic implementation of the Minimum Error Rate Training described in (Och, 2003).
J03-1002 P03-1021
