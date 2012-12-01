Punyakanok et al.(2004)), information extraction (e.g.
C04-1197
Mooney and Bunescu (2005), Prager et al.(2000), White et al.(2001)). Researchers have further shown that opinion-oriented information extraction can provide analogous benefits to a variety of practical applications including product reputation tracking (Morinaga et al., 2002), opinion-oriented question answering (Stoyanov et al., 2005), and opinion-oriented summarization (e.g.
H01-1054 H05-1116
Linear Programming Approach As noted in the introduction, we model our task as global, constraint-based inference over the separately trained entity and relation classifiers, and implement the inference procedure as binary integer linear programming (ILP) ((Roth and Yih, 2004), (Punyakanok et al., 2004)).
C04-1197 W04-2401
Roth and Yih (2004)), and sequence tagging (e.g.
W04-2401
Our feature set is based on that of Choi et al.(2005) for source extraction5, but we include additional lexical and WordNetbased features.
H05-1045
Roth and Yih (2002) formulated global inference using a Bayesian network, where they captured the influence between a relation and a pair of entities via the conditional probability of a relation, given a pair of entities.
C02-1151
Inspired by Roth and Yih (2004), we model our task as global, constraint-based inference over separately trained entity and relation classifiers.
W04-2401
Roth and Yih (2004) later formulated global inference using integer linear programming, which is the approach that we apply here.
W04-2401
Choi et al.(2005) and Kim and Hovy (2005b)), to determine the polarity and strength of opinion expressions (e.g.
H05-1045 I05-2011
Wilson et al.(2005)), and to recognize propositional opinions and their sources (e.g.
H05-1044
Kim and Hovy (2005a), Munson et al.(2005) and Wilson et al.(2005)), omitting source identification altogether.
H05-1044 H05-1068 I05-2011
Sutton et al.(2004)). In this paper, we present a global inference approach (Roth and Yih, 2004) to the extraction of opinion-related entities and relations.
W04-2401
For source extraction in particular, our system achieves an F-measure of 78.1, significantly outperforming previous results in this area (Choi et al., 2005), which obtained an F-measure of 69.4 on the same corpus.
H05-1045
For details, see Choi et al.(2005). word: words in a [-4, +4] window centered on xi.
H05-1045
Punyakanok et al.(2004) notes that, in general, it is better to have high recall from the classifiers included in the ILP formulation.
C04-1197
Inspired by Roth and Yih (2004), we employ an integer linear programming approach to solve the joint opinion recognition task, and show that global, constraint-based inference can significantly boost the performance of both relation extraction and the extraction of opinion-related entities.
W04-2401
In contrast to our work, Roth and Yih (2004) operated in the domain of factual information extraction rather than opinion extraction, and assumed that the exact boundaries of entities from the gold standard are known a priori, which may not be available in practice.
W04-2401
Bunescu and Mooney (2004), Roth and Yih (2004)).
P04-1056 W04-2401
Kim and Hovy (2005b) and Choi et al.(2005) focus only on the extraction of sources of opinions, without extracting opinion expressions.
H05-1045 I05-2011
Specifically, Kim and Hovy (2005b) assume a priori existence of the opinion expressions and extract a single source for each, while Choi et al.(2005) do not explicitly extract opinion expressions nor link an opinion expression to a source even though their model implicitly learns approximations of opinion expressions in order to identify opinion sources.
H05-1045 I05-2011
