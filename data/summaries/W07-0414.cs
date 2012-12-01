The fact that ITG constraints can reach such high translation accuracies supports the findings in Zens et al.(2004) and is an empirical validation of the ITG hypothesis.
C04-1030
Some models (Brown et al.(1996), Kumar and Byrne (2005)) allow words to change place with their local neighbors, but disallow global reorderings.
H05-1021
5The accumulating oracle algorithm makes a greedy decision for every sentence given the ngram counts so far accumulated (Zens and Ney, 2005).
W05-0834
In Wellington et al.(2006), hand-aligned data are used to compare the standard ITG constraints to ITGs that allow gaps.
P06-1123
If the input consists of sevWe also adopt the approximation that treats every sentence with its reference as a separate corpus (Tillmann and Zhang, 2006) so that ngram counts are not accumulated, and parallel processing of sentences becomes possible.
P06-1091
Typically, k is set to 4 (Zens and Ney, 2003).
P03-1019
Table 2 6We use a straightforward adaption of Algorithm 3 in Huang and Chiang (2005) 7We fill the initial phrase and word lattice with the 20 best candidates, using phrases of 3 or less words.
W05-1506
Constraints The Inversion Transduction Grammar (ITG) (Wu, 1997), a derivative of the Syntax Directed Transduction Grammars (Aho and Ullman, 1972), constrains the possible permutations of the input string by defining rewrite rules that indicate permutations of the string.
J97-3002
While earlier work has trained and tested instantiations of different reordering models and then compared the translation results (Zens and Ney, 2003) we provide a more general mechanism to evaluate the potential efficacy of reordering constraints, independent of specific training paradigms.
P03-1019
Tillmann and Zhang (2006) use a BLEU oracle decoder for discriminative training of a local reordering model.
P06-1091
Zens and Ney (2003) perform a comparison of different reordering strategies.
P03-1019
Other models (Wu (1997), Xiong et al.(2006)) explicitly allow global reorderings, but do not allow all possible permutations, including some local permutations.
J97-3002 P06-1066
They can be used for discriminative training of reordering models (Tillmann and Zhang, 2006).
P06-1091
Kumar and Byrne (2005) define two local reordering models for their Translation Template Model (TTM): In the first one, called MJ-1, only adjacent phrases are allowed to swap, and the movement has to be done within a window of 2.
H05-1021
As in Zens and Ney (2003), phrases are not broken up, but every phrase is, at the beginning of reordering, stored in the chart as one lexical token together with the precomputed n-gram matches and the n-gram precision score.
P03-1019
Zens et al.(2004) conduct a study similar to Zens and Ney (2003) and note that the results for the ITG reordering constraints were quite dependent on the very simple probability model used.
C04-1030 P03-1019
mations. Zens and Ney (2005) describe a dynamicprogramming algorithm in which at every state the number of n-gram matches is stored, along with a multiset that contains all words from the reference that have not yet been matched.
W05-0834
