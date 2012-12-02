4.3. Testing on the Penn Treebank To test whether head-driven language models do indeed converge to linguistically-motivated grammars better than SCFGs, we replicated the experiment of (Pereira and Schabes, 1992) on the ATIS section of the Penn Treebank.
P92-1017
The first is that, in contrast to the results of (Pereira and Schabes, 1992), unbracketed training does improve bracketing performance (from a baseline of about 50% to 72.7% without features and 74.8% with features).
P92-1017
(Pereira and Schabes, 1992) explore this topic, demonstrating that a stochastic context free grammar trained on part-of-speech sequences from English text can have an entropy as low or lower than another but bracket the text much more poorly (tested on hand-annotations).
P92-1017
Without features, we are essentially replicating the two experiments run by (Pereira and Schabes, 1992), except that they use a different set of initial rules (all 4095 CNF grammar rules over 15 nonterminals and the 48 Treebank terminal categories).
P92-1017
One effective way around this problem is to use hand-structured text like the Penn Treebank (Marcus, 1991) to train the learner: (Pereira and Schabes, 1992) demonstrate that the inside-outside algorithm can learn grammars effectively given such constraint; from a bracketed corpus (Brill, 1993) successfully learns rules that iteratively transform a default phrase-structure into a better one for a particular sentence.
H91-1104 H93-1047 P92-1017
This is the same general procedure as used by (Lari and Young, 1990; Briscoe and Waegner, 1992; Pereira and Schabes, 1992) and others.
P92-1017
