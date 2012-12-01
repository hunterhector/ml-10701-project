The projection algorithm of (Quirk et al., 2005) defines heuristics for each of these problems.
P05-1034
The weights of this model are trained to maximize BLEU (Och and Ney, 2004).
J04-4002
It follows the order model defined in (Quirk et al., 2005).
P05-1034
The sentences were annotated with alignment (using GIZA++ (Och and Ney, 2004)) and syntactic dependency structures of the source and target, obtained as described in Section 2.
J04-4002
Alternatively, order is modelled in terms of movement of automatically induced hierarchical structure of sentences (Chiang, 2005; Wu, 1997).
J97-3002 P05-1033
An important advantage of our model is that it is global, and does not decompose the task of ordering a target sentence into a series of local decisions, as in the recently proposed order models for Machine Transition (Al-Onaizan and Papineni, 2006; Xiong et al., 2006; Kuhn et al., 2006).
N06-1004 P06-1066 P06-1067
Target Dependency Trees Through Projection Our algorithm for obtaining target dependency trees by projection of the source trees via the word alignment is the one used in the MT system of (Quirk et al., 2005).
P05-1034
These models are combined as feature functions in a (log)linear model for predicting a target sentence given a source sentence, in the framework proposed by (Och and Ney, 2002).
P02-1038
Previous work has shown that it is useful to model target language order in terms of movement of syntactic constituents in constituency trees (Yamada and Knight, 2001; Galley et al., 2006) or dependency trees (Quirk et al., 2005), which are obtained using a parser trained to determine linguistic constituency.
P01-1067 P05-1034 P06-1121
Figure 1(b) shows several orders of the sentence which violate this constraint.1 Previous studies have shown that if both the source and target dependency trees represent linguistic constituency, the alignment between subtrees in the two languages is very complex (Wellington et al., 2006).
P06-1123
MT System Our baseline SMT system is the system of Quirk et al.(2005). It translates by first deriving a dependency tree for the source sentence and then translating the source dependency tree to a target dependency tree, using a set of probabilistic models.
P05-1034
The target dependency trees are obtained through projection of the source dependency trees, using the word alignment (we use GIZA++ (Och and Ney, 2004)), ensuring better parallelism of the source and target structures.
J04-4002
Many state-of-the-art SMT systems do not use trees and base the ordering decisions on surface phrases (Och and Ney, 2004; Al-Onaizan and Papineni, 2006; Kuhn et al., 2006).
J04-4002 N06-1004 P06-1067
The advantages of modeling how a target language syntax tree moves with respect to a source language syntax tree are that (i) we can capture the fact that constituents move as a whole and generally respect the phrasal cohesion constraints (Fox, 2002), and (ii) we can model broad syntactic reordering phenomena, such as subject-verb-object constructions translating into subject-object-verb ones, as is generally the case for English and Japanese.
W02-1039
