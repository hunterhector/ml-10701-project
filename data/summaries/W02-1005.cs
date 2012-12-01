For CSSC, we tested our system on the identical data from the Brown corpus used by Golding (1995), Golding and Roth (1996) and Mangu and Brill (1997).
P96-1010 W95-0104
MMVC in Classifier Combination The investigated MMVC model proves to be a very effective participant in classifier combination, with substantially different output to Naïve Bayes (9.6% averaged complementary rate, as defined in Brill and Wu (1998)).
P98-1029
Previous work has addressed the problem of CSSC from a machine learning perspective, including Bayesian and Decision List models (Golding, 1995), Winnow (Golding and Roth, 1996) and Transformation-Based Learning (Mangu and Brill, 1997).
P96-1010 W95-0104
Mooney. 1996.
W96-0208
When a90 is a word, 2Golding and Schabes (1996) show that the most important words for CSSC are contained within a window of a160a147a161 . 3The results shown were obtained for a162a163a59a165a164 with term weights doubled within a a160a147a161 context window.
P96-1010
Golding. 1995.
W95-0104
Table 5 shows the improvement obtained by adding the MMVC model to empirically the best voting system we had using Bayes, BayesRatio, TBL and Decision Lists (all classifier combination methods tried and their results are presented exhaustively in Florian and Yarowsky (2002)).
W02-1004
For English and Swedish, for which POS-tagged training data was available to us, the fnTBL algorithm (Ngai and Florian, 2001) based on Brill (1995) was used to annotate the data, while for Spanish a mildly-supervised POS-tagging system similar to the one presented in Cucerzan and Yarowsky (2000) was employed.
J95-4004 N01-1006 P00-1035
Previous work in WSD and CSSC (Golding, 1995; Bruce et al., 1996; Yarowsky, 1996; Golding and Roth, 1996; Pedersen, 1998) has found diverse feature types to be useful, including inflected words, lemmas and part-of-speech (POS) in a variety of collocational and syntactic relationships, including local bigrams and trigrams, predicate-argument relationships, and wide-context bag-of-words associations.
P96-1010 W95-0104 W96-0210
We then compare the functionality and the performance of this model to those of the widely used Naïve Bayes model for the WSD task (Gale et al., 1992; Mooney, 1996; Pedersen, 1998), enhanced with the full richer feature space beyond the traditional unordered bag-ofwords.
W96-0208
Adjectives Nouns Verbs Overall Most Likely 63.43 66.52 57.6 63.09 Naïve Bayes (FE) 75.67 84.15 76.65 80.16 Mixture 76.45 81.57 75.9 78.79 AdaMixt 76.83 83.39 77.10 80.16 MMVC 78.49 84.79 76.81 81.06 Table 3: Results using 5-fold cross validation on SENSEVAL1 training data (English) 5.3 Spelling Correction Both MM and the enhanced Bayes model obtain virtually the same overall performance9 as the TriBayes system reported in (Golding and Schabes, 1996), which uses a similar feature space.
P96-1010
The correction and boosting methods we investigated marginally improve the performance of the mixture model, as can be seen in Table 4 but they do not achieve the performance of RuleS 93.1% (Mangu and Brill, 1997) and Winnow 93.5% (Golding and Roth, 1996; Golding and Roth, 1999), methods that include features more directly specialized for spelling correction.
P96-1010
