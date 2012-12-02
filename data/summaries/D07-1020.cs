To evaluate our disambiguation system, we choose the B-cubed scoring method that was used by Bagga & Baldwin (1998).
P98-1012
In Niu et al.(2004) and Pedersen et al.(2005), an ambiguous object is defined as a mention of the ambiguous personal name in a corpus.
P04-1076
For the task of cross-document co-reference, Bagga & Baldwin (1998) chose 24 articles from 83 singleton clusters, and 173 other articles in 11 non-singleton clusters to create the final test data set – Bagga’s corpus.
P98-1012
In Bagga & Baldwin (1998), Mann & Yarowsky (2003) and Gooi & Allan (2004), an ambiguous object refers to a single entity with the ambiguous personal name in a given document.
N04-1002 P98-1012 W03-0405
Bagga’s corpus is a document collection for the English personal name “John Smith” that was used by Bagga & Baldwin (1998).
P98-1012
Moreover, we adopt the policy of “one person per document” as in Bagga & Baldwin (1998), and define an ambiguous object as a set of target entities given by the EXERT system.
P98-1012
From Table 1, we found that the syntactic features (contextual bnp and summarized bnp) and semantic features (contextual entities and document entities) consistently improve the performances, and all performances outperform the best result reported by Bagga & Baldwin (1998): 84.6 Model B-cubed performance Gold standard cluster # 35 Baseline 30.17 (100.00/17.78) Bagga 80.32 (94.77/69.70) Bagga + contextual bnp 89.16 (89.18/89.13) Bagga + summarized bnp 89.59 (92.60/86.78) Bagga + summarized bnp + contextual entities 89.60 (87.16/92.18) Bagga + summarized bnp + document entities 92.02 (93.10/90.97) Table 1: Performances for Bagga’s corpus with the optimal stop-threshold Name Model John Smith (dev) Michael Johnson (dev) Robert Smith (test) James Jones (test) Average performance Gold standard cluster # 53 52 65 24 Baseline 64.63 (111) 67.97 (101) 78.79 (100) 37.50 (104) 62.22 Bagga 82.63 (75) 89.07 (66) 91.56 (73) 86.42 (24) 87.42 Bagga + contextual bnp 85.18 (62) 89.13 (65) 92.35 (74) 86.45 (22) 88.28 Bagga + summarized bnp 85.97 (66) 91.08 (51) 93.17 (70) 90.11 (33) 90.08 Bagga + summarized bnp + contextual entities 85.44 (70) 94.24 (55) 91.94 (73) 96.66 (24) 92.07 Bagga + summarized bnp + document entities 91.94 (61) 92.55 (51) 93.48 (67) 97.10 (28) 93.77 Table 2: Performances for the English Boulder Name corpus with the optimal stop-threshold Name Model Li Gang (dev) Zhang Yong (dev) Li Hai (test) Liu Bo (test) Average performance Gold standard cluster # 57 63 57 45 Baseline 72.61 (100) 76.83 (101) 74.03 (97) 62.07 (100) 71.39 Bagga 96.21 (57) 96.43 (64) 94.51 (64) 91.66 (49) 94.70 Bagga + contextual bnp 97.57 (57) 96.38 (66) 94.53 (64) 93.21 (51) 95.42 Bagga + summarized bnp 98.50 (56) 96.17 (61) 95.38 (62) 93.21 (51) 95.81 Bagga + summarized bnp + contextual entities 99.50 (58) 95.49 (63) 96.75 (58) 91.05 (52) 95.70 Bagga + summarized bnp + document entities 99.50 (56) 94.57 (70) 98.57 (59) 97.02 (48) 97.41 Table 3: Performances for the Chinese Boulder Name corpus with the optimal stop-threshold English Name John Smith (dev) Michael Johnson (dev) Robert Smith (test) James Jones (test) Average performance Bagga + summarized bnp + document entities 91.31 (91.94) 90.57 (92.55) 86.71 (93.48) 96.64 (97.10) 91.31 (93.77) Chinese Name Li Gang (dev) Zhang Yong (dev) Li Hai (test) Liu Bo (test) Average performance Bagga + summarized bnp + document entities 99.06 (99.50) 94.56 (94.56) 98.25 (98.57) 89.18 (97.02) 95.26 (97.41) Table 4: Performances for the Boulder Name corpus with the fixed stop-threshold 196 4.2.2 Performance on the Boulder Name corpus Table 2 and Table 3 show the performance of each feature model with the optimal stop-threshold for the English and Chinese Boulder Name corpora, respectively.
P98-1012
Li et al.(2004) and Malin (2005) consider named-entity disambiguation as a graph problem, and try to capture information related to the ambiguous object beyond local context, even implicit relational information.
N04-1003
In particular, we seek to go beyond the kind of bag of local words features employed in earlier systems (Bagga & Baldwin, 1998; Gooi & Allan, 2004; Pedersen et al., 2005) that did not attempt to exploit deep semantic features that are difficult to extract, and to go beyond the kind of biographical information (Mann & Yarowsky, 2003) that is unlikely to occur with great frequency (such as place of birth, or family relationships) in many of the documents returned by typical search engines.
N04-1002 P98-1012 W03-0405
Bagga & Baldwin (1998), Gooi & Allan (2004), and Pedersen et al.(2005) use local token features; Mann & Yarowsky (2003) extract local biographical information; Niu et al.(2004) use cooccurring Named Entity (NE) phrases and NE relationships in local context.
N04-1002 P04-1076 P98-1012 W03-0405
In order to compare our work to that of others, we re-implement the model used by Bagga & Baldwin (1998).
P98-1012
This work follows on the work of Bagga & Baldwin (1998), Mann & Yarowsky (2003), Niu et al.(2004), Li et al.(2004), Pedersen et al.(2005), and Malin (2005).
N04-1003 P04-1076 P98-1012 W03-0405
Most previous work (Bagga & Baldwin, 1998; Mann & Yarowsky, 2003; Li et al., 2004; Gooi & Allan, 2004; Malin, 2005; Pedersen et al., 2005; Byung-Won On and Dongwon Lee, 2007) employed unsupervised methods because no large annotated corpus is available and because of the variety of the data distributions for different ambiguous personal names.
N04-1002 N04-1003 P98-1012 W03-0405
Li et al.(2004) use the EM algorithm to learn the global probability distribution among documents, entities, and representative mentions, and Malin (2005) constructs a social network graph to learn a similarity matrix.
N04-1003
Because of the difference between Bagga’s resources and ours (different versions of the namedentity system and different dictionaries of the morphological root and the stop-words), our best 195 B-cubed F score for Bagga’s model is 80.3— 4.3 percent lower than the best performance reported by Bagga & Baldwin (1998): 84.6.
P98-1012
In our approach, all documents are preprocessed with a syntactic phrase chunker (Hacioglu, 2004) and the EXERT 1 system (Hacioglu et al.2005; Chen & Hacioglu, 2006), a named-entity detection and co-reference resolution system that was developed for the ACE 2 project.
H05-1048 N04-4037
We not only extract local NE phrases as in Niu et al.(2004), but also use our entity co-reference system to extract accurate and representative NE phrases occurring in a document which may have a relation to the ambiguous object.
P04-1076
Bagga & Baldwin (1998), Mann & Yarowsky (2003), Gooi & Allan (2004), Niu et al.(2004), and Pedersen et al.(2005) explore features in local context.
N04-1002 P04-1076 P98-1012 W03-0405
