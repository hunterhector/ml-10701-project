For example, Brown et al.(1992) describe an approach based on grouping words into classes, thereby reducing the number of conditional probabilities in the model.
J92-4003
The computation of prefix probabilities for SCFGs is generally useful for applications, and has been solved with the LRI algorithm (Jelinek and Lafferty, 1991).
J91-3004
A tutorial introduction to SCFGs and standard algorithms can be found in Jelinek et al.(1992). MOTIVATION There are good arguments that SCFGs are in principle not adequate probabilistic models for natural languages, due to the conditional independence assumptions they embody (Magerman and Marcus, 1991; Jones and Eisner, 1992; Briscoe and Carroll, 1993).
E91-1004 J93-1002
Note that in the case of bigrams, only a particularly simple form of prefix/suffix probabilities are required, namely, the 'left-corner' and 'right-corner' probabilities, P(X ~z wl) and P(Y ~ R w2), which can each be obtained from a single matrix inversion (Jelinek and Lafferty, 1991).
J91-3004
