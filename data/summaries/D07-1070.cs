667 Givenann-wordinput sentence, theparser begins by scoring each of the O(n2) possible edges, and then seeks the highest-scoring legal dependency tree formed by any n−1 of these edges, using an O(n3) dynamic programming algorithm (Eisner, 1996) for projective trees.
C96-1058
For this paper, we performed some initial bootstrapping experiments on small corpora, using the featuresfrom(McDonaldetal., 2005).
P05-1012
A similar soft projection of dependencies was used in supervised machine translation by Smith and Eisner (2006), who used a source sentence’s dependency paths to bias the generation of its translation.
W06-3104
Previous work on parser bootstrapping has not been able to exploit this redundancy among features, becauseithasusedPCFG-likemodelswithfarfewer features (Steedman et al., 2003).
E03-1008
Conventional bootstrapping retrains on the most confident unsupervised examples, making them 4This function is not necessarily convex in θ, because of the additionoftheentropyterm(Jiaoetal., 2006).
P06-1027
80.0 80.5 76.7 Table 4: Dependency accuracy of the DMV model (Klein and Manning, 2004).
P04-1061
Design We bootstrapped non-projective parsers for languages assembled for the CoNLL dependency parsing competitions (Buchholz and Marsi, 2006).
W06-2920
Since we cannot try EM on McDonald’s conditional model, we ran some pilot experiments using the generative dependency model with valence (DMV) of Klein and Manning (2004).
P04-1061
However, another approach is to train a separate out-of-domain parser, and use this to generate additional features on the supervised and unsupervised in-domain data (Blitzer et al., 2006).
W06-1615
Smith. 2007.
D07-1014
Drawing on Abney’s (2004) analysis of the Yarowsky algorithm, we perform bootstrapping by entropy regularization: we maximize a linear combination of conditional likelihood on labeled data and confidence (negative R´enyi entropy) on unlabeled data.
J04-3004
Our observation is that this situation is ideal for so-called “bootstrapping,” “co-training,” or “minimally supervised” learning methods (Yarowsky, 1995; Blum and Mitchell, 1998; Yarowsky and Wicentowski, 2000).
P00-1027 P95-1026
Although we see statistically significant improvements (at the .05 level on a paired permutation test), the quality of the parsers is still quite poor, in contrast to other applications of bootstrapping which “rival supervised methods” (Yarowsky, 1995).
P95-1026
is in fact the Shannon entropy H(p) and that limα→∞Rα(p) = −logmaxy p(y), i.e. the negative log probability of the modal or “Viterbi” label (Arndt, 2001; Karakos et al., 2007).
N07-1032
2.1 Feature-Based Parsing McDonald et al.(2005) introduced a simple, flexible framework for scoring dependency parses.
P05-1012
We thus introduce a multiplier γ to form the actual objective function that we minimize with respect to θ:4 −summationdisplay i∈L logpθ,i(y∗i ) + γ Nsummationdisplay inegationslash∈L H(pθ,i) (4) One may regard γ as a Lagrange multiplier that is used to constrain the classifier’s uncertainty H to be low, as presented in the work on entropy regularization (Brand, 1999; Grandvalet and Bengio, 2005; Jiao et al., 2006).
P06-1027
Dependency parsing is important as a key component in leading systems for information extraction (Weischedel, 2004)1 and question answering (Peng et al., 2005).
H05-1039
Since the lexical translations and dependency paths are typically not labeled in the English corpus, a given pair must be counted fractionally according to its posterior probability of satisfying these conditions, given models of contextual translation and English parsing.3 3Similarly, Jansche (2005) imputes “missing” trees by using comparable corpora.
W05-1508
Results We performed bootstrapping experiments on the full CoNLL sets for Czech, German, and Spanish using the non-projective model from McDonald et al.(2005). Performance confirms the results of our analysis above (Table 2).
P05-1012
We use the MSTParser implementation described in McDonald et al.(2005) for feature extraction.
P05-1012
Parsing is also key to the latest advances in machine translation, which translate syntactic phrases (Galley et al., 2006; Marcu et al., 2006; Cowan et al., 2006).
P06-1121 W06-1606 W06-1628
Merialdo (1994) saw a similar degradation over small (and large) seed sets in HMM POS tagging.
J94-2001
We argue that bootstrapping a parser is most promising when the model uses a rich set of redundant features, as in recent models for scoring dependency parses (McDonald et al., 2005).
P05-1012
In his analysis of Yarowsky (1995), Abney (2004) formulates several variants of bootstrapping.
J04-3004 P95-1026
We now present a generalization of Abney’s K function and relate it to another semi-supervised learning technique, entropy regularization (Brand, 1999; Grandvalet and Bengio, 2005; Jiao et al., 2006).
P06-1027
6See also (Mann and McCallum, 2007) for similar results on conditional random fields.
N07-2028
For nonprojective parsing, the analogy to the inside algorithm is the O(n3) “matrix-tree algorithm,” which is dominated asymptotically by a matrix determinant (Smith and Smith, 2007; Koo et al., 2007; McDonald and Satta, 2007).
D07-1014 D07-1015 W07-2216
In fact, McClosky et al.(2006) found a similar technique to be effective—though only in a model with a large feature space (“PCFG + reranking”), as we would predict.
P06-1043
Translation dictionaries can themselves be induced from comparable corpora (Schafer and Yarowsky, 2002; Schafer, 2006; Klementiev and Roth, 2006), or extracted from bitext or digitized versions of human-readable dictionaries if these are available.
P06-1103 W02-2026
But the denominator Zi is a normalizing constant that sums over all parses; it is found by a dependency-parsing variant of the inside algorithm, following (Eisner, 1996).
C96-1058
Computing this for projective parsing takes O(n3) time, using a dynamic programming algorithm that is closely related to the inside algorithm (Hwa, 2000).6 For nonprojective parsing, unfortunately, the runtime rises to O(n4), since it requires determinants of n distinct matrices (each incorporating a log factor in a different column; we omit the details).
W00-1306
In supervised dependency parsing, secondorder edge features provide improvements (McDonald and Pereira, 2006; Riedel and Clarke, 2006); moreover, the feature-based approach is not limited to dependency parsing.
E06-1011 W06-1616
Of course, features may consider the parent and child words connected by e, and their parts of speech.2 But some features used by McDonald et al.(2005) also consider the parts of speech of words adjacent to the parent and child, or between the parent and child, as well as the number of words between the parent and child.
P05-1012
