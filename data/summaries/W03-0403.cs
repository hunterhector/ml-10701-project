To address this limitation, the Redwoods treebank has been created to provide annotated training material to permit statistical models for ambiguity resolution to be combined with the precise interpretations produced by the ERG (Oepen et al., 2002).
C02-2025
Selective sampling has typically been applied to classification tasks, but has also been shown to reduce the number of examples needed for inducing Lexicalized Tree Insertion Grammars from the Penn Treebank (Hwa, 2000).
W00-1306
We show that sample selection metrics based on tree entropy (Hwa, 2000) and disagreement between two different parse selection models significantly reduce the number of annotated sentences necessary to match a given level of performance according to random selection.
W00-1306
Perceptrons have been used by Collins and Duffy (2002) to re-rank the output of a PCFG, but have not previously been applied to feature-based grammars.
P02-1034
The parse with the highest probability is taken as the preferred parse for the model.2 We use the limited memory variable metric algorithm (Malouf, 2002) to determine the weights.
W02-2018
Log-linear models have previously been used for stochastic unification-based grammars by Johnson et al.(1999) and Osborne (2000).
C00-1085 P99-1069
Using Redwoods-1, Toutanova and Manning (2002) have shown that loglinear models for parse selection considerably outperform PCFG models trained on the same features.
W02-2030
Most statistical parsing research, such as Collins (1997), has centered on training probabilistic context-free grammars using the Penn Treebank.
P97-1003
We do so in the context of Redwoods (Oepen et al., 2002), a treebank that contains HPSG analyses for sentences from the Verbmobil appointment scheduling and travel planning domains.
C02-2025
The performance of LL-CONFIG on Redwoods-1 matches the accuracy of the best stand-alone log-linear model reported by Toutanova and Manning (2002), which uses essentially the same features.
W02-2030
Active learning has been successfully applied to a number of natural language oriented tasks, including text categorization (Lewis and Gale, 1994) and part-of-speech tagging (Engelson and Dagan, 1996).
P96-1042
Hwa (2000) shows that certainty-based selective sampling can reduce the amount of training material needed for inducing Probabilistic Lexicalized Tree Insertion Grammars by 36% without degrading the quality of the grammars.
W00-1306
Whereas Hwa (Hwa, 2000) evaluated the effectiveness of selective sampling according to the number of brackets which were needed to create the parse trees for selected sentences, we compare selection methods based on the absolute number of sentences they select.
W00-1306
Rather than comparing the two learners on whether they categorically select the same preferred parse on a number of examples, we can view active learning as the inverse of agreement-based co-training (Abney, 2002).
P02-1046
The configurational set is loosely based on the derivation tree features given by Toutanova and Manning (2002), and thus encodes standard relations such as grandparent-of and leftsibling for the nodes in the tree.
W02-2030
The single-learner method uses tree entropy (Hwa, 2000), which measures the uncertainty of a learner based on the conditional distribution it assigns to the parses of a given sentence.
W00-1306
