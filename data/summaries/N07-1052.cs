Parsing optimally relative to a synchronous grammar using a dynamic program requires time O(n6) in the length of the sentence (Wu, 1997).
J97-3002
We demonstrate our technique using the synchronous grammar formalism of tree-to-tree transducers (Knight and Graehl, 2004).
N04-1014
This epsilon1-admissible heuristic (Ghallab and Allard, 1982) bounds our search error by L∗γ−max.3 3 Bitext Parsing In bitext parsing, one jointly infers a synchronous phrase structure tree over a sentence ws and its translation wt (Melamed et al., 2004; Wu, 1997).
J97-3002 P04-1084
As a result, most work on search has focused on non-optimal methods, such as beam search or pruning based on approximate models (Collins, 1999), though in certain cases admissible heuristics are known (Och and Ney, 2000; Zhang and Gildea, 2006).
P00-1056 W06-1627
Zhang and Gildea (2006) offer a different heuristic for A∗ parsing of ITG grammars that provides a forward estimate of the cost of aligning the unparsed words in both sentences.
W06-1627
Given such a model, both our optimization heuristic and the lexical heuristic of Zhang and Gildea (2006) can be computed independently.
W06-1627
Following Galley et al.(2004), we learn a grammar by projecting English syntax onto a foreign language via word-level alignments, as in figure 3(b).7 We parsed 1200 English-Spanish sentences using a grammar learned from 40,000 sentence pairs of the English-Spanish Europarl corpus.8 Figure 4(a) shows that A∗ expands substantially fewer states while searching for the optimal parse with our op7The bilingual corpus consists of translation pairs with fixed English parses and word alignments.
N04-1035
