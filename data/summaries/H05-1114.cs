Latent semantic indexing (LSI) studied in (Sch¨utze, 1998) improves the performance of sense discrimination, while unsupervised feature selection also improves the performance of word sense discrimination (Niu et al., 2004).
P04-1080
Niu, Z.Y., Ji, D.H., & Tan, C.L.. 2004.
P04-1080
Niu, Z.Y., Ji, D.H., & Tan, C.L.. 2005.
P05-1049
label propagation algorithm) (Niu et al., 2005) to perform sense disambiguation on unlabeled instances of target word.
P05-1049
and Results 4.1 Experiment Design For empirical study of dimensionality reduction techniques on WSD task, we evaluated five dimensionality reduction algorithms on the data in English lexical sample (ELS) task of SENSEVAL-3 (Mihalcea et al., 2004)(including all the 57 English words ) 1: supervised feature clustering (SuFC) (Baker and McCallum, 1998; Bekkerman et al., 2003; Slonim 1Available at http://www.senseval.org/senseval3 909 and Tishby, 2001), iterative double clustering (IDC) (El-Yaniv and Souroujon, 2001), semi-supervised feature clustering (SemiFC) (our algorithm), supervised feature selection (SuFS) (Forman, 2003), and latent semantic indexing (LSI) (Deerwester et.
W04-0807 W04-2405
Many corpus based statistical methods have been proposed to solve this problem, including supervised learning algorithms (Leacock et al., 1998; Towel and Voorheest, 1998), weakly supervised learning algorithms (Dagan and Itai, 1994; Li and Li, 2004; Mihalcea, 2004; Niu et al., 2005; Park et al., 2000; Yarowsky, 1995), unsupervised learning algorithms (or word sense discrimination) (Pedersen and Bruce, 1997; Sch¨utze, 1998), and knowledge based algorithms (Lesk, 1986; McCarthy et al., 2004).
J04-1001 J94-4003 J98-1006 P00-1069 P04-1036 P05-1049 P95-1026 W04-0807 W04-2405 W97-0322
SVM) (Lee and Ng, 2002) or semi-supervised methods (ex.
W02-1006
For each ambiguous word in ELS task of SENSEVAL-3, we used three types of features to capture contextual information: part-of-speech of neighboring words with position information, unordered single words in topical context, and local collocations (as same as the feature set used in (Lee and Ng, 2002) except that we did not use syntactic relations).
W02-1006
Park, S.B., Zhang, B.T., & Kim, Y.T.. 2000.
P00-1069
For sense disambiguation on SENSEVAL-3 data, we constructed connected graphs for LP algorithm following (Niu et al., 2005): two instances u,v will be connected by an edge if u is among v’s k nearest neighbors, or if v is among u’s k nearest neighbors 4We used SVMlight with linear kernel function, available at http://svmlight.joachims.org/.
P05-1049
Supervised feature selection improves the performance of an examplar based learning algorithm over SENSEVAL2 data (Mihalcea, 2002), Naive Bayes and decision tree over SENSEVAL-1 and SENSEVAL-2 data (Lee and Ng, 2002), but feature selection does not improve SVM and Adaboost over SENSEVAL-1 and SENSEVAL-2 data (Lee and Ng, 2002) for word sense disambiguation.
C02-1039 W02-1006
