Our group used directly the output of the parser (Aduriz et al., 2000), which includes some additional features: number, determiner mark, ambiguous analyses and elliptic words.
C00-1001
Following the relevance formula presented in (Magnini and Cavagli´a, 2000), we defined 2 feature types: (1) the most relevant domain, and (2) a list of domains above a predefined threshold 3 . Other experiments using domains from SUMO, the EuroWordNet 1 The PoS tagging was performed with the fnTBL toolkit (Ngai and Florian, 2001).
N01-1006
We tried to represent this information in local features, relying on the analysis of a deep morphological analyzer developed in our group (Aduriz et al., 2000).
C00-1001
We also obtain salient bigrams in the context, with the methods and the software described in (Pedersen, 2001).
N01-1011
NB: We applied a simple smoothing method presented in (Ng, 1997), where zero counts are replaced by the probability of the given sense divided by the number of examples.
W97-0323
The Decision List (DL) algorithm is described in (Yarowsky, 1995b).
P95-1026
and Parameters DL: On Senseval-2 data, we observed that DL improved significantly its performance with a smoothing technique based on (Yarowsky, 1995a).
P95-1026
