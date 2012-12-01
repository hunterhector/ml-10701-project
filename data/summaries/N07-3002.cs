Learning in this context consisted of estimating the parameters of the model with simple likelihood based techniques, but incorporating various smoothing and back-off estimation tricks to cope with the sparse data problems (Collins, 1997; Bikel, 2004).
J04-4004 P97-1003
In which case, the parsing problem reduces to a18a37a36 a1a39a38a41a40a43a42a45a44a46a38a48a47 a49a22a50a41a51a53a52a55a54a57a56 a58 a52a60a59a62a61a5a63a64a59a66a65a43a56a67a50a26a49 sa2a5a4a29a19a22a21a23a4a25a24a28a16 (1) where the score sa2a5a4 a19 a21 a4 a24 a16 can depend on any measurable property of a4a20a19 and a4a25a24 within the tree a18 . This formulation is suf ciently general to capture most dependency parsing models, including probabilistic dependency models (Wang et al., 2005; Eisner, 1996) as well as non-probabilistic models (McDonald et al., 2005; Wang et al., 2006).
C96-1058 E06-1011 P05-1012 W05-1516 W06-2904
Bikel. 2004.
J04-4004
Over the past decade, there has been tremendous progress on learning parsing models from treebank data (Magerman, 1995; Collins, 1999; Charniak, 1997; Ratnaparkhi, 1999; Charniak, 2000; Wang et al., 2005; McDonald et al., 2005).
A00-2018 P05-1012 P95-1037 P97-1003 W05-1516
The structured large margin approach, on the other hand, uses a global scoring function by minimizing a training loss the structured margin loss (McDonald et al., 2005) which is directly coordinated with the global tree.
P05-1012
To cope with the sparse data problem, I use distributional word similarity (Pereira et al., 1993; Grefenstette, 1994; Lin, 1998) to generalize the observed frequency counts in the training corpus.
P93-1024 P98-2127
Despite the realization that maximum margin training is closely related to maximum conditional likelihood for conditional models (McDonald et al., 2005), a suf ciently uni ed view has not yet been achieved that permits the easy exchange of improvements between the probabilistic and nonprobabilistic approaches.
P05-1012
5) 77.6a75 a76 Obtained with Chinese Treebank 4.0 using the data split reported in Wang et al.(2005). a77 Obtained with Chinese Treebank 5.0 using the data split reported in Corston-Olivr et al.(2006). 6 Current Results Table 1 compares my results1 with those obtained by other researchers, on both English and Chinese data.2 The English results are obtained using the same standard training and test set splits from English Penn Treebank 3.0.
W05-1516
Furthermore, I based training on maximizing the conditional probability of a parse tree given a sentence, unlike most previous generative models (Magerman, 1995; Collins, 1997; Charniak, 1997), which focus on maximizing the joint probability of the parse tree and the sentence.
P95-1037 P97-1003
The results on Chinese are obtained on two different data sets, Chinese Treebank 4.0 and Chinese Treebank 5.0 as noted.3 Table 1 shows that the results I am able to achieve on English are competitive with the state of the art, but are still behind the best results of (McDonald and Pereira, 2006).
E06-1011
Most of the early work in this area was based on postulating generative probability models of language that included parse structures (Magerman, 1995; Collins, 1997; Charniak, 1997).
P95-1037 P97-1003
Another unexploited connection is that probabilistic approaches pay closer attention to the individual errors made by each component of a parse, whereas the training error minimized in the large margin approach the structured margin loss (McDonald et al., 2005) is a coarse measure that only assesses the total error of an entire parse rather than focusing on the error of any particular component.
P05-1012
Dependency Parsing To learn an accurate dependency parser from data, the rst approach I investigated is based on a strictly lexical parsing model where all the parameters are based on words (Wang et al., 2005).
W05-1516
Furthermore, I plan to apply my parsers in other domains (e.g., biomedical data) (Blitzer et al., 2006) besides treebank data, to investigate the effectiveness and generality of my approaches.
W06-1615
2McDonald et al.(2005) have tried MIRA on Chinese Treebank 4.0 with the same data split reported here, obtaining a dependency accuracy score of 82.5 (Ryan McDonald, personal communication).
P05-1012
For example, smoothing methods have played a central role in probabilistic approaches (Collins, 1997; Wang et al., 2005), and yet they are not being used in current large margin training algorithms.
P97-1003 W05-1516
maximum entropy ) to be applied (Ratnaparkhi, 1999; Charniak, 2000).
A00-2018
Dependency trees are usually assumed to be projective (no crossing arcs), which means that if there is an arc a2a5a4a20a19a15a21a27a4a25a24a28a16, then a4a29a19 is an ancestor of all the words between a4a30a19 and a4a25a24 . Let a31a7a2a32a0a33a16 denote the set of all the directed, projective trees that span a0 . From an input sentence a0, one would like to be able to compute the best parse; that is, a projective tree, a18a35a34 a31a7a2a32a0a33a16, that obtains the highest score . In particular, I follow Eisner (1996) and McDonald et al.(2005) and assume that the score of a complete spanning tree a18 for a given sentence, whether probabilistically motivated or not, can be decomposed as a sum of local scores for each link (a word pair).
C96-1058 P05-1012
In the second approach, I improve structured large margin training for parsing in two ways (Wang et al., 2006).
W06-2904
Currently, the work on conditional parsing models appears to have culminated in large margin training approaches (Taskar et al., 2004; McDonald et al., 2005), which demonstrates the state of the art performance in English dependency parsing.
P05-1012 W04-3201
