Reranking In recent years, reranking techniques have been successfully used in statistical parsers to rerank the output of history-based models (Black et al., 1993).
P93-1005
For example, all possible sub-trees can be used as features (Collins and Duffy, 2002; Bod, 2003).
E03-1005 P02-1034
In (Collins and Duffy, 2002), lexical items are all located at the leaf nodes of parse trees.
P02-1034
In (Collins and Duffy, 2002), the Voted Perceptron algorithm was used for parse reranking.
P02-1034
CD02 = (Collins and Duffy, 2002).
P02-1034
In (Shen and Joshi, 2003), a SVM based reranking algorithm was proposed.
W03-0402
Speci cally, slice i contains positive samples ((~pk;pki); +1) and negative samples ((pki; ~pk); 1), where ~pk is the best parse for sentence k, pki is the parse with the ith highest loglikelihood in all the parses for sentence k and it is not the best parse (Shen and Joshi, 2003).
W03-0402
Then the outcome is combined with the result of the linear kernel SVMs trained on features extracted from the derived trees which are reported in (Shen and Joshi, 2003).
W03-0402
In addition to adjunction, we also use sister adjunction as de ned in the LTAG statistical parser described in (Chiang, 2000).1 The tree resulting from the combination of elementary trees is is called a derived tree.
P00-1058
As described above, we use the SVM based voting algorithm (Shen and Joshi, 2003) in our reranking experiments.
W03-0402
It is worth mentioning that the f-scores reported in (Collins and Duffy, 2002) are about 1% less than the results in (Collins, 2000).
P02-1034
The comparison between (Collins, 2000) and (Collins and Duffy, 2002) in x3 shows that it is hard to add new features to improve performance.
P02-1034
In this paper, we use the LTAG based features in the parse reranking problem (Collins, 2000; Collins and Duffy, 2002).
P02-1034
Also, Model 1 provides a 10% reduction in error over (Collins and Duffy, 2002) where the features from tree kernel were over arbitrary sub-trees.
P02-1034
SJ03 = linear kernel of (Shen and Joshi, 2003).
W03-0402
3. Our algorithm is similar to the derivation tree extraction explained in (Chiang, 2000), except we extract our LTAG from n-best sets of parse trees, while in (Chiang, 2000) the LTAG is extracted from the Penn Treebank.3 For other techniques for LTAG grammar extraction see (Xia, 2001; Chen and Vijay-Shanker, 2000).
P00-1058
Our results show a 17% relative difference in f-score improvement over the use of a linear kernel without LTAG based features (Shen and Joshi, 2003).
W03-0402
We use the Support Vector Machine (SVM) (Vapnik, 1999) based algorithm proposed in (Shen and Joshi, 2003) as the reranker in this paper.
W03-0402
