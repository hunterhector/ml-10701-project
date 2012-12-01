STSG is simply a version of synchronous treeadjoining grammar or STAG (Shieber and Schabes, 1990) that lacks the adjunction operation.
C90-3045
The one exception is the synchronous DOP approach of (Poutsma, 2000), which obtains an STSG by decomposing aligned training trees in all possible ways (and using “naive” count-based probability estimates).
C00-2092
Several researchers have tried putting “more syntax” into translation models: like us, they use statistical versions of synchronous grammars, which generate source and target sentences in parallel and so describe their correspondence.4 This approach offers four features absent from IBM-style models: (1) a recursive phrase-based translation, (2) a syntax-based language model, (3) the ability to condition a word’s translation on the translation of syntactically related words, and (4) polynomial-time optimal alignment and decoding (Knight, 1999).
J99-4005
The latter are small and simple (Alshawi et al., 2000): tree nodes are words, and there need be no other structure to recover or align.
J00-1004
Systems for “deep” analysis and generation might wish to learn mappings between deep and surface trees (B¨ohmov´a et al., 2001) or between syntax and semantics (Shieber and Schabes, 1990).
C90-3045
One can mechanically transform this algorithm to compute outside probabilities, the Viterbi parse, the parse forest, and other quantities (Goodman, 1999).
J99-4004
Previous work in statistical synchronous grammars has been limited to forms of synchronous context-free grammar (Wu, 1997; Alshawi et al., 2000; Yamada and Knight, 2001).
J00-1004 J97-3002 P01-1067
Their alignment and translation accuracy improves when they are forced to translate shallow phrases as contiguous, potentially idiomatic units (Och et al., 1999).
W99-0604
3However, the binary-branching SCFGs used by Wu (1997) and Alshawi et al.(2000) are strictly less powerful than STSG.
J00-1004 J97-3002
