For example, the use of parallel corpora for sense tagging can help with word sense disambiguation (Brown et al., 1991; Dagan, 1991; Dagan and Itai, 1994; Ide, 2000; Resnik and Yarowsky, 1999).
J94-4003 P91-1034 P91-1048
Supervised approaches which make use of a small hand-labeled training set (Bruce and Wiebe, 1994; Yarowsky, 1993) typically outperform unsupervised approaches (Agirre et al., 2000; Litkowski, 2000; Lin, 2000; Resnik, 1997; Yarowsky, 1992; Yarowsky, 1995), but tend to be tuned to a speci c corpus and are constrained by scarcity of labeled data.
C92-2070 H93-1052 H94-1047 P95-1026 W97-0209
with Senseval Data In our experiments with real data, we make use of the parallel corpora constructed by Diab and Resnik (2002) for evaluation purposes.
P02-1033
WSD is fundamental to natural language understanding and is a useful intermediate step for many other language processing tasks (Ide and Veronis, 1998).
J98-1001
The rst model, which we call the Sense model, builds on the work of Diab and Resnik (2002) that uses both parallel text and a sense inventory for the target language, and recasts their approach in a probabilistic framework.
P02-1033
a0 a1a7a6a9a8a11a10a12a1a14a13a16a15a16a17a16a17a16a17a18a15a19a10a12a1a21a20a23a22 and a0a2a3 a6a24a8a11a10 a3a19a13 a15a16a17a16a17a16a17a11a15a19a10 a3a26a25 a22. We use the shorthand a27a29a28 a10 a1a31a30 for a27a29a28a32a0a33a1a35a34 a10 a1a36a30 . 2.2 The Sense Model The Sense Model makes the assumption, inspired by ideas in Diab and Resnik (2002) and Bengio and Kermorvant (2003), that the English word a0a33a1 and the Spanish word a0a37a3 in a translation pair share the same precise sense.
P02-1033
Our Sense Model was motivated by Diab and Resnik (2002) but the avors of the two are quite 3Some English words are found to occur in the Spanish Senses.
P02-1033
Bengio and Kermorvant (2003) present a graphical model that is an attempt to formalize probabilistically the main ideas in Diab and Resnik (2002).
P02-1033
We show that this improves on the results of Diab and Resnik (2002).
P02-1033
0.672 0.651 120,268 As can be seen from the following table, both our models clearly outperform Diab (2003), which is an improvement over Diab and Resnik (2002), in both accuracy and recall, while the Concept Model does signi cantly better than the Sense Model with fewer parameters.
P02-1033
The main inspiration for our work is Diab and Resnik (2002), who use translations and linguistic knowledge for disambiguation and automatic sense tagging.
P02-1033
To take into account variability of translation, we combine the translations from the two systems for each English word, following in the footsteps of Diab and Resnik (2002).
P02-1033
