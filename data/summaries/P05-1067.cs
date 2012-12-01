Induction by Synchronous Hierarchical Tree Partitioning (Ding and Palmer, 2004a) gave a polynomial time solution for learning parallel sub-sentential de1 Total 826 sentence pairs, 9957 Chinese words, 12660 English words.
W04-1513
As a unified approach, we augment the SDIG by adding all the possible word pairs (,) ji fe as a parallel ET pair and using the IBM Model 1 (Brown et al., 1993) word to word translation probability as the ET translation probability.
J93-2003
(Wu, 1997) introduced a polynomial-time solution for the alignment problem based on synchronous binary trees.
J97-3002
Our approach, while similar to (Ding and Palmer, 2004a) in that we also iteratively partition the parallel dependency trees based on a heuristic function, departs (Ding and Palmer, 2004a) in three ways: (1) we base the hierarchical tree partitioning operations on the categories of the dependency trees; (2) the statistics of the resultant tree pairs from the partitioning operation are collected at each iteration rather than at the end of the algorithm; (3) we do not re-train the word to word probabilities at each iteration.
W04-1513
Fox (2002) collected the statistics mainly on French and English data: in dependency representations, the percentage of head crossings per chance (case [b] in the graph) is 12.62%.
W02-1039
Interestingly, NPs are also used as anchor points to learn monolingual paraphrases (Ibrahim et al., 2003).
W03-1608
According to Fox (2002), dependency representations have the best inter-lingual phrasal cohesion properties.
W02-1039
Dorr. 1994.
J94-4004
(Alshawi et al., 2000) represents each production in parallel dependency trees as a finite-state transducer.
J00-1004
Different versions of such training algorithms can be found in (Hajic et al., 2002; Eisner 2003; Gildea 2003; Graehl and Knight 2004).
N04-1014 P03-1011 P03-2041
Dependency Insertion Grammars Ding and Palmer (2004b) described one version of synchronous grammar: Synchronous Dependency Insertion Grammars.
W04-1513
Graehl and Knight (2004) defined training and decoding algorithms for both generalized tree-to-tree and tree-to-string transducers.
N04-1014
(Yamada and Knight, 2001, 2002) modeled translation as a sequence of tree operations transforming a syntactic tree into a string of the target language.
P01-1067 P02-1039
In a different approach, Hwa et al.(2002) aligned the parallel sentences using phrase based statistical MT models and then projected the alignments back to the parse trees.
P02-1050
Furthermore, a grammar based on dependency structures has the advantage of being simple in formalism yet having CFG equivalent formal generative capacity (Ding and Palmer, 2004b).
W04-1513
We use a Maximum Entropy model to interpolate the heuristics in a log-linear fashion, which is different from the error minimization training in (Ding and Palmer, 2004a).
W04-1513
Eisner (2003) proposed viewing the MT problem as a probabilistic synchronous tree substitution grammar parsing 541 problem.
P03-2041
However, structural divergences between languages (Dorr, 1994)，which are due to either systematic differences between languages or loose translations in real corpora，pose a major challenge to syntax-based statistical MT.
J94-4004
Synchronous Tree Adjoining Grammars (Shieber and Schabes, 1990)).
C90-3045
Fox. 2002.
W02-1039
Synchronous Tree Adjoining Grammars, proposed by (Shieber and Schabes, 1990), were introduced primarily for semantics but were later also proposed for translation.
C90-3045
Statistical approaches to machine translation, pioneered by (Brown et al., 1993), achieved impressive performance by leveraging large amounts of parallel corpora.
J93-2003
In our implementation, the IBM Model 1 (Brown et al., 1993) is used.
J93-2003
The recent advances in parsing have achieved parsers with 3 ()On time complexity without the grammar constant (McDonald et al., 2005).
P05-1012
However, even after extending this model by allowing cloning operations on subtrees, Gildea (2003) found that parallel trees over-constrained the alignment problem, and achieved better results with a tree-to-string model than with a tree-to-tree model using two trees.
P03-1011
The heuristic function is based on a set of heuristics, most of which are similar to those in (Ding and Palmer, 2004a).
W04-1513
Our MT system was evaluated using the n-gram based Bleu (Papineni et al., 2002) and NIST machine translation evaluation software.
P02-1040
We used the ISI Rewrite decoder (Germann et al.2001) to decode the IBM models.
P01-1030
In comparison, we deployed the GIZA++ MT modeling tool kit, which is an implementation of the IBM Models 1 to 4 (Brown et al., 1993; AlOnaizan et al., 1999; Och and Ney, 2003).
J03-1002 J93-2003
An Example 3.3 Heuristics Similar to (Ding and Palmer, 2004a), we also use a heuristic function in Step 1(a) of the algorithm to rank all the word pairs for the tentative tree parti544 tioning operation.
W04-1513
Melamed (2003, 2004) formalized the MT problem as synchronous parsing based on multitext grammars.
N03-1021 P04-1083
