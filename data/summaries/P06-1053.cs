A simple and principled approach to handling structure re-use would be to use adaptation probabilities for probabilistic grammar rules (Church, 2000), analogous to cache probabilities used in caching language models (Kuhn and de Mori, 1990).
C00-1027
As our goal is to create the simplest possible model which can nonetheless model experimental data, we do not make any tree modi cation designed to improve accuracy (as, e.g., Klein and Manning 2003).
P03-1054
A third approach is to calculate the forward probability (Stolcke, 1995) of the sentence using a PCFG.
J95-2002
While the effect is not always strong, we expect positive adaptation to be higher than negative adaptation (Dubey et al., 2005).
H05-1104
Therefore, we assume POS tags as input, using the gold-standard tags from the treebank (following, e.g., Roark and Johnson 1999).
P99-1054
If Prime is a binary-valued random variable denoting if a rule occurred in the context, then we de ne: P(RHS|LHS,Prime) = c(LHS → RHS,Prime)c(LHS,Prime) This is essentially an instantiation of Church’s (2000) adaptation probability, albeit with PCFG rules instead of words.
C00-1027
The merit of an edge is its inside probability times a prior P(LHS) times a lookahead probability (Roark and Johnson, 1999).
P99-1054
the RB1 model of Roark and Johnson, 1999).
P99-1054
This conclusion is strengthened when we turn to consider the performance of the parser on the standard Penn Treebank test set: the Within model showed a small increase in F-score over the PCFG baseline, while the copy model showed no such advantage.5 All the models we proposed offer a broadcoverage account of human parsing, not just a limited model on a hand-selected set of examples, such as the models proposed by Jurafsky (1996) and Hale (2001) (but see Crocker and Brants 2000).
N01-1021
Dubey et al.(2005) present a corpus study that demonstrates the existence of parallelism in corpus data.
H05-1104
An alternative is to keep track of all derivations, and predict dif culty at points where there is a large change in the shape of the probability distribution across adjacent parsing states (Hale, 2001).
N01-1021
Dubey et al.(2005) argue that the effect is simply an instance of a pervasive syntactic priming mechanism in human parsing.
H05-1104
Therefore, we use an Earley-style probabilistic parser, which outputs Viterbi parses (Stolcke, 1995).
J95-2002
