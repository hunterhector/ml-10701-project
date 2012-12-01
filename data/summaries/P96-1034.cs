The formulation we give here is inspired by (Kaptan and Kay, 1994) and (Roche and Schabes, 1995).
J95-2004
2.3 Transformation-based parsing Transformation-based parsing was first introduced in (Brill, 1993).
P93-1035
A tree-based extension of the very fast algorithm described in (Roche and Schabes, 1995) is in principle possible for transformation-based parsing, but is likely to result in huge space requirements and seems impractical.
J95-2004
For example, in an application of the transformation-based parser described in (Brill, 1993), 7r = 300 rules were learned, to be applied at each node of the initial parse structure, but the average number of rules that are successfully applied at each node is only about one.
P93-1035
If space requirements are of primary importance or when the rule set is very large, our method can then be considered for stringbased transformation rewriting as an alternative to the already mentioned method in (Roche and Schabes, 1995), which is faster but has more onerous space requirements.
J95-2004
In this paper we consider transformation-based parsing, introduced in (Brill, 1993), and we improve upon the O(Trpn) time upper bound..
P93-1035
In (Roche and Schabes, 1995), a method is described for converting a list of transformations that operates on strings into a deterministic finite state transducer, resulting in an optimal tagger in the sense that tagging requires only one state transition per word, giving a linear time tagger whose run-time is independent of the number and size of rules.
J95-2004
More recently, transformations have been applied to a diverse set of problems, including part of speech tagging, pronunciation network creation, prepositional phrase attachment disambiguation, and parsing, under the paradigm of transformation-based error-driven learning (see (Brill, 1993; Brill, 1995) and (Brill and Resnik, 1994)).
C94-2195 J95-4004 P93-1035
