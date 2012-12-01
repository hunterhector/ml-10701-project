References Bar-Haim, R., Dagan, I., Dolan, B., Ferro, L., Giampiccolo, D., Magnini, B., et al.(2006). The Second PASCAL Recognising Textual Entailment Challenge.
P06-1057
Textual Entailment Recognition (RTE) (Dagan et al., 2006) has recently been proposed as an application independent task to capture such inferences.
P06-1057
Most systems did not use sense tagged data for disambiguation though MELB did use SemCor (Miller et al., 1993b) for filtering infrequent synonyms and UNT used a semi-supervised word sense disambiguation combined with a host of other techniques, including machine translation engines.
H93-1061
Lillian Lee. 1999. Measures of distributional similarity.
P99-1004
It is our first attempt to RTE and we have taken profit of an analysis of the approaches followed in previous challenges (see (Dagan et al., 2005), and (Bar-Haim et al., 2006) for overviews of RTE-1 and RTE-2).
P06-1057
The lexical substitution task follows on from some previous ideas (McCarthy, 2002) to examine the capabilities of WSD systems built by researchers on a task which has potential for NLP applications.
W02-0816
We also produced best and oot baselines using the distributional similarity measures l1, jaccard, cosine, lin (Lin, 1998) and SD (Lee, 1999) 4.
P99-1004
ilarity measures in a different task for Lee (1999)
P99-1004
Finding alternative words that can occur in given contexts would potentially be useful to many applications such as question answering, summarisation, paraphrase acquisition (Dagan et al., 2006), text simplification and lexical acquisition (McCarthy, 2002).
P06-1057 W02-0816
Notice that our calculation of the MFS is based on the frequencies in the SemCor corpus (Miller et al., 1993), as we exploit WordNet sense rankings.
H93-1061
There exists already many interesting approaches to this problem, see (Dagan et al., 2005; Bar-Haim et al., 2006) for various recent efforts and our paper wont try to fully reinvent the wheel.
P06-1057
The results obtained, using the accuracy measure that is the fraction of correct responses according to (Dagan et al., 2006), are shown in table 1.
P06-1057
Existing hand-annotated corpora like SemCor (Miller et al., 1993), which is annotated with WordNet senses (Fellbaum, 1998) allow for a small improvement over the simple most frequent sense heuristic, as attested in the all-words track of the last Senseval competition (Snyder and Palmer, 2004).
H93-1061
detection P =summationtext mwsysi?MWsys 1 if mwi exists at i |MWsys| (9) detection R =summationtext mwsysi?MW 1 if mwi exists at i |MW| (10) identification P = summationtext mwsysi?MWsys 1 if mwsysi = mwi |MWsys| (11) 50 identification R = summationtext mwsysi?MW 1 if mwsysi = mwi |MW| (12) 3.1 Baselines We produced baselines using WordNet 2.1 (Miller et al., 1993a) and a number of distributional similarity measures.
H93-1061
Compared with WordNet (Miller et al., 1993)?? which has been used widely in QA?FrameNet, PropBank and VerbNet are still relatively new, and therefore their usefulness for QA has still to be proven.
H93-1061
To overcome this problem several approaches have been studied, being the Recognising Textual Entailment Challenge (RTE) (BarHaim et al., 2006; Dagan et al., 2006) the most referred source for determining which one is the most accurate.
P06-1057
In previous RTE challenges (Dagan et al., 2006; Bar-Haimetal., 2006), severalmachine-learningapproaches appeared, but their results showed that significant improvements were still necessary.
P06-1057
[Bar-Haim, Dagan, et al.2006] We do recognize that some of our metrics have already been employed by other teams [Jijkoun and Rijke, 2005] and that our results may be different because of the thesaurus corpus we employed and the classification strategy we used.
P06-1057
George Miller, Richard Beckwith, Christine Fellbaum, David Gross, and Katherine Miller, 1993a.
H93-1061
