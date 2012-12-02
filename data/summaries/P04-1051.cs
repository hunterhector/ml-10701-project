2.3 Probability-Based Cost Functions A fundamentally different approach to measure discourse coherence was proposed by Lapata (2003).
P03-1069
Second, we use twelve discourses from the BLLIP corpus taken from (Lapata, 2003), together with M.LAPATA.
P03-1069
Several papers in the recent literature (Mellish et al., 1998; Barzilay et al., 2002; Karamanis and Manurung, 2002; Lapata, 2003; Karamanis et al., 2004) have focused on defining local coherence, which evaluates the quality of sentence-to-sentence transitions.
P03-1069 P04-1050 W98-1411
However, our algorithm can still be useful as a subroutine in a more complex system that deals with global coherence (Marcu, 1997; Mellish et al., 1998).
W98-1411
Kibble and Power (2000) define three further classes of transitions: COHERENCE and SALIENCE, which are both defined in Table 1 as well, and NOCB, the class of transitions for which Cb(ui) is undefined.
W00-1411
Measures of local coherence specify which ordering of the sentences makes for the most coherent discourse, and can be based e.g. on Centering Theory (Walker et al., 1998; Brennan et al., 1987; Kibble and Power, 2000; Karamanis and Manurung, 2002) or on statistical models (Lapata, 2003).
P03-1069 P87-1022 W00-1411
Finally, a transition is considered to satisfy the CHEAPNESS constraint (Strube and Hahn, 1999) if Cb(ui) = Cp(ui−1).
J99-3001
The measure M.KP (Kibble and Power, 2000) sums the value of nocb and the values of three functions which evaluate to 0 if the transition is cheap, salient, or coherent, and 1 otherwise.
W00-1411
For example, the measure from (Mellish et al., 1998) looks at the entire discourse up to the current transition for some of their cost factors.
W98-1411
Mellish et al.(1998) and Karamanis and Manurung (2002) present algorithms based on genetic programming, and Lapata (2003) uses a graph-based heuristic algorithm, but none of them can give any guarantees about the quality of the computed ordering.
P03-1069 W98-1411
Table 2 summarises some cost functions from the literature, in the reconstruction of Karamanis et al.(2004). Each line shows the name of the coherence measure, the arity d from Definition 1, and the initial and transition cost functions.
P04-1050
We define a branch-and-cut algorithm based on linear programming, and evaluate it on discourse ordering problems based on the GNOME corpus (Karamanis, 2003) and the BLLIP corpus (Lapata, 2003).
P03-1069
The first is a family of algorithms for discourse ordering based on genetic programming (Mellish et al., 1998; Karamanis and Manurung, 2002).
W98-1411
Finally, the measure M.BFP (Brennan et al., 1987) uses a lexicographic ordering on 4-tuples which indicate whether the transition is a CONTINUE, RETAIN, SMOOTH-SHIFT, or ROUGHSHIFT.
P87-1022
Details on the comparison of different centering-based coherence measures are discussed by Karamanis et al.(2004). 6 Comparison to Other Approaches There are two approaches in the literature that are similar enough to ours that a closer comparison is in order.
P04-1050
However, a Majority Ordering algorithm is not guaranteed to compute good solutions to the discourse ordering problem, as Lapata (2003) assumes.
P03-1069
Table 1 shows the most common classification into the four types CONTINUE, RETAIN, SMOOTH-SHIFT, and ROUGH-SHIFT, which are predicted to be less and less coherent in this order (Brennan et al., 1987).
P87-1022
