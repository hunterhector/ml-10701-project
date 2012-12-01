% Note: underscore matches anything (anonymous wildcard) Figure 2: An Earley parser that recovers inside probabilities (Earley, 1970; Stolcke, 1995).
J95-2002
We further restrict to semiring-weighted programs as in (Goodman, 1999).
J99-4004
In some special cases only a linear solver is needed: e.g., for unary rule cycles (Stolcke, 1995), or epsilon1-cycles in FSMs (Eisner, 2002).
J95-2002 P02-1001
Eisner. 2005.
W05-1504
24Neither uses heuristics from Klein and Manning (2003a).
N03-1016 P03-1054
27Thus it can handle a subset of the cases described by Goodman (1999), again by building the whole parse forest.
J99-4004
The agenda algorithm does this by iterative approximation (propagating updates around any cycles in the proof graph until numerical convergence), essentially as suggested by Stolcke (1995) for the case of Earley’s algorithm.14 Again, the computation may diverge.
J95-2002
(Dyna would have been equally helpful in the first author’s earlier work on new algorithms for lexicalized and CCG parsing, syntactic MT, transformational syntax, trainable parameterized FSMs, and finite-state phonology.) In other cases (Smith and Eisner, 2004; Smith and Smith, 2004; Smith et al., 2005), Dyna let us quickly replicate, tweak, and combine useful techniques from the literature.
H05-1060 P04-1062 P04-3032 P05-1044 W04-3207 W05-1504
Smith, 2005).
H05-1060 P05-1044
Weighted deduction is a powerful theoretical formalism that encompasses many NLP algorithms (Goodman, 1999).
J99-4004
In some cases, we were experimenting with genuinely new algorithms not supported by any existing tool, as in our work on dependency-lengthlimited parsing (Eisner and Smith, 2005b) and loosely syntax-based machine translation (Eisner and D.
H05-1060 P05-1044 W05-1504
We compared a Dyna CFG parser to the Java parser of Klein and Manning (2003b),24 22Markus Dreyer’s reimplementation of the complex Collins (1999) parser uses under 30 lines of Dyna.
N03-1016 P03-1054
Stolcke. 1995.
J95-2002
It provides an elegant notation for specifying a variety of parsing algorithms (Shieber et al., 1995), including algorithms for probabilistic or other semiring-weighted parsing (Goodman, 1999).
J99-4004
Folding introduces new intermediate items, perhaps exploiting the distributive law; applications include parsing speedups such as (Eisner and Satta, 1999), as well as well-known techniques for speeding up multi-way database joins, constraint programming, or marginalization of graphical models.
P99-1059
It has previously been generalized (Nederhof, 2003) to the case 〈W,⊕,⊗〉 = 〈R≥0,max,+〉.
J03-1006
In previous work such as (Goodman, 1999; Nederhof, 2003), one only specifies the inference rules as unweighted Horn clauses, and then weights are added automatically in a standard way: all values have the same type W, and all rules transform to equations of the form c ⊕= a1 ⊗ a2 ⊗ ··· ⊗ ak, where ⊕ and ⊗ give W the structure of a semiring.4 In Dyna one writes these equations explicitly in place of Horn clauses (Fig.
J03-1006 J99-4004
To return goal, one may not need to compute the values of all items.9 In particular, finding the best parse should not require finding all parses (in contrast to Goodman (1999) and Zhou and Sato (2003)).
J99-4004
In the parsing community, new algorithms are often stated simply as a set of deductive inference rules (Sikkel, 1997; Eisner and Satta, 1999).
P99-1059
Charniak. 1998.
W98-1115
Our approach may be most closely related to deductive databases, which even in their heyday were apparently ignored by the CL community (except for Minnen, 1996).
P96-1033
As an object-oriented C++ library, it also facilitates rapid implementation of new estimation techniques (Smith and Eisner, 2004; Smith and Eisner, 2005).
H05-1060 P04-1062 P04-3032 P05-1044 W04-3207 W05-1504
Some of the wellknown CL papers, notably Goodman (1999), were already mentioned in section 1.1.
J99-4004
Note also that a’s own value (Nederhof, 2003) might not be an optimistic estimate, if negative weights are present.
J03-1006
Goodman’s (1999) strategy of building all items and sorting them before computing any weights is wise only if one genuinely wants to build all items.
J99-4004
Melamed. 2003.
N03-1021
Klein and Manning (2003a) went on to describe admissible heuristics and an A* framework for parsing.
N03-1016 P03-1054
The A* heuristics explored by Klein and Manning (2003a) can be seen as resulting from bounding transformations.
N03-1016 P03-1054
programming as deduction The “parsing as deduction” framework (Pereira and Warren, 1983) is now over 20 years old.
P83-1021
Minnen. 1996.
P96-1033
Eisner. 2004.
P04-3032
Nederhof (2003) considers only max= with a uniform-cost agenda discipline (see §4.5), which guarantees that no item will be removed more than once from the agenda.
J03-1006
Magic templates introduce top-down filtering into the search strategy and can be used to derive Earley’s algorithm (Minnen, 1996), to introduce left-corner filters, and to restrict FSM constructions to build only accessible states.
P96-1033
These techniques included unweighted FS morphology, conditional random fields (Lafferty et al., 2001), synchronous parsers (Wu, 1997; Melamed, 2003), lexicalized parsers (Eisner and Satta, 1999),22 partially supervised training `a la (Pereira and Schabes, 1992),23 and grammar induction (Klein and Manning, 2002).
J97-3002 N03-1021 P02-1017 P92-1017 P99-1059
We implement the agenda as a priority queue whose priority function may be specified by the user.15 Charniak et al.(1998) and Caraballo and Charniak (1998) showed that, when seeking the best parse (using min= or max=), best-first parsing can be extremely effective.
J98-2004 W98-1115
1). Accordingly, heterogeneous Dyna programs, to be supported soon by our compiler, will allow items of different types to have values of different types, computed by different aggregation operations over arbitrary right-hand-side ex3Previous treatments of weighted deduction have used an agenda only for an unweighted parsing phase (Goodman, 1999) or for finding the single best parse (Nederhof, 2003).
J03-1006 J99-4004
