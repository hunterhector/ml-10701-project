In order to make the results directly comparable, we produced POS tags as the input of our parsers by using a POS tagger (Tsuruoka and Tsujii, 2005) which was trained on sections 0-18 in the WSJ corpus.
H05-1059
Since many researchers have reported that information on partial parse trees plays an important role for achieving high performance (Bod, 1992; Collins and Duffy, 2002; Kudo et al., 2005), we expect that additional features will improve the performance of chunk parsing.
P02-1034 P05-1024
For this purpose, we use the maximum entropy modeling with inequality constraints (Kazama and Tsujii, 2003).
W03-1018
The head word is identified by using the head-percolation table (Magerman, 1995).
P95-1037
of machine learning techniques that have been developed for sequence labeling problems such as Hidden Markov Models, sequential classification with SVMs (Kudo and Matsumoto, 2001), and Conditional Random Fields (Sha and Pereira, 2003).
N01-1025 N03-1028
parsing We also tried an iterative parsing strategy, which was successfully used in probabilistic HPSG parsing (Ninomiya et al., 2005).
W05-1511
Recognition with a Maximum Entropy Classifier For the candidates which are not filtered out in the above two phases, we perform classification with maximum entropy classifiers (Berger et al., 1996).
J96-1002
Sang used the IOB tagging method proposed by Ramshow(Ramshaw and Marcus, 1995) and memory-based learning for each level of chunking and achieved an f-score of 80.49 on the Penn Treebank corpus.
W95-0107
LR LP F-score Ratnaparkhi (1997) 86.3 87.5 86.9 Collins (1999) 88.1 88.3 88.2 Charniak (2000) 89.6 89.5 89.5 Kudo (2005) 89.3 89.6 89.4 Sang (2001) 78.7 82.3 80.5 Deterministic (tagger-POSs) 81.2 86.5 83.8 Deterministic (gold-POSs) 82.6 87.7 85.1 Search (tagger-POSs) 83.2 87.1 85.1 Search (gold-POSs) 84.6 88.5 86.5 Iterative Search (tagger-POSs) 85.0 86.8 85.9 Iterative Search (gold-POSs) 86.2 88.0 87.1 Table 6: Comparison with other work.
A00-2018 N01-1025 P05-1024 W97-0301
However, there is a very large gap between their performance and that of widely-used practical parsers (Charniak, 2000; Collins, 1999).
A00-2018
with the CFG Rule Dictionary We use an idea that is similar to the method proposed by Ratnaparkhi (Ratnaparkhi, 1996) for partof-speech tagging.
W96-0213
Chunk parsing (Tjong Kim Sang, 2001; Brants, 1999) is a simple parsing strategy both in implementation and concept.
E99-1016
Magerman. 1995.
P95-1037
