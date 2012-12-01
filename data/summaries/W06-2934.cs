c©2006 Association for Computational Linguistics Multi-lingual Dependency Parsing with Incremental Integer Linear Programming Sebastian Riedel and Ruket C¸ akıcı and Ivan Meza-Ruiz ICCS School of Informatics University of Edinburgh Edinburgh, EH8 9LW, UK S.R.Riedel,R.Cakici,I.V.Meza-Ruiz@sms.ed.ac.uk Abstract Our approach to dependency parsing is based on the linear model of McDonald et al.(McDonald et al., 2005b).
H05-1066 P05-1012
The first feature set, BASELINE, is taken from McDonald and Pereira (2005b).
H05-1066 P05-1012
In the implementation1 of McDonald et al.(2005b) dependency labels are handled by finding the best scoring label for a given token pair so that s(i,j) = max s(i,j,label) goes into Equation 1.
H05-1066 P05-1012
This framework is efficient for both projective and non-projective parsing and provides an online learning algorithm which combined with a rich feature set creates state-of-the-art performance across multiple languages (McDonald and Pereira, 2006).
E06-1011
In this work we presented a novel way of solving the linear model of McDonald et al.(2005a) for projective and non-projective parsing based on an incremental ILP approach.
H05-1066 P05-1012
Instead of using the MST algorithm (McDonald et al., 2005b) to maximise equation 1, we present an equivalent ILP formulation of the problem.
H05-1066 P05-1012
However, McDonald and Pereira (2006) mention the restrictive nature of this parsing algorithm.
E06-1011
Our parser is inspired by McDonald et al.(2005a) which treats the task as the search for the highest scoring Maximum Spanning Tree (MST) in a graph.
H05-1066 P05-1012
Our model is based on the linear model presented in McDonald et al.(2005a), s(x,y) = summationdisplay (i,j)∈y s(i,j) =summationdisplayw ·f (i,j)(1) where x is a sentence, y a parse and s a score function over sentence-parse pairs.
H05-1066 P05-1012
