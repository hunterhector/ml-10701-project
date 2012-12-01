Rec. F (Cahill et al., 2004) overall 95.98 57.86 72.20 73.00 40.28 51.91 90.16 54.35 67.82 65.54 36.16 46.61 args only 98.64 42.03 58.94 82.69 30.54 44.60 86.36 36.80 51.61 66.08 24.40 35.64 Basic Model overall 92.44 91.28 91.85 63.87 62.15 63.00 63.12 62.33 62.72 42.69 41.54 42.10 args only 89.42 92.95 91.15 60.89 63.45 62.15 47.92 49.81 48.84 31.41 32.73 32.06 Basic Model with Subject Path Constraint overall 92.16 91.36 91.76 63.72 62.20 62.95 75.96 75.30 75.63 50.82 49.61 50.21 args only 89.04 93.08 91.02 60.69 63.52 62.07 66.15 69.15 67.62 42.77 44.76 44.76 Table 7: Evaluation of trace insertion and antecedent recovery for C04 algorithm, our basic algorithm and basic algorithm with the subject path constraint.
P04-1041
We also combine our basic algorithm (Section 4.2) with (Cahill et al., 2004)’s algorithm in order to resolve the modifier-function traces.
P04-1041
A common characteristic of all these approaches 1(Jijkoun, 2003; Jijkoun and Rijke, 2004) also describe postprocessing methods to recover NLDs, which are applied to syntactic dependency structures converted from CFG-trees.
P03-2006 P04-1040
However, with few exceptions (Model 3 of Collins, 1999; Schmid, 2006), output trees produced by state-of-the-art broad coverage statistical parsers (Charniak, 2000; Bikel, 2004) are only surface context-free phrase structure trees (CFG-trees) without empty categories and coindexation to represent displaced constituents.
A00-2018 P06-1023
In addition to CFG-oriented approaches, a number of richer treebank-based grammar acquisition and parsing methods based on HPSG (Miyao et al., 2003), CCG (Clark and Hockenmaier, 2002), LFG (Riezler et al., 2002; Cahill et al., 2004) and Dependency Grammar (Nivre and Nilsson, 2005) incorporate non-local dependencies into their deep syntactic or semantic representations.
P02-1035 P02-1042 P04-1041 P05-1013
Three strategies have been proposed: (i) post-processing parser output with pattern matchers (Johnson, 2002), linguistic principles (Campbell, 2004) or machine learning methods (Higgins, 2003; Levy and Manning, 2004; Gabbard et al., 2006) to recover empty nodes and identify their antecedents;1 (ii) integrating non-local dependency recovery into the parser by enriching a simple PCFG model with GPSG-style gap features (Collins, 1999; Schmid, 2006); (iii) pre-processing the input sentence with a finite-state trace tagger which detects empty nodes before parsing, and identify the antecedents on the parser output with the gap information (Dienes and Dubey, 2003a; Dienes and Dubey, 2003b).
E03-1049 N06-1024 P02-1018 P03-1055 P04-1042 P04-1082 P06-1023 W03-1005
Inspired by (Cahill et al., 2004; Burke et al., 2004), we have implemented an f-structure annotation algorithm to automatically obtain f-structures from CFG-trees in the CTB5.1.
P04-1041
The evaluation metric adopted by most previous work used the label and string position of the trace and its antecedent (Johnson, 2002).
P02-1018
This is in contrast to English data, on which (Johnson, 2002) reports a drop of 7-9% moving from treebank trees to parser output trees.
P02-1018
In order to resolve all Chinese NLDs represented in the CTB, we modify and substantially extend the (Cahill et al., 2004) (henceforth C04 for short) algorithm as follows: Given the set of subcat frames s for the word w, and a set of paths p for the trace t, the algorithm traverses the f-structure f to: predict a dislocated argument t at a sub-fstructure h by comparing the local PRED:w to w’s subcat frames s t can be inserted at h if h together with t is complete and coherent relative to subcat frame s traverse f starting from t along the path p link t to it’s antecedent a if p’s ending GF a exists in a sub-f-structure within f; or leave t without an antecedent if an empty path for t exists In the modified algorithm, we condition the probability of NLD path p (including the empty path without an antecedent) on the GF associated of the trace t rather than the antecedent a as in C04.
P04-1041
We also plan to adapt other NLD recovery methods (Jijkoun and Rijke, 2004; Schmid, 2006) to Chinese and compare them with the current results.
P04-1040 P06-1023
to Chinese (Cahill et al., 2004)’s algorithm (Section 3.2) only resolves certain NLDs with known types of antecedents (TOPIC, TOPIC REL and FOCUS) at fstructures.
P04-1041
In order to give an overview on the character2 (Levy and Manning, 2004) is the only approach we are aware of that has been applied to both English and German.
P04-1042
In Section 3 we review (Cahill et al., 2004)’s method for recovering English NLDs in treebank-based LFG approximations.
P04-1041
3.2 F-Structure Based NLD Recovery (Cahill et al., 2004) presented a NLD recovery algorithm operating at LFG f-structure for treebankbased LFG approximations.
P04-1041
Our method revises and considerably extends the approach of (Cahill et al., 2004) originally designed for English, and, to the best of our knowledge, is the first NLD recovery algorithm for Chinese.
P04-1041
(Cahill et al., 2004)’s approach for English resolves three LDD types in parser output trees without traces and coindexation (Figure 2(b)), i.e. topicalisation (TOPIC), wh-movement in relative clauses (TOPIC REL) and interrogatives (FOCUS).
P04-1041
The evaluation shows that our algorithm considerably outperforms (Cahill et al., 2004)’s with respect to Chinese data.
P04-1041
As pointed out by (Campbell, 2004), this metric is insensitive to the correct attachment of the EC into the parse tree, and more importantly it is not clear whether it adequately measures performance in predicateargument structure recovery.
P04-1082
2 Non-Local Dependencies in Chinese In the Penn Chinese Treebank (CTB) (Xue et al., 2002) non-local dependencies are represented in terms of empty categories (ECs) and (for some of them) coindexation with antecedents, as exemplified in Figure 1.
C02-1145
Inspired by (Cahill et al., 2004)’s methodology which was originally designed for English and Penn-II treebank, our approach to Chinese non-local dependency recovery is based on Lexical-Functional Grammar (LFG), a formalism that involves both phrase structure trees and predicate-argument structures.
P04-1041
