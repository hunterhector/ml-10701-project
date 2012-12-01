(Vijay-Shanker, 1992)).
J92-4004
Following (Stone and Doran, 1997), we represent meaning using a flat semantic representation, i.e. as multisets, or conjunctions, of non-recursive propositions.
P97-1026
D-Tree Grammar (DTG) is proposed in (Rambow et al., 1995) to remedy some empirical and theoretical shortcomings of TAG; Tree Description Grammar (TDG) is introduced in (Kallmeyer, 1999) to support syntactic and semantic underspecification and Interaction Grammar is presented in (Perrier, 2000) as an alternative way of formulating linear logic grammars.
C00-2087 P95-1021
5.1 Bottom-Up Generation Bottom-up or “lexically-driven” generators (e.g., (Shieber, 1988; Whitelock, 1992; Kay, 1996; Carroll et al., 1999)) start from a bag of lexical items with instantiated semantics and generates a syntactic tree by applying grammar rules whose right hand side matches a sequence of phrases in the current input.
C88-2128 C92-2117 P96-1027
And (Poznanski et al., 1995) make use of a tree reconstruction method which incrementally improves the syntactic tree until it is accepted by the grammar.
P95-1035
In (Shieber, 1988), a chart-based bottom-up generator is presented which is devoid of an indexing scheme: all word edges leave and enter the same vertex and as a result, interactions must be considered explicitly between new edges and all edges currently in the chart.
C88-2128
As (Shieber, 1988) showed, the problem with such words is that they cannot be selected on the basis of the input semantics.
C88-2128
In this sense, it is not unlike (Shieber et al., 1990)’s semantic-head-driven generation.
J90-1004
5.2 Top-Down Generation As shown in detail in (Shieber et al., 1990), topdown generators can fail to terminate on certain grammars because they lack the lexical information necessary for their well-foundedness.
J90-1004
(Brew, 1992) combines a constraint-propagation mechanism with a shift-reduce generator, propagating constraints after every reduction step.
C92-2092
(Kay, 1996)) is to index edges with semantic indices (for instance, the edge with category N/x:dog(x) will be indexed with x) and to restrict edge combination to these edges which have compatible indices.
P96-1027
Further, (Duchier and Thater, 1999) shows that this model generator can be used to parse with descriptions based grammars (Rambow et al., 1995; Kallmeyer, 1999) that is, on logic based grammars where lexical entries are descriptions of trees expressed in some tree logic.
P95-1021
