This statistical technique of labeling predicate argument operates on the output of the probabilistic parser reported in (Collins, 1997).
P97-1003
Model In previous work using the PropBank corpus, (Gildea and Palmer, 2002) proposed a model predicting argument roles using the same statistical method as the one employed by (Gildea and Jurafsky, 2002) for predicting semantic roles based on the FrameNet corpus (Baker et al., 1998).
J02-3001 P02-1031 P98-1013
Our model considers two sets of features: Feature Set 1 (FS1): features used in the work reported in (Gildea and Palmer, 2002) and (Gildea and Jurafsky, 2002) ; and Feature Set 2 (FS2): a novel set of features introduced in this paper.
J02-3001 P02-1031
Roman Yangarber, Ralph Grishman, Pasi Tapainen and Silja Huttunen, 2000.
C00-2136
Because predicate lexical information is used for less than 5% of the branching decisions, the generated classifier scales better than the statistical method from (Gildea and Palmer, 2002) to unknown predicates.
J02-3001 P02-1031
To achieve high accuracy and resolve the data sparsity problem the method reported in (Gildea and Palmer, 2002; Gildea and Jurafsky, 2002) employed a backoff solution based on a lattice that combines the model features.
J02-3001 P02-1031
The full parser first performs part-of-speech (POS) tagging using transformation based learning (TBL) (Brill, 1995).
J95-4004
Section 2 reports on the parser that produces predicate-argument labels and compares it against the parser introduced in (Gildea and Palmer, 2002).
J02-3001 P02-1031
Features Arg P Arg R Arg a3a5a4 Role A FS1 84.96 84.26 84.61 78.76 FS1 + hPos 92.24 84.50 88.20 79.04 FS1 + cw, cPos 92.19 84.67 88.27 80.80 FS1 + cNE 83.93 85.69 84.80 79.85 FS1 + NE flags 87.78 85.71 86.73 81.28 FS1 + pvcSum + 84.88 82.77 83.81 78.62 pvcMax FS1 + FS2 91.62 85.06 88.22 83.05 Table 1: Inductive learning results for argument identification and role assignment Model Implementation Arg a3a5a4 Role A Statistical (Gildea and Palmer) 82.8 This study 71.86 78.87 Decision Trees FS1 84.61 78.76 FS1 + FS2 88.98 83.74 Table 2: Comparison of statistical and decision tree learning models of the decision-tree-based method against the results obtained by the statistical approach reported in (Gildea and Palmer, 2002).
J02-3001 P02-1031
Some of the most recent methods were reported in (Riloff, 1996; Yangarber et al., 2000).
C00-2136
One such augmented parser, trained on data available from the PropBank project has been recently presented in (Gildea and Palmer, 2002).
J02-3001 P02-1031
At last, the dependency parser presented in (Collins, 1997) is used to generate the full parse.
P97-1003
For example, the backoff lattice in (Gildea and Palmer, 2002) consists of eight connected nodes for a five-feature set.
J02-3001 P02-1031
Then non-recursive, or basic, noun phrases (NPB) are identified using the TBL method reported in (Ngai and Florian, 2001).
N01-1006
(Gildea and Palmer, 2002) report the results listed on the first line of Table 2.
J02-3001 P02-1031
The statistical model introduced in Gildea and Jurafsky (2002) uses predicate lexical information at most levels in the probability lattice, hence its scalability to unknown predicates is limited.
J02-3001 P02-1031
In this paper we describe a domain-independent IE paradigm that is based on predicate-argument structures identified automatically by two different methods: (1) the statistical method reported in (Gildea and Palmer, 2002); and (2) a new method based on inductive learning which obtains 17% higher Fscore over the first method when tested on the same data.
J02-3001 P02-1031
