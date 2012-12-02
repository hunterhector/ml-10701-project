1(b). As stated in introduction, Hisamitsu et al.(2000) reported on that the superiority of NormDist(D(T)), normalized Dist(D(T)), in picking out topic-specific words over various measures including existing ones and other ones developed by using the baseline method.
C00-1047
It is reported that measures defined by the baseline method do not have these problems (Hisamitsu et al.2000). 1.2 Baseline method The basic idea of the baseline method stated in introduction can be summarized by the famous quote (Firth 1957) : "You shall know a word by the company it keeps".
C00-1047
In this paper we employ the basic idea of the ‘baseline method’ proposed by Hisamitsu (Hisamitsu et al.2000). The idea is that the distribution of words co-occurring with a representative term should be biased according to the word distribution of the whole corpus.
C00-1047
Experiments As in Hisamitsu et al.(2000), taking topic-word selection for IR navigation into account, we examined the relation between the value of representative measures and a manual classification of words (monograms) extracted from nearly 160,000 articles in the 1996 archive of the Nihon Keizai Shimbun (denoted by D 0 later on).
C00-1047
The details of the guideline of classification are stated in Hisamitsu et al.(2001). 3.2 Measures compared in the experiments Four measures were compared by Hisamitsu et al.(2000): NormDist(D(T)), NormDIFFNUM(D(T)), tf-idf, and tf(term frequency), where NormDIFFNUM(D(T)) is a normalized version of a measure called DIFFNUM(D(T)), which gives the number of distinct words in D(T).
C00-1047
For instance, the mutual information (Church et al.1990) and log-likelihood ratio (Dunning 1993; Cohen 1995) have been widely used for extracting word bigrams.
J90-1003 J93-1003
The value of Dist(D(T)) can be defined in various ways, and they found that using log-likelihood ratio (see Dunning 1993) worked best which is represented as follows: 0 # log )(# log D K k TD k k i M ii i i M ii i ∑∑ == −, where k i and K i are the frequency of a word w i in D(W) and D 0 respectively, and {w 1,...,w M } is the set of all words in D 0 . As stated in introduction, Dist(D(T)) is normalized by the baseline function, which is referred as B Dist (•) here.
J93-1003
