3 Memory-Based Dependency Parsing In the experiments below, we employ a data-driven deterministic dependency parser producing labeled projective dependency graphs,3 previously tested on Swedish (Nivre et al., 2004) and English (Nivre and Scholz, 2004).
C04-1010 W04-2407
Prague Dependency Treebank (Hajiˇc et al., 2001b), Danish Dependency Treebank (Kromann, 2003), and the METU Treebank of Turkish (Oflazer et al., 2003), which generally allow annotations with nonprojective dependency structures.
J03-4001
Unlike Kahane et al.(1998), we do not regard a projectivized representation as the final target of the parsing process.
P98-1106
Finally, since non-projective constructions often involve long-distance dependencies, the problem is closely related to the recovery of empty categories and non-local dependencies in constituency-based parsing (Johnson, 2002; Dienes and Dubey, 2003; Jijkoun and de Rijke, 2004; Cahill et al., 2004; Levy and Manning, 2004; Campbell, 2004).
P02-1018 P03-1055 P04-1040 P04-1041 P04-1042 P04-1082
The dependency graph in Figure 1 satisfies all the defining conditions above, but it fails to satisfy the condition of projectivity (Kahane et al., 1998): 1.
P98-1106
It is also true of the adaptation of the Collins parser for Czech (Collins et al., 1999) and the finite-state dependency parser for Turkish by Oflazer (2003).
J03-4001 P99-1065
In addition, there are several approaches to non-projective dependency parsing that are still to be evaluated in the large (Covington, 1990; Kahane et al., 1998; Duchier and Debusmann, 2001; Holan et al., 2001; Hellwig, 2003).
J90-4003 P01-1024 P98-1106
Using the terminology of Kahane et al.(1998), we say that jedna is the syntactic head of Z, while je is its linear head in the projectivized representation.
P98-1106
More details on the memory-based prediction can be found in Nivre et al.(2004) and Nivre and Scholz (2004).
C04-1010 W04-2407
Although the best published results for the Collins parser is 80% UAS (Collins, 1999), this parser reaches 82% when trained on the entire training data set, and an adapted version of Charniak’s parser (Charniak, 2000) performs at 84% (Jan Hajiˇc, pers.
A00-2018 P99-1065
This is true of the widely used link grammar parser for English (Sleator and Temperley, 1993), which uses a dependency grammar of sorts, the probabilistic dependency parser of Eisner (1996), and more recently proposed deterministic dependency parsers (Yamada and Matsumoto, 2003; Nivre et al., 2004).
C04-1010 C96-1058 W04-2407
It is sometimes claimed that one of the advantages of dependency grammar over approaches based on constituency is that it allows a more adequate treatment of languages with variable word order, where discontinuous syntactic constructions are more common than in languages like English (Mel’ˇcuk, 1988; Covington, 1990).
J90-4003
First, the training data for the parser is projectivized by applying a minimal number of lifting operations (Kahane et al., 1998) and encoding information about these lifts in arc labels.
P98-1106
Compared to related work on the recovery of long-distance dependencies in constituency-based parsing, our approach is similar to that of Dienes and Dubey (2003) in that the processing of non-local dependencies is partly integrated in the parsing process, via an extension of the set of syntactic categories, whereas most other approaches rely on postprocessing only.
P03-1055
.) a7 a4 a63 AuxZ Figure 1: Dependency graph for Czech sentence from the Prague Dependency Treebank1 There exist a few robust broad-coverage parsers that produce non-projective dependency structures, notably Tapanainen and J¨arvinen (1997) and Wang and Harper (2004) for English, Foth et al.(2004) for German, and Holan (2004) for Czech.
W04-0307
We call this pseudoprojective dependency parsing, since it is based on a notion of pseudo-projectivity (Kahane et al., 1998).
P98-1106
As observed by Kahane et al.(1998), any (nonprojective) dependency graph can be transformed into a projective one by a lifting operation, which replaces each non-projective arc wj →wk by a projective arc wi → wk such that wi →∗ wj holds in the original graph.
P98-1106
