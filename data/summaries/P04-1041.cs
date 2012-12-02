Collins’ Model 3, (Johnson, 2002), (Hockenmaier, 2003) ), treebank-based probabilistic parsers return fairly simple “surfacey” CFG trees, without deep syntactic or semantic information.
P02-1018 P03-1046
(Hockenmaier, 2003) provides CCG-based models of LDDs.
P03-1046
We carried out a comprehensive evaluation of the automatically acquired verbal semantic forms against the COMLEX Resource (Macleod et al., 1994) for the 2992 active verb lemmas that both resources have in common.
H94-1003
Johnson. 2002.
P02-1018
Against the PARC 700, the hand-crafted LFG grammar reported in (Kaplan et al., 2004) achieves an fscore of 79.6%.
N04-1013
A subset of 560 dependency structures of the PARC 700 Dependency Bank following (Kaplan et al., 2004) The results are given in Table 7.
N04-1013
Unlike (Collins, 1999; Johnson, 2002), in our approach resolution of LDDs is done at f-structure (attribute-value structure representations of basic predicate-argument or dependency structure) without empty productions, traces and coindexation in CFG parse trees.
P02-1018
Abney. 1997.
J97-4005
The LFG approximations of (Cahill et al., 2002), however, are only “half” grammars, i.e. like most of their probabilistic CFG cousins (Charniak, 1996; Johnson, 1999; Klein and Manning, 2003) they do not resolve LDDs but interpret linguistic material purely locally where it occurs in the tree.
P03-1054
Evaluating against the PARC 700 Dependency Bank, the P-PCFG achieves an f-score of 80.24%, an overall improvement of approximately 0.6% on the result reported for the best hand-crafted grammars in (Kaplan et al., 2004).
N04-1013
In order to measure how many of the LDD reentrancies in the gold-standard f-structures are captured correctly by our parsers, we developed evaluation software for f-structure LDD reentrancies (similar to Johnson’s (2002) evaluation to capture traces and their antecedents in trees).
P02-1018
F-Score 78.28 82.70 81.49 83.28 DCU 105 F-Strs All GFs F-Score (before LDD resolution) 79.82 79.24 81.12 81.20 All GFs F-Score (after LDD resolution) 83.79 84.59 86.30 87.04 Preds only F-Score (before LDD resolution) 70.00 71.57 73.45 74.61 Preds only F-Score (after LDD resolution) 73.78 77.43 78.76 80.97 2416 F-Strs All GFs F-Score (before LDD resolution) 81.98 81.49 83.32 82.78 All GFs F-Score (after LDD resolution) 84.16 84.37 86.45 86.00 Preds only F-Score (before LDD resolution) 72.00 73.23 75.22 75.10 Preds only F-Score (after LDD resolution) 74.07 76.12 78.36 78.40 PARC 700 Dependency Bank Subset of GFs following (Kaplan et al., 2004) 77.86 80.24 77.68 78.60 Table 7: Parser Evaluation 3.
N04-1013
Currently our best automatically induced grammars achieve 80.97% f-score for fstructures parsing section 23 of the WSJ part of the Penn-II treebank and evaluating against the DCU 1051 and 80.24% against the PARC 700 Dependency Bank (King et al., 2003), performing at the same or a slightly better level than state-of-the-art hand-crafted grammars (Kaplan et al., 2004).
N04-1013
Johnson’s (2002) work is closest to ours in spirit.
P02-1018
Unlike (Collins, 1999; Johnson, 2002), in our approach LDDs are resolved on the level of f-structure representation, rather than in terms of empty productions and coindexation on parse trees.
P02-1018
It is well known (Abney, 1997) that PCFG-type approximations to unification grammars can yield inconsistent probability models due to loss of probability mass: the parser successfully returns the highest ranked parse tree but the constraint solver cannot resolve the f-equations (generated in the pipeline or “hidden” in the integrated model) and the probability mass associated with that tree is lost.
J97-4005
We achieve between 77.68% and 80.24% against the PARC 700 following the experiments in (Kaplan et al., 2004).
N04-1013
(Johnson, 2002) All GFs 80.86 86.65 85.16 Preds Only 74.63 80.97 79.75 Table 10: Comparison at f-structure level of LDD resolution to (Johnson, 2002) on the DCU 105 parser (Charniak, 1999) and, using the pipeline f-structure annotation model, evaluate against the DCU 105, both before and after LDD resolution.
P02-1018
Using the software described in (Johnson, 2002) we add empty nodes to the output of Charniak’s parser, pass these trees to our automatic annotation algorithm and evaluate against the DCU 105.
P02-1018
Few hand-crafted, deep unification grammars have in fact achieved the coverage and robustness required to parse a corpus of say the size and complexity of the Penn treebank: (Riezler et al., 2002) show how a deep, carefully hand-crafted LFG is successfully scaled to parse the Penn-II treebank (Marcus et al., 1994) with discriminative (loglinear) parameter estimation techniques.
H94-1020 P02-1035
Resolution of such long-distance dependencies (LDDs) is therefore crucial in the determination of accurate predicate-argument struc1Manually constructed f-structures for 105 randomly selected trees from Section 23 of the WSJ section of the Penn-II Treebank ture, deep dependency relations and the construction of proper meaning representations such as logical forms (Johnson, 2002).
P02-1018
C-structure captures surface grammatical configurations, fstructure encodes abstract syntactic information approximating to predicate-argument/dependency structure or simple logical form (van Genabith and Crouch, 1996).
C96-1045
ferred to as “half” (or “shallow”) grammars (Johnson, 2002), i.e. they do not resolve LDDs but interpret linguistic material purely locally where it occurs in the tree.
P02-1018
It seems that the f-structure-based approach is more abstract (99 LDD path types against approximately 9,000 tree-fragment types in (Johnson, 2002)) and fine-grained in its use of lexical information (subcat frames).
P02-1018
(Riezler et al., 2002; Kaplan et al., 2004) describe how a carefully hand-crafted LFG is scaled to the full Penn-II treebank with log-linear based probability models.
N04-1013 P02-1035
Using (Johnson, 2002)’s method of adding empty nodes to the parse-trees results in an f-score of 79.75%.
P02-1018
Following (Riezler et al., 2002), we convert f-structures into dependency triple format.
P02-1035
The full 2,416 f-structures automatically generated by the f-structure annotation algorithm for the original Penn-II trees, in a CCG-style (Hockenmaier, 2003) evaluation experiment Pipeline Integrated PCFG P-PCFG A-PCFG PA-PCFG 2416 Section 23 trees # Parses 2416 2416 2416 2414 Lab.
P03-1046
Treebanks have been enormously influential in the development of robust, state-of-the-art parsing technology: grammars (or grammatical information) automatically extracted from treebank resources provide the backbone of many state-of-the-art probabilistic parsing approaches (Charniak, 1996; Collins, 1999; Charniak, 1999; Hockenmaier, 2003; Klein and Manning, 2003).
P03-1046 P03-1054
