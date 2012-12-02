7Compare the systematic study for English-French alignments by (Fox, 2002), who compared (i) treebank-parser style analyses, (ii) a variant with flattened VPs, and (iii) dependency structures.
W02-1039
Fox. 2002.
W02-1039
(Gildea, 2003) and (Galley et al., 2004) discuss different ways of generalizing the tree-level crosslinguistic correspondence relation, so it is not confined to single tree nodes, thereby avoiding a continuity assumption.
N04-1035 P03-1011
As an alternative to the standard “rectangular indexing” approach 10The assumption here (following (Melamed, 2003)) is that lexicalization is not considered as just affecting the grammar constant, but that in parsing, every terminal symbol has to be considered as the potential head of every phrase of which it is a part.
N03-1021
Statistical alignments are imperfect – can the constraints imposed by the word alignment be relaxed accordingly without sacrificing tractability and the effect of indirect supervision?8 3 Alignment-guided synchronous parsing Our dynamic programming algorithm can be described as a variant of standard Earley-style chart parsing (Earley, 1970) and generation (Shieber, 1988; Kay, 1996).
C88-2128 P96-1027
The only requirement will be that a parallel corpus exist for the language under consideration and one or more other languages.2 Induction of grammars from parallel corpora is rarely viewed as a promising task in its own right; in work that has addressed the issue directly (Wu, 1997; Melamed, 2003; Melamed, 2004), the synchronous grammar is mainly viewed as instrumental in the process of improving the translation model in a noisy channel approach to statistical MT.3 In the present paper, we provide an important prerequisite for parallel corpus-based grammar induction work: an efficient algorithm for synchronous parsing of sentence pairs, given a word alignment.
J97-3002 N03-1021 P04-1083
(Shieber, 1988; Neumann, 1998)).
C88-2128
As (Melamed, 2003) discusses for instance, in the context of binary branching structures even simple examples like the English/French pair a gift for you from France ↔ un cadeau de France pour vouz [a gift from France for you] lead to discontinuity of a “synchronous phrase” in one of the two languages.
N03-1021
This work represents a second pilot study (after (Kuhn, 2004)) for the longer-term PTOLEMAIOS project at Saarland University4 with the goal of learning linguistic grammars from parallel corpora (compare (Kuhn, 2005)).
P04-1060
Graphically speaking, parsing amounts to identifying rectangular crosslinguistic constituents – by assembling smaller rectangles that will together cover the full string spans in both dimensions (compare (Wu, 1997; Melamed, 2003)).
J97-3002 N03-1021
(2) 〈X1/X2 → α • Y1:r1/Y2:r2 β, [i1, j1, i2, j2]〉, 〈Y1/Y2 → γ •, [j1, k1, j2, k2]〉 〈X1/X2 → α Y1:r1/Y2:r2 • β, [i1, k1, i2, k2]〉 (3) 〈X1/X2 → α • Y1:r1/Y2:r2 β, [i1, j1, j2, k2]〉, 〈Y1/Y2 → γ •, [j1, k1, i2, j2]〉 〈X1/X2 → α Y1:r1/Y2:r2 • β, [i1, k1, i2, k2]〉 Since each inference rule contains six free variables over string positions (i1, j1, k1, i2, j2, k2), we get a parsing complexity of order O(n6) for unlexicalized grammars (where n is the number of words in the longer of the two strings from language L1 and L2) (Wu, 1997; Melamed, 2003).
J97-3002 N03-1021
20While our simulation may be significantly slower than a direct implementation of the algorithm (especially when some of the optimizations discussed in (Melamed, 2003) are taken into account), the fact that it is orders of magnitude slower does in23 Finally, we also ran an experiment in which the continuity condition (condition (iii) in rule (4)) was deactivated, i.e., complete constituents were allowed to be discontinuous in one of the languages.
N03-1021
