It has been repeatedly shown to improve parsing accuracy (Johnson, 1998; Charniak, 2000; Klein and Manning, 2003b), but it is difficult if not impossible to integrate with best-first search in bottom-up chart-parsing (as in Charniak et al.(1998)). The reason is that when working bottom up it is difficult to determine if, say, ssbar is any more or less likely than ss, as the evidence, working bottom up, is negligible.
A00-2018 J98-4004 N03-1016 P03-1054 W98-1115
the one used in Klein and Manning (2003b) would have smoothed over this problem.
N03-1016 P03-1054
Related approaches are used in Hall (2004) and Charniak and Johnson (2005).
P04-1006 P05-1022
Tsuruoka and Tsujii (2004) explore the framework developed in Klein and Manning (2003a), and seek ways to minimize the time required by the heap manipulations necessary in this scheme.
N03-1016 P03-1054
Even worse, some applications require the parsing of multiple candidate strings per sentence (Johnson and Charniak, 2004) or parsing from a lattice (Hall and Johnson, 2004), and in these applications parsing efficiency is even more important.
P04-1005 P04-1006
The results cited in Caraballo and Charniak (1998) cannot be compared directly to ours, but are roughly in the same equivalence class.
J98-2004 W98-1115
It achieves its speed in part because it uses the Eisner and Satta (1999) algorithm for n3 bilexical parsing, but also because dependency parsing has a much lower grammar constant than does standard PCFG parsing — after all, there are no phrasal constituents to consider.
P99-1059
Following common practice Johnson (1998; Klein and Manning (2003b) we Markovize by replacing these nonterminals with ones that remember less of the immediate rule context.
J98-4004 N03-1016 P03-1054
A quite different approach to parsing efficiencyistakeninCaraballoandCharniak(1998) (and refined in Charniak et al.(1998)). Here efficiency is gained by using a standard chartparsing algorithm and pulling constituents off the agenda according to (an estimate of) their probability given the sentence.
J98-2004 W98-1115
These remain fixed at all levels to the standard Penn-tree-bank set Marcus et al.(1993). Level-0 makes two distinctions, the root node and everybody else.
J93-2004
Klein and Manning (2003a) describe efficient A∗ for the most likely parse, where pruning is accomplished by using Equation 1 and a true upper bound on the outside probability.
N03-1016 P03-1054
We also show the results for the most similar Klein and Manning (2003b) experiment.
N03-1016 P03-1054
The parser of Charniak (2000) is also a two-stage ctf model, where the first stage is a smoothed Markov grammar (it uses up to three previous constituents as context), and the second stage is a lexicalized Markov grammar with extra annotations about parents and grandparents.
A00-2018
Because we prune at the end each granularity level, we can evaluate the equation exactly; no approximations are needed (as in, e.g., Charniak et al.(1998)). During parsing, instead of building each constituent allowed by the grammar, we first test if the probability of the corresponding coarser constituent (which we have from Equation 1 in the previous round of parsing) is greater than a threshold.
W98-1115
Those presented in Charniak et al.(1998) are superior, but in Section 5 below we suggest that a combination of the techniques could yield better results still.
W98-1115
We suspect that the real number is significantly lower, though still 173 No pruning 77.9 With pruning 77.9 Klein and Manning (2003b) 77.4 Figure 7: Labeled precision/recall f-measure, WSJ section 23, all sentences of length ≤ 100 much higher than the pruned version.
N03-1016 P03-1054
Most recently, McDonald et al.(2005) have implemented a dependency parser with good accuracy (it is almost as good at dependency parsing as Charniak (2000)) and very impressive speed (it is about ten times faster than Collins (1997) and four times faster than Charniak (2000)).
A00-2018 P05-1012 P97-1003
A paper closely related to ours is Goodman (1997).
W97-0302
The best-first search method of Charniak et al.(1998) estimates Equation 1.
W98-1115
