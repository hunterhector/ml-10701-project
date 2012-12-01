Recall F1 ENGLISH-NWIRE 66.7 62.3 64.2 ENGLISH-BNEWS 63.2 61.3 62.3 CHINESE-NWIRE 71.6 63.3 67.2 CHINESE-BNEWS 71.2 61.8 66.2 (a) (b) Table 2: Formal Results: Our system evaluated using the MUC model theoretic measure Vilain et al.(1995). The table in (a) is our performance on the thirty document MUC-6 formal test set with increasing amounts of training data.
M95-1005
closest comparable unsupervised system is Cardie and Wagstaff (1999) who use pairwise NP distances to cluster document mentions.
W99-0611
As in section 3, we use true mention boundaries and evaluate using the MUC F1 measure (Vilain et al., 1995).
M95-1005
mary performance metric will be the MUC F1 measure (Vilain et al., 1995), commonly used to evaluate coreference systems on a within-document basis.
M95-1005
One then applies discriminative learning methods to pairs of mentions, using features which encode properties such as distance, syntactic environment, and so on (Soon et al., 2001; Ng and Cardie, 2002).
J01-4004 P02-1014
Note that in our model the only way an entity becomes associated with an entity type is by the pronouns used to refer to it.12 If we evaluate our system as an unsupervised NER tagger for the proper mentions in the MUC-6 test set, it yields a 12Ge et al.(1998) exploit a similar idea to assign gender to proper mentions.
W98-1119
Denis and Baldridge (2007) re854 port 67.1 F1 and 69.2 F1 on the English NWIRE and BNEWS respectively using true mention boundaries.
N07-1030
11The best results we know on the MUC-6 test set using the standard setting are due to Luo et al.(2004) who report a 81.3 F1 (much higher than others).
P04-1018
The choice of entitiesmayreasonablybeconsideredtobeindependent given the mixing weights β, but how we realize an entity is strongly dependent on context (Ge et al., 1998).
W98-1119
