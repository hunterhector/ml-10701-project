SRL feature extraction has relied on various syntactic representations of input sentences, such as syntactic chunks (Hacioglu et al., 2004) and full syntactic parses (Gildea and Jurafsky, 2002).
C04-1186 J02-3001 P02-1031 W04-2416
Our accuracy is most closely comparable to the 78.63% accuracy achieved on the full task by (Pradhan et al., 2005a).
P05-1072 W05-0634
gument set we consider is {A0, A1, A2, A3, A4, AM} where AM is a generalized annotation of all adjuncts such as AM-TMP, AM-LOC, etc., where PropBank function tags like TMP or LOC in AMTMP, AM-LOC are ignored (a common setting for SRL, see (Xue and Palmer, 2004; Moschitti, 2004)).
P04-1043 W04-3212
However, inmostcasestheycanonlyprovide a local dependency between predicate and argument for 87% of the argument constituents (Chen and Rambow, 2003), which is too low to provide high SRL accuracy.
W03-1006
In order to generalize the path feature (see Table 1 in Section 3) which is probably the most salient (while being the most data sparse) feature for SRL, previous work has extracted features from other syntactic representations, such as CCG derivations (Gildea and Hockenmaier, 2003) and dependency trees (Hacioglu, 2004) or integrated features from different parsers (Pradhan et al., 2005b).
C04-1186 P05-1072 W03-1008 W04-2416 W05-0634
There have been many different proposals on how to maintain syntactic locality (Xia, 1999; Chen and VijayShanker, 2000) and SRL locality (Chen and Rambow, 2003; Shen and Joshi, 2005) when extracting LTAG etrees from a Treebank.
W03-1006
Instead of extracting a typical “standard” path feature from the derived tree, (Chen and Rambow, 2003) uses the path within the elementary tree from the predicate to the constituent argument.
W03-1006
We chose SIGF7, which is an implementation of a computer-intensive, stratified approximaterandomization test (Yeh, 2000).
C00-2137
LTAG derivation tree kernels were previously used for parse re-ranking by (Shen et al., 2003).
W03-1012
However, (Pradhan et al., 2005a) uses some additional information since it deals with incorrect parser output by using multiple parsers.
P05-1072 W05-0634
Features extracted from LTAG derivations are different and provide distinct information when compared to predicate-argument features (PAF) or subcategorization features (SCF) used in (Moschitti, 2004) or even the later use of argument spanning trees (AST) in the same framework.
P04-1043
We did this for three reasons: (i) our results are directly comparable to those who have used the Charniak parses distributed with the CoNLL 2005 data-set; (ii) we avoid the possibility of a better parser identifying a larger number of argument constituents and thus leading to better results, which is orthogonal to the discriminative power of our proposed LTAG-based features; and (iii) the quality of LTAG derivation trees depends indirectly on the quality of head dependencies recovered by the parser and it is a well-known folklore result (see Table 3 in (McDonald et al., 591 2005)) that applying the head-percolation heuristics on parser output produces better dependencies when compared to dependencies directly recovered by the parser (whether the parser is an LTAG parser or a lexicalized PCFG parser).
P05-1012 P05-1022
(Xue and Palmer, 2004)) and our experiments show that 91% of the SRL targets can be recovered despite this aggressive pruning.
W04-3212
In contrast with features from shallow parsing, previous work (Gildea and Palmer, 2002; Punyakanok et al., 2005b) has shown the necessity of full syntactic parsing for SRL.
J02-3001 J05-1004 P02-1031
The 79.44% accuracy obtained by the top system in CoNLL 2005 (Punyakanok et al., 2005a) is not directly comparable since their system used the more accurate n-best parser output of (Charniak and Johnson, 2005).
P05-1022
Our evaluation criteria which is based on predictingtheSRLforconstituentsintheparsetreeisbased on the evaluation used in (Toutanova et al., 2005).
P05-1073
In LTAG-based statistical parsers, high accuracy is obtained by using the MagermanCollins head-percolation rules in order to provide the etrees (Chiang, 2000).
P00-1058
To avoid explicit feature engineering on trees, (Moschitti, 2004) used convolution kernels on selective portions of syntactic trees.
P04-1043
We also compared our proposed feature set against predicate/argument features (PAF) proposed by (Moschitti, 2004).
P04-1043
[A0seller Ports of Call Inc.] reached agreements to [Vverb sell] [A1thing its remaining seven aircraft] [A2buyer to buyers that weren’t disclosed]. is an example of SRL annotation from the PropBank corpus (Palmer et al., 2005), where the subscripted information maps the semantic roles A0, A1, A2 to arguments for the predicate sell as defined in the PropBank Frame Scheme.
J05-1004
(Chen and Rambow, 2003) use LTAG-based decomposition of parse trees (as is typically done for statistical LTAG parsing) for SRL.
W03-1006
For SRL, high accuracy has been achieved by: (i) proposing new types of features (see Table 1 in Section 3 for previously proposed features), (ii)modelingthepredicateframesetbycapturingdependencies between arguments (Gildea and Jurafsky, 2002; Pradhan et al., 2004; Toutanova et al., 2005; Punyakanok et al., 2005a), (iii) dealing with incorrect parser output by using more than one parser (Pradhan et al., 2005b).
J02-3001 N04-1030 P02-1031 P05-1072 P05-1073 W05-0634
A similar drawback can be found in (Gildea and Hockenmaier, 2003) where aparsetreepathwas defined in terms of Combinatory Categorial Grammar (CCG) types using grammatical relations between predicate and arguments.
W03-1008
Tofullyevaluatetheinfluenceofthe LTAG-basedfeatures,wereporttheidentificationresults on both Gold Standard parses and on Charniak parser output (Charniak, 2000)5.
A00-2018
Basic features from (Gildea and Jurafsky, 2002) • predicate lemma and voice • phrase type and head word • path from phrase to predicate 1 • position: phrase relative to predicate: before or after • sub-cat records the immediate structure that expands from predicate’s parent 2 Additional features proposed by (Surdeanu et al.2003; Pradhan et al., 2004, 2005) • predicate POS • head word POS • first/last word/POS • POS of word immediately before/after phrase • path length 1 •LCA(Lowest CommonAncestor) path from phrase to its lowest common ancestor with predicate • punctuation immediately before/after phrase∗ • path trigrams∗: up to 9 are considered • head word named entity label such as “PER, ORG, LOC”∗ • content word named entity label for PP parent node∗ Additional features proposed by (Xue and Palmer, 2004) • predicate phrase type • predicate head word • voice position • syntactic frame∗ 1 In Fig.
J02-3001 N04-1030 P02-1031 P03-1002 P05-1072 W04-3212 W05-0634
For the test data, we report on results using the gold-standardTreebankdata,andinadditionwealso report results on automatically parsed data using the Charniak parser (Charniak, 2000) as provided by the CoNLL 2005 shared task.
A00-2018 P05-1022
We use sister adjunction which is commonly used in LTAG statistical parsers to deal with the relatively flat Penn Treebank trees (Chiang, 2000).
P00-1058
This result is better than (Xue and Palmer, 2004), and better on gold parses compared to (Toutanova et al., 2005; Punyakanok et al., 2005b).
J05-1004 P05-1073 W04-3212
Feature Set Our standard feature set is a combination of features proposed by (Gildea and Jurafsky, 2002), (Surdeanu et al., 2003; Pradhan et al., 2004; Pradhan et al., 2005b) and (Xue and Palmer, 2004).
J02-3001 N04-1030 P02-1031 P03-1002 P05-1072 W03-1008 W04-3212 W05-0634
