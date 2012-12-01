For comparison the parser of Charniak and Johnson (2005) has an accuracy of F1=90.7 and runs in 19 min on this set.
P05-1022
In particular, we demonstrated in Petrov et al.(2006) that a hierarchically split PCFG could exceed the accuracy of lexicalized PCFGs (Collins, 1999; Charniak and Johnson, 2005).
P05-1022 P06-1055
Some of our methods and conclusions are relevant to all state-split grammars, such as Klein and Manning (2003) or Dreyer and Eisner (2006), while others apply most directly to the hierarchical case.
P03-1054 W06-1638
Adapting unlexicalized parsers appears to be equally difficult: Levy and Manning (2003) adapt the unlexicalized parser of Klein and Manning (2003) to Chinese, but even after significant efforts on choosing category splits, only modest performance gains are reported.
P03-1054 P03-1056
It is well known that a model trained on the Wall Street Journal loses significantly in performance when evaluated on the Brown Corpus (see Gildea (2001) for more details and the exact setup of their experiment, which we duplicated here).
W01-0521
In Petrov et al.(2006), some simple smoothing is also shown to be effective.
P06-1055
The labeled brackets algorithm of Goodman (1996) has such an objective function.
P96-1024
As in many model families (Steedman, 2000; Vijay-Shanker and Joshi, 1985), split PCFGs have a derivation / parse distinction.
P85-1011
2 using the parser of Petrov et al.(2006). We then took the same grammar and extracted 500-sample lists using the method of Finkel et al.(2006). The minimum risk parse candidate was selected for various loss functions.
P06-1055 W06-1673
ENGLISH GERMAN CHINESE (Marcus et al., 1993) (Skut et al., 1997) (Xue et al., 2002) TrainSet Section 2-21 Sentences 1-18,602 Articles 26-270 DevSet Section 22 18,603-19,602 Articles 1-25 TestSet Section 23 19,603-20,602 Articles 271-300 Table 3: Experimental setup.
A97-1014 C02-1145 J93-2004
Charniak et al.(2006) pre-parse with a sequence of grammars which are coarser than (parentannotated) treebank grammars.
N06-1022
While the most probable parse problem is NP-complete (Sima’an, 1992), several approximate methods exist, including n-best reranking by parse likelihood, the labeled bracket algorithm of Goodman (1996), and a variational approximation introduced in Matsuzaki et al.(2005). We present experiments which explicitly minimize various evaluation risks over a candidate set using samples from the split PCFG, and relate those conditions to the existing non-sampling algorithms.
P05-1010 P96-1024
The method for sampling derivations of a PCFG is given in Finkel et al.(2006) and Johnson et al.(2007). It requires a single inside-outside computation per sentence and is then efficient per sample.
N07-1018 W06-1673
410 ≤40 words all Parser LP LR LP LR ENGLISH Charniak et al.(2005) 90.1 90.1 89.5 89.6 Petrov et al.(2006) 90.3 90.0 89.8 89.6 This Paper 90.7 90.5 90.2 89.9 ENGLISH (reranked) Charniak et al.(2005)4 92.4 91.6 91.8 91.0 GERMAN Dubey (2005) F1 76.3 This Paper 80.8 80.7 80.1 80.1 CHINESE5 Chiang et al.(2002) 81.1 78.8 78.0 75.2 This Paper 80.8 80.7 78.8 78.5 Table 4: Our final test set parsing performance compared to the best previous work on English, German and Chinese.
N06-1022 P05-1022 P05-1039 P06-1055
Split PCFGs We consider PCFG grammars which are derived from a raw treebank as in Petrov et al.(2006): A simple X-bar grammar is created by binarizing the treebank trees.
P06-1055
2006 release of the Charniak and Johnson (2005) parser runs in 1150 seconds on the same machine with an F1 of 90.7%. 4 Objective Functions for Parsing A split PCFG is a grammar G over symbols of the form X-k where X is an evaluation symbol (such as NP) and k is some indicator of a subcategory, such as a parent annotation.
P05-1022
Charniak et al.(1998) G0 G1 G2 G3 G4 G5 G6 X-bar = G = pii DT: DT-1: DT-2: the that this this 0 1 2 3 4 That 5 6 7 some some 8 9 10 11 these 12 13 the the the 14 15 The 16 a a 17 Figure 1: Hierarchical refinement proceeds top-down while projection recovers coarser grammars.
W98-1115
This is the approach taken by Charniak et al.(2006), where they estimate what in our terms are projections of the raw treebank grammar from the treebank itself.
N06-1022
As demonstrated by Charniak et al.(2006) parsing times can be greatly reduced by pruning chart items that have low posterior probability under a simpler grammar.
N06-1022
On English, the parser is outperformed only by the reranking parser of Charniak and Johnson (2005), which has access to a variety of features which cannot be captured by a generative model.
P05-1022
Parsing Most research on parsing has focused on English and parsing performance on other languages is generally significantly lower.3 Recently, there have been some attempts to adapt parsers developed for English to other languages (Levy and Manning, 2003; Cowan and Collins, 2005).
H05-1100 P03-1056
3.1 Coarse-to-Fine Approaches Charniak et al.(2006) introduces multi-level coarseto-fine parsing, which extends the basic pre-parsing idea by adding more rounds of pruning.
N06-1022
Projected Grammars Fortunately, there is a well worked-out notion of estimating a grammar from an infinite distribution over trees (Corazza and Satta, 2006).
N06-1043
In contrast, automatically learned grammars like the one of Matsuzaki et al.(2005) and Petrov et al.(2006) require a treebank for training but no additional human input.
P05-1010 P06-1055
Corazza and Satta (2006) extend these methods to the case of PCFGs and tree distributions.
N06-1043
Previous work has shown that high-quality unlexicalized PCFGs can be learned from a treebank, either by manual annotation (Klein and Manning, 2003) or automatic state splitting (Matsuzaki et al., 2005; Petrov et al., 2006).
P03-1054 P05-1010 P06-1055
These grammars produce the highest test set parsing figures that we are aware of in each language, except for English for which non-local methods such as feature-based discriminative reranking are available (Charniak and Johnson, 2005).
P05-1022
The refined grammar is estimated using a variant of the forward-backward algorithm (Matsuzaki et al., 2005).
P05-1010
The proofs of the general case are given in Corazza and Satta (2006), but the resulting procedure is quite intuitive.
N06-1043
We then parse with each refinement, in sequence, much along the lines of Charniak et al.(2006), except with much more complex and automatically derived intermediate grammars.
N06-1022
It is interesting to note that these grammars capture many of the “structural zeros” described by Mohri and Roark (2006) and pruning rules with probability below e−10 reduces the grammar size drastically without influencing parsing performance.
N06-1040
Recently McClosky et al.(2006) came to the conclusion that this performance drop is not due to overfitting the WSJ data.
P06-1043
78 80 82 84 86 Grammar Size F 1 Hierarchically Split PCFGs Charniak and Johnson (2005) generative parser Charniak and Johnson (2005) reranking parser G3 G5 G 6G 4 Figure 4: Parsing accuracy starts dropping after 5 training iterations on the Brown corpus, while it is improving on the WSJ, indicating overfitting.
P05-1022
Most relevant to our work is Charniak and Johnson (2005) which uses a pre-parse phase to rapidly parse with a very coarse, unlexicalized treebank grammar.
P05-1022
In particular, G may be improper, though the results of Chi (1999) imply that G will be proper if it is the maximum-likelihood estimate of a finite treebank.
J99-1004
The earliest work that we are aware of on estimating models from models in this way is that of Nederhof (2005), who considers the case of learning language models from other language models.
J05-2002
In this section, we present experiments with the various options and explicitly relate them to parse risk minimization (Titov and Henderson, 2006).
W06-1666
For any projection of a grammar, we give a new method for efficiently estimating the projection’s parameters from the source PCFG itself (rather than a treebank), using techniques for infinite tree distributions (Corazza and Satta, 2006) and iterated fixpoint equations.
N06-1043
Matsuzaki et al.(2005) present a VARIATIONAL approach, which approximates the true posterior over parses by a cruder, but tractable sentence-specific one.
P05-1010
Space does not permit a thorough exposition of our analysis, but as in the case of English (Petrov et al., 2006), the learned subcategories exhibit interesting linguistic interpretations.
P06-1055
As in Charniak et al.(2006), we construct a sequence of increasingly refined grammars, reparsing with each refinement.
N06-1022
