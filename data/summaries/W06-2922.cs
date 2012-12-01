J. Nivre, et al.2004. Memory-based Dependency Parsing.
C04-1010 W04-2407
Kudo and Matsumoto (2002) report a two week learning time on a Japanese corpus of about 8000 sentences with SVM.
W02-2016
S. Buchholz, et al.2006. CoNLL-X Shared Task on Multilingual Dependency Parsing.
W06-2920
For details on the CoNLL-X shared task and the measurements see (Buchholz, et al.2006). 6 Experiments I performed several experiments to tune the parser.
W06-2920
Portuguese, training required over 4 days but produced a bad model which could not be used (I tried both the TinySVM (Kudo 2002) and the LIBSVM (Chang and Lin 2001) implementations).
W02-2016
4 Non-Projective Relations For handling non-projective relations, Nivre and Nilsson (2005) suggested applying a preprocessing step to a dependency parser, which consists in lifting non-projective arcs to their head repeatedly, until the tree becomes pseudo-projective.
P05-1013
R. McDonald, et al.2005. Non-projective Dependency Parsing using Spanning Tree Algorithms.
H05-1066
Using Maximum Entropy (Berger, et al.1996) classifiers I built a parser that achieves a throughput of over 200 sentences per second, with a small loss in accuracy of about 23 %.
J96-1002
Recently statistical dependency parsing techniques have been proposed which are deterministic and/or linear (Yamada and Matsumoto, 2003; Nivre and Scholz, 2004).
C04-1010 W04-2407
