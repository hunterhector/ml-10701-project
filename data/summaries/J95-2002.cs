Pereira and Schabes (1992) showed that partially bracketed input samples can alleviate the problem in certain cases.
P92-1017
Briscoe, Ted, and Carroll, John (1993).
J93-1002
Traditionally it has been seen as a drawback of top-down parsing algorithms such as Earley's that they sacrifice "robustness," i.e., the ability to find partial parses in an ungrammatical input, for the efficiency gained from top-down prediction (Magerman and Weir 1992).
P92-1006
In some work, context-free grammars are combined with scoring functions that are not strictly probabilistic (Nakagawa 1987), or they are used with context-sensitive and/or semantic probabilities (Magerman and Marcus 1991; Magerman and Weir 1992; Jones and Eisner 1992; Briscoe and Carroll 1993).
E91-1004 J93-1002 P92-1006
Stolcke, Andreas, and Segal, Jonathan (1994).
P94-1011
Briscoe and Carroll (1993) turn this incongruity into an advantage by using the LR parser as a probabilistic model in its own right, and show how LR probabilities can be extended to capture non--context-free contingencies.
J93-1002
For this purpose we need a probabilistic version of the well-known parsing concept of a left comer, which is also at the heart of the prefix probability algorithm of Jelinek and Lafferty (1991).
J91-3004
The latter extension removes one of the common objections against top-down, predictive (as opposed to bottom-up) parsing approaches (Magerman and Weir 1992).
P92-1006
Magerman and Marcus (1991) are interested primarily in scoring functions to guide a parser efficiently to the most promising parses.
E91-1004
© 1995 Association for Computational Linguistics Computational Linguistics Volume 21, Number 2 standard tasks, compiled by Jelinek and Lafferty (1991).
J91-3004
The total time is therefore O(/3) for an input of length l, which is also the complexity of the standard Inside/Outside (Baker 1979) and LRI (Jelinek and Lafferty 1991) algorithms.
J91-3004
Magerman, David M., and Weir, Carl (1992).
P92-1006
For example, Jelinek and Lafferty (1991) use the term "proper" to mean (c), and "well-defined" for (b).
J91-3004
Jurafsky, Daniel; Wooters, Chuck; Tajchman, Gary; Segal, Jonathan; Stolcke, Andreas; Fosler, Eric; and Morgan, Nelson (1994).
P94-1011
Another application in which prefix probabilities play a central role is the extraction of n-gram probabilities from SCFGs (Stolcke and Segal 1994).
P94-1011
~7 The matrix inversion method for dealing with left-recursive prediction is borrowed from the LRI algorithm of Jelinek and Lafferty (1991) for computing prefix probabilities for SCFGs in CNF) s We then use that idea a second time to deal with the similar recursion arising from unit productions in the completion step.
J91-3004
B.3 Efficient Parsing with Large Sparse Grammars During work with a moderate-sized, application-specific natural language grammar taken from the BeRP speech system (Jurafsky, Wooters, Tajchman, Segal, Stolcke, Foster, and Morgan 1994) we had an opportunity to optimize our implementation of the algorithm.
P94-1011
While the Jelinek and Lafferty (1991) solution to problem (3) is not a direct extension of CYK parsing, the authors nevertheless present their algorithm in terms of its similarities to the computation of inside probabilities.
J91-3004
As pointed out by Jelinek and Lafferty (1991), knowing probabilities P (Xo... xi) for arbitrary prefixes Xo... xi enables probabilistic prediction of possible follow-words Xi+l, as P(xi+l I xo...xi) = P(Xo...xixi+I)/P(xo...xi).
J91-3004
