We use the union, re ned and intersection heuristics de ned in (Och and Ney, 2003) which are used in conjunction with IBM Model 4 as the baseline in virtually all recent work on word alignment.
J03-1002 P03-1021
Examples of this perspective include (Liu et al., 2005; Ittycheriah and Roukos, 2005; Moore, 2005; Taskar et al., 2005).
H05-1010 H05-1011 H05-1012 P05-1057
Like Ittycheriah and Roukos (2005), we converted the alignment discriminative training corpus links into a special corpus consisting of parallel sentences where each sentence consists only of a single word involved in the link.
H05-1012
Cherry and Lin (2003) and Taskar et al.(2005) compared their results with Model 4 using intersection by looking at AER (with the Sure versus Possible link distinction), and restricted themselves to considering 1-to-1 alignments.
H05-1010 P03-1012
Och (2003) has described an ef cient exact one-dimensional error minimization technique for a similar search problem in machine translation.
J03-1002 P03-1021
4 Semi-Supervised Training for Word Alignments Intuitively, in approximate EM training for Model 4 (Brown et al., 1993), the E-step corresponds to calculating the probability of all alignments according to the current model estimate, while the M-step is the creation of a new model estimate given a probability distribution over alignments (calculated in the E-step).
J93-2003
Callison-Burch et al.(2004) showed in their work on combining alignments of lower and higher quality that the alignments of higher quality should be given a much higher weight than the lower quality alignments.
P04-1023
Moore. 2005.
H05-1011
MODEL 4 REFINED 30.63 76.4 F/E EMD 2 REFINED 31.56 81.2 Table 8: Evaluation of Translation Quality with the baseline (with the exception of (Moore, 2005)).
H05-1011
We rst recast the problem of estimating the IBM models (Brown et al., 1993) in a discriminative framework, which leads to an initial increase in word-alignment accuracy.
J93-2003
The most widely applied training procedure for statistical machine translation IBM model 4 (Brown et al., 1993) unsupervised training followed by post-processing with symmetrization heuristics (Och and Ney, 2003) yields low quality word alignments.
J03-1002 J93-2003 P03-1021
An additional translation set called the Maximum BLEU set is employed by the SMT system to train the weights associated with the components of its log-linear model (Och, 2003).
J03-1002 P03-1021
We run Maximum BLEU (Och, 2003) for 25 iterations individually for each system.
J03-1002 P03-1021
For each training direction, we run GIZA++ (Och and Ney, 2003), specifying 5 iterations of Model 1, 4 iterations of the HMM model (Vogel et al., 1996), and 4 iterations of Model 4.
C96-2141 J03-1002 P03-1021
However, union and rened alignments, which are many-to-many, are what are used to build competitive phrasal SMT systems, because intersection performs poorly, despite having been shown to have the best AER scores for the French/English corpus we are using (Och and Ney, 2003).
J03-1002 P03-1021
The only previous discriminative approach which has been shown to produce translations of similar or better quality to those produced by the symmetrized baseline was (Ittycheriah and Roukos, 2005).
H05-1012
Callison-Burch et al.(2004) examined the issue of semi-supervised training for word alignment, but under a scenario where they simulated suf cient gold standard word alignments to follow an approach similar to Nigam et al.(2000). We do not have enough labels for this approach.
P04-1023
Alignment Search Algorithm Brown et al.(1993) introduced operations de ning a hillclimbing search appropriate for Model 4.
J93-2003
