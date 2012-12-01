Chiang’s model adds a third composition operation called sister-adjunction (see Figure 3), borrowed from D-tree substitution grammar (Rambow et al., 1995).2 There is an important distinction between derived trees and derivation trees (see Figure 3).
P95-1021
Most work in statistical parsing does not operate in the realm of parse trees as they appear in many treebanks, but rather on trees transformed via augmentation of their node labels, or some other transformation (Johnson, 1998).
J98-4004
It then computes inside and outside probabilities as in Hwa’s experiment (1998), and uses these to compute the expected number of times each event occurred.
P98-1091
Other researchers investigated this type of extraction to construct stochastic TAG parsers (Chiang, 2000; Chen and Vijay-Shanker, 2000; Sarkar, 2001).
N01-1023 P00-1058
TIG (Schabes and Waters, 1995) is a weakly-context free restriction of tree adjoining grammar (Joshi and Schabes, 1997), in which tree fragments called elementary trees are combined by two composition operations, substitution and adjunction (see Figure 3).
J95-4002
by Chiang (2000).
P00-1058
For Penn Treebank II style annotation (Marcus et al., 1993), in which a nonterminal symbol is a category together with zero or more functional tags, we adopt the following scheme: the atomic pattern a matches any label with category a or functional tag a; moreover, we define Boolean operators^,_, and:.
J93-2004
criminative models described in (Magerman, 1995; Ratnaparkhi, 1997), the lexicalized PCFG models in (Collins, 1999), the generative model in (Charniak, 2000), the lexicalized TAG extractor in (Xia, 1999) and the stochastic lexicalized TAG models in (Chiang, 2000; Sarkar, 2001; Chen and VijayShanker, 2000).
A00-2018 N01-1023 P00-1058 P95-1037 W97-0301
For example, in the rule sets used by the parsers described in (Magerman, 1995; Ratnaparkhi, 1997; Collins, 1999), the sets of rules for finding the heads of ADJP, ADVP, NAC, PP and WHPP include rules for picking either the rightmost or leftmost FW (foreign word).
P95-1037 W97-0301
As explored thoroughly by Johnson (1998), even simple, local syntactic transformations on training trees for an unlexicalized PCFG model can have a significant impact on parsing performance.
J98-4004
The third experiment was on the Chinese Treebank, starting with the same head rules used in (Bikel and Chiang, 2000).
P00-1058 W00-1201
Smoothed estimates for parameters in this class are computed as follows: e= 1e1+(1 1)( 2e2+(1 2)e3) where ei is the estimate of p(X j i(Y)) for some future context X, and the i are computed by the formula found in (Bikel et al., 1997), modified to use the multiplicative constant 5 found in the similar formula of (Collins, 1999): i = 1 di 1d i ! 1 1+5ui=di ! (7) where di is the number of occurrences in training of the context i(Y) (and d0 =0), and ui is the number of unique outcomes for that context seen in training.
A97-1029
Specifically, the EM algorithm we use is a variant of the Inside-Outside algorithm (Baker, 1979; Lari and Young, 1990; Hwa, 1998).
P98-1091
