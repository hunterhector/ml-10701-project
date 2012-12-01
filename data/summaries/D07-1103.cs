Moore(2004)commentsthatthep-valueforthese tables under Fisher’s exact test is 1/N.
W04-3243
The phrase translation model probabilities are smoothed according to one of several techniques as described in (Foster et al., 2006) and identified in the discussion below.
W06-1607
These joint counts are estimated using the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
J93-2003 N03-1017
Moore. 2004.
W04-3243
In addition, a number of different phrasetable smoothing algorithms were used: no smoothing, Good-Turing smoothing, Kneser-Ney 3 parameter smoothing and the loglinear mixture involving two features called Zens-Ney (Foster et al., 2006).
W06-1607
Phrasetables produced by the standard DiagAndmethod(Koehnetal.,2003)canbeaggressively pruned using significance pruning without worsening BLEU.
N03-1017
Moore (2004) discusses the use of significance testing of word associations using the loglikelihood-ratio test and Fisher’s exact test.
W04-3243
This is plausible since a similar effect (a decrease in the benefit of smoothing) has been noted with phrasetable smoothing (Foster et al., 2006).
W06-1607
Philipp Koehn 2003.
N03-1017
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ∝ exp bracketleftBiggsummationdisplay i λifi(s,t,a) bracketrightBigg where each fi(s,t,a) is a feature function, and weights λi are set using Och’s algorithm (Och, 2003) to maximize the system’s BLEU score (Papineni et aal., 2001) on a development corpus.
P03-1021
The features used are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and 4-gram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit (Stolcke, 2002).
N03-1017
