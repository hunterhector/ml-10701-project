A. Ratnaparkhi, 1996.
W96-0213
Ratnaparkhi. 1996.
W96-0213
They are quite comparable to that obtained by Wu (1994) using a manual Chinese-English parallel corpus.
A94-1030
Finally, word similarity can be computed from structural features like head-modifier relationships (Grefenstette 1994b; Ruge 1992; Dagan, Marcus, and Markovitch 1993; Pereira, Tishby, and Lee 1993; Dagan, Pereira, and Lee 1994).
J93-2004
Only a few such corpora exist, including the Hansard English-French corpus and the HKUST EnglishChinese corpus (Wu, 1994).
A94-1030
Mitchell P. Marcus, Beatrice Santorini, and Mary Ann Marcinkiewicz. 1993. Building a large annotated corpus of English: The Penn Treebank. Computational Linguistics, 19(2):313330.
J93-2004
It is interesting to note that the inclusion of prefix and suffix for all words gives better result instead of using only for rare words as is described in Ratnaparkhi (1996).
W96-0213
Tjong Kim Sang, Sabine Buchholz, Introduction to the CoNLL-2000 shared task: chunking, Proceedings of the 2nd workshop on Learning language in logic and the 4th conference on Computational natural language learning, September 13-14, 2000, Lisbon, Portugal 18 Erik F.
A00-2007 W00-0726
3 WordNet-Based Similarity Measures We also examine the following measures of semantic similarity which are WordNet-based.3 Wu and Palmer (1994) propose a measure of similarity of two concepts c1 and c2 based on the depth of concepts in the WordNet hierarchy.
A94-1030
In contrast, methods based on Maximum Entropy (Ratnaparkhi, 1996), Conditional Random Field (Shrivastav, 2006) etc.
W96-0213
Furthermore, in order to estimate the relative performance of the models, experiments were carried out with two existing taggers: TnT (Brants, 2000) and ACOPOST 3 . The accuracy achieved using TnT are 87.44% and 87.36% respectively with bigram and trigram model for 40K training data.
A00-1031
These observations can be extended to the case of weighted rewrite rules (Mohri and Sproat 1996).
J96-3004
The only similar performing tool is the Trigrams `n' Tags tagger (Brants, 2000) which uses a much simpler statistical model.
A00-1031
This is because identical words occur more often in coordinate head words than in other lexical dependencies (there were 43 pairs with identical words in the coordination set, compared to 3 such pairs in the 150 SimTest ncoord xcoord SDcoord nnonCoord xnonCoord SDnonCoord 95% CI p-value coordDistrib 503 0.11 0.13 485 0.06 0.09 [0.04 0.07] 0.000 (Resnik, 1995) 444 3.19 2.33 396 2.43 2.10 [0.46 1.06] 0.000 (Lin, 1998) 444 0.27 0.26 396 0.19 0.22 [0.04 0.11] 0.000 (Jiang and Conrath, 1997) 444 0.13 0.65 395 0.07 0.08 [-0.01 0.11] 0.083 (Wu and Palmer, 1994) 444 0.63 0.19 396 0.55 0.19 [0.06 0.11] 0.000 (Leacock and Chodorow, 1998) 444 1.72 0.51 396 1.52 0.47 [0.13 0.27] 0.000 (Hirst and St-Onge, 1998) 459 1.599 2.03 447 1.09 1.87 [0.25 0.76] 0.000 (Banerjee and Pedersen, 2003) 451 114.12 317.18 436 82.20 168.21 [-1.08 64.92] 0.058 (Patwardhan and Pedersen, 2006) 459 0.67 0.18 447 0.66 0.2 [-0.02 0.03] 0.545 random 483 0.89 0.17 447 0.88 0.18 [-0.02 0.02] 0.859 Table 1: Summary statistics for 9 different word similarity measures (plus one random measure):ncoord and nnonCoord are the sample sizes for the coordinate and non-coordinate noun pairs samples, respectively; xcoord, SDcoord and xnonCoord, SDnonCoord are the sample means and standard deviations for the two sets.
A94-1030
Brants. 2000.
A00-1031
Though taggers based on dependency networks (Toutanova et al., 2003), SVM (Gimenez and M`arquez, 2003), MaxEnt (Ratnaparkhi, 1996), CRF (Smith et al., 2005), and other methods may reach slightly better results, their train/test cycle is orders of magnitude longer.
W96-0213
Penn treebank (PTB) (Marcus et al., 1993). We used
J93-2004
Penn Treebank (Marcus et al., 1993), using a stan-
J93-2004
M.P. Marcus, B. Santorini, and M. Marcinkiewicz. 1993. Building a Large Annotated Corpus of English: The Penn Treebank. ComputationalLinguistics, 19(2):313330.
J93-2004
For example, it would be helpful to consider strong correspondence between certain English and Chinese words, as in (Wu, 1994).
A94-1030
Stochastic models (Cutting et al., 1992; Dermatas et al., 1995; Brants, 2000) have been widely used in POS tagging for simplicity and language independence of the models.
A00-1031
A. Ratnaparkhi. 1996. A Maximum Entropy Model for Part-Of-Speech Tagging. In Proceedings of EMNLP, pages 133142.
W96-0213
33. oravecz@nytud.hu Abstract In the world of non-proprietary NLP software the standard, and perhaps the best, HMM-based POS tagger is TnT (Brants, 2000).
A00-1031
Even without a formal survey it is clear that TnT (Brants, 2000) is used widely in research labs throughout the world: Google Scholar shows over 400 citations.
A00-1031
For the most part, these features are clever hacks, and it is unfortunate that neither Brants (2000) nor the standard HMM textbooks mention them, especially as they often yield more significant error reduction than the move from HMM to other architectures.
A00-1031
For our experiments we use the CoNLL-2000 shared task dataset (Tjong Kim Sang and Buchholz, 2000).
A00-2007 W00-0726
