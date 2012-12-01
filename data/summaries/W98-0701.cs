The reason why gj (I0) is calculated as a sum of the best scores (ll), rather than by using the traditional maximum likelihood estimate (Berger et al., 1996)(Gah eta\[., 1993), is to minimise the effect of the sparse data problem.
J96-1002
To determine the tree head-word we used a set of rules similar to that described by (Magerman, 1995)(Jelinek et al., 1994) and also used by (Collins, 1996), which we modified in the following way: • The head of a prepositional phrase (PP-IN NP) was substituted by a function the name of which corresponds to the preposition, and its sole argument corresponds to the head of the noun phrase NP.
H94-1052 P95-1037 P96-1025
(Agirre and Rigau, 1996) report coverage 86.2%, precision 71.2% and recall 61.4% for nouns in four randomly selected semantic concordance files.
C96-1005
(Yarowsky, 1995), whose training corpus for the noun drug was 9 times bigger than that of Karov and Edelman, reports 91.4% correct performance improved to impressive 93.9% when using the "one sense per discourse" constraint.
P95-1026
Similarly to our work, (Resnik, 1995)(Agirre and Rigau, 1996) challenge the fine-grainedness of WordNet, but their work is limited to nouns only.
C96-1005 W95-0105
Both for the training and for the testing of our algorithm, we used the syntactically analysed sentences of the Brown Corpus (Marcus, 1993), which have been manually semantically tagged (Miller et al., 1993) into semantic concordance files (SemCor).
H93-1061 J93-2004
Context (Yarowsky, 1995) pointed out that the sense of a target word is highly consistent within any given document (one sense per discourse).
P95-1026
(Karov and Edelman, 1996) use an interesting iterative algorithm and attempt to solve the sparse data bottleneck by using a graded measure of contextual similarity.
W96-0104
Because our algorithm does not consider the context given by the preceding sentences, we have conducted the following experiment to see to what extent the discourse context could improve the performance of the wordsense disambiguation: Using the semantic concordance files (Miller et al., 1993), we have counted the occurrences of content words which previously appear in the same discourse file.
H93-1061
