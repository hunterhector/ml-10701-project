The features for NWI were studied in Wu & Jiang (2000) and Li et al.(2004). The use of sampling was proposed in Della Pietra et al.(1997) and Rosenfeld et al.(2001). There is also a related work on this line in Japanese (Uchimoto et al., 2001).
W00-1207 W01-0512
An alternative to linear models is the log-linear models suggested by Och (2003).
P03-1021
We thank Xiaodan Zhu for his early contribution, and the three reviewers, one of whom alerted us the related work of (Uchimoto et al., 2001).
W01-0512
We also tested the statistical significance of results, using the criterion proposed by Sproat and Emperson (2003), and all results reported in this section are significantly different from each other.
W03-1719
We then describe a transformation-based learning (TBL, Brill, 1995) method that is used to adapt our system to different segmentation standards.
J95-4004
The method we use is transformation-based learning (Brill, 1995), which requires an initial segmentation, a goal segmentation into which we wish to transform the initial segmentation and a space of allowable transformations (i.e.
J95-4004
The superiority of the unified approach has been demonstrated empirically in Gao et al.(2003), and will also be discussed in Section 5.
P03-1035
All feature functions in Figure 1, except the NW function, are derived from models presented in (Gao et al., 2003).
P03-1035
The IWP of a single character is the likelihood for this character to appear as an independent word in texts (Wu and Jiang, 2000): )( ),( )( xC WxC xIWP = . (4) where C(x, W) is the number of occurrences of the character x as an independent word in training data, and C(x) is the total number of x in training data.
W00-1207
It is also related to loglinear models for machine translation (Och, 2003).
P03-1021
The use of TBL for Chinese word segmentation was first suggested in Palmer (1997).
P97-1041
The training and test corpora of these standards are detailed in Table 1, where MSR is defined by ourselves, and the other four are standards used in SIGHAN’s First International Chinese Word Segmentation Bakeoff (Bakeoff test sets for brevity, see Sproat and Emperson (2003) for details).
W03-1719
Our method is a discriminative approach inspired by the Minimum Error Rate Training method proposed in Och (2003).
P03-1021
Following the empirical study in (Gao and Lee, 2000), we use K-Mixture (Katz, 1996) which estimate P i (k) as k ki kP ) 1 ( 1 )1()( 0, ++ +−= β β β α δα, (6) where δ k,0 =1 if k=0, 0 otherwise.
P00-1073
For example, there is no single segmenter in SIGHAN’s Bakeoff, which achieved top-2 ranks in all four test sets (Sproat and Emperson, 2003).
W03-1719
