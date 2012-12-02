Most of the approaches for relation extraction rely on the mapping of syntactic dependencies, such as SVO, onto semantic relations, using either pattern matching or other strategies, such as probabilistic parsing for trees augmented with annotations for entities and relations (Miller et al, 2000), or clustering of semantically similar syntactic dependencies, according to their selectional restrictions (Gamallo et al., 2002).
A00-2030
(Roth and Yih, 2002), e.g., use probabilistic classifiers with constraints induced between relations and entities, such as selectional restrictions.
C02-1151
In our architecture, when the RSS finds more than one possible relation, we choose one relation by using the word sense disambiguation (WSD) system SenseLearner (Mihalcea and Csomai, 2005).
P05-3014
We use Minipar (Lin, 1993), which produces functional relations for the components in a sentence, including subject and object relations with respect to a verb.
P93-1016
These are used as a starting point to bootstrap the pattern learning process, by means of semantic similarity measures (Yangarber, 2000; Stevenson, 2004).
A00-1039
The linguistic component uses the infrastructure and the following resources from GATE (Cunningham et al., 2002): tokenizer, sentence splitter, part-of-speech tagger, morphological analyzer and VP chunker.
P02-1022
Also using kernel methods and support vector machines, (Zhao and Grishman, 2005) combine clues from different levels of syntactic information and applies composite kernels to integrate the individual kernels.
P05-1052
