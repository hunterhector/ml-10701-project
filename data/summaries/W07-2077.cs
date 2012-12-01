??Governing category as described in (Gildea and Jurafsky, 2002).
J02-3001
This approach has been applied to problems like compound noun interpretation (Rosario and Hearst 2001) and semantic role labeling (Gildea and Jurafsky 2002).
J02-3001
Traditionally, SRL systems have been trained on either the PropBank corpus (Palmer et al., 2005) ??for two years, the CoNLL workshop (Carreras and M`arquez, 2004; Carreras and M`arquez, 2005) has made this their shared task, or the FrameNet corpus ??Senseval-3 used this for their shared task (Litkowski, 2004).
J05-1004 W04-2415
Since the SFG annotation is semantically oriented, the work also bears some resemblance to Propbank (Palmer et al., 2005).
J05-1004
Morpho-syntactic annotation of the English references and hypotheses is performed using the constraint grammar parser ENGCG (Voutilainen, 1995), and the Spanish texts are annotated using the FreeLing analyser (Carreras et al., 2004).
W04-2415
Most of the features we designed are features that have become standard for the SRL task (Gildea and Jurafsky, 2002; Xue and Palmer, 2004; Carreras and M`arquez, 2004; Carreras and M`arquez, 2005).
J02-3001 J05-1004 W04-2415 W04-3212
In the original formulation for English in Gildea and Jurafsky (2002), it answers the question: Is the NP governed by IP or VP?
J02-3001
"the international Olympic Conference held in Paris" Figure 1 Example of DE construction Since the governing category information is encoded in the path feature, it may be redundant; indeed this redundancy might explain why the governing category feature was used in Gildea & Jurafsky(2002) but not in Gildea and Palmer(2002).
J02-3001
Dependency trees have been used in a variety of NLP applications, such as relation extraction (Culotta and Sorensen, 2004) and machine translation (Ding and Palmer, 2005).
J05-1004
Ding and Palmer (2005) introduced a version of probabilistic extension of Synchronous Dependency Insertion Grammars (SDIG) to deal with the pervasive structure divergence.
J05-1004
??Constituent path as described in (Gildea and Jurafsky, 2002); All 3/4/5-grams of path constituents beginning at the verb predicate or ending at the constituent.
J02-3001
With the advent of faster and powerful computers, more effective machine learning algorithms, and importantly, large data resources annotated with relevant levels of semantic information FrameNet (Baker et al., 1998) andProbBankcorpora (Palmer et al., 2005), we are seeing a surge in efficient approaches to SRL (Carreras and M`arquez, 2005).
J05-1004
The main components of the systems are the following: 2.1 Linguistic processing Firstly, each text-hypothesis pair is preprocessed in order to obtain the following information for the entailment decision: ??POS: a Part of Speech Tagging is performed in order to obtain lemmas for both text and hypothesis using the Freeling POS tagger (Carreras et al., 2004).
W04-2415
As described earlier, the reference answer facets are roughly extracted from the relations in a syntactic dependency parse (c.f., Nivre and Scholz, 2004) and a shallow semantic parse (Gildea and Jurafsky, 2002).
J02-3001
For example, Gildea and Jurafsky (2002) found that identifying passives was important in training a semantic role classifier from FrameNet, using a parser trained on the Penn Treebank along with a set of templates to distinguish passive constructions from active ones.
J02-3001
Another important thread of investigation concerning preposition behavior is the task of semantic role (and perhaps semantic relation) labeling (Gildea & Jurafsky, 2002).
J02-3001
In this task we disambiguate argument structures in two ways: predicting VerbNet (Kipper et al., 2000) thematic roles and PropBank (Palmer et al., 2005) numbered arguments, as well as adjunct arguments.
J05-1004
Work HowNet (Dong and Dong, 2006) and WordNet provide domain information for Chinese and English, but there has been no domain resource for Japanese that are publicly available.8 Domain dictionary construction methods that have been developed so far are all based on highly structured lexical resources like LDOCE or WordNet (Guthrie et al., 1991; Agirre et al., 2001) and hence not applicable to languages for which such highly structured lexical resources are not available.
W01-0703
scale knowledge Resources The evaluation presented here covers a wide range of large-scale semantic resources: WordNet (WN) (Fellbaum, 1998), eXtended WordNet (Mihalcea and Moldovan, 2001), large collections of semantic preferences acquired from SemCor (Agirre and Martinez, 2001; Agirre and Martinez, 2002) or acquired from the BNC (McCarthy, 2001), large-scale Topic Signatures for each synset acquired from the web (Agirre and de la Calle, 2004) or SemCor (Landes et al., 2006).
W01-0703
increase [from $50] to $100) temporal topic 3 Semantic Parsing 3.1 Architecture and Classifier Following the architecture of earlier semantic parsers like Gildea and Jurafsky (2002), we treat the semantic parsing task as a 1-of-N classification problem.
J02-3001
Among others we can mention eXtended WordNet (Mihalcea and Moldovan, 2001), large collections of semantic preferences acquired from SemCor (Agirre and Martinez, 2001; Agirre and Martinez, 2002) or acquired from British National Corpus (BNC) (McCarthy, 2001), largescale Topic Signatures for each synset acquired from the web (Agirre and de la Calle, 2004) or acquired from the BNC (Cuadros et al., 2005).
W01-0703
??Partial parsing path as described in (Carreras et al., 2004)); All 3/4/5-grams of path elements beginning at the verb predicate or ending at the constituent.
W04-2415
Among them, we select the following subset: (a) Phrase Type, Predicate Word, Head Word, 134 Position and Voice as defined in (Gildea and Jurafsky, 2002); (b) Partial Path, No Direction Path, Head Word POS, First and Last Word/POS in Constituent and SubCategorization as proposed in (Pradhan et al., 2003); and (c) Syntactic Frame as designed in (Xue and Palmer, 2004).
J02-3001 W04-3212
Semantic role labelling (SRL) has been addressed in the CoNLL??004 and CoNLL??005 Shared Tasks (Carreras and M`arquez, 2004; Carreras and M`arquez, 2005) for English.
W04-2415
This paper illustrates the above claims with respect to three lexical resources ??FrameNet (Baker et al., 1998), PropBank (Palmer et al., 2005) and VerbNet (Schuler, 2005) ??that convey information about lexical predicates and their arguments.
J05-1004
Text is automatically annotated, using the SVMTool (Gimenez and M`arquez, 2004), Freeling (Carreras et al., 2004), and Phreco (Carreras et al., 2005) packages.
W04-2415
As can be seen in 2b and 2c, the dependencies are augmented by thematic roles (Kipper et al., 2000) (e.g., Agent, Theme, Cause, Instrument?? produced by a semantic role labeling system (c.f., Gildea and Jurafsky, 2002).
J02-3001
??Syntactic frame as described by Xue and Palmer (2004) Combination Features ??Predicate and Phrase Type ??Predicate and binary position ??Head Word and Predicate ??Predicate and PropBank frame sense ??Predicate, PropBank frame sense, VerbNet class (in the ?close??track only) 2.3 Maximum Entropy Markov Models Maximum Entropy Markov Models are a discriminative model for sequential tagging that models the local probability P(s n | s nn??,o), where o is the context of the observation.
W04-3212
(Gildea and Jurafsky, 2002; Xue and Palmer, 2004; Pradhan et al., 2003).
J02-3001 W04-3212
The systems for the other languages follow the successful models devised for English, (Gildea and Jurafsky, 2002; 95 Xue and Palmer, 2004; Pradhan et al., 2003).
J02-3001 W04-3212
Similarly to Xue and Palmer (2004), Argumentidentification FE Supp Cop Asp Exist Null Argument None Self_mover Path etc classification Figure 3: FE extraction steps.
W04-3212
Section 3) and those extracted from provided semantic information, most of the features we used are borrowed from the existing literature (Gildea and Jurafsky, 2002; Xue and Palmer, 2004; Surdeanu et al., forthcoming).
J02-3001 W04-3212
Restriction 6 applies to VerbNet output 355 follow (Agirre and Martinez, 2001) and use WordNet (Fellbaum, 1998) as the generalization classes (the concept <food,nutrient>).
W01-0703
Nevertheless, we do see some headway for other languages, such as German and Chinese (Erk and Pado, 2006; Sun and Jurafsky, 2004; Xue and Palmer, 2005).
J05-1004
This task has been the subject of a previous Senseval task (Automatic Semantic Role Labeling, Litkowski (2004)) and two shared tasks on semantic role labeling in the Conference on Natural Language Learning (Carreras & Marquez (2004) and Carreras & Marquez (2005)).
W04-2415
