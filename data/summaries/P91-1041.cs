Discussion: Comparison to Other Approaches The control structure of our algorithm is identical to that of \[Pereira, 1985\].
P85-1017
References \[Godden, 1990\] Godden, K.
P90-1023
With the simplicity of our algorithm and the ease of implementing it (compared to both incremental copying schemes and lazy schemes), combined with the demonstrated speed of the algorithm, the algorithm could be a viable alternative to existing unification algorithms used in current ~That is, unless some new scheme for reducing excessive copying is introduced such as scucture-sharing of an unchanged shared-forest (\[Kogure, 1990\]).
C90-2039
\[Kogure, 1990\] Kogure, K.
C90-2039
A permanent forwarding link is the usual forwarding link found in other algorithms (\[Pereira, 1985\], \[Wroblewski, 1987\], etc).
P85-1017
\[Pereira, 1985\] Pereira, E "A Structure-Sharing Representation for Unificadon-Based Grammar Formalisms".
P85-1017
\[Godden, 1990\] calculates the computation time cost of copying to be about 67 per3Please refer to \[Kogure, 1989\] for trivial time modification of Wroblewski's algorithm to handle cycles.
P90-1023
Our original unification algorithm was based on \[Wroblewskl, 1987\] which was chosen in 1988 as the then fastest algorithm available for our application (HPSG based unification grammar, three types of parsers (Earley, Tomita-LR, and active chart), unification with variables and cycles 3 combined with Kasper's (\[Kasper, 1987\]) scheme for handling disjunctions.
P87-1033
2In the large-scale HPSG-based spoken Japanese analysis system developed at ATR, sometimes 98 percent of the elapsed time is devoted to graph unification (\[Kogure, 1990\]).
C90-2039
Thus, if unification fails no copies are made at all (as in \[Karttunen, 1986\]'s scheme).
C86-1016
This is not a problem in our method because the temporary change made to a node is performed as pushing pointers into already existing structures (nodes) and it does not require entirely new structures to be created and dynamically allocated memory (which was necessary for the copy (create-node) operation), z3 \[Godden, 1990\] presents a method of using lazy evaluation in unification which seems to be one SUCC~sful actualization of \[Karttunen and Kay, 1985\]'s lazy evaluation idea.
P85-1016 P90-1023
As in \[Pereira, 1985\], we have three types of nodes: 1) :atomic, 2) :bottom 9, and 3) :complex.
P85-1017
\[Karttunen, 1986\] Karttunen, L.
C86-1016
\[Karttunen and Kay, 1985\] Karttunen, L.
P85-1016
(\[Godden, 1990\] calls such a unification: Eager Unification.).
P90-1023
In terms of speed, since delayed evaluation requires additional bookkeeping, how schemes such as the one introduced by \[Godden, 1990\] would compare with nonlazy incremental copying schemes is an open question.
P90-1023
The difference between Karttunen's method and ours is that in our algorithm, one increment to the global counter can invalidate all the changes made to nodes, while in Karttunen's algorithm each node in the entire argument graph that has been destructively modified must be restored separately by retrieving the attribute-values saved in an 21The discussion ofKartunnen's method is based on the DPATR implementation on Xerox 1100 machines (\[Karttunen, 1986\]).
C86-1016
We share the principle of storing changes in a restorable way with \[Karttunen, 1986\]'s reversible unification and copy graphs only after a successful unification.
C86-1016
Karttunen originally introduced this scheme in order to replace the less efficient structure-sharing implementations (\[Pereira, 1985\], \[Karttunen and Kay, 1985\]).
P85-1016 P85-1017
\[Kasper, 1987\] Kasper, R.
P87-1033
