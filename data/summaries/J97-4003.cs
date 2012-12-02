6. Efficiency Evaluation The computational treatment of lexical rules as covariation in lexical entries was implemented in Prolog by the authors in cooperation with Dieter Martini for the ConTroll system (Gerdemann and King 1994; G6tz and Meurers 1997a).
C94-2154 J97-4003
In a number of proposals, lexical generalizations are captured using lexical underspecification (Kathol 1994; Krieger and Nerbonne 1992; 564 Meurers and Minnen Covariation Approach to HPSG Lexical Rules Riehemann 1993; Oliva 1994; Frank 1994; Opalka 1995; Sanfilippo 1995).
C94-2131 E95-1024
The computational treatment of lexical rules proposed can be seen as an extension to the principled method discussed by G6tz and Meurers (1995, 1996, 1997b) for encoding the main building block of HPSG grammars--the implicative constraints--as a logic program.
J97-4003
For example, in the case of generation, underspecification of the head of a construction can lead to massive nondeterminism or even nontermination when not enough restricting information is available to generate its complements (Martinovi4 and Strzalkowski 1992; Minnen, Gerdemann, and G6tz 1995).
E95-1024
A similar method is included in PATR-II (Shieber et al.1983) and can be used to encode lexical rules as binary relations in the CUF system (Dbrre and Eisele 1991; D6rre and Dorna 1993b) or the TFS system (Emele and Zajac 1990; Emele 1994).
C90-3052
The encoding of lexical rules used in the covariation approach is related to the work of van Noord and Bouma (1994), who describe the hand-encoding of a single lexical rule as definite relations and show how these relations can be used to constrain a lexical entry.
C94-1039
Flickinger, Pollard, and Wasow (1985) solve this problem using additional specifications: "By providing with each lexical rule a generic class frame which specifies the general form and predictable properties of the rule's output, we avoid unnecessary work when the lexical rule applies" (p.
P85-1032
One possibility is to annotate the lexical rule encoding with such criteria by means of delay statements, as, for example, suggested by van Noord and Bouma (1994).
C94-1039
on the research results reported in Meurers and Minnen (1995, 1996), we propose a new computational treatment of lexical rules that overcomes these shortcomings and results in a more efficient processing of lexical rules as used in HPSG.
E95-1024
7. Related Work The powerful mechanism of lexical rules (Carpenter 1991) has been used in many natural language processing systems.
J91-3003
An interesting alternative, therefore, is to automatically determine certain control problems and deal with them in an off-line fashion along the lines of Minnen, Gerdemann, and G6tz (1995) and Minnen, Gerdemann, and Hinrichs (1996).
C96-1092 E95-1024
27 Briscoe and Copestake (1996) argue that semi-productivity of lexical rules, which can be understood as a generalization of exceptions to lexical rules, can be integrated with our approach by assigning probabilities to the automaton associated with a particular lexical entry.
W96-0303
interpretation of the signature is sometimes referred to as closed world (Gerdemann and King 1994; Gerdemann 1995).
C94-2154
Also an analysis treating adjunct extraction via lexical rules (van Noord and Bouma 1994) results in an infinite lexicon.
C94-1039
32 In certain cases an extension of the constraint language with named disjunctions or contexted constraints (Maxwell and Kaplan 1989; Eisele and D6rre 1990; Griffith 1996) can be used to circumvent constraint propagation.
C96-1076
