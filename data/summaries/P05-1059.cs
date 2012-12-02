The ITG we apply in our experiments has more structural labels than the primitive bracketing grammar: it has a start symbol S, a single preterminal C, and two intermediate nonterminals A and B used to ensure that only one parse can generate any given word-level alignment, as discussed by Wu (1997) and Zens and Ney (2003).
J97-3002 P03-1019
Melamed (2003) presents algorithms for synchronous parsing with more complex grammars, discussing how to parse grammars with greater than binary branching and lexicalization of synchronous grammars.
N03-1021
λL1,L2 is the probability of any word alignment template for a pair of L1word source string and L2-word target string, which we model as a uniform distribution of word-forword alignment patterns after a Poisson distribution of target string’s possible lengths, following Brown et al.(1993). As an alternative, the summationtext operator can be replaced by the max operator as the inside operator over the translation probabilities above, meaning that we use the Model 1 Viterbi probability as our estimate, rather than the total Model 1 probability.2 A na¨ıve implementation would take O(n6) steps of computation, because there are O(n4) cells, each of which takes O(n2) steps to compute its Model 1 probability.
J93-2003
In including an estimate of the outside probability, our technique is related to A* methods for monolingual parsing (Klein and Manning, 2003), although our estimate is not guaranteed to be lower than complete outside probabity assigned by ITG.
N03-1016
Zens and Ney (2003) found that the constraints of ITG were a better match to the decoding task than the heuristics used in the IBM decoder of Berger et al.(1996). Zhang and Gildea (2004) found ITG to outperform the tree-to-string model for word-level alignment, as measured against human gold-standard alignments.
C04-1060 P03-1019
Wu (1997) demonstrated that for pairs of sentences that are less than 16 words, the ITG alignment space has a good coverage over all possibilities.
J97-3002
The Inversion Transduction Grammar (ITG) of Wu (1997) is a syntactically motivated algorithm for producing word-level alignments of pairs of translationally equivalent sentences in two languages.
J97-3002
For scoring the Viterbi alignments of each system against goldstandard annotated alignments, we use the alignment error rate (AER) of Och and Ney (2000), which measures agreement at the level of pairs of words: AER = 1 − |A∩GP| + |A∩GS||A| + |G S| where A is the set of word pairs aligned by the automatic system, GS is the set marked in the gold standard as “sure”, and GP is the set marked as “possible” (including the “sure” pairs).
P00-1056
In the tree-to-string model of Yamada and Knight (2001), a parse tree for one sentence of a translation pair is projected onto the other string.
P01-1067
Alshawi et al.(2000) use hierarchical finite-state transducers.
J00-1004
