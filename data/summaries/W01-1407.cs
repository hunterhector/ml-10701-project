If we assign a probability a13a15a14a17a16 a10a12a11a5a19a18a2 a3a5a21a20 to each pair of strings a16 a10 a11a5a12a22 a2a4a3a5 a20, then according to Bayes’ decision rule, we have to choose the English string that maximizes the product of the English language model a13a23a14a24a16 a10 a11a5 a20 and the string translation model a13a15a14a17a16a25a2 a3a5a26a18a10a27a11a5a28a20 . Many existing systems for statistical machine translation (Wang and Waibel, 1997; Nießen et al., 1998; Och and Weber, 1998) make use of a special way of structuring the string translation model like proposed by (Brown et al., 1993): The correspondence between the words in the source and the target string is described by alignments which assign one target word position to each source word position.
H93-1039 J93-2003 P97-1047 P98-2162
Table 2 summarizes the characteristics of the training corpus used for training the parameters of Model 4 proposed in (Brown et al., 1993).
H93-1039 J93-2003
Another possibility is to assess the impact on the alignment quality after training, which can be evaluated automatically (Langlais et al., 1998; Och and Ney, 2000), but as we found that the alignment quality on the Verbmobil data is consistently very high, and extremely robust against manipulation of the training data, we abandoned this approach.
P00-1056 P98-1117
of unknown word forms 25 We used a translation system called “singleword based approach” described in (Tillmann and Ney, 2000) and compared to other approaches in (Ney et al., 2000).
C00-2123
For a description of the Constraint Grammar approach we refer the reader to (Karlsson, 1990).
C90-3030
