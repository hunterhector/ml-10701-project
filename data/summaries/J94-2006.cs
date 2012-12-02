In particular, centering literature (Grosz, Joshi, and Weinstein 1983) questioned Sidner's use of an Actor Focus using text that involved complex sentences.
P83-1007
Other research on discourse (e.g., Grosz 1981; Grosz and Sidner 1986; Reichman 1978) has studied another phenomenon, the global focus of discourse.
J86-3001
This framework was introduced by Grosz, Joshi, and Weinstein (1983), it has been discussed and/or expanded on in several other works, including Brennan, Friedman, and Pollard (1987), Walker (1989, 1993), Kameyama (1986, 1993), Walker, Iida, and Cote (1992), Brennan (1993), Kameyama, Passonneau, and Poesio (1993), Linson (1993), and Hoffman and Turan (1993).
P83-1007 P86-1031 P87-1022 P89-1031 P93-1010
For English, the Cf is ordered or ranked by grammatical relations to the main verb (Walker 1989); the order is "first the subject, object, and object2, followed by other subcategorized functions, and finally adjuncts".
P89-1031
Centering, on the other hand, (in addition to requiring this same kind of inferencing) sometimes suggests multiple possibilities for the co-specifications of pronouns in a sentence (Walker 1989).
P89-1031
Example of Pronoun Resolution with RAFT/RAPR The following example (modified from Brennan, Friedman, and Pollard \[1987\]) illustrates RAFT/RAPR.
P87-1022
Also, Brennan, Friedman, and Pollard (1987) claim Kameyama's proposed rule falls out of their transition preferences, but whether this is true in all contexts is not immediately evident.
P87-1022
The problem for centering may be viewed as resulting from the fact that if a sentence, Un, has only one pronoun, then centering (Brennan, Friedman, and Pollard 1987) makes that element the Cb(Un) (assuming it co-specifies something in Cf(Un-1)), and centering prefers to resolve pronouns so that Cb(Un)=Cb(Un-1) regardless of the grammatical roles that Cb(Un-1) played in Un-1.
P87-1022
fact, this is what Brennan, Friedman, and Pollard (1987) appear to do for their examples.
P87-1022
(~) 1994 Association for Computational Linguistics Computational Linguistics Volume 20, Number 2 Subsequent to Sidner's work, Grosz, Joshi, and Weinstein (1983) introduced centering to account for the same phenomena addressed by Sidner's algorithm.
P83-1007
Centers For each utterance, centering computes the following (Grosz, Joshi, and Weinstein 1983; Brennan, Friedman, and Pollard 1987; Walker, Iida, and Cote 1992): the backward-looking center (Cb), which is intended to capture that item which ties the current sentence in with the previous sentence in the discourse, and a list of forward-looking centers (Cf), or elements that can potentially be the Cb of the next sentence.
P83-1007 P87-1022
Kameyama, Megumi (1986).
P86-1031
In resolving pronouns, the Brennan, Friedman, and Pollard (1987) (and Walker, ~ida, and Cote \[1992\]) algorithm uses Rule 1, Rule 2, and the Cb constraint.
P87-1022
Kameyama, Megumi; Passonneau, Rebecca; and Poesio, Massimo (1993).
P93-1010
We then 13 Suri (1992) identified the need to address this problem, and made some preliminary proposals for particular sentence types.
P92-1035
Because our algorithms track two foci and consider the grammatical roles of a pronoun and its possible antecedents during pronoun resolution (by preferring the 8 Working within centering, Kameyama (1986) proposes preferences based on grammatical roles in resolving pronouns in certain situations.
P86-1031
Note that because the centering literature claims that centering should operate only within a discourse segment, and because this claim is used to explain some otherwise problematic cases of pronoun use, not being able to adequately handle discourse seg1 Notice that we use the term focusing to cover all local focusing frameworks, Sidner's focusing framework (Sidner 1979), Carter's extensions to Sidner's framework (Carter 1987), the centering framework (Grosz, Joshi, and Weinstein 1983 and others), our framework (RAFT/RAPR), PUNDIT (Dahl \[1986\] and others), etc.
J86-3001 P83-1007
(Brennan, Friedman, and Pollard 1987, p.
P87-1022 P87-1022
Introduction Several researchers have noted the local coherence exhibited by discourse (Sidner 1979; Grosz, Joshi, and Weinstein 1983; Carter 1987; etc.).
P83-1007
However, we should point out that the centering literature has noted that centering "... is intended to operate within a \[discourse\[ segment" (Walker 1989, p.
P89-1031
Kameyama, Megumi (1993).
P93-1010
Suri (1992) argued that the reason Sidner's algorithms could not handle that text was not because they used two foci, but because a method for processing of complex sentences was not speci~ed.
P92-1035
(Brennan, Friedman, and Pollard 1987; Walker, Iida, and Cote 1992).
P87-1022
Walker (1989) indicated that centering needs to handle multiple subjects, but did not specify how to do that.
P89-1031
They correctly resolve the pronouns in these examples, s 4.3 Pronominalization and Grammatical Roles Brennan, Friedman, and Pollard (1987) discuss an ambiguous discourse.
P87-1022
