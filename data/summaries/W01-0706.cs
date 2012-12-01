The first is the one used in the chunking competition in CoNLL-2000 (Tjong Kim Sang and Buchholz, 2000).
W00-0726
For example, the sentence “He reckons the current account deficit will narrow to only $ 1.8 billion in September.” would be chunked as follows (Tjong Kim Sang and Buchholz, 2000): [NP He ] [VP reckons ] [NP the current account deficit ] [VP will narrow ] [PP a1This research is supported by NSF grants IIS-9801638, ITR-IIS-0085836 and an ONR MURI Award.
W00-0726
Table 2 shows the results on identifying all phrases — chunking in CoNLL2000 (Tjong Kim Sang and Buchholz, 2000) terminology.
W00-0726
For the full parser, we use the one developed by Michael Collins (Collins, 1996; Collins, 1997) — one of the most accurate full parsers around.
P96-1025 P97-1003
First, it has been noted that in many natural language applications it is sufficient to use shallow parsing information; information such as noun phrases (NPs) and other syntactic sequences have been found useful in many large-scale language processing applications including information extraction and text summarization (Grishman, 1995; Appelt et al., 1993).
M95-1014
This is done using the “Chunklink” program provided for CoNLL-2000 (Tjong Kim Sang and Buchholz, 2000).
W00-0726
(See details in (Tjong Kim Sang and Buchholz, 2000).) The second definition used is that of atomic phrases.
W00-0726
However, since work in this direction has started, a significant progress has also been made in the research on statistical learning of full parsers, both in terms of accuracy and processing time (Charniak, 1997b; Charniak, 1997a; Collins, 1997; Ratnaparkhi, 1997).
P97-1003 W97-0301
The reported results for the full parse tree (on section 23) are recall/precision of 88.1/87.5 (Collins, 1997).
P97-1003
Church. 1988.
A88-1019
Since earlier versions of the SNoW based CSCL were used only to identify single phrases (Punyakanok and Roth, 2001; Munoz et al., 1999) and never to identify a collection of several phrases at the same time, as we do here, we also trained and tested it under the exact conditions of CoNLL-2000 (Tjong Kim Sang and Buchholz, 2000) to compare it to other shallow parsers.
W00-0726 W99-0621
Parsers Precision(a4 ) Recall(a4 ) a5a7a6 (a4 ) a8KM00 a9 93.45 93.51 93.48 a8Hal00 a9 93.13 93.51 93.32 a8CSCL a9 * 93.41 92.64 93.02 a8TKS00 a9 94.04 91.00 92.50 a8ZST00 a9 91.99 92.25 92.12 a8Dej00 a9 91.87 91.31 92.09 a8Koe00 a9 92.08 91.86 91.97 a8Osb00 a9 91.65 92.23 91.94 a8VB00 a9 91.05 92.03 91.54 a8PMP00 a9 90.63 89.65 90.14 a8Joh00 a9 86.24 88.25 87.23 a8VD00 a9 88.82 82.91 85.76 Baseline 72.58 82.14 77.07 2.2 Data Training was done on the Penn Treebank (Marcus et al., 1993) Wall Street Journal data, sections 02-21.
J93-2004
See (Tjong Kim Sang and Buchholz, 2000) for details.
W00-0726
The shallow parser used is the SNoW-based CSCL parser (Punyakanok and Roth, 2001; Munoz et al., 1999).
W99-0621
Thus, over the past few years, along with advances in the use of learning and statistical methods for acquisition of full parsers (Collins, 1997; Charniak, 1997a; Charniak, 1997b; Ratnaparkhi, 1997), significant progress has been made on the use of statistical learning methods to recognize shallow parsing patterns — syntactic phrases or words that participate in a syntactic relationship (Church, 1988; Ramshaw and Marcus, 1995; Argamon et al., 1998; Cardie and Pierce, 1998; Munoz et al., 1999; Punyakanok and Roth, 2001; Buchholz et al., 1999; Tjong Kim Sang and Buchholz, 2000).
A88-1019 P97-1003 P98-1010 P98-1034 W00-0726 W95-0107 W97-0301 W99-0621 W99-0629
