(%) 1 htsa3 (Grozea, 2004) 72.9 2 IRST-kernels (Strapparava et al., 2004) 72.6 3 nusels (Lee et al., 2004) 72.4 4 SENSEVAL-3 contest baseline 55.2 5 Niu et al.(Niu et al., 2005) LP/J-S 70.3 6 Niu et al.LP/cosine 68.4 7 Niu et al.SVM 69.7 Table 2: Accuracy results of other published systems on SENSEVAL-3.
P05-1049 W04-0831 W04-0834 W04-0856
These synthesized nodes are akin to the dongle nodes (Goldberg and Zhu, 2006).
W06-3808
To analyze the in uence of training set size on accuracy, we randomly sample subsets of the training data (25%, 50%, and 75%) and use the remaining training data plus the test data as unlabeled data, similarly to the procedure followed in related work (Niu et al., 2005).
P05-1049
In line with existing work (Lee and Ng, 2002; Niu et al., 2005), we use the following features: • Integer × 7: seven features consisting of the POS of the previous three words, the POS of the next three words, and the POS of the word itself.
P05-1049 W02-1006
In addition to the 11 collocations used in similar work (Lee and Ng, 2002), we also used C−3,1, C−3,2, C−2,3, C−1,3.
W02-1006
Lee. 2004.
W04-0834
4.2 SENSEVAL-3 word sense disambiguation task The second task is word sense disambiguation using the SENSEVAL-3 corpus (Mihalcea et al., 2004), to enable a comparison of our method with previously published results.
W04-0807
Several graph-based learning techniques have recently been developed and applied to NLP problems: minimum cuts (Pang and Lee, 2004), random walks (Mihalcea, 2005; Otterbacher et al., 2005), graph matching (Haghighi et al., 2005), and label propagation (Niu et al., 2005).
H05-1049 H05-1052 H05-1115 P04-1035 P05-1049 W04-0834
The Niu et al.work (Niu et al., 2005) is most comparable to ours.
P05-1049
We used the MXPOST tagger (Ratnaparkhi, 1996) for POS annotation.
W96-0213
In NLP, label propagation has been used for word sense disambiguation (Niu et al., 2005), document classi cation (Zhu, 2005), sentiment analysis (Goldberg and Zhu, 2006), and relation extraction (Chen et al., 2006).
P05-1049 P06-1017 W06-3808
The approach of setting different limits among different kinds of nodes is also used in related work (Goldberg and Zhu, 2006).
W06-3808
Note that syntactic features, which have been used in some previous studies on this dataset (Mohammad and Pedersen, 2004), were not included.
W04-0839
