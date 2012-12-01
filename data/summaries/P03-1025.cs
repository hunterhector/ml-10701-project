In the parameterized version of the RTN method that Nederhof (2000) proposes, the state space is enlarged: different copies of each state are created to keep track of what the derivational history was at the point of entering the present subautomaton.
J00-1003
5. 5 RTN-based approximation techniques A comprehensive overview and experimental comparison of finite-state approximation techniques for context-free grammars is given in (Nederhof 2000).
J00-1003
optimizations Besides the selective history list construction, two further optimizations were applied to Nederhof’s (2000) parameterized RTN-method: First, Earley items with the same remainder to the right of the dot were collapsed (a41 a4 a0a5 a10 a9 a45 a12 a49 and a41 a4 a0a5 a10 a11 a45 a12 a49 ).
J00-1003
We ran a comparison between a version of the non-selective parameterized RTN-method of (Nederhof 2000) and the selective history method proposed in this paper.
J00-1003
8For the exact conditions see (Nederhof 2000, 25).
J00-1003
strategy We propose a refinement of finite-state approximation techniques for context-free grammars, as they have been developed for syntax (Pereira and Wright 1997, Grimley-Evans 1997, Johnson 1998, Nederhof 2000).
J00-1003 P97-1058 P98-1101
Nederhof (2000) discusses an important additional step for avoiding an explosion of the size of the intermediate, non-deterministic FSA: before the described approximation is performed, the contextfree grammar is split up into subgrammars of mutually recursive categories (i.e., categories which can participate in a recursive cycle); in each subgrammar, all other categories are treated as nonterminal symbols.
J00-1003
