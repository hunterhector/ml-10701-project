To overcome its limitation to one-place predicates, Dale and Haddock (1991) introduced a constraint-based procedure that could generate referring expressions involving relations; and as a response to the computational complexity of ‘greedy’ algorithms like FB, Reiter and Dale (Reiter and Dale, 1992; Dale and Reiter, 1995) introduced the psycholinguistically motivated Incremental Algorithm (IA).
C92-1038 E91-1028
Extend Description (w.r.t the chosen p) Pr ← Pr −{p} p ← [r\v]p for every other constant r’ in p do associate rprime with a new, unique variable vprime p ← [rprime\vprime]p push Describe(r’,v’) onto Stack initialise a set Pprimer of facts true of rprime N ← N ⊕p goto Step 1 Algorithm 2: The Relational Algorithm MakeReferringExpression(r, C, P) L ←{} for each member Ai of list P do V = FindBestValue(r, Ai, BasicLevelValue(r, Ai)) if RulesOut(〈Ai, V〉) negationslash= nil then L ← L∪{〈Ai,V〉} C ←C − RulesOut(〈Ai, V〉) endif if C = {} then if 〈type, X〉∈L for some X then return L else return L∪{〈type, BasicLevelValue(r, type)〉} endif endif return failure FindBestValue(r, A, initial-value) if UserKnows(r, 〈A, initial-value〉) = true then value ← initial-value else value ← no-value endif if (more-specific-value ← MoreSpecificValue(r, A, value)) negationslash= nil ∧ (new-value ← FindBestValue(A, more-specific-value)) negationslash= nil ∧ (|RulesOut(〈A, new-value〉)|>|RulesOut(〈A, value〉)|) then value ← new-value endif return value RulesOut(〈A, V〉) if V = no-value then return nil else return {x : x ∈ C ∧ UserKnows(x, 〈A, V〉) = false} endifAlgorithm 3: The Incremental Algorithm 66 • The relational algorithm from (Dale and Haddock, 1991) uses constraint satisfaction to incorporate relational properties while avoiding infinite regress; see Algorithm 2.
E91-1028
We focus here on the following algorithms: • The Full Brevity algorithm (Dale, 1989) attempts to build a minimal distinguishing description by always selecting the most discriminatory property available; see Algorithm 1.
P89-1009
63 presented in (Dale, 1989), (Dale and Haddock, 1991) and (Reiter and Dale, 1992), we explore how well these algorithms perform in the same context.
C92-1038 E91-1028 P89-1009
The task is discussed informally in some of the earliest work on NLG (in particular, see (Winograd, 1972; McDonald, 1980; Appelt, 1981)), but the first formally explicit algorithm was introduced in (Dale, 1989); this algorithm, often referred to as the Full Brevity (FB) algorithm, has served as a starting point for many subsequent GRE algorithms.
P89-1009
We are currently exploring whether Krahmer et al’s (2003) graph-based approach to GRE is able to provide a better coverage of the data: this algorithm provides the ability to make use of different search strategies and weighting mechanisms when adding properties to a description, and such a mechanism might be used, for example, to counterbalance the Relational Algorithm’s heavy bias towards the relations in this domain.
J03-1003
• the Incremental Algorithm (Reiter and Dale, 1992; Dale and Reiter, 1995) considers the available properties to be used in a description via a preference ordering over those properties; see Algorithm 3.
C92-1038
The Context-Sensitive extension (Krahmer and Theune, 2002) is able to generate referring expressions for the most salient entity in a context; the Boolean Expressions algorithm (van Deemter, 2002) is able to derive expressions containing boolean operators, as in the cup that does not have a handle; and the Sets algorithm (van Deemter, 2002) extends the basic approach to references to sets, as in the red cups.
J02-1003
Some approaches reuse parts of other algorithms: the Branch and Bound algorithm (Krahmer et al., 2003) uses the Full Brevity algorithm, but is able to generate referring expressions with both attributes and relational descriptions using a graph-based technique.
J03-1003
Focussing specifically on the algorithms 1The only exceptions we know of to this deficit are not directly concerned with the kinds of properties people select, but with phenomena such as how people group entities together (Funakoshi et al., 2004; Gatt, 2006), or with multimodal referring expressions where the linguistic part is not necessarily distinguishing by itself (van der Sluis and Krahmer, 2004).
E06-1041
Some authors, for example (van Deemter and Halld´orsson, 2001), have suggested that human-produced descriptions are often not minimal, and this is an intuition that we would generally agree with.
W01-0804
The major exceptions here may be (a) van Deemter’s (2002) algorithm for sets; recall that we excluded from the human data used here 16 references that involved sets; and, as noted above, (b) Krahmer et al’s (2003) graph-based approach to GRE, which may perform better than the Relational Algorithm on descriptions using relations.
J02-1003 J03-1003
There are many other algorithms described in the literature: see, for example, (Horacek, 1997; Bateman, 1999; Stone, 2000; Gardent, 2002).
P02-1013 P97-1027 P99-1017 W00-1416
The only algorithm of those we examine here that provides a mechanism for exploring a generalisation hierarchy is the Incremental Algorithm (Reiter and Dale, 1992), and this cannot handle relations; so, we take the shortcut of explicitly representing the next-to relation for every left-of and right-of relation in the knowledge base.
C92-1038
