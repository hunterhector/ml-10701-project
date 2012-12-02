A probability of derivation tree D = {〈α i,η α j,r i 〉} is generally defined as follows (Schabes et al., 1988; Chiang, 2000).
C88-2121 P00-1058
However, existing models of disambiguation with lexicalized grammars are a mere extension of lexicalized probabilistic context-free grammars (LPCFG) (Collins, 1996; Collins, 1997; Charniak, 1997), which are based on the decomposition of parsing results into the syntactic/semantic dependencies of two words in a sentence under the assumption of independence of the dependencies.
P96-1025 P97-1003
what does student want to write your Figure 3: A derivation tree of lexicalized parse trees, such as the distinction of arguments/modifiers and unbounded dependencies (Collins, 1997), are elegantly represented in derivation trees.
P97-1003
trees Recent work on the automatic extraction of LTAG (Xia, 1999; Chen and Vijay-Shanker, 2000) and disambiguation models (Chiang, 2000) has been the first on the statistical model for syntactic disambiguation based on lexicalized grammars.
P00-1058
Derivation trees, the structural description in LTAG (Schabes et al., 1988), represent the association of lexical items i.e., elementary trees.
C88-2121
Recent studies on the automatic extraction of lexicalized grammars (Xia, 1999; Chen and Vijay-Shanker, 2000; Hockenmaier and Steedman, 2002a) allow the modeling of syntactic disambiguation based on linguistically motivated grammar theories including LTAG (Chiang, 2000) and CCG (Clark et al., 2002; Hockenmaier and Steedman, 2002b).
P00-1058 P02-1042 P02-1043
Recently used machine learning methods including maximum entropy models (Berger et al., 1996) and support vector machines (Vapnik, 1995) provide grounds for this type of modeling, because it allows various dependent features to be incorporated into the model without the independence assumption.
J96-1002
Abney. 1997.
J97-4005
In particular, when we apply Feature-Based LTAG (FBLTAG), the above probability is no longer consistent because of the non-local constraints caused by feature unification (Abney, 1997).
J97-4005
Although we needed to compute normalizing factor Z c to obtain probability values, we used unnormalized products as the preference score for beam thresholding, following (Clark et al., 2002).
P02-1042
A possible solution to this problem is to directly estimate p(A|w) by applying a maximum entropy model (Berger et al., 1996).
J96-1002
We have not adopted the local contexts of words as in the supertaggers in LTAG (Joshi and Srinivas, 1994) because they partially include the semantic preferences of a sentence.
C94-1024
We did not use any preprocessing such as supertagging (Joshi and Srinivas, 1994) and the parser searched for the most plausible derivation tree from the derivation forest in terms of the probability given by the combination of syntax and semantics probabilities.
C94-1024
structures A disambiguation model for wide-coverage CCG (Clark et al., 2002) aims at representing deep linguistic dependencies including long-distance dependencies and control relations.
P02-1042
We evaluated the validity of our model through experiments on a disambiguation task of parsing the Penn Treebank (Marcus et al., 1994) with an automatically acquired LTAG grammar.
H94-1020
The parsing algorithm was CKY-style parsing with beam thresholding, which was similar to ones used in (Collins, 1996; Clark et al., 2002).
P02-1042 P96-1025
The model proposed in Section 3 is generally applicable to any lexicalized grammars, and this section reports the evaluation of our model with a wide-coverage LTAG grammar, which is automatically acquired from the Penn Treebank (Marcus et al., 1994) Sections 02–21.
H94-1020
A series of studies on parsing with wide-coverage LFG (Johnson et al., 1999; Riezler et al., 2000; Riezler et al., 2002) have had a similar motivation to ours.
P00-1061 P02-1035 P99-1069
We have only two ways of adhering to LPCFG models: preserve the consistency of probability models by abandoning improvements to the lexicalized grammars using complex constraints (Chiang, 2000), or ignore the inconsistency in probability models (Clark et al., 2002).
P00-1058 P02-1042
To cope with this, we adopted an algorithm of maximum entropy estimation for feature forests (Miyao and Tsujii, 2002; Geman and Johnson, 2002), which allows parameters to be efficiently estimated.
P02-1036
To cope with this problem, we applied an efficient algorithm of maximum entropy estimation for feature forests (Miyao and Tsujii, 2002; Geman and Johnson, 2002).
P02-1036
Using this model, we can assign consistent probabilities to parsing results with complex structures, such as ones represented with feature structures (Abney, 1997; Johnson et al., 1999).
J97-4005 P99-1069
parse trees The first successful work on syntactic disambiguation was based on lexicalized probabilistic context-free grammar (LPCFG) (Collins, 1997; Charniak, 1997).
P97-1003
For example, when we apply a unification-based grammar, LPCFG-like modeling results in an inconsistent probability model because the model assigns probabilities to parsing results not allowed by the grammar (Abney, 1997).
J97-4005
Since an existing study incorporates these relations ad hoc (Collins, 1997), they are apparently crucial in accurate disambiguation.
P97-1003
