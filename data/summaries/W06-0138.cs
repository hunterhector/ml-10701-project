Ng and Low (2004) and Luo (2003) also trained single joint models over the Chinese segmentation and POS tagging subtasks.
W03-1025 W04-3236
Hinging on this idea, one way to avoid error propagation in chaining subtasks such as segmentation and POS tagging is to exploit the learning transfer (Sutton and McCallum, 2005) among subtasks, typically through joint inference.
H05-1094
Sutton and McCallum (Sutton and McCallum, 2005) suggested that in many cases exact inference can be too expensive and thus formidable.
H05-1094
Similar to (Sutton and McCallum, 2005), in our system we also train a cascade of linear-chain CRF for the subtasks.
H05-1094
3.1 Features for Segmentation We adopted the basic segmentation features used in (Ng and Low, 2004).
W04-3236
Furthermore, to evaluate our reranking method’s impact on the POS tagging task, we also performed 10-fold cross-validation tests on the 250k Penn 205 Chinese Treebank (CTB) (Xue et al., 2002).
C02-1145
