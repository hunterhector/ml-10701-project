However, modeling complete bilingual bilexical dependencies as theorized in Melamed (2003) implies a huge parameter space of O(|V |2|T|2), where |V | and |T| are the vocabulary sizes of the two languages.
N03-1021
The two levels of distributions are interpolated using a technique inspired by Witten-Bell smoothing (Chen and Goodman, 1996).
P96-1041
Our results also echo the ndings of Kuhn (2004).
P04-1060
The probability of the tree is the product rule probabilities at each node: P(S → A) · P(A → [C B]) · P(C → I/Je) · P(B → 〈C C〉) · P(C → see/vois) · P(C → them/les) The structural constraint of ITG, which is that only binary permutations are allowed on each level, has been demonstrated to be reasonable by Zens and Ney (2003) and Zhang and Gildea (2004).
C04-1060 P03-1019
The trick of reducing interacting variables in DP for bilexical parsing has been pointed out by Eisner and Satta (1999).
P99-1059
For scoring the Viterbi alignments of each system against gold-standard annotated alignments, we use the alignment error rate (AER) of Och and Ney (2000), which measures agreement at the level of pairs of words: AER = 1 − |A ∩ GP| + |A ∩ GS||A| + |G S| where A is the set of word pairs aligned by the automatic system, GS is the set marked in the gold standard as sure, and GP is the set marked as possible (including the sure pairs).
P00-1056
In this paper we focus on the second issue, constraining the grammar to the binary-branching Inversion Transduction Grammar of Wu (1997).
J97-3002
and Smoothing We apply one of the pruning techniques used in Zhang and Gildea (2005).
P05-1059
953 2 Bilexicalization of Inversion Transduction Grammar The Inversion Transduction Grammar of Wu (1997) models word alignment between a translation pair of sentences by assuming a binary synchronous tree on top of both sides.
J97-3002
The new model, which bilexicalizes within languages, allows us to use the hook trick (Eisner and Satta, 1999) and therefore reduces complexity.
P99-1059
Synchronous grammar formalisms that are capable of modeling such complex relationships while maintaining the context-free property in each language have been proposed for many years, (Aho and Ullman, 1972; Wu, 1997; Yamada and Knight, 2001; Melamed, 2003; Chiang, 2005), but have not been scaled to large corpora and long sentences until recently.
J97-3002 N03-1021 P01-1067 P05-1033
Melamed (2003) discussed the applicability of the so-called hook trick for parsing bilexical multitext grammars.
N03-1021
In the rst comparison, we measured the performance of ve word aligners, including IBM models, ITG, the lexical ITG (LITG) of Zhang and Gildea (2005), and our bilexical ITG (BLITG), on a hand-aligned bilingual corpus.
P05-1059
2.1 Cross-Language Bilexicalization Zhang and Gildea (2005) described a model in which the nonterminals are lexicalized by English and foreign language word pairs so that the inversions are dependent on lexical information on the left hand side of synchronous rules.
P05-1059
Lexicalization seems likely to help models predict alignment patterns between languages, and has been proposed by Melamed (2003) and implemented by Alshawi et al.(2000) and Zhang and Gildea (2005).
J00-1004 N03-1021 P05-1059
To make more con dent conclusions, we also did tests on a larger hand-aligned data set used in Liu et al.(2005). We used 165 sentence pairs that are up to 25 words in length on both sides.
P05-1057
