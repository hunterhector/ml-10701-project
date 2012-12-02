Decoding is carried-out using the Moses decoder (Koehn and Hoang, 2007).
D07-1091
Standard ngram language models assign probabilities to translation hypotheses in the target language, typically as smoothed trigram models (Chiang, 2005).
P05-1033
Wehope the present work will, together with Talbot and Osborne (2007), establish the Bloom filter as a practical alternative to conventional associative data structures used in computational linguistics.
P07-1065
In this paper, we build on recent work (Talbot and Osborne, 2007) that demonstrated how the Bloom filter (Bloom (1970); BF), a space-efficient randomised data structure for representing sets, could be used to store corpus statistics efficiently.
P07-1065
of BF-LM framework We refer to (Talbot and Osborne, 2007) for empirical results establishing the performance of the logfrequency BF-LM: overestimation errors occur with 474 0.01 0.025 0.05 0.1 0.25 0.5 0.03 0.02 0.01 0.005 0.0025 0.001 Mean squared error of log probabilites Memory in GB MSE between WB 3-gram SRILM and BF-LMs Base 3 Base 1.5 Base 1.1 Figure 5: MSE between SRILM and BF-LMs 22 23 24 25 26 27 28 29 30 0.01 0.1 1 BLEU Score Mean squared error WB-smoothed BF-LM 3-gram model BF-LM base 1.1 BF-LM base 1.5 BF-LM base 3 Figure 6: MSE vs.
P07-1065
All evaluation is in terms of the BLEU score on our test set (Papineni et al., 2002).
P02-1040
items There is a potential risk of redundancy if we represent related statistics using the log-frequency BF scheme presented in Talbot and Osborne (2007).
P07-1065
Our framework makes use of the log-frequency Bloom filter presented in (Talbot and Osborne, 2007), and described briefly below, to compute smoothed conditional n-gram probabilities on the fly.
P07-1065
As noted in Talbot and Osborne (2007), errors for this log-frequency BF scheme are one-sided: frequencies will never be underestimated.
P07-1065
modelling with Bloom filters Recentwork(TalbotandOsborne, 2007)presenteda scheme for associating static frequency information with a set of n-grams in a BF efficiently.1 3.1 Log-frequency Bloom filter The efficiency of the scheme for storing n-gram statistics within a BF presented in Talbot and Osborne (2007) relies on the Zipf-like distribution of n-gramfrequencies: mosteventsoccuranextremely small number of times, while a small number are very frequent.
P07-1065
