4 4 Probability Models 4.1 Direct Model Departing from the conventional noisy-channel approach of Brown et al.(1993), our basic model is a direct one: c∗ = argmax c Pr(c|e) (2) where e is the English input string and c∗ is the best Chinese translation according to the translation model Pr(c | e).
J93-2003
In fact, the recursive transfer step can be done by a a linear-time algorithm (see Section 5), and the parsing step is also fast with the modern Treebank parsers, for instance (Collins, 1999; Charniak, 2000).
A00-2018
Similarly, in the tree-transducer terminology, Graehl and Knight (2004) define extended tree transducers that have multi-level trees on the source-side.
N04-1014
For example, Shieber and Schabes (1990) introduce synchronous tree-adjoining grammar (STAG) and Eisner (2003) uses a synchronous tree-substitution grammar (STSG), which is a restricted version of STAG with no adjunctions.
C90-3045 P03-2041
Phrase-based models (Koehn et al., 2003; Och and Ney, 2004) are good at learning local translations that are pairs of (consecutive) sub-strings, but often insufficient in modeling the reorderings of phrases themselves, especially between language pairs with very different word-order.
J04-4002 N03-1017
When writing these rules, we avoid notational overhead by introducing a short-hand form from Galley et al.(2004) that integrates the mapping into the tree, which is used throughout Section 1.
N04-1035
To alleviate this problem, determinization techniques have been proposed by Mohri and Riley (2002) for finite-state automata and extended to tree automata by May and Knight (2006).
N06-1045
This example also shows that, one-level SCFG rule, even if informed by the Treebank as in (Yamada and Knight, 2001), is not enough to capture a common construction like this which is five levels deep (from VP to “by”).
P01-1067
This is because the generative capacity of these models lies within the realm of finite-state machinery (Kumar and Byrne, 2003), which is unable to process nested structures and long-distance dependencies in natural languages.
N03-1019
Informally speaking, a derivation in a transducer is a sequence of steps converting a source-language 2Although hybrid approaches, such as dependency grammars augmented with phrase-structure information (Alshawi et al., 2000), can do re-ordering easily.
J00-1004
4.2 Log-Linear Model Following Och and Ney (2002), we extend the direct model into a general log-linear framework in order to incorporate other features: c∗ = argmax c Pr(c|e)α·Pr(c)β·e−λ|c| (9) where Pr(c) is the language model and e−λ|c| is the length penalty term based on |c|, the length of the translation.
P02-1038
Galley et al.(2004) presents a linear-time algorithm for automatic extraction of these xRs rules from a parallel corpora with word-alignment and parse-trees on the source-side, which will be used in our experiments in Section 6.
N04-1035
Fox. 2002.
W02-1039
So instead of determinization, here we present a simple-yet-effective extension to the Algorithm 3 of Huang and Chiang (2005) that guarantees to output unique translated strings: • keep a hash-table of unique strings at each vertex in the hypergraph • when asking for the next-best derivation of a vertex, keep asking until we get a new string, and then add it into the hash-table This method should work in general for any equivalence relation (say, same derived tree) that can be defined on derivations.
P05-1033 W05-1506
To this end, we use an efficient algorithm by Huang and Chiang (2005, Algorithm 3) that solves the general k-best derivations problem in monotonic hypergraphs.
P05-1033 W05-1506
In accordance with our experiments, we also use English and Chinese as the source and target languages, opposite to the Foreign-to-English convention of Brown et al.(1993). (a) the gunman was [killed]1 by [the police]2. parser⇓ (b) S NP-C DT the NN gunman VP VBD was VP-C VBN killed PP IN by NP-C DT the NN police PUNC . r1,r2⇓ (c) qiangshou VP VBD was VP-C VBN killed PP IN by NP-C DT the NN police ◦ r3⇓ (d) qiangshou bei NP-C DT the NN police VBN killed ◦ r5⇓ r4⇓ (e) qiangshou bei [jingfang]2 [jibi]1 ◦ Figure 3: A synatx-directed translation process for Example (1).
J93-2003
Besides being linguistically motivated, the need for EDL is also supported by empirical findings in MT that one-level rules are often inadequate (Fox, 2002; Galley et al., 2004).
N04-1035 W02-1039
In computational linguistics, the bottom-up version of this algorithm resembles the tree parsing algorithm for TSG by Eisner (2003).
P03-2041
Similar algorithms have also been proposed for dependency-based translation (Lin, 2004; Ding and Palmer, 2005).
C04-1090 P05-1067
Besides, our model, as being linguistically motivated, is also more expressive than the formally syntax-based models of Chiang (2005) and Wu (1997).
J97-3002 P05-1033
Both Yamada and Knight (2001) and Chiang (2005) use SCFGs as the underlying model, so their translation schemata are syntax-directed as in Fig.
P01-1067 P05-1033
Following Galley et al.(2004), we use a special class of extended tree-to-string transducer (xRs for short) with multilevel left-hand-side (LHS) trees.1 Since the righthand-side (RHS) string can be viewed as a flat onelevel tree with the same nonterminal root from LHS (Fig.
N04-1035
There are also some variations of syntax-directed translators where dependency structures are used in place of constituent trees (Lin, 2004; Ding and Palmer, 2005; Quirk et al., 2005).
C04-1090 P05-1034 P05-1067
Feature weights of both systems are tuned on the same data set.3 For Pharaoh, we use the standard minimum error-rate training (Och, 2003); and for our system, since there are only two independent features (as we always fix α = 1), we use a simple grid-based line-optimization along the language-model weight axis.
P03-1021
Tree-to-String Tranducers In this section, we define the formal machinery of our recursive transformation model as a special case of xRs transducers (Graehl and Knight, 2004) that has only one state, and each rule is linear (L) and non-deleting (N) with regarding to variables in the source and target sides (henth the name 1-xRLNs).
N04-1014
We first word-align them by GIZA++, then parse the English side by a variant of Collins (1999) parser, and finally apply the rule-extraction algorithm of Galley et al.(2004). The resulting rule set has 24.7M xRs rules.
N04-1035
In contrast, their decodings are reported to be computationally expensive and Chiang (2005) uses aggressive pruning to make it tractable.
P05-1033
