For example, while it is difficult to induce a grammar with raw text alone, the task is tractable when the syntactic analysis for each sentence is provided as a part of the training data (Pereira and Schabes 1992).
P92-1017
Pierce and Cardie (2001) have shown, in the context of base noun identification, that combining sample selection and cotraining can be an effective learning framework for large-scale training.
W01-0501
Portions of this work have appeared previously (Hwa 2000, 2001b); we thank the reviewers of those papers for their helpful comments.
W00-1306 W01-0710
Some well-known approaches include rule-based models (Brill and Resnik 1994), backed-off models (Collins and Brooks 1995), and a maximumentropy model (Ratnaparkhi 1998).
C94-2195 P98-2177 W95-0103
Similar approaches are being explored for parsing (Steedman, Hwa, et al.2003; Hwa et al.2003). 6.
E03-1008 N03-1031
The work of Sarkar (2001) and Steedman, Osborne, et al.(2003) suggests that co-training can be helpful for statistical parsing.
E03-1008 N01-1023 N03-1031
269 Hwa Sample Selection for Statistical Parsing 76 77 78 79 80 81 5000 10000 15000 20000 25000 30000 35000 40000 45000 Classification accuracy on the test set (%) Number of labeled brackets in the training set baseline length error driven tree entropy (a) 0 5,000 10,000 15,000 20,000 25,000 30,000 35,000 40,000 ba se li n e le ng t h er r or d r iven t r ee en t r op y Evaluation functions Number of Labeled Brackets in the Training Data (b) Figure 7 PLTIG parser: (a) A comparison of the evaluation functions’ learning curves.
W00-1306
Figure 6(d) is a bar graph comparing all the evaluation 263 Hwa Sample Selection for Statistical Parsing 74 76 78 80 82 84 86 0 5000 10000 15000 20000 Classification accuracy on the test set (%) Number of examples in the training set baseline novelty backoff 74 76 78 80 82 84 86 0 5000 10000 15000 20000 Classification accuracy on the test set (%) Number of examples in the training set baseline uncertainty confidence (a) (b) 74 76 78 80 82 84 86 0 5000 10000 15000 20000 Classification accuracy on the test set (%) Number of examples in the training set baseline area 0 5,000 10,000 15,000 20,000 25,000 ba se li n e no ve lty ba ckof f un ce rtai nty conf idence ar e a Evaluation Functions Number of Labeled Training Examples (c) (d) Figure 6 A comparison of the performance of different evaluation functions: (a) compares the learning curves of the functions that use knowledge about the problem space (f novel and f backoff ) with that of the baseline; (b) compares the learning curves of performance-based function (f unc and f conf ) with the baseline; (c) compares the learning curve of f area, which combines uncertainty and confidence, with f unc, f conf, and the baseline; (d) compares all the functions for the number of training examples selected at the final performance level (83.8%).
W00-1306
Some examples include text categorization (Lewis and Catlett 1994), base noun phrase chunking (Ngai and Yarowsky 2000), part-of-speech tagging (Engelson Dagan 1996), spelling confusion set disambiguation (Banko and Brill 2001), and word sense disambiguation (Fujii et al.1998). More challenging are learning problems whose objective is not classification, but generation of complex structures.
J98-4002 P00-1016 P01-1005 P96-1042
Current state-of-the-art statistical parsers (Collins 1999; Charniak 2000) are all trained on large annotated corpora such as the Penn Treebank (Marcus, Santorini, and Marcinkiewicz 1993).
A00-2018 J93-2004
A recent effort that focuses on statistical syntactic parsing is the work by Tang, Lou, and Roukos (2002).
P02-1016
Recent work by Tang, Luo, and Roukos (2002) suggests that a hybrid approach that combines features of the problem space and the uncertainty of the parser may result in better performance for lexicalized parsers.
P02-1016
In the first experiment, we use an induction algorithm (Hwa 2001a) based on the expectation-maximization (EM) principle that induces parsers for PLTIGs.
W01-0710
would be labeled as “((Several fund managers) (expect ((a rough market) (this morning)) (before (prices stabilize))).)” Our algorithm is similar to the approach taken by Pereira and Schabes (1992) for inducing PCFG parsers.
P92-1017
In the second experiment, the basic learning model is Collins’s (1997) Model 2 parser, which uses a history-based learning algorithm that takes statistics directly over the treebank.
P97-1003
271 Hwa Sample Selection for Statistical Parsing 78 80 82 84 86 88 100000 200000 300000 400000 500000 600000 700000 800000 900000 Classification accuracy on the test set (%) Number of labeled constituents in the training set baseline length novel lex error driven tree entropy (a) 0 100,000 200,000 300,000 400,000 500,000 600,000 700,000 800,000 ba se li n e no ve l le ng t h er r or d r iven t r ee en t r op y Evaluation Functions Number of Labeled Constituents in the Training Data (b) Figure 8 Model 2 parser: (a) A comparison of the learning curves of the evaluation functions.
W00-1306
Moreover, in order to determine whether the performances of the predictive criteria are consistent across different learning models within the same domain, we have performed the study on two parsing models: one based on a context-free variant of tree-adjoining grammars (Joshi, Levy, and Takahashi 1975), the Probabilistic Lexicalized Tree Insertion Grammar (PLTIG) formalism (Schabes and Waters 1993; Hwa 1998), and Collins’s Model 2 parser (1997).
P97-1003 P98-1091
