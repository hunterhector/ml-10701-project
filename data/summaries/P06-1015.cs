Pantel et al.(2004) proposed a similar, highly scalable approach, based on an edit-distance technique, to learn lexico-POS patterns, showing both good performance and efficiency.
C04-1111 N04-1041
• CHEM: This small dataset of 313,590 words consists of a college level textbook of introductory chemistry (Brown et al.2003). Each corpus is pre-processed using the Alembic Workbench POS-tagger (Day et al.1997). Below we describe the systems used in our empirical evaluation of Espresso.
A97-1051
• RH02: The algorithm by Ravichandran and Hovy (2002) described in Section 2.
P02-1006
Following (Pantel et al.2004), we define the relative recall of system A given system B, R A|B, as: BP AP C C R R R B A B A C C C C B A BA B A × × ==== | where R A is the recall of A, C A is the number of correct instances extracted by A, C is the (unknown) total number of correct instances in the corpus, P A is A’s precision in our experiments, 2 The kappa statistic jumps to Κ = 0.79 if we treat partially correct classifications as correct.
C04-1111 N04-1041
Hearst (1992) pioneered using patterns to extract hyponym (is-a) relations.
C92-2082
We thus multiply pmi(i, p) with the discounting factor suggested in (Pantel and Ravichandran 2004).
C04-1111 N04-1041
Caraballo (1999) proposed the first attempt, which used conjunction and apposition features to build noun clusters.
P99-1016
Berland and Charniak (1999) proposed a system for part-of relation extraction, based on the (Hearst 1992) approach.
C92-2082 P99-1008
• PR04: The algorithm by Pantel and Ravichandran (2004) described in Section 2.
C04-1111 N04-1041
Many recent efforts have also focused on extracting semantic relations between entities, such as entailments (Szpektor et al.2004), is-a (Ravichandran and Hovy 2002), part-of (Girju et al.2006), and other relations.
P02-1006 W04-3206
Recently, Pantel and Ravichandran (2004) extended this approach by making use of all syntactic dependency features for each noun.
C04-1111 N04-1041
Pattern Ranking/Selection In (Ravichandran and Hovy 2002), a frequency threshold on the patterns in P is set to select the final patterns.
P02-1006
Ravichandran and Hovy (2002) focus on scaling relation extraction to the Web.
P02-1006
Espresso Algorithm Espresso is based on the framework adopted in (Hearst 1992).
C92-2082
We chose the state of the art algorithm described in (Ravichandran and Hovy 2002) with the following slight modification.
P02-1006
Other pattern-based algorithms include (Riloff and Shepherd 1997), who used a semi-automatic method for discovering similar words using a few seed examples, KnowItAll (Etzioni et al.2005) that performs large-scale extraction of facts from the Web, Mann (2002) who used part of speech patterns to extract a subset of is-a relations involving proper nouns, and (Downey et al.2005) who formalized the problem of relation extraction in a coherent and effective combinatorial model that is shown to outperform previous probabilistic frameworks.
W02-1111 W97-0313
Minimally supervised algorithms, like (Hearst 1992; Pantel et al.2004), typically ignore generic patterns since system precision dramatically decreases from the introduced noise and bootstrapping quickly spins out of control.
C04-1111 C92-2082 N04-1041
To date, researchers have harvested, with varying success, several resources, including concept lists (Lin and Pantel 2002), topic signatures (Lin and Hovy 2000), facts (Etzioni et al.2005), and word similarity lists (Hindle 1990).
C00-1072 C02-1144 P90-1034
Improving upon (Berland and Charniak 1999), Girju et al.(2006) employ machine learning algorithms and WordNet (Fellbaum 1998) to disambiguate part-of generic patterns like “X’s Y” and “X of Y”.
P99-1008
