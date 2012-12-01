Role of Lexical Features In Goldberg et al.(2006), we have established that using lexical features increases the chunking Fmeasure from 78 to over 92 on the Hebrew Treebank.
P06-1087
Kudo and Matsumoto (2000) used SVM as a classification engine and achieved an FScore of 93.79 on the shared task NPs.
W00-0730
In (Goldberg et al., 2006), we established that the task is not trivially transferable to Hebrew, but reported that SVM based chunking (Kudo and Matsumoto, 2000) performs well.
P06-1087 W00-0730
Indeed, the most common class of errors reported in Goldberg et aal., 2006 are of the split/merge type.
P06-1087
Early attempts at NP Chunking were rule learning systems, such as the Error Driven Pruning method of Pierce and Cardie (1998).
P98-1034
In (Goldberg et al., 2006) we argued that it is not applicable to Hebrew, mainly because of the prevalence of the Hebrew’s construct state (smixut).
P06-1087
This method is similar to the corpus error detection method presented by Nakagawa and Matsumoto (2002).
C02-1101
5As each anchor appear in only one support vector, we can treat the vector’s α value as the anchor weight The intuition that “hard to learn” examples are suspect corpus errors is not new, and appears also in Abney et al.(1999), who consider the “heaviest” samples in the final distribution of the AdaBoost algorithm to be the hardest to classify and thus likely corpus errors.
W99-0606
A 10-fold cross validation experiment on punctuation normalized HEBErr resulted in an F-Score of 92.2, improving the results reported by (Goldberg et al., 227 2006) on the same setting (91.4).
P06-1087
Ramshaw. 1995.
W95-0107
For the Hebrew experiments, we use the corpora of (Goldberg et al., 2006).
P06-1087
Further details can be found in Kudo and Matsumoto (2000; 2003).
P03-1004 W00-0730
These are the same settings as in (Kudo and Matsumoto, 2000; Goldberg et al., 2006).
P06-1087 W00-0730
We tested this hypothesis by training the Error-Driven Pruning (EDP) method of (Cardie and Pierce, 1998) with an extended set of features.
P98-1034
In Goldberg et al.(2006), we noted the Hebrew Treebank is not consistent in its treatment of punctuation, and thus we evaluated the chunker only after performing normalization of chunk boundaries for punctuations.
P06-1087
For the English experiments, we use the now-standard training and test sets that were introduced in (Marcus and Ramshaw, 1995)2.
W95-0107
Following Ramshaw and Marcus (1995), the current dominant approach is formulating chunking as a classification task, in which each word is classified as the (B)eginning, (I)nside or (O)outside of a chunk.
W95-0107
Refining the SimpleNP Definition: The hard cases analysis identified examples that challenge the SimpleNP definition proposed in Goldberg et al.(2006). The most notable cases are: The ‘et’ marker : ‘et’ is a syntactic marker of definite direct objects in Hebrew.
P06-1087
NP chunks in the shared task data are BaseNPs, which are non-recursive NPs, a definition first proposed by Ramshaw and Marcus (1995).
W95-0107
The HEBErr version of the corpus is obtained by projecting the chunk boundaries on the sequence of PoS and morphology tags obtained by the automatic PoS tagger of Adler & Elhadad (2006).
P06-1084
