As described above, we prepared two sets of training examples for each English word sense to disambiguate: one set was translated word-byword by looking up a bilingual dictionary, as proposed in (Wang and Carroll, 2005), and the other translated using MT software.
H05-1069
In detail, we first mapped senses of ambiguous words, as defined in the gold-standard TWA (Mihalcea, 2003) and Senseval-3 lexical sample (Mihalcea et al., 2004) datasets (which we use for evaluation) onto their corresponding Chinese translations.
W04-0807
We can see that the recall has increased significantly, and is now closer to the MFS baseline, which is a very hard baseline for unsupervised systems (McCarthy et al., 2004).
P04-1036
of Sense Examples Wang and Carroll (2005) proposed an automatic approach to acquire sense examples from large amount of Chinese text and English-Chinese and Chinese-English dictionaries.
H05-1069
In the future, we would like to combine our approach with other systems based on automatic acquisition of sense examples that can provide local context (Agirre and Martinez, 2004b).
W04-0813 W04-3204
Still, the performance is significantly lower than the score achieved by supervised systems, which can reach above 72% recall (Mihalcea et al., 2004).
W04-0807
Li. 2004.
J04-1001
For example, Ng et al.(2003) proposed to train a classifier on sense examples acquired from word-aligned English-Chinese parallel corpora.
P03-1058
Among them, systems under the multilingual paradigm have shown great promise (Gale et al., 1992; Dagan and Itai, 1994; Diab and Resnik, 2002; Ng et al., 2003; Li and Li, 2004; Chan and Ng, 2005; Wang and Carroll, 2005).
H05-1069 J04-1001 J94-4003 P02-1033 P03-1058
Also, we would like to analyse if automatically obtained information on sense distribution (McCarthy et al., 2004) can improve WSD performance.
P04-1036
MT software translated ones), as it has been shown to perform well with the features described below (Agirre and Martinez, 2004a).
W04-0813 W04-3204
For example, Dagan and Itai (1994) carried out WSD experiments using monolingual corpora, a bilingual lexicon and a parser for the source language.
J94-4003
Wang and Carroll (2005) proposed to use monolingual corpora and bilingual dictionaries to automatically acquire sense examples.
H05-1069
This paper is organised as follows: Section 2 revisits the process of acquiring sense examples proposed in (Wang and Carroll, 2005) and then describes our adapted approach.
H05-1069
For finegrained evaluation, we used Senseval-3 English lexical sample dataset (Mihalcea et al., 2004), which comprises 7,860 sense-tagged instances for training and 3,944 for testing, on 57 words (nouns, verbs and adjectives).
W04-0807
7 http://wordnet.princeton.edu 8 http://www.wordsmyth.net We also used the SemCor corpus (Miller et al., 1993) for tuning our relative-threshold heuristic.
H93-1061
We also obtained salient bigrams in the context, with the methods and the software described in (Pedersen, 2001).
N01-1011
The intuition is that although machine translated text contains noise, features like word ordering, POS tags 1 A similar process took 15 minutes per noun as reported in (Chan and Ng, 2005), and about an hour for 20 nouns as reported in (Wang and Carroll, 2005).
H05-1069
