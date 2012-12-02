In our earlier work (Carberry 1985, 1989), we claimed that a cooperative participant must accept a response or pursue discourse goals directed toward being able to accept the response.
J89-2001 P85-1024
We have expanded on Litman and Allen's (1987) notion of constraint satisfaction and Allen and Perrault's (1980) use of beliefs.
J80-3003
Walker (1992) has found many occasions of redundancy in collaborative dialogues, and explains these by claiming that people repeat themselves in order to ensure that each utterance has been understood.
C92-1054
Discourse Acts by Chaining Our process model starts with the semantic representation of a new utterance and uses plan inference rules (Allen and Perrault 1980; Carberry 1988) along with constraint satisfaction (Litman and Allen 1987) to hypothesize chains of actions A1,A2.....
J80-3003 J88-3003
Thus, since a communicated proposition is presumed to be relevant to this plan construction process, the dialogue participants are obligated to communicate as soon as possible any discrepancies in belief about such propositions (Walker and Whittaker 1990; Chu-Carroll and Carberry 1995b) and to enter into a negotiation subdialogue in which they attempt to "square away" (Joshi 1982) their disparate beliefs.
P90-1010 P95-1019
43 Computational Linguistics Volume 25, Number 1 Initial work on this component includes a subsystem that can identify what evidence to present to a user when conflicts arise (Chu-Carroll and Carberry 1995b, 1998) and what information to request when the system cannot rationally decide whether to accept a proposition conveyed by the user (Chu-Carroll and Carberry 1995a, 1998).
J98-3002 P95-1019
Recipes In previous work, we noted the need to differentiate among domain, problem-solving, and discourse actions (Lambert and Carberry 1991; Elzer 1995).
P91-1007
Allen and Perrault (1980) noted the need to represent an agent's wanting to know the referent of a term in a proposition, without having to specify what that referent was.
J80-3003
Clark and Schaeffer (1989) discuss second, third, and fourth turn repairs in discourse, and McRoy and Hirst (1995) provide an excellent formal model of repair in dialogue.
J95-4001
A different approach would be to maintain such knowledge about adjacency pairs (Schegloff and Sachs 1973) and expected continuations in a transition network separate from the discourse recipes, as was done by Reithinger and Maier (1995).
P95-1016
Grosz, Lochbaum, and Sidner (Grosz and Sidner 1990; Lochbaum, Grosz, and Sidner 1990; Lochbaum 1991) have specified a system in which two agents are working to accomplish some common goal by building a "shared plan" in which each agent holds certain beliefs and intentions.
P91-1005
Walker (1991, 1992) has examined dialogues in which people repeat what they already know either in question or statement form (e.g., "I have four children".
C92-1054
Similarly, if a listener does not believe a communicated proposition, he must convey this disagreement as soon as possible (Walker and Whittaker 1990).
P90-1010
21 Due to length restrictions, we have omitted a part of the algorithm that deals with focusing heuristics that are not needed for the kinds of utterances addressed in this paper; an example of utterances needing the full algorithm is given in Lambert and Carberry (1991).
P91-1007
The Process Model Grosz and Sidner (1986) claim that a robust model of understanding must use multiple knowledge sources in order to recognize the complex relationships that utterances have to one another.
J86-3001
All of these models indicate the need for modeling collaborative dialogue, but none suggests a system that can handle the 29 Another reason for repetition, she claims, is for centering (Grosz, Joshi, and Weinstein 1995), but she concentrates on repetitions that give evidence of understanding.
J95-2003
A number of researchers (Reichman 1978, 1985; Grosz and Sidner 1986; Polanyi 1986; Cohen 1987; Hirschberg and Litman 1987; Litman and Allen 1987; Schiffrin 1987; Hinkelman 1989; Litman and Hirschberg 1990; Knott and Dale 1994; Knott and Mellish 1996; Marcu 1997) have investigated the use in discourse of special words and phrases such as but, anyway, and by the way.
C90-2044 J86-3001 J87-1002 P87-1023 P89-1026 P97-1013
Other collaborative models assume that two participants are working together to achieve a common goal (Cohen and Levesque 1990a, 1991a, 1991b; Lochbaum, Grosz, and Sidner 1990; Lochbaum 1991; Grosz and Sidner 1990; Searle 1990).
P91-1005
23 Although CA can provide background information prior to conveying the proposition about which the background is being given, the Give-Background action in these instances will be recognized in assimilating CA's second utterance (the utterance about which the background is being given) (Lambert and Carberry 1991).
P91-1007
and Lambert Modeling Negotiation Subdialogues Galliers (1991, 1992) has specified a nonnumeric theory of belief revision that relates strength of belief to persistence of belief.
P91-1007 P92-1025
44 Carberry and Lambert Modeling Negotiation Subdialogues their minds (Flowers, McGuire, and Birnbaum 1982; Quilici 1991).
P91-1007
Since this paper is concerned almost exclusively with the discourse level of the dialogue model, we will not discuss the overall tripartite model further, except to note that the construction of a new discourse tree requires that the system identify its relationship to existing or new actions at the problem-solving and domain levels (Lambert and Carberry 1991).
P91-1007
7. Other Related Work 7.1 Grosz and Sidner's Theory of Discourse Processing Grosz and Sidner (1986) postulated a theory of discourse structure that included linguistic, intentional, and attentional components, and they argued that the dominance and satisfaction-precedes relationships between discourse segments must be identified in order to determine discourse structure.
J86-3001
Domain and problemsolving actions have been investigated by many researchers (Allen and Perrault 1980; Perrault and Allen 1980; Wilensky 1981; Litman and Allen 1987; van Beek and Cohen 1986; Ramshaw 1989; Carberry 1990).
C90-2044 E89-1005 J80-3003
The applicability conditions of the Obtain-Info-Ref act, such as the condition that _agent1 believe that _agent2 knows the information, are based on criteria identified in Searle (1970), Cohen and Perrault (1979), and Allen and Perrault (1980).
J80-3003
Understanding Systems Several researchers have built argument understanding systems, but none has addressed participants coming to an agreement or mutual belief about a particular situation, either because the researchers investigated monologues only (Cohen 1987; Cohen and Young 1991), or because they assumed that dialogue participants do not change 28 In a dialogue, Grosz and Sidner's discourse segment purpose is intended to capture the purpose of a segment consisting of a series of utterances by both participants, not the communicative intentions underlying each participant's discourse actions.
J87-1002
The bodies of our discourse recipes are based on work by other researchers (Allen and Perrault 1980; Searle 1970; Cohen and Perrault 1979), dialogues in which we have participated, the naturally occurring dialogues that we examined, and our hypotheses about how our system might be expanded in the future.
J80-3003
Cohen (1987) developed an argument understanding system that used clue words and an evidence oracle to build a discourse structure for arguments based on which utterances served as support for other utterances.
J87-1002
Our system for recognizing complex discourse acts and handling negotiation subdialogues has been integrated into the tripartite dialogue model presented in Lambert and Carberry (1991).
P91-1007
Grosz and Sidner (1986) claim that when evidence is available from one source, less evidence should be required from others.
J86-3001
This claim is supported by a combination of 1) the stack paradigm (Polanyi 1986; Reichman 1978; Grosz and Sidner 1986; Litman and Allen 1987), which treats topic structure as following a stack-like discipline; 2) focusing heuristics (McKeown 1983) that suggest that if a speaker has more to say about a topic, then he should do so before moving back to a topic deeper on the stack; and 3) the notion of implicit acceptance (discussed in Section 4.6) that argues that passing up the opportunity to reject an assertion in a collaborative dialogue communicates acceptance of it.
J86-3001
The effect of an Inform act in Allen and Perrault's system (Allen and Perrault 1980) is that the hearer believes the communicated proposition--this definition would seem to say that the hearer always accepts the information provided by the speaker.
J80-3003
