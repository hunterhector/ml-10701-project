the parser and reranker trained purely on Wall Street Journal) has improved by 0.3% over Charniak and Johnson (2005).
P05-1022
It is also the case that we thought PP attachment might be improved because of the increased coverage of prepositionnoun and preposition-verb combinations that work such as (Hindle and Rooth, 1993) show to be so important.
J93-1005
Examples of this include self-training (Charniak, 1997) and co-training (Blum and Mitchell, 1998; Steedman et al., 2003).
E03-1008
As all distributions are conditioned with five or more features, they are all heavily backed off using Chen back-off (the average-count method from Chen and Goodman (1996)).
P96-1041
These additional features are largely responsible for improving the reranker’s performance on section 23 to 91.3% f-score (Charniak and Johnson (2005) reported an f-score of 91.0% on section 23).
P05-1022
Given sufficient labelled data, there are several “supervised” techniques of training high-performance parsers (Charniak and Johnson, 2005; Collins, 2000; Henderson, 2004).
A00-2018 P04-1013 P05-1022
first-stage 50-best parser The first stage of our parser is the lexicalized probabilistic context-free parser described in (Charniak, 2000) and (Charniak and Johnson, 2005).
A00-2018 P05-1022
Gildea (2001) and Bacchiani et al.(2006) show that out-of-domain training data can improve parsing ac152 curacy.
W01-0521
The features consist of those described in (Charniak and Johnson, 2005), together with an additional 601,577 features.
P05-1022
Our labeled data comes from the Penn Treebank (Marcus et al., 1993) and consists of about 40,000 sentences from Wall Street Journal (WSJ) articles 153 annotated with syntactic information.
J93-2004
Clark et al.(2003) applies self-training to POS-tagging and reports the same outcomes.
W03-0407
As in (Charniak and Johnson, 2005) the parser has been modified to produce n-best parses.
P05-1022
Model fparser freranker Charniak and Johnson (2005) – 91.0 Current baseline 89.7 91.3 WSJ + NANC 91.0 92.1 Table 3: f-scores on WSJ section 23.
P05-1022
MaxEnt Reranker The second stage of our parser is a Maximum Entropy reranker, as described in (Charniak and Johnson, 2005).
P05-1022
Sarkar (2001) and Steedman et al.(2003) investigated using co-training for parsing.
E03-1008 N01-1023
It is not surprising that self-training is not normally effective: Charniak (1997) and Steedman et al.(2003) report either minor improvements or significant damage from using self-training for parsing.
E03-1008
It does this using the reranking methodology described in Collins (2000), using a Maximum Entropy model with Gaussian regularization as described in Johnson et al.(1999). Our reranker classifies each parse with respect to 1,333,519 features (most of which only occur on few parses).
P99-1069
Finally, there are “unsupervised” strategies where no data is labeled and all annotations (including the grammar itself) must be discovered (Klein and Manning, 2002).
P02-1017
