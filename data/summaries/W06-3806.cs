kernels We compared three different kernels: (1) the kernel Kl((Tprime,Hprime),(Tprimeprime,Hprimeprime)) based on the intra-pair 35 Datasets Kl Kl +Kt Kl +Ks Train:D1 Test:T1 0.5888 0.6213 0.6300 Train:T1 Test:D1 0.5644 0.5732 0.5838 Train:D2(50%)prime Test:D2(50%)primeprime 0.6083 0.6156 0.6350 Train:D2(50%)primeprime Test:D2(50%)prime 0.6272 0.5861 0.6607 Train:D2 Test:T2 0.6038 0.6238 0.6388 Mean 0.5985 0.6040 0.6297 (± 0.0235 ) (± 0.0229 ) (± 0.0282 ) Table 1: Experimental results lexical similarity siml(T,H) as defined in (Corley and Mihalcea, 2005).
W05-1203
First, as observed in (Corley and Mihalcea, 2005) the lexical-based distance kernel Kl shows an accuracy significantly higher than the random baseline, i.e. 50%.
W05-1203
1). In line with many other researches (e.g., (Corley and Mihalcea, 2005)), we determine these anchors using different similarity or relatedness dectors: the exact matching between tokens or lemmas, a similarity between tokens based on their edit distance, the derivationally related form relation and the verb entailment relation in WordNet, and, finally, a WordNet-based similarity (Jiang and Conrath, 1997).
W05-1203
We also used the following resources: the Charniak parser (Charniak, 2000) to carry out the syntactic analysis; the wn::similaritypackage (Pedersen et al., 2004) to compute the Jiang&Conrath (J&C) distance (Jiang and Conrath, 1997) needed to implement the lexical similarity siml(T,H) as defined in (Corley and Mihalcea, 2005); SVM-lightTK (Moschitti, 2004) to encode the basic tree kernel function, KT, in SVM-light (Joachims, 1999).
A00-2018 N04-3012 P04-1043 W05-1203
Then, we use this cross-pair similarity with more traditional intra-pair similarities (e.g., (Corley and Mihalcea, 2005)) to define a novel kernel function.
W05-1203
