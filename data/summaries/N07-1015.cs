General structural representations of natural language data have been studied in (Suzuki et al., 2003; Cumby and Roth, 2003), but these models were not designed specifically for relation extraction.
P03-1005
Bunescu and Mooney (2005b) and Zhang et.
H05-1091
Therefore, both lines of work rely on an appropriately de1Although Zhao and Grishman (2005) defined a number of kernels for relation extraction, the method is essentially similar to feature-based methods.
P05-1052
Dependency Relations and Dependency Paths: These features have been explored by Bunescu and Mooney (2005a), Zhao and Grishman (2005), and Zhou et.
H05-1091 P05-1052
Some existing studies use corpus-based statistics for relation extraction (Hasegawa et al., 2004).
P04-1053
Grammar Productions: The features in convolution tree kernels for relation extraction (Zhang et al., 2006a; Zhang et al., 2006b) are sequences of grammar productions, that is, complete subtrees of the syntactic parse tree.
N06-1037 P06-1104
Work Zhao and Grishman (2005) and Zhou et al.(2005) explored a large set of features that are potentially useful for relation extraction.
P05-1052 P05-1053
H1: Zhang et al.(2006a) found that using pathenclosed tree performed better than using minimum complete tree, when convolution tree kernels were applied.
N06-1037 P06-1104
Of particular interest among the various kernels proposed are the convolution kernels (Bunescu and Mooney, 2005b; Zhang et al., 2006a), because they can efficiently compute the similarity between two instances in a huge feature space due to their recursive nature.
H05-1091 N06-1037 P06-1104
2http://ai-nlp.info.uniroma2.it/moschitti/Tree-Kernel.htm 3The performance we achieved is lower than that reported in (Zhang et al., 2006b), due to different data preprocessing, data partition, and parameter setting.
N06-1037 P06-1104
We also tried the convolution tree kernel method (Zhang et al., 2006a), using an SVM tree kernel package2.
N06-1037 P06-1104
Zelenko et al.(2003) and Culotta and Sorensen (2004) used tree kernels for relation extraction.
P04-1054
For example, gapped subsequence features in subsequence kernels (Bunescu and Mooney, 2005b) can be represented as subgraphs of the sequence representation if we add more edges to connect any pair of nodes u and v provided that the token represented by u occurs somewhere before that represented by v in the sentence.
H05-1091
Bigrams: A bigram feature (Zhao and Grishman, 2005) can be represented by a subgraph consisting of two connected nodes from the sequence representation, where each node is labeled with the token.
P05-1052
Bag-of-Words: These features have also been 116 explore by Zhao and Grishman (2005) and Zhou et.
P05-1052
The second line of work designs kernel functions on some structured representation (sequences or trees) of the relation instances to capture the similarity between two relation instances (Zelenko et al., 2003; Culotta and Sorensen, 2004; Bunescu and Mooney, 2005a; Bunescu and Mooney, 2005b; Zhang et al., 2006a; Zhang et al., 2006b).
H05-1091 N06-1037 P04-1054 P06-1104
The first utilizes a set of carefully selected features obtained from different levels of text analysis, from part-of-speech (POS) tagging to full parsing and dependency parsing (Kambhatla, 2004; Zhao and Grishman, 2005; Zhou et al., 2005)1.
P04-3022 P05-1052 P05-1053
Entity Attributes: Previous studies have shown that entity types and entity mention types of arg1 and arg2 are very useful (Zhao and Grishman, 2005; Zhou et al., 2005; Zhang et al., 2006b).
N06-1037 P05-1052 P05-1053 P06-1104
Bunescu and Mooney (2005a) proposed a dependency path kernel for relation extraction.
H05-1091
