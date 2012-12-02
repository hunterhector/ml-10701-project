Extending on the notion of a Base NP, introduced by Collins (1996), we mark any nonterminal that dominates only preterminals as Base.
P96-1025
Our results are not quite as good as those carefully created by hand, but they are close (84.8 vs 85.7). 1 Introduction and Previous Research It is by now commonplace knowledge that accurate syntactic parsing is not possible given only a context-free grammar with standard Penn Treebank (Marcus et al., 1993) labels (e.g., S, NP, etc).
J93-2004
In retrospect, however, there are perhaps even greater similarities to that of (Magerman, 1995; Henderson, 2003; Matsuzaki et al., 2005).
N03-1014 P05-1010 P95-1037
Collins. 1996.
P96-1025
Instead researchers condition parsing decisions on many other features, such as parent phrase-marker, and, famously, the lexical-head of the phrase (Magerman, 1995; Collins, 1996; Collins, 1997; Johnson, 1998; Charniak, 2000; Henderson, 2003; Klein and Manning, 2003; Matsuzaki et al., 2005) (and others).
A00-2018 J98-4004 N03-1014 P03-1054 P05-1010 P95-1037 P96-1025 P97-1003
Unfortunately, our model does not perform quite as well as those of Klein and Manning (2003) or Matsuzaki et al.(2005). It is worth noting that Matsuzaki’s grammar uses a different parse evaluation scheme than Klein & Manning or we do.
P03-1054 P05-1010
We perform this in a manner similar to Klein and Manning (2003) and Matsuzaki et al.(2005) through the creation of intermediate nodes, as in Figure 2.
P03-1054 P05-1010
Magerman. 1995.
P95-1037
Coming to this problem from the standpoint of tree transformation, we naturally view our work as a descendent of Johnson (1998) and Klein and Manning (2003).
J98-4004 P03-1054
We also always keep the heir label as a feature, following Klein and Manning (2003).
P03-1054
The Klein and Manning (2003) parser is an unlexicalized PCFG with various carefully selected context annotations.
P03-1054
Another Klein and Manning (2003) feature we try includes the temporal NP feature, where TMP markings in the treebank are retained, and propagated down the head inheritance path of the tree.
P03-1054
Klein and Manning (2003) find marking nonterminals which have unary rewrites to be helpful.
P03-1054
However, Klein and Manning (2003) find that this hurts performance relative to just marking the NPs, and so our Base feature does not insert.
P03-1054
This is exactly what is done by Klein and Manning (2003).
P03-1054
One particularly perspicuous way to view the use of extra conditioning information is that of tree-transformation (Johnson, 1998; Klein and Manning, 2003).
J98-4004 P03-1054
Consider the approach of Matsuzaki et al.(2005). They posit a series of latent annotations for each nonterminal, and learn a grammar using an EM algorithm similar to the inside-outside algorithm.
P05-1010
While this is not as accurate as the hand-tailored grammar of Klein and Manning (2003), it is close, and we believe there is room for improvement.
P03-1054
We do so by aligning the labels contained in the intermediate nodes in the order in which they would be added when increasing the markovization hori1The implementation we use was created by Mark Johnson and used for the research in (Johnson, 1998).
J98-4004
We have been impressed by the success of random-forest methods in language modeling (Xu and Jelinek, 2004).
W04-3242
Belz (2002) considers the problem in a manner more similar to our approach.
C02-1068
Klein and Manning (2003) use a horizon of two (or less, in some cases) which means only the next two labels to be expanded are retained.
P03-1054
Related to this, we further noticed that several of Klein & Manning’s (2003) features, such as marking NPs as right recursive or possessive have the property of annotating with the label of the rightmost child (when they are NP and POS respectively).
P03-1054
However, again in retrospect, it is in the work of Magerman (1995) that we see the greatest similarity.
P95-1037
Klein and Manning (2003) employ Collins’ (1999) horizontal markovization to desparsify their intermediate nodes.
P03-1054
As in (Johnson, 1998) and (Klein and Manning, 2003), we annotate the Penn treebank nonterminals with various context information.
J98-4004 P03-1054
In order to ease comparison between our work and that of Klein and Manning (2003), we follow their lead in smoothing no production probabilities save those going from preterminal to nonterminal.
P03-1054
Perhaps the best way to think about this problem is to contrast our work with that of Klein and Manning (2003).
P03-1054
