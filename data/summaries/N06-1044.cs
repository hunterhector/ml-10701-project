Chi. 1999.
J99-1004
The maximization problem above has a unique solution, provided by the estimator (see for instance (Chi and Geman, 1998)) pG(A → α) = f(A → α,D)f(A,D). (7) We refer to this as the supervised MLE method.
J98-2005
This solves a problem that was left open in the literature (Chi and Geman, 1998); see again Section 1 for discussion.
J98-2005
The solution to the above minimization problem provides the estimator pG(A → α) = EpD f(A → α,d)E pD f(A,d) . (12) A proof of this result appears in (Corazza and Satta, 2006), and is briefly summarized in Appendix A, in order to make this paper self-contained.
N06-1043
The above maximization problem provides a system of |R| nonlinear equations (see (Chi and Geman, 1998)) pG(A → α) =summationtext w∈C f(w,C)·EpG(d|w) f(A → α,d)summationtext w∈C f(w,C)·EpG(d|w) f(A,d), (9) where Ep denotes an expectation computed under distribution p, and pG(d|w) is the probability of derivation d conditioned by sentence w (so that pG(d|w) > 0 only if y(d) = w).
J98-2005
A full proof appears in (Corazza and Satta, 2006).
N06-1043
In this section we recall a renormalization technique for PCFGs that was used before in (Abney et al., 1999), (Chi, 1999) and (Nederhof and Satta, 2003) for different purposes, and is exploited in the next section to prove our main results.
J99-1004 P99-1070
This is for instance the case with probabilistic tree-adjoining grammars (Schabes, 1992; Sarkar, 1998), for which consistency results have not yet been shown in the literature.
C92-2066 P98-2190
More specifically, in (Chi and Geman, 1998) empty rules and unary rules are not allowed, thus excluding infinite ambiguity, that is, the possibility that some string in the input sample has an infinite number of derivations in thegrammar.
J98-2005
We now discuss a third estimation method for PCFGs, which was proposed in (Corazza and Satta, 2006).
N06-1043
In later work by (S´anchez and Bened´ı, 1997) and (Chi and Geman, 1998), the result was independently extended to expectation maximization, which is an unsupervised method exploited to estimate probabilistic context-free grammars by finding local maxima of the likelihood of a sample of unannotated sentences.
J98-2005
The proof in (S´anchez and Bened´ı, 1997) makes use of spectral analysis of expectation matrices, while the proof in (Chi and Geman, 1998)isbasedonasimplercountingargument.
J98-2005
