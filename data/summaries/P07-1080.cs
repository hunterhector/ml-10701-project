This approximation method replicates exactly the computation of the feed-forward neural network in (Henderson, 2003), where the above means µtprimei are equivalent to the neural network hidden unit activations.
N03-1014
Although the most accurate parsing models (Charniak and Johnson, 2005; Henderson, 2004; Collins, 2000) are discriminative, all the most accurate discriminative models make use of a generative model.
A00-2018 P04-1013 P05-1022
Evaluation In this section we evaluate the two approximations to dynamic SBNs discussed in the previous section, the feed-forward method equivalent to the neural network of (Henderson, 2003) (NN method) and the mean field method (MF method).
N03-1014
Undirected graphical models, in particular Condi3We measured significance of all the experiments in this paper with the randomized significance test (Yeh, 2000).
C00-2137
Work There has not been much previous work on graphical models for full parsing, although recently several latent variable models for parsing have been proposed (Koo and Collins, 2005; Matsuzaki et al., 2005; Riezler et al., 2002).
H05-1064 P02-1035 P05-1010
(Koo and Collins, 2005; Matsuzaki et al., 2005; Riezler et al., 2002)).
H05-1064 P02-1035 P05-1010
the MF approximation on the whole WSJ corpus, so instead we use only sentences of length at most 15, as in (Taskar et al., 2004) and (Turian and Melamed, 2006).
P06-1110 W04-3201
The same is true for reranking with data-defined kernels, with which we would 638 expect similar improvements as were achieved with the neural network parser (Henderson and Titov, 2005).
P05-1023
tional Random Fields, are the standard tools for shallow parsing (Sha and Pereira, 2003).
N03-1028
We used the Penn Treebank WSJ corpus (Marcus et al., 1993) to perform the empirical evaluation of the considered approaches.
J93-2004
We first show that the previous neural network model of (Henderson, 2003) can be viewed as a coarse approximation to inference with ISBNs.
N03-1014
It should also be noted that the model (Charniak, 2000) is the most accurate generative model on the standard WSJ parsing benchmark, which confirms the viability of our generative model.
A00-2018
It is expensive to train R P F1 Bikel, 2004 87.9 88.8 88.3 Taskar et al., 2004 89.1 89.1 89.1 NN method 89.1 89.2 89.1 Turian and Melamed, 2006 89.3 89.6 89.4 MF method 89.3 90.7 90.0 Charniak, 2000 90.0 90.2 90.1 Table 1: Percentage labeled constituent recall (R), precision (P), combination of both (F1) on the testing set.
A00-2018 P06-1110 W04-3201
Another previous approach is to use neural networks to compute a compressed representation of the history and condition decisions on this representation (Henderson, 2003; Henderson, 2004).
N03-1014 P04-1013
For example, the discriminative training techniques successfully applied in (Henderson, 2004) to the feed-forward neural network model can be directly applied to the mean field model proposed in this paper.
P04-1013
In (Koo and Collins, 2005), an undirected graphical model is used for parse reranking.
H05-1064
This improvement is statically significant.3 The MF model achieves results which do not appear to be significantly different from the results of the best model in the list (Charniak, 2000).
A00-2018
We refer the reader to (Henderson, 2003) for details.
N03-1014
First, it is shown that the neural network parser of (Henderson, 2003) can be considered as a simple feed-forward approximation to the graphical model.
N03-1014
(Charniak, 2000; Collins, 1999)).
A00-2018
The standard split of the corpus into training (sections 2–22, 9,753 sentences), validation (section 24, 321 sentences), and testing (section 23, 603 sentences) was performed.2 As in (Henderson, 2003; Turian and Melamed, 2006) we used a publicly available tagger (Ratnaparkhi, 1996) to provide the part-of-speech tag for each word in the sentence.
N03-1014 P06-1110 W96-0213
Both methods are empirically compared, and the mean field approach achieves significantly better results, which are non-significantly different from the results of the most accurate generative parsing model (Charniak, 2000) on our testing set.
A00-2018
637 ferent generative and discriminative parsing methods (Bikel, 2004; Taskar et al., 2004; Turian and Melamed, 2006; Charniak, 2000) evaluated in the same experimental setup.
A00-2018 P06-1110 W04-3201
they are Markovian), but in our parsing models the pattern of interconnection is determined by structural locality, rather than sequence locality, as in the neural networks of (Henderson, 2003).
N03-1014
For our experiments, we replicated the same pattern of interconnection between state variables as described in (Henderson, 2003).1 We also used the 1In the neural network of (Henderson, 2003), our variables same left-corner parsing strategy, and the same set of decisions, features, and states.
N03-1014
