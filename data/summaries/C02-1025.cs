On the MUC-6 data, Bikel et al.(1997; 1999) do have some statistics that show how IdentiFinder performs when the training data is reduced.
A97-1029
Mikheev et al.(1998) did make use of information from the whole document.
M98-1021
IdentiFinder's performance in MUC-7 is published in (Miller et al., 1998).
M98-1009
In MUC-6, the best result is achieved by SRA (Krupka, 1995).
M95-1018
Previous work deals with this problem by correcting inconsistencies between the named entity classes assigned to different occurrences of the same entity (Borthwick, 1999; Mikheev et al., 1998).
M98-1021
Mikheev et al.(1998) have also used a maximum entropy classifier that uses already tagged entities to help tag other entities.
M98-1021
In MUC-6 and MUC-7, the named entity task is defined as finding the following classes of names: person, organization, location, date, time, money, and percent (Chinchor, 1998; Sundheim, 1995) Machine learning systems in MUC-6 and MUC7 achieved accuracy comparable to rule-based systems on the named entity task.
M98-1028
MUC-7 has also seen hybrids of statistical NERs and hand-coded systems (Mikheev et al., 1998; Borthwick, 1999), notably Mikheev's system, which achieved the best performance of 93.39% on the official NE test data.
E99-1001 M98-1021
The importance of dictionaries in NERs has been investigated in the literature (Mikheev et al., 1999).
E99-1001
Since MUC-6, BBN's Hidden Markov Model (HMM) based IdentiFinder (Bikel et al., 1997) has achieved remarkably good performance.
A97-1029
Statistical NERs usually find the sequence of tags that maximizes the probability a0a2a1a4a3a6a5a8a7a10a9, where a7 is the sequence of words in a sentence, and a3 is the sequence of named-entity tags assigned to the words in a7. Attempts have been made to use global information (e.g., the same named entity occurring in different sentences of the same document), but they usually consist of incorporating an additional classifier, which tries to correct the errors in the output of a first NER (Mikheev et al., 1998; Borthwick, 1999).
E99-1001 M98-1021
In this section, we try to compare our results with those obtained by IdentiFinder '97 (Bikel et al., 1997), IdentiFinder '99 (Bikel et al., 1999), and MENE (Borthwick, 1999).
A97-1029
This enables us to build a high performance NER without using separate classifiers to take care of global consistency or complex formulation on smoothing and backoff models (Bikel et al., 1997).
A97-1029
These results are achieved by training on the official MUC-6 and MUC-7 training data, which is much less training data than is used by other machine learning systems that worked on the MUC-6 or MUC-7 named entity task (Bikel et al., 1997; Bikel et al., 1999; Borthwick, 1999).
A97-1029
In (Bikel et al., 1997) and (Bikel et al., 1999), performance was plotted against training data size to show how performance improves with training data size.
A97-1029
