Stuttgart. Atro Voutilainen 1993.
E93-1046 W93-0306
NPtool (Voutilainen 1993).
E93-1046 W93-0306
Before proceeding further with the main argument, consider three very recent hybrids systems that employ linguistic rules for resolving some of the ambiguities before using automatically generated corpus-based information: collocation matrices (Leech, Garside and Bryant 1994), Hidden Markov Models (Tapanainen and Voutilainen 1994), or syntactic patterns (Tapanainen and 2For related discussion, cf.
A94-1008 C94-1103 C94-1104
Kenneth Church 1988.
A88-1019
Geoffrey Leech, Roger Garside and Michael Bryant 1994.
C94-1103
knowledge about what is relevant in the context), they tend to reach a 95-97% accuracy in the analysis of several languages, in particular English (Marshall 1983; Black et aL 1992; Church 1988; Cutting et al.1992; de Marcken 1990; DeRose 1988; Hindle 1989; Merialdo 1994; Weischedel et al.1993; Brill 1992; Samuelsson 1994; Eineborg and Gamb~ick 1994, etc.).
A88-1019 A92-1018 A92-1021 H92-1023 J88-1003 J93-2006 J94-2001 P89-1015
Ralph Weischedel, Marie Meteer, Richard Schwartz, Lance Ramshaw and Jeff Palmuzzi 1993.
J93-2006
Tomek Strzalkowski 1992.
C92-1033
162 Kimmo Koskenniemi, Pasi Tapanainen and Atro Voutilainen 1992.
C92-1027
3However, CLAWS4 (Leech, Gazside and Bryant 1994) leaves some ambiguities unresolved; it uses portmanteau tags for representing them.
C94-1103
Note in passing that the ratio 1.04-1.08/99.7% compares very favourably with other systems; c.f. 3.0/99.3% by POST (Weischedel et al.1993) and 1.04/97.6% or 1.09/98.6% by de Marcken (1990).
J93-2006
Bernard Merialdo 1994.
J94-2001
Atro Voutilainen and Pasi Tapanainen 1993.
E93-1046 W93-0306
1992; Strzalkowski 1992).
C92-1033
analysis 2.3.1 Finite-State Intersection Grammar Syntactic analysis is carried out in another reductionistic parsing framework known as FiniteState Intersection Grammar (Koskenniemi 1990; Koskenniemi, Tapanainen and Voutilainen 1992; Tapanainen 1992; Voutilainen and Tapanainen 1993; Voutilainen 1994).
A94-1008 C90-2040 C92-1027 C94-1104 E93-1046 W93-0306
Mitchell Marcus, Beatrice Santorini and Mary Ann Marcinkiewicz 1993.
J93-2004
Govt. Eric Brill 1992.
A92-1021
65-70. Douglass Cutting, Julian Kupiec, Jan Pedersen and Penelope Sibun 1992.
A92-1018
The learning corpus can consist of plain text, but the best results seem achievable with annotated corpora (Merialdo 1994; Elworthy 1994).
A94-1009 J94-2001
Section 2 outlines a rule-based system consisting of the ENGCG tagger followed by a finitestate syntactic parser (Voutilainen and Tapanainen 1993; Voutilainen 1994) that resolves remaining part-of-speech ambiguities as a side effect.
A94-1008 C94-1104 E93-1046 W93-0306
71-81. David Elworthy 1994.
A94-1009
Stephen DeRose 1988.
J88-1003
The representation is introduced in (Voutilainen and Tapanainen 1993; Voutilainen 1994); here, only the main characteristics are given: • Each word boundary is explicitly represented as one of five alternatives: the sentence boundary "@@" the boundary separating juxtaposed finite clauses "@/" -centre-embedded (sequences of) finite clauses are flanked with "@<" and "@>" the plain word boundary "@" • Each word is furnished with a tag indicating a surface-syntactic function (subject, premoditier, auxiliary, main verb, adverbial, etc.).
A94-1008 C94-1104 E93-1046 W93-0306
Pasi Tapanainen and Timo Jgrvinen 1994.
A94-1008 C94-1104
Ezra Black, Fred Jelinek, John Lafferty, Robert Mercer and Salim Roukos 1992.
H92-1023
225-237. Helmut Schmid 1994.
C94-1027
Pasi Tapanainen and Atro Voutilainen 1994.
A94-1008 C94-1104
Cutting et al.1992). Corpus-based information can be represented e.g. as neural networks (Eineborg and Gamb/~c k 1994; Schmid 1994), local rules (Brill 1992), or collocational matrices (Garside 1987).
A92-1018 A92-1021 C94-1027
