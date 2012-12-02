Prior approaches to this task (Miller et al., 2000; Zelenko et al., 2003) have relied on partial or full syntactic analysis.
A00-2030
Culotta and Sorensen (2004) described a slightly generalized version of this kernel based on dependency trees.
P04-1054
Work Collins et al.(1997) and Miller et al.(2000) used statistical parsing models to extract relational facts from text, which avoided pipeline processing of data.
A00-2030
Kambhatla (2004) described a Maximum Entropy model using features from various syntactic sources, but the number of features they used is limited and the selection of features has to be a manual process.
P04-3022
In our approach, input text is preprocessed by the Charniak sentence parser (including tokenization and POS tagging) and the GLARF (Meyers et al., 2001) dependency analyzer produced by NYU.
W01-1511
Based on these observations, Zhao et al.(2004) proposed a discriminative model to combine information from different syntactic sources using a kernel SVM (Support Vector Machine).
C04-1109
