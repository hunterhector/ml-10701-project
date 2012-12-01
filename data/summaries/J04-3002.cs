Before we continue, there are a few more technical items to mention concerning the data preparation and experimental design: • All of the data sets are stemmed using Karp’s morphological analyzer (Karp et al.1994) and part-of-speech tagged using Brill’s (1992) tagger.
A92-1021 C92-3145
Low-frequency words have been used as features in information extraction (Weeber, Vos, and Baayen 2000) and text categorization (Copeck et al.2000). A number of researchers have worked on mining collocations from text to extend lexicographic resources for machine translation and word sense disambiguation (e.g., Smajda 1993; Lin 1999; Biber 1993).
J93-3004 P99-1041
The third type of subjectivity clue we examine here are adjective and verb features identified using the results of a method for clustering words according to distributional similarity (Lin 1998) (Section 3.4).
P98-2127
Many variants of distributional similarity have been used in NLP (Lee 1999; Lee and Pereira 1999).
P99-1004 P99-1005
Features identified using distributional similarity have previously been used for syntactic and semantic disambiguation (Hindle 1990; Dagan, Pereira, and Lee 1994) and to develop lexical resources from corpora (Lin 1998; Riloff and Jones 1999).
P90-1034 P94-1038 P98-2127 P99-1004 P99-1005 P99-1041
Dekang Lin’s (1998) method is used here.
P98-2127
Still another is identifying the type of a subjective expression (e.g., positive or negative evaluative), extending work such as Hatzivassiloglou and McKeown (1997) on classifying lexemes to the classification of instances in context (compare, e.g., “great!” and “oh great.”) In addition, it would be illuminating to apply our system to data annotated with discourse trees (Carlson, Marcu, and Okurowski 2001).
P97-1023 W01-1605
There are techniques for analyzing agreement when annotations involve segment boundaries (Litman and Passonneau 1995; Marcu, Romera, and Amorortu 1999), but our focus in this article is on words.
P95-1015
With distributional similarity, words are judged to be more or less similar based on their distributional patterning in text (Lee 1999; Lee and Pereira 1999).
P99-1004 P99-1005
Three studies classify reviews as positive or negative (Turney 2002; Pang, Lee, and Vaithyanathan 2002; Dave, Lawrence, Pennock 2003).
W02-1011
For each seed s i, the precision of the set {s i }∪C i,n in the training data is calculated, where C i,n is the set of n words most similar to s i, according to Lin’s (1998) method.
P98-2127
Similarly, Gordon et al.(2003) use manually developed grammars to detect some types of subjective language.
P03-1027
In addition, we used the results of a method for clustering words according to distributional similarity (Lin 1998) to identify adjectival and verbal clues of subjectivity.
P98-2127
In our first subjectivity annotation project (Wiebe, Bruce, and O’Hara 1999; Bruce and Wiebe 1999), a corpus of sentences from the Wall Street Journal Treebank Corpus (Marcus, Santorini, and Marcinkiewicz 1993) (corpus WSJ-SE in Table 1) was annotated at the sentence level by multiple judges.
J93-2004
303 Wiebe, Wilson, Bruce, Bell, and Martin Learning Subjective Language While it is common in studies of collocations to omit low-frequency words and expressions from analysis, because they give rise to invalid or unrealistic statistical measures (Church and Hanks, 1990), we are able to identify higher-precision collocations by including placeholders for unique words (i.e., the ugen-n-grams).
J90-1003
Automatic subjectivity analysis would also be useful to perform flame recognition (Spertus 1997; Kaufer 2000), e-mail classification (Aone, Ramos-Santacruze, and Niehaus 2000), intellectual attribution in text (Teufel and Moens 2000), recognition of speaker role in radio broadcasts (Barzialy et al.2000), review mining (Terveen et al.1997), review classification (Turney 2002; Pang, Lee, and Vaithyanathan 2002), style in generation (Hovy 1987), and clustering documents by ideological point of view (Sack 1995).
W02-1011
However, additional aspects of a document influence its relevance, including evidential status and attitude (Kessler, Nunberg, Sch ¨utze 1997).
P97-1005
For example, in Karlgren and Cutting (1994), editorials are one of fifteen categories, and in Kessler, Nunberg, and Sch ¨utze (1997), editorials are one of six.
C94-2174 P97-1005
