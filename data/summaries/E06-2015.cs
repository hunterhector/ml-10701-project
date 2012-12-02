The last years have seen a boost of work devoted to the development of machine learning based coreference resolution systems (Soon et al., 2001; Ng & Cardie, 2002; Kehler et al., 2004, inter alia).
J01-4004 N04-1037 P02-1014
Note that in contrast to Ng & Cardie (2002) we classify ALIAS as a lexical feature, as it solely relies on string comparison and acronym string matching.
P02-1014
Instances are created following Soon et al.(2001). During testing the classifier imposes a partitioning on the available REs by clustering each set of expressions labeled as coreferent into the same coreference chain.
J01-4004
System Features Following Ng & Cardie (2002), our baseline system reimplements the Soon et al.(2001) system.
J01-4004 P02-1014
This layer of semantic context abstracts from the specific lexical expressions used, and therefore represents a higher level of abstraction than predicate argument statistics (Kehler et al., 2004) and Latent Semantic Analysisusedasamodelofworldknowledge(Klebanov & Wiemer-Hastings, 2002).
N04-1037
In our experiments we use the ASSERT parser (Pradhan et al., 2004), an SVM based semantic role tagger which uses a full syntactic analysis to automatically identify all verb predicates in a sentence together with their semantic arguments, which are output as PropBank arguments (Palmer et al., 2005).
J05-1004 N04-1030
Algorithm For learning coreference decisions, we used a Maximum Entropy (Berger et al., 1996) model.
J96-1002
In this respect, the present work is closer in spirit to Ji et al.(2005), who explore the employment of the ACE 2004 relation ontology as a semantic filter.
H05-1003
3.1 Performance Metrics We report in the following tables the MUC score (Vilain et al., 1995).
M95-1005
Similarly, many researchers have explored techniques for robust, broad coverage semantic parsing in terms of semantic role labeling (Gildea & Jurafsky, 2002; Carreras & M`arquez, 2005, SRL henceforth).
J02-3001 W05-0620
