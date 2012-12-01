A wide range of features have been shown to be useful in previous work on semantic role labeling for verbal predicates (Gildea and Jurafsky, 2002; Pradhan et al., 2004b; Xue and Palmer, 2004) and our experiments show most of them are also effective for SRL of nominalized predicates.
J02-3001 N04-1030 N04-4036 W04-3212
Chinese Nombank The Chinese Nombank extends the general annotation framework of the English Proposition Bank (Palmer et al., 2005) and the English Nombank (Meyers et al., 2004) to the annotation of nominalized predicates in Chinese.
J05-1004 W04-2705
The results are comparable with those reported in Luo (Luo, 2003), but they cannot be directly compared with most of the results reported in the literature, where correct segmentation is assumed.
W03-1025
(Hull and Comez, 1996) implemented a rule-based system for identifying the arguments for nominal predicates and (Lapata, 2002) has a system that interprets the relation between the head of noun compound and its head, but no meaningful comparison can be made between our work and theirs.
J02-3004
This line of research has also expanded from English to other languages (Sun and Jurafsky, 2004; Xue and Palmer, 2005).
J05-1004 N04-1032
Performing reranking on the top 10 propositions did not lead to significant improvement, using the five feature classes described in (Haghighi et al., 2005).
W05-0623
Xue and Palmer (2005) reported an f-score of 61.3% when a parser is used to preprocess the data.
J05-1004
The alternative approach is to combine heuristic and machine-learning approaches (Xue and Palmer, 2004).
W04-3212
Our parser is similar to (Luo, 2003) and is trained and tested on the same data partition as the semantic role labeling system.
W03-1025
experiments all corep (%) r(%) f(%) f(%) constituents known n/a n/a 86.6 86.9 constituents unknown 69.7 73.7 71.6 72.0 Table 2: Results for hand-crafted parses Compared with the 93.9% reported by Xue and Palmer (2005) for verbal predicates on the same data, the 86.9% the system achieved when the consituents are given is considerably lower, suggesting that SRL for nominalized predicates is a much more challenging task.
J05-1004
The class features are induced from frame files through a procedure first introduced in (Xue and Palmer, 2005).
J05-1004
This can be done with high accuracy when the machine-learning algorithm is powerful and is provided with appropriate features (Hacioglu et al., 2003; Pradhan et al., 2004b).
N04-1030 N04-4036
Many classification techniques, SVM (Pradhan et al., 2004b), perceptrons (Carreras and M`arquez, 2004a), Maximum Entropy (Xue and Palmer, 2004), etc.
N04-1030 N04-4036 W04-2412 W04-2415 W04-3212
In a recent paper on the SRL on verbal predicates for English, (Toutanova et al., 2005) pointed out that one potential flaw in a SRL system where each argument is considered on its own is that it does not take advantage of the fact that the arguments (not the adjuncts) of a predicate are subject to the hard constraint that they do not have the same label3.
P05-1073
Perhaps the closest work to that of ours is that of (Pradhan et al., 2004a), where they reported preliminary work for analyzing the predicate-argument structure of Chinese nominalizations, using a small data set of 630 proposition for 22 nominalizations taken from the Chinese Treebank.
N04-1030 N04-4036
It turns out the heuristics that are first proposed in Xue and Palmer (2004) to prune out non-arguments for verbal predicates can be easily adapted to detect arguments for the nominalized predicates as well, so in our experiments we adopt the latter approach.
W04-3212
It has been the shared task for the CoNLL competition for two consecutive years (Carreras and M`arquez, 2004b; Carreras and M`arquez, 2005).
W04-2412 W04-2415 W05-0620
Detecting and classifying the arguments of predicates has been an active area of research in recent years, driven by the availability of large-scale semantically annotated corpora such as the FrameNet (Baker et al., 1998) and the Propbank (Palmer et al., 2005).
J05-1004 P98-1013
It is generally formulated as a semantic role labeling (SRL) task, where each argument of the predicate is assigned a label that represents the semantic role it plays with regard to its predicate (Gildea and Jurafsky, 2002; Hacioglu et al., 2003; Pradhan et al., 2004b; Xue and Palmer, 2004; Toutanova et al., 2005; Koomen et al., 2005).
J02-3001 J05-1004 N04-1030 N04-4036 P05-1073 W04-3212 W05-0625
The results reported here for nominalized predicates are consistent with what Xue and Palmer (2005) reported for the SRL of Chinese verbs with regard to the role of the parser in their semantic role labeling system: there is a substantial performance drop when the automatic parser is used.
J05-1004
