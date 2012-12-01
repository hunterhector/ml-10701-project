ing. We use as our English corpus the Wall Street Journal (WSJ) portion of the Penn Treebank (Marcus et al., 1993).
J93-2004
Consequently, researchers have attempted to derive morphological information heuristically (e.g., Cucerzan and Yarowsky (2000), Clark (2003), Freitag (2004)).
C04-1052 E03-1009 P00-1035
To overcome this problem, Clark (2000) proposes a bootstrapping approach, in which he (1) clusters the most distributionally reliable words, and then (2) incrementally augments each cluster with words that are distributionally similar to those already in the cluster.
W00-0717
It is perhaps not immediately clear why morphological information would play a crucial role in the induction process, especially since the distributional approach has achieved considerable success for English POS induction (see Lamb (1961), Sch tze (1995) and Clark (2000)).
W00-0717
Perhaps due to the overly simplistic methods employed to compute morphological information, morphology has only been used as what Biemann (2006) called add-on’s in existing POS induction algorithms, which remain primarily distributional in nature.
P06-3002
These results provide empirical support for the claim that morphological information can be usefully employed to label rare words (Clark, 2003).
E03-1009
We use as our baseline system one of the best existing unsupervised POS induction algorithms (Clark, 2003).
E03-1009
For instance, Cucerzan and Yarowsky (2000) posit a character sequence x as a suffix if there exists a sufficient number of distinct words w in the vocabulary such that the concatentations wx are also in the vocabulary.
P00-1035
Haghighi and Klein s (2006) prototype-driven approach requires just a few prototype examples for each POS tag, exploiting these labeled words to constrain the labels of their distributionally similar words when training a generative log-linear model for POS tagging.
N06-1041
Previous POS induction algorithms have attempted to derive morphological information from dictionaries (Haji, 2000) and knowledge-based morphological analyzers (Duh and Kirchhoff, 2006).
W06-1647
In particular, we have implemented an unsupervised morphological analyzer that outperforms Goldsmith s (2001) Linguistica and Creutz and Lagus s (2005) Morfessor for our English and Bengali datasets and compares favorably to the bestperforming morphological parsers in MorphoChallenge 20053 (see Dasgupta and Ng (2007)).
J01-2001 N07-1020
In fact, Jardino and Adda (1994), Sch tze (1997) and Clark (2000) have attempted to address the ambiguity problem to a certain extent.
W00-0717
Smith and Eisner (2005) train a log-linear model for POS tagging in an unsupervised manner using contrastive estimation, which seeks to move probability mass to a positive example e from its neighbors (i.e., negative examples created by perturbing e).
P05-1044
