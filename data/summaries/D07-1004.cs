Chinese NER tool [Wu et al.2005]. The number of the candidates extracted from the top m(= 50) snippets, n, is adaptive for different questions but it does not exceed 30.
H05-1054
The pattern-based model [Ravichandran et al.2002 and Soubbotin et al.2002] first classifies the question into predefined categories, and then extracts the exact answer by using answer patterns learned off-line.
P02-1006
A first-stage Google search (FGS) is applied to extract n candidate answers fc1,c2,,...,cng from the top m Google snippets fs1,s2,,...,smg by a NER tool [Wu et al.2005]. Those snippets containing the candidates fcig and at least one question keyword fqig are retained.
H05-1054
The retrieval-based model [Yang et al.2003] selects a correct answer from the candidates according to the distance between a candidate and all question keywords.
E03-1070
Therefore, our classifying the question 33 Figure 1: Web Question Answering Architecture is different from conventional question classification (QC) [Li et al.2002] that determines the answer type of the question.
C02-1150
[Clarke et al.2001; Magnini et al.2002; and Dumais et al.2002]. In the S-SVM, all of the test questions share the same hand-tagged training data, so the WWFS features cannot be easily used [Ittycheriah et al.2002; Suzuki, et al.2002]. Tables 6 and 7 compare the performances of the U-SVM with the (SBFS + BMFS) features, the WWFS features, and combination of three types of features for the CTREC04 and CTREC05 test data sets, respectively.
C02-1119 P02-1054
In recent years, many supervised machine learning techniques for answer selection in open-domain question answering have been investigated in some pioneering studies [Ittycheriah et al.2001; Ng et al.2001; Suzuki et al.2002; Sasaki, et al.2005; and Echihabi et al.2003]. Compared with retrieval-based [Yang et al.2003], pattern-based [Ravichandran et al.2002 and Soubbotin et al.2002], and deep NLP-based [Moldovan et al.2002, Hovy et al.2001; and Pasca et al.2001] answer selection, machine learning techniques are more effective in constructing QA components from scratch.
C02-1119 E03-1070 P02-1006 P03-1003 P05-1027 W01-0509
current models of this type are based on supervised approaches [Ittycheriah et al.2001; Ng et al.2001; Suzuki et al.2002; and Sasaki et al.2005] that are heavily dependent on hand-tagged questionanswer training pairs, which not readily available.
C02-1119 P05-1027 W01-0509
of the 19th International Conference on Computational Linguistics, Taibai, 2002.
C02-1150
Second, the U-SVM automatically learns the unique questiondependent clusters and the pseudo-training for each 34 Table 1: Comparison of Various Machine Learning Techniques System Model Key Idea Training Data [Ittycheriah et al.2001] ME Classifier Classifying candidates into positive and negative 5,000 English Q-A pairs [Suzuki et al.2002] SVM Classifier Classifying candidates into positive and negative 1358 Japanese Q-A pairs [Echihabi et al.2003] N-C Model Selecting correct answer by aligning question with sentences 90,000 English Q-A pairs [Sasaki et al.2005] ME Classifier Classifying words in sentences into answer and non-answer words 2,000 Japanese Q-A pairs Our U-SVM Model SVM Classifier Classifying question into a set of question-dependent clusters No Q-A pairs question.
C02-1119 P03-1003 P05-1027
Note that the SBFS and BMFS features here is fewer than the features in [Ittycheriah et al.2001; Suzuki et al.2002], but the comparison is still effective because the models are compared in terms of the same features.
C02-1119
