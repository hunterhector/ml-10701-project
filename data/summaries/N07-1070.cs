Recently, Palmer et al., (2005), have PropBanked a significant portion of the Treebanked Brown corpus which enables us to perform experiments to analyze the reasons behind the performance degradation, and suggest potential solutions.
J05-1004
Recently there have been some improvements to the Charniak parser, use n-best re-ranking as reported in (Charniak and Johnson, 2005) and selftraining and re-ranking using data from the North American News corpus (NANC) and adapts much better to the Brown corpus (McClosky et al., 2006a; McClosky et al., 2006b).
N06-1020 P05-1022 P06-1043
System Description We formulate the labeling task as a classification problem as initiated by Gildea and Jurafsky (2002) and use Support Vector Machine (SVM) classifiers (2005).
J02-3001
We use TinySVM2 along with YamCha3 (Kudo and Matsumoto, 2000) (Kudo and Matsumoto, 2001) as the SVM training and classification software.
N01-1025 W00-0730
The syntactic parser is the version that is selftrained using 2,500,000 sentences from NANC, and where the starting version is trained only on WSJ data (McClosky et al., 2006b).
N06-1020 P06-1043
Palmer et al., (2005) have recently PropBanked a significant portion of this Treebanked Brown corpus.
J05-1004
Automatic, accurate and wide-coverage techniques that can annotate naturally occurring text with semantic argument structure play a key role in NLP applications such as Information Extraction (Surdeanu et al., 2003; Harabagiu et al., 2005), Question Answering (Narayanan and Harabagiu, 2004) and Machine Translation (Boas, 2002; Chen and Fung, 2004).
C04-1100 N04-4008 P03-1002
test sets, we used stratified sampling, which is often used by the syntactic parsing community (Gildea, 2001).
W01-0521
More details of this system can be found in Pradhan et al., (2005).
P05-1072
In this study we use PropBanked versions of the Wall Street Journal (WSJ) part of the Penn Treebank (Marcus et al., 1994) and part of the Brown portion of the Penn Treebank.
H94-1020
Annotation and Corpora In the PropBank1 corpus (Palmer et al., 2005), predicate argument relations are marked for the verbs in the text.
J05-1004
While all these systems perform quite well on the WSJ test data, they show significant performance degradation (approximately 10 point drop in F-score) when applied to label test data that is different than the genre that WSJ represents (Pradhan et al., 2004; Carreras and M`arquez, 2005).
N04-1030 P05-1072 W05-0620
