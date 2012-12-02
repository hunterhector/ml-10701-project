• Third, the queue and cloned states are checked (starting with the last state) against the register using function replace or register(), which is essentially the same as the nonrecursive version in the second algorithm in Daciuk et al.(2000) and is shown in Figure 2.
J00-1002
2. Mathematical Preliminaries 2.1 Finite-State Automata and Languages As in Daciuk et al.(2000), we will define a deterministic finite-state automaton as M =(Q,Σ, δ, q 0, F), where Q is a finite set of states, q 0 ∈ Q is the start state, F ⊆ Q is a set of accepting states, Σ is a finite set of symbols called the alphabet, and δ: Q × Σ → Q is the next-state mapping.
J00-1002
The algorithm may be straightforwardly derived from customary textbook constructions for the intersection and the complementation of finite-state automata; the resulting algorithm solves the dictionary construction problem addressed by Daciuk et al.’s (2000) second algorithm as a special case.
J00-1002
Forcada † Universitat d’Alacant Universitat d’Alacant Daciuk et al.[Computational Linguistics 26(1):3–16 (2000)] describe a method for constructing incrementally minimal, deterministic, acyclic finite-state automata (dictionaries) from sets of strings.
J00-1002
As suggested by one of the reviewers of this article, an improvement in efficiency may be obtained by realizing that, in many cases, cloned states corresponding to the shortest prefixes of string w are not affected by minimization, because their intact equivalents have become unreachable and therefore have been removed from the register; the solution lies in identifying these states and not cloning them (for example, Daciuk et al.’s [2000] and Revuz’s [2000] algorithms do not clone them).
J00-1002
The asymptotic time complexity of the algorithms is in the same class (O(|Q||w|))as that in Daciuk et al.(2000), because the slowest part of the algorithm (the last one) checks all queue and cloned states (O(|w|)) against all states of the register (O(|Q|)).
J00-1002
These two operations may be applied to dictionary construction and maintenance and generalize the result in Daciuk et al.’s (2000) second algorithm (incremental construction of acyclic finite-state automata from unsorted strings) in two respects, with interesting practical implications: • The method described here allows for the addition of strings to the languages of cyclic automata (in practice, it may be convenient to have cycles in dictionaries if we want them to accept, for example, all possible integer numbers or Internet addresses).
J00-1002
It is not difficult to show that minimization may be performed by initializing a list R called the register (Daciuk et al.2000) with all of the intact states and then testing, one by one, queue and cloned states (starting with the last queue state (⊥, w) or, if it does not exist, the last clone state (q, w), and descending in Pr(w)) against states in the register and adding them to the register if they are not found to be equivalent to a state in R.
J00-1002
• States of the form (q, x) with q ∈ Q −{⊥} and x ∈ Pr(w), such that δ ∗ (q 0, x)=q; they will be called cloned states, inspired by the terminology in Daciuk et al.(2000); the remaining states in (Q −{⊥})× Pr(w)—the great majority of states in Q × Q w —may safely be discarded because they are unreachable from the new start state q prime 0 =(q 0, epsilon1), which itself is a cloned state.
J00-1002
The language accepted by automaton M L(M)={w ∈ Σ ∗ : δ ∗ (q 0, w) ∈ F} (2) and the right language of state q vector L(q)={x ∈ Σ ∗ : δ ∗ (q, x) ∈ F} (3) are defined as in Daciuk et al.(2000). 2.2 Single-String Automaton We also find it convenient to define the (complete) single-string automaton for string w, denoted M w =(Q w,Σ, δ w, q 0w, F w ), such that L(M w )={w}.
J00-1002
1. Introduction In a recent paper in this journal, Daciuk et al.(2000) describe two methods for constructing incrementally minimal, deterministic, acyclic finite-state automata (dictionaries) from sets of strings: The first method adds strings in dictionary order, and the second one is for unsorted data.
J00-1002
