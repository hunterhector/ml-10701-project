Supervised learning techniques, such as perceptron learning, maximum entropy modeling or maximum weighted bipartite matching, have been shown to provide further improvements on word alignments (Ayan et al., 2005; Moore, 2005; Ittycheriah and Roukos, 2005; Taskar et al., 2005).
H05-1009 H05-1010 H05-1011 H05-1012
FranzJ.Och. 2003.
J03-1002 P03-1021
For maximum phrase length, we used 3 (based onwhatwassuggestedby(Koehn etal., 2003)and 7(thedefaultmaximumphraselengthinPharaoh).
N03-1017
MT output was evaluated using the standard evaluation metric BLEU (Papineni et al., 2002).2 The parameters of the MT System were optimized for BLEU metric on NIST MTEval’2002 test sets using minimum error rate training (Och, 2003), and the systems were tested on NIST MTEval’2003 test sets for both languages.
J03-1002 P02-1040 P03-1021
We therefore adopted a modified weighting scheme following(Koehnetal., 2003), whichincorporates NULL alignments.
N03-1017
In recent years, phrase-based systems (Koehn, 2004; Chiang, 2005) have been shown to outperform word-based MT systems; therefore,inthispaper,weuseapublicly-available phrase-based MT system, Pharaoh (Koehn, 2004), to investigate the impact of different alignments.
P05-1033
Work Starting with the IBM models (Brown et al., 1993), researchers have developed various statistical word alignment systems based on different models, such as hidden Markov models (HMM) (Vogel et al., 1996), log-linear models (Och and Ney, 2003), and similarity-based heuristic methods (Melamed, 2000).
C00-2163 C96-2141 J00-2004 J03-1002 J93-2003 P03-1021
Each uni-directional alignment is the result of running GIZA++ (Och, 2000b) in one of two directions (source-to-target and vice versa) with default configurations.
C00-2163
The state-of-the art evaluation metric— alignment error rate (AER)—attempts to balance the precision and recall scores at the level of alignment links (Och and Ney, 2000).
C00-2163
In recent years, researchers have shown that even using a limited amount of manually aligned data improves word alignment significantly (Callison-Burch et al., 2004).
P04-1023
Other metrics assess the impact of alignments externally, e.g., different alignments are tested by comparing the corresponding MT outputs using automated evaluation metrics (e.g., BLEU (Papineni et al., 2002) or METEOR (Banerjee and Lavie, 2005)).
P02-1040 W05-0909
Moore. 2005.
H05-1011
Although it is possible to estimate phrases directly from a training corpus (Marcu and Wong, 2002), most phrase-based MT systems (Koehn, 2004; Chiang, 2005) start with a word alignment and extract phrases that are consistent with the given alignment.
P05-1033 W02-1018
However, these studies showed that AER and BLEU do not correlate well (Callison-Burch et al., 2004; Goutte et al., 2004; Ittycheriah and Roukos, 2005).
H05-1012 P04-1023 P04-1064
FranzJ.Och. 2000b.
C00-2163
Two supervised alignment combination techniques (SA and SB) using 2 and 4 input alignments as described in (Ayan et al., 2005).
H05-1009
The details of how the annotations are done can be found in (Ayan et al., 2005) and (Ittycheriah and Roukos, 2005).
H05-1009 H05-1012
