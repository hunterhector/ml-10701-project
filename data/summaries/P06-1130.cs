The generation architecture presented here builds on the integrated parsing architecture resources of Cahill et al.(2004). The generation process takes an f-structure (such as the f-structure on the right in Figure 1) as input and outputs the most likely f-structure annotated tree (such as the tree on the left in Figure 1) given the input fstructure argmaxTreeP(Tree|F-Str) where the probability of a tree given an fstructure is decomposed as the product of the probabilities of all f-structure annotated productions contributing to the tree but where in addition to conditioning on the LHS of the production (as in the integrated parsing architecture of Cahill et al.(2004)) each production X → Y is now also conditioned on the set of f-structure features Feats φ-linked2 to the LHS of the rule.
P04-1041
We only evaluate strings produced by the system (similar to Nakanishi et al.(2005)). We conduct a total of four experiments.
W05-1510
c©2006 Association for Computational Linguistics Robust PCFG-Based Generation using Automatically Acquired LFG Approximations Aoife Cahill1 and Josef van Genabith1,2 1 National Centre for Language Technology (NCLT) School of Computing, Dublin City University, Dublin 9, Ireland 2 Center for Advanced Studies, IBM Dublin, Ireland {acahill,josef}@computing.dcu.ie Abstract We present a novel PCFG-based architecture for robust probabilistic generation based on wide-coverage LFG approximations (Cahill et al., 2004) automatically extracted from treebanks, maximising the probability of a tree given an f-structure.
P04-1041
In this paper we present a novel PCFG-based architecture for probabilistic generation based on wide-coverage, robust Lexical Functional Grammar (LFG) approximations automatically extracted from treebanks (Cahill et al., 2004).
P04-1041
Nakanishi et al.(2005) present probabilistic models for a chart generator using a HPSG grammar acquired from the Penn-II Treebank (the Enju HPSG).
W05-1510
Simple PCFGbased models, while effective and computationally efficient, can only provide approximations to LFG and similar constraint-based formalisms (Abney, 1997).
J97-4005
Belz (2005) describes a method for building statistical generation models using an automatically created generation treebank for weather forecasts.
W05-1601
This conditioning effectively turns the f-structure annotated PCFGs of Cahill et al.(2004) into probabilistic generation grammars.
P04-1041
Our backoff uses the built-in lexical macros4 of the automatic fstructure annotation algorithm of Cahill et al.(2004) to identify potential part-of-speech categories corresponding to a particular set of features.
P04-1041
1034 Conditioning F-Structure Features Grammar Rules Probability {PRED, SUBJ, COMP, TENSE} VP(↑=↓) → VBD(↑=↓) SBAR(↑COMP=↓) 0.4998 {PRED, SUBJ, COMP, TENSE} VP(↑=↓) → VBP(↑=↓) SBAR(↑COMP=↓) 0.0366 {PRED, SUBJ, COMP, TENSE} VP(↑=↓) → VBD(↑=↓), S(↑COMP=↓) 6.48e-6 {PRED, SUBJ, COMP, TENSE} VP(↑=↓) → VBD(↑=↓) S(↑COMP=↓) 3.88e-6 {PRED, SUBJ, COMP, TENSE} VP(↑=↓) → VBP(↑=↓), SBARQ(↑COMP=↓) 7.86e-7 {PRED, SUBJ, COMP, TENSE} VP(↑=↓) → VBD(↑=↓) SBARQ(↑COMP=↓) 1.59e-7 Table 1: Example VP Generation rules automatically extracted from Sections 02–21 of the Penn-II Treebank P(Tree|F-Str) := productdisplay X → Y in Tree φ(X) = Feats P(X → Y |X,Feats) (1) P(X → Y |X,Feats) = P(X → Y,X,Feats)P(X,Feats) = (2) P(X → Y,Feats) P(X,Feats) ≈ #(X → Y,Feats) #(X →...,Feats) (3) and where probabilities are estimated using a simple MLE and rule counts (#) from the automatically f-structure annotated treebank resource of Cahill et al.(2004). Lexical rules (rules expanding preterminals) are conditioned on the full set of (atomic) feature-value pairs φ-linked to the RHS.
P04-1041
Nakanishi et al.(2005) achieve 90.56% coverage and a BLEU score of 0.7723 on Section 23 1038 Sentence length of Evaluation Section 23 Sentences of length: Training Data Metric ≤ 20 ≤ 25 ≤ 30 ≤ 40 all ≤ 20 BLEU 0.7326 0.7185 0.7165 0.7082 0.7052 String Accuracy 0.76 0.7428 0.7363 0.722 0.7175 Coverage 85.49 81.56 77.26 71.94 69.08 ≤ 25 BLEU 0.7300 0.7235 0.7218 0.7118 0.7077 String Accuracy 0.7517 0.7382 0.7315 0.7172 0.7116 Coverage 89.65 87.77 84.38 80.31 78.56 ≤ 30 BLEU 0.7207 0.7125 0.7107 0.6991 0.6946 String Accuracy 0.747 0.7336 0.7275 0.711 0.7045 Coverage 93.23 92.14 89.74 86.59 85.18 ≤ 40 BLEU 0.7221 0.7140 0.7106 0.7016 0.6976 String Accuracy 0.746 0.7331 0.7236 0.7072 0.7001 Coverage 94.58 93.85 91.89 89.62 88.33 all BLEU 0.7227 0.7145 0.7095 0.7011 0.6979 String Accuracy 0.7476 0.7331 0.7239 0.7077 0.7012 Coverage 95.26 94.40 92.55 90.69 89.49 Table 5: Generation -partial output +lexical smoothing Sentence length of Evaluation Section 23 Sentences of length: Training Data Metric ≤ 20 ≤ 25 ≤ 30 ≤ 40 all all BLEU 0.7272 0.7237 0.7201 0.7160 0.7147 String Accuracy 0.7547 0.7436 0.7361 0.7237 0.7192 Coverage 61.99 57.38 53.64 47.60 47.60 Table 6: Generation -partial output -lexical smoothing sentences, restricted to length ≤20 for efficiency reasons.
W05-1510
Ratnaparkhi (2000) uses maximum entropy models to drive generation with word bigram or dependency representations taking into account (unrealised) semantic features.
A00-2026
In each case, we use the automatically generated f-structures from Cahill et al.(2004) from the original Section 23 treebank trees as f-structure input to our generation experiments.
P04-1041
Research on discriminative disambiguation methods (Valldal and Oepen, 2005; Nakanishi et al., 2005) is important.
W05-1510
This results in efficiently treating the well known problem originally described in Kay (1996), where one unnecessarily retains sub-optimal strings.
P96-1027
Following Baayen and Sproat (1996) we assume that unknown words have a probability distribution similar to hapax legomena.
J96-2001
and Further Work We present a new architecture for stochastic LFG surface realisation using the automatically annotated treebanks and extracted PCFG-based LFG approximations of Cahill et al.(2004). Our model maximises the probability of a tree given an fstructure, supporting a simple and efficient implementation that scales to wide-coverage treebankbased resources.
P04-1041
Cahill et al.(2004) present two parsing architectures: the pipeline and the integrated parsing architecture.
P04-1041
Kaplan and Wedekind (2000) show that for certain linguistically interesting classes of LFG (and PATR etc).
C00-1062
4.2 String-Based Evaluation We evaluate the output of our generation system against the raw strings of Section 23 using the Simple String Accuracy and BLEU (Papineni et al., 2002) evaluation metrics.
P02-1040
Generation Algorithm The generation algorithm is based on chart generation as first introduced by Kay (1996) with Viterbi-pruning.
P96-1027
3 PCFG-Based Generation for Treebank-Based LFG Resources Cahill et al.(2004) present a method to automatically acquire wide-coverage robust probabilistic LFG approximations1 from treebanks.
P04-1041
Bangalore and Rambow (2000) use n-gram word sequence statistics in a TAG-based generation model to rank output strings and additional statistical and symbolic resources at intermediate generation stages.
C00-1007
Bangalore et al.(2001) investigate the effect of training size on performance while using grammars automatically extracted from the PennII Treebank (Marcus et al., 1994) for generation.
H94-1020 W01-0520
In the in1The resources are approximations in that (i) they do not enforce LFG completeness and coherence constraints and (ii) PCFG-based models can only approximate LFG and similar constraint-based formalisms (Abney, 1997).
J97-4005
