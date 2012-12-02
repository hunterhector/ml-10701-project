Similarly, (Koehn et al., 2003) propose a relative distortion model to be used with a phrase decoder.
N03-1017
Trying all possible word reordering is an NP-Complete problem as shown in (Knight, 1999), which makes searching for the optimal solution among all possible permutations computationally intractable.
J99-4005
Any aligner such as (Al-Onaizan et al., 1999) or (Vogel et al., 1996) can be used to obtain word alignments.
C96-2141
Results The phrase-based decoder we use is inspired by the decoder described in (Tillmann and Ney, 2003) and similar to that described in (Koehn, 2004).
J03-1005 N04-4026
The word reorderings that are explored by the search algorithm are controlled by two parameters s and w as described in (Tillmann and Ney, 2003).
J03-1005
(Yamada and Knight, 2002) propose a syntax-based decoder that restrict word reordering based on reordering operations on syntactic parse-trees of the input sentence.
P02-1039
The beam search algorithm attempts to find the translation (i.e., hypothesis that covers all source words) with the minimum cost as in (Tillmann and Ney, 2003) and (Koehn, 2004) . The distortion cost is added to the log-linear mixture of the hypothesis extension in a fashion similar to the language model cost.
J03-1005 N04-4026
N-gram language models have also been used in Statistical Machine Translation (SMT) as proposed by (Brown et al., 1990; Brown et al., 1993).
J90-2002 J93-2003
Only phrases that conform to the so-called consistent alignment restrictions (Och et al., 1999) are extracted.
W99-0604
(Xia and McCord, 2004) propose a method to automatically acquire rewrite patterns that can be applied to any given input sentence so that the rewritten source and target sentences have similar word order.
C04-1073
Distortion models were first proposed by (Brown et al., 1993) in the so-called IBM Models.
J93-2003
However, their decoder is outperformed by phrase-based decoders such as (Koehn, 2004), (Och et al., 1999), and (Tillmann and Ney, 2003). Phrase-based SMT decoders mostly rely on the language model to select among possible word order choices.
J03-1005 N03-1017 W99-0604
This new model leads to significant improvements in MT quality as measured by BLEU (Papineni et al., 2002).
P02-1040
(Wu, 1996) propose using contiguity restrictions on the reordering.
P96-1021
(Tillmann et al., 1997) proposed a DP-based monotone search algorithm for SMT.
P97-1037
This observation is also reported by (Xia and McCord, 2004).We argue that the distortion model we propose leads to a better translation as measured by BLEU.
C04-1073
(Och et al., 2004; Tillman, 2004) propose orientation-based distortion models lexicalized on the phrase level.
N04-1021
For a comparison and a more detailed discussion of the two approaches see (Zens and Ney, 2003).
P03-1019
(Och et al., 1999; Tillmann and Ney, 2003) relax the monotonicity restriction in their phrase-based decoder by allowing a restricted set of word reorderings.
J03-1005 W99-0604
Reordering restrictions for word-based SMT decoders were introduced by (Berger et al., 1996) and (Wu, 1996).
P96-1021
