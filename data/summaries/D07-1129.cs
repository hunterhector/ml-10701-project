For the explanations of Labeled Attachment Score, Unlabeled Attachment Score and Label Accuracy, the readers are suggested to refer to the shared task introductory paper (Nivre et al., 2007).
D07-1096
In this paper, we investigate the effectiveness of structural correspondence learning (SCL) (Blitzer et al., 2006) in the domain adaptation task given by the CoNLL 2007.
W06-1615
The following is a summary given in (McDonald et al., 2005).
H05-1066
Unfortunately, we have discovered a bug in our codes after submitting our results for the blind tests, and the reported results in (Nivre et al., 2007) were not representative of our approach.
D07-1096
The paper is structured as follows: in section 2, we review the decoding and learning aspects of (McDonald et al., 2005), in section 3, structural correspondence learning applied to dependency parsing, and in section 4, we describe the experiments and the features needed for the CoNLL 2006 shared task.
H05-1066
We discriminatively trained our parser in an on-line fashion using a variant of the voted perceptron (Collins, 2002; Collins and Roark, 2004; Crammer and Singer, 2003).
P04-1015 W02-1001
Spanning Tree Algorithm As in (McDonald et al., 2005), we use Chu-LiuEdmonds (CLE) algorithm (Chu and Liu, 1965; Edmonds, 1967) for decoding.
H05-1066
c©2007 Association for Computational Linguistics Structural Correspondence Learning for Dependency Parsing Nobuyuki Shimizu Information Technology Center University of Tokyo Tokyo, Japan shimizu@r.dl.itc.u-tokyo.ac.jp Hiroshi Nakagawa Information Technology Center University of Tokyo Tokyo, Japan nakagawa@dl.itc.u-tokyo.ac.jp Abstract Following (Blitzer et al., 2006), we present an application of structural correspondence learning to non-projective dependency parsing (McDonald et al., 2005).
H05-1066 W06-1615
Our experiments were conducted on CoNLL-2007 shared task domain adaptation track (Nivre et al., 2007) using treebanks (Marcus et al., 1993; Johansson and Nugues, 2007; Kulick et al., 2004).
D07-1096 J93-2004
Learning Again following (McDonald et al., 2005), we have used the single best MIRA (Crammer and Singer, 2003), which is a “margin aware” variant of perceptron (Collins, 2002; Collins and Roark, 2004) for structured prediction.
H05-1066 P04-1015 W02-1001
During the training, the parser was trained with these additional features in addition to these described in (McDonald et al., 2005).
H05-1066
The reminder of the features are the same as ones used in (McDonald et al., 2005).
H05-1066
It is no longer rare to see dependency relations used as features, in tasks such as machine translation (Ding and Palmer, 2005) and relation extraction (Bunescu and Mooney, 2005).
H05-1091 P05-1067
Adaptation Following (Blitzer et al., 2006), we present an application of structural correspondence learning (SCL) to non-projective dependency parsing (McDonald et al., 2005).
H05-1066 W06-1615
