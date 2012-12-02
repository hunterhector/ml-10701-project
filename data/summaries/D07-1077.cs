Niessen and Ney (2004) describe an approach for translation from German to English that combines verbs with associated particles, and also reorders questions.
J04-2003
Reordering approaches have given significant improvements in performance for translation from French to English (Xia and McCord, 2004) and from German to English (Collins et al., 2005).
C04-1073 P05-1066
Our approach is most similar to that of Collins et al.(2005). Most SMT systems employ some mechanism that allows reordering of the source language during translation (i.e., non-monotonic decoding).
P05-1066
We evaluated the reordering approach within the MOSES phrase-based SMT system (Koehn et al., 2007).
P07-2045 P07-2045
Xia and McCord (2004) describe an approach for French, where reordering rules that operate on context-free rule productions are acquired au738 tomatically.
C04-1073
More recently developed hierarchical systems (e.g., (Yamada and Knight, 2001; Chiang, 2005; Marcu et al., 2006)) may be better equipped to deal with reordering of this type; however, in this example they would effectively have to first identify the span of the relative clause, and then move it into the correct position, without any explicit representation of the source language syntax.
P01-1067 P05-1033 W06-1606
We trained a Chinese Treebank-style tokenizer and partof-speech tagger, both using a tagging model based on a perceptron learning algorithm (Collins, 2002).
W02-1001
It is worth noting that none of these approaches to reordering make use of explicit syntactic information in the source language—for example, none of the methods make use of an existing source-language parser (the systems of Yamada and Knight (2001) and Marcu et al.(2006) make use of a parser in the target language, i.e., English).
P01-1067 W06-1606
The reordered sentence is then re-tokenized to be consistent with the baseline system, which uses a different tokenization scheme that is more friendly to the MT system.3 We use BLEU scores as the performance measure in our evaluation (Papineni et al., 2002).
P02-1040
Syntactic reordering approaches are an effective method for handling systematic differences in word order between source and target languages within the context of statistical machine translation (SMT) systems (Xia and McCord, 2004; Collins et al., 2005).
C04-1073 P05-1066
The model of Chiang (2005) employs a synchronous context-free grammar to allow hierarchical approaches to reordering.
P05-1033
Our baseline is a phrase-based MT system trained using the MOSES toolkit (Koehn et al., 2007).
P07-2045
Finally, note that a number of statistical MT systems make use of source language syntax in transducer-style approaches; see (Lin, 2004; Ding and Palmer, 2005; Quirk et al., 2005; Liu et al., 2006; Huang et al., 2006).
C04-1090 P05-1034 P05-1067 P06-1077 W06-3601
Collins et al.(2005) also describe an approach for German, concentrating on reordering German clauses, which have quite different word order from clauses in English.
P05-1066
We report results for the method on the NIST 2006 evaluation data, using the MOSES phrase-based SMT system (Koehn et al., 2007).
P07-2045
Berger et al.(1996) describe an approach for French that reorders phrases of the form NOUN1 de NOUN2.
J96-1002
We used the Chinese parser described by Sun and Jurafsky (2004), which was adapted from the parser 2We used 8 corpora for training, including LDC2002E18, LDC2003E07, LDC2003E14, LDC2005E83, LDC2005T06, LDC2006E26, LDC2006E8, and LDC2006G05.
N04-1032
Work A number of researchers (Brown et al., 1992; Berger et al., 1996; Niessen and Ney, 2004; Xia and McCord, 2004; Collins et al., 2005) have described approaches that preprocess the source language input in SMT systems.
C04-1073 J04-2003 J96-1002 P05-1066
presented in Collins (1997).
P97-1003
The syntaxbased models of Yamada and Knight (2001) and Marcu et al.(2006) build a full parse tree in the target language, again effectively allowing hierarchical reordering based on synchronous grammars.
P01-1067 W06-1606
More sophisticated models include reordering parameters that are sensitive to lexical information (Tillmann, 2004; Kumar and Byrne, 2005; Koehn et al., 2005).
H05-1021 N04-4026
