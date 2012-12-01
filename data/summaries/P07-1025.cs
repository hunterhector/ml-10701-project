Parse tree paths were used for semantic role labeling by Gildea and Jurafsky (2002) as descriptive features of the syntactic relationship between predicates and their arguments in the parse tree of a sentence.
J02-3001
Semantic Role Annotations A recent release of the PropBank (Palmer et al., 2005) corpus of semantic role annotations of Treebank parses contained 112,917 labeled instances of 4,250 rolesets corresponding to 3,257 verbs, as illustrated by this example for the verb buy.
J05-1004
Annotations similar to these have been used to create automated semantic role labeling systems (Pradhan et al., 2005; Moschitti et al., 2006) for use in natural language processing applications that require only shallow semantic parsing.
P05-1072 W06-2909
Our work suggests that feature generalization based on verb-similarity may compliment approaches to generalization based on role-similarity (Gildea and Jurafsky, 2002; Baldewein et al., 2004).
J02-3001 W04-0817
FrameNet (Baker et al., 1998).
P98-1013
Using the first 120 surrogate training examples and our simple semantic role labeling approach, we would expect F-scores that are above 0.5, and that using the first 700 would yield F-scores around 0.6. 7 Discussion The overall performance of our semantic role labeling approach is not competitive with leading contemporary systems, which typically employ support vector machine learning algorithms with syntactic features (Pradhan et al., 2005) or syntactic tree kernels (Moschitti et al., 2006).
P05-1072 W06-2909
Our approach is analogous to previous work in extracting collocations from large text corpora using syntactic information (Lin, 1998).
P98-2127
This observation further supports the distributional hypothesis of word similarity and corresponding technologies for identifying synonyms by similarity of lexical-syntactic context (Lin, 1998).
P98-2127
In future work, it would be particularly interesting to compare empiricallyderived verb clusters to verb classes derived from theoretical considerations (Levin, 1993), and to the automated verb classification techniques that use these classes (Joanis and Stevenson, 2003).
E03-1040
For this task we utilized the August 2005 release of the Charniak parser with the default speed/accuracy settings (Charniak, 2000), which required roughly 360 hours of processor time on a 2.5 GHz PowerPC G5.
A00-2018
To prepare this corpus for analysis, we extracted the body text from each of the 4.1 million entries in the corpus and applied a maximum-entropy algorithm to identify sentence boundaries (Reynar and Ratnaparkhi, 1997).
A97-1004
