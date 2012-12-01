This paper describes a refinement of an existing all-words WSD system for Dutch (Hoste et al., 2002b) that is an ensemble of word experts, each specialised in disambiguating the senses for one particular ambiguous wordform.
W02-0814
As compared to an earlier version, built on data made available to the SENSEVAL-2 competition, we have made manual corrections in the annotations of the data, and on the corrected data we have additionally cross-validated the amount of local context, which in previous work had been left arbitrarily constant at three left and right neighbouring words and their POS tags (Hendrickx and van den Bosch, 2002; Hoste et al., 2002b).
W02-0809 W02-0814
POS tags of the focus word itself are also included, to aid sense disambiguations related to syntactic differences (Stevenson and Wilks, 2001).
J01-3001
keyword features), since a post-SENSEVAL-2 study described in (Hoste et al., 2002b) indicated that for the Dutch data, WSD on local context, the immediate three left and right neighbouring words of the ambiguous words, yielded the best performance among all variants tested.
W02-0814
In a previous experiment (Hoste et al., 2002b) it was shown that building word experts for words that occur at least ten times in the training data, yield the best results.
W02-0814
Also, the automatic feature weighting in the similarity metric of a memory-based learner makes the approach well-suited for domains with large numbers of features from heterogeneous sources, as it embodies a smoothing-by-similarity method when data is sparse (Zavrel and Daelemans, 1997).
P97-1056
To make a comparison between the results on the old version of the data and the new version, we have conducted an experiment on the new data, using the same cross-validation procedure as we have used in (Hendrickx and van den Bosch, 2002) which led to a score of 84.3% on the test set.
W02-0809
Subsequently, cross-validation experiments were performed to optimize the amount of local context around the ambiguous word, which had been set arbitrarily constant in previous studies (Veenstra et al., 2000; Hendrickx and van den Bosch, 2002; Hoste et al., 2002a).
W02-0809 W02-0814
Our approach to memory-based all-words WSD follows the memorybased approach of (Ng and Lee, 1996), and the work by (Veenstra et al., 2000) on a memorybased approach to the English lexical sample task of SENSEVAL-1.
P96-1006
A previous study, described in (Hoste et al., 2002b) showed that MBWSD-D trained only on local features, has a better performance on the test set than all other variants that use keyword information.
W02-0814
The keywords were selected through a selection method suggested by (Ng and Lee, 1996) within three sentences around the ambiguous word; only content words were used as candidates.
P96-1006
As we have done these exeriments on a cleaned version of the data, the results described so far cannot be compared to the results described in (Hendrickx and van den Bosch, 2002), which were obtained on the previous version of the data and with different parameter optimalisations.
W02-0809
(Hendrickx and van den Bosch, 2002)).
W02-0809
