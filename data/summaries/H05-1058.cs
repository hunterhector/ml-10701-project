Previous authors have used numerous HMM-based models (Banko and Moore, 2004; Collins, 2002; Lee et al., 2000; Thede and Harper, 1999) and other types of networks including maximum entropy models (Ratnaparkhi, 1996), conditional Markov models (Klein and Manning, 2002; McCallum et al., 2000), conditional random elds (CRF) (Lafferty et al., 2001), and cyclic dependency networks (Toutanova et al., 2003).
C04-1080 N03-1033 P00-1034 P99-1023 W02-1001 W02-1002 W96-0213
We extracted tagged sentences from the parse trees and divided the data into training (sections 0-18), development (sections 19-21), and test (sections 22-24) sets as in (Toutanova et al., 2003).
N03-1033
Smith and Jason Eisner 2005.
P05-1044
The following ve binary ags, taken from (Toutanova et al., 2003), are derived from the current word wi and used as features : is-capitalized (refers to the rst letter only); has-digits (word contains one or more digits); is-hyphenated (word contains ‘-’); is-all-caps (all letters are capitalized); is-conjunction (true if is-all-caps, has-digits, and is-hyphenated are all true, for example CFC-12 or F/A-18).
N03-1033
Previous work used all possible pre xes and suf xes ranging in length from 1 to k characters, with k = 4 (Ratnaparkhi, 1996), and k = 10 (Toutanova et al., 2003).
N03-1033 W96-0213
The token-level accuracy result obtained from the OCM-II model on the development set (96.64%) can be directly compared to an accuracy of 96.57% reported in (Toutanova et al., 2003) for a cyclic dependency network using similar word features and the same three tag context.
N03-1033
This is based on the idea from (Ratnaparkhi, 1996) that rare words in the training set are similar to unknown words in the test set, and can be used to learn how to tag the unknown words that will be encountered during testing.
W96-0213
Beginning with (Church and Hanks, 1989), numerous authors have used the pointwise mutual information between pairs of words to analyze word co-locations and associations.
P89-1010
We rst rewrite the conditional probability (henceforth abbreviated as p) as: p = P(ci = 1jsi−1,si) = P(ci = 1,si−1,si)P(s i−1,si) If the probabilities are maximum likelihood (ML) estimates derived from counts on the training data, we can equivalently write: p = N(ci = 1,si−1,si)N(s i−1,si) 2This use of implied negative training data is similar to the neighborhood concept described in (Smith and Eisner, 2005) 461 where N( ) is the count function.
P05-1044
All training of language models is done using the SRILM toolkit (Stolcke, 2002) with the FLM extensions (Bilmes and Kirchhoff, 2003), and the implementation and testing of the various graphical models is carried out with the help of the graphical models toolkit (GMTK) (Bilmes and Zweig, 2002).
N03-2002
