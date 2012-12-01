Although the parser only derives projective graphs, the fact that graphs are labeled allows non-projective dependencies to be captured using the pseudoprojective approach of Nivre and Nilsson (2005). Another limitation of the parsing algorithm is that it does not assign dependency labels to roots, i.e., to tokens having HEAD=0.
P05-1013
• Support vector machines for mapping histories to parser actions (Kudo and Matsumoto, 2002).
W02-2016
• History-based feature models for predicting the next parser action (Black et al., 1992).
H92-1026
• Graph transformations for recovering nonprojective structures (Nivre and Nilsson, 2005).
P05-1013
We projectivize training data by a minimal transformation, lifting non-projective arcs one step at a time, and extending the arc label of lifted arcs using the encoding scheme called HEAD by Nivre and Nilsson (2005), which means that a lifted arc is assigned the label r↑h, where r is the original label and h is the label of the original head in the nonprojective dependency graph.
P05-1013
2.4 Pseudo-Projective Parsing Pseudo-projective parsing was proposed by Nivre and Nilsson (2005) as a way of dealing with non-projective structures in a projective data-driven parser.
P05-1013
Nivre. 2005.
P05-1013
All experiments have been performed using MaltParser (Nivre et al., 2006), version 0.4, which is made available together with the suite of programs used for preand post-processing.1 1www.msi.vxu.se/users/nivre/research/MaltParser.html 2 Parsing Methodology 2.1 Parsing Algorithm The parsing algorithm used for all languages is the deterministic algorithm first proposed for unlabeled dependency parsing by Nivre (2003) and extended to labeled dependency parsing by Nivre et al.(2004). The algorithm builds a labeled dependency graph in one left-to-right pass over the input, using a stack to store partially processed tokens and adding arcs using four elementary actions (where top is the token on top of the stack and next is the next token): • SHIFT: Push next onto the stack.
W04-2407
