The reductions presented in Kasper and Rounds (1986) and Johnson (1988) can be used to show that the problem is NP-hard, so the satisfiability problem for feature constraints with set-values (as defined above) is NP-complete.
P86-1038 P88-1029
Eisele and D6rre 1988; D6rre and Eisele 1990; Maxwell and Kaplan 1989a, 1989b) can be applied here too.
P88-1035
The most widely known model of feature structures and constraint language is the one developed to explain disjunctive feature values by Kasper and Rounds (1986, 1990) and Kasper (1986, 1987).
P86-1038 P87-1033
For example, "negative values" and "disjunctive values" allow grammars and lexical entries to be written much more succinctly, as the following examples show (based on Karttunen 1984).
P84-1008
Instead of providing entities in the interpretation that serve as the denotation for "disjunctive" or "negative" features, we follow Kasper and Rounds (1986, 1990), Moshier and Rounds (1987), and Johnson (1988, 1990) in permitting disjunction and negation only in the constraint language.
C90-1003 P86-1038 P87-1033 P88-1029 P90-1022
1. Introduction Many modern linguistic theories, such as Lexical-Functional Grammar (Bresnan 1982), Functional Unification Grammar (Kay 1985), Generalized Phrase Structure Grammar (Gazdar et al.1985), Unification Categorial Grammar (Haddock et al.1987), (Uszkoreit 1986), and Head-Driven Phrase Structure Grammar (Pollard and Sag 1987), replace the atomic categories of a context-free grammar with a "feature structure" that represents the syntactic and semantic properties of the phrase.
C86-1045
However, because negation is interpreted declaratively (in fact, classically) in the first-order language used to express constraints here, its treatment is straightforward and unproblematic, and suggests ways of extending the unification algorithm to cover these cases (Johnson 1990b, to appear).
C90-1003 P90-1022
(An example is presented below; see Johnson (1990) and especially Section 2.10 of Johnson (1988) for further discussion).
C90-1003 P90-1022
Various proposals to extend the Kasper-Rounds approach to deal with negative feature values are described by Moshier and Rounds (1987), Moshier (1988), Kasper (1988), Dawar and Vijayashanker (1989, 1990), Langholm (1989); other extensions to this framework are discussed by D6rre and Rounds (1989), Smolka (1988, 1989), and Nebel and Smolka (1989); and Shieber (1989) discusses the integration of such feature systems into a variety of parsing algorithms.
P87-1033 P88-1029 P89-1003
As explained below, the familiar attribute-value "unification algorithm" can be interpreted as computing the atomic consequences of a purely conjunctive formula (where the graphs it operates on are data structures efficiently representing such formulae), and unification failure corresponds to the unsatisfiability of that conjunction (Kasper and Rounds 1990; Johnson 1988, 1990a; Pereira 1987).
C90-1003 P87-1033 P88-1029 P90-1022
This paper follows an alternative strategy suggested in Johnson (1990a): axiomatize the relevant properties of feature structures in some well-understood language (here first-order logic) and translate constraints on these structures into the same language.
C90-1003 P90-1022
Johnson and Klein (1986) and Johnson and Kay (1990) show how "set-valued" features can be used to express Discourse Representation Theory (Kamp 1981) in a complex-feature based grammar formalism.
C86-1156 C90-1003 P90-1022
Following Kaplan and Bresnan (1982), Pereira and Shieber (1984), Kasper and Rounds (1986, 1990), and Johnson (1988, 1990a) the constraints that determine the feature structures are regarded as formulae from a language for describing feature structures, rather than as feature structures themselves.
C90-1003 P84-1027 P86-1038 P88-1029 P90-1022
As Kasper (1986, 1987) noted in a different setting, the steps of the attribute-value unification algorithm are just applications of the axioms 1-3.
P86-1038 P87-1033
is possible to avoid these problems by augmenting feature structures with "inequality arcs," as was first proposed (to my knowledge) by Karttunen (1984) and discussed in Johnson (1990a), Johnson (in press) and pages 67-72 of Johnson (1988).
C90-1003 P84-1008 P90-1022
