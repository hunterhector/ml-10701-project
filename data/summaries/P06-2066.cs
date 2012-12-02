508 3 Relaxations of projectivity While the restriction to projective analyses has a number of advantages, there is clear evidence that it cannot be maintained for real-world data (Zeman, 2004; Nivre, 2006).
E06-1010
As a general result, our experiments confirm previous studies on non-projective dependency parsing (Nivre and Nilsson, 2005; Hall and Novák, 2005; 512 McDonald and Pereira, 2006): The phenomenon of non-projectivity cannot be ignored without also ignoring a significant portion of real-world data (around 15a37for DDT, and 23a37for PDT).
E06-1010 E06-1011 P05-1013 W05-1505
Nivre (2006) shows experimentally that limiting the permissible edge degree to 1 or 2 can reduce the average parsing time for a deterministic algorithm from quadratic to linear, while omitting less than 1a37 of the structures found in DDT and PDT.
E06-1010
Dependency-based representations have become increasingly popular in syntactic parsing, especially for languages that exhibit free or flexible word order, such as Czech (Collins et al., 1999), Bulgarian (Marinov and Nivre, 2005), and Turkish (Eryi˘git and Oflazer, 2006).
E06-1010 P05-1013 P99-1065
509 j i1 2 3 5 64 (a) gd D 0, ed D 0, wnC (b) gd D 1, ed D 1, wnC j i1 2 3 5 64 (c) gd D 2, ed D 1, wnNUL Figure 3: Gap degree, edge degree, and well-nestedness 3.3 Edge degree The notion of edge degree was introduced by Nivre (2006) in order to allow mildly non-projective structures while maintaining good parsing efficiency in data-driven dependency parsing.2 Define the span of an edge .i;j/ as the interval S..i;j// WD Œmin.i;j/;max.i;j/c141: Definition 9 Let G D .V I E/ be a dependency forest, let e D .i;j/ be an edge in E, and let Ge be the subgraph of G that is induced by the nodes contained in the span of e.
E06-1010
A dependency tree is acceptable, if it can be lifted to form a projective graph.3 A similar design is pursued in Topological Dependency Grammar (Duchier and Debusmann, 2001), where a dependency analysis consists of two, mutually constraining graphs: the ID graph represents information about immediate dominance, the LP graph models the topological structure of a sentence.
P01-1024
The non-projective dependency grammar of Kahane et al.(1998) is based on an operation on dependency trees called lifting: a ‘lift’ of a tree T is the new tree that is obtained when one replaces one 2We use the term edge degree instead of the original simple term degree from Nivre (2006) to mark the distinction from the notion of gap degree.
E06-1010 P98-1106
The projectivity constraint also leads to favourable parsing complexities: chart-based parsing of projective dependency grammars can be done in cubic time (Eisner, 1996); hard-wiring projectivity into a deterministic dependency parser leads to linear-time parsing in the worst case (Nivre, 2003).
C96-1058
However, recent results in non-projective dependency parsing, especially using data-driven methods, indicate that most non-projective structures required for the analysis of natural language are very nearly projective, differing only minimally from the best projective approximation (Nivre and Nilsson, 2005; Hall and Novák, 2005; McDonald and Pereira, 2006).
E06-1010 E06-1011 P05-1013 W05-1505
1 2 3 5 64 7 8 Není proto zapotřebí uzavírat nové nájemní smlouvy . contractsleasenewsignneededis-not therefore . ‘It is therefore not needed to sign new lease contracts.’ Figure 1: Dependency forest for a Czech sentence from the Prague Dependency Treebank Some authors extend dependency forests by a special root node with position 0, and add an edge .0;i/ for every root node i of the remaining graph (McDonald et al., 2005).
H05-1066
In particular, chart-based parsers for grammar formalisms in which derivations obey the well-nestedness constraint (such as Tree Adjoining Grammar) are not hampered by the ‘crossing configurations’ to which Satta (1992) attributes the fact that the universal recognition problem of Linear Context-Free Rewriting Systems isNP-complete.
P92-1012
