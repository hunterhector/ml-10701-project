However, Zhou and Su (2002) have reported state of the art results on the MUC-6 and MUC-7 data using a HMM-based tagger.
P02-1060
The tagger uses a Gaussian prior over the weights (Chen et al., 1999) which allows a large number of rare, but informative, features to be used without overfitting.
E99-1025
ME Tagger The ME tagger is based on Ratnaparkhi (1996)’s POS tagger and is described in Curran and Clark (2003). The tagger uses models of the form: p(y|x) = 1Z(x) exp parenleftBigg nsummationdisplay i=1 λifi(x,y) parenrightBigg (1) where y is the tag, x is the context and the fi(x,y) are the features with associated weights λi.
E03-1071 W96-0213
Malouf (2002)) records the NE tag that was most recently assigned to the current word.
W02-2019
Malouf (2002), Burger et al.(2002)) reported results significantly lower than the best system (Carreras et al., 2002).
W02-2003 W02-2004 W02-2019
Feature Set Table 1 lists the contextual predicates used in our baseline system, which are based on those used in the Curran and Clark (2003) CCG supertagger.
E03-1071
Condition Contextual predicate freq(wi) < 5 X is prefix of wi, |X| ≤ 4 X is suffix of wi, |X| ≤ 4 wi contains a digit wi contains uppercase character wi contains a hyphen ∀wi wi = X wi−1 = X, wi−2 = X wi+1 = X, wi+2 = X ∀wi POSi = X POSi−1 = X, POSi−2 = X POSi+1 = X, POSi+2 = X ∀wi NEi−1 = X NEi−2NEi−1 = XY Table 1: Contextual predicates in baseline system 3 The Data We used three data sets: the English and German data for the CoNLL-2003 shared task (Tjong Kim Sang and De Meulder, 2003) and the Dutch data for the CoNLL2002 shared task (Tjong Kim Sang, 2002).
W02-2024 W03-0419
The frequency counts have been obtained from 1 billion words of English newspaper text collected by Curran and Osborne (2002).
W02-2008
Malouf (2002)) whilst others gained significant improvement using gazetteers and triggers (e.g.
W02-2019
Zhou and Su (2002) used a wide variety of features, which suggests that the relatively poor performance of the taggers used in CoNLL-2002 was largely due to the feature sets used rather than the machine learning method.
P02-1060
Carreras et al.(2002)). Our system incorporates only English and Dutch first name and last name gazetteers as shown in Table 6.
W02-2004
Collins (2002) includes a number of interesting contextual predicates for NER.
P02-1062
Collins (2002) also describes a mapping from words to word types which groups words with similar orthographic forms into classes.
P02-1062
These improve upon the scores of the best performing system at CoNLL-2002 (Carreras et al., 2002).
W02-2004
Tsukamoto et al.(2002)) encode the most probable tag for the next words in the window.
W02-2031
Using a wider context window than 2 words may improve performance; a reranking phase using global features may also improve performance (Collins, 2002).
P02-1062
The additional orthographic features have proved useful in other systems, for example Carreras et al.(2002), Borthwick (1999) and Zhou and Su (2002).
P02-1060 W02-2004
