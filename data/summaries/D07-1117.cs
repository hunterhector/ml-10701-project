Hidden Markov models are simple and effective, but unlike discriminative models, such as Maximum Entropy models (Ratnaparkhi, 1996) and Conditional Random Fields (John Lafferty, 2001), they have more difficulty utilizing a rich set of conditionally dependent features.
W96-0213
HMM Model 2.1 Porting English Tagger to Mandarin The HMM tagger used in this work is a secondorder HMM tagger initially developed for English by Thede and Harper (1999).
P99-1023
The interpolation weights for smoothing transition, emission, and suffix probabilities were estimated using the log-based Thede smoothing method (Thede and Harper, 1999) as follows: PThede(n-gram) = λ(n-gram)PML(n-gram) + (1−λ(n-gram))PThede((n-1)-gram) where: PML(n-gram) = the ML estimation λ(n-gram) = f(n-gram count) f(x) = loga(x+ 1) +blog a(x+ 1) + (b+ 1) While porting the HMM-based English POS tagger to Mandarin is fairly straightforward for words seen in the training data, some thought is required to handle unknown words due to the morphology differences between the two languages.
P99-1023
In order to train the reranking model, the method in (Collins and Koo, 2005) is used to prepare the N-best training examples.
J05-1003
Note that we did not use all the morphological features as in (Tseng et al., 2005), which would probably provide additional improvement.
I05-3005
We have also investigated using the reranking algorithm in (Collins and Koo, 2005) for the Mandarin POS tagging task, and found it quite effective 8Tseng at el.’s training/test split uses up the entire CTB corpus, leaving no development data for tuning parameters.
J05-1003
When working on the same training/test data (CTB5.0 with the same pre-processing procedures) as in (Tseng et al., 2005), our HMM model obtained an accuracy of 93.72%, as compared to their 93.74% accuracy.
I05-3005
Reranking In this section, we describe our use of the RankBoost-based (Freund and Schapire, 1997; Freund et al., 1998) discriminative reranking approach that was originally developed by Collins and Koo (2005) for parsing.
J05-1003
Lower accuracies have been reported in the literature for Mandarin POS tagging (Tseng et al., 2005; Xue et al., 2002).
C02-1145 I05-3005
(2005) reported accuracies of 93% and 93.74% on CTB-I (Xue et al., 2002) (100K words) and CTB 5.0 (500K words), respectively, each using a Maximum Entropy approach.
C02-1145
6AffixPOS features are somewhat different from the CTBMorph features used in (Tseng et al., 2005), where a morpheme/POS dictionary with the possible tags for all morphemes in the training set was used instead of two separate dictionaries for prefix and suffix.
I05-3005
First a bracketing parser (the Charniak parser (Charniak, 2000) in our case) is used to generate the parse tree of a sentence, then the const2dep tool developed by Hwa was utilized to convert the bracketing tree to a dependency tree based on the head percolation table developed by the second author.
A00-2018
Reranking approaches (Charniak and Johnson, 2005; Chen et al., 2002; Collins and Koo, 2005; Ji et al., 2006; Roark et al., 2006) have been successfully applied to many NLP applications, including parsing, named entity recognition, sentence boundary detection, etc.
J05-1003 P05-1022 W06-3607
In order to better handle unknown words, we also extract the two most important types of morphological features5 that were utilized in (Tseng et al., 2005) for those words that appear no more than seven times (following their convention) in the training set: Affixation features: we use character n-gram prefixes and suffixes for n up to 4.
I05-3005
The state-of-theart systems have achieved an accuracy of 97% for English on the Wall Street Journal (WSJ) corpus (which contains 4.5M words) using various models (Brants, 2000; Ratnaparkhi, 1996; Thede and Harper, 1999).
A00-1031 P99-1023 W96-0213
