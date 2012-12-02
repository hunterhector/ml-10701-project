Other than the additional field, the algorithm remains essentially the same as the parsing algorithm described in (Schabes and Shieber, 1994), so it can be applied as a transducer during recognition, or as a post-process on a derivation forest (Vijay-Shanker and Weir, 1993).
E93-1045 J94-1004
upenn, edu Abstract Rambow, Wier and Vijay-Shanker (Rainbow et al., 1995) point out the differences between TAG derivation structures and semantic or predicateargument dependencies, and Joshi and VijayShanker (Joshi and Vijay-Shanker, 1999) describe a monotonic compositional semantics based on attachment order that represents the desired dependencies of a derivation without underspecifying predicate-argument relationships at any stage.
P95-1021
The resulting dependencies are represented graphiCally in the dependency structure below: ¢0 :supposed-to I ¢\] :be-able-to(0) I ¢2:fly(0) This example is relatively straightforward, simply reversing the direction of adjunction dependencies as described in (Candito and Kahane, 1998a), but this algorithm can transduce 91 the correct isomorphic dependency structure for the Portuguese derivation as well, similar to the distributed derivation tree in Candito and Kahane's example 5b, "Paul claims Mary seems to adore hot dogs," (Rambow et al., 1995), where there is no edge corresponding to the dependency between the raising and bridge verbs: c~:voar 81:~-capaz-de(VP) ~2:fi-pressuposto-que(S) We begin by adjoining ~1 :g-capaz-de at node VP of c~:voar, which produces the dependency (~-capaz-de, 0,voar), just as before.
P95-1021
The primary goal of this paper is to solve the problem of preserving semantic dependencies in Isomorphic Synchronous Tree Adjoining Grammar (ISTAG) (Shieber, 1994; Shieber and Schabes, 1990), a variant of Tree Adjoining Grammar (Joshi, 1985) in which source and target elementary trees are assembled into isomorphic derivations.
C90-3045
In this paper, we apply the Joshi and Vijay-Shanker conception of compositional semantics to the problem of preserving semantic dependencies in Synchronous TAG translation (Shieber and Schabes, 1990; Abeill~ et al., 1990).
C90-3045
fin--1 :going(VP) I \[ fin--1 :vai(VP) fln:supp.(VP) This sort of non-local non-isomorphic transfer cannot be handled in a synchronous TAG that has an isomorphism restriction on derivation trees• On the other hand, we do not wish to return to the original non-local formulation of synchronous TAG (Shieber and Schabes, 1990) because the non-local inheritance of links on the derived tree is difficult to implement, and because the non-local formulation can recognize languages beyond the generative power of TAG.
C90-3045
It is also important to note that Joshi and Vijay-Shanker's definition of TAG compositional semantics differs from that of Shieber 9) and Schabes (Shieber and Schabes, 1990) using Synchronous TAG, in that the former preserves the scope ordering of predicative adjunctions, which may be permuted in the latter, altering the meaning of the sentence.
C90-3045
Rambow, Wier and Vijay-Shanker themselves introduce D-Tree Grammar (Rambow et al., 1995) and Candito and Kahane introduce the DTG variant Graph Adjunction Grammar (Candito and Kahane, 1998b) in order to solve this problem using a derivation process that mirrors composition more directly, but both involve potentially significantly greater recognition complexity than TAG.
P95-1021
The problem, first described in Rambow, Wier and Vijay-Shanker (Rainbow et al., 1995), stems from the fact that the TAG derivation structure even using a flat adjunction of modifiers (Schabes and Shieber, 1994) deviates from the appropriate dependency *The author would like to thank Karin Kipper, Aravind Joshi, Martha Palmer, Norm Badler, and the anonymous reviewers for their valuable comments.
J94-1004 P95-1021
(avoar, 1, 3, capaz) 7See (Schabes and Shieber, 1994) for the motivations of this restriction.
J94-1004
the traversal must 2See (Schabes and Shieber, 1994) for definitions of modifier and predicative auxiliaries.
J94-1004
