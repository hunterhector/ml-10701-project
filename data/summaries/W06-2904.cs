This is an interesting test domain because Chinese does not have clearly de ned parts-of-speech, which makes lexical smoothing one of the most natural approaches to achieving reasonable results (Wang et al., 2005).
W05-1516
Finally, we compared our results to the probabilistic parsing approach of (Wang et al., 2005), which on this data obtained accuracies of 0.7631 on the CTB test set and 0.6104 on the development set.
W05-1516
Dependency relations have also been found to be useful in information extraction (Culotta and Sorensen, 2004; Yangarber et al., 2000).
A00-1039 P04-1054
Nevertheless, in this paper we follow the recent work of (Wang et al., 2005) and consider a completely lexicalized parser that uses no parts-ofspeech or grammatical categories of any kind.
W05-1516
Although (McDonald et al., 2005) explicitly describes this as an advantage over previous approaches (Ratnaparkhi, 1999; Yamada and Matsumoto, 2003), below we nd that changing the loss to enforce a more detailed set of constraints leads to a more effective approach.
P05-1012
maximum entropy ) to be applied (Ratnaparkhi, 1999; Charniak, 2000).
A00-2018
(Fox, 2002) found that the dependency structures of a pair of translated sentences have a greater degree of cohesion than phrase structures.
W02-1039
For example, smoothing methods have played a central role in probabilistic approaches (Collins, 1997; Wang et al., 2005), and yet they are not being used in current large margin training algorithms.
P97-1003 W05-1516
Learning in this context consisted of estimating the parameters of the model with simple likelihood based techniques, but incorporating various smoothing and back-off estimation tricks to cope with the sparse data problems (Collins, 1997; Bikel, 2004).
J04-4004 P97-1003
For parsing, the link scores in (1) are smoothed by word similarities (similar to the approach used by (Wang et al., 2005)) before the maximum score projective dependency tree is computed.
W05-1516
Fox. 2002.
W02-1039
Many methods have been proposed to compute distributional similarity between words, e.g., (Hindle, 1990; Pereira et al., 1993; Grefenstette, 1994; Lin, 1998).
P90-1034 P93-1024 P98-2127
Large margin training can be expressed as minimizing a regularized loss (Hastie et al., 2004) a45a58a113a115a114 a77 a116a117 a77 a78 a77 a118 (3) a59 a20 a45a47a39a26a48 a119a67a62a121a120 a4a123a122a25a20a124a9 a19 a20a100a17a102a101a125a4 sa4a68a77a75a9 a19 a20a100a17a126a101 sa4a68a77a75a9a44a122a25a20a100a17a14a17 where a19 a20 is the target tree for sentence a2 a20 ; a122 a20 ranges over all possible alternative trees in a31a32a4a33a2a127a20a33a17 ; sa4a68a77a102a9a19 a17a128a3 a129 a53a61a60a63a62a95a64a32a60a67a66a130a57a68a50a29a49 a77a54a78a102a79a67a4a6a5a16a20a105a21 a5a25a24a71a17 ; and a120 a4a123a122a25a20a124a9 a19 a20a100a17 is a measure of distance between the two trees a122a25a20 and a19 a20 . Using the techniques of (Hastie et al., 2004) one can show that minimizing (4) is equivalent to solving the quadratic program a45a47a113a115a114 a131a71a132a133 a116a117 a77a54a78a102a77a134a118a98a135a136a78a75a137 subject to (4) a138 a20a102a139 a120 a4 a19 a20a97a9a44a122a140a20a100a17a103a118 sa4a68a77a75a9a44a122a25a20a68a17a126a101 sa4a68a77a102a9 a19 a20a33a17 for all a141a44a9a44a122a25a20 a35 a31a32a4a33a2a142a20a68a17 which corresponds to the training problem posed in (McDonald et al., 2005).
P05-1012
Even though a part-of-speech lexicon has always been considered to be necessary in any natural language parser, (Wang et al., 2005) showed that distributional word similarities from a large unannotated corpus can be used to supplant part-of-speech smoothing with word similarity smoothing, to still achieve state of the art dependency parsing accuracy for Chinese.
W05-1516
In which case, the parsing problem reduces to a19a38a37 a3a40a39a42a41a44a43a46a45a47a39a26a48 a49a51a50a42a52a54a53a56a55a58a57 a59 a53a61a60a63a62a6a64a65a60a67a66a44a57a68a50a29a49 sa4a6a5 a20 a21a69a5 a24 a17 (1) where the score sa4a6a5a27a20a70a21 a5a25a24a71a17 can depend on any measurable property of a5a30a20 and a5a25a24 within the tree a19 . This formulation is suf ciently general to capture most dependency parsing models, including probabilistic dependency models (Wang et al., 2005; Eisner, 1996) as well as non-probabilistic models (McDonald et al., 2005).
C96-1058 P05-1012 W05-1516
Over the past decade, there has been tremendous progress on learning parsing models from treebank data (Collins, 1997; Charniak, 2000; Wang et al., 2005; McDonald et al., 2005).
A00-2018 P05-1012 P97-1003 W05-1516
To train a77 we follow the large margin training approach of (Taskar et al., 2003; Tsochantaridis et al., 2004), which has been applied with great success to dependency parsing (Taskar et al., 2004; McDonald et al., 2005).
P05-1012 W04-3201
Dependency trees are usually assumed to be projective (no crossing arcs), which means that if there is an arc a4a6a5a27a20a25a21a28a5a25a24a29a17, then a5a16a20 is an ancestor of all the words between a5a30a20 and a5a25a24 . Let a31a32a4a33a2a34a17 denote the set of all the directed, projective trees that span a2 . Given an input sentence a2, we would like to be able to compute the best parse; that is, a projective tree, a19a36a35 a31a32a4a33a2a34a17, that obtains the highest score . In particular, we follow (Eisner, 1996; Eisner and Satta, 1999; McDonald et al., 2005) and assume that the score of a complete spanning tree a19 for a given sentence, whether probabilistically motivated or not, can be decomposed as a sum of local scores for each link (a word pair).
C96-1058 P05-1012 P99-1059
(Cherry and Lin, 2003) exploited such cohesion between the dependency structures to improve the quality of word alignment of parallel sentences.
P03-1012
In fact, recently, effective conditional parsing models have been learned using relatively straightforward plug-in estimates, augmented with similarity based smoothing (Wang et al., 2005).
W05-1516
It turns out that probabilistic approaches pay closer attention to the individual errors made by each component of a parse, whereas the training error minimized in the large margin approach the structured margin loss (Taskar et al., 2003; Tsochantaridis et al., 2004; McDonald et al., 2005) is a coarse measure that only assesses the total error of an entire parse rather than focusing on the error of any particular component.
P05-1012 W04-3201
We converted them into dependency trees using the same method and headnding rules as in (Bikel, 2004).
J04-4004
It was found in (Bikel, 2004) that Collins’ parser made use of bi-lexical statistics only 1.49% of the time.
J04-4004
Following (Bikel, 2004), we used Sections 1-270 for training, Sections 271-300 for testing and Sections 301325 for development.
J04-4004
(Klein and Manning, 2003) presented an unlexicalized parser that eliminated all lexicalized parameters.
P03-1054
Nevertheless, extending our approach to directed features and contextual features, as in (Wang et al., 2005), remains an important direction for future research.
W05-1516
Despite the realization that maximum margin training is closely related to maximum conditional likelihood for conditional models (McDonald et al., 2005), a suf ciently uni ed view has not yet been achieved that permits the easy exchange of improvements between the probabilistic and nonprobabilistic approaches.
P05-1012
Collins. 1997.
P97-1003
Currently, the work on conditional parsing models appears to have culminated in large margin training (Taskar et al., 2003; Taskar et al., 2004; Tsochantaridis et al., 2004; McDonald et al., 2005), which currently demonstrates the state of the art performance in English dependency parsing (McDonald et al., 2005).
P05-1012 W04-3201
Most of the early work in this area was based on postulating generative probability models of language that included parse structure (Collins, 1997).
P97-1003
First, there are exponentially many constraints corresponding to each possible parse of each training sentence which forces one to use alternative training procedures, such as incremental constraint generation, to slowly converge to a solution (McDonald et al., 2005; Tsochantaridis et al., 2004).
P05-1012
One extension is to consider directed features, and contextual features like those used in current probabilistic parsers (Wang et al., 2005).
W05-1516
For standard scoring functions, parsing requires an a72a58a4a6a73a75a74a12a17 dynamic programming algorithm to compute a projective tree that obtains the maximum score (Eisner and Satta, 1999; Wang et al., 2005; McDonald et al., 2005).
P05-1012 P99-1059 W05-1516
In fact, it was found in (Gildea, 2001) that the removal of bi-lexical statistics from a state of the art PCFG parser resulted in very little change in the output.
W01-0521
