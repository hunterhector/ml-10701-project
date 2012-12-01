Engelson and Dagan (1996) confirm this observation that, in general, different (and even more refined) selection methods still yield similar results.
P96-1042
Baldridge and Osborne (2004) have already argued that this is a highly critical requirement because the examples selected by AL are tuned to one particular classifier.
W04-3202
This is measured by the vote entropy (Engelson and Dagan, 1996), i.e., the entropy of the distribution of classifications assigned to an example by the classifiers.
P96-1042
These findings stand in contrast to those supplied by Baldridge and Osborne (2004) who focused on parse selection.
W04-3202
(e.g., IL2 → AA0, have → aaaa) lexical and morphological prefix and suffix of length 3, stemmed version of each token syntactic the token’s part-of-speech tag contextual features of neighboring tokens Table 1: Features used for AL versity of a batch and representativeness of the respective example (to avoid outliers) (Shen et al., 2004).
P04-1075
In a more recent study, Shen et al.(2004) consider AL for entity recognition based on Support Vector Machines.
P04-1075
Whereas Hwa (2001) reports positive results, Baldridge and Osborne (2004) argue that AL based on uncertainty sampling may face serious performance degradation when labeled data is reused for training a classifier different from the one employed during AL.
W01-0710 W04-3202
QBC is based on the idea to select those examples for manual annotation on which a committee of classifiers disagree most in their predictions (Engelson and Dagan, 1996).
P96-1042
We report on other aspects of AL for real annotation projects in Tomanek et al.(2007). 6 Discussion and Conclusions We have shown, for the annotation of (named) entities, that AL is well-suited to speed up annotation work under realistic conditions.
W07-1502
From the general-language newspaper domain, we used the English data set of the CoNLL2003 shared task (Tjong Kim Sang and De Meulder, 2003).
W03-0419
Pierce and Cardie (2001) have shown, however, that for tasks which require large numbers of labeled examples – such as most NLP tasks – cotraining might be inadequate because it tends to generate noisy data.
W01-0501
and Features For our AL framework we decided to employ a Maximum Entropy (ME) classifier (Berger et al., 1996).
J96-1002
AL has already been applied to several NLP tasks, such as document classification (Schohn and Cohn, 2000), POS tagging (Engelson and Dagan, 1996), chunking (Ngai and Yarowsky, 2000), statistical parsing (Thompson et al., 1999; Hwa, 2000), and information extraction (Lewis and Catlett, 1994; Thompson et al., 1999).
P00-1016 P96-1042 W00-1306
reusability — The examples AL selects for manual annotation are dependent on the model being used, up to a certain extent (Baldridge and Osborne, 2004).
W04-3202
Hachey et al.(2005) propose a committee-based AL approach where the committee’s classifiers constitute multiple views on the data by employing different feature subsets.
W05-0619
