Table 10: Comparison with related works CRL IREX Chunking Model for the word unit problem DATA GENERAL (Uchimoto et al., 2000) 80.17 ME Transformation rules (Yamada et al., 2002) 83.7 SVM Examples in training data are segmented (Takemoto et al., 2001) 83.86 Lexicon and Rules Compound lexicon (Utsuro et al., 2002) 84.07 Stacking (ME and Decision List) (Isozaki and Kazawa, 2002) 86.77 85.77 SVM with sigmoid curve Parameter control for a statistical morphological analyzer Our Method 87.21 SVM Chunking by Character Named Entity Chunkers by Stacking.
C02-1054 W02-1036
We use a support vector machine (SVM)based chunker yamcha (Kudo and Matsumoto, 2001) for the chunking process.
N01-1025
Isozaki (Isozaki and Kazawa, 2002) controls the parameters of a statistical morphological analyzer so as to produce more fine-grained output.
C02-1054
Isozaki (Isozaki and Kazawa, 2002) introduces the thesaurus – NTT Goi Taikei (Ikehara et al., 1999) – to augment the Table 5: The depth of redundant analysis and the extraction accuracy Pair Wise Method Depth of morph.
C02-1054
Table 2: Tags for positions in a word Tag Description S one-character word B first character in a multi-character word E last character in a multi-character word I intermediate character in a multi-character word (only for words longer than 2 chars) Table 3: Tags for character types Tag Description ZSPACE Space ZDIGIT Digit ZLLET Lowercase alphabetical letter ZULET Uppercase alphabetical letter HIRAG Hiragana KATAK Katakana OTHER Others (Kanji etc.) 3.3 Support Vector Machine-based Chunking We used the chunker yamcha (Kudo and Matsumoto, 2001), which is based on support vector machines (Vapnik, 1998).
N01-1025
Five chunk tag sets, IOB1, IOB2, IOE1, IOE2 (Ramshaw and Marcus, 1995) and SE (Uchimoto et al., 2000), are commonly used.
W95-0107
