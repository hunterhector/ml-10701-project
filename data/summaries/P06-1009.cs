The word aligned data are annotated with both sure(S)andpossible(P)alignments(S ⊆ P; Och and Ney (2003)), where the possible alignments indicate ambiguous or idiomatic alignments.
J03-1002
work Recently, a number of discriminative word alignment models have been proposed, however these early models are typically very complicated with many proposing intractable problems which require heuristics for approximate inference (Liu et al., 2005; Moore, 2005).
H05-1011 P05-1057
The second data set is the Romanian-English parallel corpus from the 2005 ACL shared task (Martin et al., 2005).
W05-0809
Ittycheriah and Roukos (2005) trained a dis71 criminative model on a corpus of ten thousand word aligned Arabic-English sentence pairs that outperformed a GIZA++ baseline.
H05-1012
We use L-BFGS, an iterative quasi-Newton optimisation method, which performs well for training log-linear models (Malouf, 2002; Sha and Pereira, 2003).
N03-1028 W02-2018
For parameter tuning, we used the 17 sentence trial set from the Romanian-English corpus in the 2003 NAACL task (Mihalcea and Pedersen, 2003).
W03-0301
Callison-Burch et al.(2004) demonstrated that the GIZA++ models could be trained in a semi-supervised manner, leading to a slight decrease in error.
P04-1023
Toutanova et al.(2002)). Secondly, the later IBM models, such as Model 4, have to resort to heuristic search techniques to approximate forward-backward and Viterbi inference, which sacrifice optimality for tractability.
W02-1012
We use the refined method from Och and Ney (2003) which starts from the intersection of the two models’ predictions and ‘grows’ the predicted alignments to neighbouring alignments which only appear in the output of one of the models.
J03-1002
We use a similar graphical structure to the directed hidden Markov model (HMM) from GIZA++ (Och and Ney, 2003).
J03-1002
The Romanian results are close to the best reported result of 26.10 from the ACL shared task (Martin et al., 2005).
W05-0809
Liu et al.(2005) used a conditional log-linear model with similar features to those we have employed.
P05-1057
This data set was used for the 2003 NAACL shared task (Mihalcea and Pedersen, 2003), where the word-aligned sentences weresplitintoa37sentencetrialsetanda447sentence testing set.
W03-0301
4 as a feature Previous work (Taskar et al., 2005) has demonstrated that by including the output of Model 4 as a feature, it is possible to achieve a significant decrease in AER.
H05-1010
ThisdiffersfromtheGIZA++hidden Markov model which has individual parameters for each different jump width (Och and Ney, 2003; Vogel et al., 1996): we found a single feature (and thus parameter) to be more effective.
C96-2141 J03-1002
We follow Taskar et al.(2005) by using the first 100 test sentences for training and the remaining 347 for testing.
H05-1010
In the shared task it was found that models which were trained on only the first four letters of each word obtained superior results to those using the full words (Martin et al., 2005).
W05-0809
An exception is Taskar et al.(2005) who presented a word matching model for discriminative alignment which they they were able to solve optimally.
H05-1010
Here we employ a number of string matching features inspired by similar features in Taskar et al.(2005). We use an indicator feature for every possible source-target word pair in the training data.
H05-1010
Moore. 2005.
H05-1011
Interestingly, without any features derived from the sentence aligned corpus, our model achieves performance equivalent to Model 3 trained on the full corpus (Och and Ney, 2003).
J03-1002
Most current SMT systems (Och and Ney, 2004; Koehn et al., 2003) use a generative model for word alignment such as the freely available GIZA++ (Och and Ney, 2003), an implementation of the IBM alignment models (Brown et al., 1993).
J03-1002 J04-4002 J93-2003 N03-1017
