Challenge Setting The organization provided training, development and test sets derived from the standard sections of the Penn TreeBank (Marcus et al., 1993) and PropBank (Palmer et al., 2005) corpora.
J05-1004 J93-2004
In the same line, some systems also use features of the content words of the argument, using the heuristics of Surdeanu et al.(2003). Very generally also, many systems extract features from the first and last words of the argument.
P03-1002
Ensembles of decision trees learned through the AdaBoost algorithm (AB) were applied by M`arquez et al.(2005) and Surdeanu and Turmo (2005).
W05-0635
Finally, Lin and Smith (2005) presented a proposal radically different from the rest, with very light learning components.
W05-0626
The exceptions to the hierarchical processing are the systems by Pradhan et al.(2005b) and Mitsumori et al.(2005), which perform a chunking-based sequential tokenization.
W05-0629 W05-0634
The Proposition Bank (PropBank) (Palmer et al., 2005) annotates the Penn TreeBank with verb argument structure.
J05-1004
Pradhan et al.(2005b) followed a stacking approach by learning a chunk-based SRL system including as features the outputs of two syntax-based systems.
W05-0634
Finally, in this edition two systems apply learning at a global context (Haghighi et al., 2005; Sutton and McCallum, 2005) and, consequently, they are able to extract features from a complete labeling of a predicate.
W05-0623 W05-0636
In addition to the CoNLL-2004 shared task, another evaluation exercise was conducted in the Senseval-3 workshop (Litkowski, 2004).
W04-0803
• Full parser of Charniak (2000).
A00-2018
Tjong Kim Sang et al.(2005) applied, among others, Memory-Based Learning (MBL).
W05-0637
For instance, Tsai et al.(2005) report F1=75.76 for a base system on the development set, M`arquez et al.(2005) report F1=75.75, Punyakanok et al.(2005) report F1=74.76, and Haghighi et al.(2005) report F1=74.52.
W05-0623 W05-0638
The tagger follows the CoNLL-2003 task setting (Tjong Kim Sang and De Meulder, 2003), and thus is not developed with WSJ data.
W03-0419
best individual system on the task is that of Surdeanu and Turmo (2005), which obtained F1=75.04 on the combined test set, about 3 points below than the best performing combined system.
W05-0635
Their results on the WSJ test equal the best results published so far on this task and datasets (Pradhan et al., 2005a), though they are not directly comparable due to a different setting in defining arguments not perfectly matching the predicted parse constituents.
W05-0634
In a more sophisticated way, Punyakanok et al.(2005) and Tsai et al.(2005) performed global inference as constraint satisfaction using Integer Linear Programming, also taking into account all candidate arguments (“ac-ILP”).
W05-0638
In this category, it is also noticeable the use of the syntactic frame feature, proposed by Xue and Palmer (2004).
W04-3212
That system performed F1=73.57 on the development set, which is 2.18 points below the F1=75.75 obtained by the same architecture using full parsing, and 4.47 points below the best performing combined system on the development set (Pradhan et al., 2005b).
W05-0634
Differently, other systems have captured features from the left/right tokens surrounding the argument, which are typically words, but can be chunks or general phrases in systems that sequentialize the task (M`arquez et al., 2005; Pradhan et al., 2005b; Mitsumori et al., 2005).
W05-0629 W05-0634
Looking at the description of the different systems, it becomes clear that the general type of features used in this edition is strongly based on previous work on the SRL task (Gildea and Jurafsky, 2002; Surdeanu et al., 2003; Pradhan et al., 2005a; Xue and Palmer, 2004).
J02-3001 P03-1002 W04-3212 W05-0634 W05-0635
As a special case, Moschitti et al.(2005) subdivide the “i+c” strategy into four phases: after identification, heuristics are applied to assure compatibility of identified arguments; and, before classifying arguments into roles, a preclassification into core vs.
W05-0630
sf: syntactic frame (Xue and Palmer, 2004); On the complete proposition: as: sequence of arguments of a proposition.
W04-3212
Yi and Palmer (2005) did also a greedy merging of arguments but taking into account not complete solutions but all candidate arguments labeled by base systems (“ac-join”).
J05-1004 W05-0639
Regarding novel learning paradigms not applied in previous shared tasks, we find Relevant Vector Machine (RVM), which is a kernel–based linear discriminant inside the framework of Sparse Bayesian Learning (Johansson and Nugues, 2005) and Tree Conditional Random Fields (T-CRF) (Cohn and Blunsom, 2005), that extend the sequential CRF model to tree structures.
W05-0622 W05-0624
by Ponzetto and Strube (2005), who used C4.5.
W05-0633
From the point of view of learning architectures and study of feature relevance, it is also worth mentioning the following recent works (Punyakanok et al., 2004; Moschitti, 2004; Xue and Palmer, 2004; Pradhan et al., 2005a).
C04-1197 J05-1004 P04-1043 W04-3212 W05-0630 W05-0634
Remarkably, Park and Rim (2005) parametrize the pruning procedure and then study the effect of being more or less aggressive at filtering constituents.
W05-0632
Again, we concentrate on the PropBank corpus (Palmer et al., 2005), which is the Wall Street Journal part of the Penn TreeBank corpus enriched with predicate–argument structures.
J05-1004
Many of the combinations depart from the manually selected conjunctions of Xue and Palmer (2004).
W04-3212
In (Carreras and M`arquez, 2004) one may find a detailed review of the task and also a brief state-of-the-art on SRL previous to 2004.
W04-2412
The data consists of sections of the Wall Street Journal part of the Penn TreeBank (Marcus et al., 1993), with information on predicate-argument structures extracted from the PropBank corpus (Palmer et al., 2005).
J05-1004 J93-2004
Actually, Haghighi et al.(2005) performed a double selection step: an inner re-ranking of n-best solutions coming from the base system on a single tree; and an outer selection of the final solution among the candidate solutions coming from n-best parse trees.
W05-0623
Interestingly, Yi and Palmer (2005) retrained Ratnaparkhi’s parser using the WSJ training sections enriched with semantic information coming from PropBank annotations.
J05-1004 W05-0639
Dev. tWSJ tBrown UPC PoS-tagger 97.13 97.36 94.73 Charniak (2000) 92.01 92.29 87.89 Table 2: Accuracy (%) of PoS taggers.
A00-2018
Finally, Haghighi et al.(2005) and Sutton and McCallum (2005) performed a different approach by learning a re-ranking function as a global model on top of the base SRL models.
W05-0623 W05-0636
Test WSJ Test Brown P(%) R(%) F1 P(%) R(%) F1 P(%) R(%) F1 UPC Chunker 94.66 93.17 93.91 95.26 94.52 94.89 92.64 90.85 91.73 UPC Clauser 90.38 84.73 87.46 90.93 85.94 88.36 84.21 74.32 78.95 Collins (1999) 85.02 83.55 84.28 85.63 85.20 85.41 82.68 81.33 82.00 Charniak (2000) 87.60 87.38 87.49 88.20 88.30 88.25 80.54 81.15 80.84 Table 3: Results of the syntactic parsers on the development, and WSJ and Brown test sets.
A00-2018
For instance, many systems used the pruning strategy described in (Xue and Palmer, 2004) (“x&p”) and other systems used the soft pruning rules described in (Pradhan et al., 2005a) (“softp”).
J05-1004 W04-3212 W05-0634
For example, indicators of the immediate syntactic types that form the argument, flags raised by punctuation tokens in or nearby the argument, or the governing category feature of Gildea and Jurafsky (2002).
J02-3001
While almost all systems use the standard path of (Gildea and Jurafsky, 2002), many have explored variations of it.
J02-3001
• Named Entities predicted with the MaximumEntropy based tagger of Chieu and Ng (2003).
W03-0423
M`arquez et al.(2005) and Tjong Kim Sang et al.(2005) performed a greedy merging of the arguments of base complete solutions (“s-join”).
W05-0637
Four of them with the standard polynomial kernels (Mitsumori et al., 2005; Tjong Kim Sang et al., 2005; Tsai et al., 2005; Pradhan et al., 2005b), another one using Gaussian kernels (Ozgencil and McCracken, 2005), and a last group using tree-based kernels specifically designed for the task (Moschitti et al., 2005).
W05-0629 W05-0630 W05-0631 W05-0634 W05-0637 W05-0638
Ten systems contributed to the task, which was evaluated using the PropBank corpus (Palmer et al., 2005).
J05-1004
However, it is worth mentioning the work of Tjong Kim Sang et al.(2005) in which spelling error correction techniques are adapted for improving the resulting role labeling.
W05-0637
As a special case, Lin and Smith (2005) used the GT-PARA analyzer for converting parse trees into a flat representation of all predicates including argument boundaries.
W05-0626
In particular, 8 teams used the Maximum Entropy (ME) statistical framework (Che et al., 2005; Haghighi et al., 2005; Park and Rim, 2005; Tjong Kim Sang et al., 2005; Sutton and McCallum, 2005; Tsai et al., 2005; Yi and Palmer, 2005; Venkatapathy et al., 2005).
J05-1004 W05-0623 W05-0632 W05-0636 W05-0637 W05-0638 W05-0639
c©2005 Association for Computational Linguistics Introduction to the CoNLL-2005 Shared Task: Semantic Role Labeling Xavier Carreras and Llu´ıs M`arquez TALP Research Centre Technical University of Catalonia (UPC) {carreras,lluism}@lsi.upc.edu Abstract In this paper we describe the CoNLL2005 shared task on Semantic Role Labeling.
W05-0626
