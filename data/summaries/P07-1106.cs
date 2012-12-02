averaged perceptron The averaged perceptron algorithm (Collins, 2002) was proposed as a way of reducing overfitting on the training data.
W02-1001
Another difference from our model is the rule-based submodel, which uses a dictionary-based forward maximum match method described by Sproat et al.(1996). 6 Experiments Two sets of experiments were conducted.
J96-3004
The second set of experiments used training and testing sets from the first and second international Chinese word segmentation bakeoffs (Sproat and Emerson, 2003; Emerson, 2005).
I05-3017 W03-1719
One existing method that is based on sub-word information, Zhang et al.(2006), combines a CRF and a rule-based model.
N06-2049
Experiments have shown that there is only about 75% agreement among native speakers regarding the correct word segmentation (Sproat et al., 1996).
J96-3004
Given an input sentence x, the correct output segmentation F(x) satisfies: F(x) = argmax y∈GEN(x) Score(y) where GEN(x) denotes the set of possible segmentations for an input sentence x, consistent with notation from Collins (2002).
W02-1001
It can be seen as an alternative to the ME and CRF models (Xue, 2003; Peng et al., 2004), which 843 1 word w 2 word bigram w1w2 3 single-character word w 4 a word starting with character c and having length l 5 a word ending with character c and having length l 6 space-separated characters c1 and c2 7 character bigram c1c2 in any word 8 the first and last characters c1 and c2 of any word 9 word w immediately before character c 10 character c immediately before word w 11 the starting characters c1 and c2 of two consecutive words 12 the ending characters c1 and c2 of two consecutive words 13 a word of length l and the previous word w 14 a word of length l and the next word w Table 1: feature templates do not involve word information.
C04-1081
Four training and testing corpora were used in the second bakeoff (Emerson, 2005), including the Academia Sinica corpus (AS), the Hong Kong City University Corpus (CU), the Peking University Corpus (PK) and the Microsoft Research Corpus (MR).
I05-3017
The term “global” feature vector is used by Collins (2002) to distinguish between feature count vectors for whole sequences and the “local” feature vectors in ME tagging models, which are Boolean valued vectors containing the indicator features for one element in the sequence.
W02-1001
Hence we use a beam-search decoder during training and testing; our idea is similar to that of Collins and Roark (2004) who used a beam-search decoder as part of a perceptron parsing model.
P04-1015
Note that the algorithm from Collins (2002) was designed for discriminatively training an HMM-style tagger.
W02-1001
Examples include Xue (2003), Peng et al.(2004) and Shi and Wang (2007); these use maximum entropy (ME) and conditional random field (CRF) models (Ratnaparkhi, 1998; Lafferty et al., 2001).
C04-1081
with Previous Work Among the character-tagging CWS models, Li et al.(2005) uses an uneven margin alteration of the traditional perceptron classifier (Li et al., 2002).
I05-3023
Despite the above differences, since the theorems of convergence and their proof (Collins, 2002) are only dependent on the feature vectors, and not on the source of the feature definitions, the perceptron algorithm is applicable to the training of our CWS model.
W02-1001
Feature numbers are from Table 1) 6.4 Closed test on the SIGHAN bakeoffs Four training and testing corpora were used in the first bakeoff (Sproat and Emerson, 2003), including the Academia Sinica Corpus (AS), the Penn Chinese Treebank Corpus (CTB), the Hong Kong City University Corpus (CU) and the Peking University Corpus (PU).
W03-1719
Wang et al.(2006) incorporates an N-gram language model in ME tagging, making use of word information to improve the character tagging model.
W06-0121
Liang (2005) uses the discriminative perceptron algorithm (Collins, 2002) to score whole character tag sequences, finding the best candidate by the global score.
I05-3023 W02-1001
Collins (2002) proposed the perceptron as an alternative to the CRF method for HMM-style taggers.
W02-1001
Denote the global feature vector for segmented sentence y with Φ(y) ∈ Rd, where d is the total number of features in the model; then Score(y) is computed by the dot product of vector Φ(y) and a parameter vector α ∈ Rd, where αi is the weight for the ith feature: Score(y) = Φ(y)·α 841 Inputs: training examples (xi,yi) Initialization: set α = 0 Algorithm: for t = 1..T, i = 1..N calculate zi = argmaxy∈GEN(xi) Φ(y)·α if zi negationslash= yi α = α + Φ(yi)−Φ(zi) Outputs: α Figure 1: the perceptron learning algorithm, adapted from Collins (2002) The perceptron training algorithm is used to determine the weight values α.
W02-1001
We follow the format from Peng et al.(2004). Each row represents a CWS model.
C04-1081
We chose the three models that achieved at least one best score in the closed tests from Emerson (2005), as well as the sub-word-based model of Zhang et al.(2006) for comparison.
I05-3017 N06-2049
The first eight rows represent models from Sproat and Emerson (2003) that participated in at least one closed test from the table, row “Peng” represents the CRF model from Peng et al.(2004), and the last row represents our model.
C04-1081 W03-1719
