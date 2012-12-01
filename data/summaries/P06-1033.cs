Other examples can be found in the work of Johnson (1998) and Klein and Manning (2003), which show that well-chosen transformations of syntactic representations can greatly improve the parsing accuracy obtained with probabilistic context-free grammars.
J98-4004 P03-1054
Bikel. 2004.
J04-4004
MaltParser (Nivre and Hall, 2005; Nivre et al., 2006) is a data-driven parser-generator, which can induce a dependency parser from a treebank, and which supports several parsing algorithms and learning algorithms.
P05-1013 W05-1505
Thus, Nivre and Nilsson (2005) improve parsing accuracy for MaltParser by projectivizing training data and applying an inverse transformation to the output of the parser, while Hall and Nov´ak (2005) apply post-processing to the output of Charniak’s parser (Charniak, 2000).
A00-2018 P05-1013 W05-1505
Work Other ways of improving parsing accuracy with respect to coordination include learning patterns of morphological and semantical information for the conjuncts (Park and Cho, 2000).
C00-2086
This is well illustrated by the Collins parser (Collins, 1997; Collins, 1999), scrutinized by Bikel (2004), where several transformations are applied in order to improve the analysis of noun phrases, coordination and punctuation.
J04-4004 P97-1003 P99-1065
More specifically for PDT, Collins et al.(1999) relabel coordinated phrases after converting dependency structures to phrase structures, and Zeman (2004) uses a kind of pattern matching, based on frequencies of the parts-of-speech of conjuncts and conjunctions.
P99-1065
262 AS EM T LA U L U L None MBL 79.08 72.83 28.99 21.15 τp MBL 80.79 74.39 31.54 22.53 τp◦τv◦τc+∗ MBL 82.93 76.31 34.17 23.01 None SVM 81.09 75.68 32.24 25.02 τp SVM 82.93 77.28 35.99 27.05 τp◦τv◦τc+∗ SVM 84.55 78.82 37.63 27.69 Table 5: Optimized parsing results (SVM, ∆e); T = transformation; LA = learning algorithm; AS = attachment score, EM = exact match; U = unlabeled, L = labeled T P:S R:S P:C R:C P:A R:A P:M R:M None 52.63 72.35 55.15 67.03 82.17 82.21 69.95 69.07 τp◦τv◦τc+∗ 63.73 82.10 63.20 75.14 90.89 92.79 80.02 81.40 Table 6: Detailed results for SVM; T = transformation; P = unlabeled precision, R = unlabeled recall costly to train (Sagae and Lavie, 2005).
W05-1513
A partial explanation may be found in the “short-dependency preference” exhibited by most parsers (Eisner and Smith, 2005), with MaltParser being no exception.
W05-1504
We write τp for the projectivization of training data and τ−1p for the inverse transformation applied to the parser’s output.6 In addition, we replace MBL with SVM, a learning algorithm that tends to give higher accuracy in classifier-based parsing although it is more 6More precisely, we use the variant called PATH in Nivre and Nilsson (2005).
P05-1013
We see that pseudo-projective parsing brings a very consistent increase in accuracy of at least 1.5 percentage points, which is more than that reported by Nivre and Nilsson (2005), and that the addition of the PS-to-MS transformations increases accuracy with about the same margin.
P05-1013
3: Optimization In this section we combine the best results from the previous section with the graph transformations proposed by Nivre and Nilsson (2005) to recover non-projective dependencies.
P05-1013
Lombardo and Lesmo (1998) conjecture that MS is more suitable than PS for incremental dependency parsing.
W98-0502
Whether better parsing accuracy can be obtained by transforming 1About 2% of all dependencies are non-projective and about 25% of all sentences have a non-projective dependency graph (Nivre and Nilsson, 2005).
P05-1013
The part-of-speech tagging used (both in training and testing) is the HMM tagging distributed with the treebank, with a tagging accuracy of 94.1%, and with the tagset compressed to 61 tags as in Collins et al.(1999). Data #S #W %S %C %A ∆t 73088 1256k 3.9 7.7 1.3 ∆d 7319 126k 4.0 7.8 1.4 ∆e 7507 126k 3.8 7.3 1.4 Table 1: PDT data sets; S = sentence, W = word; S = separator, C = conjunct, A = auxiliary verb T AS τc 97.8 τc∗ 98.6 τc+ 99.6 τc+∗ 99.4 τv 100.0 Table 2: Transformations; T = transformation; AS = attachment score (unlabeled) of τ−1(τ(∆t)) compared to ∆t MaltParser is used with the parsing algorithm of Nivre (2003) together with the feature model used for parsing Czech by Nivre and Nilsson (2005).
P05-1013 P99-1065
For unlabeled exact match, our results are better than any previously reported results, including those of McDonald and Pereira (2006).
E06-1011
Using ensemble methods and a pool of different parsers, Zeman and ˇZabokrtsk´y (2005) attain a top score of 87.0%.
W05-1518
Hall and Nov´ak (2005) report a score of 85.1%, applying a corrective model to the output of Charniak’s parser; McDonald and Pereira (2006) achieve a score of 85.2% using a second-order spanning tree algorithm.
E06-1011 W05-1505
In section 4.2 we use MBL, again with the same settings as Nivre and Nilsson (2005),3 and in section 4.2 we use SVM with a polynomial kernel of degree 2.4 The metrics for evaluation are the attachment score (AS) (labeled and unlabeled), i.e., the proportion of words that are assigned the correct head, and the exact match (EM) score (labeled and unlabeled), i.e., the proportion of sentences that are assigned a completely correct analysis.
P05-1013
The parser used is MaltParser (Nivre and Hall, 2005; Nivre et al., 2006), a freely available system that combines a deterministic parsing strategy with discriminative classifiers for predicting the next parser action.
P05-1013 W05-1505
