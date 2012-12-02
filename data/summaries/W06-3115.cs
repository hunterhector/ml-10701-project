For each differently tokenized corpus, we computed word alignments by a HMM translation model (Och and Ney, 2003) and by a word alignment refinement heuristic of “grow-diagfinal” (Koehn et al., 2003).
J03-1002 N03-1017 P03-1021
When decoding, the denominator is dropped since it depends only on f J1. Feature function scaling factors λm are optimized based on a maximum likelihood approach (Och and Ney, 2002) or on a direct error minimization approach (Och, 2003).
J03-1002 P02-1038 P03-1021
In a phrase-based statistical translation (Koehn et al., 2003), a bilingual text is decomposed as K phrase translation pairs (¯e1, ¯f¯a1), (¯e2, ¯f¯a2 ),...: The input foreign sentence is segmented into phrases ¯f K1, 122 mapped into corresponding English ¯eK1, then, reordered to form the output English sentence according to a phrase alignment index mapping ¯a.
N03-1017
In a hierarchical phrase-based translation (Chiang, 2005), translation is modeled after a weighted synchronous-CFG consisting of production rules whose right-hand side is paired (Aho and Ullman, 1969): X → 〈γ,α,∼〉 where X is a non-terminal, γ and α are strings of terminals and non-terminals.
P05-1033
The decoding process is very similar to those described in (Koehn et al., 2003): It starts from an initial empty hypothesis.
N03-1017
In the hierarchical phrase-based model, production rules are accumulated by computing “holes” for extracted contiguous phrases (Chiang, 2005): 1.
P05-1033
The other is a hierarchical phrase-based translation in which translation is realized as a set of paired production rules (Chiang, 2005).
P05-1033
Models We used a log-linear approach (Och and Ney, 2002) in which a foreign language sentence f J1 = f1, f2,... fJ is translated into another language, i.e.
P02-1038
One is a phrase-based translation in which a phrasal unit is employed for translation (Koehn et al., 2003).
N03-1017
2.1 Phrase/Rule Extraction The phrase extraction algorithm is based on those presented by Koehn et al.(2003). First, manyto-many word alignments are induced by running a one-to-many word alignment model, such as GIZA++ (Och and Ney, 2003), in both directions and by combining the results based on a heuristic (Och and Ney, 2004).
J03-1002 J04-4002 N03-1017 N04-1021 P03-1021
Second, phrase translation pairs are extracted from the word aligned corpus (Koehn et al., 2003).
N03-1017
Functions Our phrase-based model uses a standard pharaoh feature functions listed as follows (Koehn et al., 2003): • Relative-count based phrase translation probabilities in both directions.
N03-1017
For details, please refer to Koehn et al.(2003). In addition, we added three feature functions to restrict reorderings and to represent globalized insertion/deletion of words: • Lexicalized reordering feature function scores whether a phrase translation pair is monotonically translated or not (Och et al., 2004): hlex(¯aK1 | ¯f K1, ¯eK1 ) = log Kproductdisplay k=1 pr(δk| ¯f¯ak, ¯ek) (3) where δk = 1 iff ¯ak − ¯ak−1 = 1 otherwise δk = 0.
J04-4002 N03-1017 N04-1021
In the hierarchical phrase-based model, decoding is realized as an Earley-style top-down parser on the foreign language side with a beam search strategy synchronized with the cardinality of already translated foreign words (Watanabe et al., 2006).
P06-1098
