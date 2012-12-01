In contrast to Dang & Palmer (2005), we only include the hypernyms of the most frequent sense, and we include the entire hypernym chain (e.g.
P05-1006
Kohomban and Wee Sun Lee provided us with the results file for the Simil-Prime system (Kohomban and Lee, 2005).
P05-1005
We had a significant improvement (p-value<0.05) over the baseline of 52.9%, a marginal improvement over the second best performer (SenseLearner) (Mihalcea and Faruque, 2004), and we were as good as the top performer (GAMBL) (Decadt et al., 2004).7 System Precision Fraction of Recall Our system 61% 22% GAMBL 59.0% 21.3% SenseLearner 56.1% 20.2% Baseline 52.9% 19.1% Table 3.
W04-0807 W04-0827 W04-0838
We utilize the OpenNLP MaxEnt implementation2 of the maximum entropy classification algorithm (Berger et al., 1996) to train classification models for each lemma and part-of-speech combination in the training corpus.
J96-1002
Following Dang & Palmer (2005) and Kohomban & Lee (2005), we use contextual, syntactic and semantic information to inform our word 1 http://www.cs.unt.edu/~rada/downloads.html.
P05-1005 P05-1006
While many unsupervised word sense disambiguation systems have been created, supervised systems have generally produced superior results (Snyder and Palmer, 2004; Mihalcea et al., 2004).
W04-0807 W04-0811 W04-0838
We use the Connexor parser3 (Tapanainen and Järvinen, 1997) to extract lemma information, parts of speech, syntactic dependencies, tense, case, and number information.
A97-1011
However, there are significant differences between the specific types of contextual, syntactic and semantic information we use in our system and those proposed by Dang & Palmer (2005) and Kohomban & Lee (2005).
P05-1005 P05-1006
baseline is slightly higher than that reported by others (Snyder and Palmer 2004).
W04-0811
We use SemCor1, OMWE 1.0 (Chklovski and Mihalcea, 2002), and example sentences in WordNet as the training corpus.
W02-0817
