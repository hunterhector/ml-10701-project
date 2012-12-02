We are also aware of a few alternatives in grammatical formalisms that could capture such flatness, e.g., sister adjunction (Chiang, 2000).
P00-1058
are the labeled parsing recall and precision, respectively, as defined in (Collins, 1997) (slightly different from (Black et al., 1991)).
H91-1060 P97-1003
also (Ng and Tomita, 1991; Wright et al., 1991; Abney et al., 1999)).
P99-1070
The LR approach for parsing has long been considered for natural language parsing (Lang, 1974; Tomita, 1985; Wright and Wrigley, 1991; Shieber, 1983; Pereira, 1985; Merlo, 1996), but it was not until a more recent past, with the advent of corpusbased techniques made possible by the availability of large treebanks, that parsing results and evaluation started being reported (Briscoe and Carroll, 1993; Inui et al., 1997; Carroll and Briscoe, 1996; Ruland, 2000).
C00-2098 J93-1002 P83-1017 W96-0209
Concrete LR-like algorithms for TAGs have only recently been proposed (Prolo, 2000; Nederhof, 1998), though their evaluation was restricted to the quality of the parsing table (see also (Schabes and Vijay-Shanker, 1990; Kinyon, 1997) for earlier attempts).
P90-1035 P98-2156
Shieber. 1983.
P83-1017
Following (Briscoe and Carroll, 1993), conflict resolution is based on contextual information extracted from the so called Instantaneous Description or Configuration: a stack, representing the control memory of the LR parser, and a lookahead sequence, here limited to one symbol.1 However, while Briscoe and Carroll invested on massive parallel computation of the possible parsing paths, with pruning and posterior ranking, we ex1Unlike (Wright and Wrigley, 1991)’s approach who tries to transpose PCFG probabilities to LR tables, facing difficulties which, to the best of our knowledge, have not been yet solved to content (cf.
J93-1002
This is similar to (Collins, 1997)’s and Charniak97’s definition of a separate category for auxiliary verbs.
P97-1003
We are currently working on a version of the LR parser for a subclass of TAGs, the Tree Insertion Grammars (Schabes and Waters, 1995), for which efficient true LR parsers can be obtained.
J95-4002
103-110. Proceedings of the Conference on Empirical Methods in Natural periment with a simple greedy depth-first technique with limited amount of backtracking, that resembles to a certain extent the commitment/recovery models from the psycholinguistic research on human language processing, supported by the occurrence of “garden paths”.2 We use the Penn Treebank WSJ corpus, release 2 (Marcus et al., 1994), to evaluate the approach.
H94-1020
As for the accuracy, it is not far from the top performing parser for parts-of-speech that we are aware of, reported by (Sima’an, 2000): recall/precision = a12a14a13 a14 a13a16a15a57a49a14a12a14a13 a14a18a17a11a17 Perhaps the most similar work to ours is Briscoe and Carroll’s (1993; 1995; 1992; 1996).
J93-1002 W96-0209
Then we update a39 a23 a32 a29a65a33 a1 a39 a23 a32 a29a65a33 a51 a27a28a24a30a29 a0 a32 a24 a8 a29a65a33 and start another branch in the tree by executing a24 . 4 Evaluation We evaluated the approach using the Penn Treebank WSJ Corpus, release 2 (Marcus et al., 1994), using Sections 2 to 21 for grammar extraction and training, section 0 for development and 23 for testing.
H94-1020
