Recently, Moore (2005) proposed a discriminative model in which pairs of sentences (e, f) and proposed alignments a are scored using a linear combination of arbitrary features computed from the tuples (a, e, f).
H05-1011
Moreover, including predictions of bi-directional IBM Model 4 and model of Liang et al.(2006) as features, we achieve an absolute AER of 3.8 on the EnglishFrench Hansards alignment task—the best AER result published on this task to date.
N06-1014
In contrast, Taskar et al.(2005) cast word alignment as a maximum weighted matching problem, in which each pair of words (ej, fk) in a sentence pair (e, f) is associated with a score sjk(e, f) reflecting the desirability of the alignment of that pair.
H05-1010
In order to make our results more comparable with Moore (2005), we split the original set into 200 training examples and 247 test examples.
H05-1011
We view this as a particularly promising aspect of our work, given that phrase-based systems such as Pharaoh (Koehn et al., 2003) perform better with higher recall alignments.
N03-1017
The Basic Matching Model: Edge Features In the basic matching model of Taskar et al.(2005), called M here, one can only specify features on pairs of word tokens, i.e. alignment edges.
H05-1010
By also including as features the posteriors of the model of Liang et al.(2006), we achieve AER of 3.8, and 96.7/95.5 precision/recall.
N06-1014
Generative alignment models like the HMM model (Vogel et al., 1996) and IBM models 4 and above (Brown et al., 1990; Och and Ney, 2003) directly model correlations between alignments of consecutive words (at least on one side).
C96-2141 J03-1002 J90-2002
We begin with a quick summary of the maximum weight bipartite matching model in (Taskar et al., 2005).
H05-1010
Moreover, the parameters of the model must be estimated using averaged perceptron training (Collins, 2002), which can be unstable.
W02-1001
These features 117 include word association, orthography, proximity, etc., and are documented in Taskar et al.(2005). We also augment those features with the predictions of IBM Model 2 run on the training and test sentences.
H05-1010
To once again anticipate the results presented in Section 4, the baseline model of Taskar et al.(2005) makes the prediction given in Figure 3(a) because the two missing alignments are atypical translations of common words.
H05-1010
By including the IBM Model 2 features, the performance of the model described in Taskar et al.(2005) on our test set (trained on 200 sentences) improves from 10.0 AER to 8.2 AER, outperforming unsymmetrized IBM Model 4 (but not intersected model 4).
H05-1010
We applied our algorithms to word-level alignment using the English-French Hansards data from the 2003 NAACL shared task (Mihalcea and Pedersen, 2003).
W03-0301
The validation and test sentences have been hand-aligned (see Och and Ney (2003)) and are marked with both sure and possible alignments.
J03-1002
Note in particular two substantial limitations of the bipartite matching model of Taskar et al.(2005): words have fertility of at most one, and there is no way to incorporate pairwise interactions among alignment decisions.
H05-1010
However, the proposed bipartite matching model of Taskar et al.(2005), despite being tractable and effective, has two important limitations.
H05-1010
The standard approach to word alignment is to construct directional generative models (Brown et al., 1990; Och and Ney, 2003), which produce a sentence in one language given the sentence in another language.
J03-1002 J90-2002
We also trained on only the first 100 to make our results more comparable with the experiments of Och and Ney (2003), in which IBM model 4 was tuned using 100 sentences.
J03-1002
Moore. 2005.
H05-1011
