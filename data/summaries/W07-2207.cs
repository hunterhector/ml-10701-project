Research groups working within grammatical frameworks like CCG (Clark & Curran, 2004), LFG (Riezler et al., 2002), and HPSG (Malouf & van Noord, 2004; Oepen, Flickinger, Toutanova, & Manning, 2004; Miyao, Ninomiya, & Tsujii, 2005) have successfully integrated broad-coverage computational grammars with sophisticated statistical parse selection models.
P02-1035 P04-1014
subtrees of depth one) that make up the packed representation (Geman & Johnson, 2002), or has taken a more relaxed approach by allowing non-local prop57 Configuration Unifications Copies Hypotheses Space Unpack Total(#) (#) (#) (kbyte) (ms) (ms) greedy best-first 5980 1447 – 9202 – 400 selective, no caching 5535 1523 1245 27188 70 410 selective, with cache 4915 1522 382 27176 10 350 Table 5: Efficiency effects of the instantiation failure caching and propagation with GG, without grandparenting.
P02-1036
Parse selection approaches for these frameworks often use discriminative Maximum Entropy (ME) models, where the probability of each parse tree, given an input string, is estimated on the basis of select properties (called features) of the tree (Abney, 1997; Johnson, Geman, Canon, Chi, & Riezler, 1999).
J97-4005 P99-1069
In an almost contemporaneous study, but in the context of parsing with treebank grammars, Huang & Chiang (2005) develop a series of increasingly efficient algorithms for unpacking n-best results from a weighted hypergraph representing a parse forest.
W05-1506
Each such move is an application of the fundamental rule of chart parsing, combining an active and a passive edge, and the scores represent the expected ‘figure of merit’ (Caraballo & Charniak, 1998) of the resulting structure.
J98-2004
On the other hand, the same property prohibits the application of exact best-first techniques like A∗ search, because there is no reliable future cost estimate; in this respect, our set-up differs fundamentally from that of Klein & Manning (2003) and related PCFG parsing work.
N03-1016
Following (Johnson et al., 1999), a conditional ME model of the probabilities of trees {t1...tn} for a string s, and assuming a set of feature functions {f1 ...fm} with corresponding weights {λ1 ...λm}, is defined as: p(ti|s) = exp summationtext j λjfj(ti)summationtext n k=1 exp summationtext j λjfj(tk) (1) 2This property of parse forests is not a prerequisite of the chart parsing framework.
P99-1069
A balance point between efficiency 5The models were trained using the open-source TADM package (Malouf, 2002), using default hyper-parameters for all configurations, viz.
W02-2018
The algorithm of Carroll & Oepen (2005) and the final one of Huang & Chiang (2005) are essentially equivalent, and turn out to be reformulations of an approach originally described by Jim´enez & Marzal (2000) (although expressed there only for grammars in Chomsky Normal Form).
W05-1506
