114 7 Appendix: Notational conventions The regular expression formalism used in this paper is essentially the same as in Kaplan and Kay (1994), in Karttunen (1995), and in Kempe and Karttunen (1996).
C96-2105 J94-3001 P95-1003
For the details of the formalism (briefly explained in the Appendix), please consult Karttunen (1995), Kempe and Karttunen (1996).
C96-2105 P95-1003
Section 3 introduces a novel type of replace expression for constructing transducers that unambiguously recognize and mark 2The tentative formulation of the longest-match constraint in (Kaplan and Kay, 1994, p.
J94-3001
As in Kaplan and Kay (1994), Karttunen (1995), and other previous works on related topics, the intermediate levels of the composition introduce auxiliary symbols to express and enforce constraints on the replacement relation.
J94-3001 P95-1003
The idea of treating phonological rewrite rules in this way was the starting point of Kaplan and Kay (1994).
J94-3001
One reason is that we prefer to think of the simple unconditional (uncontexted) replacement as the basic case, as in Karttunen (1995).
P95-1003
(We believe that the conditional case can also be handled in a simpler way than in Kaplan and Kay (1994)).
J94-3001
notation to the simple replace expressions in Karttunen (1995).
P95-1003
In contrast to the simple replace expression, UPPER -> LOWER, defined in Karttunen (1995), the new directed version, UPPER ©-> LOWER, yields an unambiguous transducer if the lower language consists of a single string.
P95-1003
Another extension, already implemented, is a directed version of parallel replacement (Kempe and Karttunen 1996), which allows any number of replacements to be done simultaneously without interfering with each other.
C96-2105
Although the same results could often be achieved by using lex and yacc, sed, awk, perl, and other Unix utilities, there is an advantage in using finitestate transducers for these tasks because they can then be smoothly integrated with other finite-state processes, such as morphological analysis by lexical transducers (Karttunen et al 1992, Karttunen 1994) and rule-based part-of-speech disambiguation (Chanod and Tapanainen 1995, Roche and Schabes 1995).
C94-1066 E95-1021 J95-2004 P95-1003
(Roche and Schabes (1995) introduce a similar technique for imposing the left-to-right order on the transduction).
J95-2004
Roche and Sehabes (1995) call such transducers deterministic.
J95-2004
Replacement Z< "$\[Z>\] Y,> -> LOWER ; Figure 11: Definition of UPPER @-> LOWER The logic of ~-> replacement could be encoded in many other ways, for example, by using the three pairs of auxiliary brackets, <i, >i, <c, >c, and <a, >a, introduced in Kaplan and Kay (1994).
J94-3001
Transducers compiled from simple replace expressions UPPER -> LOWER (Karttunen 1995, Kempe and Karttunen 1996) are generally nondeterministic in the sense that they may yield multiple results even if the lower language consists of a single string.
C96-2105 P95-1003
