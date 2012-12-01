The model we used is the hybrid Markov/semiMarkov CRF described by Andrew (2006), which was shown to have state-of-the-art accuracy.
W06-1655
Riezler and Vasserman (2004) showed that an L1-regularized ME estimator outperformed an L2-regularized estimator for ranking the parses of a stochastic unification-based grammar.
W04-3223
Following previous work (Ratnaparkhi, 1996), we assume that the tag of a word is independent of the tags of all preceding words given the tags of the previous two words (i.e., 𝑘 =2 in the equation above).
W96-0213
In our experiments, we used the Averaged Perceptron algorithm of Freund and Schapire (1999), a variation that has been shown to be more effective than the standard algorithm (Collins 2002).
W02-1001
Kazama and Tsujii (2003) described an estimation method that constructs an equivalent constrained optimization problem with twice the number of variables.
W03-1018
The model and experimental setup is identical with that of Andrew (2006) except for two differences.
W06-1655
re-ranking We follow the experimental paradigm of parse re-ranking outlined in Charniak and Johnson (2005), and fed the features extracted by their program to the five rerankers we developed.
P05-1022
L1 or Lasso regularization of linear models, introduced by Tibshirani (1996), embeds feature selection into regularization so that both an assessment of the reliability of a feature and the decision about whether to remove it are done in the same framework, and has generated a large amount of interest in the NLP community recently (e.g., Goodman 2003; Riezler and Vasserman 2004).
N04-1039 W04-3223
Lasso The Boosted Lasso (BLasso) algorithm was originally proposed in Zhao and Yu (2004), and was adapted for language modeling by Gao et al.(2006). BLasso can be viewed as a version of Boosting with L1 regularization.
P06-1029
See Gao et al.(2006) for implementation details, and Zhao and Yu (2004) for a theoretical justification for BLasso.
P06-1029
825 Because for some sentences there are multiple best parses (i.e., parses with the same F-Score), we used the variant of ME estimator described in Riezler et al.(2002), where 𝐿 𝒘 is defined as the likelihood of the best parses 𝑦 ∈ 𝑌 (𝑥 ) relative to the n-best parser output 𝑮 𝑬 𝑵 𝑥, (i.e., 𝑌 𝑥 ⊑ 𝑮 𝑬 𝑵 (𝑥 )): 𝐿 𝒘 = − log 𝑃 (𝑦 𝑖 |𝑥 𝑖 )𝑦 𝑖 ∈ 𝑌 (𝑥 𝑖 )𝑛𝑖 =1 . We applied this variant in our experiments of parse re-ranking and LM adaptation, and found that on both tasks it leads to a significant improvement in performance for the L2-regularied ME estimator but not for the L1-regularied ME estimator.
P02-1035
The results are summarized in Table 5.3 We note that all three algorithms performed slightly better than the model used by Andrew (2006), which also used L2 regularization (96.84 F1).
W06-1655
First, we extracted features from both positive and negative training examples, while Andrew (2006) uses only features that occur in some positive training example.
W06-1655
ME estimators with L2 regularization, which have been widely used in NLP tasks (e.g., Chen and Rosenfeld 2000; Charniak and Johnson 2005; Johnson et al.1999), tend to produce models that have this property.
P05-1022 P99-1069
We used the standard splits of the Penn Treebank from the tagging literature (Toutanova et al.2003) for training, development and test sets.
N03-1033
In addition, the perceptron algorithm and its variants, e.g., the voted or averaged perceptron, is becoming increasingly popular due to their competitive performance, simplicity in implementation and low computational cost in training (e.g., Collins 2002).
W02-1001
The results are presented in Tables 12 and 2, where Baseline results were obtained using the parser by Charniak (2000).
A00-2018
For example, in the parse re-ranking task, one cannot tell whether the L2regularized ME approach used by Charniak and Johnson (2005) significantly outperforms the Boosting method by Collins (2000) because different feature sets and n-best parses were used in the evaluations of these methods.
A00-2018 P05-1022
model adaptation Our experiments with LM adaptation are based on the work described in Gao et al.(2006). The variously trained language models were evaluated according to their impact on Japanese text input accuracy, where input phonetic symbols 𝑥 are mapped into a word string 𝑦 . Performance of the application is measured in terms of character error 2 The result of ME/L2 is better than that reported in Andrew and Gao (2007) due to the use of the variant of L2-regularized ME estimator, as described in Section 2.1.
P06-1029
Gao et al.(2006) showed that BLasso, due to its explicit use of L1 regularization, outperformed Boosting in the LM adaptation task.
P06-1029
The linear model combines the log probability calculated by the Charniak (2000) parser as a feature with 1,219,272 additional features.
A00-2018
In our experiments, we used the limited memory quasi-Newton algorithm (or L-BFGS, Nocedal and Wright 1999) to find the optimal 𝒘 because this method has been shown to be substantially faster than other methods such as Generalized Iterative Scaling (Malouf 2002).
W02-2018
