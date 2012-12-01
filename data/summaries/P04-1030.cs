However, if many iterations are required to obtain a parse, the utility of starting with a low beam and iterating becomes questionable (Goodman, 1997).
W97-0302
Roark (2002), when reviewing 2SCLITE (http://www.nist.gov/speech/ tools/) by NIST is the most commonly used alignment tool.
P02-1037
a0 section “1987” of the BLLIP corpus (Charniak et al., 1999) [20 million words] The BLLIP corpus is a collection of Penn Treebank-style parses of the three-year (1987-1989) Wall Street Journal collection from the ACL/DCI corpus (approximately 30 million words).6 The parses were automatically produced by the parser of Charniak (2001).
P01-1017
We achieve 73.2/76.5% LP/LR on section 23 of the Penn Treebank, compared to 82.9/82.4% LP/LR of Roark (2001) and 90.1/90.1% LP/LR of Charniak (2000).
A00-2018
3Parse trees are commonly scored with the PARSEVAL set of metrics (Black et al., 1991).
H91-1060
Hall and Johnson (2003) use a best-first probabilistic context free grammar (PCFG) to parse the input lattice, pruning to a set of local trees (candidate partial parse trees), which are then passed to a version of the parser of Charniak (2001) for more refined parsing.
P01-1017
Final testing was carried out on section 00, and the PARSEVAL measures (Black et al., 1991) were used to evaluate the performance.
H91-1060
Another contributing factor to the accuracy of Charniak (2001) is the size of the training set — 20M words larger than that used in this work.
P01-1017
The current best-performing models, in terms of WER, for the HUB-1 corpus, are the models of Roark (2001), Charniak (2001) (applied to n-best lists by Hall and Johnson (2003)), and the SLM of Chelba and Jelinek (2000) (applied to n-best lists by Xu et al.(2002)). However, n-best list parsing, as seen in our evaluation, requires repeated analysis of common subsequences, a less efficient process than directly parsing the word lattice.
A00-2018 P01-1017 P02-1025
Model n-best List/Lattice Training Size WER (%) SER (%) Oracle (50-best lattice) Lattice 7.8 Charniak (2001) List 40M 11.9 Xu (2002) List 20M 12.3 Roark (2001) (with EM) List 2M 12.7 Hall (2003) Lattice 30M 13.0 Chelba (2000) Lattice 20M 13.0 Current (α a1 1a6 16a0 β a1 1) List 20M 13.1 71.0 Current (α a1 1a6 16a0 β a1 1) Lattice 20M 13.1 70.4 Roark (2001) (no EM) List 1M 13.4 Lattice Trigram Lattice 40M 13.7 69.0 Current (α a1 1a6 16a0 β a1 1) List 1M 14.8 74.3 Current (α a1 1a6 16a0 β a1 1) Lattice 1M 14.9 74.0 Current (α a1 β a1 0) Lattice 1M 16.0 75.5 Treebank Trigram Lattice 1M 16.5 79.8 No language model Lattice 16.8 84.0 Table 3: Comparison of WER for parsing HUB-1 words lattices with best results of other works.
P01-1017 P02-1025
Charniak et al.(1998) introduce overparsing as a technique to improve parse accuracy by continuing parsing after the first complete parse tree is found.
W98-1115
Collins (1999) falls back to the POS tagging of Ratnaparkhi (1996) for words seen fewer than 5 times in the training corpus.
W96-0213
Hall (2003) is a lattice-parser related to Charniak (2001).
P01-1017
Xu et al.(2002) report inverse correlation between labelled precision/recall and WER.
P02-1025
Xu (2002) is an implementation of the model of Chelba (2000) for n-best list parsing.
P02-1025
As the tagger of Ratnaparkhi (1996) cannot tag a word lattice, we cannot back off to this tagging.
W96-0213
The difference in WER between our parser and those of Charniak (2001) and Roark (2001) applied to word lists may be due in part to the lower PARSEVAL scores of our system.
P01-1017
