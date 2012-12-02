Method Overlap Overlap IG ratio C4.5 Maximum Entropy Transformations Back-off model Late Closure Most Likely for each P percent 83.7 % 84.1% 79.7 % 77.7 % 81.9 % 84.1% 59.0 % 72.0 % correct Table 3: Scores on the Ratnaparkhi et al.PP-attachment test set (see text); the scores of Maximum Entropy are taken from Ratnaparkhi et al.(1994); the scores of Transformations and Back-off are taken from Collins & Brooks (1995).
H94-1048 W95-0103
The Dudani weighted k-nearest neighbor classifier (k=30) slightly outperforms Collins ~ Brooks' (1995) Back-Off model.
W95-0103
Their method bases attachment decisions on the ratio and Zavrcl, Daelemans ~4 Veenstra 136 Memory-Based PP Attachment Jakub Zavrel, Walter Daelemans and Jorn Veenstra (1997) Resolving PP attachment Ambiguities with Memory-Based Learning.
P97-1056
Brill and Resnik (1994) appl!ed Error-Driven TransformationBased Learning, Ratnaparkhi, Reynar and Roukos (1994) applied a Maximum Entropy model, Franz (1996) used a Loglinear model, and Collins and Brooks (1995) obtained good results using a BackOff model.
C94-2195 H94-1048 W95-0103
Collins and Brooks (1995) used a Back-Off model, which enables them to take low frequency effects into account on the Ratnaparkhi dataset (with good results).
W95-0103
But if we have information about feature relevance, we can add linguistic bias to weight or select different features (Cardie, 1996).
W96-0211
Ratnaparkhi, Reynar, and Roukos (1994) used a Maximum Entropy model and a decision tree on the dataset they extracted from the Wall Street Journal corpus.
H94-1048
The other methods for which results have been reported on this dataset include decision trees, Maximum Entropy (Ratnaparkhi, Reynar, and Roukos, 1994), and Error-Driven TransformationBased Learning (Brill and Resnik, 1994), 3 which were clearly outperformed by both IB1 and IBI-IG, even though e.g.
C94-2195 H94-1048
Hindle and Rooth (1993) were the first to show that a corpus-based approach to PP attachment ambiguity resolution can lead to good results.
J93-1005
It has been used in statistical disambiguation methods by Ratnaparkhi, Reynar, and Roukos (1994) and Collins and Brooks (1995); this allows a comparison of our models to the methods they tested.
H94-1048 W95-0103
The data consist of four-tuples of words, extracted from the Wall Street Journal Treebank (Marcus, Santorini, and Marcinkiewicz, 1993) by a group at IBM (Ratnaparkhi, Reynar, and Roukos, 1994).
H94-1048 J93-2004
Because language-processing tasks typically can only be described as a complex interaction of regularities, subregularities and (families of) exceptions, storing all empirical data as potentially useful in analogical extrapolation works better than extracting the main regularities and forgetting the individual examples (Daelemans, 1996).
C96-1018
In addition to the computational work, Ratnaparkhi, Reynar, and Roukos (1994) performed a study with three human subjects, all experienced treebank annotators, who were given a small random sample of the test sentences (either as fourtuples or as full sentences), and who had to give the same binary decision.
H94-1048
As we have argued in Zavrel and Daelemans (1997), this corresponds exactly to the behavior of the Back-Off algorithm of Collins and Brooks (1995), so that it comes as no surprise that the accuracy of both methods is the same.
P97-1056 W95-0103
Adding aThe results of Brill's method on the present benchmark were reconstructed by Collins and Brooks (1995).
W95-0103
In order to make a fair comparison, we evaluated our methods on the common benchmark dataset first used in Ratnaparkhi, Reynar, and Roukos (1994).
H94-1048
After the initial effort by Hindle and Rooth (1993), it has become clear that this area needs statistical methods in which an easy integration of many information sources is possible.
J93-1005
For an example of this type of unsupervised learning as a side-effect of supervised learning, see Daelemans, Berck, and Gillis (1996).
C96-1018
In Zavrel and Daelemans (1997) it is shown that Memory-Based and Back-Off type methods are closely related, which is mirrored in the performance levels.
P97-1056
Brill and Resnik (1994) applied Error-Driven Transformation-Based Learning to this task, using the verb, nounl, preposition, and noun2 features.
C94-2195
