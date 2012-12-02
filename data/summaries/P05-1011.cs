Other discriminative classifiers were applied to the disambiguation in HPSG parsing (Baldridge and Osborne, 2003; Toutanova et al., 2004).
W03-0403 W04-3222
This method was shown to be a generalization of the reference distribution method (Johnson and Riezler, 2000).
A00-2021
Our representation of the chart can be interpreted as an instance of a feature forest (Miyao and Tsujii, 2002; Geman and Johnson, 2002).
P02-1036
length LP LR UP UR F-score Section 22 (BO 40 words) 20.69 87.18 86.23 90.67 89.68 86.70 Section 22 (BO 100 words) 22.43 86.99 84.32 90.45 87.67 85.63 Section 23 (BO 40 words) 20.52 87.12 85.45 90.65 88.91 86.27 Section 23 (BO 100 words) 22.23 86.81 84.64 90.29 88.03 85.71 Table 3: Accuracy for development/test sets 6 Experiments We used an HPSG grammar derived from Penn Treebank (Marcus et al., 1994) Section 02-21 (39,832 sentences) by our method of grammar development (Miyao et al., 2004).
H94-1020
Another approach to estimating log-linear models for HPSG is to extract a small informative sample from the original set CCB4D7B5 (Osborne, 2000).
C00-1085
However, despite the development of methods to improve HPSG parsing efficiency (Oepen et al., 2002a), the exhaustive parsing of all sentences in a treebank is still expensive.
C02-2025
models for HPSG Discriminative log-linear models are now becoming a de facto standard for probabilistic disambiguation models for deep parsing (Johnson et al., 1999; Riezler et al., 2002; Geman and Johnson, 2002; Miyao and Tsujii, 2002; Clark and Curran, 2004b; Kaplan et al., 2004).
C04-1041 N04-1013 P02-1035 P02-1036 P04-1014 P99-1069
Different from the results of CCG and PCFG (Collins, 1999; Charniak, 2000), the recall was clearly lower than precision.
A00-2018
Model parameters that maximize the loglikelihood of the training data are computed using a numerical optimization method (Malouf, 2002).
W02-2018
and related work Experiments on deep parsing of Penn Treebank have been reported for Combinatory Categorial Grammar (CCG) (Clark and Curran, 2004b) and Lexical Functional Grammar (LFG) (Kaplan et al., 2004).
C04-1041 N04-1013 P04-1014
Such constraints are known 83 to introduce inconsistencies in probabilistic models estimated using simple relative frequency (Abney, 1997).
J97-4005
However, despite research on HPSG processing efficiency (Oepen et al., 2002a), the application of HPSG parsing is still limited to specific domains and short sentences (Oepen et al., 2002b; Toutanova and Manning, 2002).
C02-2025 W02-2030
Clark and Curran (2004a) described a method of reducing the cost of parsing a training treebank in the context of CCG parsing.
C04-1041 P04-1014
An approach similar to ours may be applied to them, following the study on the learning of a discriminative classifier for a packed representation (Taskar et al., 2004).
W04-3201
Previous studies on probabilistic models for HPSG (Toutanova and Manning, 2002; Baldridge and Osborne, 2003; Malouf and van Noord, 2004) also adopted log-linear models.
W02-2030 W03-0403 W04-3222
The aim of this paper is to report the development of log-linear models for the disambiguation in widecoverage HPSG parsing, and their empirical evaluation through the parsing of the Wall Street Journal of Penn Treebank II (Marcus et al., 1994).
H94-1020
Our results cannot be strictly compared with other grammar formalisms because each formalism represents predicate-argument dependencies differently; for reference, our results are competitive with the corresponding measures reported for Combinatory Categorial Grammar (CCG) (LP/LR = 86.6/86.3) (Clark and Curran, 2004b).
C04-1041 P04-1014
A possible direction is to encode larger contexts of parse trees, which were shown to improve the accuracy (Toutanova and Manning, 2002; Toutanova et al., 2004).
W02-2030 W04-3222
