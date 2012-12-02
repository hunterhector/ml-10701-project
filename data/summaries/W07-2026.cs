In 10-fold crossvalidation with this data we achieved an average fscore of 70.6, based on features similar to the subset trees used for semantic role labeling in (Moschitti 2004).
P04-1043
As described earlier, the reference answer facets are roughly extracted from the relations in a syntactic dependency parse (c.f., Nivre and Scholz, 2004) and a shallow semantic parse (Gildea and Jurafsky, 2002).
J02-3001
Scores were calculated using the srl-eval.pl script from the CoNLL-2005 scoring package (Carreras and M`arquez, 2005).
W05-0620
In the original formulation for English in Gildea and Jurafsky (2002), it answers the question: Is the NP governed by IP or VP?
J02-3001
"the international Olympic Conference held in Paris" Figure 1 Example of DE construction Since the governing category information is encoded in the path feature, it may be redundant; indeed this redundancy might explain why the governing category feature was used in Gildea & Jurafsky(2002) but not in Gildea and Palmer(2002).
J02-3001
Such models have already been investigated in (Pradhan et al., 2003; Moschitti et al., 2005) and their description is hereafter reported.
W05-0630
With the advent of faster and powerful computers, more effective machine learning algorithms, and importantly, large data resources annotated with relevant levels of semantic information FrameNet (Baker et al., 1998) andProbBankcorpora (Palmer et al., 2005), we are seeing a surge in efficient approaches to SRL (Carreras and M`arquez, 2005).
W05-0620
This approach has been applied to problems like compound noun interpretation (Rosario and Hearst 2001) and semantic role labeling (Gildea and Jurafsky 2002).
J02-3001
parse trees as in (Moschitti, 2004)) would be more successful.
P04-1043
Traditionally, SRL systems have been trained on either the PropBank corpus (Palmer et al., 2005) ??for two years, the CoNLL workshop (Carreras and M`arquez, 2004; Carreras and M`arquez, 2005) has made this their shared task, or the FrameNet corpus ??Senseval-3 used this for their shared task (Litkowski, 2004).
W05-0620
For example, Gildea and Jurafsky (2002) found that identifying passives was important in training a semantic role classifier from FrameNet, using a parser trained on the Penn Treebank along with a set of templates to distinguish passive constructions from active ones.
J02-3001
Another important thread of investigation concerning preposition behavior is the task of semantic role (and perhaps semantic relation) labeling (Gildea & Jurafsky, 2002).
J02-3001
increase [from $50] to $100) temporal topic 3 Semantic Parsing 3.1 Architecture and Classifier Following the architecture of earlier semantic parsers like Gildea and Jurafsky (2002), we treat the semantic parsing task as a 1-of-N classification problem.
J02-3001
System Results Our system is evaluated using the official CoNLL evaluator (Carreras and M`arquez, 2005), available at http://www.lsi.upc.es/?srlconll/ soft.html.
W05-0620
This choice is justified by previous studies (Moschitti et al., 2005) showing that for lower nodes, the role classification is generally more accurate than for upper ones; ??if only two nodes are involved, i.e. they dominate each other, then keep the one with the higher SVM classification score.
W05-0630
Among them, we select the following subset: (a) Phrase Type, Predicate Word, Head Word, 134 Position and Voice as defined in (Gildea and Jurafsky, 2002); (b) Partial Path, No Direction Path, Head Word POS, First and Last Word/POS in Constituent and SubCategorization as proposed in (Pradhan et al., 2003); and (c) Syntactic Frame as designed in (Xue and Palmer, 2004).
J02-3001 W04-3212
The final labeling accuracy that we derive using the official CoNLL evaluator (Carreras and M`arquez, 2005) along with the official development and test data ofSEMEVALprovides a reliable assessment of the accuracy achievable by our SRL model.
W05-0620
Text is automatically annotated, using the SVMTool (Gimenez and M`arquez, 2004), Freeling (Carreras et al., 2004), and Phreco (Carreras et al., 2005) packages.
W05-0620
PoS-tagging and lemmatization are provided by the SVMTool package (Gimenez and M`arquez, 2004), and base phrase chunking is provided by the Phreco software (Carreras et al., 2005).
W05-0620
As can be seen in 2b and 2c, the dependencies are augmented by thematic roles (Kipper et al., 2000) (e.g., Agent, Theme, Cause, Instrument?? produced by a semantic role labeling system (c.f., Gildea and Jurafsky, 2002).
J02-3001
(Gildea and Jurafsky, 2002; Xue and Palmer, 2004; Pradhan et al., 2003).
J02-3001 W04-3212
The systems for the other languages follow the successful models devised for English, (Gildea and Jurafsky, 2002; 95 Xue and Palmer, 2004; Pradhan et al., 2003).
J02-3001 W04-3212
For evaluation we use the official CoNLL evaluator (Carreras and M`arquez, 2005).
W05-0620
Finally, we would like to experiment with more sophisticated kernels, the tree kernels described in (Moschitti, 2004), i.e. models that have shown a lot of promise for the English SRL process.
P04-1043
Nevertheless, we do see some headway for other languages, such as German and Chinese (Erk and Pado, 2006; Sun and Jurafsky, 2004; Xue and Palmer, 2005).
N04-1032
This task has been the subject of a previous Senseval task (Automatic Semantic Role Labeling, Litkowski (2004)) and two shared tasks on semantic role labeling in the Conference on Natural Language Learning (Carreras & Marquez (2004) and Carreras & Marquez (2005)).
W05-0620
