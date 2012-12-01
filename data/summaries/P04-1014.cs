The feature set for the normal-form model is the same except that, following Hockenmaier and Steedman (2002), the dependency features are defined in terms of the local rule instantiations, by adding the heads of the combining categories to the rule instantiation features.
P02-1043
Clark et al.(2002) handle the additional derivations by modelling the derived structure, in their case dependency structures.
P02-1042
Hockenmaier also found the dependencies to be very beneficial — in contrast to recent results from the lexicalised PCFG parsing literature (Gildea, 2001) — but did not gain from the use of distance measures.
W01-0521
The parser uses a maximum entropy supertagger (Clark and Curran, 2004) to assign lexical categories to the words in a sentence, and applies the CKY chart parsing algorithm described in Steedman (2000).
C04-1041
For the normal-form model we were able to reduce the size of the charts considerably by applying two types of restriction to the parser: first, categories can only combine if they appear together in a rule instantiation in sections 2–21 of CCGbank; and second, we apply the normal-form restrictions described in Eisner (1996).
P96-1011
(See Clark and Curran (2004) for a description of the Eisner constraints.) The normal-form model requires only 5 machines for estimation, with an average memory usage of 730 MB for each machine.
C04-1041
Table 3 also gives the results if automatically assigned POS tags are used in the training and testing phases, using the C&C POS tagger (Curran and Clark, 2003).
E03-1071 W03-1013
Let E fi be the expected value of fi over the forest for model ; then the values in (5) can be obtained by calculating E j fi for the complete forest j for each sentence S j in the training data (the second sum in (5)), and also E j fi for each forest j of correct derivations (the first sum in (5)): @L( ) @ i = mX j=1 (E j fi E j fi) (8) The likelihood in (4) can be calculated as follows: L( )= mX j=1 (log Z j log Z j) (9) where log Z is the normalisation constant for . 6 Estimation in Practice The gold standard dependency structures are produced by running our CCG parser over the normal-form derivations in CCGbank (Hockenmaier, 2003a).
P03-1046
The results of Clark et al.(2002) and Hockenmaier (2003a) are shown for comparison.
P02-1042 P03-1046 W03-1013
dmax(c) is 3A more complete description of CCG feature forests is given in Clark and Curran (2003).
E03-1071 W03-1013
Our algorithm is based on Goodman’s (1996) labelled recall algorithm for the phrase-structure PARSEVAL measures.
P96-1024
Initially we tried the parallel version of GIS described in Clark and Curran (2003) to perform the estimation, running over the Beowulf cluster.
E03-1071 W03-1013
Dependency Model We follow Riezler et al.(2002) in using a discriminative estimation method by maximising the conditional likelihood of the model given the data.
P02-1035
L-BFGS over forests can be parallelised, using the method described in Clark and Curran (2003) to calculate the feature expectations.
E03-1071 W03-1013
And finally, we show that the parsing algorithm described in Clark and Curran (2003) is extremely slow in some cases, and suggest an efficient alternative based on Goodman (1996).
E03-1071 P96-1024 W03-1013
Clark and Curran (2003) outlines an algorithm for finding the most probable dependency structure, which keeps track of the highest scoring set of dependencies for each node in the chart.
E03-1071 W03-1013
Setting the gradient to zero yields the usual maximum entropy constraints (Berger et al., 1996), except that in this case the empirical values are themselves expectations (over all derivations leading to each gold standard dependency structure).
J96-1002
Let L be the number of correct dependencies in with respect to a gold standard dependency structure G; then the dependency structure, max, which maximises the expected recall rate is: max = arg max E(L =jGj) (10) = arg max X i P( ijS )j \ ij where S is the sentence for gold standard dependency structure G and i ranges over the dependency structures for S . This expression can be expanded further: max = arg max X i P( ijS ) X 2 1 if 2 i = arg max X 2 X 0j 2 0 P( 0jS ) = arg max X 2 X d2 ( 0)j 2 0 P(djS ) (11) The final score for a dependency structure is a sum of the scores for each dependency in ; and the score for a dependency is the sum of the probabilities of those derivations producing . This latter sum can be calculated efficiently using inside and outside scores: max =arg max X 2 1 ZS X c2C c c if 2deps(c) (12) where c is the inside score and c is the outside score for node c (see Clark and Curran (2003)); C is the set of conjunctive nodes in the packed chart for sentence S and deps(c) is the set of dependencies on conjunctive node c.
E03-1071 W03-1013
Clark and Curran (2004) shows that the normal-form constraints significantly increase parsing speed and, in combination with adaptive supertagging, result in a highly efficient wide-coverage parser.
C04-1041
We use the novel strategy developed in Clark and Curran (2004): first assign a small number of categories (approximately 1.4) on average to each word, and increase the number of categories if the parser fails to find an analysis.
C04-1041
Normal-Form Model The objective function and gradient vector for the normal-form model are as follows: L0( ) = L( ) G( ) (6) = log mY j=1 P (d jjS j) nX i=1 2i 2 2i @L0( ) @ i = mX j=1 fi(d j) (7) mX j=1 X d2 (S j) e :f(d) fi(d) P d2 (S j) e :f(d) i 2 i 1See Riezler et al.(2002) for a similar description in the context of LFG parsing.
P02-1035
The dependency structures considered in this paper are described in detail in Clark et al.(2002) and Clark and Curran (2003).
E03-1071 P02-1042 W03-1013
The expected values can be calculated using the method in Clark and Curran (2003).
E03-1071 W03-1013
Clark and Curran (2004) shows that this supertagging method results in a highly efficient parser.
C04-1041
Following Clark et al.(2002), evaluation is by precision and recall over dependencies.
P02-1042
The results show that each additional feature type increases perforLP LR UP UR cat Clark et al.2002 81.9 81.8 90.1 89.9 90.3 Hockenmaier 2003 84.3 84.6 91.8 92.2 92.2 Log-linear 86.6 86.3 92.5 92.1 93.6 Hockenmaier(POS) 83.1 83.5 91.1 91.5 91.5 Log-linear (POS) 84.8 84.5 91.4 91.0 92.5 Table 3: Results on the test set mance.
P02-1042 P03-1046 W03-1013
Riezler et al.(2002) and Toutanova et al.(2002). One motivation for using a log-linear model is that long-range dependencies which CCG was designed to handle can easily be encoded as features.
P02-1035
Curran. 2003.
E03-1071
Sha and Pereira (2003).
N03-1028
In Clark and Curran (2003) we argued for the use of log-linear parsing models for CCG.
E03-1071 W03-1013
Clark and Curran (2003) show how the sum over the complete derivation space can be performed efficiently using a packed chart and a variant of the inside-outside algorithm.
E03-1071 W03-1013
They use a conditional model, based on Collins (1996), which, as the authors acknowledge, has a number of theoretical deficiencies; thus the results of Clark et al.provide a useful baseline for the new models presented here.
P96-1025
For the dependency model, we define the probability of a dependency structure as follows: P( jS )= X d2 ( ) P(d; jS ) (1) where is a dependency structure, S is a sentence and ( ) is the set of derivations which lead to. This extends the approach of Clark et al.(2002) who modelled the dependency structures directly, not using any information from the derivations.
P02-1042
A number of statistical parsing models have recently been developed for Combinatory Categorial Grammar (CCG; Steedman, 2000) and used in parsers applied to the WSJ Penn Treebank (Clark et al., 2002; Hockenmaier and Steedman, 2002; Hockenmaier, 2003b).
P02-1042 P02-1043 P03-1046 W03-1013
Our normal-form parser significantly outperforms the parser of Clark et al.(2002) and produces results at least as good as the current state-of-the-art for CCG parsing.
P02-1042
This paper assumes a basic understanding of CCG; see Steedman (2000) for an introduction, and Clark et al.(2002) and Hockenmaier (2003a) for an introduction to statistical parsing with CCG.
P02-1042 P03-1046 W03-1013
Hockenmaier (2003a) uses a model which favours only one of the derivations leading to a derived structure, namely the normal-form derivation (Eisner, 1996).
P03-1046 P96-1011
