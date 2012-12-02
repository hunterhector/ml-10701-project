LLW stands for Levenshtein with learned weights, which is a modi cation of R&Y proposed by Mann and Yarowsky (2001).
N01-1020
Filali and Bilmes (2005) proposed to use Dynamic Bayesian Nets (DBNs) for computing word similarity.
P05-1042
45 3.2 Levenshtein with learned weights Mann and Yarowsky (2001) applied the stochastic transducer of Ristad and Yianilos (1998) for inducing translation lexicons between two languages, but found that in some cases it offered no improvement over Levenshtein distance.
N01-1020
In comparison with the results of Filali and Bilmes (2005), certain differences are apparent.
P05-1042
CORDI (Kondrak, 2002) is a program for detecting recurrent sound correspondences in bilingual wordlists.
C02-1016
The ALINE algorithm (Kondrak, 2000) assigns a similarity score to pairs of phonetically-transcribed words on the basis of the decomposition of phonemes into elementary phonetic features.
A00-2038
HMM Mackay and Kondrak (2005) propose to computing similarity between pairs of words with a technique adapted from the eld of bioinformatics.
W05-0606
A more detailed description of the models can be found in (Filali and Bilmes, 2005).
P05-1042
Instead, we order the candidate pairs by their scores, and evaluate the ranking using 11-point interpolated average precision (Manning and Schutze, 2001).
N01-1020
A translation model is induced between phonemes in two wordlists by combining the maximum similarity alignment with the competitive linking algorithm of Melamed (2000).
J00-2004
We countered this by normalizing all scores, which was not done in (Filali and Bilmes, 2005).
P05-1042
As mentioned in (Mann and Yarowsky, 2001), it appears that there are signi cant differences between the pronunciation task and the cognate iden49 ti cation task.
N01-1020
Beyond historical linguistics, cognate identi cation has applications in other areas of computational linguistics (Mackay and Kondrak, 2005).
W05-0606
ALINE denotes the algorithm for aligning phonetic sequences (Kondrak, 2000) described in Section 2.1.
A00-2038
The PHMM column provides the results reported in (Mackay and Kondrak, 2005) for the best Pair HMM model, which uses log odds scoring.
W05-0606
