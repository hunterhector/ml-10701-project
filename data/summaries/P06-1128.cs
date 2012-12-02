We first apply a deep parser (Miyao and Tsujii, 2005) and a dictionary-based term recognizer (Tsuruoka and Tsujii, 2004) to MEDLINE and obtain annotations of predicate argument structures and ontological identifiers of genes, gene products, diseases, and events.
P05-1011
Figure 1 shows an output of an HPSG parser (Miyao and Tsujii, 2005) for the sentence “A normal serum CRP measurement does not exclude deep vein thrombosis.” The dotted lines express predicate argument relations.
P05-1011
technologies Recently, state-of-the-art CFG parsers (Charniak and Johnson, 2005) can compute phrase structures of natural sentences at fairly high accuracy.
P05-1022
3.1 Off-line processing: HPSG parsing and term recognition We first parsed all sentences using an HPSG parser (Miyao and Tsujii, 2005) to obtain their predicate argument structures.
P05-1011
In addition, parsers that compute deeper analyses, such as predicate argument structures, have become available for 1018 the processing of real-world sentences (Miyao and Tsujii, 2005).
P05-1011
For example, GENA (Koike and Takagi, 2004) is a database of genes and gene products that is semi-automatically collected from well-known databases, including HUGO, OMIM, Genatlas, Locuslink, GDB, MGI, FlyBase, WormBase, Figure 1: An output of HPSG parsing Figure 2: A predicate argument structure CYGD, and SGD.
W04-3102
Because our target is biomedical texts, we re-trained a parser (Hara et al., 2005) with the GENIA treebank (Tateisi et al., 2005), and also applied a bidirectional part-ofspeech tagger (Tsuruoka and Tsujii, 2005) trained with the GENIA treebank as a preprocessor.
H05-1059 I05-2038
