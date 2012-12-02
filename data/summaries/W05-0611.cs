approach was proposed in the context of memorybased learning for part-of-speech tagging as MBT (Daelemans et al., 1996).
W96-0102
Additionally, a broader comparison with point-wise predictors (Kashima and Tsuboi, 2004) as well as Viterbi-based probabilistic models (McCallum et al., 2000; Lafferty et al., 2001; Sha and Pereira, 2003) in large-scale comparative studies is warranted.
N03-1028
We employ the English NER shared task data set used in the CoNLL2003 conference, again using the same evaluation method as originally used in the shared task (Tjong Kim Sang and De Meulder, 2003).
W03-0419
Output sequence optimization Rather than basing classifications only on model parameters estimated from co-occurrences between input and output symbols employed for maximizing the likelihood of point-wise single-label predictions at the output level, classifier output may be augmented by an optimization over the output sequence as a whole using optimization techniques such as beam searching in the space of a conditional markov model’s output (Ratnaparkhi, 1996) or hidden markov models (Skut and Brants, 1998).
W96-0213
The examples represent seven-word windows of words and their respective (predicted) part-of-speech tags, and each example is labeled with a class using the IOB type of segmentation coding as introduced by Ramshaw and Marcus (1995), marking whether the middle word is inside (I), outside (O), or at the beginning (B) of a chunk.
W95-0107
Boosting (Freund and Schapire, 1996) has been applied to optimize chunking systems (Carreras et al., 2002), as well as voting over sets of different classifiers (Florian et al., 2003).
W02-2004 W03-0425
Generalization performance is measured by the F-score on correctly identified and labeled constituents in test data, using the evaluation method originally used in the “shared task” subevent of the CoNLL-2000 conference (Tjong Kim Sang and Buchholz, 2000) in which this particular training and test set were used.
A00-2007 W00-0726
Direct feedback loops that copy a predicted output label to the input representation of the next example have been used in symbolic machine-learning architectures such as the the maximum-entropy tagger described by Ratnaparkhi (1996) and the memory-based tagger (MBT) proposed by Daelemans et al.(1996). This solution assumes that processing is directed, e.g. from left to right.
W96-0102 W96-0213
Alternatives to the 86 IOB-style encoding should also be incorporated in these experiments (Tjong Kim Sang, 2000).
A00-2007 W00-0726
