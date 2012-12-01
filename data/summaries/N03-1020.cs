A series of workshops on automatic text summarization (WAS 2000, 2001, 2002), special topic sessions in ACL, COLING, and SIGIR, and government sponsored evaluation efforts in the United States (DUC 2002) and Japan (Fukusima and Okumura 2001) have advanced the technology and produced a couple of experimental online systems (Radev et al.2001, McKeown et al.2002). Despite these efforts, however, there are no common, convenient, and repeatable evaluation methods that can be easily applied to support system development and just-in-time comparison among different summarization methods.
H01-1056
Metrics Recall at different compression ratios has been used in summarization research to measure how well an automatic system retains important content of original documents (Mani et al.1998). However, the simple sentence recall measure cannot differentiate system performance appropriately, as is pointed out by Donaway et al.(2000). Therefore, instead of pure sentence recall score, we use coverage score C.
W00-0408
We are starting to explore various metrics suggested in Donaway et al.(2000). For example, weight n-gram matches differently according to their information content measured by tf, tfidf, or SVD.
W00-0408
However, these evaluations involve human judges and hence are subject to variability (Rath et al.1961). For example, Lin and Hovy (2002) pointed out that 18% of the data contained multiple judgments in the DUC 2001 single document evaluation 1. To further progress in automatic summarization, in this paper we conduct an in-depth study of automatic evaluation methods based on n-gram co-occurrence in the context of DUC.
W02-0406
References Donaway, R.L., Drummey, K.W., and Mather, L.A. 2000.
W00-0408
