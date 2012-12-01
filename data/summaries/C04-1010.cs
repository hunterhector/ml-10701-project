These settings are the result of extensive experiments partially reported in Nivre et al.(2004). For more information about the different parameters and settings, see Daelemans et al.(2003). 4 Experiments The data set used for experimental evaluation is the standard data set from the Wall Street Journal section of the Penn Treebank, with sections 2–21 3Given the parsing algorithm, N can never have a head or a right dependent in the current configuration.
W04-2407
(All differences are significant beyond the .01 level; McNemar’s test.) Table 2 shows the dependency accuracy, root accuracy and complete match scores for our best parser (Model 2 with label set B) in comparison with Collins (1997) (Model 3), Charniak (2000), and Yamada and Matsumoto (2003).5 It is clear that, with respect to unlabeled accuracy, our parser does not quite reach state-of-the-art performance, even if we limit the competition to deterministic methods such as that of Yamada and Matsumoto (2003).
A00-2018 P97-1003
This permits us to make exact comparisons with the parser of Yamada and Matsumoto (2003), but also the parsers of Collins (1997) and Charniak (2000), which are evaluated on the same data set in Yamada and Matsumoto (2003).
A00-2018 P97-1003
Moreover, the deterministic dependency parser of Yamada and Matsumoto (2003), when trained on the Penn Treebank, gives a dependency accuracy that is almost as good as that of Collins (1997) and Charniak (2000).
A00-2018 P97-1003
In this way, our approach can be seen as a form of history-based parsing (Black et al., 1992; Magerman, 1995).
H92-1026 P95-1037
Previous work on memory-based learning for deterministic parsing includes Veenstra and Daelemans (2000) and Nivre et al.(2004). For the experiments reported in this paper, we have used the software package TiMBL (Tilburg Memory Based Learner), which provides a variety of metrics, algorithms, and extra functions on top of the classical k nearest neighbor classification kernel, such as value distance metrics and distance weighted class voting (Daelemans et al., 2003).
W04-2407
This is different from the original IB1 algorithm, as described in Aha et al.(1991). used for training and section 23 for testing (Collins, 1999; Charniak, 2000).
A00-2018 P99-1065
Indirect support for this assumption can be gained from previous experiments with Swedish data, where almost the same accuracy (85% unlabeled attachment score) has been achieved with a treebank which is much smaller but which contains proper dependency annotation (Nivre et al., 2004).
W04-2407
For the larger B set, our best parser achieves an F-measure of 96.9% (DEP labels included), which can be compared with 97.0% for a similar (but larger) set of labels in Collins (1999).6 Although none of the previous results on labeling accuracy is strictly comparable to ours, it nevertheless seems fair to conclude that the 6This F-measure is based on the recall and precision figures reported in Figure 7.15 in Collins (1999).
P99-1065
We are grateful to Yamada and Matsumoto for letting us use their rule set, which is a slight modification of the rules used by Collins (1999).
P99-1065
(For the The a7 a4 a63 DEP finger-pointing a7 a4 a63 NP-SBJ has already a7 a4 a63 ADVP begun a7 a4 a63 VP. a63 a7 a4DEP Figure 1: Dependency graph for English sentence unlabeled dependency parser of Yamada and Matsumoto (2003) the classification problem only involves three classes.) The parsing methodology investigated here has previously been applied to Swedish, where promising results were obtained with a relatively small treebank (approximately 5000 sentences for training), resulting in an attachment score of 84.7% and a labeled accuracy of 80.6% (Nivre et al., 2004).1 However, since there are no comparable results available for Swedish, it is difficult to assess the significance of these findings, which is one of the reasons why we want to apply the method to a benchmark corpus such as the the Penn Treebank, even though the annotation in this corpus is not ideal for labeled dependency parsing.
W04-2407
Unlabeled attachment score (UAS): The proportion of words that are assigned the correct head (or no head if the word is a root) (Eisner, 1996; Collins et al., 1999).
C96-1058 P99-1065
To some extent, this can probably be explained by the strong tradition of constituent analysis in Anglo-American linguistics, but this trend has been reinforced by the fact that the major treebank of American English, the Penn Treebank (Marcus et al., 1993), is annotated primarily with constituent analysis.
J93-2004
On the other hand, the best available parsers trained on the Penn Treebank, those of Collins (1997) and Charniak (2000), use statistical models for disambiguation that make crucial use of dependency relations.
A00-2018 P97-1003
The data has been converted to dependency trees using head rules (Magerman, 1995; Collins, 1996).
P95-1037 P96-1025
The parsing algorithm used here was first defined for unlabeled dependency parsing in Nivre (2003) and subsequently extended to labeled graphs in Nivre et al.(2004). Parser configurations are represented by triples 〈S,I,A〉, where S is the stack (represented as a list), I is the list of (remaining) input tokens, and A is the (current) arc relation for the dependency graph.
W04-2407
In another study, Blaheta and Charniak (2000) report an F-measure of 98.9% for the assignment of Penn Treebank grammatical role labels (our G set) to phrases that were correctly parsed by the parser described in Charniak (2000).
A00-2018 A00-2031
2. Labeled attachment score (LAS): The proportion of words that are assigned the correct head and dependency type (or no head if the word is a root) (Nivre et al., 2004).
W04-2407
As far as we know, this makes it different from all previous systems for dependency parsing applied to the Penn Treebank (Eisner, 1996; Yamada and Matsumoto, 2003), although there are systems that extract labeled grammatical relations based on shallow parsing, e.g.
C96-1058
Models similar to model 2 have been found to work well for datasets with a rich annotation of dependency types, such as the Swedish dependency treebank derived from Einarsson (1976), where the extra part-of-speech features are largely redundant (Nivre et al., 2004).
W04-2407
Deterministic methods for dependency parsing have now been applied to a variety of languages, including Japanese (Kudo and Matsumoto, 2000), English (Yamada and Matsumoto, 2003), Turkish (Oflazer, 2003), and Swedish (Nivre et al., 2004).
J03-4001 W00-1303 W04-2407
