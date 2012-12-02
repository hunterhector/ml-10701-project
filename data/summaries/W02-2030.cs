Decision trees have been applied for feature selection for statistical parsing models by Magerman (1995) and Haruno et al.(1998). Another example of automatic feature selection for parsing is in the context of a deterministic parsing model that chooses parse actions based on automatically induced decision structures over a very rich feature set (Hermjakob and Mooney, 1997).
P95-1037 P97-1062 P98-1083
Stochastic Unification Based Grammars (Johnson et al., 1999; Riezler et al., 2000).
P00-1061 P99-1069
This model is very similar to the markovized rule models in Collins (1997).
P97-1003
This paper presents work on the problem of probabilistic parse selection from among a set of alternatives licensed by a hand-built grammar in the context of the newly developed Redwoods HPSG treebank (Oepen et al., 2002).
C02-2025
of the Treebank and Features Used The Redwoods treebank (Oepen et al., 2002) is an under-construction treebank of sentences corresponding to a particular HPSG grammar, the LinGO ERG (Flickinger, 2000).
C02-2025
For a sentence s with possible analyses t1;:::;tk, the conditional probability for analysis ti is given by: P(tijs) = exp ‡Pm j=1 fj(ti)‚j · Pk i0=1 exp ‡Pm j=1 fj(ti0)‚j · (1) As in Johnson et al.(1999) we trained the model by maximizing the conditional likelihood of the preferred analyses and using a Gaussian prior for smoothing (Chen and Rosenfeld, 1999).
P99-1069
Haruno et al.(1998) have experimented with boosting decision trees, reporting significant gains.
P98-1083
This is a similar, but more limited, strategy to the one used by Magerman (1995).
P95-1037
Grandparent annotation was used previously by Charniak and Carroll (1994) and Johnson (1998).
J98-4004
These are much finer grained than Penn Treebank preterminals tags, and more akin to those used in TreeAdjoining Grammar models (Bangalore and Joshi, 1999).
J99-2004
The Redwoods treebank provides deeper semantics expressed in the Minimum Recursion Semantics formalism (Copestake et al., 2001), but in the present experiments we have not explored this fully.
P01-1019
However, an upper bound for such an approach for our corpus is below 55 percent parse selection accuracy, which is the accuracy of an oracle tagger that chooses at random among the parses having the correct tag sequence (Oepen et al., 2002).
C02-2025
In most recent parsing work the history consists of a small number of manually selected features (Charniak, 1997; Collins, 1997).
P97-1003
( (Johnson et al., 1999) add features measuring parallelism).
P99-1069
Magerman. 1995.
P95-1037
