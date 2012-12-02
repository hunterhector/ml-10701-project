For example, both papers propose minimum-risk decoding, and McDonald and Satta (2007) discuss unsupervised learning and language modeling, while Smith and Smith (2007) define hiddenvariable models based on spanning trees.
D07-1014 W07-2216
Sets and Features We used data from the CoNLL-X shared task on multilingual dependency parsing (Buchholz and Marsi, 2006).
W06-2920
4.2 Max-Margin Estimation The second learning algorithm we consider is the large-margin approach for structured prediction (Taskar et al., 2004a; Taskar et al., 2004b).
W04-3201
Max-margin learning has been applied to PCFG parsing by Taskar et al.(2004b). They show that this problem has a QP dual of polynomial size, where the dual variables correspond to marginal probabilities of CFG rules.
W04-3201
McDonald and Pereira (2006) define a second-order dependency parsing model in which interactions between adjacent siblings are allowed, and Carreras (2007) defines a second-order model that allows grandparent and sibling interactions.
D07-1101 E06-1011 W06-2932
Second, McDonald and Satta (2007) propose an O(n5) algorithm for computing the marginals, as opposed to the O(n3) matrix-inversion approach used by Smith and Smith (2007) and ourselves.
D07-1014 W07-2216
Computation of the marginals and partition function can also be achieved in O(n3) time, using a variant of the inside-outside algorithm (Baker, 1979) applied to the Eisner (1996) data structures (Paskin, 2001).
C96-1058
We train the model using the approach described by Sha and Pereira (2003).
N03-1028
Following McDonald et al.(2005a), we use a discriminative model for dependency parsing.
H05-1066 P05-1012
Smith. 2007.
D07-1014
In this paper we consider training algorithms based on work in conditional random fields (CRFs) (Lafferty et al., 2001) and max-margin methods (Taskar et al., 2004a).
W04-3201
Carreras. 2007.
D07-1101
We first reiterate the observation of McDonald et al.(2005a) that non-projective parses correspond to directed spanning trees on a complete directed graph of n nodes, where n is the length of the sentence.
H05-1066 P05-1012
5It should be noted that McDonald et al.(2006) use a richer feature set that is incomparable to our features.
E06-1011 W06-2932
In line with McDonald et al.(2005b), we confirm that spanning-tree models are well-suited to dependency parsing, especially for highly non-projective languages such as Dutch.
H05-1066 P05-1012
4.1 Log-Linear Estimation In conditional log-linear models (Johnson et al., 1999; Lafferty et al., 2001), a distribution over parse trees for a sentence x is defined as follows: P(y|x;w) = exp braceleftBigsummationtext (h,m)∈y w ·f(x,h,m) bracerightBig Z(x;w) (7) where Z(x;w) is the partition function, a sum over T sp (x), T snp(x), T mp (x) or T mnp(x).
P01-1042 P99-1069
The majority of previous work on dependency parsing has focused on local (i.e., classification of individual edges) discriminative training methods (Yamada and Matsumoto, 2003; Nivre et al., 2004; Y.
W04-2407
We applied the above two marginal-based training algorithms to six languages with varying degrees of non-projectivity, using datasets obtained from the CoNLL-X shared task (Buchholz and Marsi, 2006).
W06-2920
All projective models were trained on these new training sets.4 Our feature space is based on that of McDonald et al.(2005a).5 6.2 Results We performed experiments using three training algorithms: the averaged perceptron (Collins, 2002), log-linear training (via conjugate gradient descent), and max-margin training (via the EG algorithm).
H05-1066 P05-1012 W02-1001
Decoding can be carried out using Viterbistyle dynamic-programming algorithms, for example the O(n3) algorithm of Eisner (1996).
C96-1058
Work Global log-linear training has been used in the context of PCFG parsing (Johnson, 2001).
P01-1042
This contrasts with the online learning algorithms used in previous work with spanning-tree models (McDonald et al., 2005b).
H05-1066 P05-1012
Johnson. 2001.
P01-1042
McDonald et al.(2005a; 2005b) trained global models using online algorithms such as the perceptron algorithm or MIRA.
H05-1066 P05-1012
For higher-order non-projective parsing, however, computational complexity results (McDonald and Pereira, 2006; McDonald and Satta, 2007) indicate that exact solutions to the three inference problems of Section 2.2 will be intractable.
E06-1011 W06-2932 W07-2216
In the non-projective case (i.e., T (x) defined as T snp(x) or T mnp(x)), McDonald et al.(2005b) describe how the CLE algorithm (Chu and Liu, 1965; Edmonds, 1967) can be used for decoding.
H05-1066 P05-1012
These algorithms compute marginal probabilities and partition functions, quantities which are central to many methods for the statistical modeling of complex structures (e.g., the EM algorithm (Baker, 1979; Baum et al., 1970), contrastive estimation (Smith and Eisner, 2005), training algorithms for CRFs (Lafferty et al., 2001), and training algorithms for max-margin models (Bartlett et al., 2004; Taskar et al., 2004a)).
P05-1044 W04-3201
Two other groups of authors have independently and simultaneously proposed adaptations of the Matrix-Tree Theorem for structured inference on directed spanning trees (McDonald and Satta, 2007; SmithandSmith,2007).
D07-1014 W07-2216
Non-local (i.e., classification of entire trees) training methods were used by McDonald et al.(2005a), who employed online learning.
H05-1066 P05-1012
Similar adaptations of the Matrix-Tree Theorem have been developed independently and simultaneouslybySmithandSmith(2007)andMcDonaldand Satta (2007); see Section 5 for more discussion.
D07-1014 W07-2216
These structures are equivalent to non-projective dependency parses (McDonald et al., 2005b), and more generally could be relevant to any task that involves learning a mapping from a graph to an underlying spanning tree.
H05-1066 P05-1012
