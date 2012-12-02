Parts of the Comparative Method have been computerized by Frantz (1970), Hewson (1974), Wimbish (1989), and Lowe and Mazandon (1994), but none of them have tackled the alignment step.
J94-3004
I have not implemented the rule from Covington (1996) that gives a reduced penalty for adjacent skips in the same string to reflect the fact that affixes tend to be contiguous.
J96-4002
Two ten-letter strings have anywhere from 26,797 to 8,079,453 different alignments depending on exactly what alignments are considered distinct (Covington 1996, Covington and Canfield 1996).
J96-4002
Following Covington (1996), I implemented a very simple pruning strategy.
J96-4002
skips Covington (1996) considers the alignments e -e 1 1equivalent and generates only the first of them, leaving it to some later step in the comparison process to decide whether \[e\] and \[1\] really correspond.
J96-4002
Covington (1996) treats this as a process that steps through both strings and, at each step, performs either a "match" (accepting a character from both strings), a "skip-l" (skipping a character in the first string), or a "skip-2" (skipping a character in the second string).
J96-4002
Table 1: Evaluation metric used by Covington (1996).
J96-4002
an evaluation metric The phonetic similarity criterion used by Covington (1996) is shown in Table 1.
J96-4002
277 Start rol/sk,p oo ro-1 LIoJ LJ ~",~ngl string2 L J \\ ~,';,i~?\ ro ::: Situations where only one move is possible string 2 o S,,,on E;'-;1 string 1 Analogous to above Figure 1: Part of a 3-way-branching search tree for generating potential alignments (Covington 1996, ignoring no-alternating-skips rule).
J96-4002
In this paper I extend the guided-search alignment algorithm of Covington (Computational Linguistics, 1996) to handle more than two strings.
J96-4002
Covington (1996) presents a workable alignment algorithm for comparing two languages.
J96-4002
Accordingly, I follow Covington (1996) in recasting the problem as a tree search.
J96-4002
Lowe, John B., and Mazaudon, Martine (1994) The Reconstruction Engine: a computer implementation of the comparative method.
J94-3004
