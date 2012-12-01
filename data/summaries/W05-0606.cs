For the baseline method, we selected the Longest Common Subsequence Ratio (LCSR), a measure of orthographic word similarity often used for cognate identification (Brew and McKelvie, 1996; Melamed, 1999; Koehn and Knight, 2001).
J99-1003 W01-0504
3The HMM model of (Mann and Yarowsky, 2001) is of distinctly different design than our PHMM model.
N01-1020
In statistical machine translation, cognates are helpful in inducing translation lexicons (Koehn and Knight, 2001; Mann and Yarowsky, 2001), sentence alignment (Melamed, 1999), and word alignment (Tiedemann, 2003).
E03-1026 J99-1003 N01-1020 W01-0504
Other applications include cross-lingual information retrieval (Pirkola et al., 2003), detection of confusable drug names (Kondrak and Dorr, 2004), and lexicography (Brew and McKelvie, 1996).
C04-1137
Somewhat surprisingly, the Hidden Markov Model falls well short of the baseline Levenshtein distance.3 Mann and Yarowsky (2001) developed yet another model, which outperformed all other similarity measures.
N01-1020
We also include the results obtained by the ALINE word aligner (Kondrak, 2000) on phonetically-transcribed word lists.
A00-2038
Following the method proposed by Evert (2004), we applied Fisher’s exact test to counts of word pairs that are accepted by only one of the two tested algorithms.
C04-1136
Covington. 1998.
P98-1043
Instead, we order the candidate pairs by their scores, and evaluate the ranking using 11-point interpolated average precision (Manning and Schutze, 2001).
N01-1020
Hidden Markov Models Hidden Markov Models have been applied successfully to a number of problems in natural language processing, including speech recognition (Jelinek, 1999) and statistical machine translation (Och and Ney, 2000).
P00-1056
In dialectology, similarity is used for estimating distance between dialects (Nerbonne, 2003).
E03-1088
The value of C can be established on a held-out data set.2 4.4 Levenshtein with Learned Weights Mann and Yarowsky (2001) investigated the induction of translation lexicons via bridge languages.
N01-1020
Covington (1998) illustrates the problem with an example of Italian “due” and the Spanish “dos”, both of which mean “two”.
P98-1043
The former includes string edit distance (Wagner and Fischer, 1974), longest common subsequence ratio (Melamed, 1999), and measures based on shared character n-grams (Brew and McKelvie, 1996).
J99-1003
In contrast, the methods proposed by Tiedemann (1999) automatically construct weighted string similarity measures on the basis of string segmentation and bitext co-occurrence statistics.
W99-0626
