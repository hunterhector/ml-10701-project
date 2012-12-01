We use maximum entropy model (Berger et al., 1996) for both the mention-pair model (9) and the entity-mention model (8): a83a84a1a86a85a88a87 a43 a44 a71 a43 a16 a5a13a7 a55a35a34a23a36 a6a35a37 a6a39a38a40a6a42a41 a31a44a43a3a45a31 a6 a45a46a48a47a24a49 a50 a1 a43 a44 a71 a43 a16 a5 a71 (10) a83a84a1a4a85 a87 a55 a81 a71 a43 a16 a5a13a7 a55a35a34 a36 a6 a37 a6a39a38a40a6a42a41 a11a7a32 a45a31 a6 a45a46a48a47 a49 a50 a1 a55a39a81 a71 a43 a16 a5 a71 (11) wherea57 a16 a1a51a8 a71a52a8 a71a90a85a73a5 is a feature and a53 a16 is its weight; a50 a1a33a8 a71a54a8a5 is a normalizing factor to ensure that (10) or (11) is a probability.
J96-1002
Morton (2000) also uses a maximum entropy mention-pair model, and a special “dummy” mention is used to model the event of starting a new entity.
P00-1023
The model (9) is very similar to the model in (Morton, 2000; Soon et al., 2001; Ng and Cardie, 2002) while (8) has more conditions.
J01-4004 P00-1023 P02-1014
Their work is later enhanced by (Ng and Cardie, 2002) in several aspects: first, the decision tree returns scores instead of a hard-decision of “link” or “not-link” so that Ng and Cardie (2002) is able to pick the “best” candidate on the left, as opposed the first in (Soon et al., 2001); Second, Ng and Cardie (2002) expands the feature sets of (Soon et al., 2001).
J01-4004 P02-1014
Early work of anaphora resolution focuses on finding antecedents of pronouns (Hobbs, 1976; Ge et al., 1998; Mitkov, 1998), while recent advances (Soon et al., 2001; Yang et al., 2003; Ng and Cardie, 2002; Ittycheriah et al., 2003) employ statistical machine learning methods and try to resolve reference among all kinds of noun phrases (NP), be it a name, nominal, or pronominal phrase – which is the scope of this paper as well.
J01-4004 N03-2014 P02-1014 P03-1023 P98-2143 W98-1119
Effective training algorithm exists (Berger et al., 1996) once the set of features a42 a57 a16 a1a33a8 a71a54a8 a71a100a85a68a5 a53 is selected.
J96-1002
The model in (Yang et al., 2003) expands the conditioning scope by including a competing candidate.
P03-1023
One common strategy shared by (Soon et al., 2001; Ng and Cardie, 2002; Ittycheriah et al., 2003) is that a statistical model is trained to measure how likely a pair of mentions corefer; then a greedy procedure is followed to group mentions into entities.
J01-4004 N03-2014 P02-1014
Morton. 2000.
P00-1023
Soon et al.(2001) uses a decision tree model for coreference resolution on the MUC6 and MUC7 data.
J01-4004
For tests on the MUC data, we report both F-measure using the official MUC score (Vilain et al., 1995) and ECM-F.
M95-1005
Neither (Soon et al., 2001) nor (Ng and Cardie, 2002) searches for the global optimal entity in that they make locally independent decisions during search.
J01-4004 P02-1014
Syntactic features are derived from parse trees output from a maximum entropy parser (Ratnaparkhi, 1997).
W97-0301
The MUC6-small system compares favorably with the similar experiment in Harabagiu et al.(2001) in which an a22 a38a98a34a14a2a1 F-measure is reported.
N01-1008
For example, Kehler (1997) uses a mention-pair maximum entropy model, and two methods are proposed to compute entity scores based on the mention-pair model: 1) a distribution over entity space is deduced; 2) the most recent mention of an entity, together with the candidate mention, is used to compute the entity-mention score.
W97-0319
Details of the mention detection and coreference system can be found in (Florian et al., 2004).
N04-1001
