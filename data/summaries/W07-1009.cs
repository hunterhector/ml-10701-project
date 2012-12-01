of Speech Tagging and Chunking Our implementation of SEXTANT uses a maximum entropy POS tagger designed to be very efficient, tagging at around 100 000 words per second (Curran and Clark, 2003), trained on the entire Penn Treebank (Marcus et al., 1994).
W03-0424
others, Eisner (1996), McDonald et al. (2005a), and
H05-1124
McDonald et al.proposed an online large-margin method for training dependency parsers (McDonald et al., 2005).
H05-1124
R. McDonald, K. Crammer, and F. Pereira. 2005a. Online Large-Margin Training of Dependency Parsers. In Proceedings of ACL, pages 9198.
H05-1124
O(n2) time (McDonald et al., 2005b). Additional
H05-1124
The difficulty of this task is that the standard method for converting NER to a sequence tagging problem with BIOencoding (Ramshaw and Marcus, 1995), where each 1http://www.nist.gov/speech/tests/ace/ index.htm token is assigned a tag to indicate whether it is at the beginning (B), inside (I), or outside (O) of an entity, is not directly applicable when tokens belong to more than one entity.
W95-0107
(Shen et al., 2003) explored an adaptation of a general Hidden Markov Model-based term recognizer to biological domain.
W03-1307
5.2 Pre-processing All documents are passed through a sequence of preprocessing steps implemented using the LT-XML2 and LT-TTT2 tools (Grover et al., 2006) with the output of each step encoded in XML mark-up.
W06-2703
While Shen et al.(2003) and Zhang et al.(2004) report results testing on 4% of the abstracts in the GENIA corpus, Zhou et al.(2004) report 10-fold cross-validation scores.
W03-1307
Their corpus contains MEDLINE abstracts on the inhibition of the enzyme CYP450 (Kulick et al., 2004), specifically those abstracts that contain at least one overlapping and one discontinuous annotation.
W04-3111
The BioIE P450 corpus (Kulick et al., 2004), by contrast, includes chemicals, proteins and other substances such as foodstuffs in a single category called ?substance??
W04-3111
These are based on those found in (Curran and Clark, 2003).
W03-0424
Joakim Nivre, Johan Hall, Jens Nilsson, Gulsen Eryigitand Svetoslav Marinov. 2006. Labeled pseudo-projective dependency parsing with support vector machines. In Proceedings of CoNLL, pages 221225.
W06-3318
McDonald et al.(2005) propose structured multilabel classification as opposed to sequential labelling for dealing with nested, discontinuous, and overlapping NEs.
H05-1124
They extracted affix features in a similar way with (Shen et al., 2003).
W03-1307
All our results for NER are reported on the CoNLL-2003 shared task dataset (Tjong Kim Sang and De Meulder, 2003).
W03-0419
Gu (2006) reports results on recognising nested entities in the GENIA corpus (Version 3.02) when training an SVM-light binary classifier to recognise either proteins or DNA.
W06-3318
Tokenisation and sentence splitting is followed by part-ofspeech tagging with the Maximum Entropy Markov Model (MEMM) tagger developed by Curran and Clark (2003) (hereafter referred to as C&C ) for the CoNLL-2003 shared task (Tjong Kim Sang and De Meulder, 2003), trained on the MedPost data (Smith et al., 2004).
W03-0419 W03-0424
Information on lemmatisation, as well as abbreviations and their long forms, is added using the morpha lemmatiser (Minnen et al., 2000) and the ExtractAbbrev script of Schwartz and Hearst (2003), respectively.
W00-1427
However, as explicitly stated by Shen et al.(2003) and Zhang et al.(2004), this evaluation is limited to non-embedded (i.e.
W03-1307
In the algorithm, parsing states are represented by triples ?S,I,A?? where S is the stack that keeps the words being under consideration, I is the list of reDA RA CR (Yamada and Matsumoto, 2003) 90.3 91.6 38.4 (Nivre and Scholz, 2004) 87.3 84.3 30.4 (Isozaki et al., 2004) 91.2 95.7 40.7 (McDonald et al., 2005) 90.9 94.2 37.5 (McDonald and Pereira, 2006) 91.5 N/A 42.1 (Corston-Oliver et al., 2006) 90.8 93.7 37.6 Our Base Parser 90.9 92.6 39.2 Table 2: Comparison of parser performance.
H05-1124
McDonaldetal.(2005b) 84.4
H05-1124
feature set of McDonald et al. (2005a), and consists
H05-1124
Ryan McDonald, Koby Crammer, and Fernando Pereira. 2005a. Online large-margin training of dependency parsers. In Proceedings of ACL, pages 9198.
H05-1124
1We augment the McDonald et al. (2005a) feature set with
H05-1124
the conditions of previous work (McDonald et al., 2005b; Mc-
H05-1124
Setup 5.1 Corpora GENIA (V3.02), a large publicly available biomedical corpus annotated with biomedical NEs, is widely used in the text mining community (Cohen et al., 2005).
W05-1306
as the surrounding input (McDonald et al., 2005a;
H05-1124
Current approaches in biological term annotation can be generalized into three main categories: lexicon-based, rule-based and learning-based (Cohen and Hersh, 2005).
W05-1306
Shen et al.(2003), Zhang et al.(2004), and Zhou et al.(2004) all report on a rulebased approach to dealing with nested NEs in the GENIA corpus (Version 3.0) in combination with a Hidden Markov Model (HMM) that first recognises innermost NEs.
W03-1307
Dependency parsing has been actively studied in recent years (Yamada and Matsumoto, 2003; Nivre and Scholz, 2004; Isozaki et al., 2004; McDonald et al., 2005; McDonald and Pereira, 2006; Corston-Oliver et al., 2006).
H05-1124
Work In previous work addressing nested entities, Shen et al.(2003), Zhang et al.(2004), Zhou et al.(2004), Zhou (2006), and Gu (2006) considered the GENIA 2Both corpora are represented in XML with standoff annotation, potentionally allowing overlapping NEs.
W03-1307 W06-3318
Finally, a rule-based chunker marks up noun and verb groups and their heads (Grover and Tobin, 2006).
W06-2703
First, it recognizes non-recursive Base Noun Phrase (BNP) (our specifications for BNP resemble those in Ramshaw and Marcus 1995).
W95-0107
Both the GENIA corpus (Kim et al., 2003) and the BioIE cytochrome P450 corpus (Kulick et al., 2004) come with named entity annotations that include a proportion of chemicals, and at least a few abstracts that are recognisable as chemistry abstracts.
W04-3111
isons with previous work (McDonald et al., 2005b;
H05-1124
As the vanilla C&C tagger (Curran and Clark, 2003) is optimised for performance on newswire text, various modifications were applied to improve its performance for biomedical NER.
W03-0424
sensitivity (Eisner, 2000; McDonald et al., 2005b;
H05-1124
Ryan McDonald, Fernando Pereira, Kiril Ribarov, and Jan Hajic. 2005b. Non-projective dependency parsing using spanning tree algorithms. In Proceedings of HLT/EMNLP, pages 523530.
H05-1124
monds, 1967; McDonald et al., 2005b) as our first-
H05-1124
Because of the importance and complexity of the problem, biological term annotation has attracted intensive research and there is a large number of published work on this topic (Cohen and Hersh, 2005; Franzn et al., 2003).
W05-1306
As shown by (Cohen and Hersh, 2005), an accurate text classification system can be especially valuable to database curators.
W05-1306
R. McDonald, F. Pereira, K. Ribarov, and J. Hajic. 2005b. Non-Projective Dependency Parsing using Spanning Tree Algorithms. In Proceedings of HLT-EMNLP, pages 523530.
H05-1124
