A similar architecture has been adopted by (Wang and Harper, 2004) who train an n-best supertagger and an attachment predictor on the Penn Treebank and obtain an labelled F-score of 92.4%, thus slightly outperforming the results of (Collins, 1999) who obtained 92.0% on the same sentences, but evaluating on transformed phrase structure trees instead on directly computed dependency relations.
W04-0307
(Hagenstr¨om and Foth, 2002) show that the TnT tagger (Brants, 2000) can be profitably integrated into WCDG parsing: A constraint that prefers analyses which conform to TnT’s category predictions can greatly reduce the number of spurious readings of lexically ambiguous words.
A00-1031
can be automatically extracted from large corpora of trees or even raw text: prepositions that tend to occur in the vicinity of specific nouns or verbs more often than chance would suggest can be assumed to modify those words preferentially (Volk, 2002).
C02-1004
Stochastic parsers for English trained on the Penn Treebank have peaked their performance around 90% (Charniak, 2000).
A00-2018
Supertags have been successfully applied to guide parsing in symbolic frameworks such as Lexicalised Tree-Adjoning grammar (Bangalore and Joshi, 1999).
J99-2004
When used to predict the probability of the possible regents of each preposition in each sentence, it achieved an accuracy of 79.4% and 78.3%, respectively (see (Foth and Menzel, 2006) for details).
P06-1037 P06-2029
An architecture which fulfills this requirement is Weighted Constraint Dependency Grammar, which was based on a model originally proposed by Maruyama (1990) and later extended with weights (Schr¨oder, 2002).
P90-1005
Therefore, external evidence is either used to restrict the space of possibilities for a subsequent component (Clark and Curran, 2004) or to choose among the alternative results which a traditional rule-based parser usually delivers (Malouf and van Noord, 2004).
C04-1041
Here the state of the art for German is defined by a system which applies treebank transformations to the original NEGRA treebank and extends a Collins-style parser with a suffix analysis (Dubey, 2005).
P05-1039
Similar to our approach, the result of (Wang and Harper, 2004) was achieved by integrating the evidence of two (stochastic) components into a single decision procedure on the optimal interpretation.
W04-0307
Dubey (2005) reported how serious this problem can be when he coupled a tagger with a subsequent parser, and noted that tagging errors are by far the most important source of parsing errors.
P05-1039
Considering that a detailed supertag corresponds to several distinct predictions (about label, direction etc.), it might be more appropriate to measure the average accuracy of these distinct predictions; by this measure, the individual predictions of the supertagger are 84.5% accurate; see (Foth et al., 2006) for details.
P06-1037 P06-2029
Among the available predictor components which could be integrated into the parser additionally, the approach of (McDonald et al., 2005) certainly looks most promising.
H05-1066
Most successful for many of the 13 different languages has been the system described in (McDonald et al., 2005).
H05-1066
