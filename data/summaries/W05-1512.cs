(2005) 86.6 86.7 1.19 Klein and Manning (2003) 86.9 85.7 86.3 30.9 1.10 Charniak (1997) 87.4 87.5 1.00 Collins (1997) 88.6 88.1 0.91 Table 3: Comparison with other parsers (sentences of length ≤ 40) as head information.
P03-1054 P97-1003
Recently, Klein and Manning (2003) showed that a carefully performed linguistic mark-up of the treebank leads to almost the same performance results as lexicalization.
P03-1054
Lexicalization As previously shown (Charniak (1997), Collins (1997), Carroll and Rooth (1998), etc.), ContextFree Grammars (CFGs) can be transformed to lexicalized CFGs, provided that a head-marking scheme for rules is given.
P97-1003
It is a bit worse than the unlexicalized PCFGs of Klein and Manning (2003) and Matsuzaki et al.(2005), and of course, it is also worse than state-of-the-art lexicalized parsers (experience shows that evaluation results on sections 22 and 23 do not differ much).
P03-1054 P05-1010
Estimation from most probable heads: By contrast, a quite different scheme is applied in Klein and Manning (2003): extensive manual annotation enriches the tree-bank with information, but no trees are added to the tree-bank.
P03-1054
Matsuzaki et al.(2005) independently introduce a similar approach and present empirical results that rival ours.
P05-1010
This result is attractive since unlexicalized grammars are easy to estimate, easy to parse with, and timeand space-efficient: Klein and Manning (2003) do not smooth grammar-rule probabilities, except unknown-word probabilities, and they do not prune since they are able to determine the most probable parse of each full parse forest.
P03-1054
It turns out, however, that lexicalization is not unproblematic: First, there is evidence that full lexicalization does not carry over across different tree-banks for other languages, annotations or domains (Dubey and Keller, 2003).
P03-1013
Comparison indicates that our best model is already better than the early lexicalized model of Magerman (1995).
P95-1037
For parsing, we mapped all unknown words to unknown word symbols, and applied the Viterbi algorithm as implemented in Schmid (2004), exploiting its ability to deal with highly-ambiguous grammars.
C04-1024
The average parsing time is 10 seconds per sentence, which is comparable to what is reported in Klein and Manning (2003).
P03-1054
Data and Parameters To facilitate comparison with previous work, we trained our models on sections 2-21 of the WSJ section of the Penn tree-bank (Marcus et al., 1993).
J93-2004
It thus complements and extends the approach of Chiang and Bikel (2002), who aim at discovering latent head markers in tree-banks to improve manually written head-percolation rules.
C02-1126
With automatic refinement it is harder to guarantee improved performance than with manual refinements (Klein and Manning, 2003) or with refinements based on direct lexicalization (Magerman (1995), Collins (1996), Charniak (1997), etc.).
P03-1054 P95-1037 P96-1025 P97-1003
This is in sharp contrast to the smoothed fixed-word statistics in most lexicalized parsing models derived from sparse data (Magerman (1995), Collins (1996), Charniak (1997), etc.).
P95-1037 P96-1025 P97-1003
By contrast, alternative approaches, like Collins (1997), apply an additional transformation to each tree in the tree-bank, splitting each rule into small parts, which finally results in a new grammar covering many more sentences than the explicit one.
P97-1003
The most important tree-bank transformation in the literature is lexicalization: Each node in a tree is labeled with its head word, the most important word of the constituent under the node (Magerman (1995), Collins (1996), Charniak (1997), Collins (1997), Carroll and Rooth (1998), etc.).
P95-1037 P96-1025 P97-1003
Magerman. 1995.
P95-1037
Table 2 displays our results in terms of LP/LR F1 (Black and al., 1991).
H91-1060
In contrast, manual linguistic mark-up of the tree-bank like in Klein and Manning (2003) is based on individual linguistic intuition and might be cost and time intensive.
P03-1054
Although coarse-grained models clearly benefit from POS information in the heads (L = 1,2,5), it is surprising that the best models with completely latent heads are on a par with or almost as good as the best ones using POS 122 LP LR F1 Exact CB Model 1 (this paper) 84.8 84.4 84.6 26.4 1.37 Magerman (1995) 84.9 84.6 1.26 Model 2 (this paper) 85.7 85.7 85.7 29.3 1.29 Collins (1996) 86.3 85.8 1.14 Matsuzaki etal.
P95-1037 P96-1025
