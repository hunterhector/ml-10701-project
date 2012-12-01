Bunescu and Mooney (2005) have also demonstrated that dependency graphs can be produced using Combinatory Categorial Grammar (CCG) and context-free grammar (CFG) parsers.
H05-1091
Previous work which has used this representation have used indirect evaluation: document and sentence filtering (Yangarber, 2003; Stevenson and Greenwood, 2005).
P03-1044 P05-1047
Dependency Patterns Three dependency parsers were used for these experiments: MINIPAR3 (Lin, 1999), the Machinese Syntax4 parser from Connexor Oy (Tapanainen and J¨arvinen, 1997) and the Stanford5 parser (Klein and Manning, 2003).
A97-1011 P03-1054
Sudo et al.(2003) compared three models in terms of their ability to identify event participants.
P03-1029
2The formalism used for representing dependency patterns is similar to the one introduced by Sudo et al.(2003). Each node in the tree is represented in the format a[b/c] (e.g.
P03-1029
Predicate-Argument Model (SVO): A simple approach, used by Yangarber (2003) and Stevenson and Greenwood (2005), is to use subject-verbobject tuples from the dependency parse as extraction patterns.
P03-1044 P05-1047
This has implications on the practical application for each approach, particularly when used for automatic acquisition of IE systems using learning methods (Yangarber et al., 2000; Sudo et al., 2003; Bunescu and Mooney, 2005).
C00-2136 H05-1091 P03-1029 P03-1044
This model may be motivated by the assumption that many IE scenarios involve the extraction 1Yangarber et al.(2000) and Sudo et al.(2003) used a slightly extended version of this model in which the pattern also included certain phrases which referred to either the subject or object.
C00-2136 P03-1029 P03-1044
For example, the AutoSlog system (Riloff, 1993) uses patterns which match certain grammatical categories, mainly nouns and verbs, in phrase chunked text while Yangarber et al.(2000) use subject-verbobject tuples derived from a dependency parse.
C00-2136
Subtrees: The final model to be considered is the subtree model (Sudo et al., 2003).
P03-1029
Chains: A pattern is defined as a path between a verb node and any other node in the dependency tree passing through zero or more intermediate nodes (Sudo et al., 2001).
H01-1009
For example, Yangarber (2003) uses just subject-verb-object tuples while Sudo et al.(2003) allow any subpart of the tree to act as an extraction pattern.
P03-1029 P03-1044
Several recent approaches to IE have used patterns based on a dependency analysis of the input text (Yangarber, 2003; Sudo et al., 2001; Sudo et al., 2003; Bunescu and Mooney, 2005; Stevenson and Greenwood, 2005).
H01-1009 H05-1091 P03-1029 P03-1044 P05-1047
The results presented here suggest that the Stanford parser (Klein and Manning, 2003) is capable of generating analyses for almost all sentences within corpora from two very different domains.
P03-1054
