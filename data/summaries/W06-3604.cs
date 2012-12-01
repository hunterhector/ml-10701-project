More generally, as a precursor to the abovementioned work, confusable disambiguation has been investigated in a string of papers discussing the application of various machine learning algorithms to the task (Yarowsky, 1994; Golding, 1995; Mangu 31 and Brill, 1997; Huang and Powers, 2001).
P94-1013 W95-0104
Yet, it could be an asset in higher-level proofing or authoring tools, e.g. to be able to automatically discern among confusables and thereby to detect confusable errors (Golding and Roth, 1999; Even-Zohar and Roth, 2000; Banko and Brill, 2001; Huang and Powers, 2001).
A00-2017 P01-1005
Arguably it is the “archetypical prediction problem in natural language processing” (Even-Zohar and Roth, 2000).
A00-2017
A specific type of word prediction is confusable prediction, i.e., learn to predict among limited sets of confusable words such as to/two/too and there/their/they’re (Golding and Roth, 1999; Banko and Brill, 2001).
P01-1005
An explicit choice for the particular study on “all-words” prediction is to encode context only by words, and not by any higher-level linguistic non-terminals which have been investigated in related work on word prediction (Wu et al., 1999; Even-Zohar and Roth, 2000).
A00-2017
log-linear) improvements are observed (Banko and Brill, 2001).
P01-1005
Our discrete, classificatio-nased approach has the same goal as probabilistic methods for language modeling for automatic speech recognition (Jelinek, 1998), and is also functionally equivalent to n-gram models with back-off smoothing (Zavrel and Daelemans, 1997).
P97-1056
setup All experiments described in this article take the form of learning curve experiments (Banko and Brill, 2001), in which a sequence of training sets is generated with increasing size, where each size training set is used to train a model for word prediction, which is subsequently tested on a held-out test set – which is fixed throughout the whole learning curve experiment.
P01-1005
Interestingly, IGTREE is functionally equivalent to back-off smoothing (Zavrel and Daelemans, 1997), with the IG of the features determining the order in which to back off, which in the case of word prediction tends to be from the outer context to the inner context of the immediately neighboring words.
P97-1056
Another motivation for our choice is that our decision-tree approximation of k-nearest neighbor classification is functionally equivalent to back-off smoothing (Zavrel and Daelemans, 1997); not only does it share its performance capacities with n-gram models with back-off smoothing, it also shares its scaling abilities with these models, while being able to handle large values of n.
P97-1056
Counter to the learning curves in the allwords prediction experiments, and to the observation by (Banko and Brill, 2001), the learning curves of this confusable triple in the three different data sets flatten, and converge, remarkably, to a roughly similar score of about 98%.
P01-1005
As the third test set we selected all tokens of the Brown corpus part of the Penn Treebank (Marcus et al., 1993), a selected portion of the original one-million word Brown corpus (Kuˇcera and Francis, 1967), a collection of samples of American English in many different genres, from sources printed in 1961; we refer to this test set as BROWN.
J93-2004
Golding. 1995.
W95-0104
and Roth, 2000; Banko and Brill, 2001).
P01-1005
