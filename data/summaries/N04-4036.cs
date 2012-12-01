[Kudo and Matsumoto2001] Taku Kudo and Yuji Matsumoto.
N01-1025
Annotation and Corpora For our experiments, we use the FrameNet database (Baker et al., 1998) which contains frame-specific seThis research was partially supported by the ARDA AQUAINT program via contract OCG4423B and by the NSF via grant IS-9978025 mantic annotation of a number of predicates in English.
P98-1013
We create a baseline system using a subset of features introduced by Gildea and Jurafsky (2002), which are directly applicable to nominal predicates.
J02-3001 P02-1031
References [Baker et al.1998] Collin F.
P98-1013
[Lapata2002] Maria Lapata.
J02-3004
[Kudo and Matsumoto2000] Taku Kudo and Yuji Matsumoto.
W00-0730
We used the Charniak parser (Chaniak, 2001) to parse the sentences in order to perform feature extraction.
P01-1017
[Gildea and Jurafsky2002] Daniel Gildea and Daniel Jurafsky.
J02-3001 P02-1031
[Surdeanu et al.2003] Mihai Surdeanu, Sanda Harabagiu, John Williams, and Paul Aarseth.
P03-1002
The bulk of this recent work views semantic analysis as a tagging, or labeling problem, and has applied various supervised machine learning techniques to it (Gildea and Jurafsky (2000, 2002); Gildea and Palmer (2002); Surdeanu et al.(2003); Hacioglu and Ward (2003); Thompson et al.(2003); Pradhan et al.(2003)). Note that, while all of these systems are limited to the analysis of verbal predicates, many underlying semantic relations are expressed via nouns, adjectives, and prepositions.
J02-3001 N03-2009 P00-1065 P02-1031 P03-1002
[Gildea and Jurafsky2000] Daniel Gildea and Daniel Jurafsky.
P00-1065
Predicate NP expansion rule – This is the noun equivalent of the verb sub-categorization feature used by Gildea and Jurafsky (2002).
J02-3001 P02-1031
14. Named Entities in Constituent – As in Surdeanu et al.(2003), this is represented as seven binary features extracted after tagging the sentence with BBN’s IdentiFinder (Bikel et al., 1999) named entity tagger.
P03-1002
[Gildea and Palmer2002] Daniel Gildea and Martha Palmer.
J02-3001 P02-1031
We use TinySVM2 along with YamCha3 (Kudo and Matsumoto (2000, 2001)) as the SVM training and test software.
N01-1025 W00-0730
[Hacioglu and Ward2003] Kadri Hacioglu and Wayne Ward.
N03-2009
Two notable exceptions to this include the work of (Hull and Gomez, 1996) – a rule based system for identifying the semantic arguments of nominal predicates, and the work of (Lapata, 2002) on interpreting the relation between the head of a nominalized compound and its modifier noun.
J02-3004
