In their experiments on NP identifiers, Pierce and Cardie (2001) observed a similar effect.
W01-0501
We have explored using different settings for the seed set size (Steedman et al., 2003).
E03-1008
In the context of parsing, all previous work (Thompson et al., 1999; Hwa, 2000; Tang et al., 2002) has focussed on single learners.
P02-1016 W00-1306
Abney (2002) argues that this assumption is extremely strong and typically violated in the data, and he proposes a weaker independence assumption.
P02-1046
Current state-of-the-art statistical parsers (Collins, 1999; Charniak, 2000) are trained on large annotated corpora such as the Penn Treebank (Marcus et al., 1993).
A00-2018 J93-2004
Further avenues to explore include the development of selection methods to efficiently approximate maximizing the objective function of parser agreement on unlabeled data, following the work of Dasgupta et al.(2002) and Abney (2002).
P02-1046
The other approach, and the focus of this paper, is co-training (Sarkar, 2001), a mostlyunsupervised algorithm that replaces the human by having two (or more) parsers label training examples for each other.
N01-1023
Active learning can be applied to a single learner (Lewis and Catlett, 1994) and to multiple learners (Freund et al., 1997; Engelson and Dagan, 1996; Ngai and Yarowsky, 2000).
P00-1016 P96-1042
One is sample selection (Thompson et al., 1999; Hwa, 2000; Tang et al., 2002), a variant of active learning (Cohn et al., 1994), which tries to identify a small set of unlabeled sentences with high training utility for the human to label1.
P02-1016 W00-1306
Empirical studies were conducted to compare selection methods under both co-training and a semi-supervised framework called corrected co-training (Pierce and Cardie, 2001), in which the selected examples are manually checked and corrected before being added to the 1In the context of training parsers, a labeled example is a sentence with its parse tree.
W01-0501
We do not explicitly maximize agreement (along the lines of Abney’s algorithm (2002)) because it is too computationally intensive for training parsers.
P02-1046
