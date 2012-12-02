Brent et al.(1995) give an information theoretic method for discovering meaningful affixes, which was later extended to enable a novel search algorithm based on a probabilistic word-generation model (Snover et al., 2002).
W02-0602
A conceptually similar approach is taken by Baroni et al.(2002) who combine use of edit distance to measure orthographic similarity and mutual information to measure semantic similarity, to determine morphologically related word pairs.
W02-0606
Goldsmith (2001) gives a comprehensive heuristic algorithm for unsupervised morphological analysis, which uses an MDL criterion to segment words and find morphological paradigms (called signatures).
J01-2001
Schone and Jurafsky (2000) extend this by using latent semantic analysis (Dumais et al., 1988) to require that a proposed stem+affix split is sufficiently semantically similar to the stem before the split is accepted.
W00-0712
Similarly, Creutz and Lagus (2002) use an MDL formulation for word segmentation.
W02-0603
We adopt the minimum description length (MDL) approach to word segmentation, which has been shown to be effective in recent work (notably (Goldsmith, 2001) and (Brent et al., 1995)).
J01-2001
More fundamentally, we intend to use the algorithm presented here (with the above extensions) as a subroutine in a paradigm construction system along the lines of Goldsmith (2001).
J01-2001
