IBM Models 1, 2, and 3 refer to Brown et al.(1993). “Tree-to-String” is the model of Yamada and Knight (2001), and “Tree-to-String, Clone” allows the node cloning operation of Section 2.1. “Tree-to-Tree” indicates the model of Section 3, while “Tree-to-Tree, Clone” adds the node cloning operation of Section 3.1.
J93-2003 P01-1067
The use of explicit syntactic information for the target language in this model has led to excellent translation results (Yamada and Knight, 2002), and raises the prospect of training a statistical system using syntactic information for both sides of the parallel corpus.
P02-1039
Yamada and Knight (2001) present an algorithm for estimating probabilistic parameters for a similar model which represents translation as a sequence of re-ordering operations over children of nodes in a syntactic tree, using automatic parser output for the initial tree structures.
P01-1067
However, real bitexts generally do not exhibit parse-tree isomorphism, whether because of systematic differences between how languages express a concept syntactically (Dorr, 1994), or simply because of relatively free translations in the training material.
J94-4004
Tree-to-String Model We begin by summarizing the model of Yamada and Knight (2001), which can be thought of as representing translation as an Alexander Calder mobile.
P01-1067
The approach of optimizing a small number of metaparameters has been applied to machine translation by Och and Ney (2002).
P02-1038
Alshawi et al.(2000) also induce parallel tree structures from unbracketed parallel text, modeling the generation of each node’s children with a finite-state transducer.
J00-1004
Wu (1997) showed that restricting word-level alignments between sentence pairs to observe syntactic bracketing constraints significantly reduces the complexity of the alignment problem and allows a polynomial-time solution.
J97-3002
Systems for automatic translation between languages have been divided into transfer-based approaches, which rely on interpreting the source string into an abstract semantic representation from which text is generated in the target language, and statistical approaches, pioneered by Brown et al.(1990), which estimate parameters for a model of word-to-word correspondences and word re-orderings directly from large corpora of parallel bilingual text.
J90-2002
We provide a comparison of the tree-based models with the sequence of successively more complex models of Brown et al.(1993). Results are shown in Table 2.
J93-2003
In part to deal with this problem, Yamada and Knight (2001) flatten the trees in a pre-processing step by collapsing nodes with the same lexical head-word.
P01-1067
For reasons of speed, Yamada and Knight (2002) limited training to sentences of length 30, and were able to use only one fifth of the available Chinese-English parallel corpus.
P02-1039
Dorr. 1994.
J94-4004
For scoring the viterbi alignments of each system against goldstandard annotated alignments, we use the alignment error rate (AER) of Och and Ney (2000), which measures agreement at the level of pairs of words: 1 AER =1− 2jA \ Gj jAj + jGj 1 While Och and Ney (2000) differentiate between sure and possible hand-annotated alignments, our gold standard alignments come in only one variety.
P00-1056
As seen for other tasks (Carroll and Charniak, 1992; Merialdo, 1994), the likelihood criterion used in EM training may not be optimal when evaluating a system against human labeling.
J94-2001
