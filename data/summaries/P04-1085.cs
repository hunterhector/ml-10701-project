Features Many of the local features described in this subsection are similar in spirit to the ones used in the previous work of (Hillard et al., 2003).
N03-2012
Second, the table corroborates the findings of (Hillard et al., 2003) that lexical information make the most helpful local features.
N03-2012
Durational features: a0 duration of the spurt a0 seconds of overlap with any other speaker a0 seconds of silence during the spurt a0 speech rate in the spurt Lexical features: a0 number of words in the spurt a0 number of content words in the spurt a0 perplexity of the spurt with respect to four language models, one for each class a0 first and last word of the spurt a0 number of instances of adjectives with positive polarity (Hatzivassiloglou and McKeown, 1997) a0 idem, with adjectives of negative polarity a0 number of instances in the spurt of each cue phrase and agreement/disagreement token listed in (Hirschberg and Litman, 1994; Cohen, 2002) Table 3.
P97-1023
This Feature sets Accuracy (Hillard et al., 2003) 82% Lexical 84.95% Structural and durational 71.23% All (no label dependencies) 85.62% All (with label dependencies) 86.92% Table 6.
N03-2012
Switchboard, (Stolcke et al., 2000)).
J00-3003
In the first set of experiments, we reproduced the experimental setting of (Hillard et al., 2003), a three-way classification (BACKCHANNEL and OTHER are merged) using hand-labeled data of a single meeting as a test set and the remaining data as training material; for this experiment, we used the same training set as (Hillard et al., 2003).
N03-2012
Speaker ranking accuracy Table 2 summarizes the accuracy of our statistical ranker on the test data with different feature sets: the performance is 89.39% when using all feature sets, and reaches 90.2% after applying Gaussian smoothing and using incremental feature selection as described in (Berger et al., 1996) and implemented in the yasmetFS package.6 Note that restricting ourselves to only backward looking features decreases the performance significantly, as we can see in Table 2.
J96-1002
The algorithm is exactly the same as the one described in (Ratnaparkhi, 1996) to find the most probable part-of-speech sequence.
W96-0213
Entropy Ranking We view the problem as an instance of statistical ranking, a general machine learning paradigm used for example in statistical parsing (Collins, 2000) and question answering (Ravichandran et al., 2003).3 The problem is to select, given a set of a0 possible candidates a1a3a2a5a4a7a6a7a8a9a8a9a8a9a6a10a2a12a11a14a13 (in our case, potential A speakers), the one candidate a2a16a15 that maximizes a given conditional probability distribution.
W03-1209
This finding is consistent with previous work (Ravichandran et al., 2003) that compares maximum entropy classification and re-ranking on a question answering task.
W03-1209
Previous work in automatic identification of agreement/disagreement (Hillard et al., 2003) demonstrates that this is a feasible task when various textual, durational, and acoustic features are available.
N03-2012
Regarding lexical features, we selected a list of lexical items we believed are instrumental in the expression of agreements and disagreements: agreement markers, e.g. “yes” and “right”, as listed in (Cohen, 2002), general cue phrases, e.g. “but” and “alright” (Hirschberg and Litman, 1994), and adjectives with positive or negative polarity (Hatzivassiloglou and McKeown, 1997).
P97-1023
Conditional Markov models (CMM) (Ratnaparkhi, 1996; Klein and Manning, 2002) have been successfully used in sequence labeling tasks incorporating rich feature sets.
W96-0213
We use maximum entropy modeling (Berger et al., 1996) to directly model the conditional probability a17a19a18a20a2a21a15a23a22a24a26a25, where each a27a5a15 in a24a29a28a30a18a31a27a32a4a33a6a7a8a9a8a9a8a9a6a23a27a34a11a14a25 is an observation associated with the corresponding speaker a2 a15 . a27 a15 is represented here by only one variable for notational ease, but it possibly represents several lexical, durational, structural, and acoustic observations.
J96-1002
The annotation of the corpus with adjacency pairs is described in (Shriberg et al., 2004; Dhillon et al., 2004).
W04-2319
We define the problem of AP 1Part of these annotated meetings were provided by the authors of (Hillard et al., 2003).
N03-2012
This improved accuracy with DA information should of course not be considered as the actual accuracy of our system, since DA information is difficult to acquire automatically (Stolcke et al., 2000).
J00-3003
First, the analysis of our results shows that with our three local feature sets only, we obtain substantially better results than (Hillard et al., 2003).
N03-2012
Shriberg. 2004.
W04-2319
Our accuracy for classifying agreements and disagreements is 86.9%, which is a 4.9% improvement over (Hillard et al., 2003).
N03-2012
