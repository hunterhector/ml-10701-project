We measured the argument classification accuracy of our network, assuming the correct segmentation is given to our system, as in (Pradhan et al., 2004), by post-processing our per-word tags to form a majority vote over each segment.
N04-1030
As our algorithm outputs a semantic tag for each word of a sentence, we directly compare this per-wordaccuracywithASSERT.BecauseASSERT uses a parser, and because PropBank was built by labeling the nodes of a hand-annotated parse tree, pernode accuracy is usually reported in papers such as (Pradhan et al., 2004).
N04-1030
Classification Accuracy So far we have not used the same accuracy measures as in previous work (Gildea and Jurafsky, 2002; Pradhan et al., 2004).
J02-3001 N04-1030
The current version of the dataset gives semantic tags for the same sentencesas inthe PennTreebank (Marcuset al., 1993), whichareexcerptsfromtheWallStreetJournal.
J93-2004
The authors of (Pradhan et al., 2004) used a similar structure, but added more features, notably head word part-of-speech, the predicted named entity class of the argument, word sense disambiguation of the verb and verb clustering, and others (they add 25 variants of 12 new feature types overall.) Their system also uses a parser, as before, and then a polynomial Support Vector Machine (SVM) (Boser et al., 1992) is used in two further stages: to classify each node in the tree as being a semantic argument or not for a given verb; and then to classify each semantic argument into one of the classes (ARG1, ARG2, etc.).
N04-1030
In (Gildea and Jurafsky, 2002) the authors presented a statistical approach to learning (for FrameNet), with some success.
J02-3001
For example, simply adding whether each word is part of a noun or verb phrase using the handannotated parse tree (the so-called “GOV” feature from (Gildea and Jurafsky, 2002)) improves the performance of our system from 83.95% to 85.8%.
J02-3001
Using this intuition, state-of-the-art systems first build a parse tree, and syntactic constituents are then labeled by feeding hand-built features extracted from the parse tree to a machine learning system, e.g. the ASSERT system (Pradhan et al., 2004).
N04-1030
To achieve the goal of semantic understanding, the current consensus is to divide and conquer the [The company]ARG0 [bought]REL [sugar]ARG1 [on the world market]ARGM-LOC [to meet export commitments]ARGM-PNC Figure 1: Example of Semantic Role Labeling from the PropBank dataset (Palmer et al., 2005).
J05-1004
We focus our experimental study on the semantic role labeling problem (Palmer et al., 2005): being able to give a semantic role to a syn1Even though some parsers effectively exhibit linear behavior in sentence length (Ratnaparkhi, 1997), fast statistical parsers such as (Henderson, 2004) still take around 1.5 seconds for sentences of length 35 in tests that we made.
J05-1004 P04-1013 W97-0301
Semantic Parsing FrameNet (Baker et al., 1998) and the Proposition Bank (Palmer et al., 2005), or PropBank for short, are the two main systems currently developed for semantic role-labeling annotation.
J05-1004
Many current solutions are complicated, consist of several stages and handbuilt features, and are too slow to be applied as part of real applications that require such semantic labels, partly because of their use of a syntactic parser (Pradhan et al., 2004; Gildea and Jurafsky, 2002).
J02-3001 N04-1030
We compared our system to the freely available ASSERT system (Pradhan et al., 2004).
N04-1030
(Pradhan et al., 2004).
N04-1030
We trained on the training set of PropBank supplemented with the Brown corpus, resulting in a test accuracy on the test set of PropBank of 96.85% which compares to 96.66% using the Brill tagger (Brill, 1992).
A92-1021
