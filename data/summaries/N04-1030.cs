[Gildea and Hockenmaier2003] Dan Gildea and Julia Hockenmaier.
W03-1008
[Blaheta and Charniak2000] Don Blaheta and Eugene Charniak.
A00-2031
[Surdeanu et al.2003] Mihai Surdeanu, Sanda Harabagiu, John Williams, and Paul Aarseth.
P03-1002
In recent work, a number of researchers have cast this problem as a tagging problem and have applied various supervised machine learning techniques to it (Gildea and Jurafsky (2000, 2002); Blaheta and Charniak (2000); Gildea and Palmer (2002); Surdeanu et al.(2003); Gildea and Hockenmaier (2003); Chen and Rambow (2003); Fleischman and Hovy (2003); Hacioglu and Ward (2003); Thompson et al.(2003); Pradhan et al.(2003)). In this This research was partially supported by the ARDA AQUAINT program via contract OCG4423B and by the NSF via grant IS-9978025 paper, we report on a series of experiments exploring this approach.
A00-2031 J02-3001 N03-2008 N03-2009 P00-1065 P02-1031 P03-1002 W03-1006 W03-1008
[Fleischman and Hovy2003] Michael Fleischman and Eduard Hovy.
N03-2008
G&P system estimates the posterior probabilities using several different feature sets and interpolate the estimates, while Surdeanu et al.(2003) use a decision tree classifier.
P03-1002
For the initial experiments, we adopted the approach described by Gildea and Jurafsky (2002) (G&J) and evaluated a series of modifications to improve its performance.
J02-3001 P02-1031
[Marcus et al.1994] Mitchell Marcus, Grace Kim, Mary Ann Marcinkiewicz, Robert MacIntyre, Ann Bies, Mark Ferguson, Karen Katz, and Britta Schasberger.
H94-1020
The Gildea and Hockenmaier (G&H) System The Gildea and Hockenmaier (2003) system uses features extracted from Combinatory Categorial Grammar (CCG) corresponding to the features that were used by G&J and G&P systems.
W03-1008
[Gildea and Palmer2002] Daniel Gildea and Martha Palmer.
J02-3001 P02-1031
The Surdeanu et al.System. Surdeanu et al.(2003) report results on two systems using a decision tree classifier.
P03-1002
2. Head Word POS – Surdeanu et al.(2003) showed that using the part of speech (POS) of the head word gave a significant performance boost to their system.
P03-1002
[Kudo and Matsumoto2001] Taku Kudo and Yuji Matsumoto.
N01-1025
Annotation and Corpora We will be reporting on results using PropBank1 (Kingsbury et al., 2002), a 300k-word corpus in which predicate argument relations are marked for part of the verbs in the Wall Street Journal (WSJ) part of the Penn TreeBank (Marcus et al., 1994).
H94-1020
[Chen and Rambow2003] John Chen and Owen Rambow.
W03-1006
[Hacioglu and Ward2003] Kadri Hacioglu and Wayne Ward.
N03-2009
For our experiments, we used TinySVM2 along with YamCha3 (Kudo and Matsumoto, 2000) (Kudo and Matsumoto, 2001) as the SVM training and test software.
N01-1025 W00-0730
The clustering algorithm uses a database of verb-direct-object relations extracted by Lin (1998).
P98-2127
Classifier Accuracy (%) SVM 88 Decision Tree (Surdeanu et al., 2003) 79 Gildea and Palmer (2002) 77 Table 11: Argument classification using same features but different classifiers.
J02-3001 P02-1031 P03-1002
[Kudo and Matsumoto2000] Taku Kudo and Yuji Matsumoto.
W00-0730
LDC2002t31. [Lin1998] Dekang Lin.
P98-2127
The Gildea and Palmer (2002) system uses the same features and the same classification mechanism used by G&J.
J02-3001 P02-1031
1. Named Entities in Constituents – Following Surdeanu et al.(2003), we tagged 7 named entities (PERSON, ORGANIZATION, LOCATION, PERCENT, MONEY, TIME, DATE) using IdentiFinder (Bikel et al., 1999) and added them as 7 binary features.
P03-1002
[Hacioglu et al.2003] Kadri Hacioglu, Sameer Pradhan, Wayne Ward, James Martin, and Dan Jurafsky.
N03-2009
and Implementation We formulate the parsing problem as a multi-class classification problem and use a Support Vector Machine (SVM) classifier (Hacioglu et al., 2003; Pradhan et al, 2003).
N03-2009
[Gildea and Jurafsky2002] Daniel Gildea and Daniel Jurafsky.
J02-3001 P02-1031
To evaluate this scenario, we used the Charniak parser (Chaniak, 2001) to generate parses for PropBank training and test data.
P01-1017
[Gildea and Jurafsky2000] Daniel Gildea and Daniel Jurafsky.
P00-1065
Martin Center for Spoken Language Research, University of Colorado, Boulder, CO 80303 fspradhan,whw,hacioglu,marting@cslr.colorado.edu Dan Jurafsky Department of Linguistics Stanford University Stanford, CA 94305 jurafsky@stanford.edu Abstract In this paper, we propose a machine learning algorithm for shallow semantic parsing, extending the work of Gildea and Jurafsky (2002), Surdeanu et al.(2003) and others.
J02-3001 P02-1031 P03-1002 W03-1008
