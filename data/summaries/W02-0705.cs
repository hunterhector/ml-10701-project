Brown et al.(1993)). The value used for a26 a6a8a5a20a19a21a12a14a9 is first computed from counts of the number of bitexts in the training set in which a5 and a12 co-occur, in which a5 only appears, in which a12 only appears, and in which neither of them appear.
J93-2003
In some previous work (Alshawi et al., 1998; Alshawi et al., 2000a; Alshawi et al., 2000b) the training method constructs synchronized alignments in which each head word has at most two dependent phrases.
J00-1004
To make the similarity measure symmetrical, i.e. a121a81a6a8a5a10a111a31a19a21a5a45a123a55a9a20a36a128a121a81a6a8a5a45a123a104a19a21a5a10a111a33a9, we take the average of two relative entropy quantities: a121a81a6a8a5 a111 a19a21a5 a123 a9a7a36 a30a55a129a71a72 a6a88a97a130a6 a87 a6a88a124a10a89a5 a111 a9a25a89a110a89 a87 a6a88a124a10a89a5 a123 a9a21a9a131a38 a97a130a6 a87 a6a88a124a10a89a5a45a123a55a9a25a89a110a89 a87 a6a88a124a125a89a5a10a111a25a9a21a9a21a9 Of course, this is one of many different possible similarity measures which could have been used (cf Pereira et al.(1993)), including ones that do not depend on additional labels.
P93-1024
It is described in Alshawi et al.(2000b). 4 Similarity Cased-Based Transduction 4.1 Training the transduction parameters Our semantic similarity transduction method is a case-based (or example-based) method for transducing source strings to target strings that makes use of two different kinds of training data: a114 A set of source-string, target-string pairs that are instances of the transduction mapping.
J00-1004
One is the statistical dependency transduction model (Alshawi and Douglas, 2000; Alshawi et al., 2000b), a trainable generative statistical translation model using head transducers (Alshawi, 1996).
J00-1004
Since this model has been presented at length elsewhere (Alshawi, 1996; Alshawi et al., 2000a; Alshawi and Douglas, 2000), the description in this paper will be relatively compact.
J00-1004
The main component of a17 is the so-called a26 correlation measure (see Gale and Church (1991)) normalized to the range a27a28a29a19a31a30a33a32 with a28 indicating perfect correlation.
H91-1026
(For further details, see Alshawi and Douglas (2000).) To carry out translation with a dependency transduction model, we apply a “middle-out” dynamic programming search to find the optimal derivation.
J00-1004
Here we use the technique described by Alshawi and Douglas (2000) where the models have greater freedom to vary the granularity of phrase locality.
J00-1004
corresponds to synchronized dependency trees) if, roughly speaking, a2 induces an isomorphism between the dependency functions a3 and a4 (see Alshawi and Douglas (2000) for a more formal definition).
J00-1004
