The Mathematics of Statistical Machine Translation: Parameter Estimation, Computational Linguisics vol 19(2) 1993 George Foster 2000.
P00-1006
1328-1335. Montreal Kenji Yamada and Kevin Knight 2001.
P01-1067
(Marcu, Wong, 2002) illustrate the effects of assuming that lexical correspondence can only be modeled at the word level, and motivate a joint probability model that explicitly generates phrase level lexical content across both languages.
W02-1018
Both (Marcu, Wong, 2002; Wu, 1995) model the reordering phenomenon effectively, but at significant computational expense, and tend to be difficult to scale to long sentences.
W02-1018
BLEU: A Method for Automatic Evaluation of Machine Translation, IBM Research Report, RC22176 Stephan Vogel, Hermann Ney, and Christoph Tillmann 1996.
C96-2141
Direct translation approaches (Foster, 2000) consider estimating a31 a0a15a14a9a33a1a34a13 directly, and work by (Och and Ney, 2002) show that similar or improved results are achieved by replacinga31 a0a2a1a20a33a14a39a13 in the optimization witha31 a0a15a14a35a33a1a26a13, at the cost of deviating from the Bayesian framework.
P00-1006 P02-1038
Re-ordering effects across languages have been modeled in several ways, including word-based (Brown et al., 1993), template-based (Och et al., 1999) and syntax-based (Yamada, Knight, 2001).
J93-2003 P01-1067 W99-0604
of Chinese and English words tracts phrases by harvesting the Viterbi path from an HMM alignment model (Vogel et al., 1996).
C96-2141
a31 a0a15a14a168a69 a77 a33a1a119a169 a25 a13a158a3 a86 a44 a60a87a22 a46 a56a89a88a91a90a26a23a66a92 a0 a77 a13 a99 a128 a130a26a131a171a170a132a152a172 a86 a44 a60a87a22 a46 a56a89a88a91a90a26a23a66a92 a0 a136 a77 a13 (10) (10) calculates direct translation probabilities, ie a31 a0a15a14a35a33a1a26a13 . As mentioned earlier, (Och and Ney, 2002), show that using direction translation estimates in the decoding process as compared with calculating a31 a0a2a1a38a33a14a19a13 as prescribed by the Bayesian framework does not reduce translation quality.
P02-1038
Within the generative model, the Bayes reformulation is used to estimate a31 a0a15a14a35a33a1a26a13a37a36 a31 a0a15a14a19a13 a31 a0a2a1a38a33a14a39a13 where a31 a0a15a14a39a13 is considered the language model, and a31 a0a2a1a38a33a14a19a13 is the translation model; the IBM (Brown et al., 1993) models being the de facto standard.
J93-2003
Reasons to introduce phrase level translation knowledge sources have been adequately shown and confirmed by (Och, Ney, 2000), and we focus on methods to build these sources from existing, mature components within the translation process.
C00-2163
MT Evaluation Kit Version 9, www.nist.gov/speech/tests/mt/ Franz Josef Och, Hermann Ney 2002.
P02-1038
The most likely alignment pattern between a source and target sentence under the trained alignment model will be referred to as the maximum approximation, which under HMM alignment (Vogel et al., 1996) model corresponds to the Viterbi path.
C96-2141
Statistical Machine Translation defines the task of translating a source language sentence a0a2a1a4a3 a1a6a5a8a7a9a7a9a7a10a1a12a11a12a13 into a target language sentence a0a15a14a16a3 a14a5 a7a9a7a9a7a17a14a19a18a20a13. The traditional framework presented in (Brown et al., 1993) assumes a generative process where the source sentence is passed through a noisy stochastic process to produce the target sentence.
J93-2003
of the 38th Annual Meeting of the Association for Computational Linguistics Daniel Marcu and William Wong 2002.
W02-1018
Saarbrucken, Germany Franz Josef Och, Christoph Tillmann, Hermann Ney 1999.
W99-0604
To implement our phrase extraction technique, the maximum approximation alignments were combined with the union operation as described in (Och et al., 1999), resulting in a dense but inaccurate alignment map as measured against a human aligned gold standard.
W99-0604
