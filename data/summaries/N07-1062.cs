The motivation in (Callison-Burch et al., 2005) is that there are some long source phrases in the test data that also occur in the training data.
P05-1032
Och. 2003.
P03-1021
Results 6.1 Translation System For the experiments, we use a state-of-the-art phrase-based statistical machine translation system as described in (Zens and Ney, 2004).
N04-1033
We have investigated this and our results are in line with (Koehn et al., 2003) showing that the translation quality does not improve if we utilize phrases beyond a certain length.
N03-1017
7. 2 Related Work (Callison-Burch et al., 2005) and (Zhang and Vogel, 2005) presented data structures for a compact representation of the word-aligned bilingual data, such that on-the-fly extraction of long phrases is possible.
P05-1032
The model scaling factors are optimized using minimum error rate training (Och, 2003).
P03-1021
Furthermore, the suffix array data structure of (Callison-Burch et al., 2005) requires a fair amount of memory, about 2GB in their example, whereas our implementation will use only a tiny amount of memory, e.g. less than 20MB for the large Chinese-English NIST task.
P05-1032
It should be rather straightforwardtoapplythisdatastructureaswellas the phrase-match algorithm to the hierarchical approach of (Chiang, 2005).
P05-1033
Even a length limit of 3, as proposed by (Koehn et al., 2003), would result in almost optimal translation quality.
N03-1017
