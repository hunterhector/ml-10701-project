3) Similarity formulae The similarity of W 1 to W 2 is the average affinity of the contexts that include W 1 to W 2, and the similarity of a context X 1 to X 2 is a weighted average of the affinity of the words in X 1 to X 2 . Similarity formulae are defined as follows: ),(),(),( 21211 1 XWaffXWweightXXsim n XW n ⋅= ∑ ∈ + (7) (8) ),(),(),( 1),( 21211 211 21 1 WXaffWXweightWWsim else WWsim WWif n XW n n ⋅= = = ∑ ∈ + + The weights in formula 7 are computed as reflecting global frequency, log-likelihood factors, and part of speech as used in (Karov and Edelman, 1998).
J98-1002
To remove these noisy remaining contexts, we set up a dropping threshold using normal distribution of similarity values as follows (Ko and Seo, 2000): } ),( max Cc i θσµ +≥ ∈ i cXsim (10) where i) X is a remaining context, ii) µ is an average of similarity values, iii) σ is a standard deviation of similarity values, and iv) θ is a numerical value corresponding to the threshold (%) in normal distribution table.
C00-1066
Contexts are similar to the extent that they contain similar words, and words are similar to the extent that they appear in similar contexts (Karov and Edelman, 1998).
J98-1002
Thus we employ the similarity measure technique by Karov and Edelman (1998).
J98-1002
We use the Brill POS tagger to extract content words (Brill, 1995).
J95-4004
Affinity formulae are defined as follows (Karov and Edelman, 1998): ),(max),( inXWn WWsimXWaff i ∈ = (5) (6) ),(max),( jnXWn XXsimWXaff j ∈ = In the above formulae, n denotes the iteration number, and the similarity values are defined by WSM n and CSM n . Every word has some affinity to the context, and the context can be represented by a vector indicating the affinity of each word to it.
J98-1002
For example, there are Naive Bayes (McCallum and Nigam, 1998), Rocchio (Lewis et al., 1996), Nearest Neighbor (kNN) (Yang et al., 2002), TCFP (Ko and Seo, 2002), and Support Vector Machine (SVM) (Joachims, 1998).
C02-1074
The TCFP classifier with robustness from noisy data Here, we simply describe the TCFP classifier using the feature projection technique (Ko and Seo, 2002; 2004).
C02-1074
