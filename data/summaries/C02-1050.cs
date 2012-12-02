Germann et al.(2001) suggested greedy method and integer programming decoding, though the rst method su er from the similar problem as described above and the second is impractical for the real-world application.
P01-1030
According to the Bayes Rule, the problem is transformed into the noisy channel model paradigm, where the translation is the maximum a posteriori solution of a distribution for a channel target text given a channel source text and a prior distribution for the channel source text (Brown et al., 1993).
J93-2003
The skipping based criteria, such as introduced by Och et al.(2001), is not appropriate for the language pairs with drastically di erent alignment, such as Japanese and English, hence was not considered in this paper.
W01-1408
The translation results were evaluated by worderror-rate (WER) and position independent worderror-rate (PER) (Watanabe et al., 2002; Och et al., 2001).
W01-1408
Complexity The computational complexity for the left-to-right and right-to-left is the same, O(jEj3m22m), as reported by Tillmann and Ney (2000), in which jEj is the size of the vocabulary for output sentences 3.
C00-2123
NULL Translation Model p1 : A xed probability of inserting a NULL word after determining each target word f. For details, refer to Brown et al.(1993). 2.2 Search Problem The search problem of statistical machine translation is to induce the maximum likely channel source sequence, e, given f and the model, P(fje) =P a P(f;aje) and P(e).
J93-2003
This problem is known to be NP-Complete (Knight, 1999), for the re-ordering property in the model further complicates the search.
J99-4005
Under this constraint, many researchers had contributed algorithms and associated pruning strategies, such as Berger et al.(1996), Och et al.(2001), Wang and Waibel (1997), Tillmann and Ney (2000) GarciaVarea and Casacuberta (2001) and Germann et al.(2001), though they all based on almost linearly Translation Model Lexical ModelQ t( f jjei) Fertility ModelQ n( ijei) Distortion Model Head Qd1( j c ijA(e i )B( f j)) Non-Head Qd1>( j j0jB( f j)) NULL Translation Model m 0 0 pm 2 00 p 01 Figure 2: Translation Model (IBM Model 4) aligned language pairs, and not suitable for language pairs with totally di erent alignment correspondence, such as Japanese and English.
C00-2123 P01-1030 P97-1047 W01-1408
The list of zero fertility words can be obtained from the viterbi alignment of training corpus (Germann et al., 2001).
P01-1030
There exists stack decoding algorithm (Berger et al., 1996), A* search algorithm (Och et al., 2001; Wang and Waibel, 1997) and dynamic-programming algorithms (Tillmann and Ney, 2000; Garcia-Varea and Casacuberta, 2001), and all translate a given input string word-by-word and render the translation in left-to-right, with pruning technologies assuming almost linearly aligned translation source and target texts.
C00-2123 P97-1047 W01-1408
The translation of f j can be computed either by inverse translation table (Och et al., 2001; Al-Onaizan et al., 1999).
W01-1408
Algorithms The decoding methods presented in this paper explore the partial candidate translation hypotheses greedily, as presented in Tillmann and Ney (2000) and Och et al.(2001), and operation applied to each hypothesis is similar to those explained in Berger et al.(1996), Och et al.(2001) and Germann et al.(2001). The algorithm is depicted in Algorithm 1 where C = fjk : k = 1:::jCjg represents a set of input string position 1.
C00-2123 P01-1030 W01-1408
