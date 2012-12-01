Note that Wu and Palmer (1994) designed their measure such that shallow nodes (i.e., less specific senses) are less similar than nodes that are deeper in the WordNet hierarchy, a property that is lacking in the edge distance measure.
P94-1019
Set-Up Using (verb,slot,noun) tuples from the corpus, we experimented with several ways of building sense profiles of each verb’s target argument slots (Resnik, 1993; Li and Abe, 1998; Clark and Weir, 2002).5 In both our pilot experiment and current development work, we found that the method of Clark and Weir (2002) overall gave better performance, and so we limit our discussion here to the results on their model.
J02-2003 J98-2002
In McCarthy (2000), the distributions are propagated to the lowest common subsumers (i.e., the nodes labelled B, C, and D).
A00-2034
By comparison, McCarthy (2000) attained 73% accuracy on her set of hand-selected test verbs in a similar task; however, when applied to our randomly selected verbs, our replication of her method achieved an overall performance of 67%, and performed very poorly on low frequency verbs.
A00-2034
Typical methods comprise an edgedistance measurement over the two sense nodes being compared within the hierarchy (Leacock and Chodorow, 1998; Rada et al., 1989; Wu and Palmer, 1994).
P94-1019
The text is parsed using the RASP parser (Briscoe and Carroll, 2002), and subcategorizations are extracted using the system of Briscoe and Carroll (1997).
A97-1052
Note that we did not hand-verify that individual verbs allowed or disallowed the alternation, as McCarthy (2000) had done, because we wanted to evaluate our method in the presence of noise of this kind.
A00-2034
Briefly, Clark and Weir (2002) populate the WordNet hierarchy based on corpus frequencies (of all nouns for a verb/slot pair), and then determine the appropriate probability estimate at each node in the hierarchy by using a24 a102 to determine whether to generalize an estimate to a parent node in the hierarchy.
J02-2003
In the calculation of SPD, we compare the two node distance measures, a119a7a6a9a8 (Wu and Palmer, 1994) and a119 a104a93a105a107a106a50a104, and the two ways of propagating sense profiles, without entropy (a52a48a61 ) and with entropy (a52a72a69 ), as described in Section 3.
P94-1019
Work Our method draws on, and extends, earlier work in verb lexical semantics (Resnik, 1993; McCarthy, 2000).
A00-2034
The method addresses conceptual problems of an earlier measure proposed by McCarthy (2000), which was limited to tree cut models (Li and Abe, 1998) and failed to distinguish detailed semantic differences between them.
A00-2034 J98-2002
1A tree cut for tree T is a set of nodes C in T such that every leaf node of T has exactly one member of C on a path between it and the root (Li and Abe, 1998).
J98-2002
We assume throughout the paper that WordNet node distance is the inverse of WordNet similarity, and indeed the similarity measures we use are directly invertible.) We illustrate with an example the differences between our measure and both McCarthy’s (2000) method and general vector distance measures.
A00-2034
McCarthy determines the sense profile of a verb/slot pair using a minimum description length tree cut model over the frequency-populated hierarchy (Li and Abe, 1998).
J98-2002
We suspect the problem is twofold, arising from the dependence of her method on tree cut models (Li and Abe, 1998).
J98-2002
The two profiles for a verb are “aligned” to permit comparison using skew divergence as a probability distance measure Lee (1999).
P99-1004
Other approaches instead assume a probability distribution over the entire sense hierarchy; similarity is captured between individual senses by a formula over the information content (negative log probabilities) of relevant nodes (e.g., Jiang and Conrath, 1997; Lin, 1998).
J98-2002
Because we demonstrate our new SPD measure on the same problem as McCarthy (2000), we provide more detail of her method here, for comparison.
A00-2034
Selection We evaluate our method on the causative alternation in order for comparison to the earlier method of McCarthy (2000).
A00-2034
For one, we invert (to obtain distance) the WordNet similarity measure of Wu and Palmer (1994), yielding: a26a15a96a72a97 a51 a20 a84a115a36 a20 a82a115a63a59a31 a26a15a29a90a37 a22 a35 a51 a20 a84 a63 a88 a26a15a29a90a37 a22 a35 a51 a20 a82 a63 a41a50a26a15a29a90a37 a22 a35 a51a34a98 a92 a74 a51 a20 a84 a36 a20 a82 a63a54a63 a36 (3) where a99a78a46a11a0a94a105a14a102a2a11a104a107a47a102a110a16a21a109 is the lowest common subsumer of a100a71a101 and a100a103a102 . The other method we use is the simple edge distance between nodes, a119a23a104a93a105a107a106a50a104 .4 Thus far, we have defined SPD as a sum of propagated profile scores multiplied by the distance “travelled” (equation 1).
P94-1019
We compare SPD to other measures applied directly to the (unpropagated) probability profiles given by the Clark-Weir method: the probability distribution distance given by skew divergence (skew) (Lee, 1999), as well as the general vector distance given by cosine (cos).
P99-1004
This means that the kind of straightforward propagation method used by McCarthy (2000) is not applicable to sense profiles of this type.
A00-2034
The two profiles become: a19a21a20a23a22a23a24a26a25a28a27 a29a32a31a34a33a35a37a36a6a35a39a38a40a37a36a6a35a37a38a41a37a36a4a35a39a36a14a35a37a36a6a35a39a36a14a35a37a36a6a35a39a38a41a37a36a6a35a37a38a43a42a13a44 a19a21a20a23a22a23a24a26a25a28a27a14a30 a31a34a33a35a37a36a6a35a39a36a6a35a37a36a14a35a39a38a45a39a36a6a35a37a38a45a39a36a4a35a39a38a41a37a36a6a35a37a38a41a37a36a6a35a39a36a6a35a46a44 In the first method (that of McCarthy, 2000), the two profiles become identical.
A00-2034
In McCarthy (2000), an error analysis reveals that the best method has more false positives than false negatives—some slots are considered overly similar because the sense profiles are compared at a coarse-grained level, losing fine semantic distinctions.
A00-2034
In a pilot experiment on a smaller, domain-specific corpus (6M words, medical domain) (Tsang and Stevenson, 2004), we randomly picked 18 causative verbs and 18 filler verbs for development and 20 causative verbs and 20 filler verbs for testing.
W04-2605
Similarly, McCarthy (2000) uses skew divergence (a variant of KL divergence proposed by Lee, 1999) to compare the sense profile of one argument of a verb (e.g., the subject position of the intransitive) to another argument of the same verb (e.g., the object position of the transitive), to determine if the verb participates in an argument alternation involving the two positions.
A00-2034 P99-1004
Evaluation We evaluate the SPD method on sense profiles created using the method of Clark and Weir (2002), with comparison to the other distance measures (skew and cos) as explained above.
J02-2003
Automatic detection of such argument alternations is important to acquisition of verb lexical semantics (Dang et al., 2000; Dorr and Jones, 2000; Merlo and Stevenson, 2001; Schulte im Walde and Brew, 2002; Tsang et al., 2002), and moreover, may play a role in automatic processing of language for applied tasks, such as question-answering (Katz et al., 2001), information extraction (Riloff and Schmelzenbach, 1998), detection of text relations (Teufel, 1999), and determination of verbparticle constructions (Bannard, 2002).
C00-2148 C02-1146 J01-3003 W01-1009 W98-1106
As in McCarthy (2000), we cast argument alternation detection as a comparison of sense profiles across two different argument positions of a verb.
A00-2034
It is worth noting that the method of Clark and Weir (2002) does not yield a tree cut, but instead generally populates the WordNet hierarchy with non-zero probabilities.
J02-2003
