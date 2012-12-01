Tree-substitution grammar (Schabes, 1990) is TAG without auxiliary trees or adjunction; instead we include a weaker composition operation, sister-adjunction (Rambow et al., 2001), in which an initial tree is inserted between two sister nodes (see Figure 4).
J01-1004
Smith. 2004.
W04-3207
We extract a grammar for the resource-rich language (MSA) from the Penn Arabic Treebank in a process described by Chiang and others (Chiang, 2000; Xia et al., 2000; Chen, 2001).
P00-1058 W00-1307
Work This paper is part of a larger investigation into parsing Arabic dialects (Rambow et al., 2005; Chiang et al., 2006).
E06-1047
Our implementation uses an extension of our monolingual parser (Chiang, 2000) based on tree-substitution 1 grammar with sister adjunction (TSG+SA).
P00-1058
We allow multiple sister-adjunctions at the same site, similar to how Schabes and Shieber (1994) allow multiple adjunctions of modi er auxiliary trees.
J94-1004
4.1 The synchronous TSG+SA formalism Our parser (Chiang, 2000) is based on synchronous tree-substitution grammar with sisteradjunction (TSG+SA).
P00-1058
Finally Pt2 is reestimated by EM on some heldout unannotated sentences of Lprime, using the same method as Chiang and Bikel (2002) but on the syntactic transfer probabilities instead of the monolingual parsing model.
C02-1126
In other work, there has been a fair amount of interest in parsing one language using another language, see for example (Smith and Smith, 2004; Hwa et al., 2004).
W04-3207
estimation and smoothing Ps and Psa are the parameters of a monolingual TSG+SA and can be learned from a monolingual Treebank (Chiang, 2000); the details are not important here.
P00-1058
