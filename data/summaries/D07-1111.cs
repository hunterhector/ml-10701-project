Additionally, following Sagae and Lavie (2006), we extend the basic deterministic LR algorithm with a bestfirst search, which results in a parsing strategy similar to generalized LR parsing (Tomita, 1987; 1990), except that we do not perform Tomita’s stack-merging operations.
J87-1004 N06-2033 P06-2089
In the multilingual parsing track, participants train dependency parsers using treebanks provided for ten languages: Arabic (Hajic et al., 2004), Basque (Aduriz et al.2003), Catalan (Martí et al., 2007), Chinese (Chen et al., 2003), Czech (Böhmova et al., 2003), English (Marcus et al., 1993; Johansson and Nugues, 2007), Greek (Prokopidis et al., 2005), Hungarian (Czendes et al., 2005), Italian (Montemagni et al., 2003), and Turkish (Oflazer et al., 2003).
J93-2004
1044 task (Nivre et al., 2007), which differed from the 2006 edition by featuring two separate tracks, one in multilingual parsing, and a new track on domain adaptation for dependency parsers.
D07-1096
We generalize the standard deterministic stepwise framework to probabilistic parsing, with the use of a best-first search strategy similar to the one employed in constituent parsing by Ratnaparkhi (1997) and later by Sagae and Lavie (2006); 3.
N06-2033 P06-2089 W97-0301
There are now several approaches for multilingual dependency parsing, as demonstrated in the CoNLL 2006 shared task (Buchholz and Marsi, 2006).
W06-2920
At test time, each input sentence is parsed using each of the three LR models, and the three resulting dependency structures are combined according to the maximum-spanning-tree parser combination scheme6 (Sagae and Lavie, 2006a) where each dependency proposed by each of the models has the same weight (it is possible that one of the more sophisticated weighting schemes proposed by Sagae and Lavie may be more effective, but these were not attempted).
N06-2033 P06-2089
We provide additional evidence that the parser ensemble approach proposed by Sagae and Lavie (2006a) can be used to improve parsing accuracy, even when only a single parsing algorithm is used, as long as variation can be obtained, for example, by using different learning techniques or changing parsing direction from forward to backward (of course, even greater gains may be achieved when different algorithms are used, although this is not pursued here); and, finally, 4.
N06-2033 P06-2089
To control overfitting in the MaxEnt models, we used box-type inequality constraints (Kazama and Tsujii, 2003).
W03-1018
For a more complete definition, see the CoNLLX shared task description paper (Buchholz and Marsi, 2006).
W06-2920
For a description of the features names in capital letters, see the shared task description (Nivre et al., 2007).
D07-1096
If, instead, this procedure returns a list of several possible actions with corresponding probabilities, we can then parse with a model similar to the probabilistic LR models described by Briscoe and Carroll (1993), where the probability of a parse tree is the product of the probabilities of each of the actions taken in its derivation.
J93-1002
See (Nivre et al., 2007).
D07-1096
As such, it follows a bottom-up strategy, or bottom-up-trees, as defined in Buchholz and Marsi (2006), in contrast to the shift-reduce dependency parsing algorithm described by Nivre (2003), which is a bottom-up/topdown hybrid, or bottom-up-spans.
W06-2920
Sagae and Lavie (2006a) and Zeman and Žabokrtský (2005) have observed that reversing the direction of stepwise parsers can be beneficial in parser combinations.
N06-2033 P06-2089 W05-1518
For example, using MSTParser (McDonald and Pereira, 2005), a large-margin allpairs parser, in our domain adaptation procedure results in significantly improved accuracy (83.2 LAS).
P05-1012
The first LR model for each language uses maximum entropy classification (Berger et al., 1996) to determine possible parser actions and their probabilities4.
J96-1002
In the domain adaptation track, participants were provided with English training data from the Wall Street Journal portion of the Penn Treebank (Marcus et al., 1993) converted to dependencies (Johansson and Nugues, 2007) to train parsers to be evaluated on material in the biological (development set) and chemical (test set) domains (Kulick et al., 2004), and optionally on text from the CHILDES database (MacWhinney, 2000; Brown, 1973).
J93-2004 W04-3111
The resulting algorithm is projective, and nonprojectivity is handled by pseudo-projective transformations as described in (Nivre and Nilsson, 2005).
P05-1013
