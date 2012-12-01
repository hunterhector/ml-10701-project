of feature function It is non-trivial to define an appropriate feature function Φ(y) that has a good ability to distinguish the correct parse yi from all other candidates In early studies, the feature functions were given heuristically by simply preparing feature templates (Collins, 2000; Collins, 2002).
P02-1034 P02-1062
The tree kernel method of (Collins and Duffy, 2002) uses the all-subtrees representation and achieves 88.6%/88.9% recall and precision, which are slightly worse than the results obtained with our model.
P02-1034 P02-1062
The best known kernel for modeling a tree is the tree kernel (Collins and Duffy, 2002), which argues that a feature vector is implicitly composed of the counts of subtrees.
P02-1034 P02-1062
Even using the methods of (Bod, 2001), millions of subtrees are still exploited, which leads to inefficiency in real problems.
P01-1010
CO02=(Collins and Duffy, 2002).
P02-1034 P02-1062
BoostLoss is analogous to the boosting algorithm and is used in (Collins, 2000; Collins, 2002).
P02-1034 P02-1062
Parsing We used the same data set as the CoNLL 2000 shared task (Tjong Kim Sang and Buchholz, 2000).
W00-0726
To solve the problem efficiently, we now adopt a variant of the branch-and-bound algorithm, similar to that described in (Kudo and Matsumoto, 2004) 4.1 Efficient Enumeration of Trees Abe and Zaki independently proposed an efficient method, rightmost-extension, for enumerating all subtrees from a given tree (Abe et al., 2002; Zaki, 2002).
W04-3239
Our model achieves a 94.12 Fmeasure, and outperforms the baseline CRFs parser and the SVMs parser (Kudo and Matsumoto, 2001).
N01-1025
(Charniak, 2000) extends PCFG and achieves similar performance to (Collins, 2000).
A00-2018
(Bod, 2001) also uses the all-subtrees representation with a very different parameter estimation method, and realizes 90.06%/90.08% recall and precision for sentences of ≤ 40 words.
P01-1010
Collins et al.used RankBoost to parse reranking tasks (Collins, 2000; Collins, 2002).
P02-1034 P02-1062
With the DOP methods, (Bod, 2001) also employs constraints (e.g., depth of subtrees) to ¶We ran these tests on a Linux PC with Pentium 4 3.2 Ghz.
P01-1010
For example, tree kernel (Collins and Duffy, 2002), one of the convolution kernels, implicitly maps the instance represented in a tree into all-subtrees space.
P02-1034 P02-1062
In early studies, feature sets were given heuristically by simply preparing task-dependent feature templates (Collins, 2000; Collins, 2002).
P02-1034 P02-1062
As a baseline model, we used a shallow parser based on Conditional Random Fields (CRFs), very similar to that described in (Sha and Pereira, 2003).
N03-1028
CH00 = (Charniak, 2000), CO00=(Collins, 2000).
A00-2018
194 TOP NP PRP (L) I (R) VP VBD (L) saw (R) NP DT (L) a NN girl (R) EOS Figure 4: Tree representation for shallow parsing Represented in a right-branching tree with two virtual nodes MODEL Fβ=1 CRFs (baseline) 93.76 8 SVMs-voting (Kudo and Matsumoto, 2001) 93.91 RW + linguistic features (Zhang et al., 2002) 94.17 Boosting (our model) 94.12 Table 2: Results of shallow parsing Fβ=1 is the harmonic mean of precision and recall.
N01-1025
