errors can lead to irrecoverable mention detection errors; Jing et al.(2003) also observe that character-based models are better performing than word-based ones for Chinese named entity recognition.
W03-1026
Statistical Classifiers Good performance in many natural language processing tasks, such as part-of-speech tagging, shallow parsing and named entity recognition, has been shown to depend heavily on integrating many sources of information (Zhang et al., 2002; Jing et al., 2003; Ittycheriah et al., 2003).
N03-2014 W03-1026
To transform the problem into a classification task, we use the IOB2 classification scheme (Tjong Kim Sang and Veenstra, 1999).
E99-1023
Mention Detection The English mention detection model is similar to the system described in (Ittycheriah et al., 2003)7.The following is a list of additional features (again, a56a65a48 is the current token): a3 Shallow parsing information associated with the tokens in window of 3; a3 Prefixes/suffixes of length up to 4; a3 A capitalization/word-type flag (similar to the ones described by Bikel et al.(1997)); a3 Gazetteer information: a handful of location (55k entries) person names (30k) and organizations (5k) dictionaries; a3 A combination of gazetteer, POS and capitalization information, obtained as follows: if the word is a closed-class word — select its class, else if it’s in a dictionary — select that class, otherwise back-off to its capitalization information; we call this feature gap; a3 WordNet information (the synsets and hypernyms of the two most frequent senses of the word); a3 The outputs of three systems (HMM, RRM and MaxEnt) trained on a 32-category named entity data, the output of an RRM system trained on the MUC-6 data, and the output of RRM model identifying 49 categories.
A97-1029 N03-2014
First, the mention-pair model is used as an approximation to the entity-mention model (3), which itself is an approximation of a91 a31a32a31 a1 a23 a92a22 a15 a8a36a0 a15 a8a43a34a81a1 a68a34 . Second, instead of doing a pick-first (Soon et al., 2001) or best-first (Ng and Cardie, 2002) selection, the mention-pair linking model is used to compute a starting probability.
J01-4004 P02-1014
Although we also use a mention-pair model, our tracking algorithm differs from Soon et al.(2001), Ng and Cardie (2002) in several aspects.
J01-4004 P02-1014
The Entity Detection and Tracking task (EDT henceforth) has close ties to the named entity recognition (NER) and coreference resolution tasks, which have been the focus of attention of much investigation in the recent past (Bikel et al., 1997; Borthwick et al., 1998; Mikheev et al., 1999; Miller et al., 1998; Aberdeen et al., 1995; Ng and Cardie, 2002; Soon et al., 2001), and have been at the center of several evaluations: MUC-6, MUC-7, CoNLL’02 and CoNLL’03 shared tasks.
A97-1029 E99-1001 J01-4004 M95-1012 P02-1014 W98-1118
Simple as it seems, the mention-pair model has been shown to work well (Soon et al., 2001; Ng and Cardie, 2002).
J01-4004 P02-1014
Algorithm 1 The RRM Decoding Algorithm foreacha26a29a27a67a42 foreacha68 a1a20a23a69a10a11a10a12a10a45 a60 a48a22a70a26a22a71 a1a73a72a2a25 a57a38a50 a7 a56 a48a54a57 a64a74a30 a57 a31a33a26a17a34 a5a11a75 a60a77a76a74a76 a31a78a26a35a34a66a79a81a80a83a82a38a84a69a85a86a80a24a87a88a48 a60 a48 a70a26a61a71 Somewhat similarly, the MaxEnt algorithm has an associated set of weights a31a33a89 a48a54a57 a34a48a90a50 a7a53a52a54a52a54a52a15 a57a38a50 a7a58a52a54a52a54a52 a25, which are estimated during the training phase so as to maximize the likelihood of the data (Berger et al., 1996).
J96-1002
The segmentation model is similar to the one presented by Lee et al.(2003), and obtains an accuracy of about 98%.
P03-1051
For mention detection we use approaches based on Maximum Entropy (MaxEnt henceforth) (Berger et al., 1996) and Robust Risk Minimization (RRM henceforth) 1For a description of the ACE program see http://www.nist.gov/speech/tests/ace/.
J96-1002
Similarly to classical NLP tasks such as base noun phrase chunking (Ramshaw and Marcus, 1994), text chunking (Ramshaw and Marcus, 1995) or named entity recognition (Tjong Kim Sang, 2002), we formulate the mention detection problem as a classification problem, by assigning to each token in the text a label, indicating whether it starts a specific mention, is inside a specific mention, or is outside any mentions.
W02-2024 W94-0111 W95-0107
Third, this probabilistic framework allows us to search the space of all possible entities, while Soon et al.(2001), Ng and Cardie (2002) take the “best” local hypothesis.
J01-4004 P02-1014
