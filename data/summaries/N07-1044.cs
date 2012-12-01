We performed the same experiment using McCarthy et al.’s (2004a) model, which also achieved a significant correlation (ρ = 0.316, p < 0.01).
P04-1036 W04-0837
One reason for this is the highly skewed distribution of word senses (McCarthy et al., 2004a).
P04-1036 W04-0837
We could obtain such counts from any document collection; however, to facilitate comparisons with prior work (e.g., McCarthy et al.2004a), all our experimentsusetheBritishNationalCorpus(BNC).In what follows we describe in detail how we retrieve co-occurrence counts from the BNC and how we acquire dominant senses.
P04-1036 W04-0837
Applications such as machine translation (Vickrey et al., 2005) and information retrieval (Stokoe, 2005) have also been shown to benefit from WSD.
H05-1051 H05-1097
We used WordNet 1.7.1 (Fellbaum, 1998) senses.3 We compared our results to a baseline that selects for each word type a random sense, assumes it is the dominant one, and uses it to disambiguate all instances of the target word (McCarthy et al., 2004a).
P04-1036 W04-0837
Mohammad and Hirst (2006) propose an algorithm for inferring dominant senses without relying on distributionally similar neighbors.
E06-1016
This is not surprising, there is ample evidence in the literature (Mohammad and Hirst, 2006; Turney, 2001) that association measures (e.g., conditional probability, mutual information) are better indicators of lexical similarity than raw frequency.
E06-1016
A promising direction is the combination of different ranking models (Brody et al., 2006) and the integration of dominant sense models with supervised WSD.
P06-1013
Examples include odds ratio (Mohammad and Hirst, 2006) and Turney’s (2001) IR-based pointwise mutual information (PMI-IR).
E06-1016
Recall that McCarthy et al.(2004a) propose a model that crucially relies on a robust parser for estimating dominant senses.
P04-1036 W04-0837
Specifically, the approach compares the domain of the context surrounding the target word with the domains of its senses and uses a version of WordNet 4Comparison against Mohammad and Hirst (2006) was not possible since they use a sense inventory other than WordNet (i.e., Roget’s thesaurus) and evaluate their model on artificially generated sense-tagged data.
E06-1016
Moreover, unlike Mohammad and Hirst (2006), our algorithm only requires co-occurrence frequencies for the target word and its senses, without considering all senses in the inventory and all words in the corpus simultaneously.
E06-1016
Our model significantly outperforms the two baselines and McCarthy et al.(2004b). Its precision and recall according to individual parts of speech is shown in Table 5.
P04-1036 W04-0837
First, we use the acquired dominant senses to disambiguate the meanings of words in the Senseval-2 (Palmer et al., 2001) and Senseval-3 (Snyder and Palmer, 2004) data sets.
W04-0811
OurworkshareswithMcCarthyetal.(2004a)and Mohammad and Hirst (2006) the objective of inferring dominant senses automatically.
E06-1016 P04-1036 W04-0837
Work McCarthy et al.(2004a) were the first to propose a computational model for acquiring dominant senses from text corpora.
P04-1036 W04-0837
Mohammad and Hirst (2006) estimate the co-occurrence frequency of a word and its sense descriptors by considering small window sizes of up to five words.
E06-1016
Furthermore, it is computationally inexpensive; in contrast to McCarthy et al.(2004a) we do not rely on the structure of the sense inventory for measuring the similarity between synonyms and their senses.
P04-1036 W04-0837
Our method was significantly better than McCarthy et al.(2004b) on Senseval-2 and Senseval-3.
P04-1036 W04-0837
It is therefore not surprising that recent work (McCarthy et al., 2004a; Mohammad and Hirst, 2006; Brody et al., 2006) attempts to alleviate the annotation bottleneck by inferring the first sense automaticallyfromrawtext.Automaticallyacquiredfirst senses will undoubtedly be noisy when compared to human annotations.
E06-1016 P04-1036 P06-1013 W04-0837
Finally, note that our model is conceptually simpler than McCarthy et al.(2004b) and IRST-DDD.
P04-1036 W04-0837
Following McCarthy et al.(2004a), we first use our method to find the dominant sense for all word types inthe corpusandthen usethatsense todisambiguate tokens without taking contextual information into account.
P04-1036 W04-0837
Besides the two baselines (BaseR and BaseS), we also compare our model to McCarthy et al.(2004b)4 and the best unsupervised (IRST-DDD) and supervised (GAMBLE) systems that participated in Senseval-3.
P04-1036 W04-0837
