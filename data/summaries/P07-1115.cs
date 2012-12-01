An improved acquisition technique is used which expands on the ideas Yallop et al.(2005) recently explored for a small experiment on adjectival SCF acquisition.
P05-1076
The first systems capable of automatically learning a small number of verbal subcategorization frames (SCFs) from unannotated English corpora emerged over a decade ago (Brent, 1991; Manning, 1993).
P91-1027 P93-1032
Unlike in Yallop’s work (Yallop et al., 2005), our rules are declarative rather than procedural and these rules, written independently of the acquisition system, are expanded by the system in a number of ways prior to execution.
P05-1076
The details of these measures and their application to subcategorization acquisition can be found in (Korhonen and Krymolowski, 2002).
W02-2014
Information Extraction (IE) ((Surdeanu et al., 2003)).
P03-1002
(Briscoe and Carroll, 1997)) is to extract SCFs from parse trees, introducing an unnecessary dependence on the details of a particular parser.
A97-1052
Grammatical Relations We obtain the GRs using the recent, second release of the RASP toolkit (Briscoe et al., 2006).
P06-4020
It involves identifying SCFs on the basis of grammatical relations (GRs) in the output of the RASP (Robust Accurate Statistical Parsing) system (Briscoe et al., 2006).
P06-4020
A similar approach was recently motivated and explored by Yallop et al.(2005). A decision-tree classifier was developed for 30 adjectival SCF types which tests for the presence of GRs in the GR output of the RASP (Robust Accurate Statistical Parsing) system (Briscoe and Carroll, 2002).
P05-1076
A way to maximise the accuracy of the lexicon would be to smooth (correct) the acquired SCF distributions with back-off estimates based on lexical-semantic classes of verbs (Korhonen, 2002) (see section 4) before filtering them.
W02-2014
probability) estimates based on lexical-semantic classes of verbs (Korhonen, 2002).
W02-2014
Subsequent research has yielded systems for English (Carroll and Rooth, 1998; Briscoe and Carroll, 1997; Korhonen, 2002) capable of detecting comprehensive sets of SCFs with promising accuracy and demonstrated success in application tasks (e.g.
A97-1052 W02-2014 W98-1114
The first column shows the results for Briscoe and Carroll’s (1997) (B&C) system when this system is run with the original classifier but a more recent version of the parser (Briscoe and Carroll, 2002) and the same filtering technique as our new system (thresholding based on the relative frequencies of SCFs).
A97-1052
(Carroll et al., 1998; Korhonen et al., 2003)).
P03-1009 W98-1114
Classifier SCF Frames The SCFs recognized by the classifier were obtained by manually merging the frames exemplified in the COMLEX Syntax (Grishman et al., 1994), ANLT (Boguraev et al., 1987) and/or NOMLEX (Macleod et al., 1997) dictionaries and including additional frames found by manual inspection of unclassifiable examples during development of the classifier.
C94-1042 P87-1027
(Carroll et al., 1998), important for many NLP tasks (e.g.
W98-1114
