In the training phase, this model considers which of the preceding/subsequent morphemes constitute one named entity together with the morpheme at the current position (Sassano and Utsuro, 2000).
C00-2102
Entity Chunking We first provide our definition of the task of Japanese named entity chunking (Sekine et al., 1998; Borthwick et al., 1998; Uchimoto et al., 2000).
P00-1042 W98-1118 W98-1120
281-288. Proceedings of the Conference on Empirical Methods in Natural combining outputs of classifiers at the first stage (van Halteren et al., 1998; Brill and Wu, 1998; Tjong Kim Sang, 2000).
A00-2007 P98-1029 P98-1081
Previously studied techniques for collecting such systems include: i) using several existing real systems (van Halteren et al., 1998; Brill and Wu, 1998; Henderson and Brill, 1999; Tjong Kim Sang, 2000), ii) bagging/boosting techniques (Henderson and Brill, 1999; Henderson and Brill, 2000), and iii) switching the data expression and obtaining several models (Tjong Kim Sang, 2000).
A00-2005 A00-2007 P98-1029 P98-1081 W99-0623
Following Uchimoto et al.(2000), feature functions for morphemes at the current position as well as the surrounding contexts are defined.
P00-1042
Actually, in the experimental evaluation, we show that the results of combining the best performing model of Uchimoto et al.(2000) with the one which performs poorly but extracts named entities quite different from those of the best performing model can help improve the performance of the best model.
P00-1042
Experimental evaluation showed that the proposed method achieved improvement in F-measure over the best known results with an ME model (Uchimoto et al., 2000), when a complementary model extracted named entities quite differently from the best performing model.
P00-1042
As the base model for supervised learning of Japanese named entity chunking, we employ a model based on the maximum entropy model (Uchimoto et al., 2000), which performed the best in IREX (Information Retrieval and Extraction Exercise) Workshop (IREX Committee, 1999) among those based on machine learning techniques.
P00-1042
Uchimoto et al.(2000) reported that the optimal number of preceding/subsequent contexts to be incorporated in the model is two morphemes to both left and right from the current position.
P00-1042
As for the number of preceding/subsequent morphemes as contextual clues, we consider the following models: 1 Minor modifications from those of Uchimoto et al.(2000) are: i) we used character types of morphemes because they are known to be useful in the Japanese named entity chunking, and ii) the sets of parts-of-speech tags are different.
P00-1042
2. Combine the outputs of the several systems: previously studied techniques include: i) voting techniques (van Halteren et al., 1998; Tjong Kim Sang, 2000; Henderson and Brill, 1999; Henderson and Brill, 2000), ii) switching among several systems according to confidence values they provide (Henderson and Brill, 1999), iii) stacking techniques (Wolpert, 1992) which train a second stage classifier for Association for Computational Linguistics.
A00-2005 A00-2007 P98-1081 W99-0623
p λ (y | x)= exp parenleftBig summationdisplay i λ i f i (x, y) parenrightBig summationdisplay y exp parenleftBig summationdisplay i λ i f i (x, y) parenrightBig Uchimoto et al.(2000) defines the context x as the patterns of surrounding morphemes as well as that at the current position, and the output y as the named entity chunking state to be assigned to the morpheme at the current position.
P00-1042
Both in (Uchimoto et al., 2000) and in this paper, this is the model which performs the best among all the individual models without system combination.
P00-1042
F =        any subset of braceleftBig mlength=···, NEtag=···,POS=··· bracerightBig braceleftBig class sys =“no outputs” bracerightBig In the training and testing phases, within each segment SegEv j of event expression, a class is assigned to each system, where each class class i sys for the i-th system is represented as a list of the classes of the named entities output by the system: class i sys = braceleftbigg +/−, ..., +/− “no output” (i =1,...,n) 3.4 Learning Algorithm We apply a simple decision list learning method to the task of learning a classifier for combining outputs of named entity chunkers 4 . A decision list (Yarowsky, 1994) is a sorted list of decision rules, each of which decides the value of class given some features f of an event.
P94-1013
Entity Chunking States Uchimoto et al.(2000) classifies classes of named entity chunking states into the following 40 tags: • Each of eight named entity types plus an “OPTIONAL” type are divided into four chunking states, namely, the beginning/middle/end of an named entity, or an named entity consisting of a single morpheme.
P00-1042
In the recent corpus-based NLP research, system combination techniques have been successfully applied to several tasks such as parts-of-speech tagging (van Halteren et al., 1998), base noun phrase chunking (Tjong Kim Sang, 2000), and parsing (Henderson and Brill, 1999; Henderson and Brill, 2000).
A00-2005 A00-2007 P98-1081 W99-0623
