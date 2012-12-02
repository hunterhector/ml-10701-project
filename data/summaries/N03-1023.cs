We hypothesize that the presence of redundant fea4When tackling the task of confusion set disambiguation, Banko and Brill (2001) observe only modest gains from selftraining by bootstrapping from a seed corpus of one million words.
P01-1005
Ng and Cardie (2002); Soon et al.(2001)). Specifically, coreference resolution is recast as a classification task, in which a pair of NPs is classified as co-referring or not based on constraints that are learned from an annotated corpus.
J01-4004 W02-1008
Overall, our results suggest that single-view 1Abney (2002) argues that the conditional independence assumption is remarkably strong and is rarely satisfied in real data sets, showing that a weaker independence assumption suffices.
P02-1046
For other tasks such as named entity classification, views can be derived from features inside and outside the phrase under consideration (Collins and Singer, 1999).
W99-0613
We perform the experiments in this paper using our coreference resolution system (see Ng and Cardie (2002)).
W02-1008
The version of the algorithm that we consider here is a variation of the one presented in Banko and Brill (2001).
P01-1005
Abney. 2002.
P02-1046
Although co-training produces substantial improvements over the baseline at its best parameter settings, a closer examination of our results reveals that they corroborate previous findings: the algorithm is sensitive not only to the number of iterations, but to other input parameters such as the pool size and the growth size as well (Nigam and Ghani, 2000; Pierce and Cardie, 2001).
W01-0501
and Discussion Results are shown in Table 3, where performance is reported in terms of recall, precision, and F-measure using the model-theoretic MUC scoring program (Vilain et al., 1995).
M95-1005
Multi-view learning has been successfully applied to a number of tasks in natural language processing (NLP), including text classification (Blum and Mitchell, 1998; Nigam and Ghani, 2000), named entity classification (Collins and Singer, 1999), base noun phrase bracketing (Pierce and Cardie, 2001), and statistical parsing (Sarkar, 2001; Steedman et al., 2003).
E03-1008 N01-1023 W01-0501 W99-0613
Co-training algorithms such as CoBoost (Collins and Singer, 1999) and Greedy Agreement (Abney, 2002) that explicitly trade classifier agreement on unlabeled data against error on labeled data may be more robust to the underlying assumptions of co-training and can conceivably perform better than the Blum and Mitchell algorithm for problems without a natural feature split.9 Other less studied single-view weakly supervised algorithms in the NLP community such as co-training with different learning algorithms (Goldman and Zhou, 2000) and graph mincuts (Blum and Chawla, 2001) can be similarly applied to these problems to further test our original hypothesis.
P02-1046 W99-0613
