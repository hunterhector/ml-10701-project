Or, we may want to identify disease and treatment relations in publications and textbooks, which can be used to help formalise medical knowledge and assist general practitioners in diagnosis, treatment and prognosis (Rosario and Hearst, 2004).
P04-1055
These models included a baseline system based on a term-by-document representation of term context, which is equivalent to the representation used in previous work by Hasegawa et al.(Hasegawa et al., 2004) and Chen et al.(Chen et al., 2005).
P04-1053
Setup 4.1 Materials Following Chen et al.(2005), we derive our relation discovery data from the automatic content extraction (ACE) 2004 and 2005 materials for evaluation of information extraction.4 This is preferable to using the New York Times data used by Hasegawa et al.(2004) as it has gold standard annotation, which can be used for unbiased evaluation.
P04-1053
Interestingly, the performance of the asymmetric KL divergence and the symmetric JS divergence is very close, which makes it difficult to conclude whether the relation discovery domain is a symmetric domain or an asymmetric domain like Lee’s (1999) task of improving probability estimates for unseen word co-occurrences.
P99-1004
The second approach is from Lee (1999).
P99-1004
In this section, we discuss several 2Previous approaches select labels from the collection of context words for a relation cluster (Hasegawa et al., 2004; Zhang et al., 2005).
P04-1053
This is compared to a baseline term-by-document (TxD) representation which is a re-implementation of the approach used by Hasegawa et al.(2004) and Chen et al.(2005). 3.2 Dimensionality Reduction Dimensionality reduction techniques for document and corpus modelling aim to reduce description length and model a type of semantic similarity that is more linguistic in nature (e.g., see Landauer et al.’s (1998) discussion of LSA and synonym tests).
P04-1053
Agglomerative clustering is used for comparability with the original relation discovery work of Hasegawa et al.(2004). This choice was motivated because as it is not known in advance how many clusters there should be in a new domain.
P04-1053
This consisted of MxTerminator (Reynar and Ratnaparkhi., 1997) for sentence boundary detection, the Penn Treebank 5Following results reported by Chen et al.(2005), who tried unsuccessfully to incorporate words from the surrounding context to represent a relation’s semantics, we use only intervening words.
A97-1004
Previous approaches to relation discovery (Hasegawa et al., 2004; Chen et al., 2005) have been limited to TxD representations, using tf*idf weighting and the cosine similarity measure.
P04-1053
In previous work (Hasegawa et al., 2004; Chen et al., 2005), the conceptual representation has been limited to term-by-document (TxD) models of relation semantics.
P04-1053
For all divergence measures, Lee’s (1999) method outperformed Dagan et al.’s (1997) method.
P97-1008 P99-1004
Dagan et al.(1997) find that the symmetric information radius measure performs best on a pseudoword sense disambiguation task, while Lee (1999) find that the asymmetric skew divergence – a generalisation of Kullback-Leibler divergence – performs best for improving probability estimates for unseen word co-occurrences.
P97-1008 P99-1004
These goals correspond to the three main steps in a generalised algorithm (Hasegawa et al., 2004): 1.
P04-1053
The first is from Dagan et al.(1997). For KL divergence, this function is defined as Sim(p,q) = 10−βKL(p||q), where β is a free parameter, which is tuned on the development set (as described in Section 4.2).
P97-1008
In previ25 ous work, relations have been used for automatic text summarisation as a conceptual representation of sentence content in a sentence extraction framework (Filatova and Hatzivassiloglou, 2004).
W04-1017
