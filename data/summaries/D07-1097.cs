Sincetheparsingalgorithmonlyproducesprojective dependency graphs, we may use pseudo-projective parsing to recover non-projective dependencies, i.e., projectivize training data and encode information about these transformations in extended arc labels to support deprojectivization of the parser output (Nivre and Nilsson, 2005).
P05-1013
The improvements for each language from step 1 (baseline) to step 2 (parsing algorithm) and step 3 (feature model and learning algorithm) can be tracked in table 1.3 2.1 Parsing Algorithm MaltParser implements several parsing algorithms, but for the Single Malt system we stick to the one used by Nivre et al.(2006), which performs labeled projectivedependency parsinginlineartime, usinga stack to store partially processed tokens and an input queue of remaining tokens.
W06-2933
Nivre. 2007.
D07-1096 N07-1050
The output of the ensemble system for x is the maximum spanning tree of this graph (rooted at the node 0), which can be extracted using the Chu-Liu-Edmonds algorithm, as shown by McDonald et al.(2005). Following Sagae and Lavie (2006), we let s(a) = summationtextmi=1 wciai, where wci is the average labeled attachment score of parser i for the word class c8 of the dependent of a, and ai is 1 if a ∈ Gi and 0 otherwise.
H05-1066 N06-2033
Blended Parser The Blended parser is an ensemble system based on the methodology proposed by Sagae and Lavie (2006).
N06-2033
As shown by McDonald and Nivre (2007), the Single Malt parser tends to suffer from two problems: error propagation due to the deterministic parsing strategy, typicallyaffectinglongdependenciesmorethan short ones, and low precision on dependencies originating in the artificial root node due to fragmented parses.9 The question is which of these problems is alleviatedbythemultipleviewsgivenbythecomponent parsers in the Blended system.
D07-1013 D07-1096 N07-1050
In the multilingual track of the CoNLL 2007 shared task on dependency parsing, a single parser must be trained to handle data from ten different languages: Arabic (Hajiˇc et al., 2004), Basque (Aduriz et al., 2003), Catalan, (Mart´ı et al., 2007), Chinese (Chen et al., 2003), Czech (B¨ohmov´a et al., 2003), English (Marcus et al., 1993; Johansson and Nugues, 2007), Greek (Prokopidis et al., 2005), Hungarian (Csendes et al., 2005), Italian (Montemagni et al., 2003), and Turkish (Oflazer et al., 2003).1 Our contribution is a study in multilingual parser optimization using the freely available MaltParser system, which performs 1For more information about the task and the data sets, see Nivre et al.(2007). deterministic, classifier-based parsing with historybased feature models and discriminative learning, and which was one of the top performing systems in the CoNLL 2006 shared task (Nivre et al., 2006).
D07-1096 J93-2004 N07-1050 W06-2933
The parsing algorithms used are the arc-eager baseline algorithm, the arcstandard variant of the baseline algorithm, and the incremental, non-projective parsing algorithm first described by Covington (2001) and recently used for deterministic classifier-based parsing by Nivre (2007), all of which are available in MaltParser.
D07-1096 N07-1050
Thefirstoftheseis a single-parser system, similar to the one described in Nivre et al.(2006), which parses a sentence deterministically in a single left-to-right pass, with postprocessing to recover non-projective dependencies, and where the parameters of the MaltParser system have been tuned for each language separately.
W06-2933
