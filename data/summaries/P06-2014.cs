They model operations that are meaningful at a syntax level, like re-ordering children, but ignore features that have proven useful in IBM models, such as the preference to align words with similar positions, and the HMM preference for links to appear near one another (Vogel et al., 1996).
C96-2141
The IBM models (Brown et al., 1993) benefit from a one-tomany constraint, where each target word has ex105 the tax causes unrest l' impôt cause le malaise Figure 1: A cohesion constraint violation.
J93-2003
English dependency trees are provided by Minipar (Lin, 1994).
C94-1079
Fox (2002) measured phrasal cohesion in gold standard alignments by counting crossings.
W02-1039
Originally introduced as a byproduct of training statistical translation models in (Brown et al., 1993), word alignment has become the first step in training most statistical translation systems, and alignments are useful to a host of other tasks.
J93-2003
For evaluation we compare to the remaining 347 gold standard pairs using the alignment evaluation metrics: precision, recall and alignment error rate or AER (Och and Ney, 2003).
J03-1002
(Moore, 2005) uses an averaged perceptron for training with a customized beam search.
H05-1011
Recently, discriminative learning technology for structured output spaces has enabled several discriminative word alignment solutions (Liu et al., 2005; Moore, 2005; Taskar et al., 2005).
H05-1010 H05-1011 P05-1057
d is an absolute discount parameter as in (Moore, 2005).
H05-1011
Our work borrows heavily from (Taskar et al., 2005), which uses a max-margin approach with a weighted maximum matching aligner.
H05-1010
In our French-English data set, an ITG rules out only 0.3% of necessary links beyond those already eliminated by the one-to-one constraint (Cherry and Lin, 2006).
E06-1019
Others parse one of the two strings before alignment begins, and align the resulting tree to the remaining string (Yamada and Knight, 2001).
P01-1067
Fortunately, Wu (1997) provides a method to have an ITG respect a known partial structure.
J97-3002
The first baseline, matching is the matching SVM described in Section 4.2.1, which is a re-implementation of the state-of-theart work in (Taskar et al., 2005)3.
H05-1010
Our training set for the discriminative aligners is the first 100 sentence pairs from the FrenchEnglish gold standard provided for the 2003 WPT workshop (Mihalcea and Pedersen, 2003).
W03-0301
Wu (1997) provides anecdotal evidence that only incorrect alignments are eliminated by ITG constraints.
J97-3002
(Gildea, 2003) presents another aligner with a soft syntactic constraint.
P03-1011
To create a matching alignment solution, we reproduce the approach of (Taskar et al., 2005) within the framework described in Section 4.1: 1.
H05-1010
The SD-ITG achieves by far the strongest ITG alignment result reported on this French-English set; surpassing the 0.16 AER reported in (Zhang and Gildea, 2004).
C04-1060
However, as Fox (2002) showed, even in a language pair as close as French-English, there are situations where phrasal cohesion should not be maintained.
W02-1039
In (Zhang and Gildea, 2004), this model was tested on the same annotated French-English sentence pairs that we divided into training and test sets for our experiments; it achieved an AER of 0.15. 7 Conclusion We have presented a discriminative, syntactic word alignment method.
C04-1060
Note that this will not search the exact same alignment space as a cohesion-constrained beam search; instead it uses the union of the cohesion constraint and the weaker ITG constraints (Cherry and Lin, 2006).
E06-1019
IBM Models 1 and 2, HMM (Vogel et al., 1996), and weighted maximum matching alignment all conduct complete searches, but they would not be amenable to monitoring the syntactic interactions of links.
C96-2141
The gold standard is divided into sure and possible link sets S and P (Och and Ney, 2003).
J03-1002
Gildea. 2003.
P03-1011
Fox. 2002.
W02-1039
Cherry and Lin (2003) use the phrasal cohesion of a dependency tree as a constraint on a beam search aligner.
P03-1012
(Liu et al., 2005) uses a log-linear model with a greedy search.
P05-1057
The Inversion Transduction Grammar or ITG formalism, described in (Wu, 1997), is well suited for our purposes.
J97-3002
The first thing to note is that our Matching baseline is achieving scores in line with (Taskar et al., 2005), which reports an AER of 0.107 using similar features and the same training and test sets.
H05-1010
The tree-to-string models of (Yamada and Knight, 2001) naturally consider syntax, but special modeling considerations are needed to allow any deviations from the provided tree (Gildea, 2003).
P01-1067 P03-1011
Melamed. 2000.
J00-2004
3. We adopt the weighted Hamming loss in described (Taskar et al., 2005): ∆(y,¯y) = co|y−¯y|+cc|¯y−y| where co is an omission penalty and cc is a commission penalty.
H05-1010
Some methods parse two flat strings at once using a bitext grammar (Wu, 1997).
J97-3002
Methods like competitive linking (Melamed, 2000) and maximum matching (Taskar et al., 2005) use a one-toone constraint, where words in either sentence can participate in at most one link.
H05-1010 J00-2004
The second baseline, D-ITG is an ITG aligner with hard cohesion constraints, but which uses the weights 3Though it is arguably lacking one of its strongest features: the output of GIZA++ (Och and Ney, 2003) Table 2: The performance of SVM-trained aligners with various degrees of cohesion constraint.
J03-1002
The dominant IBM alignment models (Och and Ney, 2003) use minimal linguistic intuitions: sentences are treated as flat strings.
J03-1002
This work adds a cloning operation to the tree-to-string generative model in (Yamada and Knight, 2001).
P01-1067
To measure correlation between Ej and Fk we use conditional link probability (Cherry and Lin, 2003) in place of the Dice coefficient: cor(Ej,Fk) = #links(Ej,Fk)−d#cooccurrences(E j,Fk) where the link counts are determined by wordaligning 50K sentence pairs with another matching SVM that uses the φ2 measure (Gale and 109 Church, 1991) in place of Dice.
H91-1026 P03-1012
Though Tsochantaridis et al.(2004) provide several ways to incorporate loss into the SVM objective, we will use margin re-scaling, as it corresponds to loss usage in another max-margin alignment approach (Taskar et al., 2005).
H05-1010
We use the same feature representation ψ(l) as (Taskar et al., 2005), with some small exceptions.
H05-1010
