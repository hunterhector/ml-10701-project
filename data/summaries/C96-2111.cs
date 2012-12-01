Moreover, our implementation uses the open Prolog lists of Eisele/D6rre (1986) to encode the feature structures of PATR-II (also see Gazdar/Mellish 1989: 228ff).
C86-1129
Whereas Shieber et al.(1990) have discussed similar techniques in the context of semantichead-driven generation, we are concerned here with parsing.
J90-1004
on Implementation in Prolog Implementation of the LC algorithm in Prolog has been discussed by Matsumoto et al.(1982) for the BUP system, by Pereira/Shieber (1987), Kilbury (1990), and Covington (1994).
C90-3080 J90-1004
Shieber (1985, 1992) follows established terminology in speaking of top-down filtering in connection with the prediction step of the Earley algorithm.
P85-1018
Like Shieber (1985, 1992) with the notion of restriction, we confine our attention to a subset of specifications; in particular, we can define a feature structure that subsumes all VP-type feature structures of Shieber's recursive subcategorization rules.
P85-1018
Bouma, Gosse (1991) Prediction in Chart Parsing Algorithms for Categorial Unification Grammar, Proceedings of the 5th EACL Conterence, 179-184.
E91-1031
Kilbury, James (1990) QPATR and Constraint Threading, Proceedings of COLING-90, Vol.
C90-3080
However, such an adaptation of CF algorithms involves their extension to possibly infinite nonterminal domains, which, as Shieber (1985) and Haas (1989) have shown, is nontrivial.
J89-4001 P85-1018
We view the linking relation not simply as a filter to increase efficiency within the domain of syntactic analysis--this aspect is stressed by Shieber (1985) and other investigators such as Bouma (1991)--but rather as a device for the top-down predictive instantiation of information, as Shieber et al.(1990) have shown for semantic-head-driven generation.
E91-1031 J90-1004 P85-1018
2.4 Top-Down Predictive Linking The aim of our proposal is to define equivalence relations that keep the linking relation finite while also preventing it from being too restrictive; this turns the linking relation into a weakpredietion table in the sense of Haas (1989: 227ff).
J89-4001
This amounts to the simplest case of the restriction technique of Shieber (1985).
P85-1018
Eisele, Andreas / Jochen DOrre (1986) A Lexical Functional Grammar System in Prolog, Proceedings' of COLING-86, 551-553.
C86-1129
A better solution, which we have adopted from Kilbury (1990), is to introduce rule numbers, which are then used to define a purely filtering linking relation.
C90-3080
An example of the pitfalls awaiting naive attempts at such an extension is provided by the grammars illustrating the list technique for subcategorization introduced by Shieber (1986: 32, 77-78); also see the similar example of Haas (1989: 227).
J89-4001
