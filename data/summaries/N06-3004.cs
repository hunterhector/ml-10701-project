However, to be more expressive and flexible, it is often easier to start with a general SCFG or tree-transducer (Galley et al., 2004).
N04-1035
Bikel. 2004.
J04-4004
We develop this intuition into a technique called synchronous binarization (Zhang et al., 2006) which binarizes a synchronous production or treetranduction rule on both source and target sides simultaneously.
N06-1033
When tested on top of two state-of-the-art systems, the Collins/Bikel parser (Bikel, 2004) and Chiang’s CKY-based Hiero decoder (Chiang, 2005), this algorithm is shown to have very little overhead even for quite large k (say, 106) (See Fig.
J04-4004 P05-1033
Many researchers have explored syntax-based methods, for instance, Wu (1996) and Chiang (2005) both uses binary-branching synchronous context-free grammars (SCFGs).
P05-1033 P96-1021
These rules can be learned from a parallel corpus using English parsetrees, Chinese strings, and word alignment (Galley et al., 2004).
N04-1035
Following Galley et al.(2004), we use an extended tree-to-string transducer (xRs) with multi-level left-hand-side (LHS) trees.1 Since the right-hand-side (RHS) string can be viewed as a flat one-level tree with the same nonterminal root from LHS (Fig.
N04-1035
So I codeveloped several fast and exact algorithms for kbest parsing in the general framework of directed monotonic hypergraphs (Huang and Chiang, 2005).
P05-1033 W05-1506 W05-1507
So one might want to postpone some disambiguation by propagating k-best lists (instead of 1-best solutions) to subsequent phases, as in joint parsing and semantic role-labeling (Gildea and Jurafsky, 2002).
J02-3001
Smith for the Dyna language (Eisner et al., 2005), 223 and Jonathan May for ISI’s tree automata package Tiburon.
H05-1036
Previous algorithms for k-best parsing (Collins, 2000; Charniak and Johnson, 2005) are either suboptimal or slow and rely significantly on pruning techniques to make them tractable.
P05-1022
Binarization for MT Machine Translation has made very good progress in recent times, especially, the so-called “phrasebased” statistical systems (Och and Ney, 2004).
J04-4002
We also propose another trick (hook) for further speeding up the decoding with integrated n-gram models (Huang et al., 2005).
W05-1506 W05-1507
Experiments show that the resulting rule set significantly improves the speed and accuracy over monolingual binarization (see Table 1) in a stateof-the-art syntax-based machine translation system (Galley et al., 2004).
N04-1035
We adapt this syntaxdirected transduction process to statistical MT by applying stochastic operations at each node of the source-language parse-tree and searching for the best derivation (a sequence of translation steps) that converts the whole tree into some target-language string (Huang et al., 2006).
W06-3601
This is also true for reranking and discriminative training, where the k-best list of candidates serves as an approximation of the full set (Collins, 2000; Och, 2003; McDonald et al., 2005).
P03-1021 P05-1012
These algorithms have been re-implemented by other researchers in the field, including Eugene Charniak for his n-best parser, Ryan McDonald for his dependency parser (McDonald et al., 2005), Microsoft Research NLP group (Simon Corston-Oliver and Kevin Duh, p.c). for a similar model, Jonathan Graehl for the ISI syntax-based MT decoder, David A.
P05-1012 P05-1022
In accordance with our experiments, we also use English and Chinese as the source and target languages, opposite to the Foreign-to-English convention of Brown et al.(1993). (a) the gunman was killed by the police . parser ⇓ (b) S NP-C DT the NN gunman VP VBD was VP-C VBN killed PP IN by NP-C DT the NN police PUNC . r1, r2 ⇓ (c) qiangshou VP VBD was VP-C VBN killed PP IN by NP-C DT the NN police ◦ r3 ⇓ (d) qiangshou bei NP-C DT the NN police VBN killed ◦ r5 ⇓ r4 ⇓ (e) qiangshou bei jingfang jibi ◦ Figure 3: A synatx-directed translation process.
J93-2003
Similar algorithms have also been proposed for dependency-based translation (Lin, 2004; Ding and Palmer, 2005).
C04-1090 P05-1067
