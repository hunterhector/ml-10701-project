BLEU. This score measures the precision of unigrams, bigrams, trigrams and fourgrams with respect to a reference translation with a penalty for too short sentences (Papineni et al., 2002).
P02-1040
We use maximum entropy to train the model scaling factors (Och and Ney, 2002).
P02-1038
In statistical machine translation, we are given a source language (‘French’) sentence fJ1 = f1 :::fj :::fJ, which is to be translated into a target language (‘English’) sentence eI1 = e1 :::ei :::eI: Among all possible target language sentences, we will choose the sentence with the highest probability: ˆeI1 = argmax eI1 'Pr(eI 1jf J 1 ) “ = argmax eI1 'Pr(eI 1)¢Pr(f J 1 je I 1) “ This decomposition into two knowledge sources is known as the source-channel approach to statistical machine translation (Brown et al., 1990).
J90-2002
Constraints In this section, we describe the ITG constraints (Wu, 1995; Wu, 1997).
J97-3002
A comparison of the ITG constraints and the IBM constraints for single-word based models can be found in (Zens and Ney, 2003).
P03-1019
(Tillmann and Ney, 2003).
J03-1005
If arbitrary reorderings are allowed, the search problem is NP-hard (Knight, 1999).
J99-4005
Using a loglinear model (Och and Ney, 2002), we obtain: Pr(eI1jfJ1 ) = exp ˆ MX m=1 ‚mhm(eI1;fJ1 ) ! ¢Z(fJ1 ) Here, Z(fJ1 ) denotes the appropriate normalization constant.
P02-1038
Investigations on the IBM constraints (Berger et al., 1996) for single-word based statistical machine translation can be found e.g. in (Tillmann and Ney, 2003).
J03-1005
Alternatively, one can train them with respect to the final translation quality measured by some error criterion (Och, 2003).
P03-1021
For further details, see (Och et al., 1999; Och and Ney, 2002).
P02-1038 W99-0604
Marcu and Wong (2002) present a joint probability model for phrase-based translation.
W02-1018
The key elements of this translation approach (Och et al., 1999) are the alignment templates.
W99-0604
It has been pointed out in (Zens and Ney, 2003) that the ITG constraints can be characterized as follows: a reordering violates the ITG constraints if and only if it contains (3;1;4;2) or (2;4;1;3) as a subsequence.
P03-1019
