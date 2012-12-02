We use Charniak’s parser (Charniak, 2001) to parse the example sentence.
P01-1017
Since Zhao and Grishman (2005) use a 5-fold cross-validation on a subset of the 2004 data (newswire and broadcast news domains, containing 348 documents and 4400 relation instances), for comparison, we use the same setting (5-fold cross-validation on the same subset of the 2004 data, but the 5 partitions may not be the same) for the ACE 2004 data.
P05-1052
In our implementation, we use the binary SVMLight (Joachims, 1998) and Tree Kernel Tools (Moschitti, 2004).
P04-1043
Methods (2002/2003 data) P(%) R(%) F Ours: composite kernel 2 (polynomial expansion) 77.3 (64.9) 65.6 (51.2) 70.9 (57.2) Zhou et al.(2005): feature-based SVM 77.2 (63.1) 60.7 (49.5) 68.0 (55.5) Kambhatla (2004): feature-based ME (-) (63.5) (-) (45.2) (-) (52.8) Ours: tree kernel with entity information at node 76.1 (62.4) 62.6 (48.5) 68.7 (54.6) Bunescu and Mooney (2005): shortest path dependency kernel 65.5 (-) 43.8 (-) 52.5 (-) Culotta and Sorensen (2004): dependency kernel 67.1 (-) 35.0 (-) 45.8 (-) Table 3.
H05-1091 P04-1054 P04-3022 P05-1053
Culotta and Sorensen (2004) used a generic ACE corpus including about 800 documents (no corpus version is specified).
P04-1054
That is, it is 4 Bunescu and Mooney (2005) used the ACE 2002 corpus, including 422 documents, which is known to have many inconsistencies than the 2003 version.
H05-1091
They show that our method outperforms the previous methods and significantly outperforms the previous two dependency kernels 4 . This may be due to two reasons: 1) the dependency tree (Culotta and Sorensen, 2004) and the shortest path (Bunescu and Mooney, 2005) lack the internal hierarchical phrase structure information, so their corresponding kernels can only carry out node-matching directly over the nodes with word tokens; 2) the parse tree kernel has less constraints.
H05-1091 P04-1054
In relation extraction, typical work on kernel methods includes: Zelenko et al.(2003), Culotta and Sorensen (2004) and Bunescu and Mooney (2005).
H05-1091 P04-1054
Both corpora are parsed using Charniak’s parser (Charniak, 2001).
P01-1017
Bunescu and Mooney (2005) proposed another dependency tree kernel for relation extraction.
H05-1091
Therefore, although this kernel shows performance improvement over the previous one (Culotta and Sorensen, 2004), the constraint makes the two dependency kernels share the similar behavior: good precision but much lower recall on the ACE corpus.
P04-1054
Here we use the same convolution parse tree kernel as described in Collins and Duffy (2001) for syntactic parsing and Moschitti (2004) for semantic role labeling.
P04-1043
For example, the kernels for structured natural language data, such as parse tree kernel (Collins and Duffy, 2001), string kernel (Lodhi et al., 2002) and graph kernel (Suzuki et al., 2003) are example instances of the wellknown convolution kernels 1 in NLP.
P03-1005
Moreover, the difference between our method and Bunescu and Mooney (2005) is that their kernel is defined on the shortest path between two entities instead of the entire subtrees.
H05-1091
classify the feature-based kernel defined in (Zhao and Grishman, 2005) into the feature-based methods since their kernels can be easily represented by the dot-products between explicit feature vectors.
P05-1052
Performance comparison on the ACE 2003/2003 data over both 5 major types (the numbers outside parentheses) and 24 subtypes (the numbers in parentheses) Methods (2004 data) P(%) R(%) F Ours: composite kernel 2 (polynomial expansion) 76.1 (68.6) 68.4 (59.3) 72.1 (63.6) Zhao and Grishman (2005): feature-based kernel 69.2 (-) 70.5 (-) 70.4 (-) Table 4.
P05-1052
Culotta and Sorensen (2004) generalized it to estimate similarity between dependency trees.
P04-1054
Work Many techniques on relation extraction, such as rule-based (MUC, 1987-1998; Miller et al., 2000), feature-based (Kambhatla 2004; Zhou et al., 2005) and kernel-based (Zelenko et al., 2003; Culotta and Sorensen, 2004; Bunescu and Mooney, 2005), have been proposed in the literature.
A00-2030 H05-1091 P04-1054 P04-3022 P05-1053
(2) Compared with Previous Kernels: Since our method only counts the occurrence of each sub-tree without considering the layer and the ancestors of the root node of the sub-tree, our method is not limited by the constraints (identical layer and ancestors for the matchable nodes, as discussed in Section 2) in Culotta and Sorensen (2004).
P04-1054
Feature-based methods (Kambhatla, 2004; Zhou et al., 2005; Zhao and Grishman, 2005 2 ) for this task employ a large amount of diverse linguistic features, such as lexical, syntactic and semantic features.
P04-3022 P05-1052 P05-1053
Miller et al.(2000) addressed the task from the syntactic parsing viewpoint and integrated various tasks such as POS tagging, NE tagging, syntactic parsing, template extraction and relation extraction using a generative model.
A00-2030
