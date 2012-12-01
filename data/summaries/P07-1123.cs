Similar to, e.g., (Pang et al., 2002), we use a Naive Bayes algorithm trained on word features cooccurring with the subjective and the objective classifications.
W02-1011
This is reported in studies of manual annotation of phrases (Takamura et al., 2006), recognizing contextual polarity of expressions (Wilson et al., 2005), and sentiment tagging of words and word senses (Andreevskaia and Bergler, 2006; Esuli and Sebastiani, 2006).
E06-1025 E06-1026 E06-1027 H05-1044
Lexicon-Based Approach Many subjectivity and sentiment analysis tools rely on manually or semi-automatically constructed lexicons (Yu and Hatzivassiloglou, 2003; Riloff and Wiebe, 2003; Kim and Hovy, 2006).
N06-1026 P06-1134 W03-1014 W03-1017
While work on subjectivity analysis in other languages is growing (e.g., Japanese data are used in (Takamura et al., 2006; Kanayama and Nasukawa, 2006), Chinese data are used in (Hu et al., 2005), and German data are used in (Kim and Hovy, 2006)), much of the work in subjectivity analysis has been applied to English data.
E06-1026 N06-1026 W06-1642
First, even when sentiment is the desired focus, researchers in sentiment analysis have shown that a two-stage approach is often beneficial, in which subjective instances are distinguished from objective ones, and then the subjective instances are further classified according to polarity (Yu and Hatzivassiloglou, 2003; Pang and Lee, 2004; Wilson et al., 2005; Kim and Hovy, 2006).
H05-1044 N06-1026 P04-1035 W03-1017
In the experiments reported in this section, we use a parallel corpus consisting of 107 documents from the SemCor corpus (Miller et al., 1993) and their manual translations into Romanian.3 The corpus consists of roughly 11,000 sentences, with approximately 250,000 tokens on each side.
H93-1061
3.2 Rule-based Subjectivity Classifier Using a Subjectivity Lexicon Starting with the Romanian lexicon, we developed a lexical classifier similar to the one introduced by (Riloff and Wiebe, 2003).
W03-1014
Automatic subjectivity analysis methods have been used in a wide variety of text processing applications, such as tracking sentiment timelines in online forums and news (Lloyd et al., 2005; Balog et al., 2006), review classification (Turney, 2002; Pang et al., 2002), mining opinions from product reviews (Hu and Liu, 2004), automatic expressive text-to-speech synthesis (Alm et al., 2005), text semantic analysis (Wiebe and Mihalcea, 2006; Esuli and Sebastiani, 2006), and question answering (Yu and Hatzivassiloglou, 2003).
E06-1025 E06-2031 H05-1073 P02-1053 P04-1035 P06-1134 W02-1011 W03-1017
This is consistent with observations made in previous work that subjectivity is a property associated not with words, but with word meanings (Wiebe and Mihalcea, 2006).
P06-1134
This approach builds a subjectivity-annotated corpus for the target language through projection, and then trains a statistical classifier on the resulting corpus (numerous statistical classifiers have been trained for subjectivity or sentiment classification, e.g., (Pang et al., 2002; Yu and Hatzivassiloglou, 2003)).
W02-1011 W03-1017
