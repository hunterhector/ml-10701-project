For Chinese, (Sproat et al., 1994) used the word unigram model in their word segmenter based on weighted finite-state transducer.
P94-1010
\[Nagata, 1996\] Masaaki Nagata.
C96-2136
The application of the word segmenter is described elsewhere (Nagata, 1996).
C96-2136
For Japanese, (Nagao and Mori, 1994) proposed a method of computing an arbitrary length character N-gram, and showed that the character N-gram statistics obtained from a large corpus includes information useful for word extraction.
C94-1101
(Chang et al., 1995) proposed an automatic dictionary construction method for Chinese from a large unsegmented corpus (311591 sentences) with the help of a small segmented seed corpus (1000 sentences).
W95-0109
\[Sproat et al., 1994\] Richard Sproat, Chinlin Shih, William Gale, and Nancy Chang.
P94-1010
\[Weischedel et al., 1993\] Ralph Weischedel, Marie Meteer, Richard Schwartz, Lance Ramshaw, and Jeff Palmucci.
J93-2006
Second, we devised a method to obtain the expected word N-gram count in the target texts, using an N-best word segmentation algorithm (Nagata, 1994).
C94-1032
Generalized Forward Backward Reestimation Generalization of the Forward and Viterbi Algorithm In English part of speech taggers, the maximization of Equation (1) to get the most likely tag sequence, is accomplished by the Viterbi algorithm (Church, 1988), and the maximum likelihood estimates of the parameters of Equation (2) are obtained from untagged corpus by the ForwardBackward algorithm (Cutting et al., 1992).
A88-1019 A92-1018
52 0.2 \[~i -~ 0.1 ~ ~ Figure 5: An example of computing the expected word frequencies N-best word segmentation hypotheses can be obtained by using the Forward-DP Backward-A* algorithm (Nagata, 1994).
C94-1032
Church. 1988.
A88-1019
\[Nagata, 1994\] Masaaki Nagata.
C94-1032
It is impossible to compare our results with (Chang et al., 1995), because the experiment conditions are completely different in terms of language (Chinese vs.
W95-0109
\[Cutting et al., 1992\] Doug Cutting, Julian Kupiec, Jan Pedersen, and Penelope Sibun.
A92-1018
\[Church, 1988\] Kenneth W.
A88-1019
\[Nagao and Mori, 1994\] Makoto Nagao and Shinsuke Mori.
C94-1101
In English taggers, (Weischedel et al., 1993) proposed a statistical model to estimate word output probability p(wi\]tl) for an unknown word from spelling information such as inflectional endings, derivational endings, hyphenation, and capitalization.
J93-2006
This is achieved by introducing an explicit statistical model of unknown words, and by using an Nbest word segmentation algorithm (Nagata, 1994) as an approximation of the generalized ForwardBackward algorithm.
C94-1032
\[Chang et al., 1995\] Jing-Shin Chang, Yi-Chung Lin, and Keh-Yih Su.
W95-0109
