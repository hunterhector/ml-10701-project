Optimization We optimize the feature weights using a modified version of averaged perceptron learning as described by Collins (2002).
W02-1001
The standard approach to word alignment makes use of various combinations of five generative models developed at IBM by Brown et al.(1993), sometimes augmented by an HMM-based model or Och and Ney’s “Model 6” (Och and Ney, 2003).
J03-1002 J93-2003
and Methodology for Evaluation We evaluated our models using data from the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
W03-0301
We chose this statistic because it has previously been found to be effective for automatically constructing translation lexicons (e.g., Melamed, 2000).
J00-2004
Liu et al.(2005) also develop a log-linear model, based on IBM Model 3.
P05-1057
Automatic sentence alignment of the training data was provided by Ulrich Germann, and the hand alignments of the words in the test data were created by Franz Och and Hermann Ney (Och and Ney, 2003).
J03-1002
For example, Och and Ney (2003) found that the intersection of the alignments found training the IBM models in both directions always outperformed either direction alone in their experiments.
J03-1002
does not permit a full description of this heuristic model here, but in brief, it utilizes a series of greedy searches inspired by Melamed’s competitive linking algorithm (2000), in which constraints limiting alignments to being one-to-one and monotonic are applied at different thresholds of the LLR score, with a final cutoff of the LLR score below which no alignments are made.
J00-2004
We trained the models in both directions, Englishto-French and French-to-English, and computed the union, intersection, and what Och and Ney (2003) call the “refined” combination of the two alignments.
J03-1002
For, example, Och and Ney (2003) suggest supervised optimization of a number of parameters, including the probablity of jumping to the empty word in the HMM model, as well as smoothing parameters for the distortion probabilities and fertility probabilities of the more complex models.
J03-1002
We optimize the model weights using a modified version of averaged perceptron learning as described by Collins (2002).
W02-1001
Moore. 2004.
W04-3243
The other estimate comes from a heuristic alignment model that we previously developed (Moore, 2005).
W05-0801
We compute LLR scores using the following formula presented by Moore (2004): LLR(f,e)= summationdisplay f?∈{f,¬f} summationdisplay e?∈{e,¬e} C(f?,e?)log p(f?|e?) p(f?) In this formula f and e mean that the words whose degree of association is being measured occur in the respective target and source sentences of an aligned sentence pair, ¬f and ¬e mean that the corresponding words do not occur in the respective sentences, f? and e? are variables ranging over these values, and C(f?,e)? is the observed joint count for the values of f? and e?.
W04-3243
For comparison, we aligned our parallel corpus with IBM Model 4 using Och’s Giza++ software package (Och and Ney, 2003).
J03-1002
Work When the first version of this paper was submitted for review, we could honestly state, “We are not aware of any previous work on discriminative word alignment models.” Callison-Burch et al.(2004) had investigated the use of small amounts of annotated data to help train the IBM and HMM models, but the models were still generative and were trained using maximum-likelihood methods.
P04-1023
Fraser and Marcu (2005) modify Model 4 to be a log-linear combination of 11 submodels (5 based on standard Model 4 parameters, and 6 based on additional features) and discriminatively optimize the submodel weights on each iteration of a Viterbi approximation to EM.
W05-0814
We report the performance of our alignment models in terms of precision, recall, and alignment error rate (AER) as defined by Och and Ney (2003): recall = |A ∩ S| |S| precision = |A ∩P| |A| AER = 1− |A ∩ P|+|A ∩S| |A|+|S| In these definitions, S denotes the set of alignments annotated as sure, P denotes the set of alignments annotated possible or sure, and A denotes the set of alignments produced by the method under test.
J03-1002
When Brown et al.(1993) wanted to add a fertility component to create Models 3, 4, and 5, however, this generative 81 story didn’t fit any longer, because it does not include how many target language words to align to each source language word as a separate decision.
J93-2003
Although the best performing systems are “phrasebased” (e.g, Och and Ney, 2004), possible phrase translations are normally first extracted from wordaligned bilingual text segments.
J04-4002
Moore. 2005.
W05-0801
