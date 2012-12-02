Fleischman et al.(FKH, 2003) extend G & J’s work and achieve better performance in role classification for correct frame element boundaries.
W03-1007
Work The first work using FrameNet for semantic parsing was done by Gildea and Jurafsky (G & J, 2002) using conditional probabilistic models.
J02-3001
Entropy ME models implement the intuition that the best model is the one that is consistent with the set of constraints imposed by the evidence, but otherwise is as uniform as possible (Berger et al.1996). We model the probability of a class c given a vector of features x according to the ME formulation below: )],(exp[ 1 )|( 0 xcf Z xcp ii n i x λ = Σ= Here x Z is normalization constant, ),( xcf i is a feature function which maps each class and vector element to a binary value, n is the total number of feature functions, and i λ is a weight for the feature function.
J96-1002
For testing, we use the YASMET MEtagger (Bender et al.2003) to perform the Viterbi search for choosing the most probable tag sequence for a sentence using the probabilities from training.
E03-1055
