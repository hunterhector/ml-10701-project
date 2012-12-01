We performed similar experiments for the Alvey NL Tools grammar of English (Grover, Carroll, and Briscoe 1993), and the English grammar of the MiMo2 system (van Noord et al.1991). From these experiments it can be concluded that selective memorization with goal-weakening (as applied to head-corner and left-corner parsing) is substantially more efficient than conventional chart parsing.
P91-1015
The grammar is documented in detail in van Noord, Nederhof, Koeling, and Bouma (1996).
P96-1032
Weakening The insight behind goal weakening (or abstraction \[Johnson and D6rre 1995\]) in the context of memorization is that we may combine a number of slightly different goals into a single, more general, goal.
P95-1014
This problem can be solved in some cases by a good (but relatively expensive) implementation of the memorization technique, e.g., along the lines of Warren (1992) or Johnson and DOrre (1995).
P95-1014
3: Alvey NL Tools A final set of experiments was performed for the Alvey NL Tools grammar (Grover, Carroll, and Briscoe 1993), similar to the experiments discussed in Carroll (1994).
P94-1040
This can be accomplished, for example, by replacing all terms beyond a certain depth by anonymous variables, or by other restrictors (Shieber 1985).
P85-1018
Some further variations are discussed in Nederhof and Satta (1994).
P94-1029
In van Noord (1991, 1993) I argue that head-corner parsing is especially useful for parsing with nonconcatenative grammar formalisms.
P91-1015
448 van Noord Efficient Head-Comer Parsing and van Noord, Nederhof, Koeling, and Bouma (1996).
P96-1032
The parsers are described in further detail in van Noord, Bouma, Koeling, and Nederhof (1996) 6 The material used to perform the experiments with the MiMo2 grammar and the Alvey NL Tools grammar, including several versions of the head-corner parser, is available via anonymous ftp at: ftp ://ftp.
P96-1032
E-mail: vannoord@let.rug.nl (~ 1997 Association for Computational Linguistics Computational Linguistics Volume 23, Number 3 Shieber (1985) therefore proposes a modified version of the Earley parser, using restricted top-down prediction.
P85-1018
In Lavelli and Satta (1991) and van Noord (1994) head-driven parsing strategies for Lexicalized Tree Adjoining Grammars are presented.
E91-1006
Shieber's (1985) restriction operator can be used here.
P85-1018
454 van Noord Efficient Head-Corner Parsing Acknowledgments Some of the introductory material of this article is a modified and extended version of the introduction of Bouma and van Noord (1993).
E93-1010
Details can be found in van Noord, Bouma, Koeling, and Nederhof (1996).
P96-1032
consider the grammar used by Tomita (1987) and Billot and Lang (1989), given here in (17) and (18).
J87-1004
The head-corner parser is closely related to the semantic-head-driven generation algorithm (see Shieber et al.\[1990\] and references cited there), especially in its purely bottom-up incarnation.
J90-1004
Even if goal weakening is reminiscent of Shieber's (1985) restriction operator, the rules of the game are quite different: in the case of goal weakening, as much information as possible is removed without risking nontermination of the parser, whereas in the case of Shieber's restriction operator, information is removed until the resulting parser terminates.
P85-1018
If the definite clause grammar is off-line parsable, and if the finite-state automaton is acyclic, then this computation can be guaranteed to terminate (van Noord 1995).
P95-1022
Moreover, a similar experiment was performed with two other grammars: the English MiMo2 grammar (van Noord et al.1991), and the English Alvey NL Tools grammar (Grover, Carroll, and Briscoe 1993).
P91-1015
This is an experimental implementation of a generalization for Definite Clause Grammars of the parser described in Nederhof and Satta (1996).
P96-1032
