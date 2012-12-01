As described earlier, the reference answer facets are roughly extracted from the relations in a syntactic dependency parse (c.f., Nivre and Scholz, 2004) and a shallow semantic parse (Gildea and Jurafsky, 2002).
J02-3001
Our syntax relies on a frame-based design in the LF ontology, a common representation in semantic lexicons (Baker et al., 1998, Kipper et al., 2000).
P98-1013
Scores were calculated using the srl-eval.pl script from the CoNLL-2005 scoring package (Carreras and M`arquez, 2005).
W05-0620
Since the SFG annotation is semantically oriented, the work also bears some resemblance to Propbank (Palmer et al., 2005).
J05-1004
In the original formulation for English in Gildea and Jurafsky (2002), it answers the question: Is the NP governed by IP or VP?
J02-3001
"the international Olympic Conference held in Paris" Figure 1 Example of DE construction Since the governing category information is encoded in the path feature, it may be redundant; indeed this redundancy might explain why the governing category feature was used in Gildea & Jurafsky(2002) but not in Gildea and Palmer(2002).
J02-3001
Dependency trees have been used in a variety of NLP applications, such as relation extraction (Culotta and Sorensen, 2004) and machine translation (Ding and Palmer, 2005).
J05-1004
Ding and Palmer (2005) introduced a version of probabilistic extension of Synchronous Dependency Insertion Grammars (SDIG) to deal with the pervasive structure divergence.
J05-1004
With the advent of faster and powerful computers, more effective machine learning algorithms, and importantly, large data resources annotated with relevant levels of semantic information FrameNet (Baker et al., 1998) andProbBankcorpora (Palmer et al., 2005), we are seeing a surge in efficient approaches to SRL (Carreras and M`arquez, 2005).
J05-1004 P98-1013 W05-0620
Traditionally, SRL systems have been trained on either the PropBank corpus (Palmer et al., 2005) ??for two years, the CoNLL workshop (Carreras and M`arquez, 2004; Carreras and M`arquez, 2005) has made this their shared task, or the FrameNet corpus ??Senseval-3 used this for their shared task (Litkowski, 2004).
J05-1004 W05-0620
For example, Gildea and Jurafsky (2002) found that identifying passives was important in training a semantic role classifier from FrameNet, using a parser trained on the Penn Treebank along with a set of templates to distinguish passive constructions from active ones.
J02-3001
This approach significantly outperforms the multi-class perceptron on the same dataset based on WORDNET 1.6 and 1.7.1. 1 Introduction Lexical-semantic resources have been applied successful to a wide range of Natural Language Processing (NLP) problems ranging from collocation extraction (Pearce, 2001) and class-based smoothing (Clark and Weir, 2002), to text classification (Baker and McCallum, 1998) and question answering (Pasca and Harabagiu, 2001).
P98-1013
Another important thread of investigation concerning preposition behavior is the task of semantic role (and perhaps semantic relation) labeling (Gildea & Jurafsky, 2002).
J02-3001
The SALSA RTE system is based on three main components: (i) a linguistic analysis of text and hypothesis based primarily on LFG and Frame Semantics (Baker et al., 1998), (ii) the computation of a match graph that encodes the semantic overlap between text and hypothesis, and (iii) a statistical entailment decision.
P98-1013
There is no direct connection between these different verbs in the ERG lexicon, even though they are intuitively related and are listed as belonging to the same or related word classes in semantic lexicons/ontologies such as VerbNet (Kipper et al., 2000) and FrameNet (Baker et al., 1998).
P98-1013
FrameNet (Baker et al, 1998) attempts to encode this knowledge.
P98-1013
increase [from $50] to $100) temporal topic 3 Semantic Parsing 3.1 Architecture and Classifier Following the architecture of earlier semantic parsers like Gildea and Jurafsky (2002), we treat the semantic parsing task as a 1-of-N classification problem.
J02-3001
The NLP field has gone through a very 94 long tradition of algorithms designed for solving this problem (Ide and Veronis, 1998).
J98-1001
This paper illustrates the above claims with respect to three lexical resources ??FrameNet (Baker et al., 1998), PropBank (Palmer et al., 2005) and VerbNet (Schuler, 2005) ??that convey information about lexical predicates and their arguments.
J05-1004 P98-1013
Text is automatically annotated, using the SVMTool (Gimenez and M`arquez, 2004), Freeling (Carreras et al., 2004), and Phreco (Carreras et al., 2005) packages.
W05-0620
PoS-tagging and lemmatization are provided by the SVMTool package (Gimenez and M`arquez, 2004), and base phrase chunking is provided by the Phreco software (Carreras et al., 2005).
W05-0620
As can be seen in 2b and 2c, the dependencies are augmented by thematic roles (Kipper et al., 2000) (e.g., Agent, Theme, Cause, Instrument?? produced by a semantic role labeling system (c.f., Gildea and Jurafsky, 2002).
J02-3001
The systems for the other languages follow the successful models devised for English, (Gildea and Jurafsky, 2002; 95 Xue and Palmer, 2004; Pradhan et al., 2003).
J02-3001 W04-3212
For evaluation we use the official CoNLL evaluator (Carreras and M`arquez, 2005).
W05-0620
Our generic senses have been inspired by FrameNet (Baker et al., 1998).
P98-1013
Setup Experiments aimed at extracting protein-protein interactions for Bakers yeast (Sacharomyces Cerevesiae) to assess BioNoculars (Cherry et al., 1998).
P98-1013
This task has been the subject of a previous Senseval task (Automatic Semantic Role Labeling, Litkowski (2004)) and two shared tasks on semantic role labeling in the Conference on Natural Language Learning (Carreras & Marquez (2004) and Carreras & Marquez (2005)).
W05-0620
