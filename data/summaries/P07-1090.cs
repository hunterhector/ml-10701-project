A language model is trained using the SRILMToolkit, and a text chunker (Chen et al., 2006) is applied to the Chinese sentences in the test and dev sets to extract the constituent boundaries necessary forthephraseboundarymodel.
P06-2013
Watanabe et al.(2006) further reduces the grammar’s size by enforcing all rules to comply with Greibach Normal Form.
P06-1098
The FWS approach is also akin to (Xiong et al., 2006) in using a synchronous grammar as a reordering constraint.
P06-1066
The basic phrase reordering model is a simple unlexicalized, context-insensitive distortion penalty model (Koehn et al., 2003).
N03-1017
We propose SG-ITG that follows Wellington et al.(2006)’s suggestion to model at most one gap.
P06-1123
In pursuit of better translation, phrase-based models (OchandNey,2004)havesignificantlyimprovedthe quality over classical word-based models (Brown et al., 1993).
J04-4002 J93-2003
Instead of using Inversion Transduction Grammar (ITG) (Wu, 1997) directly, we will discuss an ITG extension to accommodate gapping.
J97-3002
The benefit of introducing lexical evidence without being fully lexicalized has been demonstrated by a recent state-of-the-art formally syntax-based model1, Hiero (Chiang, 2005).
P05-1033
Other further generalizations of orientation include theglobalpredictionmodel(Nagataetal., 2006)and distortion model (Al-Onaizan and Papineni, 2006).
P06-1067 P06-1090
777–784. Wenliang Chen, Yujie Zhang and Hitoshi Isahara 2006.
P06-2013
We follow the notation in (Nagata et al., 2006) and define the following bilingual orientation values given two neighboring source (Chinese) phrases: Monotone-Adjacent (MA); ReverseAdjacent (RA); Monotone-Gap (MG); and ReverseGap (RG).
P06-1090
The local prediction model (Tillmann and Zhang, 2005) models structural divergence as the relative position between the translation of two neighboring phrases.
P05-1069
However, the pb features yields no noticeable improvement unlike in prefect lexical choice scenario; this is similar to the findings in (Koehn et al., 2003).
N03-1017
To address this issue, the algorithm uses gapping conservatively by utilizing the consistency constraint (Och and Ney, 2004) to suggest phrase level alignment of X.
J04-4002
Proposals to alleviate this problem include utilizing bilingual phrase cluster or words at the phrase boundary (Nagata et al., 2006) as the phrase identity.
P06-1090
The utility of ITG as a reordering constraint for most language pairs, is well-known both empirically (Zens and Ney, 2003) and analytically (Wu, 1997), howeverITG’sstraight (monotone)andinverted (reverse) rules exhibit strong cohesiveness, which is inadequate to express orientations that require gaps.
J97-3002 P03-1019
This results in a much smaller set of rules compared to Hiero, 1Chiang (2005) used the term “formal” to indicate the use of synchronous grammar but without linguistic commitment _d_6120_d_1514 _d_3300_d_5287_d_7299_d_954 _d_4615 _d_3226_d_3059 _d_6626_d_1303_d_2024 _d_4615 _d_7220_d_1609 a form is a coll.
P05-1033
