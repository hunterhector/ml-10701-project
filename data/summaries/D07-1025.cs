Both Liang, et al (2006), and Tillmann and Zhang (2006) report on effective machine translation (MT) models involving large numbers of features with discriminatively trained weights.
P06-1091 P06-1096
Al-Onaizan and Knight (2002) report a 1best accuracy of 0.199 on a corpus of Arabic person names (but an accuracy of 0.634 on English names), using a “spelling-based” model, i.e., a model which has no access to phonetic information.
W02-0505
For example, Knight and Graehl (1998) employ cascaded probabilistic finite-state transducers, one of the stages modeling the orthographicto-phonetic mapping.
J98-4003
We are given a sequence of source language characters sm1 representing a name, which is to be translated into a sequence of target language characters tn1 . Among all possible target language character sequences, we will choose the character sequence with the highest probability: ˆtˆn1 = argmax n,tn1 {Pr(tn1|sm1 )} (3) The posterior probability Pr(tn1|sm1 ) is modeled directly using a log-linear combination of several models (Och and Ney, 2002), including a characterbased phrase translation model, a character-based lexicon model, a 4-gram character sequence model, a character penalty and a phrase penalty.
P02-1038
Perceptron-Based Edit Model In this section we present a general-purpose extension of perceptron training for sequence labeling, due to Collins (2002), to the problem of sequence alignment.
W02-1001
This idea is at the heart of several recent attempts to improve the handling of named entities in machine translation (Huang et al., 2004; Lee and Chang, 2003).
N04-1036 W03-0317
Klementiev and Roth (2006) explore the use of a perceptron-based ranking model for the purpose of finding name transliterations across comparable corpora.
P06-1103
However, compare these performance scores to those returned by the system of Lee and Chang (2003), who reported a peak MRR of 0.82 in similar experiments involving data different from ours.
W03-0317
We describe a new sequence alignment model based on the averaged perceptron (Collins, 2002), which shares with the above approaches the ability to exploit arbitrary features of the input sequences, but is distinguished from them by its relative simplicity and the incremental character of its training procedure.
W02-1001
The ability to find an optimal alignment between two sequences has found application in a number of areas of CL, including phonetic modeling (Ristad and Yianilos, 1998), name transcription (Huang et al., 2004), and duplicate detection or information integration (Bilenko and Mooney, 2003; McCallum et al., 2005).
N04-1036
Huang et al.(2004), construct a probabilistic Chinese-English edit model as part of a larger alignment solution, setting edit weights in a heuristic bootstrapped procedure.
N04-1036
Therefore, to make the phrase-based SMT system robust against data sparseness for the ranking task, we also make use of the IBM Model 4 (Brown et al., 1993) in both directions.
J93-2003
Subsequently, Al-Onaizan and Knight (2002) find they can boost performance by combining a phonetically-informed model Task Train Dev Eval ELen FLen A-E 8084 1000 1000 6.5 4.9 M-E 2000 430 1557 16.3 23.0 Table 5: Characteristics of the two transcription data sets, Arabic-English (A-E) and Mandarin-English (M-E), including number of training, development, and evaluation pairs (Train, Dev, and Eval), and mean length in characters of English and foreign strings (ELen and FLen).
W02-0505
Because we are interested in an approximate comparison with similar experiments in the literature, we selected at random 2430 for training and 1557 for evaluation, which are the data sizes used by Lee and Chang (2003) for their experiments.
W03-0317
