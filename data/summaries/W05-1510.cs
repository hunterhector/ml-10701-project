These results are different from those in parsing reported by Miyao and Tsujii (2005) where COMMA and SPAN especially contributed to the accuracy.
P05-1011
The atomic features and their combinations are imported from the previous work on HPSG parsing (Miyao and Tsujii, 2005).
P05-1011
We evaluated the generator on the Penn Treebank (Marcus et al., 1993), which is highly reliable corpus consisting of real-world texts.
J93-2004
The same problems also arise with HPSG parsing, and recent studies (Tsuruoka et al., 2004; Miyao and Tsujii, 2005; Ninomiya et al., 2005) proposed a number of solutions including the methods of estimating loglinear models using packed forests of parse trees and pruning improbable candidates during parsing.
P05-1011 W05-1511
We followed two partial solutions to this problem by Kay (1996).
P96-1027
Comparing the latter half of the experimental results with those on parsing (Miyao and Tsujii, 2005), we investigated similarities and differences between probabilistic models for parsing and generation.
P05-1011
Similar results are reported in parsing (Miyao and Tsujii, 2005) while the accuracy saturated around 16,000 sentences.
P05-1011
Miyao and Tsujii (2005) represented a set of HPSG parse 96 Figure 3: Feature forest for “He bought the book.” trees using a feature forest and succeeded in estimating a1 a5a1a0 a4a2 a9 given a sentence a2 and a parse tree a0 using dynamic programming without unpacking the chart.
P05-1011
The Fergus system (Bangalore and Rambow, 2000) uses LTAG (Lexicalized Tree Adjoining Grammar (Schabes et al., 1988)) for generating a word lattice containing realizations and selects the best one using a trigram model.
C00-1007 C88-2121
The forest representation was obtained by adopting chart generation (Kay, 1996; Car93 roll et al., 1999) where ambiguous candidates are packed into an equivalence class and mapping a chart into a forest in the same way as parsing.
P96-1027
As well as features used in their previous work on statistical parsing (Toutanova and Manning, 2002), an additional feature that represents sentence probabilities of 4-gram model is incorporated.
W02-2030
models for generation with HPSG Some existing studies on probabilistic models for HPSG parsing (Malouf and van Noord, 2004; Miyao and Tsujii, 2005) adopted log-linear models (Berger et al., 1996).
J96-1002 P05-1011
Baseline model We started with a simple baseline model, a1 a5a1a0 a4 a44 a9 a38a8a7 a18 a22a31a27 a1 a5a43a41 a4 a0 a9, where a0a10a9 a44 is a PAS in the input semantic representation a44 and a41 is a lexical entry assigned to a0 . The FOM of the mother edge a11 a5a8a7a6a3a21a9 is computed simply as a11 a5a8a7a12a3a21a9 a38 a11 a5a8a7a6a5a9a14a13 a11 a5a8a7 a18 a9 . All the other models use this model as a reference distribution (Miyao and Tsujii, 2005), i.e., a13 a11 is estimated to maximize the likelihood of the training data a15a1, which is calculated with the following equation.
P05-1011
