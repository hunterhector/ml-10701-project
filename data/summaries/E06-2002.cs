Starting from the parallel training corpus, provided with direct and inverted alignments, the socalled union alignment (Och and Ney, 2003) is computed.
J03-1002 P03-1021
This preprocessing step can be accomplished by applying the GIZA++ toolkit (Och and Ney, 2003) that provides Viterbi alignments based on IBM Model-4.
J03-1002 P03-1021
By introducing the hidden word alignment variable a, the following approximate optimization criterion can be applied for that purpose: e∗ = argmaxe Pr(e | f) = argmaxe summationdisplay a Pr(e,a | f) ≈ argmaxe,a Pr(e,a | f) Exploiting the maximum entropy (Berger et al., 1996) framework, the conditional distribution Pr(e,a | f) can be determined through suitable real valued functions (called features) hr(e,f,a),r = 1...R, and takes the parametric form: pλ(e,a | f) ∝ exp Rsummationdisplay r=1 λrhr(e,f,a)} The ITC-irst system (Chen et al., 2005) is based on a log-linear model which extends the original IBM Model 4 (Brown et al., 1993) to phrases (Koehn et al., 2003; Federico and Bertoldi, 2005).
J93-2003 J96-1002 N03-1017
