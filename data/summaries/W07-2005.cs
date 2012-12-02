Morpho-syntactic annotation of the English references and hypotheses is performed using the constraint grammar parser ENGCG (Voutilainen, 1995), and the Spanish texts are annotated using the FreeLing analyser (Carreras et al., 2004).
W04-2412
increase [from $50] to $100) temporal topic 3 Semantic Parsing 3.1 Architecture and Classifier Following the architecture of earlier semantic parsers like Gildea and Jurafsky (2002), we treat the semantic parsing task as a 1-of-N classification problem.
J02-3001
The data used in this task was developed in The Preposition Project (TPP, Litkowski & Hargraves (2005) and Litkowski & Hargraves (2006)),1 with further refinements to fit the requirements of a SemEval task.
W06-2106
As described earlier, the reference answer facets are roughly extracted from the relations in a syntactic dependency parse (c.f., Nivre and Scholz, 2004) and a shallow semantic parse (Gildea and Jurafsky, 2002).
J02-3001
For example, Gildea and Jurafsky (2002) found that identifying passives was important in training a semantic role classifier from FrameNet, using a parser trained on the Penn Treebank along with a set of templates to distinguish passive constructions from active ones.
J02-3001
Litkowski. 2004.
W04-0803
Another important thread of investigation concerning preposition behavior is the task of semantic role (and perhaps semantic relation) labeling (Gildea & Jurafsky, 2002).
J02-3001
Text is automatically annotated, using the SVMTool (Gimenez and M`arquez, 2004), Freeling (Carreras et al., 2004), and Phreco (Carreras et al., 2005) packages.
W04-2412 W05-0620
PoS-tagging and lemmatization are provided by the SVMTool package (Gimenez and M`arquez, 2004), and base phrase chunking is provided by the Phreco software (Carreras et al., 2005).
W05-0620
As can be seen in 2b and 2c, the dependencies are augmented by thematic roles (Kipper et al., 2000) (e.g., Agent, Theme, Cause, Instrument?? produced by a semantic role labeling system (c.f., Gildea and Jurafsky, 2002).
J02-3001
Although automatic semantic parsing is a large and growing field (Moldovan et al., 2004; Litkowski, 2004; Baldewein et al., 2004), two problems present themselves.
W04-0803
In the original formulation for English in Gildea and Jurafsky (2002), it answers the question: Is the NP governed by IP or VP?
J02-3001
"the international Olympic Conference held in Paris" Figure 1 Example of DE construction Since the governing category information is encoded in the path feature, it may be redundant; indeed this redundancy might explain why the governing category feature was used in Gildea & Jurafsky(2002) but not in Gildea and Palmer(2002).
J02-3001
101 Other than a lexicon (which is used to identify the base form of a term), our approach uses no background knowledge, such as WordNet (Miller, 1995), extensive dictionaries (Litkowski, 2006) or custom-built knowledge-bases (Hickl et al., 2006) that have been successfully employed by other systems.
W06-2106
The main components of the systems are the following: 2.1 Linguistic processing Firstly, each text-hypothesis pair is preprocessed in order to obtain the following information for the entailment decision: ??POS: a Part of Speech Tagging is performed in order to obtain lemmas for both text and hypothesis using the Freeling POS tagger (Carreras et al., 2004).
W04-2412
This task has been the subject of a previous Senseval task (Automatic Semantic Role Labeling, Litkowski (2004)) and two shared tasks on semantic role labeling in the Conference on Natural Language Learning (Carreras & Marquez (2004) and Carreras & Marquez (2005)).
W04-0803 W04-2412 W05-0620
