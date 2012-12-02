Several recent syntax-based models for machine translation (Chiang, 2005; Galley et al., 2006) can be seen as instances of the general framework of synchronous grammars and tree transducers.
P05-1033 P06-1121
More importantly, the ratio of binarizability, as expected, decreases on freer word-order languages (Wellington et al., 2006).
P06-1123
Our experiments are on English-to-Chinese translation in the tree-to-string system of Huang et al.(2006), which takes a source-language parse tree as input and tries to recursively convert it to a targetlanguage string according to transfer rules in a synchronous grammar (Galley et al., 2006).
P06-1121
Although according to Zhang et al.(2006), the vast majority (99.7%) of rules in their Chinese-English dataset are binarizable, there do exist some interesting cases that are not (see Figure 2 for a real-data example).
N06-1033
35 3.1 String-based Approaches String-based approaches include both string-tostring (Chiang, 2005) and string-to-tree systems (Galley et al., 2006).2 To simplify the presentation we will just focus on the former but the analysis also applies to the latter.
P05-1033 P06-1121
In the worstcase, a binarized grammar with a source arity of s will require at most (2s+1) free indices in a deduction, because otherwise if one rule needs (2s + 2) 36 indices, then there are s+1 spans, which contradicts the definition of arity (Huang et al., 2005).4 These deductive systems represent the search space of decoding without a language model.
W05-1507
The resulting grammar is thus another SCFG, the binary branching equivalent of the original grammar, which can be thought of as an extension of the 34 [jinyibu]1 further [ jiu on zhongdong Mideast weiji crisis ]2 [juxing]3 hold [huitan]4 talk ‘[hold]3 [further]1 [talks]4 [on the Mideast crisis]2’ 1 2 3 4 Chinese −→ Engli sh −→ Figure 2: An example of non-binarizable rule from the hand-aligned Chinese-English data in Liu et al.(2005). The SCFG rule is VP → ADVP 1 PP 2 VB 3 NN 4, VP → VB 3 JJ 1 NNS 4 PP 2 in the notatoin of Satta and Peserico (2005).
H05-1101 P05-1057
However, this method is more sophisticated to implement than the previous method and binarizability ratio decreases on freer word-order languages (Wellington et al., 2006).
P06-1123
a Language Model To integrate with a bigram language model, we can use the dynamic-programming algorithm of Wu (1996), which we may think of as proceeding in two passes.
P96-1021
Intuitively speaking, the gaps on the target-side will lead to exponential complexity in decoding with integrated language models (see Section 3), as well as synchronous parsing (Zhang et al., 2006).
N06-1033
In this setting, the −LM decoding phase is a tree-parsing problem (Eisner, 2003) which aims to cover the entire tree by a set of rules.
P03-2041
It is also worth noting that with the hook trick of Huang et al.(2005), the target-side complexity can be reduced to O(|w|(2t+1)(m−1)), making it more analogous to its source-side counterpart: if we consider the decoding problem as intersecting the SCFG with a source-side DFA which has |S| = |w|+1 states, and a target-side DFA which has |T| = O(|w|m−1) states, then the intersected grammar has a parsing complexity of O(|S|2s+1|T|2t+1), which is symmetric from both sides.
W05-1507
1An alternative notation, used by Satta and Peserico (2005), allows co-indexed nonterminals to take different symbols across languages, which is convenient in describing syntactic divergences (see Figure 2).
H05-1101
Decoding with an SCFG (e.g., translating from Chinese to English using the above grammar) can be cast as a parsing problem (see Section 3 for details), in which case we need to binarize a synchronous rule with more than two nonterminals to achieve polynomial time algorithms (Zhang et al., 2006).
N06-1033
We compare it with the other two schemes in two popular instantiations of MT systems based on SCFGs: the string-based systems (Chiang, 2005; Galley et al., 2006) where the input is a string to be parsed using the source-side of the SCFG; and the treebased systems (Liu et al., 2006; Huang et al., 2006) where the input is a parse tree and is recursively converted into a target string using the SCFG as a tree-transducer.
P05-1033 P06-1077 P06-1121
Synchronous binarization (Zhang et al., 2006) solves this problem by simultaneously binarizing both source and target-sides of a synchronous rule, making sure of contiguous spans on both sides whenever possible.
N06-1033
This representation, being contiguous on both sides, successfully reduces the decoding complexity to a low polynomial and significantly improved the search quality (Zhang et al., 2006).
N06-1033
As a result, the binarized grammar, with a gap on the target-side, is no longer an SCFG, but can be represented in the more general formalism of Multi-Text Grammars (MTG) (Melamed, 2003): (3) parenleftbiggS S parenrightbigg →⊲⊳ [1,2][1,2,1] parenleftbigg NP-PP VP NP-PP (2) VP parenrightbigg here [1,2,1] denotes that on that target-side, the first nonterminal NP-PP has two discontinuous spans, with the second nonterminal VP in the gap.
N03-1021
3.2 Tree-based Approaches The tree-based approaches include the tree-to-string (also called syntax-directed) systems (Liu et al., 2006; Huang et al., 2006).
P06-1077
Our data preparation follows (Huang et al., 2006): the training data is a parallel corpus of 28.3M words on the English side, from which we extracted 24.7M tree-to-string rules using the algorithm of (Galley et al., 2006), and trained a Chinese trigram model on the Chinese side.
P06-1121
A very similar system for the reverse direction is described in (Liu et al., 2006).
P06-1077
For example, we first combine NP with PP (NPi,j) : (w1,t1) (PPj,k) : (w2,t2) (NP-PPi,k) : (w1 + w2,t1 ⊔t2) (7) 2Our notation of X-to-Y systems is defined as follows: X denotes the input, either a string or a tree; while Y represents the RHS structure of an individual rule: Y is string if the RHS is a flat one-level tree (as in SCFGs), and Y is tree if the RHS is multi-level as in (Galley et al., 2006).
P06-1121
