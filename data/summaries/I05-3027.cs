To construct a table containing affixes of unknown words, rather than using threshold-filtered affix tables in a separate unknown word model as was done in Gao et al.(2004), we first extracted rare words from a corpus and then collected the first and last characters to construct the prefix and suffix tables.
P04-1059
For each state, the character identity features (Ng & Low 2004, Xue & Shen 2003, Goh et al.2003) are represented using feature functions that key off of the identity of the character in the current, proceeding and subsequent positions.
P03-2039 W03-1728 W04-3236
Our morphological features are based upon the intuition regarding unknown word features given in Gao et al.(2004). Specifically, their idea was to use productive affixes and characters that only occurred independently to predict boundaries of unknown words.
P04-1059
Table 1 The number of features in each corpus # of data features # of lambda weights AS 2,558,840 8,076,916 HK 2,308,067 7,481,164 PK 1,659,654 5,377,146 MSR 3,634,585 12,468,890 3.2 Experiments 3.2.1 Results on Sighan bakeoff 2003 Experiments done while developing this system showed that its performance was significantly better than that of Peng et al.(2004). As seen in Table 2, our system’s F-score was 0.863 on CTB (Chinese Treebank from Univer169 sity of Pennsylvania) versus 0.849 F on Peng et al.(2004). We do not at present have a good understanding of which aspects of our system give it superior performance.
C04-1081
In the 2003 Sighan Bakeoff (Sproat & Emerson 2003), no single model performed well on all corpora included in the task.
W03-1719
Table 2 Comparisons of Peng et al.(2004) and our Fscore on the closed track in Sighan bakeoff 2003 Sighan Bakeoff 2003 Our F-score F-score Peng et al.(2004) CTB 0.863 0.849 AS 0.970 0.956 HK 0.947 0.928 PK 0.953 0.941 3.2.2 Results on Sighan bakeoff 2005 Our final system achieved a F-score of 0.947 (AS), 0.943 (HK), 0.950 (PK) and 0.964 (MSR).
C04-1081
Our system builds on research into conditional random field (CRF), a statistical sequence modeling framework first introduced by Lafferty et al.(2001). Work by Peng et al.(2004) first used this framework for Chinese word segmentation by treating it as a binary decision task, such that each character is labeled either as the beginning of a word or the continuation of one.
C04-1081
