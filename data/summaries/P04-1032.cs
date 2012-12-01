Theorem 1 (Niehren and Thater, 2003).
P03-1047
As a test corpus, we use the Redwoods Treebank (Oepen et al., 2002) which contains 6612 sentences.
C02-2025
This also verifies Niehren and Thater’s (2003) assumption that EP-conjunctions are “syntactic sugar” which can be resolved in a preprocessing step: EP-conjunctions can be resolved by exhaustively applying the following rule which adds new literals to make the implicit conjunction explicit: h : E 1 (h 1,...,h n ),h : E 2 (h prime 1,...,h prime m )⇒ h :‘E 1 &E 2 ’(h 1,...,h n,h prime 1,...,h prime m ), where E(h 1,...,h n ) stands for an EP with argument handles h 1,...,h n, and where ‘E 1 &E 2 ’ is a complex function symbol.
P03-1047
Two important underspecification formalisms in the recent literature are Minimal Recursion Semantics (MRS) (Copestake et al., 2004) and dominance constraints (Egg et al., 2001).
P01-1019
Underspecification is the standard approach to dealing with scope ambiguity (Alshawi and Crouch, 1992; Pinkal, 1996).
P92-1005
In this paper, we evaluate the truth of these assumptions on the MRS expressions which the ERG computes for the sentences in the Redwoods Treebank (Oepen et al., 2002).
C02-2025
We developed Niehren and Thater’s (2003) theoretical translation into a practical system for translating MRS into dominance constraints, applied it systematically to MRSs produced by English Resource Grammar for the Redwoods treebank, and evaluated the results.
P03-1047
The topmost fragment has outgoing dominance edges to otherwise unconnected subconstraints ϕ 1 and ϕ 2 . Under the merging-free semantics of the MRS dialect used in (Niehren and Thater, 2003) where every hole has to be filled exactly once, this constraint cannot be configured: there is no hole into which “available” could be plugged.
P03-1047
Underspecified descriptions are easier to derive in syntax-semantics interfaces (Egg et al., 2001; Copestake et al., 2001), useful in applications such as machine translation (Copestake et al., 1995), and can be resolved by need.
P01-1019
Lemma 2 (Niehren and Thater, 2003).
P03-1047
EP-conjunctions. Definitions 1 and 2 generalize the idealized definition of MRS of Niehren and Thater (2003) by EP-conjunctions with a merging semantics.
P03-1047
Niehren and Thater (2003) defined, in a theoretical paper, a translation from MRS into normal dominance constraints.
P03-1047
