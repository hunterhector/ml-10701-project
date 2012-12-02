We assume that the system has used the seed list to extract and generalise a set of patterns for each of the relations using training corpora (Ravichandran and Hovy, 2002; Alfonseca et al., 2006a).
P02-1006 P06-2002
Recently, kernel 49 methods are also becoming widely used for relation extraction (Bunescu and Mooney, 2005; Zhao and Grishman, 2005).
H05-1091 P05-1052
Generalising textual patterns (both manually and automatically) for the identification of relations has been proposed since the early nineties (Hearst, 1992), and it has been applied to extendingontologieswithhyperonymyandholonymyrelations (Morin and Jacquemin, 1999; Kietz et al., 2000; Cimiano et al., 2004; Berland and Charniak,1999).
C92-2082 P99-1008 P99-1050
Finkelstein-LandauandMorin(1999) learn patterns for company merging relations with exceedingly good accuracies.
P99-1050
Szpektor et al.(2004) applies a similar, with no seed lists, to extract automatically entailment relationships between verbs, and Etzioni et al.(2005) report very good results extracting Named Entities and relationships from the web.
W04-3206
Several similar approaches have been proposed (Brin, 1998; Agichtein and Gravano, 2000; Ravichandran and Hovy, 2002), with various applications: Question-Answering (Ravichandran and Hovy, 2002), multi-document Named Entity Coreference (Mann and Yarowsky, 2003), and generating biographical information (Mann and Yarowsky, 2005).
P02-1006 P05-1060 W03-0405
For example, the following patterns are reported by Ravichandran and Hovy (2002) for identifying the relations Inventor, Discoverer and Location: Relation Prec.
P02-1006
In order to train a Rote extractor from the web, this procedure is mostly used (Ravichandran and Hovy, 2002): 1.
P02-1006
M.Finkelstein-LandauandE.Morin. 1999.
P99-1050
This may just be the m characters to the left or to the right (Brin, 1998), the longest common substring of several contexts (Agichtein and Gravano, 2000), or all substrings obtained with a suffix tree constructor (Ravichandran and Hovy, 2002).
P02-1006
From the midnineties, there are systems that learn extraction patterns from partially annotated and unannotated data (Huffman, 1995; Riloff, 1996; Riloff and Schmelzenbach, 1998; Soderland, 1999).
W98-1106
The training corpora are processed with a partof-speech tagger and a module for Named Entity Recognition and Classification (NERC) that annotates people, organisations, locations, dates, relative temporal expressions and numbers (Alfonseca et al., 2006b), so this information can be included in the patterns.
P06-2002
Because of the characteristics of the web, it is necessary to develop efficient algorithms able to learn from unannotated data (Riloff and Schmelzenbach, 1998; Soderland, 1999; Mann and Yarowsky, 2005).
P05-1060 W98-1106
The approach followed for the generalisation is the one described by (Alfonseca et al., 2006a; Ruiz-Casado et al., in press), which has a few modifications with respect to Ravichandran and Hovy (2002)’s, such as the use of the wildcard * to represent any sequence of words, and the addition of part-of-speech and Named Entity labels to the patterns.
P02-1006 P06-2002
extractors Rote extractors (Mann and Yarowsky, 2005) estimate the probability of a relation r(p,q) given the surrounding context A1pA2qA3.
P05-1060
Consequently, rote extractors (Brin, 1998; Agichtein and Gravano, 2000; Ravichandran and Hovy, 2002) have been identified as an appropriate method to look for textual contexts that happen to convey a certain relation between two concepts.
P02-1006
