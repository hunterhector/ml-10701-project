Discriminative training with hidden variables has been handled in this probabilistic framework (Quattoni et al., 2004; Koo and Collins, 2005), but we choose Equation 3 for efficiency.
H05-1064
The discrepancy between DEV performance and TEST performance is due to temporal distance from TRAIN and high variance in BLEU score.11 We also compared our model with Pharaoh (Koehn et al., 2003).
N03-1017
For instance, Och et al.(2004) reported that a 1000-best list was required to achieve performance gains from reranking.
N04-1021
The phrase-based model of Koehn et al.(2003) is an instance of this framework.
N03-1017
We tuned Pharaoh’s four parameters using minimum error rate training (Och, 2003) on DEV.12 We obtained an increase of 0.8 9As in the POS features, we map each phrase pair to its majority constellation.
P03-1021
The process of phrase extraction is difficult to optimize in a non-discriminative setting: many heuristics have been proposed (Koehn et al., 2003), but it is not obvious which one should be chosen for a given language pair.
N03-1017
2.2 Perceptron-based training To tune the parameters w of the model, we use the averaged perceptron algorithm (Collins, 2002) because of its efficiency and past success on various NLP tasks (Collins and Roark, 2004; Roark et al., 2004).
P04-1007 P04-1015 W02-1001
To facilitate comparison with previous work, we created the translation tables using the same techniques as Koehn et al.(2003).3 The language model was a Kneser-Ney interpolated trigram model generated using the SRILM toolkit (Stolcke, 2002).
N03-1017
constellation features Koehn et al.(2003) demonstrated that choosing the appropriate heuristic for extracting phrases is very important.
N03-1017
We experimented with two levels of distortion: monotonic, where the phrasal alignment is monotonic (but word reordering is still possible within a phrase) and limited distortion, where only adjacent phrases are allowed to exchange positions (Zens and Ney, 2004).
N04-1033
Tillmann and Zhang (2005) present a discriminative approach based on local models.
P05-1069
At the end we ran our models once on TEST to get final numbers.2 4 Models Our experiments used phrase-based models (Koehn et al., 2003), which require a translation table and language model for decoding and feature computation.
N03-1017
In the future, we plan to explore our discriminative framework on a full distortion model (Koehn et al., 2003) or even a hierarchical model (Chiang, 2005).
N03-1017 P05-1033
Finally, we use POS features to parameterize a distortion model in a limited distortion decoder (Zens and Ney, 2004; Tillmann and Zhang, 2005).
N04-1033 P05-1069
6We used sentences of length 5–15 to facilitate comparisons with Koehn et al.(2003) and to enable rapid experimentation with various feature sets.
N03-1017
The proposed system is phrase-based, as in Koehn et al.(2003), but uses an online perceptron training scheme to learn model parameters.
N03-1017
The first approach is to reuse the components of a generative model, but tune their relative weights in a discriminative fashion (Och and Ney, 2002; Och, 2003; Chiang, 2005).
P02-1038 P03-1021 P05-1033
For example, we would like to know that if a (JJ, JJ) 7We also tried using word clusters (Brown et al., 1992) instead of POS but found that POS was more helpful.
J92-4003
Unlike minimum error rate training (Och, 2003), our system is able to exploit large numbers of specific features in the same manner as static reranking systems (Shen et al., 2004; Och et al., 2004).
N04-1021 N04-1023 P03-1021
Lexical language model features have been exploited successfully in discriminative language modeling to improve speech recognition performance (Roark et al., 2004).
P04-1007
13This result is significant with p-value 0.0585 based on approximate randomization (Riezler and Maxwell, 2005).
W05-0908
The heuristics in Koehn et al.(2003) decide whether to extract a given phrase pair based on the underlying word alignments (see Figure 3 for three examples), which we call constellations.
N03-1017
Another example of this framework is the hierarchical model of Chiang (2005).
P05-1033
The second approach is to use reranking, in which a baseline classifier generates an n-best list of candidate translations, and a separate discriminative classifier chooses amongst them (Shen et al., 2004; Och et al., 2004).
N04-1021 N04-1023
