Zhang et al (2006) also showed that the widely-used Shortest Path-enclosed Tree (SPT) performed best.
P06-1104
Composite Kernel In this paper, a composite kernel via polynomial interpolation, as described Zhang et al (2006), is applied to integrate the proposed context-sensitive convolution tree kernel with a state-of-the-art linear kernel (Zhou et al 2005) 7: ),()1(),(),(1 ••⋅−+••⋅=•• CPL KKK aa (5) Here, ),( ••LK and ),( ••CK indicates the normalized linear kernel and context-sensitive convolution tree kernel respectively while (,)pK •• is the polynomial expansion of (,)K •• with degree d=2, i.e. 2(,)((,)1)pKK• ••=+ and a is the coefficient (a is set to 0.3 using cross-validation).
P05-1053 P06-1104
This makes it suffer from the similar behavior with that of Culotta and Sorensen (2004): high precision but very low recall.
P04-1054
Kambhatla (2004) used the non-terminal path connecting the given two entities in a parse tree while Zhou et al.(2005) introduced additional chunking features to enhance the performance), it is found difficult to well preserve structured information in the parse trees using the feature-based methods.
P04-3022 P05-1053
Zhou et al (2006) further improved the performance by exploring the commonality among related classes in a class hierarchy using hierarchical learning strategy.
P06-1016
Table 1 compares the impact of different m in context-sensitive convolution tree kernels using the Shortest Path-enclosed Tree (SPT) (as described in Zhang et al (2006)) on the major relation types of the ACE RDC 2003 and 2004 corpora, in details.
P06-1104
For comparison, we use the same setting as Zhang et al (2006) by applying a 5-fold cross-validation on a subset of the 2004 data, containing 348 documents and 4400 relation instances.
P06-1104
Among other kernels, Bunescu and Mooney (2005b) proposed a subsequence kernel and applied it in protein interaction and ACE relation extraction tasks.
H05-1091
Zhang et al (2006) systematically explored seven different tree spans, including the Shortest Path-enclosed Tree (SPT) and a ContextSensitive Path-enclosed Tree1 (CSPT), and found that SPT per formed best.
P06-1104
Zhao and Grishman (2005) defined several featurebased composite kernels to integrate diverse features for relation extraction and achieved the F-measure of 70.4 on the 7 relation types of the ACE RDC 2004 corpus . Zhang et al (2006) proposed two composite kernels to integrate a linear kernel and Collins and Duffy’s convolution tree kernel.
P05-1052 P06-1104
It also shows that feature-based 8 There might be some typing errors for the performance reported in Zhao and Grishman(2005) since P, R and F do not match.
P05-1052
System P(%) R(%) F Linear Kernel 78.2 (77.2) 63.4 (60.7) 70.1 (68.0) Context-Sensitive Convolution Tree Kernel 81.1 (80.1) 66.7 (63.8) 73.2 (71.0) Composite Kernel 82.2 (80.8) 70.2 (68.4) 75.8 (74.1) Table 3: Performance of the compos ite kernel via polynomial interpolation on the major relation types of the ACE RDC 2003 (inside the parentheses) and 2004 (outside the parentheses) corpora Comparison with Other Systems ACE RDC 2003 P(%) R(%) F Ours: composite kernel 80.8 (65.2) 68.4 (54.9) 74.1 (59.6) Zhang et al (2006): composite kernel 77.3 (64.9) 65.6 (51.2) 70.9 (57.2) Ours: context-sensitive convolution tree kernel 80.1 (63.4) 63.8 (51.9) 71.0 (57.1) Zhang et al (2006): convolution tree kernel 76.1 (62.4) 62.6 (48.5) 68.7 (54.6) Bunescu et al (2005): shortest path dependency kernel 65.5 (-) 43.8 (-) 52.5 (-) Culotta et al (2004): dependency kernel 67.1 (-) 35.0 (-) 45.8 (-) Zhou et al.(2005): feature-based 77.2 (63.1) 60.7 (49.5) 68.0 (55.5) Kambhatla (2004): feature-based (63.5) (45.2) (52.8) Table 4: Comparison of difference systems on the ACE RDC 2003 corpus over both 5 types (outside the parentheses) and 24 subtypes (inside the parentheses) ACE RDC 2004 P(%) R(%) F Ours: composite kernel 82.2 (70.3) 70.2 (62.2) 75.8 (66.0) Zhang et al (2006): composite kernel 76.1 (68.6) 68.4 (59.3) 72.1 (63.6) Zhao et al (2005):8 composite kernel 69.2 (-) 70.5 (-) 70.4 (-) Ours: context-sensitive convolution tree kernel 81.1 (68.8) 66.7 (60.3) 73.2 (64.3) Zhang et al (2006): convolution tree kernel 72.5 (-) 56.7 (-) 63.6 (-) Table 5: Comparison of difference systems on the ACE RDC 2004 corpus over both 7 types (outside the parentheses) and 23 subtypes (inside the parentheses) Finally, Tables 4 and 5 compare our system with other state-of-the-art systems9 on the ACE RDC 2003 and 2004 corpora, respectively.
H05-1091 P04-1054 P04-3022 P05-1052 P05-1053 P06-1104
For the feature-based methods, Kambhatla (2004) employed Maximum Entropy models to combine diverse lexical, syntactic and semantic features in relation extraction, and achieved the F-measure of 52.8 on the 24 relation subtypes in the ACE RDC 2003 corpus.
P04-3022
Bunescu and Mooney (2005a) proposed a shortest path dependency tree kernel, which just sums up the number of common word classes at each position in the two paths, and achieved the F-measure of 52.5 on the 5 relation types in the ACE RDC 2003 corpus.
H05-1091
One problem with the context-sensitive tree span explored in Zhang et al (2006) is that it only considers the availability of entities’ siblings and fails to consider following two factors: 1) Whether is the information contained in SPT enough to determine the relationship between two entities?
P06-1104
Among them, feature-based methods (Kambhatla 2004; Zhou et al., 2005) achieve certain success by employing a large amount of diverse linguistic features, varying from lexical knowledge, entityrelated information to syntactic parse trees, dependency trees and semantic information.
P04-3022 P05-1053
As the state-of-the-art, Zhang et al (2006) applied the convolution tree kernel (Collins and Duffy 2001) and achieved comparable performance with a state-of-theart linear kernel (Zhou et al 2005) on the 5 relation types in the ACE RDC 2003 corpus.
P05-1053 P06-1104
Since then, many methods, such as feature-based (Kambhatla 2004; Zhou et al 2005, 2006), tree kernel-based (Zelenko et al 2003; Culotta and Sorensen 2004; Bunescu and Mooney 2005a; Zhang et al 2006) and composite kernel-based (Zhao and Gris hman 2005; Zhang et al 2006), have been proposed in literature.
H05-1091 P04-1054 P04-3022 P05-1052 P05-1053 P06-1016 P06-1104
As the state-of-the-art tree kernel-based method, Zhang et al (2006) explored various structured feature 729 spaces and used the convolution tree kernel over parse trees (Collins and Duffy 2001) to model syntactic structured information for relation extraction.
P06-1104
His mother Leba nese landed PRP$ NNP VBD IN NP -E1-PER NP-E2-GPE PP S d) descriptive NP NN at … VP Jane ABC news, NNP, NNP NNS, NNP . NP NP-E1-PER NP-E2-ORG NP c) semi-structured California . .,,, NP(NN) of Microsoft IN NNP NP-E2-ORG PP(IN)-subroot b) context-sensitive NP(NN) of Microsoft IN NNP NP-E2-ORG S(VBD) PP(IN)-subroot c) context-sensitive PP(IN)-subtoot NP-E2-ORG of Microsoft IN NNP a) context-free … NP John and Mary got NNP CC NNP VBD married NP-E1-PER NP-E2-PER VP S VP VBN … John and Mary got NNP CC NNP VBD married NP -E1-PER NP -E2-PER VP NP VP … NP CEO of Microsoft a nnounced NN IN NNP VBD … NP-E1-PER NP-E2-ORG VP S b) PP -linked PP … John ’s wife found a job NNP POS NN VBD DT JJ NN NP NP-E1-PER NP-E2-PER VP S a) embedded good 731 Since “predicate -linked” instances only occupy ~20% of cases, this explains why SPT performs better than the Context-Sensitive Path-enclosed Tree (CSPT) as described in Zhang et al (2006): consistently adopting CSPT may introduce too much noise/unnecessary information in the tree kernel.
P06-1104
Culotta and Sorensen (2004) extended this work to estimate similarity between augmented dependency trees and achieved the F-measure of 45.8 on the 5 relation types in the ACE RDC 2003 corpus.
P04-1054
word, entity type, mention level, overlap, base phrase chunking, dependency tree, parse tree and semantic information) as Zhou et al (2005).
P05-1053
Zhang et al (2006) explored five tree spans in relation extraction and it was a bit surprising to find that the Shortest Path-enclosed Tree (SPT, i.e. the sub-tree enclosed by the shortest path linking two involved entities in the parse tree) performed best.
P06-1104
As a result, our tree kernel is not limited by the constraints in previous tree kernels (as discussed in Section 2), such as Collins and Duffy (2001), Zhang et al (2006), Culotta and Sorensen (2004) and Bunescu and Mooney (2005a).
H05-1091 P04-1054 P06-1104
However, it is difficult for them to effectively capture structured parse tree information (Zhou et al 2005), which is critical for further performance improvement in relation extraction.
P05-1053
Although earlier researches (Zelenko et al 2003; Culotta and Sorensen 2004; Bunescu and Mooney 2005a) only achieve success on simple tasks and fail on complex tasks, such as the ACE RDC task, tree kernel-based methods achieve much progress recently.
H05-1091 P04-1054
That is, all the reported performances in this paper on the ACE RDC 2004 corpus are evaluated using 5-fold cross validation on the entire corpus . Both corpora are parsed using Charniak’s parser (Charniak, 2001) with the boundaries of all the entity mentions kept 4 . We iterate over all pairs of entity mentions occurring in the same sentence to generate potential relation instances5.
P01-1017
This convolution tree kernel has been successfully applied by Zhang et al (2006) in relation extraction.
P06-1104
Zhou et al (2005) further systematically explored diverse features through a linear kernel and Support Vector Machines, and achieved the Fmeasures of 68.0 and 55.5 on the 5 relation types and the 24 relation subtypes in the ACE RDC 2003 corpus respectively.
P05-1053
