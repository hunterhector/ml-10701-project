Another training approach that incorporates arbitrary loss functions is found in the structured prediction literature in the margin-based-learning community (Taskar et al., 2004; Crammer et al., 2004).
W04-3201
Och. 2003.
P03-1021
The ongoing evaluationliteratureisperhapsmostobviousinthe machine translation community’s efforts to better BLEU (Papineni et al., 2002).
P02-1040
Och (2003) found that such smoothing during training “gives almost identical results” on translation metrics.
P03-1021
Goodman. 1996.
P96-1024
Despite these difficulties, some work has shown it worthwhile to minimize error directly (Och, 2003; Bahl et al., 1988).
P03-1021
To find the optimal coefficients θ for a loglinear combination of these experts, we use separate development data, using the following procedure due to Och (2003): 1.
P03-1021
In particular, our experiments consider log-linear combinations of a relatively small number of features over entire complex structures, such as trees or translations, known in some previous work as products of experts (Hinton, 1999) or logarithmic opinion pools (Smith et al., 2005).
P05-1003
We found this to perform significantly better on BLEU evaluation than if we trained with a “linearized” BLEU that summed per-sentence BLEU scores (as used in minimum Bayes risk decoding by Kumar and Byrne (2004)).
N04-1022
Deterministic annealing has also been used to tackle non-convex likelihood surfaces in unsupervised learning with EM (Ueda and Nakano, 1998; Smith and Eisner, 2004).
P04-1062
for this honor, we follow Charniak and Johnson (2005) in summing their probabilities.2 Maximizing (4) is equivalent to minimizing an upper bound on the expected 0/1 loss summationtexti(1 − pθ(y∗i | xi)).
P05-1022
This technique can be used along with annealing or quadratic regularization and can achieve additional accuracy gains, which we report elsewhere (Dreyer et al., 2006).
W06-2929
The orthogonal technique of minimum Bayes risk decoding has achieved gains on parsing (Goodman, 1996) and machine translation (Kumar and Byrne, 2004).
N04-1022 P96-1024
791 and score the alignment template model’s phrases (Koehn et al., 2003).
N03-1017
M.Dreyer, D.A.Smith, andN.A.Smith. 2006.
W06-2929
Och (2003) observed, however, that the piecewiseconstant property could be exploited to characterize the function exhaustively along any line in parameter space, and hence to minimize it globally along that line.
P03-1021
Similar techniques can be used to compute the expected logarithms of some other non-linear metrics, such as F-measure (the harmonic mean of precision and recall)6 and Papineni et al.(2002)’s 5This changes the trajectory that DA takes through parameter space, but ultimately the objective is the same: as γ → ∞ over the course of DA, minimizing E[−logP] becomes indistinguishable from maximizing E[P].
P02-1040
