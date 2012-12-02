WASP algorithm compared to: (1) the original WASP algorithm which uses a functional query language (FunQL); (2) SCISSOR (Ge and Mooney, 2005), a fully-supervised, combined syntacticsemantic parsing algorithm which also uses FunQL; and (3) Zettlemoyer and Collins (2005) (Z&C), a CCG-based algorithm which uses Prolog logical forms.
J05-1003
While WASP works well for target MRLs that are free of logical variables such as CLANG (Wong and Mooney, 2006), it cannot easily handle various kinds of logical forms used in computational semantics, such as predicate logic.
N06-1056
Semantic Parsing Algorithm Our work is based on the WASP semantic parsing algorithm(WongandMooney,2006),whichtranslates NL sentences into MRs using an SCFG.
N06-1056
Collins. 2005.
J05-1003
the token (1) in the last rule of Figure 3), see Wong and Mooney (2006).
N06-1056
Like most existing work on syntax-based SMT (Chiang, 2005; Galley et al., 2006), we constructGusingrulesextractedfromwordalignments.
P05-1033 P06-1121
Among the grammar formalisms successfully put into use in syntaxbased SMT are synchronous context-free grammars (SCFG) (Wu, 1997) and synchronous treesubstitutiongrammars(STSG)(YamadaandKnight, 2001).
J97-3002 P01-1067
It is also similar to Schuler’s (2003) use of model-theoretic interpretations to guide syntactic parsing.
P03-1067
Of the many features that we have tried, one feature set stands out as being the most effective, the two-level rules in Collins and Koo (2005), which give the number of times a given rule is used to expand a non-terminal in a given parent rule.
J05-1003
the GEOQUERY functional querylanguageinWongandMooney(2006)).
N06-1056
We use the K = 5 most probable word alignments for the training set given by GIZA++ (Och and Ney, 2003), with variable names ignored to reduce sparsity.
J03-1002
On the other hand, most existing methods for mapping NL sentences to logical forms involve substantial hand-written components that are difficult to maintain (Joshi and Vijay-Shanker, 2001; Bayer et al., 2004; Bos, 2005).
W04-0818
We use the maximum-entropy model proposed in Wongand Mooney (2006), which defines a conditional probability distribution over derivations given an observed NL sentence.
N06-1056
The larger GEOQUERY corpus consists of 880 English questions gathered from various sources (Wong and Mooney, 2006).
N06-1056
More recently, we show that our SCFG-based parser can be inverted to produce a state-of-the-art NL generator, where a formal MRL is translated into an NL (Wong and Mooney, 2007).
N07-1022
In our previous work (Wong and Mooney, 2006), semantic parsing is cast as a machine translation task, where an SCFG is used to model the translation of an NL into a formal meaning-representation language (MRL).
N06-1056
Both formalisms have led to SMT systems whose performance is state-of-the-art (Chiang, 2005; Galley et al., 2006).
P05-1033 P06-1121
Zettlemoyer and Collins (2005) present a statistical method that is consider960 ably more robust, but it still relies on hand-written rules for lexical acquisition, which can create a performance bottleneck.
J05-1003
