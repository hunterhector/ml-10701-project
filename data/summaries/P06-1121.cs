work Similarly to (Poutsma, 2000; Wu, 1997; Yamada and Knight, 2001; Chiang, 2005), the rules discussed in this paper are equivalent to productions of synchronous tree substitution grammars.
C00-2092 J97-3002 P01-1067 P05-1033
Its rule binarization is described in (Zhang et al., 2006).
N06-1033
Finally, we show that our contextually richer rules provide a 3.63 BLEU point increase over those of (Galley et al., 2004).
N04-1035
In this paper, we take the framework for acquiring multi-level syntactic translation rules of (Galley et al., 2004) from aligned tree-string pairs, and present two main extensions of their approach: first, instead of merely computing a single derivation that minimally explains a sentence pair, we construct a large number of derivations that include contextually richer rules, and account for multiple interpretations of unaligned words.
N04-1035
Chiang. 2005.
P05-1033
While the state-of-the-art hierarchical SMT system (Chiang, 2005) performs well despite stringent constraints imposed on its context-free grammar, we believe its main advantage lies in its ability to extract hierarchical rules across phrasal boundaries.
P05-1033
We believe that our tree-to-string model has several advantages over tree-to-tree transformations such as the ones acquired by Poutsma (2000).
C00-2092
An empirical evaluation against a state-of-the-art SMT system similar to (Och and Ney, 2004) indicates positive prospects.
J04-4002
We presented some theoretical arguments for not limiting extraction to minimal rules, validated them on concrete examples, and presented experiments showing that contextually richer rules provide a 3.63 BLEU point increase over the minimal rules of (Galley et al., 2004).
N04-1035
We believe it will be beneficial to account for this finding in future work in syntax-based SMT and in efforts to improve upon (Chiang, 2005).
P05-1033
For this, we need a formalism that is expressive enough to deal with cases of syntactic divergence between source and target languages (Fox, 2002): for any given (pi,f,a) triple, it is useful to produce a derivation that minimally explains the transformation between pi and f, while remaining consistent with a.
W02-1039
We contrast our work with (Galley et al., 2004), highlight some severe limitations of probability estimates computed from single derivations, and demonstrate that it is critical to account for many derivations for each sentence pair.
N04-1035
In this paper, we developed probability models for the multi-level transfer rules presented in (Galley et al., 2004), showed how to acquire larger rules that crucially condition on more syntactic context, and how to pack multiple derivations, including interpretations of unaligned words, into derivation forests.
N04-1035
Galley et al.(2004) alleviate this modeling problem and present a method for acquiring millions of syntactic transfer rules from bilingual corpora, which we review below.
N04-1035
H.Fox. 2002.
W02-1039
We compare our syntax-based system against an implementation of the alignment template (AlTemp) approach to MT (Och and Ney, 2004), which is widely considered to represent the state of the art in the field.
J04-4002
Anotherpromisingprospectofourmodelseems to lie in its ability to handle non-contiguous phrases, a feature that state of the art systems such as (Och and Ney, 2004) do not incorporate.
J04-4002
Galley et al.(2004) present one such formalism (henceforth “GHKM”).
N04-1035
2.1 Tree-to-string alignments It is appealing to model the transformation of pi into f using tree-to-string (xRs) transducers, since their theory has been worked out in an extensive literature and is well understood (see, e.g., (Graehl and Knight, 2004)).
N04-1014
While it is infeasible to enumerate the millions of derivations in each forest, Graehl and Knight (2004) demonstrate an efficient algorithm.
N04-1014
Formally, transformational rules ri presented in (Galley et al., 2004) are equivalent to 1-state xRs transducers mapping a given pattern (subtree to match in pi) to a right hand side string.
N04-1035
