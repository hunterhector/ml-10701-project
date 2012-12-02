In the latter technique, sometimes known as cascaded ATNs (Woods 1980), the syntactic and semantic parts of the grammar are kept separate, thus giving the potential for a higher degree of interpretiveness in using the semantic information.
J80-1001
Hayes, P.J. and Mouradian, G.V. 1981 Flexible Parsing.
J81-4002 P81-1033
Hayes, P.J. 1984 Entity-Oriented Parsing.
P84-1047
Our earliest experiments in robust parsing were conducted through the FlexP parsing system (Hayes and Mouradian 1981).
J81-4002 P81-1033
3.5.1. Recovery strategies using a transition network approach Although attempts have been made to incorporate sentential level recovery strategies into network-based parsers including both syntactically-based ATNs (Kwasny and Sondheimer 1981, Weischedel and Sondheimer 1984, Weischedel and Black 1980, Woods et al.1976) and semantic grammar networks (Hendrix 1977), the network paradigm itself is not well suited to the kinds of recovery strategies discussed in the preceding sections.
J81-2002
Indeed, many of our ideas on the importance of those characteristics were developed though observation of FlexP's shortcomings as described in 3.5.2, and more fully in Hayes and Carbonell (1981).
J81-4002 P81-1033
Hayes, P.J. and Carbonell, J.G. 1981 Multi-strategy ConstructionSpecific Parsing for Flexible Data Base Query and Update.
J81-4002 P81-1033
Our initial experiments in realizing these advantages were conducted through the CASPAR parser (Hayes and Carbonell 1981).
J81-4002 P81-1033
One alternative we have begun to explore involves the idea of entity-oriented parsing (Hayes 1984).
P84-1047
As demonstrated by the meta-rule approach to diagnosing parse failures described by Weischedel and Sondheimer (1983) elsewhere in this journal issue, these and other difficulties elaborated below do not preclude recovery from extragrammatical input.
J83-3003
Hayes, P.J. 1981 A Construction Specific Approach to Focused Interaction in Flexible Parsing.
J81-4002 P81-1033
Hayes, P.J. and Carbonell, J.G. 1981 Multi-Strategy Parsing and its Role in Robust Man-Machine Communication.
J81-4002 P81-1033
As Hayes and Carbonell (1981) show, parsers based on case frame instantiation are particularly well suited to generating ambiguity representations of this kind.
J81-4002 P81-1033
Probably the most popular approach has been to extend syntactically-oriented parsing techniques employing Augmented Transition Networks (ATNs) (Kwasny and Sondheimer 1981, Weischedel and Sondheimer 1984, Weischedel and Black 1980, Woods et al.1976). Other researchers have attempted to deal with ungrammatical input through network-based semantic grammar techniques (Hendrix 1977), through extensions to pattern matching parsing in which partial pattern matching is allowed (Hayes and Mouradian 1981), through conceptual case frame instantiation (Dejong 1979, Schank, Lebowitz, and Birnbaum 1980), and through approaches involving multiple cooperating parsing strategies (Carbonell and Hayes 1984, Carbonell et al.1983, Hayes and Carbonell 1981).
J80-1002 J81-2002 J81-4002 P81-1033 P84-1047
It is possible to accept any permutation of elements of a pattern as a match, but this provides so much flexibility that many spurious recognitions are likely to be obtained as well as the correct ones (see Hayes and Mouradian 1981).
J81-4002 P81-1033
Carbonell, J.G. and Hayes, P.J. 1984 Robust Parsing Using Multiple Construction-Specific Strategies.
P84-1047
So, for instance, such techniques are likely to be more effective using a semantic grammar (Hendrix 1977, Brown and Burton 1975) or case frame instantiation (Dejong 1979, Hayes and Carbonell 1981) approach, than in an approach using a syntactic ATN (Woods, Kaplan and Nash-Webber 1972), where the expectations are never more specific than membership in one or more general syntactic categories.
J81-4002 P81-1033
Weischedel, R.M. and Sondheimer, N.K. 1983 Meta-Rules as a Basis for Processing Ill-formed Input.
J83-3003
Even assuming that the above example had a unique result, since it involved several significant assumptions, we would need to use focused interaction techniques (Hayes 1981) to present a paraphrase of our interpretation to the user for approval before acting on it.
J81-4002 P81-1033
Kwasny, S.C. and Sondheimer, N.K. 1981 Relaxation Techniques for Parsing Grammatically Ill-Formed Input in Natural Language Understanding Systems.
J81-2002
See Hayes and Carbonell (1981) for a fuller discussion of this point.
J81-4002 P81-1033
In the first situation, there is no meaningful recovery strategy other than focused interaction (Hayes 1981) to inform the user of the precise difficulty.
J81-4002 P81-1033
This process is also responsible for noticing when information is either missing or ambiguously determined, thereby initiating a focused clarificational dialogue (Hayes 1981).
J81-4002 P81-1033
