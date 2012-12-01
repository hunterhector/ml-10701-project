While there have been many publications on computational morphological analysis for Arabic (see (Al-Sughaiyer and Al-Kharashi, 2004) for an excellent overview), to our knowledge only Diab et al.(2004) perform a large-scale corpus-based evaluation of their approach.
N04-4038
We use Yamcha (Kudo and Matsumoto, 2003), an implementation of support vector machines which includes Viterbi decoding.6 As training features, we use two sets.
P03-1004
POS Tagging The POS tagset Diab et al.(2004) use is a subset of the tagset for English that was introduced with the English Penn Treebank.
N04-4038
Lee et al.(2003) show that the unsupervised use of the large corpus for stem identification increases accuracy.
P03-1051
In contrast, Diab et al.(2004) treat NO FUNC like any other POS tag, but it is unclear whether this is meaningful.
N04-4038
Diab et al.(2004) report a score of 95.5% for all tokens on a test corpus drawn from ATB1, thus their figure is comparable to our score of 97.6%.
N04-4038
We take the comparison between our results on POS tagging and those of Diab et al.(2004) to indicate that the use of a morphological analyzer is beneficial for Arabic as 574 Feature Description Possible Values POS that Default Name Carry Feature POS Basic part-of-speech See Footnote 9 all X Conj Is there a cliticized conjunction?
N04-4038
While the token-based evaluation is identical to that performed by Diab et al.(2004), the results are not directly comparable as they did not use actual input words, but rather recreated input words from the regenerated tokens in the ATB.
N04-4038
Lee et al.(2003) use a corpus of manually segmented words, which appears to be a subset of the first release of the ATB (110,000 words), and thus comparable to our training corpus.
P03-1051
We map our best solutions as chosen by the Maj model in Section 6 to the English tagset, and we furthermore assume (as do Diab et al.(2004)) the gold standard tokenization.
N04-4038
The only work on Arabic tagging that uses a corpus for training and evaluation (that we are aware of), (Diab et al., 2004), does not use a morphological analyzer.
N04-4038
Among this literature, Rogati et al.(2003) investigate unsupervised learning of stemming (a variant of tokenization in which only the stem is retained) using Arabic as the example language.
P03-1050
