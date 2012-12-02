The features used in Kambhatla (2004) and Zhou et al.(2005) have to be selected and carefully calibrated manually.
P04-3022 P05-1053
Culotta and Sorensen (2004) used an ACE corpus including about 800 documents, and they did not specify the corpus version.
P04-1054
Convolution Tree Kernel Given the relation instances defined in the previous section, we use the same convolution tree kernel as the parse tree kernel (Collins and Duffy, 2001) and the semantic kernel (Moschitti, 2004).
P04-1043
From the syntactic viewpoint, the tree representation in our feature space is more robust than “Parse Tree Path” feature in the flat feature set since the path feature is very sensitive to the small changes of parse trees (Moschitti, 2004) and it also does not maintain the hierarchical information of a parse tree.
P04-1043
Zhou et al.(2005) explore various features in relation extraction using SVM.
P05-1053
We may adopt a two-step method (Culotta and Sorensen, 2004) to separately model the relation detection and characterization issues.
P04-1054
The same as previous work 2 For the convenience of discussion, without losing generality, we call the features used in Zhou et al.(2005) and Kambhatla (2004) flat feature set.
P04-3022 P05-1053
However it is reported (Zhou et al., 2005; Kambhatla, 2004) that hierarchical structured syntactic features contributes less to performance improvement.
P04-3022 P05-1053
Kambhatla (2004) employs Maximum Entropy models to combine diverse lexical, syntactic and semantic features derived from the text for relation extraction.
P04-3022
In particular, the kernel methods could be very effective at reducing the burden of feature engineering for structured objects in NLP research (Culotta and Sorensen, 2004).
P04-1054
Therefore, although this kernel shows non-trivial performance improvement than that of Culotta and Sorensen (2004), the constraint makes the two dependency kernels share the similar behavior: good precision but much lower recall on the ACE corpus.
P04-1054
The Tree Kernel (Collins and Duffy, 2001), String Subsequence Kernel (SSK) (Lodhi et al., 2002) and Graph Kernel (HDAG Kernel) (Suzuki et al., 2003) are examples of convolution kernels instances in the NLP field.
P03-1005
In our implementation, we use the binary SVMLight developed by Joachims (1998) and Tree Kernel Toolkits developed by Moschitti (2004).
P04-1043
Since our method only counts the occurrence of each sub-tree without considering its ancestors, our method is not limited by the constraints in Culotta and Sorensen (2004) and that in Bunescu and Mooney (2005) as discussed in Section 2.
H05-1091 P04-1054
Besides, Zhou et al.(2005) introduce additional chunking features to enhance the parse tree features.
P05-1053
Miller et al.(2000) address the task of relation extraction from the statistical parsing viewpoint.
A00-2030
Kambhatla (2004) use the path of non-terminals connecting two mentions in a parse tree as the parse tree features.
P04-3022
Methods P R F Ours: convolution kernel over parse trees 76.32 (64.6) 62.99 (50.76) 69.02 (56.83) Kambhatla (2004): feature-based ME (63.5) (45.2) (52.8) Zhou et al.(2005): feature-based SVM 77.2 (63.1) 60.7 (49.5) 68.0 (55.5) Culotta and Sorensen (2004): dependency kernel 67.1 (-) 35.0 (-) 45.8 (-) Bunescu and Mooney (2005): shortest path dependency kernel 65.5 (-) 43.8 (-) 52.5 (-) Table 3.
H05-1091 P04-1054 P04-3022 P05-1053
parse tree structures and entity information) very effectively and the syntactic features are also particu3 Zhao and Grishman (2005) also evaluated their algorithm on the ACE corpus and got good performance.
P05-1052
Bunescu and Mooney (2005) propose a shortest path dependency kernel for relation extraction.
H05-1091
292 (Zhou et al., 2005), our experiments are carried out on explicit relations due to the poor inter-annotator agreement in annotation of implicit relations and their limited numbers.
P05-1053
Zhao and Grishman (2005) define a featurebased composite kernel to integrate diverse features.
P05-1052
We use Charniak’s parser (Charniak, 2001) to parse the example sentence.
P01-1017
It also shows that our method significantly outperforms the two dependency tree kernels (Bunescu and Mooney, 2005; Culotta and Sorensen, 2004) on the 5 ACE relation types.
H05-1091 P04-1054
Besides the entity information, we further incorporate the semantic features used in Zhou et al.(2005) into the corresponding leaf nodes.
P05-1053
This is a strong constraint on the matching of syntax so it is not surprising that the model has good precision but very low recall on the ACE corpus (Zhao and Grishman, 2005).
P05-1052
But to our surprise, the sole two-reported dependency tree kernels for relation extraction on the ACE corpus (Bunescu and Mooney, 2005; Culotta and Sorensen, 2004) showed much lower performance than the feature-based methods.
H05-1091 P04-1054
Culotta and Sorensen (2004) generalize this kernel to estimate similarity between dependency trees.
P04-1054
Prior feature-based methods for this task (Kambhatla 2004; Zhou et al., 2005) employed a large amount of diverse linguistic features, varying from lexical knowledge, entity mention information to syntactic parse trees, dependency trees and semantic features.
P04-3022 P05-1053
