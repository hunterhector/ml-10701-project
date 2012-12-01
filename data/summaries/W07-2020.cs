This is because identical words occur more often in coordinate head words than in other lexical dependencies (there were 43 pairs with identical words in the coordination set, compared to 3 such pairs in the 150 SimTest ncoord xcoord SDcoord nnonCoord xnonCoord SDnonCoord 95% CI p-value coordDistrib 503 0.11 0.13 485 0.06 0.09 [0.04 0.07] 0.000 (Resnik, 1995) 444 3.19 2.33 396 2.43 2.10 [0.46 1.06] 0.000 (Lin, 1998) 444 0.27 0.26 396 0.19 0.22 [0.04 0.11] 0.000 (Jiang and Conrath, 1997) 444 0.13 0.65 395 0.07 0.08 [-0.01 0.11] 0.083 (Wu and Palmer, 1994) 444 0.63 0.19 396 0.55 0.19 [0.06 0.11] 0.000 (Leacock and Chodorow, 1998) 444 1.72 0.51 396 1.52 0.47 [0.13 0.27] 0.000 (Hirst and St-Onge, 1998) 459 1.599 2.03 447 1.09 1.87 [0.25 0.76] 0.000 (Banerjee and Pedersen, 2003) 451 114.12 317.18 436 82.20 168.21 [-1.08 64.92] 0.058 (Patwardhan and Pedersen, 2006) 459 0.67 0.18 447 0.66 0.2 [-0.02 0.03] 0.545 random 483 0.89 0.17 447 0.88 0.18 [-0.02 0.02] 0.859 Table 1: Summary statistics for 9 different word similarity measures (plus one random measure):ncoord and nnonCoord are the sample sizes for the coordinate and non-coordinate noun pairs samples, respectively; xcoord, SDcoord and xnonCoord, SDnonCoord are the sample means and standard deviations for the two sets.
J98-1006
Such measures have proved to be very effective in automatically identifying languages of text, with accuracies nearing 100% for fairly small amounts of training and test data (Adams and Resnik, 1997; Singh, 2006b).
W97-0213
The need for multiple knowledge sources has become a golden rule, and the ?lexical sensitivity??once remarked by Resnik and Yarowsky (1997) is addressed by various means in statistical classifiers, such as learning an optimal combination of the various knowledge sources for individual target words (e.g.
W97-0213
Nature of Target Words Leacock et al.(1998), for example, observed that ?the benefits of adding topical to local context alone depend on syntactic category as well as on the characteristics of the individual word??
J98-1006
Resnik. 1997.
W97-0213
Leacock and Chodorow (1998)?s measure takes into account the path length between two concepts, which is scaled by the depth of the hierarchy in which they reside.
J98-1006
Mihalcea, 2002; Escudero et al., 2004).
W04-0807 W04-0828
As pointed out by Mihalcea et al.(2004), among the participating systems in the SENSEVAL-3 English lexical sample task, ?several of the top performance systems are based on combination of multiple classifiers, which shows once again that voting scheme that combine several learning algorithms outperform the accuracy of individual classifiers??
W04-0807
TSWEB2: Inspired by the work of (Leacock et al., 1998), these Topic Signatures were constructed using monosemous relatives from WordNet (synonyms, hypernyms, direct and indirect hyponyms, and siblings), querying Google and retrieving up to one thousand snippets per query (that is, a word sense), extracting the words with distinctive frequency using TFIDF.
J98-1006
