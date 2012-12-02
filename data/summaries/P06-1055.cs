2Other techniques are also possible; Henderson (2004) uses neural networks to induce latent left-corner parser states.
P04-1013
Therefore, a variety of techniques have been developed to both enrich and generalize the naive grammar, ranging from simple tree annotation and symbol splitting (Johnson, 1998; Klein and Manning, 2003) to full lexicalization and intricate smoothing (Collins, 1999; Charniak, 2000).
A00-2018 J98-4004 P03-1054
Probabilistic context-free grammars (PCFGs) underlie most high-performance parsers in one way or another (Collins, 1999; Charniak, 2000; Charniak and Johnson, 2005).
A00-2018 P05-1022
Another contribution is that, unlike previous work, we investigate smoothed models, allowing us to split grammars more heavily before running into the oversplitting effect discussed in Klein and Manning (2003), where data fragmentation outweighs increased expressivity.
P03-1054
We focus particularly on connections with the linguistically motivated annotations of Klein and Manning (2003), which we do generally recover.
P03-1054
Here, it is interesting to note that these distinctions emerge in a predictable order (see Figure 2 for DT splits), beginning with the distinction between demonstratives and non-demonstratives, with the other distinctions emerging subsequently; this echoes the result of Klein and Manning (2003), where the authors chose to distinguish the demonstrative constrast, but not the additional ones learned here.
P03-1054
The second approximation that Matsuzaki et al.(2005) present is the Viterbi parse under a new sentence-specific PCFG, whose rule probabilities are given as the solution of a variational approximation of the original grammar.
P05-1010
human-interpretable. It shows most of the manually introduced annotations discussed by Klein and Manning (2003), but also learns other linguistic phenomena.
P03-1054
One category consists primarily of dates, whose typical parent is an NP subsymbol whose typical parent is a root S, essentially modeling the temporal noun annotation discussed in Klein and Manning (2003).
P03-1054
For instance, Matsuzaki et al.(2005) start by annotating their grammar with the identity of the parent and sibling, which are observed (i.e.
P05-1010
Since this method is not a contribution of this paper, we refer the reader to the fuller presentations in Goodman (1996) and Matsuzaki et al.(2005). Note that contrary to the original labelled recall algorithm, which maximizes the number of correct symbols, this tree only contains rules allowed by the grammar.
P05-1010 P96-1024
5If our purpose was only to model language, as measured for instance by perplexity on new text, it could make sense to erase even the labels of the Penn Treebank to let EM find better labels by itself, giving an experiment similar to that of Pereira and Schabes (1992).
P92-1017
Matsuzaki et al.(2005) discuss two approximations.
P05-1010
Like Matsuzaki et al.(2005) and Prescher (2005), we induce splits in a fully automatic fashion.
P05-1010
Rather than experiment with head-outward binarization as in Klein and Manning (2003), we simply used a left branching binarization; Matsuzaki et al.(2005) contains a comparison showing that the differences between binarizations are small.
P03-1054 P05-1010
≤ 40 words LP LR CB 0CB Klein and Manning (2003) 86.9 85.7 1.10 60.3 Matsuzaki et al.(2005) 86.6 86.7 1.19 61.1 Collins (1999) 88.7 88.5 0.92 66.7 Charniak and Johnson (2005) 90.1 90.1 0.74 70.1 This Paper 90.3 90.0 0.78 68.5 all sentences LP LR CB 0CB Klein and Manning (2003) 86.3 85.1 1.31 57.2 Matsuzaki et al.(2005) 86.1 86.0 1.39 58.3 Collins (1999) 88.3 88.1 1.06 64.0 Charniak and Johnson (2005) 89.5 89.6 0.88 67.6 This Paper 89.8 89.6 0.92 66.3 Table 4: Comparison of our results with those of others.
P03-1054 P05-1010 P05-1022
As one can see in Table 4, the resulting parser ranks among the best lexicalized parsers, beating those of Collins (1999) and Charniak and Johnson (2005).8 Its F1 performance is a 27% reduction in error over Matsuzaki et al.(2005) and Klein and Manning (2003).
P03-1054 P05-1010 P05-1022
Recently, Matsuzaki et al.(2005) and also Prescher (2005) exhibited an automatic approach in which each symbol is split into a fixed number of subsymbols.
P05-1010
Their algorithm is therefore the labelled recall algorithm of Goodman (1996) but applied to rules.
P96-1024
Another very important distinction, as shown in Klein and Manning (2003), is the various subdivisions in the preposition class (IN).
P03-1054
These posterior rule probabilities are still given by (1), but, since the structure of the tree is no longer known, we must sum over it when computing the inside and outside probabilities: PIN(r,t,Ax)= summationdisplay B,C,s summationdisplay y,z β(Ax → ByCz)× PIN(r,s,By)PIN(s,t,Cz) POUT(r,s,By)= summationdisplay A,C,t summationdisplay x,z β(Ax → ByCz)× POUT(r,t,Ax)PIN(s,t,Cz) POUT(s,t,Cz)= summationdisplay A,B,r summationdisplay x,y β(Ax → ByCz)× POUT(r,t,Ax)PIN(r,s,By) For efficiency reasons, we use a coarse-to-fine pruning scheme like that of Caraballo and Charniak (1998).
J98-2004
Matsuzaki et al.(2005) do not report a number of rules, but our small number of symbols and our hierarchical training (which 433 (a) FRAG RB Not NP DT this NN year. . (b) ROOT FRAG FRAG RB Not NP DT this NN year . . Figure 1: (a) The original tree.
P05-1010
On the other hand, oversplitting the grammar can be a serious problem, as detailed in Klein and Manning (2003).
P03-1054
mar in Matsuzaki et al.(2005). Our grammar’s accuracy was higher than fully lexicalized systems, including the maximum-entropy inspired parser of Charniak and Johnson (2005).
P05-1010 P05-1022
Klein and Manning (2003) addressed this question from a linguistic perspective, starting with a Markov grammar and manually splitting symbols in response to observed linguistic trends in the data.
P03-1054
4In other words, in the terminology of Klein and Manning (2003), they begin with a (vertical order=2, horizontal order=1) baseline grammar.
P03-1054
Their exciting result was that, while grammars quickly grew too large to be managed, a 16-subsymbol induced grammar reached the parsing performance of Klein and Manning (2003)’s manual grammar.
P03-1054
Charniak. 2000.
A00-2018
It allows us to go from 4 splits, equivalent to the 24 = 16 substates of Matsuzaki et al.(2005), to 6 SM iterations, which take a few days to run on the Penn Treebank.
P05-1010
As another example of a specific trend which was mentioned by Klein and Manning (2003), adverbs (RB) do contain splits for adverbs under ADVPs (also), NPs (only), and VPs (not).
P03-1054
The grammars recover patterns like those discussed in Klein and Manning (2003), heavily articulating complex and frequent categories like NP and VP while barely splitting rare or simple ones (see Section 3 for an empirical analysis).
P03-1054
Henderson. 2004.
P04-1013
In the Expectation step, one computes the posterior probability of each annotated rule and position in each training set tree T: P((r,s,t,Ax → ByCz)|w,T) ∝ POUT(r,t,Ax) ×β(Ax → ByCz)PIN(r,s,By)PIN(s,t,Cz) (1) In the Maximization step, one uses the above probabilities as weighted observations to update the rule probabilities: β(Ax → ByCz) := #{Ax → ByCz}summationtext y′,z′ #{Ax → By′Cz′} Note that, because there is no uncertainty about the location of the brackets, this formulation of the insideoutside algorithm is linear in the length of the sentence rather than cubic (Pereira and Schabes, 1992).
P92-1017
Other work has also investigated aspects of automatic grammar refinement; for example, Chiang and Bikel (2002) learn annotations such as head rules in a constrained declarative language for tree-adjoining grammars.
C02-1126
For example, after 4 SM cycles, the F1 scores of the 4 trained grammars have a variance of only 0.024, which is tiny compared to the deviation of 0.43 obtained by Matsuzaki et al.(2005)). Furthermore, these grammars allocate splits to nonterminals with a variance of only 0.32, so they agree to within a single latent state.
P05-1010
However, as demonstrated in Charniak (1996) and Klein and Manning (2003), a PCFG which simply takes the empirical rules and probabilities off of a treebank does not perform well.
P03-1054
Therefore, it would be to our advantage to split the latent annotations only where needed, rather than splitting them all as in Matsuzaki et al.(2005). In addition, if all symbols are split equally often, one quickly (4 split cycles) reaches the limits of what is computationally feasible in terms of training time and memory usage.
P05-1010
