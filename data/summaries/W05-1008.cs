The second form of syntactic preprocessing, which builds directly on the output of the POS tagger, is CoNLL 2000-style full text chunking (Tjong Kim Sang and Buchholz, 2000).
W00-0726
Based on the sparseness of this data and also the findings of Baldwin and Bond (2003b) over a countability learning task, we choose to carry out DLA via a suite of 110 binary classifiers, one for each lexical type.
P03-1059 W03-1010
For our purposes, we use a Penn treebank-style tagger custom-built using fnTBL 1.0 (Ngai and Florian, 2001), and further lemmatise the output of the tagger using morph (Minnen et al., 2000).
N01-1006 W00-1427
We ran the three syntactic preprocessors over a total of three corpora, of varying size: the Brown corpus (∼460K tokens) and Wall Street Journal corpus (∼1.2M tokens), both derived from the Penn Treebank (Marcus et al., 1993), and the written component of the British National Corpus (∼98M tokens: Burnard (2000)).
J93-2004
Also somewhat related to this research is the general-purpose verb feature set proposed by Joanis and Stevenson (2003), which is shown to be applicable in a range of DLA tasks relating to English verbs.
E03-1040
In order to maximise comparability between the results for the different DLRs, we employ a common classifier design wherever possible (in all cases other than ontology-based DLA), 69 using TiMBL 5.0 (Daelemans et al., 2003); we used the IB1 k-NN learner implementation within TiMBL, with k = 9 throughout.4 We additionally employ the feature selection method of Baldwin and Bond (2003b), which generates a combined ranking of all features in descending order of “informativeness” and skims off the top-N features for use in classification; N was set to 100 in all experiments.
P03-1059 W03-1010
a machine-readable dictionary (Sanfilippo and Pozna´nski, 1992)), or two-step process in reusing an existing system to learn lexical properties in one format and then mapping this onto the DLR of choice (e.g.
A92-1011
Baldwin and Bond (2003a)), and little consideration is given to the applicability of that method to more general linguistic properties.
P03-1059 W03-1010
