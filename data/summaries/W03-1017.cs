Work Much of the earlier research in automated opinion detection has been performed by Wiebe and colleagues (Bruce and Wiebe, 1999; Wiebe et al., 1999; Hatzivassiloglou and Wiebe, 2000; Wiebe, 2000; Wiebe et al., 2002), who proposed methods for discriminating between subjective and objective text at the document, sentence, and phrase levels.
C00-1044 P99-1032
Hatzivassiloglou and McKeown (1997) described an unsupervised learning method for obtaining positively and negatively oriented adjectives with accuracy over 90%, and demonstrated that this semantic orientation, or polarity, is a consistent lexical property with high inter-rater agreement.
P97-1023
We used Brill’s tagger (Brill, 1995) to obtain part-of-speech information.
J95-4004
In earlier work (Turney, 2002) only singletons were used as seed words; varying their number allows us to test whether multiple seed words have a positive effect in detection performance.
P02-1053
As seed words, we used subsets of the 1,336 adjectives that were manually classified as positive (657) or negative (679) by Hatzivassiloglou and McKeown (1997).
P97-1023
recall and precision of extracted adjectives by using randomly selected seed sets of 1, 20, and 100 pairs of positive and negative adjectives from the list of (Hatzivassiloglou and McKeown, 1997).
P97-1023
Subsequently, Hatzivassiloglou and Wiebe (2000) showed that automatically detected gradable adjectives are a useful feature for subjectivity classification, while Wiebe (2000) introduced lexical features in addition to the presence/absence of syntactic categories.
C00-1044
For determining whether an opinion sentence is positive or negative, we have used seed words similar to those produced by (Hatzivassiloglou and McKeown, 1997) and extended them to construct a much larger set of semantically oriented words with a method similar to that proposed by (Turney, 2002).
P02-1053 P97-1023
Turney (2002) showed that it is possible to use only a few of those semantically oriented words (namely, “excellent” and “poor”) to label other phrases co-occuring with them as positive or negative.
P02-1053
Our focus is on the sentence level, unlike (Pang et al., 2002) and (Turney, 2002); we employ a significantly larger set of seed words, and we explore as indicators of orientation words from syntactic classes other than adjectives (nouns, verbs, and adverbs).
P02-1053 W02-1011
Bruce and Wiebe (1999) annotated 1,001 sentences as subjective or objective, and Wiebe et al.(1999) described a sentence-level Naive Bayes classifier using as features the presence or absence of particular syntactic classes (pronouns, adjectives, cardinal numbers, modal verbs, adverbs), punctuation, and sentence position.
P99-1032
Syntactic structure was obtained with Charniak’s statistical parser (Charniak, 2000).
A00-2018
One set consists of the previously described 657 positive and 679 negative adjectives (Hatzivassiloglou and McKeown, 1997).
P97-1023
Figure 1 plots the Features Class Standard A Standard BSingle Multiple Single Multiple Features from (Wiebe et al., 1999) Fact a0 0.03,0.38 a1 a0 0.03,0.38 a1 a0 0.06,1.00a1 a0 0.06,1.00 a1Opinion a0 0.97,0.69 a1 a0 0.97,0.69 a1 a0 1.00,0.80a1 a0 1.00,0.80 a1 Words only Fact a0 0.14,0.39 a1 a0 0.12,0.42 a1 a0 0.28,0.42a1 a0 0.28,0.45 a1Opinion a0 0.90,0.69 a1 a0 0.92,0.69 a1 a0 0.90,0.82a1 a0 0.91,0.83 a1 Words and Bigrams Fact a0 0.15,0.39 a1 a0 0.12,0.43 a1 a0 0.16,0.25a1 a0 0.16,0.25 a1Opinion a0 0.89,0.69 a1 a0 0.92,0.69 a1 a0 0.87,0.79a1 a0 0.87,0.79 a1 Words, Bigrams, and Trigrams Fact a0 0.18,0.44 a1 a0 0.13,0.41 a1 a0 0.26,0.50a1 a0 0.26,0.50 a1Opinion a0 0.89,0.70 a1 a0 0.91,0.69 a1 a0 0.93,0.82a1 a0 0.93,0.82 a1 Words, Bigrams, Trigrams, and Part-of-Speech Fact a0 0.17,0.42 a1 a0 0.13,0.40 a1 a0 0.18,0.49a1 a0 0.27,0.44 a1 Opinion a0 0.89,0.70 a1 a0 0.91,0.69 a1 a0 0.92,0.70a1 a0 0.85,0.84 a1 Words, Bigrams, Trigrams, Part-of-Speech, and Polarity Fact a0 0.15,0.43 a1 a0 0.13,0.42 a1 a0 0.44,0.50a1 a0 0.44,0.53 a1 Opinion a0 0.91,0.69 a1 a0 0.92,0.70 a1 a0 0.88,0.86a1 a0 0.91,0.86 a1 Table 4: a0 Recall, precisiona1 of opinion/fact sentence classification using different features and either a single or multiple (data cleaning) classifiers.
P99-1032
The approach is based on the hypothesis that positive words co-occur more than expected by chance, and so do negative words; this hypothesis was validated, at least for strong positive/negative words, in (Turney, 2002).
P02-1053
In addition, the presence of semantically oriented (positive and negative) words in a sentence is an indicator that the sentence is subjective (Hatzivassiloglou and Wiebe, 2000).
C00-1044
Although Naive Bayes can be outperformed in text classification tasks by more complex methods such as SVMs, Pang et al.(2002) report similar performance for Naive Bayes and other machine learning techniques for a similar task, that of distinguishing between positive and negative reviews at the document level.
W02-1011
While words and n-grams had little performance effect for the opinion class, they increased the recall for the fact class around five fold compared to the approach by Wiebe et al.(1999). In general, the additional features helped the classifier; the best performance is achieved when words, bigrams, trigrams, part-of-speech, and polarity are included in the feature set.
P99-1032
Pang et al.(2002) adopted a more direct approach, using supervised machine learning with words and n-grams as features to predict orientation at the document level with up to 83% precision.
W02-1011
