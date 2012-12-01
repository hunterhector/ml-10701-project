adaptation method we will describe in Section 6 can be viewed as an improved version in that the adaptation rules (or transformations) are acquired automatically from application data via the TBL method (Gao et al.2004). Though the use of TBL for Chinese word segmentation is not new (see Palmer [1997]; Hockenmaier and Brew [1998]), none of the previous work is aimed at standards adaptation.
P04-1059 P97-1041
MSR is described in previous sections, and the other four are standards used in SIGHAN’s First International Chinese Word Segmentation Bakeoff (or Bakeoff for brevity) (Sproat and Emerson 2003).
W03-1719
The algorithm is similar to the perceptron algorithm described in Collins (2002).
W02-1001
# OAS LN PN ON Segmenters errors P R F P R F P R F MSWS 63 .935 .442 .600 .907 .744 .818 .642 .469 .600 LCWS 49 .854 .720 .782 .945 .781 .856 .713 .131 .222 PBWS 20 .767 .736 .752 .780 .787 .784 .817 .216 .342 MSRSeg 7 .876 .864 .870 .830 .897 .862 .799 .617 .696 Table 23 Comparisons against other segmenters: In Column 1, SXX indicates participating sites in the 1 st SIGHAN International Chinese Word Segmentation Bakeoff, and CRFs indicates the word segmenter reported in (Peng et al.2004). In Columns 2 to 5, entries contain the F-measure of each segmenter on different open runs, with the best performance in bold.
C04-1081
We also test the statistical significance of results, using the criterion proposed by Sproat and Emerson (2003).
W03-1719
The first is to acquire new words from large corpora off-line and put them into a dictionary before word segmentation starts (e.g., Fung and Wu 1994; Nie, Jin and Hannan 1994; Chien 1997; Gao et al.2002). The other is to detect new words on-line, i.e., to spot new words in a sentence on the fly during the process of word segmentation (e.g., Chen 2003; Wu and Jiang 2000).
W00-1207 W03-1721
Similarly, Sproat et al.(1996) also uses multiple human judges.
J96-3004
The training criterion that directly minimizes the segmentation errors over the training data is λ ∗ = arg min λ summationdisplay i=1...M Er(w R i, w(s i,λ)), (4) where w(s i, λ) is the segmentation determined by Equation (3), where it is denoted as w ∗ . Equation (4) is referred to as the minimum sample risk (MSR; Gao et al.2005) criterion hereafter.
H05-1027
Measures Remarks P/R/F Multiple pairs, each for one type of words (i.e., LW, MDW, FT, NE); P/R/F of NER are used for cross-system comparison Roov Test the performance of detecting unknown words Riv Test the performance of resolving ambiguities in word segmentation # OAS errors Similar to cross-bracketing, used for cross-system comparison # CAS errors Test on a set of 70 high-frequency CASs in our study Significant test See Sproat and Emerson (2003).
W03-1719
3. The PBWS system is a rule-based Chinese parser (Wu and Jiang 2000) that can also output word segmentation results.
W00-1207
As described in Sproat et al.(1996), FNs are usually transliterated using Chinese character strings whose sequential pronunciation mimics the source language pronunciation of the name.
J96-3004
For example, Li et al.(2003) define NWI as a binary classification problem and use support vector machines (SVM) to combine various linguistically motivated features to determine whether a Chinese character sequence is a word.
W03-1701
Third, in many current segmenters, OOV identification is considered a separate process from segmentation (e.g., Chen 2003; Wu and Jiang 2000; Chen and Bai 1998).
W00-1207 W03-1721
Readers can refer to Li et al.(2003) for more details.
W03-1701
The key difference is that, instead of using the delta rule of Equation (8) (as shown in line 5 of Figure 4), Collins (2002) updates parameters using the rule: λ t+1 d ← λ t d + f d (w R i ) − f d (w i ).
W02-1001
The IWP of a single character is the likelihood of this character to appear as an independent word in texts (Wu and Jiang 2000): IWP(x) = C(x, W) C(x), (12) where C(x, W) is the number of occurrences of the character x as an independent word in training data, and C(x) is the total number of occurrences of x in training data.
W00-1207
In particular, we focus on lowfrequency new words, including newly coined words, occasional words, and mostly time-sensitive words (Wu and Jiang 2000).
W00-1207
535 Computational Linguistics Volume 31, Number 4 Bakeoff alleviated the situation to some degree (Sproat and Emerson 2003).
W03-1701 W03-1719
The layout of the table follows (Peng, Feng, and McCallum 2004).
C04-1081
CRFs indicates the word segmenter reported in Peng, Feng, and McCallum (2004), which uses models of linear-chain con14 The three systems are well known in mainland China, but to our knowledge, no standard evaluations on Chinese word segmentation have been published.
C04-1081
A previous work along this line is Sproat et al.(1996), which is based on weighted finite-state transducers (FSTs).
J96-3004
To achieve this, we present a transformation-based learning (TBL; Brill 1995) method, to be described in Section 6.
J95-4004
No other material was allowed (Sproat and Emerson 2003).
W03-1719
It is also related to (log-)linear models described in Berger, Della Pietra, and Della Pietra (1996), Xue (2003); Och (2003), and Peng, Feng, and McCallum (2004).
C04-1081 J96-1002 P03-1021
The method we use is Transformation-Based Learning (TBL; Brill [1995]), which requires an initial segmentation, a goal segmentation into which we wish to transform the initial segmentation, and a space of allowable transformations (i.e., transformation templates).
J95-4004
Other frameworks of Chinese word segmentation, which are similar to the linear models, include maximum entropy models (Xue 2003) and conditional random fields (Peng, Feng, and McCallum 2004).
C04-1081
Readers can refer to Zhu et al.(2003) and Sun, Zhou, and Gao (2003) for more details, where marginal improvements have been reported.
P03-1035 W03-1718
(Li et al.2003). Table 16 Methods of resolving OAs in word segmentation, on the MSR test set.
W03-1701
Given an input string s, we scan it from left to right, and output a FT candidate when a substring matches one of the ten Table 7 Generative patterns of ONA, where s ij denotes the j-th character of the i-th word of ON (Sun, Zhou and Gao 2003).
P03-1035
The Chinese person-name model is a modified version of that described in Sproat et al.(1996). Other NE models are novel, though they share some similarities with the Chinese person-name model.
J96-3004
For example, there is no single segmenter in the Bakeoff that achieved top-2 ranks in all four test sets (Sproat and Emerson 2003).
W03-1719
As shown in Sproat et al.(1996), the rate of agreement between two human judges is less than 80%.
J96-3004
SXX indicates participating sites in the 1st SIGHAN International Chinese Word Segmentation Bakeoff (Sproat and Emerson 2003).
W03-1719
Following Gao and Lee (2000), we use K-Mixture (Katz 1996) which estimates P i (k)as P i (k) = (1 − a)δ k,0 + a β+ 1 ( β β+ 1 ) k, (15) where δ k,0 =1 if k=0; 0, otherwise.
P00-1073
For instance, Chen (2003) assumes that OOV words are usually two or more characters long and are often segmented into single characters.
W03-1721
The segmentation of the gold test set depends upon a reference lexicon, which is the combination of several lexicons that are used in Microsoft applications, including a Chinese text input system (Gao et al.2002), ASR (Chang et al.2001), TTS (Chu et al.2003), and the MSR-NLP Chinese parser (Wu and Jiang 2000).
P03-1035 W00-1207
As pointed out by Vapnik (1998): “When solving a given problem, solve it directly and try to avoid solving a more general problem as an intermediate step.” Our models are similar to the maximum entropy models in Xue (2003) and CRFs in Peng, Feng, and McCallum (2004) in that all these models give the flexibility to incorporate arbitrary features and can be discriminatively trained.
C04-1081
For example, Teahan et al.(2000) and Dai et al.(1999) do not use any linguistic knowledge.
J00-3004
