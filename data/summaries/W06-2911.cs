Features We adopt the feature design used by Lee and Ng (2002), which consists of the following four types: (1) Local context: D2-grams of nearby words (position sensitive); (2) Global context: all the words (excluding stopwords) in the given context (position-insensitive; a bag of words); (3) POS: parts-of-speech D2-grams of nearby words; (4) Syn79 tactic relations: syntactic information obtained from parser output.
W02-1006
FY02 (Florian and Yarowsky, 2002), WSC04 (Wu et al., 2004), LN02 (Lee and Ng, 2002) the unseen Senseval-3 test sets).
P04-1081 W02-1004 W02-1006
2http://www.cnts.ua.ac.be/conll2003/ner/ 77 on the WSD task with respect to WordNet synsets, Kohomban and Lee (2005) trained classifiers for the top-level synsets of the WordNet semantic hierarchy, consolidating labeled examples associated with the WordNet sub-trees.
P05-1005
Ando and Zhang (2005a) extend the above traditional linear model to a joint linear model so that a predictor for problem CO is in the form: CU CO B4A2BNDCB5 BP DB CC CO DCB7DA CC CO A2DC BN A2A2 CC BP C1BN (2) where C1 is the identity matrix.
P05-1001
Florian et al.(2003)). We explore several variations similarly to Section 3.1 and report the ceiling performance.
W03-0425
[G04] Grozea (2004); [SGG04] Strapparava et al.(2004). GGS05 combined various kernels, which includes the LSA kernel that exploits unlabeled data with global context features.
W04-0831 W04-0856
Figure 8: Ando and Zhang (2005a)’s ASO semi-supervised learning method using partially-supervised procedure for creating relevant auxiliary problems.
P05-1001
We conjecture that for this method to be effective, the problems are required to be more closely related to each other as in Florian et al.(2003)’s named entity experiments.
W03-0425
Implementation Our implementation follows Ando and Zhang (2005a).
P05-1001
This is a slight modification of the extension presented in (Ando and Zhang, 2005a).
P05-1001
Previous studies e.g., (Lee and Ng, 2002; Florian and Yarowsky, 2002), have applied supervised learning techniques to WSD with success.
W02-1004 W02-1006
Our single-task baseline performance is almost the same as LN02 (Lee and Ng, 2002), which uses SVM.
W02-1006
Based on these observations, we study a new application of Alternating Structure Optimization (ASO) (Ando and Zhang, 2005a; Ando and Zhang, 2005b) to WSD.
P05-1001
algorithm Analogous to (1), we compute A2 and predictors so that they minimize the empirical risk summed over all the problems: CJ CM A2BNCU CM CU CO CVCL BPCPD6CVD1CXD2 A2BNCUCU CO CV D1 CG COBPBD AW D2 CO CG CXBPBD C4B4CU CO B4A2BNCG CO CX B5BNCH CO CX B5 D2 CO B7 D6B4CU CO B5 AX BM (3) It has been shown in (Ando and Zhang, 2005a) that the optimization problem (3) has a simple solution using singular value decomposition (SVD) when we choose square regularization: D6B4CU CO B5 BP ALCZDB CO CZ BE BEwhere AL is a regularization parameter.
P05-1001
FY02 (Florian and Yarowsky, 2002) combines classifiers by linear average stacking.
W02-1004
While the LSA kernel is closely related to a special case of the semi-supervised application of ASO (see the discussion of PCA in Ando and Zhang (2005a)), our approach here is more general in that we exploit not only unlabeled data and global context features but also the labeled examples of other target words and other types of features.
P05-1001
We first create auxiliary problems following Ando and Zhang (2005a)’s partiallysupervised strategy (Figure 8) with distinct feature maps A9 BD and A9 BE each of which uses one of CUC4BVBNBZBVBNCBCACV.
P05-1001
