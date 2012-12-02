CFG and Synchronous Parsing We begin by describing the synchronous CFG formalism, which is more rigorously defined by Aho and Ullman (1972) and Satta and Peserico (2005).
H05-1101
Wellington et al.(2006) did a similar analysis on the English-English bitext.
P06-1123
Wellington et al.(2006) indicate the necessity of introducing discontinuous spans for synchronous parsing to match up with human-annotated word alignment data.
P06-1123
Grammar rules extracted from large parallel corpora by systems such as Galley et al.(2004) can be quite large, and Wellington et al.(2006) argue that complex rules are necessary by analyzing the coverage of gold-standard word alignments from different language pairs by various grammars.
P06-1123
We use the same alignment data for the five language pairs Chinese/English, Romanian/English, Hindi/English, Spanish/English, and French/English (Wellington et al., 2006).
P06-1123
We adopt the SCFG notation of Satta and Peserico (2005).
H05-1101
The methodology in Wellington et al.(2006) measures the complexity of word alignment using the number of gaps that are necessary for their synchronous parser which allows discontinuous spans to succeed in parsing.
P06-1123
Wu (1997) demonstrates the case of binary SCFG parsing, where six string boundary variables, three for each language as in monolingual CFG parsing, interact with each other, yielding an O(N6) dynamic programming algorithm, where N is the string length, assuming the two paired strings are comparable in length.
J97-3002
Instead of linearly shifting in one number at a time, Gildea et al.(2006) employ a balanced binary tree as the control structure, producing an algorithm similar in spirit to merge-sort with a reduced time complexity of O(nlogn).
P06-2036
Wellington et al.(2006) treat many-toone word links disjunctively in their synchronous parser.
P06-1123
Grammars with longer rules can represent a larger set of reorderings between languages (Aho and Ullman, 1972), but also require greater computational complexity for word alignment algorithms based on synchronous parsing (Satta and Peserico, 2005).
H05-1101
Wu (1997)’s Inversion Transduction Grammar, as well as tree-transformation models of translation such as Yamada and Knight (2001), Galley et al.(2004), and Chiang (2005) all fall into this category.
J97-3002 P01-1067 P05-1033
Zhang et al.(2006) discuss methods for binarizing SCFGs, ignoring the nonbinarizable grammars; in Section 2 we discuss the generalized problem of factoring to k-ary grammars for any k and formalize the problem as permutation factorization in Section 3.
N06-1033
