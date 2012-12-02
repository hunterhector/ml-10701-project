We compute the union and the intersection of the two alignment relations a75 a64 and a75a103a93 : a104 a76 a75 a64a106a105 a75a103a93 a107 a76 a75 a64a106a108 a75 a93 We call the intersection relation a104, because it represents a high-precision alignment, and the union alignment a107, because it is taken to be a lower precision higher recall alignment (Och and Ney, 2000).
P00-1056
The blocks are simpler than the alignment templates (Och et al., 1999) in that they do not have an internal structure.
W99-0604
Generation Algorithm Starting point for the block generation algorithm is a word alignment obtained from an HMM Viterbi training (Vogel et al., 1996).
C96-2141
Various papers use phrase-based translation systems (Och et al., 1999; Marcu and Wong, 2002; Yamada and Knight, 2002) that have shown to improve translation quality over single-word based translation systems introduced in (Brown et al., 1993).
J93-2003 P02-1039 W02-1018 W99-0604
probability a5a7a6a9a8 a0a10a1a3a12a11 is decomposed into conditional probabilities using the chain rule: a5a13a6a14a8 a0 a1a3a15a11a17a16 a1 a18 a19a21a20 a3 a5a7a6a9a8 a0 a19a23a22 a0 a19a25a24 a3 a11 (1) a26 a1 a18 a19a21a20 a3a28a27a30a29 a8 a0 a19 a11a32a31 a27a34a33 a3 a24 a29a36a35 a8 a0 a19 a22 a0 a19a25a24 a3 a11 We try to find the block sequence that maximizes a5a7a6a9a8 a0a37a1a3a12a11 : a0a37a1a3 a26a39a38a15a40a42a41a12a43a44a38a2a45a47a46a42a48a49 a5a13a6a14a8 a0a37a1a3a36a11 . The model proposed is a joint model as in (Marcu and Wong, 2002), since target and source phrases are generated jointly.
W02-1018
In this paper, we present a block generation algorithm similar to the one in (Och et al., 1999) in full detail: source intervals are projected into target intervals under a restriction derived from a high-precision word alignment.
W99-0604
Projection of phrases has also been used in (Yarowsky et al., 2001).
H01-1035
These blocks are used to compute the results in the fourth column: the BLEU score (Papineni et al., 2002) with a153 reference translation using a153 -grams along with 95% confidence interval is reported 4.
P02-1040
(Och et al., 1999) describe the alignment template system for statistical MT: alignment templates correspond to blocks that do have an internal structure.
W99-0604
The same beam-search pruning as described in (Tillmann and Ney, 2003) is used.
J03-1005
Yamada and Knight (2002) presents a decoder for syntax-based MT that uses so-called phrasal translation units that correspond to blocks.
P02-1039
A word link extension algorithm similar to the one presented in this paper is given in (Koehn et al., 2003).
N03-1017
Marcu and Wong (2002) use a joint probability model for blocks where the clumps are contiguous phrases as in this paper.
W02-1018
3 DP-based Decoder We use a DP-based beam search procedure similar to the one presented in (Tillmann and Ney, 2003).
J03-1005
