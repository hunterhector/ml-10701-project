However, a very large amount of memory is still needed to store the packed charts for the complete training data even though the representation is very compact; in Clark and Curran (2003) we report a memory usage of 30 GB.
E03-1071 W03-1013
Clark et al.(2002) and Clark and Curran (2004) give a detailed description of the dependency structures.
P02-1042 P04-1014
The per-word accuracy is between 91 and 92% on unseen data in CCGbank; however, Clark (2002) shows this is not high enough for integration into a parser since the large number of incorrect categories results in a significant loss in coverage.
P02-1042
However, for LTAGs extracted automatically from the Penn Treebank, performance is much lower (Chen et al., 1999; Chen et al., 2002).
E99-1025
Supertagging was introduced for LTAG as a way of increasing parsing efficiency by reducing the number of structures assigned to each word (Bangalore and Joshi, 1999).
J99-2004
Parser The parser is described in detail in Clark and Curran (2004).
P04-1014
This strategy was used in our earlier work (Clark and Curran, 2003) and, as the table shows, results in very large charts.
E03-1071 W03-1013
Following Clark (2002), we apply a frequency cutoff to the training set, only using those categories which appear at least 10 times in sections 2-21.
P02-1042
The parser is extremely fast, and in Clark and Curran (2004) we show that the F-score for labelled dependencies is almost 98%.
P04-1014
An advantage of the Maximum Entropy approach is that it is easy to encode a wide range of potentially useful information as features; for example, Clark (2002) has shown that POS tags provide useful information for supertagging.
P02-1042
Clark and Curran (2004) evaluate a number of log-linear parsing models for CCG.
P04-1014
1See Steedman (2000) for an introduction to CCG, and see Clark et al.(2002) and Hockenmaier (2003) for an introduction to wide-coverage parsing using CCG.
P02-1042 W03-1013
The feature set we use is from the best performing normal-form model in Clark and Curran (2004).
P04-1014
Kaplan et al.(2004) report high parsing speeds for a deep parsing system which uses an LFG grammar: 1.9 sentences per second for 560 sentences from section 23 of the Penn Treebank.
N04-1013
2The numbers differ slightly from those reported in Clark (2002) since a newer version of CCGbank is being used here.
P02-1042
Our previous approach to parsing unseen data (Clark et al., 2002; Clark and Curran, 2003) was to use the least restrictive setting of the supertagger which still allows a reasonable compromise between speed and accuracy.
E03-1071 P02-1042 W03-1013
The second strategy is to use Eisner’s normalform constraints (Eisner, 1996).
P96-1011
In Clark and Curran (2004) we describe efficient methods for performing the calculations using packed charts.
P04-1014
Osborne (2000).
C00-1085
In Clark and Curran (2004) we show that the parsing model resulting from training data generated in this way produces state-of-the-art CCG dependency recovery: 84.6 F-score over labelled dependencies.
P04-1014
Curran and Clark (2003) describes the model and explains how Generalised Iterative Scaling, together with a Gaussian prior for smoothing, can be used to set the weights.
E03-1071 W03-1013
Bangalore and Joshi (1999) use a standard Markov model tagger to assign LTAG elementary trees to words.
J99-2004
The new strategy increases the F-score over labelled dependencies by approximately 0.5%, leading to the figures reported in Clark and Curran (2004).
P04-1014
Clark (2002) compares the size of grammars extracted from CCGbank with automatically extracted LTAGs.
P02-1042
In Clark and Curran (2004) we show that using this more restrictive setting has a small negative impact on the accuracy of the resulting parser (about 0.6 F-score over labelled dependencies).
P04-1014
Here we use the Maximum Entropy models described in Curran and Clark (2003).
E03-1071 W03-1013
(Parse Times) The results in this section are all using the best performing normal-form model in Clark and Curran (2004), which corresponds to row 3 in Table 3.
P04-1014
Clark (2002) shows how the models in (1) can be used to define a multi-tagger which can assign more than one category to a word.
P02-1042
We follow Clark (2002) in ignoring the features based on the previously assigned categories; therefore every tagging decision is local and the Viterbi algorithm is not required.
P02-1042
Supertagging has more recently been applied to CCG (Clark, 2002; Curran and Clark, 2003).
E03-1071 P02-1042 W03-1013
The supertagger in Curran and Clark (2003) finds the single most probable category sequence given the sentence, and uses additional features defined in terms of the previously assigned categories.
E03-1071 W03-1013
Here we simply use the exponential of the inside score of a category as the beam score; the inside score for a category c is the sum over all sub-derivations dominated by c of the weights of the features in those sub-derivations (see Clark and Curran (2004).5 The value of that we use here reduces the accuracy of the parser on section 00 by a small amount (0.3% labelled F-score), but has a significant impact on parser speed, reducing the parse times by a further 33%.
P04-1014
The table gives results for gold standard POS tags and, in the final 2 columns, for POS tags automatically assigned by the Curran and Clark (2003) tagger.
E03-1071 W03-1013
Estimation In Clark and Curran (2004) we describe a discriminative method for estimating the parameters of a log-linear parsing model.
P04-1014
Supertagging accuracy is relatively high for manually constructed LTAGs (Bangalore and Joshi, 1999).
J99-2004
