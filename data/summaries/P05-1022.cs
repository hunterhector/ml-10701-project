This result is only slightly higher than the highest reported result for this test-set, Bod’s (.907) (Bod, 2003).
E03-1005
Things become worse still in a parser like the one described in Charniak (2000) because it conditions on (and hence splits the dynamic programming states according to) features of the grandparent node in addition to the parent, thus multiplying the number of possible dynamic programming states even more.
A00-2018
This paper describes a simple yet novel method for constructing sets of 50-best parses based on a coarse-to-fine generative parser (Charniak, 2000).
A00-2018
The 50-best parser is a probabilistic parser that on its own produces high quality parses; the maximum probability parse trees (according to the parser’s model) have an f-score of 0.897 on section 23 of the Penn Treebank (Charniak, 2000), which is still state-of-the-art.
A00-2018
We used the Limited Memory Variable Metric optimization algorithm from the PETSc/TAO optimization toolkit (Benson et al., 2004) to find the optimal feature weights ˆθ because this method seems substantially faster than comparable methods (Malouf, 2002).
W02-2018
At the end one has a beam-width’s number of best parses (Roark, 2001).
J01-2004
The first was tried on relatively small grammars, while the second was implemented on top of the Bikel re-implementation of the Collins 174 parser (Bikel, 2004) and achieved oracle results for 50-best parses similar to those we report below.
J04-4004
Bikel. 2004.
J04-4004
This feature was inspired by a similar feature in Klein and Manning (2003).
P03-1054
Finally, we note that 50-best parsing is only a fac1Charniak in (Charniak, 2000) cites an accuracy of 89.5%.
A00-2018
Because there may not be a unique best parse for each sentence (i.e., |Y+(s)| > 1 for some sentences s) we used the variant of MaxEnt described in Riezler et al.(2002) for partially labelled training data.
P02-1035
We used these parses as the input to a MaxEnt reranker (Johnson et al., 1999; Riezler et al., 2002) that selects the best parse from the set of parses for each sentence, obtaining an f-score of 91.0% on sentences of length 100 or less.
P02-1035 P99-1069
As shown by Eisner (Eisner and Satta, 1999) the dynamic programming algorithms for bilexicalized PCFGs require O(m3) states, so a n-best parser would require O(nm3) states.
P99-1059
The loss function LD proposed in Riezler et al.(2002) is just the negative log conditional likelihood of the best parses Y+(s) relative to the n-best parser output Y(s): LD(θ) = − nprimesummationdisplay i=1 logPθ(Y+(si)|Y(si)),where Pθ(Y+|Y) = summationdisplay y∈Y+ Pθ(y|Y) The partial derivatives of this loss function, which are required by the numerical estimation procedure, are: ∂LD θj = nprimesummationdisplay i=1 Eθ[fj|Y(si)] − Eθ[fj|Y+(si)] Eθ[f|Y] = summationdisplay y∈Y f(y)Pθ(y|Y) In the experiments reported here, we used a Gaussian or quadratic regularizer R(w) = csummationtextmj=1 w2j, where c is an adjustable parameter that controls the amount of regularization, chosen to optimize the reranker’s f-score on the development set (section 24 of the treebank).
P02-1035
To put this in perspective, Roark (Roark, 2001) reports oracle results of 0.941 (with the same experimental setup) using his parser to return a variable number of parses.
J01-2004
A good example of this is the Roark parser (Roark, 2001) which works left-to right through the sentence, and abjures dynamic programming in favor of a beam search, keeping some large number of possibilities to extend by adding the next word, and then re-pruning.
J01-2004
The Collins parser (Collins, 1997) does use dynamic programming in its search.
P97-1003
A prime example of this idea is from Goodman (1997), who describes a method for producing a simple but crude approximate grammar of a standard context-free grammar.
W97-0302
