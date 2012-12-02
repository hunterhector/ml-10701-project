Chang Word Alignment is beyond the reach of methods proposed in recent alignment works based on Brown et al.'s (1993) Model 1 and 2.
J93-2003
Other logical approaches involve aligning parse trees of a sentence and its translation (Matsumoto, Ishimoto, and Utsuro 1993; Meyers, Yangarber, and Grishman 1996), or simultaneously generating parse trees and alignment arrangements (Wu 1995).
C96-1078 P93-1004
For MT and other purposes, many methods have been proposed for sentence alignment of the Hansards, an English-French corpus of Canadian parliamentary debates (Brown, Lai, and Mercer 1991; Gale and Church 1991a; Sirnard, Foster, and Isabelle 1992; Chen 1993; Gale and Church 1993), and for other language pairs, including English-German, EnglishChinese, and English-Japanese (Kay and ROscheisen 1993; Church, Dagan, Gale, Fung, Helfman, and Satish 1993; Fung and McKeown 1994; Wu 1994).
H91-1026 J92-4003 J93-1004 J93-1006 J93-2003 P91-1022 P91-1023 P93-1002 P94-1012 W93-0301
(E17) monoxide (C17) --~q~ ('carbon monoxide') (E18) Basic (C18) :~ ('Basic Law') (E19) second (C19) -'~ ('second reading') Because it is not limited to the connections involved in a presegmented target sentence (Fung and McKeown 1994; Wu and Xai 1994), ClassAlign avoids most instances of these errors.
P94-1012
Gale and Church (1991b) present an alternative algorithm that does not estimate and store probabilities for all word pairs to reduce memory requirement and to ensure robustness of probability estimation.
H91-1026 P91-1023
Dagan, Church, and Gale (1993) observe that reliably distinguishing sentence boundaries for a noisy bilingual text scanned by an OCR device is quite difficult.
J93-1004 W93-0301
E-mail: ksj@volans.cs.scu.edu.tw; jschang@cs.nthu.edu.tw (~) 1997 Association for Computational Linguistics Computational Linguistics Volume 23, Number 2 In addition to machine translation, many applications for aligned corpora have been suggested, including machine-aided translation (Shemtov 1993), translation assessment and critiquing tools (Isabelle 1992; des Tombe and Armstrong-Warwick 1993; Macklovitch 1994), text generation (Smadja 1992; Smadja, McKeown, and Hatzivassiloglou 1996), bilingual lexicography (Klavans and Tzoukermann 1990; Church and Gale 1991; Daille, Gaussier, and Lange 1994; Kupiec 1993; van der Eijk 1993; Li 1994; Wu and Xia 1994), and word-sense disambiguation (Gale, Church, and Yarowsky 1992; Chang, Chen, Sheng, and Ker 1996).
C94-1084 E93-1054 H91-1026 J93-1004 J96-1001 P91-1023 P93-1003 P94-1012
Smadja, McKeown, and Hatzivassiloglou (1996) propose to link co-occurrence to the Dice coefficient in their study of bilingual collocations.
J96-1001
A section, paragraph, sentence, phrase, collocation, or word can be aligned to its translation (Kupiec 1993; Smadja, McKeown, and Hatzivassiloglou 1996).
J96-1001 P93-1003
The above observations can be stated formally from the perspective of Brown et al.'s (1993) Model 2.
J93-2003
0~:: ', the child 1 2 8 9 3 4 5 6 can be averted by performing alignment at various levels: parse tree (Matsumoto, Ishimoto, and Utsuro 1993; Meyers, Yangarber, and Grishman 1996), phrase (Kupiec 1993), and collocation (Smadja, McKeown, and Hatzivassiloglou 1996).
C96-1078 J96-1001 P93-1003 P93-1004
Such a formulation is inspired by Gale and Church's (1991b) treatment of distortion.
H91-1026 P91-1023
Morphological classes can be formed, either from words that start with the same five-character prefix as in Gale and Church (1991b), or rigorous analysis as suggested in Brown, Della Pietra, Della Pietra, Lafferty, and Mercer (1992).
H91-1026 J92-4003 P91-1023
A potential alternative involves adopting categories available in machine-readable lexicographic resources such as Roget's thesaurus (Chapman 1977) or hand-crafted computer lexicons (Miller, Beckwith, Fellbaum, Gross, and Miller 1990; McRoy 1992).
J92-1001
1. Introduction Brown, Cocke, Della Pietra, Della Pietra, Jelinek, Laffert~ Mercer, and Roosin (1990) advocate a statistical approach to machine translation (MT) and initiate much of the recent interest in bilingual corpora.
J90-2002
In the context of SMT, Brown et al.(1993) present a series of five models of Pr(S I T) for word alignment.
J93-2003
Brown et al.(1990) propose using an adaptive Expectation and Maximization (EM) algorithm to estimate the parameters for LTP and DP from a bilingual corpus.
J90-2002
Automatic statistical methods for derived classes (Brown, Della Pietra, deSouza, Lai, and Mercer 1992) are not appropriate, since they also suffer low coverage due to data sparseness.
J92-4003
