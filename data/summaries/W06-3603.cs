The dashed curve in Figure 1 10Bikel (2004) is a “clean room” reimplementation of the Collins (1999) model with comparable accuracy.
J04-4004
We follow Taskar et al.(2004) and Turian and Melamed (2005) in training and testing on ≤ 15 word sentences in the English Penn Treebank (Taylor et al., 2003).
W04-3201 W05-1515
Step Description mean stddev % 1.5 Sample 1.5s 0.07s 0.7% 1.6 Extraction 38.2s 0.13s 18.6% 1.7 Build tree 127.6s 27.60s 62.3% 1.8 Percolation 31.4s 4.91s 15.3% 1.9–11 Leaf updates 6.2s 1.75s 3.0% 1.5–11 Total 204.9s 32.6s 100.0% 2004),10 the only one that we were able to train and test under exactly the same experimental conditions (including the use of POS tags from Ratnaparkhi (1996)).
W96-0213
Our decision tree ensembles contain over two orders of magnitude more compound features than those in Turian and Melamed (2005).
W05-1515
For reasons given in Turian and Melamed (2006), items are inferred bottom-up right-to-left.
P06-1110
For example, Riezler (2004) reports that the lscript1 regularization term drives many of the model’s parameters to zero during conjugate gradient optimization, which are 23 then pruned before subsequent optimization steps to avoid numerical instability.
W04-3223
Successful discriminative parsers have used generative models to reduce training time and raise accuracy above generative baselines (Collins & Roark, 2004; Henderson, 2004; Taskar et al., 2004).
P04-1013 P04-1015 W04-3201
The initial state contains terminal items, whose labels are the POS tags given by Ratnaparkhi (1996).
W96-0213
Charniak and Johnson (2005) use linguistically more sophisticated features, and Bod (2003) and Kudo et al.(2005) use sub-tree features, all of which we plan to try in future work.
E03-1005 P05-1022 P05-1024
Syntax-driven SMT systems are typically trained on an order of magnitude more sentences than English parsers, and unsupervised estimation methods can generate an arbitrary number of negative examples (Smith & Eisner, 2005).
P05-1044
Training Set Our training set I contains all inferences considered in every state along the correct path for each goldstandard parse tree (Sagae & Lavie, 2005).7 This method of generating training examples does not require a working parser and can be run prior to any training.
W05-1513
a Gaussian prior) •SVMs using most kernels •multilayer neural nets trained by backpropagation •the perceptron algorithm 4Turian and Melamed (2005) show that that decision trees applied to parsing have higher accuracy and training speed than decision stumps.
W05-1515
Set Results To situate our results in the literature, we compare our results to those reported by Taskar et al.(2004) and Turian and Melamed (2005) for their discriminative parsers, which were also trained and tested on ≤ 15 word sentences.
W04-3201 W05-1515
In this way, instead of choosing the best λ heuristically, we can optimize it during a single training run (Turian & Melamed, 2005).
W05-1515
% Turian and Melamed (2005) 87.13 86.47 87.80 Bikel (2004) 88.30 87.85 88.75 Taskar et al.(2004) 89.12 89.10 89.14 our parser 89.40 89.26 89.55 Table 2 Profile of an NP training iteration, given in seconds, using an AMD Opteron 242 (64-bit, 1.6Ghz).
J04-4004 W04-3201 W05-1515
Like our work, Ratnaparkhi (1999) and Sagae and Lavie (2005) generate examples off-line, but their parsing strategies are essentially shift-reduce so each sentence generates only O(n) training examples.
W05-1513
We omit details given by Turian and Melamed (2006) in favor of a longer discussion in §4.2.
P06-1110
We evaluated our parser using the standard PARSEVAL measures (Black et al., 1991): labelled precision, labelled recall, and labelled F-measure (Prec., Rec., and F1, respectively), which are based on the number of non-terminal items in the parser’s output that match those in the gold-standard parse.
H91-1060
Black, E., Abney, S., Flickenger, D., Gdaniec, C., Grishman, R., Harrison, P., et al.(1991). A procedure for quantitatively comparing the syntactic coverage of English grammars.
H91-1060
20 Turian and Melamed (2005) observed that uniform example biases b(i) produced lower accuracy as training progressed, because the induced classifiers minimized the example-wise error.
W05-1515
Although generating training examples in advance without a working parser (Sagae & Lavie, 2005) is much faster than using inference (Collins & Roark, 2004; Henderson, 2004; Taskar et al., 2004), our training time can probably be decreased further by choosing a parsing strategy with a lower branching factor.
P04-1013 P04-1015 W04-3201 W05-1513
We use the same preprocessing steps as Turian and Melamed (2005): during both training and testing, the parser is given text POS-tagged by the tagger of Ratnaparkhi (1996), with capitalization stripped and outermost punctuation removed.
W05-1515 W96-0213
Like Turian and Melamed (2005), we parallelize training by inducing 26 label classifiers (one for each non-terminal label in the Penn Treebank).
W05-1515
