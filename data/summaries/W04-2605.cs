By comparison, McCarthy (2000) attained 73% accuracy on her set of hand-selected test verbs in a similar task; however, when applied to our various sets of randomly selected verbs, our replication of her method performed very poorly, rarely reaching above chance performance.
A00-2034
The text is parsed using the RASP parser (Briscoe and Carroll, 2002), and subcategorizations are extracted using the system of Briscoe and Carroll (1997).
A97-1052
(Note that we did not hand-verify that individual verbs allowed or disallowed the alternation, as McCarthy (2000) had done, because we wanted to evaluate our method in the presence of noise of this kind.) Verbs that occur a minimum of 10 times per frame are chosen.
A00-2034
Furthermore, we note that recent work indicates that verb alternations may also play a role in automatic processing of language for applied tasks, such as question-answering (Katz et al., 2001), detection of text relations (Teufel, 1999), and determination of verb-particle constructions (Bannard, 2002).
W01-1009
In contrast to comparing head nouns directly, McCarthy (2000) instead compares the selectional preferences for each of the two slots (captured by a probability distribution over WordNet).
A00-2034
The method addresses conceptual problems of an earlier measure proposed by McCarthy (2000), which was limited to tree cut models (Li and Abe, 1998) and failed to distinguish detailed semantic differences between them.
A00-2034 J98-2002
Naturally, we look to the current research comparing semantic similarity between word senses (e.g., Budanitsky and Hirst, 2001; Lin, 1998).
J98-2002
In McCarthy (2000), an error analysis reveals that the best method has more false positives than false negatives—some slots are considered overly similar because the selectional profiles are compared at a coarsegrained level, losing fine semantic distinctions.
A00-2034
Evaluation We evaluate the SPD method on selectional profiles created using the method of Clark and Weir (2002), with comparison to the other distance measures as explained above.
J02-2003
The approach of McCarthy (2000), on the other hand, addresses the generalization problem by comparing probability distributions over WordNet.
A00-2034
We will refer in the remainder of the paper to such a probability distribution over WordNet as a “selectional profile.” As mentioned above, McCarthy (2000) suggested the use of selectional profiles to capture generalizations over argument slots, so that two argument slots could be effectively compared for detecting alternations.
A00-2034
After extracting the argument heads of the target slots of each verb (e.g., the intransitive subject and the transitive object for the causative alternation), she then determined their selectional profiles using a minimum description length tree cut model (Li and Abe, 1998).3 The two slot profiles were compared using skew divergence (a variant of 2Resnik’s proposed measure is not actually a probability distribution, but a difference between probability distributions.
J98-2002
For one, we invert (to obtain distance) the WordNet similarity measure of Wu and Palmer (1994), yielding: a26a15a96a72a97 a58 a20a76a84a64a42a93a20a38a82 a69 a34 a26a15a29 a37 a22a90a35 a58 a20 a84 a69 a88 a26a15a29 a37 a22a90a35 a58 a20 a82 a69 a45a50a26a15a29 a37 a22a90a35 a58a34a98 a92 a74 a58 a20a76a84a64a42a90a20a38a82 a69a26a69 a42 (3) where a99a78a46a11a0 a107a6a104a2a11a106a109a18a104 a17 a111 is the lowest common subsumer of a100a71a101 and a100a103a102 . The other method we use is the simple edge distance between nodes, a118a23a104a93a105a107a106a50a104 .6 Thus far, we have defined SPD as a sum of propagated profile scores multiplied by the distance “travelled” (equation 1).
P94-1019
Correspondingly, the relation between alternation patterns and meaning is a key focus in the computational study of the lexical semantics of verbs (e.g., Allen, 1997; Dang et al., 2000; Dorr and Jones, 2000; Merlo and Stevenson, 2001; Schulte im Walde and Brew, 2002; Tsang et al., 2002).
C00-2148 C02-1146 J01-3003
This means that the kind of straightforward propagation method used by McCarthy (2000) is not applicable to selectional profiles of this type.
A00-2034
Selection We evaluate our method on the causative alternation in order for comparison to the earlier methods of McCarthy (2000) and Merlo and Stevenson (2001).
A00-2034 J01-3003
In the calculation of SPD, we compare the two node distance measures, a118a1a0a3a2 (Wu and Palmer, 1994) and a118 a104a93a105a107a106a50a104, and the two ways of propagating selectional profiles, without entropy (a52a48a61 ) and with entropy (a52a72a69 ), as de7Recall that a selectional profile is a probability distribution over WordNet.
P94-1019
Using (verb,slot,noun) frequencies, we experimented with several ways of building selectional profiles of each verb’s argument slot (Resnik, 1993; Li and Abe, 1998; Clark and Weir, 2002).7 In our development work, we found that the method of Clark and Weir (2002) overall gave better performance, and so we limit our discussion here to the results on their model.
J02-2003 J98-2002
We assume throughout the paper that WordNet distance is the inverse of WordNet similarity, and indeed the similarity measures we use are directly invertible.) We illustrate with an example the differences between our measure and both McCarthy’s (2000) method and general vector distance measures.
A00-2034
In this example, one can propagate the distributions to the lowest common subsumers (i.e., B, C, and D) as in McCarthy (2000).
A00-2034
The two profiles become: a22a24a23a28a25a28a27a50a29a32a31a4a33a51a34a52a36 a38a44a42a19a38a40a39 a41a44a42a19a38a44a39 a45a44a42a14a38a40a42a6a38a44a42a19a38a40a42a6a38a44a42a19a38a40a39 a45a44a42a19a38a44a39a54a53a4a47 a22a24a23a28a25a28a27a50a29a32a31 a48 a34a52a36 a38a44a42a19a38a40a42a19a38a44a42a6a38a40a39 a46a40a42a19a38a44a39 a46a40a42a14a38a40a39 a45a44a42a19a38a44a39 a45a44a42a19a38a40a42a19a38a20a47 In the first method (that of McCarthy, 2000), the two profiles become identical.
A00-2034
tactic positions (or slots) that alternate—such as snow occurring as intransitive subject and transitive object in the causative alternation in (1) (Merlo and Stevenson, 2001; McCarthy, 2000).
A00-2034 J01-3003
Note that Wu and Palmer (1994) designed their measure such that shallow nodes are less similar than nodes that are deeper in the WordNet hierarchy.
P94-1019
Formalization of this notion has been difficult, but several computational methods have now been proposed that capture selectional preference of a verb as a probability distribution over the WordNet hierarchy (Resnik, 1993; Li and Abe, 1998; Clark and Weir, 2002).2 The key task that each of these proposals address is how to generalize appropriately from counts of observed nouns in the relevant verb argument position (in a corpus), to a probabilistic representation of selectional strength over classes.
J02-2003 J98-2002
(For comparison, McCarthy (2000) achieves 73% on her set of hand-selected verbs, but our implementation of her method yields much lower performance on our randomly selected test verbs.) In the next section, we present background work on capturing selectional preferences in WordNet, and on using them to detect alternations.
A00-2034
Some of this work has focused on subcategorization patterns as the clear syntactic cue to an alternation (Lapata, 1999; Lapata and Brew, 1999; Schulte im Walde and Brew, 2002).
P99-1051 W99-0632
As a cue to this alternation, Merlo and Stevenson (2001) create a bag of head nouns for each of the two potentially alternating slots, and compare them.
J01-3003
It is worth noting that the method of Clark and Weir (2002) does not yield a tree cut, but instead generally populates the WordNet hierarchy with non-zero probabilities.
J02-2003
The method used by Merlo and Stevenson (2001) has the advantage of directly capturing similarity between slots (in terms of use of identical nouns [lemmas]), but fails to generalize over the nouns, lending itself to sparse data problems.
J01-3003
