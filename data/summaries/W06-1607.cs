(Zens and Ney, 2004) describe a “noisy-or” combination: p(sj|˜t) = 1−p(¯sj|˜t) ≈ 1− ˜Iproductdisplay i=1 (1−p(sj|ti)) where ¯sj is the probability that sj is not in the translation of ˜t, and p(sj|ti) is a lexical probability.
N04-1033
As described above, (Zens and 57 Ney, 2004) and (Koehn et al., 2005) use two different variants of glass-box smoothing (which they call “lexical smoothing”) over the phrasetable, and combine the resulting estimates with pure relativefrequency ones in a loglinear model.
N04-1033
For phrase-based SMT, the use of smoothing to avoid zero probabilities during phrase induction is reported in (Marcu and Wong, 2002), but no details are given.
W02-1018
Moore (2004) has found that smoothing to correct overestimated IBM1 lexical probabilities for rare words can improve word-alignment performance.
P04-1066
This is the traditional approach for glass-box smoothing (Koehn et al., 2003; Zens and Ney, 2004).
N03-1017 N04-1033
Moore. 2004.
P04-1066
Langlais (2005) reports negative results for synonym-based smoothing of IBM2 lexical probabilities prior to extracting phrases for phrasebased SMT.
W05-0824
In fact, a limitation of the experiments described in this paper is that the loglinear weights for the glass-box techniques were optimized for BLEU using Och’s algorithm (Och, 2003), while the linear weights for 55 black-box techniques were set heuristically.
P03-1021
Traditionally, maximum-likelihood estimation from relative frequencies is used to obtain conditional probabilities (Koehn et al., 2003), eg, p(˜s|˜t) = c(˜s,˜t)/summationtext˜s c(˜s,˜t) (since the estimation problems for p(˜s|˜t) and p(˜t|˜s) are symmetrical, we will usually refer only to p(˜s|˜t) for brevity).
N03-1017
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ∝ exp bracketleftBiggsummationdisplay i λifi(s,t,a) bracketrightBigg where each fi(s,t,a) is a feature function, and weights λi are set using Och’s algorithm (Och, 2003) to maximize the system’s BLEU score (Papineni et al., 2001) on a development corpus.
P03-1021
The features used in this study are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and trigram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit (Stolcke, 2002).
N03-1017
To derive the joint counts c(˜s,˜t) from which p(˜s|˜t) and p(˜t|˜s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
J93-2003 N03-1017
The idea is similar in spirit to Collins’ backoff method for prepositional phrase attachment (Collins and Brooks, 1995).
W95-0103
(Zens and Ney, 2004) obtain p(sj|ti) from smoothed relative-frequency estimates in a wordaligned corpus.
N04-1033
