Please refer to (Jelinek, 1990) and (Chen and Goodman, 1996) for more about N-gram models and associated smoothing methods.
P96-1041
Dunning. 1993.
J93-1003
For our baseline, we have selected the method based on binomial loglikelihood ratio test (BLRT) described in (Dunning, 1993).
J93-1003
a11a29a9 thea13 thea15 a1a4a3a6a5 a11a29a9 thea13 thea15 a11a29a9 thea15 a11a29a9 thea15a1a0 a2 since a11a2a9 thea13 thea15a4a3 a11a29a9 thea15 a11a29a9 thea15 . Also note that in the case of phraseness of a bigram, the equation looks similar to pointwise mutual information (Church and Hanks, 1990), but they are different.
J90-1003
work Word collocation Various collocation metrics have been proposed, including mean and variance (Smadja, 1994), the t-test (Church et al., 1991), the chi-square test, pointwise mutual information (MI) (Church and Hanks, 1990), and binomial loglikelihood ratio test (BLRT) (Dunning, 1993).
J90-1003 J93-1003
Combining keyphrase and collocation Yamamoto and Church (2001) compare two metrics, MI and Residual IDF (RIDF), and observed that MI is suitable for finding collocation and RIDF is suitable for finding informative phrases.
J01-1001
Figure 4: Procedure to find key-bigrams For this experiment we used unsmoothed count for calculating phraseness a11a29a9a54a43 a13a45a44a59a15 a21 a51a53a9a54a43 a13a45a44a59a15 a23 a95, a11a29a9a54a66 a15 a21 a51a53a9a54a66 a15 a23 a95 where a95 a21 a62 a21 a51a53a9a54a43 a15 a21 a62 a21 a25a26 a51a60a9a54a43 a13a45a44a55a15, and used the unigram model for calculating informativeness with Katz smoothing (Chen and Goodman, 1996)4 to handle zero occurrences.
P96-1041
