The idea of using the confidence measure has appeared in (Peng and McCallum, 2004), where it was used to recognize the OOVs.
C04-1081
Detailed descriptions about subword tagging by CRF can be found in our paper (Zhang et al., 2006).
N06-2049
In the results of the closed test in Bakeoff 2005 (Emerson, 2005), the work of (Tseng et al., 2005), using CRFs for the IOB tagging, yielded a very high R-oov in all of the four corpora used, but the R-iv rates were lower.
I05-3017 I05-3027
For a detailed explanation of these metrics, refer to (Sproat and Emerson, 2003).
W03-1719
In the third step, we used the maximum entropy (MaxEnt) approach (the results of CRF are given in Section 3.4) to train the IOB tagger (Xue and Shen, 2003).
W03-1728
Using the same approach as in (Tseng et al., 2005), we extracted the most frequent words tagged with “B”, indicating a prefix, and the last words tagged with “I”, denoting a suffix.
I05-3027
This problem has been observed by some participants in the Bakeoff 2005 (Asahara et al., 2005), where they applied the IOB tagging to recognize OOVs, and added the OOVs to the lexicon used in the HMMbased or CRF-based approaches.
I05-3018
Segmentation performance has been improved significantly, from the earliest maximal match (dictionary-based) approaches to HMM-based (Zhang et al., 2003) approaches and recent state-of-the-art machine learning approaches such as maximum entropy (MaxEnt) (Xue and Shen, 2003), support vector machine ∗Now the second author is affiliated with NTT.
W03-1728 W03-1730
Later, (Peng and McCallum, 2004) implemented the idea using the CRF-based approach, which yielded better results than the maximum entropy approach because it could solve the label bias problem (Lafferty et al., 2001).
C04-1081
(SVM) (Kudo and Matsumoto, 2001), conditional random fields (CRF) (Peng and McCallum, 2004), and minimum error rate training (Gao et al., 2004).
C04-1081 N01-1025 P04-1059
It was first implemented in Chinese word segmentation by (Xue and Shen, 2003) using the maximum entropy methods.
W03-1728
This approach was also called “LMR” (Xue and Shen, 2003) or “BIES” (Asahara et al., 2005) tagging.
I05-3018 W03-1728
(Nakagawa, 2004) used hybrid HMM models to integrate word level and character level information seamlessly.
C04-1067
By analyzing the top results in the first and second Bakeoffs, (Sproat and Emerson, 2003) and (Emerson, 2005), we found the top results were produced by direct or indirect use of so-called “IOB” tagging, which converts the problem of word segmentation into one of character tagging so that part-of-speech tagging approaches can be used for word segmentation.
I05-3017 W03-1719
