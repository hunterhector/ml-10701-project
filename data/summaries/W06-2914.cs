A Probabilistic Latent Semantic Analysis (PLSA) approach has been adopted by (Brants et al., 2002; Farahat and Chen, 2006) for the TS task.
E06-1014
(Utiyama and Isahara, 2001) models the problem of TS as a problem of finding the minimum cost path in a graph and therefore adopts a dynamic programming algorithm.
P01-1064
The third dataset we use in this study was originally proposed in (Choi, 2000) and contains artificial thematic episodes.
A00-2004
The LCseg system (Galley et al., 2003), labeled here as G03, is to our knowledge the only word distribution based system evaluated on ICSI meeting data.
P03-1071
While the focus of our paper is not on the method of evaluation, it is worth pointing out that the performance on the synthetic data set is a very poor guide to the performance on naturally occurring data (Georgescul et al., 2006).
W06-1320
The first dataset is a subset of the ICSI-MR corpus (Janin et al., 2004), where the gold standard for thematic segmentations has been provided by taking into account the agreement of at least three human annotators (Galley et al., 2003).
P03-1071
(Kauchak and Chen, 2005) employed SVMs using features (derived for instance from information given by the presence of paragraphs, pronouns, numbers) that can be reliably used for topic 102 segmentation of narrative documents.
W05-0405
The so-labeled G03* algorithm 106 indicates the error rates obtained by (Galley et al., 2003) when extra (meeting specific) features have been adopted in a decision tree classifier.
P03-1071
In this manner, (Hearst, 1997; Reynar, 1998; Choi, 2000) start by using a similarity measure between sentences or fixed-size blocks of text, based on their word frequencies in order to find changes in vocabulary use and therefore the points at which the topic changes.
A00-2004 J97-1003
Therefore, we replicate the results reported by (Galley et al., 2003) when evaluation of LCseg was done on ICSI data.
P03-1071
Therefore, linear algebra dimensionality reduction methods like singular value decomposition have been adopted by (Choi et al., 2001; Popescu-Belis et al., 2004) in Latent Semantic Analysis (LSA) for the task of thematic segmentation.
W01-0514
Hence the use of two other evaluation metrics is favored in thematic segmentation: the Pk metric (Beeferman et al., 1999) and the WindowDiff error metric (Pevzner and Hearst, 2002).
J02-1002
Thus, although (Choi, 2000; Hearst, 1997) employ a distance function (i.e.
A00-2004 J97-1003
(Passonneau and Litman, 1993; Galley et al., 2003), obtained a level of inter-annotator agreement that is statistically significant.
P03-1071 P93-1020
We compare our system against an existing thematic segmenter in the literature: C99 (Choi, 2000).
A00-2004
Aside from the fact that we consider the TS task on different datasets (not only on narrative documents), our approach is different from the approach proposed by (Kauchak and Chen, 2005) mainly by the data representation we propose and by the fact that we put the emphasis on deriving the thematic structure merely from word distribution, while (Kauchak and Chen, 2005) observed that the ‘block similarities provide little information about the actual segment boundaries’ on their data and therefore they concentrated on exploiting other features.
W05-0405
The work of (Galley et al., 2003) shows that the G03* algorithm is better than G03 by approximately 10%, which indicates that on meeting data the performance of our word-distribution based approach could possibly be increased by using other meeting-specific features.
P03-1071
