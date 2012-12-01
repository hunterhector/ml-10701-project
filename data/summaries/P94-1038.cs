Following Pereira, Tishby, and Lee (1993), we measure word similarity by the relative entropy, or Kullback-Leibler (KL) distance, between the corresponding conditional distributions D(w~ II w~) = Z P(w2\]wl) log P(w2Iwl) (7) ~ P(w2lw~) " The KL distance is 0 when wl = w~, and it increases as the two distribution are less similar.
P93-1024
~ Our longer-term goal, however, is to apply similarity techniques to linguistically motivated word cooccurrence configurations, as suggested by lexicalized approaches to parsing (Schabes, 1992; Lafferty, Sleator, and Temperley, 1992).
C92-2066
Other types of conditional cooccurrence probabilities have been used in probabilistic parsing (Black et al., 1993).
P93-1005
Evaluation We evaluated our method by comparing its perplexity 1 and effect on speech-recognition accuracy with the baseline bigram back-off model developed by MIT Lincoln Laboratories for the Wall Streel Journal (WSJ) text and dictation corpora provided by ARPA's HLT prograin (Paul, 1991).
H91-1055
This may require an adjustment of the similarity based estimate, possibly along the lines of (Rosenfeld and Huang, 1992).
H92-1021
Dagan, Markus, and Markovitch (1993) argue that reduction to a relatively small number of predetermined word classes or clusters may cause a substantial loss of information.
P93-1022
It cannot therefore be used in a complete probabilistic framework, such as n-gram language models or probabilistic lexicalized grammars (Schabes, 1992; Lafferty, Sleator, and Temperley, 1992).
C92-2066
In configurations like verb-object and adjective-noun, there is some evidence (Pereira, Tishby, and Lee, 1993) that sharper word cooccurrence distributions are obtainable, leading to improved predictions by similarity techniques.
P93-1024
Pereira, Tishby, and Lee (1993) propose a "soft" clustering scheme for certain grammatical cooccurrences in which membership of a word in a class is probabilistic.
P93-1024
In addition to its original use in language modeling for speech recognition, Grishman and Sterling (1993) applied the cooccurrence smoothing technique to estimate the likelihood of selectional patterns.
H93-1050
