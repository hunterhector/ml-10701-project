The particular variant of DG we use, Topological Dependency Grammar (TDG) (Duchier, 2002; Duchier and Debusmann, 2001), was developed specifically with efficient parsing for free word order languages in mind.
P01-1024
In this section, we relate it to chart generation (Kay, 1996; Carroll et al., 1999) and to another constraint-based approach (Gardent and Thater, 2001).
P01-1028 P96-1027
The problematic runtimes of generation algorithms are explained by the fact that realization is an NP-complete problem even using just context-free grammars, as Brew (1992) showed in the context of shake-and-bake generation.
C92-2092
Grammar Formalism The parse trees of topological dependency grammar (TDG) (Duchier and Debusmann, 2001; Duchier, 2002) are trees whose nodes correspond one-to-one to the words of the sentence, and whose edges are labelled, e.g. with syntactic relations (see Fig.
P01-1024
A similar result was proved in the context of shakeand-bake generation by Brew (1992), but he needed to use the grammar in his encoding, which leaves the possibility open that for every single grammar G, there might be a realization algorithm tailored specifically to G which still runs in polynomial time.
C92-2092
(Gardent and Thater, 2001).
P01-1028
Following Stone and Doran (1997) and Kay (1996), we enhance this TAG grammar with a syntax-semantics interface in which nonterminal nodes of the elementary trees are equipped with index variables, which can be bound to individuals in the semantic input.
P96-1027 P97-1026
Working with derived trees, Gardent and Thater (2001) cannot ignore any information and have to keep track of the relationships between nodes at points where they are not relevant.
P01-1028
Several different approaches to improving the runtime in practice have been suggested in the literature e.g. heuristics (Brew, 1992) and factorizations into smaller exponential subproblems (Kay, 1996; Carroll et al., 1999).
C92-2092 P96-1027
Gardent and Thater (2001) also propose a constraint based approach to generation working with a variant of TAG.
P01-1028
The idea of multiple adjunction is not new (Schabes and Shieber, 1994), but it is simplified here because we disregard complex adjunction constraints.
J94-1004
