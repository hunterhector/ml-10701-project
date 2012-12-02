Similarly to our approach, Webber et al.(1999) investigated informational coherence relations.
P99-1006
Note that there seems to be a problem with the definition of “structural” versus “nonstructural” discourse structure in Webber et al.(1999): According to Webber et al.(1999), nonstructural discourse relations are licensed by anaphoric relations and can be involved in crossed dependencies.
P99-1006
262 Wolf and Gibson Representing Discourse Coherence Some accounts of informational discourse structure do not assume tree structures (e.g., Bergler [1991] and Hobbs [1985] for monologue and Penstein Rose et al.[1995] for dialogue structure).
E91-1038
Going beyond the question of how different informational-level accounts can be compatible with each other, Moser and Moore (1996) discuss the compatibility of rhetorical structure theory (RST) (Mann and Thompson 1988) with the theory of Grosz and Sidner (1986).
J86-3001 J96-3006
It is unclear, however, why Webber et al.(2003) allow one kind of tree constraint violation (nodes with multiple parents) but not another (crossed dependencies).
J03-4002
Future research should investigate questions such as whether there are structural constraints on coherence graphs (e.g., as proposed by Danlos [2004]) or whether there are systematic structural differences between the coherence graphs of texts that belong to different genres (e.g., as proposed by Bergler [1991]).
E91-1038 W04-2324
However, note that Moser and Moore (1996) focus on the question of how compatible the claims are that Mann and Thompson (1988) and Grosz and Sidner (1986) make about intentional-level discourse structure.
J86-3001 J96-3006
In order to accommodate violations of tree structure constraints (in particular, crossed dependencies), Webber et al.(1999) argue for a distinction between “structural” discourse relations, on the one hand, and “nonstructural” or “anaphoric” discourse relations on the other hand.
P99-1006
Whereas some argue that discourse segments should be prosodic units (Hirschberg and Nakatani 1996), others argue for intentional units (Grosz and Sidner 1986), phrasal units (Lascarides and Asher 1993; Longacre 1983; Webber et al.1999), or sentences (Hobbs 1985).
J86-3001 P96-1038 P99-1006
However, more recently, Webber et al.(2003) have argued that structural discourse structure should allow nodes with multiple parents, but no crossed dependencies.
J03-4002
This appears to be a crucial difference between approaches like Knott’s (1996), Marcu’s (2000), or Webber et al.’s (2003), on the one hand, and our approach, on the other hand.
J03-4002
Moore and Pollack (1992), Moser and Moore (1996), and Reichman (1985) argue that trees are insufficient for representing informational, intentional, and attentional discourse structure.
J92-4007 J96-3006
Examples of such accounts include Webber et al.(1999) and Knott (1996).
P99-1006
Lascarides and Asher (1991) do not explicitly disallow crossed dependencies, they argue that when a discourse structure is being constructed, the right frontier of an already existing discourse structure is the only possible attachment point for a new incoming discourse segment (cf.
P91-1008
Data Structures for Representing Coherence Relations In order to represent the coherence relations between discourse segments in a text, most accounts of discourse coherence assume tree structures (Britton 1994; Carlson, Marcu, and Okurowski 2002; Corston-Oliver 1998; Longacre 1983; Grosz and Sidner 1986; Mann and Thompson 1988; Marcu 2000; Polanyi and Scha 1984; Polanyi 1996; Polanyi et al.2004; van Dijk and Kintsch 1983; Walker 1998); some accounts do not allow crossed dependencies but appear to allow nodes with multiple parents (Lascarides and Asher 1991).
J86-3001 P84-1085 P91-1008 W04-2322
[Bergler 1991] for a more detailed semantic analysis of attribution relations): (15) Attribution 1.
E91-1038
Brants et al.2002; Skut et al.1997; K¨onig and Lezius 2000).
A97-1014
In order to determine interannotator agreement for step 2 of the coding procedure for the database of annotated texts, we calculated kappa statistics (Carletta 1996).
J96-2004
also Polanyi 1996; Polanyi and Scha 1984; Webber et al.1999). This constraint on building discourse structures effectively disallows crossed dependencies.
P84-1085 P99-1006
For example, Moore and Pollack (1992) point out that rhetorical structure theory (Mann and Thompson 1988) has both informational and intentional coherence relations but then forces annotators to decide on only one coherence relation between any two discourse segments.
J92-4007
Some accounts aim to represent the intentional-level structure of a discourse; in these accounts, coherence relations reflect how the role played by one discourse segment with respect to the interlocutors’ intentions relates to the role played by another segment (e.g., Grosz and Sidner 1986).
J86-3001
Grosz and Sidner 1986), which Knott argues are less constrained, than in terms of rhetorical relations (cf.
J86-3001
Knott (1996) might provide a way to empirically formalize the claims in Webber et al.(1999), or at least claims that seem to be very similar to those in Webber et al.(1999): Based on the observation that he cannot identify characteristic cue phrases for elaboration relations (e.g., because would be a characteristic cue phrase for cause–effect), Knott argues that elaboration relations are more permissive than other types of coherence relations (e.g., cause–effect, similarity, contrast).
P99-1006
Other accounts aim to represent the informational structure of a discourse; in these accounts, coherence relations reflect how the meaning conveyed by one discourse segment relates to the meaning conveyed by another discourse segment (e.g., Hobbs 1985; Marcu 2000; Webber et al.1999). Furthermore, accounts of discourse structure vary greatly with respect to how many discourse relations they assume, ranging from 2 (Grosz and Sidner 1986) to over 400 different coherence relations (reported in Hovy and ∗ Computer Laboratory and Genetics Department, Cambridge, CB3 0FD, U.K.
J86-3001 P99-1006
accounts assume less constrained graphs that allow crossed dependencies as well as nodes with multiple parents (e.g., Bergler 1991; Birnbaum 1982; Danlos 2004; Hobbs 1985; McKeown 1985; Reichman 1985; Zukerman and McConachy 1995; for dialogue structure, Penstein Rose et al.1995). Some proponents of tree structures assume that trees are easier to formalize and to derive than less constrained graphs (Marcu 2000; Webber et al.2003). We demonstrate that in fact many coherence structures in naturally occurring texts cannot be adequately represented by trees.
E91-1038 J03-4002 W04-2324
One group tries to formulate principles that allow representation of some aspects of structure in the tree itself and other aspects in some augmentation formalism (e.g., Chomsky 1973; Marcus et al.1994). Another group argues that it is more parsimonious to assume a unified dependency-based representation that drops the tree constraints of allowing no crossed dependencies (e.g., Brants et al.2002; Skut et al.1997; K¨onig and Lezius 2000).
A97-1014 H94-1020
Unlike approaches such as the TextTiling algorithm (Hearst 1997), ours allowed partially overlapping groups of discourse segments.
J97-1003
However, Webber et al.(1999) also argue that one criterion for nonstructural coherence relations is that they can cross (non)structural coherence relations.
P99-1006
