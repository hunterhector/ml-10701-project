Tuning is fully automatic, as opposed to (Matusov et al., 2006) where global system weights were set manually.
E06-1005
Also, a more heuristic alignment method has been proposed in a different system combination approach (Jayaraman and Lavie, 2005).
P05-3026
Och. 2003.
J03-1002 P03-1021
In (Rosti et al., 2007), simple a0 a75a27a13 a0 a66a1a0 a19 score was assigned to the word coming from the a0 thbest hypothesis.
N07-1029
Compared to the baseline from (Rosti et al., 2007), the new method improves the BLEU scores significantly.
N07-1029
The improved system combination method was compared to a simple confusion network decoding without system weights and the method proposed in (Rosti et al., 2007) on the Arabic to English and Chinese to English NIST MT05 tasks.
N07-1029
The same Powell’s method has been used to estimate feature weights of a standard feature-based phrasal MT decoder in (Och, 2003).
J03-1002 P03-1021
Six MT systems were combined: three (A,C,E) were phrasebased similar to (Koehn, 2004), two (B,D) were hierarchical similar to (Chiang, 2005) and one (F) was syntax-based similar to (Galley et al., 2006).
P05-1033 P06-1121
In (Rosti et al., 2007), the total confidence of the a1 th best confusion network hypothesis a3 a38a3a2a32, including NULL words, given the a4 th source sentence a5 a38 was given by a73a42a13 a3 a38a3a2 a32a7a6 a5 a38 a19a22a21 (5) a35a9a8a11a10 a35 a31 a39 a33a36a35 a35a37a36 a31 a12 a33a36a35 a13 a12 a73a15a14 a12 a39 a66a1a16a44a63 a32a18a17 a12a19a12 a19 a13 a3 a38a3a2 a32 a19 where a63 a38 is the number of nodes in the confusion network for the source sentence a5 a38, a63 a19 is the number of translation systems, a13 a12 is the a20 th system weight, a73a21a14 a12a39 is the accumulated confidence for word a22 produced by system a20 between nodes a23 and a23 a66 a0, and a16 is a weight for the number of NULL links along the hypothesis a63 a32a24a17 a12a25a12 a19 a13 a3 a38a26a2a32 a19 . The word confidences a73a21a14 a12a39 were increased by a0 a75a27a13 a0 a66a27a0 a19 if the word a22 aligns between nodes a23 and a23 a66 a0 in the network.
N07-1029
This work was extended in (Rosti et al., 2007) by introducing system weights for word confidences.
N07-1029
Metrics Currently, the most widely used automatic MT evaluation metric is the NIST BLEU-4 (Papineni et al., 2002).
P02-1040
Optimization The optimization of the system and feature weights may be carried out using a63 -best lists as in (Ostendorf et al., 1991).
H91-1013
It has been argued that METEOR correlates better with human judgment due to higher weight on recall than precision (Banerjee and Lavie, 2005).
W05-0909
In (Matusov et al., 2006), different word orderings are taken into account by training alignment models by considering all hypothesis pairs as a parallel corpus using GIZA++ (Och and Ney, 2003).
E06-1005 J03-1002 P03-1021
The idea of combining outputs from different MT systems to produce consensus translations in the hope of generating better translations has been around for a while (Frederking and Nirenburg, 1994).
A94-1016
This example has three confusion networks with priors a53a27a54a72a71, a53a27a54a1a0 and a53a27a54a1a2 . The total number of nodes in the network is represented by a63a4a3 . Similar combination of multiple confusion networks was presented in (Matusov et al., 2006).
E06-1005
