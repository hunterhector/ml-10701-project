(Xue and Palmer, 2004; Pradhan et al., 2004)) in the learning algorithm.
W04-3212
In (Moschitti, 2004), an alternative to the SCF extraction was proposed, i.e. the SCF kernel (SK).
P04-1043
A preliminary study on the benefit of such kernels was measured on the classification accuracy of semantic arguments in (Moschitti, 2004).
P04-1043
To verify that the kernel representation is superior to the traditional representation we carried out an experiment using a flat feature representation of the SCFs, i.e. we used the syntactic frame feature described (Xue and Palmer, 2004) in place of SK.
W04-3212
Both training and testing sentences were processed using Collins’ parser (Collins, 1997) to generate parse-tree automatically.
P97-1003
As the polynomial kernel with degree 3 was shown to be the most accurate for the argument classification (Pradhan et al., 2004; Moschitti, 2004) we use it to build two kernel combinations: • Poly + SK: KPoly|KPoly| + γ KT|KT|, i.e. the sum between the normalized polynomial kernel (see Section 2.3) and the normalized SK2.
P04-1043
(Gildea and Jurasfky, 2002; Gildea and Palmer, ; Gildea and Hockenmaier, 2003; Pradhan et al., 2004).
J02-3001 P02-1031 W03-1008
PB, available at www.cis.upenn.edu/∼ace, is used along with the Penn TreeBank 2 (www.cis.upenn.edu /∼treebank) (Marcus et al., 1993).
J93-2004
(Gildea and Jurasfky, 2002; Pradhan et al., 2004; Gildea and Palmer, ).
J02-3001 P02-1031
Frame Kernel (SK) The convolution kernel that we have experimented was devised in (Moschitti, 2004) and is characterized by two aspects: the semantic space of the subcategorization structures and the kernel function that measure their similarities.
P04-1043
These standard features, firstly proposed in (Gildea and Jurasfky, 2002), refer to a flat information derived from parse trees, i.e.
J02-3001 P02-1031
Classification set-up The evaluations were carried out with the SVMlight-TK software (Moschitti, 2004) available at http://ai-nlp.info.uniroma2.it/moschitti/ which encodes the tree kernels in the SVM-light software (Joachims, 1999).
P04-1043
