Dorr (1994) categorizes sources of syntactic divergence between languages, and Fox (2002) analyzed a parallel French-English corpus, quantifying how often parse dependencies cross when projecting an English tree onto a French string.
J94-4004 W02-1039
Yamada and Knight (2001) present an algorithm for estimating probabilistic parameters for a similar model which represents translation as a sequence of re-ordering operations over children of nodes in a syntactic tree, using automatic parser output for the initial tree structures.
P01-1067
The Inversion Transduction Grammar significantly outperforms the syntactically supervised tree-tostring model of Yamada and Knight (2001).
P01-1067
We describe each of the models used in more detail in the next two sections, including the clone operation of Gildea (2003).
P03-1011
Galley et al.(2004) extract translation rules from a large parsed parallel corpus that extend in scope to tree fragments beyond a single node; we believe that adding such larger-scale operations to the translation model is likely to significantly improve the performance of syntactically supervised alignment.
N04-1035
The trees may be learned directly from parallel corpora (Wu, 1997), or provided by a parser trained on hand-annotated treebanks (Yamada and Knight, 2001).
J97-3002 P01-1067
Our test set is that used in the alignment evaluation organized by Mihalcea and Pederson (2003), though we retained sentence-initial capitalization, used a closed vocabulary, and restricted ourselves to a smaller training corpus.
W03-0301
Tree-To-String Model The model of Yamada and Knight (2001) can be thought of as a generative process taking a tree in one language as input and producing a string in the other through a sequence of probabilistic operations.
P01-1067
Our test data consisted of 447 sentence pairs of no more than 30 words, hand aligned by Och and Ney (2000).
P00-1056
For scoring the viterbi alignments of each system against goldstandard annotated alignments, we use the alignment error rate (AER) of Och and Ney (2000), which measures agreement at the level of pairs of words: AER = 1 jA \ GPj + jA \ GSjjAj + jG Sj where A is the set of word pairs aligned by the automatic system, GS is the set marked in the gold standard as “sure”, and GP is the set marked as “possible” (including the “sure” pairs).
P00-1056
Zens and Ney (2003) compute the viterbi alignments for German-English and French-English sentences pairs using IBM Model 5, and then measure how many of the resulting alignments fall within the hard constraints of both Wu (1997) and Berger et al.(1996). They find higher coverage for an extended version of ITG than for the IBM decoding constraint for both language pairs, with the unmodified ITG implementation covering about the same amount of German-English data as IBM, and significantly less French-English data.
J97-3002 P03-1019
While we did not have human-annotated goldstandard parses for our training data, we did have human annotated parses for the Chinese side of our test data, which was taken from the Penn Chinese Treebank (Xue et al., 2002).
C02-1145
In part to deal with this problem, Yamada and Knight (2001) flatten the trees in a pre-processing step by collapsing nodes with the same lexical head-word.
P01-1067
The syntactically supervised model has been found to outperform the IBM word-level alignment models of Brown et al.(1993) for translation by Yamada and Knight (2002).
J93-2003 P02-1039
Inversion Transduction Grammar The Inversion Transduction Grammar of Wu (1997) can be thought as a a generative process which simultaneously produces strings in both languages through a series of synchronous context-free grammar productions.
J97-3002
Alignment Precision Recall Error Rate Inversion Transduction Grammar .68 .52 .40 Tree-to-String, automatic parses .61 .48 .46 Tree-to-String, gold parses .61 .52 .44 Table 3: Chinese Tree to English String (1997) as well as Brown et al.(1993). Decoding, meaning exact computation of the highest probability translation given a foreign sentence, is not possible in polynomial time for the IBM models, and in practice decoders search through the space of hypothesis translations using a set of additional, hard alignment constraints.
J93-2003
“Inversion Transduction Grammar” (ITG) is the model of Wu (1997), “Tree-to-String” is the model of Yamada and Knight (2001), and “Tree-to-String, Clone” allows the node cloning operation described above.
J97-3002 P01-1067
Statistical approaches to machine translation, pioneered by Brown et al.(1990), estimate parameters for a probabilistic model of word-to-word correspondences and word re-orderings directly from large corpora of parallel bilingual text.
J90-2002
Wu (1997) modeled the reordering process with binary branching trees, where each production could be either in the same or in reverse order going from source to target language.
J97-3002
3.1 Tree-to-String With Cloning In order to provide more flexibility in alignments, a cloning operation was introduced for tree-to-string alignment by Gildea (2003).
P03-1011
Zens and Ney (2003) provide a thorough analysis of alignment constraints from the perspective of decoding algorithms.
P03-1019
This gives the translation model more information about the structure of the source language, and further constrains the reorderings to match not just a possible bracketing as in Wu (1997), but the specific bracketing of the parse tree provided.
J97-3002
IBM Models 1 and 4 refer to Brown et al.(1993). We used the GIZA++ package, including the HMM model of Och and Ney (2000).
J93-2003 P00-1056
These sets were the data used by Hwa et al.(2002). The hand aligned test data consisted of 745 individual aligned word pairs.
P02-1050
In this paper, we make a direct comparison of a syntactically unsupervised alignment model, based on Wu (1997), with a syntactically supervised model, based on Yamada and Knight (2001).
J97-3002 P01-1067
In our experiments we use a grammar with a start symbol S, a single preterminal C, and two nonterminals A and B used to ensure that only one parse can generate any given word-level alignment (ignoring insertions and deletions) (Wu, 1997; Zens and Ney, 2003).
J97-3002 P03-1019
