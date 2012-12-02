More formally, let NPa2a4a3 be the a5 th NP in document a6. An instance formed from NPa7 a3 and NPa8 a3 is denoted by a9a11a10a13a12a15a14a17a16a19a18a21a20a12a22a14a24a23a25a18a27a26 . A valid instance is an instance a9 a10a13a12a22a14 a16a19a18 a20a12a22a14 a23a28a18 a26 such that NPa7 a3 precedes NPa8 a3 .5 Following previous work (Aone and Bennett (1995), 5By definition, exactly a29a30 valid instances can be created from a31 NPs in a given document.
P95-1017
The approach is a fully automated variant of the example selection algorithm introduced in Harabagiu et al.(2001). With positive example selection, system performance (F-measure) again increases, by 12-14%.
N01-1008
Aone and Bennett (1995), McCarthy and Lehnert (1995), Soon et al.(2001)). Specifically, an inductive learning algorithm is used to train a classifier that decides whether or not two NPs in a document are coreferent.
J01-4004 P95-1017
Soon et al.(2001)), we assume throughout the paper that only valid instances will be generated and used for training and testing.
J01-4004
Although approaches to coreference resolution that rely only on clustering could easily enforce transitivity (as in Cardie and Wagstaff (1999)), they have not performed as well as state-of-the-art approaches to coreference.
W99-0611
Similar observations are made by Harabagiu et al.(2001), who point out that intelligent selection of positive instances can potentially minimize the amount of knowledge required to perform coreference resolution accurately.
N01-1008
First, to address the problem of skewed class distributions, we apply a technique for negative instance selection similar to that proposed in Soon et al.(2001). In contrast to results reported there, however, we show empirically that system performance increases noticeably in response to negative example selection, with increases in F-measure of 3-5%.
J01-4004
In particular, the system outperforms the best-performing learningbased coreference system (Soon et al., 2001) by 6.9% and 3.0%.
J01-4004
A number of methods for handling skewed distributions have been proposed in the machine learning literature, most of which modify the learn6See Ng and Cardie (2002) for a detailed description of the features.
P02-1014
Results are shown in rows 1 and 2 of Table 2 where performance is reported in terms of recall, precision, and F-measure using the model-theoretic MUC scoring program (Vilain et al., 1995).
M95-1005
2One exception is Kehler’s work on probabilistic coreference (Kehler, 1997), in which he applies Dempster’s Rule of Combination (Dempster, 1968) to combine all pairwise probabilities of coreference to form a partition.
W97-0319
