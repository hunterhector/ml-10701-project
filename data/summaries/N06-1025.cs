2http://alias-i.com/lingpipe 3.3 Baseline System Features Following Ng & Cardie (2002), our baseline system reimplements the Soon et al.(2001) system.
J01-4004 P02-1014
Note that in contrast to Ng & Cardie (2002) we interpret ALIAS as a lexical feature, as it solely relies on string comparison and acronym string matching.
P02-1014
We investigate the use of the WordNet and Wikipedia taxonomies for extracting semantic similarity and relatedness measures, as well as semantic parsing information in terms of semantic role labeling (Gildea & Jurafsky, 2002, SRL henceforth).
J02-3001
Employing SRL is closer in spirit to Ji et al.(2005), who explore the employment of the ACE 2004 relation ontology as a semantic filter.
H05-1003
In our experiments we use the ASSERT parser (Pradhan et al., 2004), an SVM based semantic role tagger which uses a full syntactic analysis to automatically identify all verb predicates in a sentence together with their semantic arguments, which are output as PropBank arguments (Palmer et al., 2005).
J05-1004 N04-1030
We follow Soon et al.(2001) in performing a simple one-tailed, paired sample t-test between the baseline system’s MUC score F-measure and each of the other systems’ F-measure scores on the test documents.
J01-4004
4.1 Performance Metrics We report in the following tables the MUC score (Vilain et al., 1995).
M95-1005
Luo et al.(2004), Kehler et al.(2004)). Instances are created following Soon et al.(2001). We create a positive training instance from each pair of adjacent coreferent REs.
J01-4004 N04-1037 P04-1018
The measures we use include path length based measures (Rada et al., 1989; Wu & Palmer, 1994; Leacock & Chodorow, 1998), as well as ones based on information content (Resnik, 1995; Jiang & Conrath, 1997; Lin, 1998).
P94-1019
The measures from Rada et al.(1989), Leacock & Chodorow (1998) and Wu & Palmer (1994) are computed in the same way as for WordNet.
P94-1019
We start with a baseline system using all the features from Soon et al.(2001) that were not removed in the feature selection process (i.e.
J01-4004
Kehler et al.(2004) observe no significant improvement due to predicate argument statistics.
N04-1037
Algorithm For learning coreference decisions, we used a Maximum Entropy (Berger et al., 1996) model.
J96-1002
Nevertheless, we believe that exploiting semantic knowledge in the manner we described will assist the research on coreference resolution to overcome the plateauing in performance observed by Kehler et al.(2004). Acknowledgements: This work has been funded by the Klaus Tschira Foundation, Heidelberg, Germany.
N04-1037
The features used in our model are all binary-valued feature functions (or indicator functions), e.g. fI SEMROLE(ARG0/RUN, COREF) =      1 if candidate pair is coreferent and antecedent is the semantic argument ARG0 of predicate run 0 else In our system, a set of pre-processing components including a POS tagger (Gim´enez & M`arquez, 2004), NP chunker (Kudoh & Matsumoto, 2000) and the Alias-I LingPipe Named Entity Recognizer2 is applied to the text in order to identify the noun phrases, which are further taken as referring expressions (REs) to be used for instance generation.
W00-0730
The last years have seen a boost of work devoted to the development of machine learning based coreference resolution systems (Soon et al., 2001; Ng & Cardie, 2002; Yang et al., 2003; Luo et al., 2004, inter alia).
J01-4004 P02-1014 P03-1023 P04-1018
These measures are not specifically developed for coreference resolution but simply taken ‘off-the-shelf’ and applied to our task without any specific tuning — i.e. in contrast to Harabagiu et al.(2001), who weight WordNet relations differently in order to compute the confidence measure of the path.
N01-1008
That way we try to overcome the plateauing in performance in coreference resolution observed by Kehler et al.(2004). 2 Related Work Vieira & Poesio (2000), Harabagiu et al.(2001), and Markert & Nissim (2005) explore the use of WordNet for different coreference resolution subtasks, such as resolving bridging reference, otherand definite NP anaphora, and MUC-style coreference resolution.
J00-4003 J05-3004 N01-1008 N04-1037
We enrich the semantic information available to the classifier by using semantic similarity measures based on the WordNet taxonomy (Pedersen et al., 2004).
N04-3012
The improvement reported by Yang et al.(2005) is rather caused by their twin-candidate model than by the semantic knowledge.
P05-1021
Instead of exploring different kinds of data representations, task definitions or machine learning techniques (Ng & Cardie, 2002; Yang et al., 2003; Luo et al., 2004) we focus on a few promising semantic features which we evaluate in a controlled environment.
P02-1014 P03-1023 P04-1018
