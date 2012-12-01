In order to accomplish these steps, Bhattacharya et al.(2004) used the pseudo-translation approach of Diab and Resnik (2002): they created the model using an English-Spanish parallel corpus constructed by using Systran to translate a large collection of English text, and they obtained parallel Spanish text for the test items in the same fashion.
P02-1033 P04-1037
For example, in the English-Spanish sentence pair Me gusta la ciudad/I like the city, one would find the translation pairs a1a3a2a5a4a7a6 a13a9a8, a1a3a10 a1a12a11 a13a13a4a15a14a17a16 a3 a16a19a18a20a8, a1 a16a7a21 a13a13a4a22a10a3a18a23a8, and a1a3a24 a1 a16a19a25a26a4a22a24 a1 a16a28a27a17a18a29a27a29a8 .2 Those familiar with statistical machine translation (MT) models will note that a translation pair is equivalent to a link in a word-level alignment, and in fact we obtain translation pairs from sentence-aligned parallel text by training a statistical MT model (using GIZA++, (Och and Ney, 2003)) and using the word-level alignments that result.
J03-1002
Sense Tagging using Bilingual Text 2.1 Probabilistic Sense Model For the past several years, the University of Maryland group has been exploring unsupervised approaches to word sense disambiguation that take advantage of parallel corpora (Diab and Resnik, 2002; Diab, 2003).
P02-1033
Recently, Bhattacharya et al.(2004) (in a UMD/Montreal collaboration) have developed a variation on this bilingual approach that is inspired by the central insight of Diab’s work, but recasts it in a probabilistic framework.
P04-1037
We used Systran for Spanish and French, and for Chinese we used an implementation of the alignment template framework for statistical MT (Kumar and Byrne, 2003).
N03-1019
In information retrieval, we and other researchers have found that it can be useful to expand the representation of a document to include informative words from similar documents (Levow et al., 2001).
H01-1060
