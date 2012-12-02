Utsuro et al.(2002) studies combining outputs of multiple Japanese NE systems by stacking.
W02-1036
Four statistical classifiers are combined in the experiments, including the above-mentioned hidden Markov model classifier, a transformationbased learning classifier (Brill, 1995; Florian and Ngai, 2001), a maximum entropy classifier (Ratnaparkhi, 1999), and a robust risk minimization classifier (Zhang et al., 2002).
J95-4004
A simple combination method is the equal voting method (van Halteren et al., 2001; Tjong Kim Sang et al., 2000), where the parameters are computed as a122 a23 a9a42a21a69a18a124a28 a7 a88 and a40 a23 a9a84a10a117a45a21 a12 a10 a23 a18a124a28 a125 a9a11a10 a12 a10 a23 a18, a125 being the Kronecker operator: a125 a9a42a46 a12 a68a8a18a58a28 a32 a46a126a28a60a68 a30a127a46a67a128a28a60a68 In other words, each of the classifiers votes with equal weight for the class that is most likely under its model, and the class receiving the largest number of votes wins (i.e., it is selected as the classification output).
C00-2124 J01-2002
Classifier combination has been shown to be effective in improving the performance of NLP applications, and have been investigated by Brill and Wu (1998) and van Halteren et al.(2001) for part-of-speech tagging, Tjong Kim Sang et al.(2000) for base noun phrase chunking, and Florian et al.(2003a) for word sense disambiguation.
C00-2124 J01-2002 P98-1029 W03-0419 W03-0425
Sekine and Eriguchi (2000) provides an overview of Japanese NE recognition.
C00-2167
TBL has some attractive qualities that make it suitable for the language-related tasks: it can automatically integrate heterogeneous types of knowledge, without the need for explicit modeling (similar to Snow (Dagan et al., 1997), Maximum Entropy, decision trees, etc); it is error–driven, thus directly minimizes the ultimate evaluation measure: the error rate.
W97-0306
For comparison, we also computed two baselines: one in which each character is labeled with its most frequent label (Baseline1 in Table 2), and one in which each entity that was seen in training data is labeled with its most frequent classification (Baseline2 in Table 2 this baseline is computed using the software provided with the CoNLL-2003 shared task (Tjong Kim Sang and De Meulder, 2003)).
W03-0419
Tjong Kim Sang and Veenstra (1999) describes in detail the IOB schemes.
E99-1023
We also applied the classifier combination technique discussed in this paper to English and German (Florian et al., 2003b).
W03-0425
Work Sun et al.(2002) proposes to use a class-based model for Chinese NE recognition.
C02-1012
It was a designated task in a number of conferences, including the Message Understanding Conferences (MUC-6, 1995; MUC-7, 1997), the Information Retrieval and Extraction Conference (IREX, 1999), the Conferences on Natural Language Learning (Tjong Kim Sang, 2002; Tjong Kim Sang and De Meulder, 2003), and the recent Automatic Content Extraction Conference (ACE, 2002).
W02-2024 W03-0419
