This preprocessing technique we use here is the best performer amongst other explored techniques presented in Habash and Sadat (2006).
N06-2013
Error intervals were computed using bootstrap resampling (Koehn, 2004b).
W04-3250
This reduction can be achieved by increasing training data or via morphologically driven preprocessing (Goldwater and McClosky, 2005).
H05-1085
We use an off-the-shelf phrase-based SMT system, Portage (Sadat et al., 2005).
W05-0822
We do not use any additional information to remove specific features using alignments or syntax (unlike, e.g. removing all but one Al+ in noun phrases (Lee, 2004)).
N04-4015
Similarly to Habash and Sadat (2006), the set of schemes we explore are all word-level.
N06-2013
Approaches to combination generally either select one of the hypotheses produced by the different systems combined (Nomoto, 2004; Paul et al., 2005; Lee, 2005) or combine lattices/n-best lists from the different systems with different degrees of synthesis or mixing (Frederking and Nirenburg, 1994; Bangalore et al., 2001; Jayaraman and Lavie, 2005; Matusov et al., 2006).
A94-1016 E06-1005 P04-1063 P05-3026
It is identical to the initial tokenization used by Lee (2004).
N04-4015
For training, Portage uses IBM word alignment models (models 1 and 2) trained in both directions to extract phrase tables in a manner resembling (Koehn, 2004a).
W04-3250
In a previous publication, we presented results describing six preprocessing schemes for Arabic (Habash and Sadat, 2006).
N06-2013
The Portage decoder, Canoe, is a dynamic-programming beam search algorithm resembling the algorithm described in (Koehn, 2004a).
W04-3250
L1 uses the simple POS tags advocated by Habash and Rambow (2005) (15 tags); while L2 uses the reduced tag set used by Diab et al.(2004) (24 tags).
N04-4038 P05-1071
Specifically considering Arabic, Lee (2004) investigated the use of automatic alignment of POS tagged English and affix-stem segmented Arabic to determine appropriate tokenizations.
N04-4015
To select among these analyses, we use the Morphological Analysis and Disambiguation for Arabic (MADA) tool,2 an off-theshelf resource for Arabic disambiguation (Habash and Rambow, 2005).
P05-1071
Table 5: DRC Approach Results Combination Decoding Rescoring Scheme 1-best Standard+PPL D2 37.16 All schemes TB 38.24 38.67 D1 37.89 WA 36.91 ON 36.42 ST 34.27 EN 30.78 MR 34.65 D3 34.73 L2 32.25 L1 30.47 D2 37.39 4 best schemes TB 37.53 37.73 D1 36.05 WA 37.53 Table 6: Statistical Significance using Bootstrap Resampling DRC ROC D2 TB D1 WA ON 100 0 0 0 0 0 0 97.7 2.2 0.1 0 0 0 92.1 7.9 0 0 0 98.8 0.7 0.3 0.2 53.8 24.1 22.1 59.3 40.7 6.3 Significance Test We use bootstrap resampling to compute MT statistical significance as described in (Koehn, 2004a).
W04-3250
Recent publications on the effect of morphology on SMT quality focused on morphologically rich languages such as German (Nießen and Ney, 2004); Spanish, Catalan, and Serbian (Popovi´c 1 and Ney, 2004); and Czech (Goldwater and McClosky, 2005).
H05-1085
The POS tag set used is the reduced Arabic Treebank tag set (24 tags) (Maamouri et al., 2004; Diab et al., 2004).
N04-4038
Decoding weights are optimized using Och’s algorithm (Och, 2003) to set weights for the four components of the loglinear model: language model, phrase translation model, distortion model, and word-length feature.
P03-1021
