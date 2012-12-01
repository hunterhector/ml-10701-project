This was handled by a slight variant of the Katz procedure (Dagan, Pereira, and Lee, 1994) in which the mixedorder model substituted for the backoff model.
P94-1038
This demonstrates the utility of allowing "soft" membership classes: for most words, the maximum likelihood estimates of P(clw ) do not correspond to a winner-take-all assignment, and therefore any method that assigns each word to a single class ("hard" clustering), such as those used by Brown et al.(1992) or Ney, Essen, and Kneser (1994), would lose information.
J92-4003
Aggregate models based on higher-order n-grams (Brown et al., 1992) might be able to capture multi-word structures such as noun phrases.
J92-4003
82 2 Aggregate Markov models In this section we consider how to construct classbased bigram models (Brown et al., 1992).
J92-4003
In practice, one adjusts or smoothes (Chen and Goodman, 1996) the ML estimates so that the language model can generalize to new phrases.
P96-1041
In Section 2, we examine aggregate Markov models, or class-based bigram models (Brown et al., 1992) in which the mapping from words to classes 81 is probabilistic.
J92-4003
Though several algorithms (Brown et al., 1992; Pereira, Tishby, and Lee, 1993) have been proposed 100( 9o( 80( 4O( 20( 1000 goo 80~ 41111 2@ 5 10 15 20 25 30 5 10 15 20 25 30 iteration of EM iteration of EM (a) (b) Figure 1: Plots of (a) training and (b) test perplexity versus number of iterations of the EM algorithm, for the aggregate Markov model with C = 32 classes.
J92-4003 P93-1024
