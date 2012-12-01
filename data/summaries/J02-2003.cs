All the data used in this work have been obtained from the British National Corpus (BNC), using the system of Briscoe and Carroll (1997), which consists of a shallow-parsing component that is able to identify verbal arguments.
A97-1052
Abney and Light (1999) have tried a more motivated approach, using the expectation maximization algorithm, but with little success.
W99-0901
7. Pseudo-Disambiguation Experiments The task we used to compare the class-based estimation techniques is a decision task previously used by Pereira, Tishby, and Lee (1993) and Rooth et al.(1999). The task is to decide which of two verbs, v and v prime, is more likely to take a given noun, n,asan object.
P93-1024 P99-1014
alternative formula for G 2 is given in Dunning (1993), but the two are equivalent.
J93-1003
This ratio is similar to pointwise mutual information (Church and Hanks 1990) and also forms part of Resnik’s association score, which will be introduced in Section 6.
J90-1003
Dunning (1993) argues for the use of G 2 rather than X 2, based on an analysis of the sampling distributions of G 2 and X 2, and results obtained when using the statistics to acquire highly associated bigrams.
J93-1003
Note that the 12 The results given for similarity class are different from those given in Clark and Weir (2001) because the probability estimates used in Clark and Weir (2001) were not normalized.
N01-1013
The X 2 statistic is performing at least as well as G 2, and the results show that the average level of generalization is slightly higher for G 2 than X 2 . This suggests a possible explanation for the results presented here and those in Dunning (1993): that the X 2 statistic provides a less conservative test when counts in the contingency table are low.
J93-1003
Thus the generalization procedure can be thought of as one that finds “homogeneous” areas of the hierarchy, that is, areas consisting of classes that are associated to a similar degree with the verb (Clark and Weir 1999).
W99-0631
This appeared to solve the problem, and the results presented later for the average degree of generalization do not show an overgeneralization compared with those given in Li and Abe (1998).
J98-2002
For example, Clark and Weir (2000) describes a prepositional phrase attachment algorithm that employs probability estimates obtained using the WordNet method described here.
C00-1029
197 Clark and Weir Class-Based Probability Estimation 1997; Li and Abe 1998; Wagner 2000), the level of generalization is often determined for a small number of hand-picked verbs and the result compared with the researcher’s intuition about the most appropriate level for representing a selectional preference.
C00-1029 J98-2002
We used McCarthy’s (2000) implementation of MDL.
A00-2034
The data were again extracted from a subset of the BNC using the system of Briscoe and Carroll (1997), and the G 2 statistic was used in the chi-square test.
A97-1052
Ribas (1995), Li and Abe (1998), McCarthy (2000), and Wagner (2000) all use some kind of thresholding when dealing with counts in the hierarchy (although not in the context of a chi-square test).
A00-2034 J98-2002
The pseudo-disambiguation task described here has also been used to evaluate clustering algorithms (Pereira, Tishby, and Lee, 1993; Rooth et al., 1999), but with different data, and so it is difficult to compare the results.
P93-1024 P99-1014
The approach described in Clark and Weir (1999) is shown in Clark (2001) to have some impact on the pseudo-disambiguation task, but only with certain values of the α parameter, and ultimately does not improve on the best performance.
N01-1013 W99-0631
Dunning (1993) argues for the use of G 2 rather than X 2, based on the claim that the sampling distribution of G 2 approaches the true chi-square distribution quicker than the sampling distribution of X 2 . However, Agresti (1996, page 34) makes the opposite claim: “The sampling distributions of X 2 and G 2 get closer to chi-squared as the sample size n increases....The convergence is quicker for X 2 than G 2 .” In addition, Pedersen (2001) questions whether one statistic should be preferred over the other for the bigram acquisition task and cites Cressie and Read (1984), who argue that there are some cases where the Pearson statistic is more reliable than the log-likelihood statistic.
J93-1003 N01-1011
recent paper that extends the acquisition of selectional preferences to sense-sense relationships is Agirre and Martinez (2001).
W01-0703
An evaluation using a PP attachment task was attempted in Clark and Weir (2000), but the evaluation was limited by the relatively small size of the Penn Treebank.
C00-1029
An approach similar to this is taken by Bikel (2000), in the context of statistical parsing.
W00-1320
Previous work has considered how to estimate probabilities using classes from WordNet in the context of acquiring selectional preferences (Resnik 1998; Ribas 1995; Li and Abe 1998; McCarthy 2000), and this previous work has also addressed the question of how to determine a suitable level of generalization in the hierarchy.
A00-2034 J98-2002
An example cut showing part of the WordNet hierarchy is shown in Figure 3 (based on an example from Li and Abe [1998]; the dashed lines indicate parts of the hierarchy that are not shown in the diagram).
J98-2002
In particular, we are not addressing the problem of acquiring selectional restrictions in the way this is usually construed (Resnik 1993; Ribas 1995; McCarthy 1997; Li and Abe 1998; Wagner 2000).
A00-2034 J98-2002 W97-0808
Alternative approaches are described in Clark and Weir (1999) (see also Clark [2001]), Abney and Light (1999), and Ciaramita and Johnson (2000).
C00-1028 C00-1029 N01-1013 W99-0631 W99-0901
Before providing the details of the generalization procedure, we give the relativefrequency estimates of the relevant probabilities and deal with the problem of am6 Li and Abe (1998) also develop a theoretical framework that applies only to a tree and turn WordNet into a tree by copying each subgraph with multiple parents.
J98-2002
Finally, an issue that has not been much addressed in the literature (except by Li and Abe [1996]) is how the accuracy of class-based estimation techniques compare when automatically acquired classes, as opposed to the manually created classes from WordNet, are used.
C96-1003
This is the approach taken by Li and Abe (1998), Ribas (1995), and McCarthy (2000).
A00-2034 J98-2002
6. Alternative Class-Based Estimation Methods The approaches used for comparison are that of Resnik (1993, 1998), subsequently developed by Ribas (1995), and that of Li and Abe (1998), which has been adopted by McCarthy (2000).
A00-2034 J98-2002
The ambiguity can be resolved by noting that the correct sense of spoon is more likely to be an argument of “ate-with” than “strawberries-with” (Li and Abe 1998; Clark and Weir 2000).
C00-1029 J98-2002
