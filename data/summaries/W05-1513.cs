We trained and tested the parser on the Wall Street Journal corpus of the Penn Treebank (Marcus et al., 1993) using the standard split: sections 2-21 were used for training, section 22 was used for development and tuning of parameters and features, and section 23 was used for testing.
J93-2004
Two classifier-based deterministic dependency parsers for English have been proposed recently (Nivre and Scholz, 2004; Yamada and Matsumoto, 2003).
C04-1010
While this may seem obvious, the differences observed here are much greater than what would be expected from looking, for example, at results from chunking/shallow parsing (Zhang et al., 2001; Kudo and Matsumoto, 2001; Veenstra and van den Bosch, 2000).
N01-1025 P01-1069 W00-0735
In fact, the binary reduce actions are very similar to the reduce actions in the dependency parser of Nivre and Scholz (2004), but they are executed in a different order, so constituents can be built.
C04-1010
We conducted experiments with the parser described in section 2 using two different classifiers: TinySVM (a support vector machine implementation by Taku Kudo)2, and the memory-based learner TiMBL (Daelemans et al., 2004).
W04-3239
Additionally, our parser is in some ways similar to the maximum-entropy parser of Ratnaparkhi (1997).
W97-0301
The MBL-based parser (denoted by MBLpar) uses the IB1 algorithm, with five nearest neighbors, and the modified value difference metric (MVDM), following the work of Nivre and Scholz (2004) on MBL-based deterministic dependency parsing.
C04-1010
Like the parser of Nivre and Scholz (2004), it uses the basic shift-reduce stack-based parsing algorithm, and runs in linear time.
C04-1010
The parser in Kalt (2004) uses a similar algorithm to the one described here, but the classification task is framed differently.
W04-3203
In order to use trees with arbitrary branching for training, or generating them with the parser, we employ an instance of the transformation/detransformation process described in (Johnson, 1998).
J98-4004
Additionally, we plan to investigate the use of the beam strategy of Ratnaparkhi (1997) to pursue multiple parses while keeping the run-time linear.
W97-0301
This may be accomplished with SVMs 131 using a tree kernel, or the tree boosting classifier BACT described in (Kudo and Matsumoto, 2004).
W04-3239
For example, the tree-path feature has been shown to be valuable in semantic role labeling (Gildea and Palmer, 2002).
P02-1031
Table 1 shows a summary of the results of our experiments with SVMpar and MBLpar, and also results obtained with the Charniak (2000) parser, the Bikel (2003) implementation of the Collins (1997) parser, and the Ratnaparkhi (1997) parser.
A00-2018 P97-1003 W97-0301
Although state-of-the-art statistical parsers (Collins, 1997; Charniak, 2000) are more accurate, the simplicity and efficiency of deterministic parsers make them attractive in a number of situations requiring fast, light-weight parsing, or parsing of large amounts of data.
A00-2018 P97-1003
to Previous Work As mentioned before, our parser shares similarities with the dependency parsers of Yamada and Matsumoto (2003) and Nivre and Scholz (2004) in that it uses a classifier to guide the parsing process in deterministic fashion.
C04-1010
We also include the dependency accuracy from Yamada and Matsumoto’s (2003) SVM-based dependency parser, and Nivre and Scholz’s (2004) MBL-based dependency parser.
C04-1010
This can be seen as an extension of the deterministic dependency parser of Nivre and Scholz (2004) to full constituent parsing.
C04-1010
