As a baseline model we used a maximum entropy tagger, very similar to the one described in (Ratnaparkhi 1996).
W96-0213
We used a feature set which included the current, next, and previous word; the previous two tags; various capitalization and other features of the word being tagged (the full feature set is described in (Collins 2002a)).
P02-1062 W02-1001
In spite of these problems, (Bod 2001) gives excellent results for the method on parsing Wall Street Journal text.
P01-1010
(Goodman 1996) gives a polynomial time conversion of a DOP model into an equivalent PCFG whose size is linear in the size of the training set.
W96-0214
(Collins 2002b) describes how the voted perceptron can be used to train maximum-entropy style taggers, and also gives a more thorough discussion of the theory behind the perceptron algorithm applied to ranking tasks.
P02-1062 W02-1001
For related work on the voted perceptron algorithm applied to NLP problems, see (Collins 2002a) and (Collins 2002b).
P02-1062 W02-1001
Even after this, Bod’s method is left with a huge grammar: (Bod 2001) describes a grammar with over 5 million sub-structures.
P01-1010
(Collins 2002a) describes experiments on the same named-entity dataset as in this paper, but using explicit features rather than kernels.
P02-1062 W02-1001
The method is related to the boosting approach to ranking problems (Freund et al.1998), the Markov Random Field methods of (Johnson et al.1999), and the boosting approaches for parsing in (Collins 2000).
P99-1069
(Note that a similar recursion is described by Goodman (Goodman 1996), Goodman’s application being the conversion of Bod’s model (Bod 1998) to an equivalent PCFG.) It is clear from the identity a1a3a2a5a4 a24 a6a162a16a7a1a3a2a5a4 a44 a6a89a19 a78 a91a97a135 a80 a91 a137 a154 a2 a0 a24 a30 a0 a44 a6, and the recursive definition of a154 a2 a0 a24 a30 a0 a44 a6, that a1a3a2a5a4 a24 a6a3a16a97a1a3a2a5a4 a44 a6 can be calculated in a104 a2a54a164 a133 a24 a164a45a164 a133 a44 a164a48a6 time: the matrix of a154 a2 a0 a24 a30 a0 a44 a6 values can be filled in, then summed.6 Since there will be many more tree fragments of larger size – say depth four versus depth three – it makes sense to downweight the contribution of larger tree fragments to the kernel.
W96-0214
It might seem paradoxical to be able to efficiently learn and apply a model with an exponential number of features.1 The key to our algorithms is the 1Although see (Goodman 1996) for an efficient algorithm for the DOP model, which we discuss in section 7 of this paper.
W96-0214
Maximum entropy taggers have been shown to be highly competitive on a number of tagging tasks, such as partof-speech tagging (Ratnaparkhi 1996), and namedentity recognition (Borthwick et.
W96-0213
(Charniak 2000) describes a different method which achieves very similar performance to (Collins 2000).
A00-2018
From a theoretical point of view, it is difficult to find motivation for the parameter estimation methods used by (Bod 1998) – see (Johnson 2002) for discussion.
J02-1005
The Penn Wall Street Journal treebank (Marcus et al.1993) was used as training and test data.
J93-2004
(Bod 2001) describes experiments giving 90.6%/90.8% recall and precision for sentences of less than 40 words in length, using the all-subtrees representation, but using very different algorithms and parameter estimation methods from the perceptron algorithms in this paper (see section 7 for more discussion).
P01-1010
