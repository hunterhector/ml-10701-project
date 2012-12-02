The default strategy of picking the most frequent sense has been advocgted as the baseline performance for evaluating WSD programs (Gale et al., 1992b; Miller et al., 1994).
H94-1046 P92-1032
We have used the default values for all parameter settings in our previous work on exemplar-based WSD reported in (Ng and Lee, 1996).
P96-1006
Results Mooney (1996) has reported that the Naive-Bayes algorithm gives the best performance on disambiguating six senses of the word "line", among seven state-of-the-art learning algorithms tested.
W96-0208
In particular, Mooney (1996) evaluated seven state-of-the-art machine learning algorithms on a common data set for disambiguating six senses of the word "line".
W96-0208
We believe that this result is significant, in light of the fact that Naive-Bayes has been found to give the best performance for WSD among seven state-ofthe-art machine learning algorithms (Mooney, 1996).
W96-0208
210 Algorithm BC50 WSJ6 Sense 1 40.5% 44.8% Most Frequent 47.1% 63.7% Ng & Lee (1996) 54.0% 68.6% PEBLS (k = 1) 55.0% 70.2% PEBLS (k = 20) 58.5% 74.5% PEBLS (10-fold c.v). 58.7% 75.2% Naive-Bayes 58.2% 74.5% Table 1: Experimental Results ures are those of (Ng and Lee, 1996).
P96-1006
On the other hand, our past work on WSD (Ng and Lee, 1996) used an exemplar-based (or nearest neighbor) learning approach.
P96-1006
By using 10-fold cross validation (Kohavi and 208 John, 1995) on the training set to automatically determine the best k to use, we have obtained improved disambiguation accuracy on a large sensetagged corpus first used in (Ng and Lee, 1996).
P96-1006
Note that the accuracy figures of PEBLS with k = 1 are 1.0% and 1.6% higher than the accuracy figures of (Ng and Lee, 1996) in the third row, also with k = 1.
P96-1006
The accuracy figures of LEXAS as reported in (Ng and Lee, 1996) are reproduced in the third row of Table 1.
P96-1006
2The first five of these seven features were also used in (Ng and Lee, 1996).
P96-1006
Many different learning approaches have been used, including neural networks (Leacock et al., 1993), probabilistic algorithms (Bruce and Wiebe, 1994; Gale et al., 1992a; Gale et al., 1995; Leacock et al., 1993; Yarowsky, 1992), decision lists (Yarowsky, 1994), exemplar-based learning algorithms (Cardie, 1993; Ng and Lee, 1996), etc.
C92-2070 H93-1051 H93-1052 P92-1032 P94-1013 P94-1020 P96-1006
Both test sets are identical to the ones reported in (Ng and Lee, 1996).
P96-1006
Our past work (Ng and Lee, 1996) suggests that multiple sources of knowledge are indeed useful for WSD.
P96-1006
However, the feature value pruning method of (Ng and Lee, 1996) only selects surrounding words and local collocations as feature values if they are indicative of some sense class as measured by conditional probability (See (Ng and Lee, 1996) for details).
P96-1006
By using a larger value of k, the number of nearest neighbors to use for determining the class of a test example, and through 10-fold cross validation to automatically determine the best k, we have obtained improved disambiguation accuracy on a large sense-tagged corpus first used in (Ng and Lee, 1996).
P96-1006
The feature value pruning method of (Ng and Lee, 1996) is intended to keep only feature values deemed important for classification.
P96-1006
Other more complex smoothing procedures (such as those used in (Gale et al., 1992a)) are also possible, although we have not experimented with these other variations.
P92-1032
The accuracy achieved by our improved exemplar-based classifier is comparable to the accuracy on the same data set obtained by the Naive-Bayes algorithm, which was reported in (Mooney, 1996) to have the highest disambiguation accuracy among seven stateof-the-art machine learning algorithms.
W96-0208
Section 4 presents the disambiguation accuracy of PEBLS and Naive-Bayes on the large corpus of (Ng and Lee, 1996).
P96-1006
This corpus was first reported in (Ng and Lee, 1996), and it contains about 192,800 sense-tagged word occurrences of 191 most frequently occurring and ambiguous words of English.
P96-1006
Mooney. 1996.
W96-0208
Local collocations have been found to be the single most informative set of features for WSD (Ng and Lee, 1996).
P96-1006
That local collocation knowledge provides important clues to WSD has also been pointed out previously by Yarowsky (1993).
H93-1052
However, all possible feature values (collocated words) are used, without employing the feature value pruning method used in (Ng and Lee, 1996).
P96-1006
Also, given the relative importance of the various knowledge sources as reported in (Ng and Lee, 1996), it may be possible to improve disambignation performance by introducing feature weighting.
P96-1006
Gale, Church and Yarowsky (Gale et al., 1992a; Gale et al., 1995; Yarowsky, 1992) have also successfully used the Naive-Bayes algorithm (and several extensions and variations) for word sense disambiguation.
C92-2070 P92-1032
The accuracy achieved by our improved exemplar-based classifier is comparable to the accuracy on the same data set obtained by the Naive-Bayes algorithm, which was reported in (Mooney, 1996) to have the highest disambiguation accuracy among seven state-of-the-art machine learning algorithms.
W96-0208
Note that the nearest neighbor algorithm tested in (Mooney, 1996) uses Hamming distance as the distance metric between two symbolic feature values.
W96-0208
