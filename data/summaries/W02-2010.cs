We propose here a method that is similar in spirit to the O/C method, and also to Carreras and Màrquez (2001), Arévalo et al.(2002): 1.
W01-0726
The fnTBL-based NER system is designed in the same way as Brill’s POS tagger (Brill, 1995), consisting of a morphological stage, where unknown words’ chunks are guessed based on their morphological and capitalization representation, followed by a contextual stage, in which the full interaction between the words’ features is leveraged for learning.
J95-4004
TBL has some attractive qualities that make it suitable for the language-related tasks: it can automatically integrate heterogenous types of knowledge, without the need for explicit modeling (similar to Snow, Maximum Entropy, decision trees, etc); it is error–driven, therefore directly minimizes the Method Accuracy BY ACBPBD without capitalization information TnT 94.78% 66.72 MXPOST 95.02% 69.04 Snow 94.27% 65.94 fnTBL 94.92% 68.06 with capitalization information Snow (extended templates) 95.15% 71.36 fnTBL 95.57% 71.88 fnTBL+Snow 95.36% 73.49 Table 2: Comparative results for different methods on the Spanish development data ultimate evaluation measure: the error rate; and it has an inherently dynamic behavior 1. TBL has been previously applied to the English NER task (Aberdeen et al., 1995), with good results.
M95-1012
The leader of the pack is the MXPOST tagger (Ratnaparkhi, 1996).
W96-0213
Table 2 shows the performance of the fnTBL (Ngai and Florian, 2001) and Snow systems when using the capitalization information, both systems displaying considerably better performance.
N01-1006
In an approach similar to Zhou and Su (2002), we extracted for each word a 2-byte code, as summarized in Table 1.
P02-1060
As observed by participants in the MUC-6 and -7 tasks (Bikel et al., 1997; Borthwick, 1999; Miller et 1: Capitalization information 2: Presence in dictionary first_cap, all_caps, all_lower, number, punct, other upper, lower, both, none Table 1: Capitalization information al., 1998), an important feature for the NER task is information relative to word capitalization.
A97-1029
Transformation-based learning (Brill, 1995), Snow (sparse network of winnows (Muñoz et al., 1999)) and a forward-backward algorithm are stacked (the output of one classifier is passed as input to the next classifier), yielding considerable improvement in performance.
J95-4004
Approaches All approaches to the NER task presented in this paper, except the one presented in Section 3, use the IOB chunk tagging method (Tjong Kim Sang and Veenstra, 1999) for identifying the named entities.
E99-1023
