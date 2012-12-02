Since deterministic dependency parsing has previously been shown to be competitive in terms of parsing accuracy (Yamada and Matsumoto, 2003; Nivre et al., 2004), we believe that this is a promising approach for situations that require parsing to be robust, efficient and (almost) incremental.
W04-2407
It is instructive at this point to make a comparison with incremental parsing based on extended categorial grammar, where the structures in (6–7) would normally be handled by some kind of concatenation (or product), which does not correspond to any real semantic combination of the constituents (Steedman, 2000; Morrill, 2000).
J00-3002
By contrast, parsers that only partially disambiguate the input — partial parsing — are usually deterministic and construct the final analysis in one pass over the input (Abney, 1991; Daelemans et al., 1999).
W99-0707
Parsers that attempt to disambiguate the input completely — full parsing — typically first employ some kind of dynamic programming algorithm to derive a packed parse forest and then applies a probabilistic top-down model in order to select the most probable analysis (Collins, 1997; Charniak, 2000).
A00-2018 P97-1003
In experiments reported in Nivre et al.(2004), a parsing accuracy of 85.7% (unlabeled attachment score) was achieved, using data from a small treebank of Swedish (Einarsson, 1976), divided into a training set of 5054 sentences and a test set of 631 sentences.
W04-2407
