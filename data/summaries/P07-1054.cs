3.2 eXtended WordNet The transformation of WordNet into a graph based on the trianglerightsld relation would of course be nontrivial, but is luckily provided by eXtended WordNet (Harabagiu et al., 1999), a publicly available version of WordNet in which (among other things) each term sk occurring in a WordNet gloss (except those in example phrases) is lemmatized and mapped to the synset in which it belongs2.
W99-0501
Esuli and Sebastiani (2005; 2006a) determine the ORPs of generic terms by learning, in a semi-supervised way, a binary term classifier from a set of training terms that have been given vectorial representations by indexing their WordNet glosses.
E06-1025
WordNet synsets by PageRank 3.1 The PageRank algorithm Let G =〈N,L〉be a directed graph, with N its set of nodes and L its set of directed links; let W0 be 1Andreevskaia and Berger (2006a) also work on term senses, rather than terms, but they evaluate their work on terms only.
E06-1027
Some authors go a step further and attach these properties not to terms but to term senses (typically: WordNet synsets), on the assumption that different senses of the same term may have different opinion-related properties (Andreevskaia and Bergler, 2006a; Esuli and Sebastiani, 2006b; Ide, 2006; Wiebe and Mihalcea, 2006).
E06-1025 E06-1027 P06-1134
Hatzivassiloglou and McKeown (1997) determine the polarity of adjectives by mining pairs of conjoined adjectives from text, and observing that conjunctions such as and tend to conjoin adjectives of the same polarity while conjunctions such as but tend to conjoin adjectives of opposite polarity.
P97-1023
Andreevskaia and Berger (2006a) extend a set of terms of known positivity/negativity by adding to them all the terms whose glosses contain them; this algorithm does not view glosses as a source for a graph of terms, and is based on a different intuition than ours.
E06-1027
The same authors later extend their work to determining the ORPs of WordNet synsets (Esuli and Sebastiani, 2006b).
E06-1025
Some recent works have tackled the attribution of opinion-related properties to word senses or synsets (Ide, 2006; Wiebe and Mihalcea, 2006)1; however, they do not use glosses in any significant way, and are thus very different from our method.
P06-1134
We obtain the data of the trianglerightsld relation from eXtended WordNet (Harabagiu et al., 1999), an automatically sense-disambiguated version of WordNet in which every term occurrence in every gloss is linked to the synset it is deemed to belong to.
W99-0501
While many works (Esuli and Sebastiani, 2005; Hatzivassiloglou and McKeown, 1997; Kamps et al., 2004; Takamura et al., 2005; Turney and Littman, 2003) view the properties of positivity and negativity as categorical (i.e., a term is either positive or it is not), others (Andreevskaia and Bergler, 2006b; Grefenstette et al., 2006; Kim and Hovy, 2004; Subasic and Huettner, 2001) view them as graded (i.e., a term may be positive to a certain degree), with the underlying interpretation varying from fuzzy to probabilistic.
C04-1200 E06-1027 P97-1023
We have also tested a more complex version of e, with ei scores obtained from release 1.0 of SentiWordNet (Esuli and Sebastiani, 2006b)5.
E06-1025
Kim and Hovy (2004) determine the polarity of generic terms by means of two alternative learning-free methods that use two sets of seed terms of known positivity and negativity, and are based on the frequency with which synonyms of the target term also appear in the respective seed sets.
C04-1200
