inatreebank. Thefirst suchmethod isnowknown as “DOP1” (Bod, 1993).
E93-1006
In other words, the Zollmann & Sima’an method, and other methods that converge to the “complete parse tree” solution such as LS-DOP (Bod, 2003) and BackOff-DOP (Sima’an and Buratto, 2003), are inconsistent in the weight-distribution test.
E03-1005
2.2 Correction-factor approaches Based on similar observation, (Bonnema et al., 1999; Bod, 2003) propose alternative estimation methods, which involve a correction factor to move probability mass from larger subtrees to smaller ones.
E03-1005
In his critique of this method, (Johnson, 2002) considers a situation where there is an STSG G (the target grammar) with a specific set of subtrees (t1...tN) and specific values of the weights (w1 ...wN) . He evaluates an estimation procedure which produces a grammar Gprime (the estimated grammar), by looking at the difference between the weights of G and the expected weights of Gprime.
J02-1005
Similarly, (Bod, 2003) changes the way frequencies fi are counted, with a similar effect.
E03-1005
In Bod’s original DOP implementation (Bod, 1993; Bod, 1998), henceforth DOP1, the weights of an elementary tree t is defined as its relative frequency (relative to other subtrees with the same root label) in the tree bank.
E93-1006
Despite this empirical success, (Johnson, 2002) argued that it is inadequate because it is biased and inconsistent.
J02-1005
t1 = S A a A a t2 =S A a A t3 =S A A a t5 =S A a t4 =S A A t6 =S A t7 =A a Figure 1: The example of (Johnson, 2002) (Johnson, 2002) looks at an example grammar G ∈ STSG with the subtrees as in figure 1.
J02-1005
His criticism spearheaded a number of other methods, including (Bonnema et al., 1999; Bod, 2003; Sima’an and Buratto, 2003; Zollmann and Sima’an, 2005), and will be the starting point of our analysis.
E03-1005
