The purpose of this submission wasto validate the syntactic reordering method that we previously proposed (Collins et al., 2005).
P05-1066
Marcu and Wong (2002) proposed the joint probability model which directly estimates the phrase translation probabilities from the corpus in a theoretically governed way.
W02-1018
c©2006 Association for Computational Linguistics Constraining the Phrase-Based, Joint Probability Statistical Translation Model Alexandra Birch Chris Callison-Burch Miles Osborne Philipp Koehn School of Informatics University of Edinburgh 2 Buccleuch Place Edinburgh, EH8 9LW, UK a.c.birch-mayne@sms.ed.ac.uk Abstract The joint probability model proposed by Marcu and Wong (2002) provides a strong probabilistic framework for phrase-based statistical machine translation (SMT).
W02-1018
Probability Model The joint model (Marcu and Wong, 2002), does not rely on a pre-existing set of word-level alignments.
W02-1018
EM is then performed by first discovering an initial phrasal alignments using a greedy algorithm similar to the competitive linking algorithm (Melamed, 1997).
P97-1063
The probability of a sentence and its translation is the sum of all possible alignments C, each of which is defined as the product of the probability of all individual concepts: p(F,E) = summationdisplay C∈C productdisplay <ei,fi>∈C p(< ei,fi >) (1) The model is trained by initializing the translation table using Stirling numbers of the second kind to efficiently estimate p(< ei,fi >) by calculating the proportion of alignments which contain p(< ei,fi >) compared to the total number of alignments in the sentence (Marcu and Wong, 2002).
W02-1018
The original IBM Models (Brown et al., 1993) learn word-to-word alignment probabilities which makes it computationally feasible to estimate model parameters from large amounts of training data.
J93-2003
The translation models are included within a log-linear model (Och and Ney, 2002) which allows a weighted combination of features functions.
P02-1038
In this project we use the model described by Koehn et al.(2003) which extracts its phrase alignments from a corpus that has been word aligned.
N03-1017
On smaller data sets (Koehn et al., 2003) the joint model shows performance comparable to the standard model, however the joint model does not reach the level of performance of the stan156 EN-ES ES-EN Joint 3-gram, dl4 20.51 26.64 5-gram, dl6 26.34 27.17 + lex.
N03-1017
154 2 Translation Models 2.1 Standard Phrase-based Model Most phrase-based translation models (Och, 2003; Koehn et al., 2003; Vogel et al., 2003) rely on a pre-existing set of word-based alignments from which they induce their parameters.
N03-1017
For the future, the joint model would benefit from lexical weighting like that used in the standard model (Koehn et al., 2003).
N03-1017
The impact of constraining the joint model trained on 10,000 sentences of the German-English Europarl corpora and tested with the Europarl test set used in Koehn et al.(2003) than 10 million times that of the phrase pair with the highest count, are pruned from the phrase table.
N03-1017
