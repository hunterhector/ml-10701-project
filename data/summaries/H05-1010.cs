Another way of doing the parameter estimation for this matching task would have been to use an averaged perceptron method, as in Collins (2002).
W02-1001
With these features, we got an AER of 15.5 (compare to 19.5 for Model 2 in (Och and Ney, 2003)).
J03-1002
Melamed. 2000.
J00-2004
As observed in Melamed (2000), this use of Dice misses the crucial constraint of competition: a candidate source word with high association to a target word may be unavailable for alignment because some other target has an even better aﬃnity for that source word.
J00-2004
Tiedemann (2003) proposes incorporating a variety of word association “clues” into a greedy linking algorithm.
E03-1026
just a Dice feature – meaning no learning is needed yet – we achieve an AER of 29.8, between the Dice with competitive linking result of 34.0 and Model 1 of 25.9 given in Och and Ney (2003).
J03-1002
We applied this matching algorithm to wordlevel alignment using the English-French Hansards data from the 2003 NAACL shared task (Mihalcea and Pedersen, 2003).
W03-0301
For example, when considering whether to align two words in the IBM models (Brown et al., 1990), one cannot easily include information about such features as orthographic similarity (for detecting cognates), presence of the pair in various dictionaries, similarity of the frequency of the two words, choices made by other alignment systems on this sentence pair, and so on.
J90-2002
This view of alignment as graph matching is not, in itself, new: Melamed (2000) uses competitive linking to greedily construct matchings where the pair score is a measure of wordto-word association, and Matusov et al.(2004) find exact maximum matchings where the pair scores come from the alignment posteriors of generative models.
C04-1032 J00-2004
The standard approach to word alignment from sentence-aligned bitexts has been to construct models which generate sentences of one language from the other, then fitting those generative models with EM (Brown et al., 1990; Och and Ney, 2003).
J03-1002 J90-2002
The validation and test sentences have been hand-aligned (see Och and Ney (2003)) and are marked with both sure and possible alignments.
J03-1002
At this point, one can imagine estimating a linear matching model in multiple ways, including using conditional likelihood estimation, an averaged perceptron update (see which matchings are proposed and adjust the weights according to the diﬀerence between the guessed and target structures (Collins, 2002)), or in large-margin fashion.
W02-1001
However, our model can 4 It is important to note that while our matching algorithm has no first-order eﬀects, the features can encode such eﬀects in this way, or in better ways – e.g. using as features posteriors from the HMM model in the style of Matusov et al.(2004). 5 The number of such features which can be learned depends on the number of training examples, and since some of our experiments used only a few dozen training examples we did not make heavy use of this feature.
C04-1032
One source of constraint which our model still does not explicitly capture is the first-order dependency between alignment positions, as in the HMM model (Vogel et al., 1996) and IBM models 4+.
C96-2141
While tools like GIZA++ (Och and Ney, 2003) do make it easier to build on the long history of the generative IBM approach, they also underscore how complex high-performance generative models can, and have, become.
J03-1002
With just this feature on a pair of word tokens (which depends only on their types), we can already make a stab 77 at word alignment, aligning, say, each English word with the French word (or null) with the highest Dice value (see (Melamed, 2000)), simply as a matching-free heuristic model.
J00-2004
With Dice counts taken from the 1.1M sentences, this gives and AER of 38.7 with English as the target, and 36.0 with French as the target (in line with the numbers from Och and Ney (2003)).
J03-1002
