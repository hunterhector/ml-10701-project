Dependency parsing has seen a surge of interest lately for applications such as relation extraction (Culotta and Sorensen, 2004), machine translation (Ding and Palmer, 2005), synonym generation (Shinyama et al., 2002), and lexical resource augmentation (Snow et al., 2004).
P04-1054 P05-1067
MIRA It is also possible to exploit the structure of the output space and factor the exponential number of margin constraints into a polynomial number of local constraints (Taskar et al., 2003; Taskar et al., 2004).
W04-3201
N&N2005: The pseudo-projective parser of Nivre and Nilsson (2005).
P05-1013
Trees It is well known that projective dependency parsing using edge based factorization can be handled with the Eisner algorithm (Eisner, 1996).
C96-1058
Table 2 shows the results for English projective dependency trees extracted from the Penn Treebank (Marcus et al., 1993) using the rules of Yamada and Matsumoto (2003).
J93-2004
This algorithm has a runtime of O(n3) and has been employed successfully in both generative and discriminative parsing models (Eisner, 1996; McDonald et al., 2005).
C96-1058 P05-1012
McDonald et al.(2005) examines briefly factored MIRA for projective English dependency parsing, but for that application, k-best MIRA performs as well or better, and is much faster to train.
P05-1012
Using this spanning tree representation, we extend the work of McDonald et al.(2005) on online large-margin discriminative training methods to non-projective dependencies.
P05-1012
We should note that the results in Collins et al.(1999) are different then reported here due to different training and testing data sets.
P99-1065
To reduce sparseness, our features rely only on the reduced POS tag set from Collins et al.(1999). The number of features extracted from the PDT training set was 13, 450, 672, using the feature set outlined by McDonald et al.(2005). Czech has more flexible word order than English and as a result the PDT contains non-projective dependencies.
P05-1012 P99-1065
Nivre and Nilsson (2005) presented a parsing model that allows for the introduction of non-projective edges into dependency trees through learned edge transformations within their memory-based parser.
P05-1013
To learn these structures we used online large-margin learning (McDonald et al., 2005) that empirically provides state-of-the-art performance for Czech.
P05-1012
3. McD2005: The projective parser of McDonald et al.(2005) that uses the Eisner algorithm for both training and testing.
P05-1012
The resulting online update (to be inserted in Figure 4, line 4) would then be: min vextenddoublevextenddoublew(i+1) w(i)vextenddoublevextenddouble s.t. s(xt,yt) s(xt,yprime) L(yt,yprime) where yprime = arg maxyprime s(xt,yprime) McDonald et al.(2005) used a similar update with k constraints for the k highest-scoring trees, and showed that small values of k are sufficient to achieve the best accuracy for these methods.
P05-1012
In fact, the largest source of English dependency trees is automatically generated from the Penn Treebank (Marcus et al., 1993) and is by convention exclusively projective.
J93-2004
This model is related to the averaged perceptron algorithm of Collins (2002).
W02-1001
Furthermore, we can also see that the MST parsers perform favorably compared to the more powerful lexicalized phrase-structure parsers, such as those presented by Collins et al.(1999) and Zeman (2004) that use expensive O(n5) parsing algorithms.
P99-1065
Large Margin Learning In this section, we review the work of McDonald et al.(2005) for online large-margin dependency parsing.
P05-1012
We evaluate these methods on the Prague Dependency Treebank using online large-margin learning techniques (Crammer et al., 2003; McDonald et al., 2005) and show that MST parsing increases efficiency and accuracy for languages with non-projective dependencies.
P05-1012
This averaging effect has been shown to help overfitting (Collins, 2002).
W02-1001
This is in contrast to other non-projective methods, such as that of Nivre and Nilsson (2005), who implement non-projectivity in a pseudo-projective parser with edge transformations.
P05-1013
Collins. 2002.
W02-1001
Using this representation, the parsing algorithm of Eisner (1996) is sufficient for searching over all projective trees in O(n3) time.
C96-1058
This formalization generalizes standard projective parsing models based on the Eisner algorithm (Eisner, 1996) to yield efficient O(n2) exact parsing methods for nonprojective languages like Czech.
C96-1058
Most previous dependency parsing models have focused on projective trees, including the work of Eisner (1996), Collins et al.(1999), Yamada and Matsumoto (2003), Nivre and Scholz (2004), and McDonald et al.(2005). These systems have shown that accurate projective dependency parsers can be automatically learned from parsed data.
C04-1010 C96-1058 P05-1012 P05-1013 P99-1065
COLL1999: The projective lexicalized phrase-structure parser of Collins et al.(1999). 2.
P99-1065
Figure 4 gives pseudo-code for the MIRA algorithm as presented by McDonald et al.(2005). An online learning algorithm considers a single training instance at each update to w.
P05-1012
In particular, Wang and Harper (2004) describe a broad coverage non-projective parser for English based on a hand-constructed constraint dependency grammar rich in lexical and syntactic information.
W04-0307
