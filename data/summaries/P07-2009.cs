Supertagger The supertagger uses Maximum Entropy tagging techniques (Section 3) to assign a set of lexical categories to each word (Curran et al., 2006).
P06-1088
The C&C tools also contain a number of Maximum Entropy taggers, including the CCG supertagger, a POS tagger (Curran and Clark, 2003a), chunker, and named entity recogniser (Curran and Clark, 2003b).
E03-1071 W03-0424
Statistical tagging techniques can assign lexical categories with high accuracy and low ambiguity (Curran et al., 2006).
P06-1088
Clark et al.(2004) describes a porting method we have developed which exploits the lexicalized nature of CCG by relying on rapid manual annotation at the lexical category level.
C04-1041 P04-1014 W04-3215
A Maximum Entropy supertagger first assigns lexical categories to the words in a sentence (Curran et al., 2006), which are then combined by the parser using the combinatory rules and the CKY algorithm.
P06-1088
We have also investigated perceptron training for the parser (Clark and Curran, 2007b), obtaining comparable accuracy scores and similar training times (a few hours) compared with the log-linear models.
P07-1032 W07-1202
The POS tagger uses the standard set of grammatical categories from the Penn Treebank and, as well as being highly efficient, also has state-of-the-art accuracy on unseen newspaper text: over 97% perword accuracy on Section 23 of the Penn Treebank (Curran and Clark, 2003a).
E03-1071 W03-0424
A disadvantage of the log-linear models is that they require cluster computing resources for practical training (Clark and Curran, 2004b).
C04-1041 P04-1014 W04-3215
The combination of finite-state supertagging and highly engineered C++ leads to a parser which can analyse up to 30 sentences per second on standard hardware (Clark and Curran, 2004a).
C04-1041 P04-1014 W04-3215
The system is built around a wide-coverage Combinatory Categorial Grammar (CCG) parser (Clark and Curran, 2004b).
C04-1041 P04-1014 W04-3215
Clark and Curran (2004b) describes log-linear parsing models for CCG.
C04-1041 P04-1014 W04-3215
The parser also outputs grammatical relations (GRs) consistent with Briscoe et al.(2006). The GRs are derived through a manually created mapping from the CCG dependencies, together with a python post-processing script which attempts to remove any differences between the two annotation schemes (for example the way in which coordination is analysed).
P06-4020
The parser not only recovers the local dependencies output by treebank parsers such as Collins (2003), but also the long-range depdendencies inherent in constructions such as extraction and coordination.
J03-4003
Entropy Taggers The taggers are based on Maximum Entropy tagging methods (Ratnaparkhi, 1996), and can all be trained on new annotated data, using either GIS or BFGS training code.
W96-0213
Clark and Curran (2007a) gives precison and recall scores broken down by relation type and also compares the Mr._2 N/N_1 1 Barnum_3 called_4 ((S[dcl]\NP_1)/NP_2)/NP_3 3 that_5 worst-case_7 N/N_1 1 scenario_8 a_6 NP[nb]/N_1 1 scenario_8 called_4 ((S[dcl]\NP_1)/NP_2)/NP_3 2 scenario_8 called_4 ((S[dcl]\NP_1)/NP_2)/NP_3 1 Barnum_3 But_1 S[X]/S[X]_1 1 called_4 (ncmod _ Barnum_3 Mr._2) (obj2 called_4 that_5) (ncmod _ scenario_8 worst-case_7) (det scenario_8 a_6) (dobj called_4 scenario_8) (ncsubj called_4 Barnum_3 _) (conj _ called_4 But_1) Figure 1: Dependency output in the form of CCG dependencies and grammatical relations performance of the CCG parser with the RASP parser (Briscoe et al., 2006).
P06-4020 P07-1032 W07-1202
The named entity recogniser contains many more features than the other taggers; Curran and Clark (2003b) describes the feature set.
E03-1071 W03-0424
Supertagging has been especially successful for CCG: Clark and Curran (2004a) demonstrates the considerable increases in speed that can be obtained through use of a supertagger.
C04-1041 P04-1014 W04-3215
Curran School of Information Technologies University of Sydney NSW 2006, Australia james@it.usyd.edu.au Stephen Clark Computing Laboratory Oxford University Wolfson Building, Parks Road Oxford, OX1 3QD, UK stephen.clark@comlab.ox.ac.uk Johan Bos Dipartimento di Informatica Universit`a di Roma “La Sapienza” via Salaria 113 00198 Roma, Italy bos@di.uniroma1.it 1 Introduction The statistical modelling of language, together with advances in wide-coverage grammar development, have led to high levels of robustness and efficiency in NLP systems and made linguistically motivated large-scale language processing a possibility (Matsuzaki et al., 2007; Kaplan et al., 2004).
N04-1013 P06-1088
