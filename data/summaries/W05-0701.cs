Diab et al.(2004) describe a part-of-speech tagger based on support vector machines that is trained on tokenized data (clitics are separate tokens), reporting a tagging accuracy of 95.5%. 7 Conclusions We investigated the application of memory-based learning (k-nearest neighbor classification) to morphological analysis and PoS tagging of unvoweled written Arabic, using the ATB1 corpus as training and testing material.
N04-4038
We are not aware of any machine-learning approach to Arabic morphology, but find related issues treated in (Daya et al., 2004), who propose a machine-learning method augmented with linguistic constraints to identifying roots in Hebrew words – a related but reverse task to ours.
W04-3246
4 Part-of-speech tagging We employ MBT, a memory-based tagger-generator and tagger (Daelemans et al., 1996) to produce a part-of-speech (PoS) tagger based on the ATB1 corpus2.
W96-0102
We observe that the tagger, which has an accuracy of 91.9% on new data, can be used to select the appropriate morphological analysis of words in context at a precision of 64.0 and a recall of 89.7. 1 Introduction Memory-based learning has been successfully applied to morphological analysis and part-of-speech tagging in Western and Eastern-European languages (van den Bosch and Daelemans, 1999; Daelemans et al., 1996).
P99-1037 W96-0102
The lexical entries in a lexicon were converted to instances suitable to memorybased learning of the mapping from words to their analyses (van den Bosch and Daelemans, 1999).
P99-1037
The data facilitates machinelearned part-of-speech taggers, tokenizers, and shallow parsing units such as chunkers, as exemplified by Diab et al.(2004). However, Arabic appears to be a special challenge for data-driven approaches.
N04-4038
The attempts to model Arabic morphology in a two-level system (Kay’s (1987) Finite State Model, Beesley’s (1990; 1998) Two-Level Model and Kiraz’s (1994) Multi-tape Two-Level Model) reflect McCarthy’s separation of levels.
C94-1029 E87-1002 P98-1018
A particular instantiation, MBT, was proposed in (Daelemans et al., 1996).
W96-0102
work The application of machine learning methods to Arabic morphology and PoS tagging appears to be somewhat limited and recent, compared to the vast descriptive and rule-based literature particularly on morphology (Kay, 1987; Beesley, 1990; Kiraz, 1994; Beesley, 1998; Cavalli-Sfora et al., 2000; Soudi, 2002).
C94-1029 E87-1002 P98-1018
