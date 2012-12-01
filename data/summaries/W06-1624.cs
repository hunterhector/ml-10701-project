Traditionally, there are mainly two mainstreams in the SLU researches: knowledge-based approaches, which are based on robust parsing or template matching techniques (Sneff, 1992; Dowding et al., 1993; Ward and Issar, 1994); and data-driven approaches, which are generally based on stochastic models (Pieraccini and Levin, 1993; Miller et al., 1995).
H94-1039 P93-1008
This mechanism is well-suited for SLU since the spoken utterance usually consists of several phrases and noises (restart, repeats and filled pauses, etc) are most often between them (Ward and Issar, 1994).
H94-1039
While labelers/ sentences are available (a) Get n unlabeled sentences from u S (b) Apply the current classifier to n unlabeled sentences (c) Select m examples which are most informative to the current classifier and manually label the selected m examples (d) Add the m human-labeled examples and the remaining nm− machinelabeled examples to the training set t S (e) Train a new classifier on all labeled examples 3.2 Bootstrapping the Topic-dependent Semantic Classifiers Bootstrapping refers to a problem of inducing a classifier given a small set of labeled data and a large set of unlabeled data (Abney, 2002).
P02-1046
One way to reduce the number of labeling examples is active learning, which have been applied in many domains (McCallum and Nigam, 1998; Tang et al., 2002; Tur et al., 2005).
P02-1016
The key to the bootstrapping methods is to exploit the redundancy in the unlabeled data (Collins and Singer, 1999).
W99-0613
Abney. 2002.
P02-1046
We use the metric described in (Yarowsky, 1994; Golding, 1995).
P94-1013 W95-0104
Golding. 1995.
W95-0104
It has been applied to problems such as word-sense disambiguation (Yarowsky, 1995), web-page classification (Blum and Mitchell, 1998), namedentity recognition (Collins and Singer, 1999) and automatic construction of semantic lexicon (Thelen and Riloff, 2003).
W99-0613
