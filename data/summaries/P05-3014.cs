Although more general than models that are built individually for each word in a test corpus (Decadt et al., 2004), the applicability of the semantic models built as part of SENSELEARNER is still limited to those words previously seen in the training corpus, and therefore their overall coverage is not 100%.
W04-0827
A different version of our own SENSELEARNER system (Mihalcea and Faruque, 2004), using three of the semantic models described in this paper, combined with semantic generalizations based on syntactic dependencies, achieved a performance of 64.6%. 3 SenseLearner Our goal is to use as little annotated data as possible, and at the same time make the algorithm general enough to be able to disambiguate as many content words as possible in a text, and efficient enough so that large amounts of text can be annotated in real time.
W04-0838
Another top ranked system is the one developed by (Yuret, 2004), which combines two Naive Bayes statistical models, one based on surrounding collocations and another one based on a bag of words around the target word.
W04-0864
An alternative solution to this second step was suggested in (Mihalcea and Faruque, 2004), using semantic generalizations learned from dependencies identified between nodes in a conceptual network.
W04-0838
We base our experiments on SemCor (Miller et al., 1993), a balanced, semantically annotated dataset, with all content words manually tagged by trained lexicographers.
H93-1061
The best results reported on these data sets are 69.0% on SENSEVAL-2 data (Mihalcea and Moldovan, 2002), 55 Training SENSEVAL-2 SENSEVAL-3 Model size Precision Recall Precision Recall modelNN1 88058 0.6910 0.3257 0.6624 0.3027 modelNNColl 88058 0.7130 0.3360 0.6813 0.3113 modelVB1 48328 0.4629 0.1037 0.5352 0.1931 modelVBColl 48328 0.4685 0.1049 0.5472 0.1975 modelJJ1 35664 0.6525 0.1215 0.6648 0.1162 modelJJ2 35664 0.6503 0.1211 0.6593 0.1153 modelJJColl 35664 0.6792 0.1265 0.6703 0.1172 model*1/2 207714 0.6481 0.6481 0.6184 0.6184 model*Coll 172050 0.6622 0.6622 0.
C02-1039
and 65.2% on SENSEVAL-3 data (Decadt et al., 2004).
W04-0827
For learning, we are using the Timbl memory based learning algorithm (Daelemans et al., 2001), which was previously found useful for the task of word sense disambiguation (Hoste et al., 2002), (Mihalcea, 2002).
C02-1039 W02-0814
The system developed by (Decadt et al., 2004) uses two cascaded memory-based classifiers, combined with the use of a genetic algorithm for joint parameter optimization and feature selection.
W04-0827
