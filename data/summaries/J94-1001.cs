Computing with Features as Formulae Mark Johnson* Brown University This paper extends the approach to feature structures developed in Johnson (1991a), which uses SchO'nfinkel-Bernays' formulae to express feature structure constraints.
J91-2001
Emele, Martin (1991).
P91-1042
Rounds (1988) describes such a language called LFP, whose decidability follows from the fact that the domain of quantification is Computational Linguistics Volume 20, Number 1 restricted (just as in SB).
J88-4001
uncertainty constraints, used in the LFG treatment of long-distance dependencies (Kaplan and Zaenen 1989) appear to have a decidable satisfiability problem (Kaplan and Maxwell 1988a), but the satisfiability problem for arbitrary boolean combinations of functional uncertainty constraints is undecidable (Keller 1991), so these cannot be expressed using SB formulae either (since the quantifier-free subclass of SB is closed under boolean operations).
C88-1060 C88-1061
Johnson (1991b) also discusses the application of general first-order logic and nonmonotic logics to the specification of more complex constraints on feature structures.
J91-2001
Johnson, Mark (1991a).
J91-2001
Specialized languages can be constructed specifically for the task of expressing feature structure constraints (such as Kasper and Rounds's FDL \[Kasper and Rounds 1990\] and Johnson's attribute-value languages \[Johnson 1988\]).
J88-4001 P88-1029
is a generalization of the algorithm described in Hegner (1991), which treats Horn combinations of attribute-value constraints.
E91-1007
For example, under a classical interpretation, the set of feature structures satisfying negated feature structure constraints are not upward-closed (Moshier and Rounds 1987).
P87-1013
Rounds, William C., and Manaster-Ramer, Alexis (1987).
P87-1013
Following Johnson (1991b), attribute-value feature structures can be specified in SB in the following way.
J91-2001
Helsinki. Johnson, Mark, and Klein, Ewan (1986).
C86-1156
(1990a), following a suggestion first made in Kaplan and Bresnan (1982), showed how attribute-value constraints could be formalized in the quantifier-free subset of first-order logic, while later work (Johnson 1991a, 1991b) proposed a different formalization in the Sch6nfinkel-Bernays' subset of first-order formulae.
J91-2001
Since disjunctive constraints seem to be a practical necessity for describing natural languages (Barton, Berwick, and Ristad 1987; Karttunen 1984), most practical feature structure systems will probably have NP-hard satisfiability problems.
P84-1008
Uszkoreit, Hans (1986).
C86-1045
Previous work has shown that these formulae are expressive enough to define arbitrary disjunctions and negations of constraints (Johnson 1990a, 1990b), a kind of 'set-valued' entity (Johnson 1991a), and they can be used to impose useful sort constraints (Johnson 1991b).
C90-1003 J91-2001 P90-1022
Karttunen, Lauri (1984).
P84-1008
The effect of using such one-sided approximations was investigated in Johnson (1991a).
J91-2001
Standard procedures for transforming first-order formulae into clausal form, such as the ones described in Chang and Lee (1973), Duffy 12 Mark Johnson Computing with Features as Formulae (1991), or Genesereth and Nilsson (1987), transform SB formulae into SB formulae in clausal form.
J91-2001
For further examples and a discussion of how the disjunction and negation of attribute-value constraints are transparently representable as SB formulae, see Johnson (1991a, 1991b).
J91-2001
Kasper (1988) and Hegner (1991) point out that Horn clauses, although technically disjunctions, can be handled considerably more efficiently than general disjunctive constraints.
E91-1007 P88-1029
That is, these formulae are used as annotations on phrase structure rules in the manner described in, e.g., Kaplan and Bresnan (1982), Shieber (1986), and Johnson (1988).
C88-1060 C88-1061
Prentice-Hall. Zajac, R6mi (1992).
J92-2002
The techniques discussed by Maxwell and Kaplan (1991, 1992) seem most directly compatible with the approach described in this paper, and the methods described by Kasper (1987b), Eisele and D6rre (1988), and Emele (1991) might have important applications as well.
P87-1033 P88-1029 P88-1035 P91-1042
Tree Structure Constraints with SB Formulae Inspired by the work on description theory or 'D-theory' (Marcus, Hindle, and Fleck 1983; Vijay-Shanker 1992), this section shows how some elementary constraints on precedence and dominance in a tree can be expressed as SB formulae.
J92-4004 P83-1020
1. Introduction Despite their simplicity, a surprisingly wide range of linguistic phenomena can be described in terms of simple equality constraints on values in attribute-value structures, which are a particularly simple kind of feature structure (see Shieber 1986; Johnson 1988; Uszkoreit 1986; and Bresnan 1982 for examples of some of these analyses).
C86-1045 C86-1156
While the connection between logic programming and feature structures is well known (Ait-Kaci 1984; Ait-Kaci and Podelski 1993; Carpenter 1991, 1992; H6hfeld and Smolka 1988; Pereira 1987; Shieber 1992; Smolka 1992), this shows that the theory of feature structure constraints is also related to database theory as well.
P91-1002
examples of this approach see Dawar and Vijay-Shanker (1990), D6rre and Eisele (1990), Johnson (1988, 1990a, 1990b, 1991a, 1991b, in press a), Karttunen (1984), Kasper (1987a, 1987b, 1988), Kasper and Rounds (1986, 1990), Langholm (1989), Pereira (1987), and Smolka (1992).
C90-1003 J90-1002 J91-2001 P84-1008 P86-1038 P87-1013 P87-1033 P88-1029 P88-1035 P90-1022
For example, Johnson (1991a) shows how to formulate a variety of constraints on 'setvalued' features in SB.
J91-2001
For example, the analysis of conjunctions in LFG (Kaplan and Maxwell 1988b) and the formalizations of Discourse Representation Theory (Kamp 1981) presented in Johnson and Klein (1986) and Johnson and Kay (1990) require additional mechanisms for representing and manipulating aggregates or sets of values in ways that are beyond the capability of such "pure" attribute-value systems.
C86-1156 C88-1060 C88-1061 C90-1003 P90-1022
Cyclic feature structures can be prohibited with a constraint formalizable in SB, as described in Johnson (1991b), and one can express a constraint in SB that requires that all attributes are "attribute-value constants" (even though there appears to be no linguistic motivation for such a constraint, and indeed, some analyses crucially depend on this not being the case, as pointed out in Johnson \[1988\]).
J91-2001
Versions of both of these kinds of constraint, as well as the familiar attribute-value constraints, can be expressed as Scho'nfinkel-Bernays'formulae (as demonstrated in Johnson 1991a, 1991b), so that the problem of determining the satisfiability of a system of such constraints is reduced to the satisfiability problem for the corresponding formula.
J91-2001
Johnson, Mark (1991b).
J91-2001
Carpenter, Bob (1991).
P91-1002
Carpenter, Bob; Pollard, Carl; and Franz, Alex (1991).
P91-1002
Johnson, Mark (1990b).
C90-1003 P90-1022
of this approach are Carpenter, Pollard, and Franz (1991), D6rre (1991), D6rre and Eisele (1991), Johnson (in press b), Kay (1979, 1985a, 1985b), Pollard and Sag (1987), Rounds and Manaster-Ramer (1987), Smolka (1988), and Zajac (1992).
J88-4001 J92-2002 P87-1013 P91-1002
For most applications there is little substantive difference between these two approaches; the approach taken here allows attributes to be quantified over, e.g., to state sortal constraints, and permits values to be used as attributes, as in e.g., LFG (Kaplan and Bresnan 1982); for discussion and linguistic applications see also Johnson (1988).
C88-1060 C88-1061
Further, sortal constraints (which also cannot be expressed as simple equality constraints) can be used to formulate simpler and more comprehensible grammars (Carpenter 1992; Carpenter and Pollard 1991; Pollard and Sag 1987, 1992).
P91-1002
These axioms are quite permissive: in 6 Johnson (1991a) and Smolka (1992) propose that an attribute-value arc labeled a from x to y be conceptualized as an instance of a two-place relation a(x, y).
J91-2001
Johnson, Mark (1990a).
C90-1003 P90-1022
This paper extends the author's previous paper on the topic (Johnson 1991a) by sketching several other linguistic applications of Sch6nfinkel-Bernays' formulae (including a version of D-theory \[Marcus, Hindle, and Fleck 1983; Vijay-Shanker 1992\]), and presenting a least-fixed-point theorem that serves as the theoretical basis for a "forwardchaining" algorithm for determining satisfiability of Sch6nfinkel-Bernays' formulae.
J91-2001 J92-4004 P83-1020
Carpenter, Bob, and Pollard, Carl (1991).
P91-1002
Blackburn, Gardent, and Meyer-viol (1993) introduce a modal language L T for describing trees decorated with feature structures, whose satisfiability problem is undecidable.
E93-1004
Johnson, Mark, and Kay, Martin (1990).
C90-1003 P90-1022
Blackburn, Patrick; Gardent, Claire; and Meyer-viol, Wilfried (1993).
E93-1004
