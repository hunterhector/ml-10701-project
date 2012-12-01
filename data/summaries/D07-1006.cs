A discriminatively trained 1-to-N model with feature functions specifically designed for Arabic was presented in (Ittycheriah and Roukos, 2005).
H05-1012
This operation does not change the collection of phrases or rules extracted from a hypothesized alignment, see, for instance, (Koehn et al., 2003).
N03-1017
(Ayan and Dorr, 2006) defined a discriminative model which learns how to combine the predictions of several alignment algorithms.
N06-1013
(Moore et al., 2006) introduced a discriminative model of 1-to-N and M-to-1 alignments, and similarly to (Lacoste-Julien et al., 2006) the best results were obtained using HMMs trained to agree and intersected Model 4.
N06-1015 P06-1065
We use Viterbi training (Brown et al., 1993) but neighborhood estimation (Al-Onaizan et al., 1999; Och and Ney, 2003) or “pegging” (Brown et al., 1993) could also be used.
J03-1002 J93-2003 P03-1021
(Brown et al., 1993) defined two local search operations for their 1-to-N alignment models 3, 4 and 5.
J93-2003
(Och and Ney, 2003) discussed efficient implementation.
J03-1002 P03-1021
(Lacoste-Julien et al., 2006) created a discriminative model able to model 1-to-1, 1-to2 and 2-to-1 alignments for which the best results were obtained using features based on symmetric HMMs trained to agree, (Liang et al., 2006), and intersected Model 4.
N06-1014 N06-1015
(Matusov et al., 2004) presented a model capable of modeling 1-toN and M-to-1 alignments (but not arbitrary M-toN alignments) which was bootstrapped from Model 4.
C04-1032
(Fraser and Marcu, 2006a) established that it is important to tune α (the trade-off between Precision and Recall) to maximize performance.
P06-1097
This idea of dependency has some similarity with hierarchical SMT models such as (Chiang, 2005).
P05-1033
For French/English translation we use a state of the art phrase-based MT system similar to (Och and Ney, 2004; Koehn et al., 2003).
J03-1002 J04-4002 N03-1017 P03-1021
(Zens et al., 2004) introduced a model featuring a symmetrized lexicon.
C04-1006
We ran the baseline semisupervised system for two iterations (line 2), and in contrast with (Fraser and Marcu, 2006b) we found that the best symmetrization heuristic for this system was “union”, which is most likely due to our use of fully linked alignments which was discussed at the end of Section 3.
P06-1097
(Fraser and Marcu, 2006b) described symmetrized training of a 1-toN log-linear model and a M-to-1 log-linear model.
P06-1097
We have attempted to use the same labels as the generative story for Model 4 (Brown et 51 al., 1993), which we are extending.
J93-2003
These models took advantage of features derived from both training directions, similar to the symmetrized lexicons of (Zens et al., 2004), including features derived from the HMM model and Model 4.
C04-1006
(Marcu and Wong, 2002) defined the Joint model, which modeled consecutive word M-to-N alignments.
W02-1018
Och. 2003.
J03-1002 P03-1021
Work The LEAF model is inspired by the literature on generative modeling for statistical word alignment and particularly by Model 4 (Brown et al., 1993).
J93-2003
Evidence that inference over the space of all possible alignments is intractable has been presented, for a similar problem, in (Knight, 1999).
J99-4005
(Och and Ney, 2003) presented results suggesting that the additional parameters required to ensure that a model is not deficient result in inferior performance, but we plan to study whether this is the case for our generative model in future work.
J03-1002 P03-1021
For Arabic/English translation we train a state of the art hierarchical model similar to (Chiang, 2005) using our Viterbi alignments.
P05-1033
(Germann et al., 2004; Marcu and Wong, 2002) have some similar operations without the head word distinction.
W02-1018
(Deng and Byrne, 2005) described work on extending the HMM model using a bigram formulation to generate 1-to-N alignment structure.
H05-1022
(Och and Ney, 2003) invented heuristic symmetriza57 FRENCH/ENGLISH ARABIC/ENGLISH SYSTEM F-MEASURE (α = 0.4) BLEU F-MEASURE (α = 0.1) BLEU GIZA++ 73.5 30.63 75.8 51.55 (FRASER AND MARCU, 2006B) 74.1 31.40 79.1 52.89 LEAF UNSUPERVISED 74.5 72.3 LEAF SEMI-SUPERVISED 76.3 31.86 84.5 54.34 Table 3: Experimental Results tion of the output of a 1-to-N model and a M-to-1 model resulting in a M-to-N alignment, this was extended in (Koehn et al., 2003).
J03-1002 N03-1017 P03-1021
Parameter Estimation We can perform maximum likelihood estimation of the parameters of this model in a similar fashion to that of Model 4 (Brown et al., 1993), described thoroughly in (Och and Ney, 2003).
J03-1002 J93-2003 P03-1021
(Toutanova et al., 2002) and (Lopez and Resnik, 2005) presented a variety of refinements of the HMM model particularly effective for low data conditions.
W02-1012 W05-0812
(Liang et al., 2006) showed how to train two HMM models, a 1-to-N model and a M-to-1 model, to agree in predicting all of the links generated, resulting in a 1-to-1 alignment with occasional rare 1to-N or M-to-1 links.
N06-1014
For all non-LEAF systems, we take the best performing of the “union”, “refined” and “intersection” symmetrization heuristics (Och and Ney, 2003) to combine the 1-to-N and M-to-1 directions resulting in a M-to-N alignment.
J03-1002 P03-1021
We compare semisupervised LEAF with a previous state of the art semi-supervised system (Fraser and Marcu, 2006b).
P06-1097
We use the semi-supervised EMD algorithm (Fraser and Marcu, 2006b) to train the model.
P06-1097
The experiments performed included Model 4 and the HMM extensions of (Lopez and Resnik, 2005).
W05-0812
(Liu et al., 2005) presented a log-linear model combining IBM Model 3 trained in both directions with heuristic features which resulted in a 1-to-1 alignment.
P05-1057
Our work is most similar to work using discriminative log-linear models for alignment, which is similar to discriminative log-linear models used for the SMT decoding (translation) problem (Och and Ney, 2002; Och, 2003).
J03-1002 P02-1038 P03-1021
To build all alignment systems, we start with 5 iterations of Model 1 followed by 4 iterations of HMM (Vogel et al., 1996), as implemented in GIZA++ (Och and Ney, 2003).
C96-2141 J03-1002 P03-1021
Much of the additional work on generative modeling of 1to-N word alignments is based on the HMM model (Vogel et al., 1996).
C96-2141
In designing LEAF, we were also inspired by dependency-based alignment models (Wu, 1997; Alshawi et al., 2000; Yamada and Knight, 2001; Cherry and Lin, 2003; Zhang and Gildea, 2004).
C04-1060 J00-1004 J97-3002 P01-1067 P03-1012
(Wang and Waibel, 1998) introduced a generative story based on extension of the generative story of Model 4.
P98-2221
