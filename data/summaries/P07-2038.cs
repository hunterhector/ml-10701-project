This is because identical words occur more often in coordinate head words than in other lexical dependencies (there were 43 pairs with identical words in the coordination set, compared to 3 such pairs in the 150 SimTest ncoord xcoord SDcoord nnonCoord xnonCoord SDnonCoord 95% CI p-value coordDistrib 503 0.11 0.13 485 0.06 0.09 [0.04 0.07] 0.000 (Resnik, 1995) 444 3.19 2.33 396 2.43 2.10 [0.46 1.06] 0.000 (Lin, 1998) 444 0.27 0.26 396 0.19 0.22 [0.04 0.11] 0.000 (Jiang and Conrath, 1997) 444 0.13 0.65 395 0.07 0.08 [-0.01 0.11] 0.083 (Wu and Palmer, 1994) 444 0.63 0.19 396 0.55 0.19 [0.06 0.11] 0.000 (Leacock and Chodorow, 1998) 444 1.72 0.51 396 1.52 0.47 [0.13 0.27] 0.000 (Hirst and St-Onge, 1998) 459 1.599 2.03 447 1.09 1.87 [0.25 0.76] 0.000 (Banerjee and Pedersen, 2003) 451 114.12 317.18 436 82.20 168.21 [-1.08 64.92] 0.058 (Patwardhan and Pedersen, 2006) 459 0.67 0.18 447 0.66 0.2 [-0.02 0.03] 0.545 random 483 0.89 0.17 447 0.88 0.18 [-0.02 0.02] 0.859 Table 1: Summary statistics for 9 different word similarity measures (plus one random measure):ncoord and nnonCoord are the sample sizes for the coordinate and non-coordinate noun pairs samples, respectively; xcoord, SDcoord and xnonCoord, SDnonCoord are the sample means and standard deviations for the two sets.
P94-1019 W06-2501
Only a few such corpora exist, including the Hansard English-French corpus and the HKUST EnglishChinese corpus (Wu, 1994).
P94-1019
Brian Roark and Eugene Charniak 1998.
P98-2182
The idea that nouns co-occurring in conjunctions tend to be semantically related has been noted in (Riloff and Shepherd, 1997) and used effectively to automatically cluster semantically similar words (Roark and Charniak, 1998; Caraballo, 1999; Widdows and Dorow, 2002).
C02-1114 P98-2182 P99-1016 W97-0313
Ellen Riloff and Jessica Shepherd 1997.
W97-0313
One possible explanation for the unsuitability of the measures of (Patwardhan and Pedersen, 2006) for the coordinate similarity task could be based on how context is defined when building context vectors.
W06-2501
Interestingly, the three tests where no significant difference was measured between the scores on the coordination set and the non-coordination set (Jiang and Conrath, 1997; Banerjee and Pedersen, 2003; Patwardhan and Pedersen, 2006) were the three top scoring measures in (Patwardhan and Pedersen, 2006), where a subset of six of the above WordNetbased experiments were compared and the measures evaluated against human relatedness judgements and in a word sense disambiguation task.
W06-2501
3 WordNet-Based Similarity Measures We also examine the following measures of semantic similarity which are WordNet-based.3 Wu and Palmer (1994) propose a measure of similarity of two concepts c1 and c2 based on the depth of concepts in the WordNet hierarchy.
P94-1019
For example, Cederberg and Widdows (2003) note that words appearing in coordination patterns tend to be on the same ontological level: ?fruit and vegetables??is quite likely to occur, whereas ?fruit and apples??is an unlikely cooccurrence.
W03-0415
They are quite comparable to that obtained by Wu (1994) using a manual Chinese-English parallel corpus.
P94-1019
For example, it would be helpful to consider strong correspondence between certain English and Chinese words, as in (Wu, 1994).
P94-1019
Caraballo and Charniak (1999) have explored determining noun specificity from raw text.
P99-1016
Finally, Patwardhan and Pederson (2006) build on previous work on second-order co-occurrence vectors (Schutze, 1998) by constructing second-order co-occurrence vectors from WordNet glosses, where, as in (Banerjee and Pedersen, 2003), the gloss of a concept is extended so that it includes the gloss of concepts to which it is directly related in WordNet.
W06-2501
