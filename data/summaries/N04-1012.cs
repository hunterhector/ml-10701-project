parse selection As is now standard for feature-based grammars, we use log-linear models for parse selection (Johnson et al., 1999).
P99-1069
Although annotated corpora exist for HPSG, such corpora do not exist in significant volumes and are limited to a few small domains (Oepen et al., 2002).
C02-2025
3Hwa (2000) measured the number of constituents in a parse tree as another annotation cost.
W00-1306
a14 is the set of modelsa18 a36 a5a8a5a8a5a19a18 a49 . 4.1 Uncertainty sampling Uncertainty sampling (also called tree entropy by Hwa (2000)), measures the uncertainty of a model over the set of parses of a given sentence, based on the conditional distribution it assigns to them.
W00-1306
1We also discussed perceptron models in Baldridge and Osborne (2003); here, we keep the model class fixed to compare different AL methods.
W03-0403
Turning to parsing, most work has utilized uncertainty sampling (Thompson et al., 1999; Hwa, 2000; Tang et al., 2002).
P02-1016 W00-1306
The semantic interpretations are expressed using Minimal Recursion Semantics (MRS) (Copestake et al., 2001), which provides the means to represent interpretations with a flat, underspecified semantics using terms of the predicate calculus and generalized quantifiers.
P01-1019
The ngram set, described by Baldridge and Osborne (2003), also uses derivation trees; however, it uses a linearized representation of trees to create ngrams over the tree nodes.
W03-0403
Baldridge and Osborne (2003) also applied AL to Redwoods.
W03-0403
A radically simpler way of determining the potential informativity of an example is simply to consider the absolute probability of the most highly 4We experimented with Kullback-Leibler divergence to the mean (Pereira et al., 1993; McCallum and Nigam, 1998), but it performed no better than the simpler vote entropy metric.
P93-1024
To overcome this limitation for the HPSG English Resource Grammar (ERG, Flickinger (2000)), the Redwoods treebank has been created to provide annotated training material (Oepen et al., 2002).
C02-2025
Results have also been presented for versions 1 (Baldridge and Osborne, 2003) and 1.5 (Oepen et al., 2002; Toutanova et al., 2003), both of which have considerably less ambiguity than version 3.
C02-2025 W03-0403
Although we have not measured the cognitive burden on humans, we strongly believe that simply selecting the best parse is far more efficient than drawing the best parse for some sentence (as exemplified by Hwa (2000)).
W00-1306
We use the limited memory variable metric algorithm (Malouf, 2002) to determine the weights.
W02-2018
Unit cost is commonly used in AL research (Tang et al., 2002), but discriminant cost is more fine-grained.3 Discriminant cost works as follows.
P02-1016
