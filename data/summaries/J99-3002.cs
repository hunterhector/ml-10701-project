(~) 1999 Association for Computational Linguistics Computational Linguistics Volume 25, Number 3 to be a parsing algorithm with the ideas from Schabes (1994), which also suggest how it can be extended to handle substitution in addition to adjunction.
J94-1004
As shown by Nederhof and Satta (1994), a family of parsing algorithms (topdown, left-corner, PLR, ELR, and LR parsing \[Nederhof 1994\]) can be carried over to head-driven parsing.
J94-2002 P94-1017 P94-1029
"step" is more accurately called an "inference rule" in the literature on deductive parsing (Shieber, Schabes, and Pereira 1995).
J95-4002
However, some general considerations suggest that the algorithm from Schabes and Joshi (1988) is inherently more expensive.
P88-1032
Note that LR-like parsing algorithms were proposed by Schabes and Vijay-Shanker (1990) and Nederhof (1998).
P90-1035 P98-2156
A final remark on Schabes and Joshi (1988) concerns the time complexity in terms of the size of the grammar that they report, viz.
P88-1032
Second, the "Right Completor" from Schabes and Joshi (1988), which roughly corresponds with our adjunctor steps, has nine relevant input positions.
P88-1032
Surprisingly, it has been claimed by Schabes and Waters (1995) that this property is problematic for the mildly contextsensitive languages represented by tree-adjoining grammars (TAGs): the best practical parsing algorithms for TAGs have time complexity Cg(n 6) (Vijay-Shankar and Joshi \[1985\]; see Satta \[1994\] and Rajasekaran and Yooseph \[1995\] for lower theoretical upper bounds), whereas the only published algorithm with the correct-prefix property--that by Schabes and Joshi (1988)--has complexity O(n9).
J94-2002 J95-4002 P88-1032 P95-1023
The question arises where the exact difference lies between our algorithm and that of Schabes and Joshi (1988), and whether their algorithm could be improved to obtain the same time complexity as ours, using techniques similar to those discussed above.
P88-1032
5. Complexity The steps presented in pseudoformal notation in Section 3 can easily be composed into an actual algorithm (Shieber, Schabes, and Pereira 1995).
J95-4002
The complexity results carry over to linear indexed grammars, combinatory categorial grammars, and head grammars, since these formalisms are equivalent to TAGs (Vijay-Shanker and Weir 1993, 1994).
J93-4002
Furthermore, our new algorithm is related to many existing recognition algorithms for TAGs (Vijay-Shankar and Joshi 1985; Schabes and Joshi 1988; Lang 1988; Vijay-Shanker and Weir 1993; Schabes and Shieber 1994; Schabes 1994), some of which were published 356 Nederhof Correct-Prefix Property for TAGs together with proofs of correctness.
J93-4002 J94-1004 P88-1032
