The key requirement for parsing categorial systems formulated in this way is some theorem proving method that is sufficient for the fragment of linear logic employed (although some additional work will be required for managing labels), and a number of different approaches have been used, e.g. proof nets (Moortgat, 1992), and SLD resolution (Morrill, 1995).
E95-1019
~2: Glue Language Deduction In a line of research beginning with Dalrymple et al.(1993), a fragment of linear logic is used as a 'glue language' for assembling sentence meanings for LFG analyses in a 'deductive' fashion (enabling, for example, an direct treatment of quantifier scoping, without need of additional mechanisms).
E93-1013
See (Hepple, 1996) for a worked example.
C96-1091
3This 'excision' step has parallels to the 'emit' step used in the chart-parsing approaches for the associative Lambek calculus of (KSnig, 1994) and (Hepple, 1992), although the latters differs in that there is no removal of the relevant subformula, i.e. the 'emitting formula' is not simplified, remaining higher-order.
C92-1024
If we mechanically mirror this pattern of proof over the original glue terms (with meanings, but quantifier-free), a role/meaning 9See (Fry, 1997), who uses a proof net method for glue language deduction, for relevant discussion.
P97-1019
Recent work has seen proposals for a range of such systems, differing in their resource sensitivity (and hence, implicitly, their underlying notion of 'linguistic structure'), in some cases combining differing resource sensitivities in one system, s Many of SSee, for example, the formalisms developed in (Moortgat et al., 1994), (Morrill, 1994), (Hepple, 1995).
E95-1018 E95-1019
Hepple (1996) introduces first-order compilation for implicational linear logic, and shows how that method can be used with labelling as a basis parsing implicational categorial systems.
C96-1091
3 First-order Compilation for Implicational Linear Logic Hepple (1996) shows how deductions in implicational linear logic can be recast as deductions involving only first-order formulae, using only a single inference rule (a variant of o-E).
C96-1091
See (Hepple, 1996) for more details, including a precise statement of the compilation procedure.
C96-1091
John Fry 1997.
P97-1019
The statement of the compilation procedure here is somewhat different to that given in (Hepple, 1996), which is based on polar translation functions.
C96-1091
Hepple (1996) presents a compilation method which allows for tabular deduction for implicational linear logic (i.e.
C96-1091
