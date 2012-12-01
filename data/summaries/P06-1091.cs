Moreover, under this view, SMT becomes quite similar to sequential natural language annotation problems such as part-of-speech tagging and shallow parsing, and the novel training algorithm presented in this paper is actually most similar to work on training algorithms presented for these task, e.g. the on-line training algorithm presented in (McDonald et al., 2005) and the perceptron training algorithm presented in (Collins, 2002).
P05-1012 W02-1001
We show translation results in terms of the automatic BLEU evaluation metric (Papineni et al., 2002) on the MT03 Arabic-English DARPA evaluation test set consisting of a212a89a212a89a87 sentences with a98a89a212a161a213a89a214a89a215 Arabic words with a95 reference translations.
P02-1040
The current approach does not use specialized probability features as in (Och, 2003) in any stage during decoder parameter training.
P03-1021
While being similar to (Tillmann and Zhang, 2005), the current procedure is more automated with comparable performance.
P05-1069
The novel algorithm differs computationally from earlier work in discriminative training algorithms for SMT (Och, 2003) as follows: a90 No computationally expensive a57 -best lists are generated during training: for each input sentence a single block sequence is generated on each iteration over the training data.
P03-1021
POSbased features, syntactic or hierarchical features (Chiang, 2005).
P05-1033
In modeling a block sequence, we emphasize adjacent block neighbors that have right or left orientation, since in the current experiments only local block swapping is handled (neutral orientation is used for ’detached’ blocks as described in (Tillmann and Zhang, 2005)).
P05-1069
The block set is generated using a phrase-pair selection algorithm similar to (Koehn et al., 2003; Al-Onaizan et al., 2004), which includes some heuristic filtering to mal statement here.
N03-1017
and Future Work The work in this paper substantially differs from previous work in SMT based on the noisy channel approach presented in (Brown et al., 1993).
J93-2003
Rather than predicting local block neighbors as in (Tillmann and Zhang, 2005), here the model parameters are trained in a global setting.
P05-1069
In this local re-ordering model (Tillmann and Zhang, 2005; Kumar and Byrne, 2005) a block a0 with orientation a1 is generated relative to its predecessor block a0a3a2. During decoding, we maximize the score a4a6a5a8a7 a0a10a9a11a13a12 a1 a9a11a15a14 of a block orientation sequence a16a18a17 a19a21a20a18a22a21a23a25a24a21a20a18a26a27a20 a28a30a29a32a31a15a33 a23a18a34a32a20 a35 a23a18a36a3a37 a33 a23a25a24a21a20a18a26 a38a3a26a27a36a3a23a18a20 a33a39a29 a40 a33 a41 a40a43a42 a36 a40 a34 a42 a40 a33 a44 a36 a22a45 a46 a40 a33 a40 a26 a36 a40 a45 a33 a45 a46 a34 a24 a34a47 a48 a23 a29 a36a3a26a27a37a21a23a18a49a27a20 a33 a33 a22 a24 a40 a24 a45 a40 a33 a50a43a51 a40 a33 a40 a33a51 a35a45 a40 a16a18a52 a16a25a53 a16a18a54 Figure 1: An Arabic-English block translation example, where the Arabic words are romanized.
H05-1021 P05-1069
A perceptronlike algorithm that handles global features in the context of re-ranking is also presented in (Shen et al., 2004).
N04-1023
We are able to achieve comparable performance to (Tillmann and Zhang, 2005).
P05-1069
The latter approach requires a decomposition of the decoding scheme into local decision steps with the inherent difficulty acknowledged in (Tillmann and Zhang, 2005).
P05-1069
While error-driven training techniques are commonly used to improve the performance of phrasebased translation systems (Chiang, 2005; Och, 2003), this paper presents a novel block sequence translation approach to SMT that is similar to sequential natural language annotation problems 727 such as part-of-speech tagging or shallow parsing, both in modeling and parameter training.
P03-1021 P05-1033
Word-based features are used as well, e.g. feature a75 a11a39a99a78a99a18a11 captures word-to-word translation de4On our test set, (Tillmann and Zhang, 2005) reports a BLEU score of a100a63a101a63a102a43a103 and (Ittycheriah and Roukos, 2005) reports a BLEU score of a104a89a103a63a102 a105 . pendencies similar to the use of Model a98 probabilities in (Koehn et al., 2003).
H05-1012 N03-1017 P05-1069
1. Although the training algorithm can handle realvalued features as used in (Och, 2003; Tillmann and Zhang, 2005) the current paper intentionally excludes them.
P03-1021 P05-1069
