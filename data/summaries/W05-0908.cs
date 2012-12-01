Phrase-extraction follows Och et al.(1999) and was implemented by the authors: First, the word aligner is applied in both translation directions, and the intersection of the alignment matrices is built.
W99-0604
Work on discriminative reranking has been reported before by Och and Ney (2002), Och et al.(2004), and Shen et al.(2004). The main purpose of our reranking experiments is to have a system that can easily be adjusted to yield system variants that differ at controllable amounts.
N04-1021 N04-1023 P02-1038
Furthermore, we consider an F-score measure that is adapted from dependency-based parsing (Crouch et al., 2002) and sentence-condensation (Riezler et al., 2003).
N03-1026
In the area of statistical machine translation (SMT), recently a combination of the BLEU evaluation metric (Papineni et al., 2001) and the bootstrap method for statistical significance testing (Efron and Tibshirani, 1993) has become popular (Och, 2003; Kumar and Byrne, 2004; Koehn, 2004b; Zhang et al., 2004).
J03-1002 N04-1021 N04-1022 P03-1021 W04-3250
Applications of this test to natural language processing problems can be found in Chinchor et al.(1993). In our case of assessing statistical significance of result differences between SMT systems, the test statistic of interest is the absolute value of the difference in BLEU, NIST, or F-scores produced by two systems on the same test set.
J93-3001
Small Result Differences by Intrinsic Evaluations Metrics The intrinsic evaluation measures used in our experiments are the well-known BLEU (Papineni et al., 2001) and NIST (Doddington, 2002) metrics, and an F-score measure that adapts evaluation techniques from dependency-based parsing (Crouch et al., 2002) and sentence-condensation (Riezler et al., 2003) to machine translation.
N03-1026
Discriminative reranking on a 1000-best list of translations of the SMT system uses an lscript1 regularized log-linear model that combines a standard maximum-entropy estimator with an efficient, incremental feature selection technique for lscript1 regularization (Riezler and Vasserman, 2004).
W04-3223
Our system is a re-implementation of the phrase-based system described in Koehn (2003), and uses publicly available components for word alignment (Och and Ney, 2003)1, decoding (Koehn, 2004a)2, language modeling (Stolcke, 2002)3 and finite-state processing (Knight and Al-Onaizan, 1999)4.
J03-1002 N03-1017 N04-1021 P02-1038 P03-1021 W04-3250
