Both arguments and targets are obtained from the ASSERT parser developed by Pradhan (2004).
N04-1030
Results on MUC4 To compare the results on the terrorism domain in MUC4, we choose the recent state-of-art systems GRID by Xiao et al.(2004), Riloff et al.(2005) and ARE (2006) by Maslennikov et al.(2006) which does not utilize discourse and semantic relations.
C04-1078 P06-2074
However, Maslennikov et al.(2006) reported that the increase of relation path length will lead to considerable decrease in performance.
P06-2074
However, current semantic parsers such as the ASSERT are not able to recognize support verb constructions such as “X conducted an attack on Y” under the verb frame “attack” (Pradhan et al.2004). Hence, many useful predicate-argument structures will be missed.
N04-1030
This is different from Zhang et al.(2006), who were using entities in their subtrees.
P06-1104
Third, the knowledge of textual structure helps to interpret the meaning of entities in a text (Grosz and Sidner 1986).
J86-3001
We describe the nodes and edges of T l separately for each type, because their representations are different: 1) The nodes of discourse tree T c consist of clauses [Clause 1, …, Clause Ncl ]; and their relation edges are obtained from the Spade system described in Soricut and Marcu (2003).
N03-1030
Here we follow the methodology of Maslennikov et al.(2006). For each sentence, we compose a set of candidate templates T using the extracted relation paths between each A i and A j . To evaluate each template T i ∈T, we combine the integral scores from relation paths between its anchors A i and A j into the overall Relation_Score T : M AAScore TScoreelationR Kji jiI iT ∑ ≤≤ =,1 ),( )(_ (13) where K is the number of extracted slots, M is the number of extracted relation paths between anchors A i and A j, and Score I (A i, A j ) is obtained from Equation (9).
P06-2074
These relations capture the interactions between anchors and are therefore useful for tackling the paraphrasing and alignment problems (Maslennikov et al., 2006).
P06-2074
Some of these components are also presented in detail in our previous work (Maslennikov et al., 2006).
P06-2074
Surdeanu et al.(2003) applied semantic parsing to capture the predicate-argument sentence structure.
P03-1002
Following the methodology of Zhang et al.(2006), we use only the English portion of ACE RDC 2003 training data.
P06-1104
Results on ACE RDC’03, specific types The relatively small improvement of results in Table 5 may be attributed to the following reasons: 1) it is important to model the commonality relations, as was done by Zhou et al.(2006); and 2) our relation paths do not encode entities.
P06-1016
Zhang. 2006.
P06-1104
Maslennikov et al.(2006) classified relation path between candidate entities into simple, average and hard cases.
P06-2074
Culotta and Sorensen (2004) extracted relationships using dependency-based kernel trees in Support Vector Machines (SVM).
P04-1054
Previous approaches to IE relied on cooccurrence (Xiao et al., 2004) and dependency (Zhang et al., 2006) relations between entities.
C04-1078 P06-1104
This observation corresponds to that reported in Zhang et al.(2006). Discourse parsing is very important to reduce the amount of variations for specific types on ACE 598 RDC’03, as there are 48 possible anchor types.
P06-1104
Zhou. 2006.
P06-1016
Given a training set of sentences, we extract the anchor cues A Cj = [A 1, …, A Nanch ] of type C j using the procedures described in Maslennikov et al.(2006). The linguistic features of these anchors for the anchor types of Perpetrator, Action, Victim and Target for the MUC4 domain are given in Table 1.
P06-2074
