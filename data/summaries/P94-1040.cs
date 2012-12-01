Moore & Dowding, 1991).
H91-1036
Tomita, 1987; Wright, Wrigley & Sharman, 1991), and in the light of improvements observed for predictive over pure bottom-up parsing (e.g.
J87-1004
THE COMPILED-EARLEY PARSER The Compiled-Earley (CE) parser is based on a predictive chart-based CF parsing algorithm devised by Schabes (1991) which is driven by a table compiling out the predictive component of Earley's (1970) parser.
P91-1014
Briscoe (1993) The Alvey natural language tools grammar (~th release).
J93-1002
Tomabechi, 1991) in systems using lexicalist grammar formalisms (e.g.
P91-1041
In this parser, the LALR(1) technique (Aho, Sethi Ullman, 1986) is used, in conjunction with a graph-structured stack (Tomita, 1987), adapting for unification-based parsing Kipps' (1989) Tomita-like recogniser that achieves polynomial complexity on input length through caching.
J87-1004
Evaluations of the grammars in these particular systems have shown them to have wide coverage (Alshawi et al., 1992; Taylor, Grover &= Briscoe, 1989) 2.
E89-1035
4. PRACTICAL RESULTS To assess the practical performance of the three unification-based parsers described above, a series of experiments were conducted using the ANLT grammar (Grover, Carroll & Briscoe, 1993), a wide-coverage grammar of English.
J93-1002
2. THE PARSERS The three parsers in this study are: a bottomup left-corner parser, a (non-deterministic) LR parser, and an LR-like parser based on an algorithm devised by Schabes (1991).
P91-1014
Previous comparisons have either focussed on context-free (CF) or augmented CF parsing (Tomita, 1987; Billot & Lang, 1989), or have used relatively small, limited-coverage unification grammars and lexicons (Shann, 1989; Bouma & van Noord, 1993; Maxwell & Kaplan, 1993).
E93-1010 J87-1004
In previous work with the ANLT (Briscoe & Carroll, 1993), throughput with raw corpus data was worse than that observed in these experiments, though probably only by a constant factor.
J93-1002
6. CONCLUSIONS The research reported is in a similar vein to that of, for example, Moore & Dowding (1991), Samuelsson & Rayner (1991), and Maxwell & Kaplan (1993), in that it relies on empirical results for the study and optimisation of parsing algorithms rather than on traditional techniques of complexity analysis.
H91-1036
THE NON-DETERMINISTIC LR PARSER Briscoe & Carroll (1993) describe a methodology for constructing an LR parser for a unificationbased grammar, in which a CF 'backbone' grammar is automatically constructed from the unification grammar, a parse table is constructed from the backbone grammar, and a parser is driven by the table and further controlled by unification of the 'residue' of features in the unification grammar that are not encoded in the backbone.
J93-1002
Alshawi et al., 1992; Briscoe & Carroll, 1993).
J93-1002
Although Schabes (1991:107) claims that the problem of exponential grammar complexity "is particularly acute for natural language processing since in this context the input length is typically small (10-20 words) and the grammar size very large (hundreds or thousands of rules and symbols)", the experiments indicate that, with a widecoverage NL grammar, inputs of this length can be parsed quite quickly; however, longer inputs (of more than about 30 words in length)--which occur relatively frequently in written text--are a problem.
P91-1014
The parsers create parse forests (Tomita, 1987) that incorporate subtree sharing (in which identical sub-analyses are shared between differing superordinate analyses) and node packing (where subanalyses covering the same portion of input whose root categories are in a subsumption relationship are merged into a single node).
J87-1004
aSchabes describes a table with no lookahead; the successful application of this technique supports Schabes' (1991:109) assertion that "several other methods (such as LR(k)-like and SLR(k)-like) can also be used for constructing the parsing tables \[...\]" aBarton, Berwick & Ristad (1987:221) calculate that GPSG, also with a maximum nesting depth of two, licences more than 10 rr5 distinct syntactic categories.
P91-1014
