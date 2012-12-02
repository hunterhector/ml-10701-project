The Tagger Support cutoff Accuracy Collins (2002) 0 96.60% 5 96.72% Model 3W+TAGS variant 1 96.97% 5 96.93% Table 6: Effect of changing common word feature cutoffs (features with support ≤ cutoff are excluded from the model).
W02-1001
There are a few exceptions, such as Brill’s transformation-based learning (Brill, 1995), but most of the best known and most successful approaches of recent years have been unidirectional.
J95-4004
High-performance taggers typically also include joint three-tag counts in some way, either as tag trigrams (Brants, 2000) or tag-triple features (Ratnaparkhi, 1996, Toutanova and Manning, 2000).
A00-1031 W00-1308 W96-0213
Church. 1988.
A88-1019
For example, consider a case of observation bias (Klein and Manning, 2002) for a first-order left-toright CMM.
W02-1002
This is the best automatically learned part-of-speech tagging result known to us, representing an error reduction of 4.4% on the model presented in Collins (2002), using the same data splits, and a larger error reduction of 12.1% from the more similar best previous loglinear model in Toutanova and Manning (2000).
W00-1308 W02-1001
Indeed, as for the voted perceptron of Collins (2002), we can get performance gains by reducing the support threshold for features to be included in the model.
W02-1001
At any rate, regularized conditional loglinear models have not previously been applied to the problem of producing a high quality part-of-speech tagger: Ratnaparkhi (1996), Toutanova and Manning (2000), and Collins (2002) all present unregularized models.
W00-1308 W02-1001 W96-0213
Regardless of whether one is using HMMs, maximum entropy conditional sequence models, or other techniques like decision trees, most systems work in one direction through the sequence (normally left to right, but occasionally right to left, e.g., Church (1988)).
A88-1019
Indeed, the result of Collins (2002) that including low support features helps a voted perceptron model but harms a maximum entropy model is undone once the weights of the maximum entropy model are regularized.
W02-1001
Doing error analysis on unknown words on a simple tagging model (with 〈t0, t−1〉, 〈t0, t−1, t−2〉, and 〈w0, t0〉 features) suggested several additional specialized features that can usefully improve 9Thede and Harper (1999) use 〈t−1, t0,w0〉 templates in their “full-second order” HMM, achieving an accuracy of 96.86%.
P99-1023
word features Most of the models presented here use a set of unknown word features basically inherited from (Ratnaparkhi, 1996), which include using character n-gram prefixes and suffixes (for n up to 4), and detectors for a few other prominent features of words, such as capitalization, hyphens, and numbers.
W96-0213
Words surrounding the current word have been occasionally used in taggers, such as (Ratnaparkhi, 1996), Brill’s transformation based tagger (Brill, 1995), and the HMM model of Lee et al.(2000), but nevertheless, the only lexicalization consistently included in tagging models is the dependence of the part of speech tag of a word on the word itself.
J95-4004 P00-1034 W96-0213
Dependency Networks When building probabilistic models for tag sequences, we often decompose the global probability of sequences using a directed graphical model (e.g., an HMM (Brants, 2000) or a conditional Markov model (CMM) (Ratnaparkhi, 1996)).
A00-1031 W96-0213
Brants (2000) illustrates very clearly how tagging performance increases as training set size grows, largely because the percentage of unknown words decreases while system performance on them increases (they become increasingly restricted as to word class).
A00-1031
Abney et al.(1999) raise this baseline to 92.34%, and with our sophisticated unknown word model, it gets even higher.
W99-0606
gests that the final accuracy number presented here could be slightly improved upon by classifier combination, it is worth noting that not only is this tagger better than any previous single tagger, but it also appears to outperform Brill and Wu (1998), the best-known combination tagger (they report an accuracy of 97.16% over the same WSJ data, but using a larger training set, which should favor them).
P98-1029
The usefulness of priors in maximum entropy models is not new to this work: Gaussian prior smoothing is advocated in Chen and Rosenfeld (2000), and used in all the stochastic LFG work (Johnson et al., 1999).
P99-1069
The per-state models in this paper are log-linear models, building upon the models in (Ratnaparkhi, 1996) and (Toutanova and Manning, 2000), though some models are in fact strictly simpler.
W00-1308 W96-0213
We extracted tagged sentences from the parse trees.5 We split the data into training, development, and test sets as in (Collins, 2002).
W02-1001
performance. Whereas Ratnaparkhi (1996) used feature support cutoffs and early stopping to stop overfitting of the model, and Collins (2002) contends that including low support features harms a maximum entropy model, our results show that low support features are useful in a regularized maximum entropy model.
W02-1001 W96-0213
Table 6 contrasts our results with those from Collins (2002).
W02-1001
