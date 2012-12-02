Corpus The experiments use texts from the Wall Street Journ~d Corpus,and its partially bracketed version provided by the Penn Treebank (Brill et al., 1990).
H90-1055
Pereira and Schabes (1992) extended the inside-outside algorithm for inferring the parameters of a stochastic context-free grammar to take advantage of constituent bracketing information in the training text.
P92-1017
By taking adv~mtage of this fact in the implementation of the inside-outside ~dgorithm, its complexity becomes line~tr with respect to the input length (as noted by Pereira and Schabes, 1992),and therefore tractable for large corpora.
P92-1017
This enables us to take full adv~mtage of the fact that the extended inside-outside ~dgorithm (as described in Pereira and Schabes, 1992) behaves in linear time when the text is fully bracketed.
P92-1017
Baker (1979) describes a training algorithm for stochastic context-free grammars (SCFG) which can be used for grammar reestimation (Fujisaki et al.1989, Sharrnan et al.1990, Black et al.1992, Briscoe and Waegner 1992) or grammar inference from scratch (Lari and Young 1990).
P92-1024
the algorithm described in Pereira and Schabes (1992), the current rule probabilities and the parsed training set C are used to estimate the expected frequencies of each rule.
P92-1017
Implementation Pereira and Schabes (1992) note that the training,algorithm behaves in linear time (with respect to the sentence length) when the training material consists of fully bracketed sentences.
P92-1017
This percentage is called the bracketing accuracy (see Pereira and Schabes, 1992 tor the precise definition of this measure).
P92-1017
