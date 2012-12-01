Word alignments were first introduced as an intermediate result of statistical machine translation systems (Brown et al., 1993).
J93-2003
Results We adopted the same evaluation methodology as in (Och and Ney, 2000), which compared alignment outputs with manually aligned sentences.
P00-1056
Given the dependency tree TE, the alignment can induce a dependency tree for F (Hwa et al., 2002).
P02-1050
For example, alignments can be used to learn translation lexicons (Melamed, 1996), transfer rules (Carbonell et al., 2002; Menezes and Richardson, 2001), and classifiers to find safe sentence segmentation points (Berger et al., 1996).
J96-1002 W01-1406
The work done in (Yamada and Knight, 2001) measures statistics on operations that transform a parse tree from one language into another.
P01-1067
This demonstrates that we are competitive with the methods described in (Och and Ney, 2000).
P00-1056
to state-of-the-art Table 2 compares the results of our algorithm with the results in (Och and Ney, 2000), where an HMM model is used to bootstrap IBM Model 4.
P00-1056
These constraints tie words in such a way that the space of alignments cannot be enumerated as in IBM models 1 and 2 (Brown et al., 1993).
J93-2003
Fox. 2002.
W02-1039
The first constraint is the one-to-one constraint (Melamed, 2000): every word (except the null words e0 and f0) participates in exactly one link.
J00-2004
Work 6.1 Probability models When viewed with no features, our probability model is most similar to the explicit noise model defined in (Melamed, 2000).
J00-2004
Alignment We produce an initial alignment using the same algorithm described in Section 3, except we maximize summed φ2 link scores (Gale and Church, 1991), rather than alignment probability.
H91-1026
It has been observed that words close to each other in the source language tend to remain close to each other in the translation (Vogel et al., 1996; Ker and Change, 1997).
C96-2141
For example Melamed uses competitive linking along with an explicit noise model in (Melamed, 2000) to produce a new scoring metric, which in turn creates better alignments.
J00-2004
They defined the following metrics to evaluate an alignment A: recall = |A∩S||S| precision = |A∩P||P| alignment error rate (AER) = |A∩S|+|A∩P||S|+|P| We trained our alignment program with the same 50K pairs of sentences as (Och and Ney, 2000) and tested it on the same 500 manually aligned sentences.
P00-1056
Such measures can then be used to guide a constrained search to produce word alignments (Melamed, 2000).
J00-2004
These methods often involve using a statistic such as φ2 (Gale and Church, 1991) or the log likelihood ratio (Dunning, 1993) to create a score to measure the strength of correlation between source and target words.
H91-1026 J93-1003
We parsed the training Table 2: Comparison with (Och and Ney, 2000) Method Prec Rec AER Ours 95.7 86.4 8.7 IBM-4 F→E 80.5 91.2 15.6 IBM-4 E→F 80.0 90.8 16.0 IBM-4 Intersect 95.7 85.6 9.0 IBM-4 Refined 85.9 92.3 11.7 and testing corpora with Minipar.5 We then ran the training procedure in Section 4 for three iterations.
P00-1056
Methods such as (Wu, 1997), (Alshawi et al., 2000) and (Lopez et al., 2002) employ a synchronous parsing procedure to constrain a statistical alignment.
J00-1004 J97-3002
We can rewrite P(lk|Ck) as: P(lk|Ck) = P(lk,Ck)P(C k) = P(Ck|lk)P(lk)P(C k,eik,fjk) = P(Ck|lk)P(C k|eik,fjk) × P(lk,eik,fjk)P(e ik,fjk) = P(lk|eik,fjk)× P(Ck|lk)P(C k|eik,fjk) Here P(lk|eik,fjk) is link probability given a cooccurrence of the two words, which is similar in spirit to Melamed’s explicit noise model (Melamed, 2000).
J00-2004
Maximum entropy can be used to improve IBM-style translation probabilities by using features, such as improvements to P(f|e) in (Berger et al., 1996).
J96-1002
The second constraint, known as the cohesion constraint (Fox, 2002), uses the dependency tree (Mel’ˇcuk, 1987) of the English sentence to restrict possible link combinations.
W02-1039
