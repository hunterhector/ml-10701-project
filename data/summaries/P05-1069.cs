Two block sets are derived for each of the training sets using a phrase-pair selection algorithm similar to (Koehn et al., 2003; Tillmann and Xia, 2003).
N03-1017 N03-2036
During decoding, we generate a ’translation graph’ for every input sentence using a procedure similar to (Ueffing et al., 2002): a translation graph is a compact way of representing candidate translations which are close in terms of likelihood.
W02-1021
4. As in (Tillmann, 2004), we model the block bigram probability as a27 a14 a9 a24 a19 a10 a24 a82 a84 a78 a19 a81 a87 a29 a9 a24a164a30 a18 a19 a10 a24a31a30 a18 a21 in Eq.
N04-4026
Orientation Bigrams This section describes a phrase-based model for SMT similar to the models presented in (Koehn et al., 2003; Och et al., 1999; Tillmann and Xia, 2003).
N03-1017 N03-2036 P03-1021 W99-0604
This might be achieved by introducing orientation sequences over phrase types that have been used in ((Schafer and Yarowsky, 2003)).
W03-1002
Experimental results are reported in Table 2: here cased BLEU results are reported on MT03 Arabic-English test set (Papineni et al., 2002).
P02-1040
Weighting The lexical weight a27 a14a12a91 a29 a92a93a21 of the block a9 a72 a14a12a91 a19a86a92a93a21 is computed similarly to (Koehn et al., 2003), but the lexical translation probability a27 a14a12a94 a29 a97a100a21 is derived from the block set itself rather than from a word alignment, resulting in a simplified training.
N03-1017
Instead of directly minimizing error as in earlier work (Och, 2003), we decompose the decoding process into a sequence of local decision steps based on Eq.
P03-1021
A DP-based beam search procedure identical to the one used in (Tillmann, 2004) is used to maximize over all oriented block segmentations a14 a9a88a16a18 a19 a10 a16a18 a21 . During decoding orientation bigrams a14 a9 a11 a19 a78 a19a43a9a107a21 with left orientation are only generated if a74a157a158 a14 a9a107a21a166a165 a152 for the successor block a9 . 3 Localized Block Model and Discriminative Training In this section, we describe the components used to compute the block bigram probability a27 a14 a9 a24 a19 a10 a24a17a29 a9 a24a31a30 a18 a19 a10 a24a31a30 a18 a21 in Eq.
N04-4026
We use an orientation model similar to the lexicalized block re-ordering model in (Tillmann, 2004; Och et al., 2004): to generate a block a9 with orientation a10 relative to its predecessor block a9a12a11. During decoding, we compute the probability a13a15a14 a9a17a16a18a20a19 a10 a16a18a6a21 of a block sequence a9a17a16a18 with orientation a10 a16a18 as a product of block bigram probabilities: a13a15a14 a9 a16a18 a19 a10 a16a18 a21a23a22 a16 a24a26a25 a18a28a27 a14 a9 a24 a19 a10 a24a17a29 a9 a24a31a30 a18 a19 a10 a24a31a30 a18 a21a12a19 (1) a32a34a33 a35a37a36a34a38a40a39a34a41a37a36a34a42a43a36 a44a46a45a31a47a46a48 a39a34a49a31a36 a50 a39a34a51a17a52 a48 a39a34a41a37a36a34a42 a53a54a42a43a51a17a39a34a36 a48a31a45 a55 a48 a56 a55a58a57 a51 a55 a49 a57 a55 a48 a59 a51 a38a60 a61 a55 a48 a55 a42 a51 a55 a60 a48 a60 a61 a49 a41 a49a62 a63 a39 a45 a51a17a42a43a52a40a39a34a64a43a36 a48 a48 a38 a41 a55 a41 a60 a55 a48 a65a67a66 a55 a48 a55 a48a66 a50a60 a55 a32a34a68 a32a34a69 a32a71a70 Figure 1: An Arabic-English block translation example, where the Arabic words are romanized.
N04-4026
Our modified training procedure is related to the discriminative re-ranking procedure presented in (Shen et al., 2004).
N04-1023
Section 4 describes the online training procedure and compares it to the well known perceptron training algorithm (Collins, 2002).
W02-1001
As far as the log-linear combination of float features is concerned, similar training procedures have been proposed in (Och, 2003).
P03-1021
Lexical Weighting: (e) the lexical weight a27 a14a12a91 a29 a92a93a21 of the block a9 a72 a14a12a91 a19a86a92a93a21 is computed similarly to (Koehn et al., 2003), details are given in Section 3.4.
N03-1017
2. For details see (Tillmann, 2004).
N04-4026
A related method is multi-category perceptron, which explicitly finds a weight vector that separates correct labels from the incorrect ones in a mistake driven fashion (Collins, 2002).
W02-1001
