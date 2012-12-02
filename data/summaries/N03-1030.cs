For this evaluation, we re-trained Charniak’s parser (2000) such that the test sentences from the discourse corpus were not seen by the syntactic parser during training.
A00-2018
The performance is assessed using labeled recall and labeled precision as de ned by the standard Parseval metric (Black et al., 1991).
H91-1060
We apply canonical lexical head projection rules (Magerman, 1995) in order to lexicalize syntactic trees.
P95-1037
Given a sentence a2a44a43a46a45a39a47a12a45a49a48a51a50a52a50a4a50a10a45a49a53a54a50a4a50a52a50a55a45a49a56, we rst nd the syntactic parse tree a7 of a2 . We used in our experiments both syntactic parse trees obtained using Charniak’s parser (2000) and syntactic parse trees from the PennTree bank.
A00-2018
For example, Gildea and Jurafsky (2002) developed statistical models for automatically inducing semantic roles.
J02-3001
Recall Precision F-score a174a113a66a4a112a65a147 28.2 37.1 32.0 a174a74a145a32a112a65a147 25.4 64.9 36.5 a112a113a18a20a11a29a112a170a147 77.1 83.3 80.1 a147a137a3a22a5a117a112a65a147a49a21a95a15a177a183a173a24 82.7 83.5 83.1 a147a62a3a6a5a117a112a170a147a49a21a95a15a44a184a144a24 85.4 84.1 84.7 a149a88a112a170a147 98.2 98.5 98.3 Table 1: Discourse segmenter evaluation Table 1 shows the results obtained by the algorithm described in this paper (a147a62a3a6a5a117a112a170a147a49a21a95a15a104a183a185a24 ) using syntactic trees produced by Charniak’s parser (2000), in comparison with the results obtained by the algorithm described in (Marcu, 2000) (a112a113a18a20a11a29a112a170a147 ), and baseline algorithms a174a113a66a27a112a170a147 and a174a74a145a33a112a170a147, on the same test set.
A00-2018
The discourse parsing model uses syntactic trees produced by Charniak’s parser (2000) and discourse segments produced by the algorithm described in Section 3.
A00-2018
The problem of sentence segmentation has been studied extensively, and tools such as those described by Palmer and Hearst (1997) and Ratnaparkhi (1998) can handle it well.
J97-2002
For example, Gildea and Jurafsky (2002) present a semantic parser that optimistically assumes that has access to perfect semantic segments.
J02-3001
Another interesting nding is that the performance of current state-of-the-art syntactic parsers (Charniak, 2000) is not a bottleneck for coming up with a good solution to the sentence-level discourse parsing problem.
A00-2018
By exploiting information encoded in human-produced syntactic trees (Marcus et al., 1993), research on probabilistic models of syntax has driven the performance of syntactic parsers to about 90% accuracy (Charniak, 2000; Collins, 2000).
A00-2018 J93-2004
Magerman. 1995.
P95-1037
