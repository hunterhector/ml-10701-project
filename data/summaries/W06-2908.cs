In this paper, we employ this deﬁnition, since Kazama and Torisawa (2005) reported that the MOLT kernel with this deﬁnition has a higher accuracy than one with the deﬁnition presented by Collins and Duffy (2001).
H05-1018
kernel Although Kazama and Torisawa (2005) evaluated the MOLT kernel for SRL, the evaluation was only on the role assignment task and was preliminary.
H05-1018
However, our current system is worse than the systems reported in the CoNLL 2005 shared task in any case, since it is reported that they had F1 = 79.92 to 83.78 argument recognition accuracy (Carreras and M`arquez, 2005).
W05-0620
Although Kazama and Torisawa (2005) presented fast training with tree kernels, the slow classiﬁcation during runtime remained to be solved.
H05-1018
In addition, this method became possible because of the WMOLT kernel, and it is hard to apply to Moschitti and Bejan (2004) where the tree structure changes during recognition.
P04-1043 W04-2403
To solve these errors, we need to explore more, such as using n-best parses and the use of several syntactic views (Pradhan et al., 2005b).
P05-1072
Kazama and Torisawa (2005) proposed a new tree kernel for node relation labeling, as which SRL can be cast.
H05-1018
Moschitti and Bejan (2004) extensively studied tree kernels for semantic role labeling.
P04-1043 W04-2403
To enforce this constraint, we employ the approach presented by Toutanova et al.(2005). Given the local classiﬁcation probability p(nk = Xk) (Xk ∈ {ARG,NO-ARG}), this method ﬁnds the assignment that maximizes∏ k p(nk = Xk) while satisfying the above nonoverlapping constraint, by using a dynamic programming procedure.
P05-1073
Kazama and Torisawa (2005) proposed to represent a node relation in a tree as a marked ordered labeled tree and presented a kernel for it (MOLT kernel).
H05-1018
For example, the combination of small SVMs (Shen et al., 2003) is a possible direction.
W03-1012
The MOLT kernel also has an O(|T1||T2|) DP procedure (Kazama and Torisawa, 2005).
H05-1018
For the WMOLT kernel, we can derive O(|T1||T2|) DP procedure by slightly modifying the procedure presented by Kazama and Torisawa (2005).
H05-1018
The method for speeding up training described in Kazama and Torisawa (2005) can also be applied with a slight modiﬁcation.
H05-1018
Kazama and Torisawa (2005) proposed a method that drastically speeds up the calculation during training by converting trees into efﬁcient vectors using a tree mining algorithm.
H05-1018
of sentences) 250 500 700 1,000 setting dev test setting dev test setting dev test setting dev test γ (λ,C) (F1) (F1) (λ,C) (F1) (F1) (λ,C) (F1) (F1) (λ,C) (F1) (F1) 1 0.15, 20.50 63.66 65.13 0.2, 20.50 69.01 70.33 0.2, 20.50 72.11 73.57 0.25, 12.04 75.38 76.25 100 0.3, 12.04 80.13 80.85 0.3,500 82.25 82.98 0.3, 34.92 83.93 84.72 0.3, 3.18 85.09 85.85 1,000 0.2, 2.438 82.65 83.36 0.2, 2.438 84.80 85.45 0.2, 3.182 85.58 86.20 0.2, 7.071 86.40 86.80 2,000 0.2, 2.438 83.43 84.12 0.2, 2.438 85.56 86.24 0.2, 2.438 86.23 86.80 0.2, 12.04 86.61 87.18 4,000 0.2, 2.438 83.87 84.50 0.15, 4.15 84.94 85.61 0.15, 7.07 85.84 86.32 0.2, 12.04 86.82 87.31 4,000 (w/o) 80.81 81.41 80.71 81.51 81.86 82.33 84.27 84.63 empirically O(L2) where L is the number of training examples, regardless of the use of the speed-up method (Kazama and Torisawa, 2005), However, we can observe that the WMOLT kernel achieves a high accuracy even when the training data is very small.
H05-1018
kernel A marked ordered labeled tree (Kazama and Torisawa, 2005) is an ordered labeled tree in which each node can have a mark in addition to a label.
H05-1018
Compared to (Moschitti and Bejan, 2004) where tree fragments are heuristically extracted before applying tree kernels, the MOLT kernel is general and desirable since it does not require such fragment extraction.
P04-1043 W04-2403
For example, the recent CoNLL 2005 shared task (Carreras and M`arquez, 2005) provided parse trees for use and their usefulness was ensured.
W05-0620
We extend the kernels on marked ordered labeled trees (Kazama and Torisawa, 2005) so that the mark can be weighted according to its importance.
H05-1018
The tuning was performed using the method for speeding up the training with tree kernels described by Kazama and Torisawa (2005).
H05-1018
However, the evaluation conducted by Kazama and Torisawa (2005) was limited to preliminary experiments for role assignment.
H05-1018
The weighting in Kazama and Torisawa (2005) is written as fol2This notation is slightly different from (Kazama and Torisawa, 2005).
H05-1018
Kazama and Torisawa (2005) presented a kernel on marked ordered trees (the MOLT kernel), which is deﬁned as:2 K(T1,T2) = E∑ i=1 W(Si)·#Si(T1)·#Si(T2), where Si is a possible subtree and #Si(Tj) is the number of times Si is included in Tj.
H05-1018
As this task is recognized as an important step after (or the last step of) syntactic analysis, many studies have been conducted to achieve accurate semantic role labeling (Gildea and Jurafsky, 2002; Moschitti, 2004; Hacioglu et al., 2004; Punyakanok et al., 2004; Pradhan et al., 2005a; Pradhan et al., 2005b; Toutanova et al., 2005).
C04-1197 J02-3001 P04-1043 P05-1072 P05-1073 W04-2403 W04-2416 W05-0407
Although Moschitti et al.(2005) reported on argument recognition using tree kernels, it was a preliminary evaluation because they used oracle parse trees.
W05-0407
