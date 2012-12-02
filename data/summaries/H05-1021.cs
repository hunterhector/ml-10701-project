Phrase-pairs are then extracted from the word alignments (Koehn et al., 2003).
N03-1017
(ALL=02+03+04). For the combined set (ALL), we also show the 95% BLEU confidence interval computed using bootstrap resampling (Och, 2003).
P03-1021
Finally we use Minimum Error Training (MET) (Och, 2003) to train log-linear scaling factors that are applied to the WFSTs in Equation 1.
P03-1021
We also note the prior work of Wu (1996), closely related to Tillmann’s model.
P96-1021
Other researchers (Vogel, 2003; Zens and Ney, 2003; Zens et al., 2004) have reported performance gains in translation by allowing deviations from monotone word and phrase order.
C04-1030 P03-1019
Previous approaches to WFST-based reordering (Knight and Al-Onaizan, 1998; Kumar and Byrne, 2003; Tsukada and Nagata, 2004) constructed permutation acceptors whose state spaces grow exponentially with the length of the sentence to be translated.
N03-1019 W04-3255
Our reordering models do resemble those of (Tillmann, 2004; Tillmann and Zhang, 2005) in that we 167 treat the reordering as a sequence of jumps relative to the original phrase sequence, and that the likelihood of the reordering is assigned through phrasepair specific parameterized models.
P05-1069
However allowing reordering in translation is computationally expensive and in some cases even provably NP-complete (Knight, 1999).
J99-4005
The IBM translation models (Brown et al., 1993) describe word reordering via a distortion model defined over word positions within sentence pairs.
J93-2003
The 1000-best lists are augmented with IBM Model-1 (Brown et al., 1993) scores and then rescored with a second set of MET parameters.
J93-2003
WFST Reordering Model The Translation Template Model (TTM) is a generative model of phrase-based translation (Brown et al., 1993).
J93-2003
The Alignment Template Model (Och et al., 1999) uses phrases rather than words as the basis for translation, and defines movement at the level of phrases.
W99-0604
