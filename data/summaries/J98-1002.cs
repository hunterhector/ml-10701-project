During the development and the tuning of the algorithm, we used the method of pseudowords (Gale, Church, and Yarowsky 1992; Schitze 1992), to avoid the need for manual verification of the resulting sense tags.
C92-2070
This can be done by smoothing the observed frequencies 7 (Church and Mercer 1993) or by class-based methods (Brown et al.1991; Pereira and Tishby 1992; Pereira, Tishby, and Lee 1993; Hirschman 1986; Resnik 1992; Brill et al.1990; Dagan, Marcus, and Markovitch 1993).
H90-1055 J93-1001 P91-1034 P93-1022 P93-1024
The total weight of a word is the product of the above factors, each normalized by factor(Wi, S) the sum of factors of the words in the sentence: weight(Wi, $) = z_,~'wjcs factor(W j, S)' 8 Because this estimate is unreliable for words with low frequencies in each sense set, Gale, Church, and Yarowsky (1992) suggested to interpolate between probabilities computed within the subcorpus and probabilities computed over the entire corpus.
C92-2070
Recently, Yarowsky (1995) combined an MRD and a corpus in a bootstrapping process.
P95-1026
Gale, Church, and Yarowsky \[1992\]).
C92-2070
For example, defining the senses by the possible translations of the word (Dagan, Itai and Schwall 1991; Brown et al.1991; Gale, Church, and Yarowsky 1992), by the Roget's categories (Yarowsky 1992), or by clustering (Schi~tze 1992), yields a grouping that does not always conform to the desired sense distinctions.
C92-2070 P91-1017 P91-1034
Dagan, Itai, and Schwall (1991) used a bilingual lexicon and a monolingual corpus to save the need for translating the corpus.
P91-1017
Another problem that affects the corpus-based WSD methods is the sparseness of data: these methods typically rely on the statistics of co-occurrences of words, while many of the possible co-occurrences are not observed even in a very large corpus (Church and Mercer 1993).
J93-1001
Word Senses Sample Size Feedback Size % Correct % Correct per Sense Total drug narcotic 65 100 92.3 90.5 medicine 83 65 89.1 sentence judgment 23 327 100.0 92.5 grammar 4 42 50.0 suit court 212 1,461 98.6 94.8 garment 21 81 55.0 player performer 48 230 87.5 92.3 participant 44 1,552 97.7 the feedback sets) consisted of a few dozen examples, in comparison to thousands of examples needed in other corpus-based methods (Sch~itze 1992; Yarowsky 1995).
P95-1026
Yarowsky (1992) learned discriminators for each Roget's category, saving the need to separate the training set into senses.
C92-2070
Brown et al.(1991) and Gale, Church, and Yarowsky (1992) used the translations of ambiguous words in a bilingual corpus as sense tags.
C92-2070 P91-1034
Many of the possible co-occurrences are not observed even in a very large corpus (Church and Mercer 1993).
J93-1001
Using MRD's (Amsler 1984) for word sense disambiguation was popularized by Lesk (1986); several researchers subsequently continued and improved this line of work (Krovetz and Croft 1989; Guthrie et al.1991; V~ronis and Ide 1990).
P91-1019
In recent years, text corpora have been the main source of information for learning automatic WSD (see, for example, Gale, Church, and Yarowsky \[1992\]).
C92-2070
