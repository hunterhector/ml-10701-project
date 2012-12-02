3.3 Part-of-Speech Features (F pos ) In the previous NER research in newswire domain, part-of-speech (POS) features were stated not useful, as POS features may affect the use of some important capitalization information (Zhou and Su 2002).
P02-1060
Furthermore, some constraints on the boundary category and entity category between two consecutive tags are applied to filter the invalid NE tags (Zhou and Su 2002).
P02-1060
2 3 3.1 HMM-based Named Entity Recognizer Our system is adapted from a HMM-based NE recognizer, which has been proved very effective in MUC (Zhou and Su 2002).
P02-1060
The reported result of the simple deterministic features used in MUC can achieve Fmeasure of 74.1 (Zhou and Su 2002), but when they are used in biomedical domain, they only get F-measure of 24.3.
P02-1060
An alternative back-off modeling approach by means of constraint relaxation is applied in our model (Zhou and Su 2002).
P02-1060
Moreover, if we can map the abbreviation to its full form in the current document, the recognized abbreviation is still helpful for classifying the same forthcoming abbreviations in the same document, as in (Zhou and Su 2002).
P02-1060
Moreover, (Collier et al.2000; Nobata et al.2000; Takeuchi and Collier.
C00-1030 W00-0904
In this paper, we will study how to adapt a general Hidden Markov Model (HMM)-based NE recognizer (Zhou and Su 2002) to biomedical domain.
P02-1060
Since in previous work, many NER systems have been applied successfully in newswire domain (Zhou and Su 2002; Bikel et al.1999; Borthwich et al.1999), more and more explorations have been done to port existing NER system into biomedical domain (Kazama et al.2002; Takeuchi et al.2002; Nobata et al.1999 and 2000; Collier et al.2000; Gaizauskas et al.2000; Fukuda et al.1998; Proux et al.1998). However, compared with those in newswire domain, these systems haven’t got high performance.
C00-1030 P02-1060 W00-0904 W02-0301 W02-2029
This is consistent with earlier explanation for why POS features are not so useful in biomedical NER (Nobata et al.2000; Takeuchi and Collier 2002).
W00-0904 W02-2029
Corpus P R F Our system on V3.0 66.5 65.7 66.1 Our system on V1.1 63.8 61.3 62.5 Kazama’s on V1.1 56.2 52.8 54.4 Table 6: Comparison of overall performance Table 6 shows the overall performance of our system on V3.0 and V1.1, and the best reported system on V1.1 described in (Kazama et al.2002). On V1.1, we use the same training and testing data and capture the same NE classes as (Kazama et al.2002). Our system (62.5 F-measure) outperforms Kazama’s (54.4 F-measure) by 8.1 F-measure.
W02-0301
This kind of features have been widely used in both newswire NER system, such as (Zhou and Su 2002), and biomedical NER system, such as (Nobata et al.1999; Gaizauskas et al.2000; Collier et al.2000; Takeuchi and Collier 2002; Kazama et al.2002). Based on the characteristics of biomedical NEs, we designed simple deterministic features manually.
C00-1030 P02-1060 W00-0904 W02-0301 W02-2029
In previous research, (Kazama et al.2002) make use of POS information and conclude that it only slightly improves performance.
W02-0301
Furthermore, we evaluate these features and compare with those used in MUC (Zhou and Su, 2002).
P02-1060
