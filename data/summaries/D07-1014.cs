Log-linear models have been used in parsing by Riezler et al.(2000) (for constraint-based grammars) and Johnson (2001) and Miyao and Tsujii (2002) (for CFGs).
P00-1061 P01-1042
If the trees are constrained to be projective, EM is easily applied using the inside-outside variant of the parsing algorithm described by Eisner (1996) to compute the marginal probability.
C96-1058
The Danish and Dutch datasets were prepared for the CoNLL 2006 shared task (Buchholz and Marsi, 2006); Arabic and Czech are from the 2007 shared task.
W06-2920
Following McDonald et al.(2005a), we assume that the features are edge-factored: vectorf(x,y) = nsummationdisplay i=1 vectorf(x,xi,xy(i)) (2) In other words, the dependencies between words in the tree are all conditionally independent of each other, given the sequence x and the fact that the parse is a spanning tree.
H05-1066 P05-1012
The solution to the conditionalization problem is given in Section 3, using a widely-known but newly-applied Matrix Tree TheoremduetoTutte(1984),andexperimentalresultsare presented with a comparison to the MIRA learning algorithm used by McDonald et al.(2005a). We go on to describe and experiment with two useful applications of conditional modeling: minimum Bayesrisk decoding (Section 4) and hidden-variable training by conditional maximum likelihood estimation (Section 5).
H05-1066 P05-1012
In particular, a clusterlearning algorithm that permits clusters to split and/or merge, as in Petrov et al.(2006) or in Pereira et al.(1993), may be appropriate.
P06-1055 P93-1024
We have already shown in Section 3 how to solve (a); here we avoid (b) by maximizing conditional likelihood, marginalizing out the hidden variable, denotedz: max vectorθ summationdisplay x,y ˜p(x,y)log summationdisplay z pvectorθ(y,z | x) (17) This sort of conditional training with hidden variables was carried out by Koo and Collins (2005), for example, in reranking; it is related to the information bottleneck method (Tishby et al., 1999) and contrastive estimation (Smith and Eisner, 2005).
H05-1064 P05-1044
Koo et al.(2007) and McDonald and Satta (2007) both describe how the Matrix Tree Theorem can be applied to computing the sum of scores of edgefactored dependency trees and the edge marginals.
D07-1015 W07-2216
135 decode train Arabic Czech Danish Dutch map MIRA 79.9 81.4 86.6 90.0 CE 80.4 80.2 87.5 90.0 (Section 3) mBr MIRA 79.4 80.3 85.0 87.2 (Section 4) CE 80.5 80.4 87.5 90.0 (Sections 3 & 4) Table 1: Unlabeled dependency parsing accuracy (on test data) for two training methods (MIRA, as in McDonald et al.(2005b), and conditional estimation) and with maximum a posteriori (map) and minimum Bayes-risk (mBr) decoding.
H05-1066 P05-1012
Noting that adding latent features to nonterminals in unlexicalized context-free parsing has been very successful (Chiang and Bikel, 2002; Matsuzaki et al., 2005; Prescher, 2005; Dreyer and Eisner, 2006; Petrov et al., 2006), we were surprised not to see a 3Czech experiments were not done, since the number of features (more than 14 million) was too high to multiply out by clusters.
C02-1126 P05-1010 P06-1055 W05-1512 W06-1638
First, there were generative, stochastic models like HMMs, PCFGs, and Eisner’s (1996) models.
C96-1058
More recently, EM has been used to learn hidden variables in parse trees; these can be head-childannotations(ChiangandBikel, 2002), latent head features (Matsuzaki et al., 2005; Prescher, 2005; Dreyer and Eisner, 2006), or hierarchicallysplit nonterminal states (Petrov et al., 2006).
C02-1126 P05-1010 P06-1055 W05-1512 W06-1638
Large-margin whole-structure models were proposed for sequence labeling by Altun et al.(2003), for constituents by Taskar et al.(2004), and for dependency trees by McDonald et al.(2005a). In this paper, we propose a model most similar to the conditional random fields— interpretable as log-linear models—of Lafferty et al.(2001), which are now widely used for sequence labeling.
H05-1066 P05-1012 W03-1019
A probability model permits alternative decoding procedures (Goodman, 1996).
P96-1024
Exact nonprojective inference and estimation become intractable if we break edge factoring (McDonald and Pereira, 2006).
E06-1011
The latest state-of-the-art statistical dependency parsers are discriminative, meaning that they are based on classifiers trained to score trees, given a sentence, either via factored whole-structure scores (McDonald et al., 2005a) or local parsing decision scores (Hall et al., 2006).
E06-1011 H05-1066 P05-1012
Summation over trees where x0 has exactly one child is addressed directly by Koo et al.(2007). 133 than the margin (McDonald et al., 2005a).
D07-1015 H05-1064 H05-1066 P05-1012
Notethattheapproximations to maximizing over spanning trees with second-order features, proposed by McDonald and Pereira (2006), do not permit estimating the clusters as part of the same process as weight estimation (at least not without modification).
E06-1011
For more applications in parsing, see Petrov and Klein (2007).
N07-1051
We compare conditional training of a nonprojective edge-factored parsing model to the online MIRA training used by McDonald et al.(2005b). Four languages with relatively common nonprojective phenomena were tested: Arabic (Hajiˇc et al., 2004), Czech (B¨ohmov´a et al., 2003), Danish (Kromann, 2003), and Dutch (van der Beek et al., 2002).
H05-1066 P05-1012
Dependency parsing can be used to provide a “bare bones” syntactic structurethatapproximatessemantics,andithastheadditionaladvantageofadmittingfastparsingalgorithms (Eisner, 1996; McDonald et al., 2005b) with a negligible grammar constant in many cases.
C96-1058 H05-1066 P05-1012
While discriminative methods, such as those presented in McDonald et al.(2005b), obtain very high accuracy on standard dependency parsing tasks and can be trained and applied without marginalization, “summing trees” permits some alternative techniques of interest.
H05-1066 P05-1012
This has been applied widely in unsupervised parsing (Carroll and Charniak, 1992; Klein and Manning, 2002).
P02-1017
Recently dependency parsing has received renewed interest, both in the parsing literature (Buchholz and Marsi, 2006) and in applications like translation (Quirk et al., 2005) and information extraction (Culotta and Sorensen, 2004).
P04-1054 P05-1034 W06-2920
The more commonly used maximum a posteriori decoding (also known as “Viterbi” decoding) that we applied in Section 3.3 sought to minimize the expected whole-tree loss: ˆy = argmax y pvectorθ(y | x) = argmin y Epvectorθ(Y|x) [−δ(y,Y)] (14) Minimum Bayes-risk decoding generalizes this idea to an arbitrary loss function lscript on the proposed tree: ˆy = argmin y Epvectorθ(Y|x) [lscript(y,Y)] (15) This technique was originally applied in speech recognition (Goel and Byrne, 2000) and translation (Kumar and Byrne, 2004); Goodman (1996) proposed a similar idea in probabilistic context-free parsing, seeking to maximize expected recall.
N04-1022 P96-1024
