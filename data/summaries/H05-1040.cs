With the increasing popularity of statistical NLP, Li and Roth (2002), Hacioglu and Ward (2003) and Zhang and Lee (2003) used supervised learning for question classification on a data set from UIUC that is now standard1.
C02-1150 N03-2010
Using a parse of the question sentence, we derive a novel set of multi-resolution features suitable for training a conditional random field (CRF) (Lafferty et al., 2001; Sha and Pereira, 2003).
N03-1028
Li and Roth (2002) used a Sparse Network of Winnows (SNoW) (Khardon et al., 1999).
C02-1150
We did not use ECOC (Hacioglu and Ward, 2003) because the reported gain is less than 1%.
N03-2010
We used the Stanford Lexicalized Parser (Klein and Manning, 2003) to parse the question.
P03-1054
Our findings corroborate Li and Roth (2002), who report little benefit from adding head chunk features for the fine classification task.
C02-1150
1http://l2r.cs.uiuc.edu/˜cogcomp/Data/ QA/QC/ 315 Hacioglu and Ward (2003) used linear support vector machines (SVMs) with question word 2grams and error-correcting output codes (ECOC)— but no NE tagger or related word dictionary—to get 80.2–82% accuracy.
N03-2010
Hidden Markov models are extremely popular for such applications, but recent work has shown that conditional random fields (CRFs) (Lafferty et al., 2001; Sha and Pereira, 2003) have a consistent advantage over traditional HMMs in the face of many redundant features.
N03-1028
