2 3 Some Preliminaries 3.1 First-order Compilation for Categorial Parsing Hepple (1996) introduces a method of firstorder compilation for implicational linear logic, to provide a basis for efficient theorem proving of various categorial formalisms.
C96-1091
The resulting method is one in which the formulae of a Lambek sequent that is to be proven are first converted to produce rules of a formalism which combines ideas from the multiset-valued linear indexed grammar formalism of Rainbow (1994), with the Lambek calculus span labelling scheme of Morrill (1995), and with the first-order compilation method for categorial parsing of Hepple (1996).
C96-1091 E95-1019
The resulting 'grammar' is then parsed using an Earley-style predictive chart algorithm which is adapted from Rambow et al.(1995b). 2 The Lambek Calculus We are concerned with the implicational (or 'product-free') fragment of the associative Lambek calculus (Lambek, 1958).
P95-1021
Thus when Y--o X combines with its argument, whose derivation includes Z, the latter's variable becomes bound, e.g. lu.w(lz.u) + x(yz) =~ w(Iz.x(yz)) 3.2 Multiset-valued Linear Indexed Grammar Rambow (1994) introduces the multiset-valued linear indexed grammar formalism ({}-LIG).
P94-1036
We should note that the DTG parsing method of (Rambow et al., 1995), from which the current approach is derived, is polynomial time.
P95-1021
In the (Rambow et hi., 1995) algorithm, the scanning component also deals with epsilon productions.
P95-1021
x\[\](o-3) I Y\[ll(1-k) w\[\](1-2) Z\[ll(3-k) I I 0 0 4.2 The Earley-style Parsing Method The chart parsing method to be presented is derived from the Earley-style DTG parsing method of Rambow et al.(1995), and in some sense both simplifies and complicates their method.
P95-1021
spans) to handle word order, is used in Pareschi (1988), although in that approach all string positions instantiate to values on a single ordering (i.e.
P88-1033
Firstly, directional types are labelled with span information using the labelling scheme of Morrill (1995) (which is justified in relation to relational algebraic models for the Lambek calculus (van Benthem, 1991)).
E95-1019
The starting point for this work is the observation, in (Hepple, 1998), of certain similarities between categorial grammars and the D-Tree grammar (DTG) formalism of Rambow et al.(1995a). On this basis, we have explored adapting the DTG parsing approach of Rambow et al.(1995b) for use with the Lambek calculus.
P95-1021
second stage of the conversion is adapted from the first-order compilation method of Hepple (1996), discussed earlier, modified to handle directional formulae and using a modified indexation scheme to record dependencies 3The constants produced in the translation correspond to 'new' string positions, which make up the additional suborderings on which hypotheticals are located.
C96-1091
The method of Hepple (1992) avoids this complicated book-keeping, and also rules out some useless subderivations allowed by Khnig's method, but does so at the cost of computing a representation of all the possible category sequences that might be tested in an exhaustive sequent proof search.
C92-1024
