• further steps of text analysis, e.g. light parsing or extraction of noun phrases or other phrases (Ait-Mokhtar and Chanod, 1997).
A97-1012
4 min b-FST (/~=0, a=0), =nO 87.21 26 585 11 000 1 181 6 se~ b-FST (fl=l,a=0), =nl 95.16 26 585 11 600 37 6 697 11 sec b-FST (~=2,a=0) 95.32 21 268 7 089 3 663 663 003 4 h 11 b-FST (fl=0, a=l) 93.691 199391 877 I 252 40243 12sec b-FST (fl=0,a=2) 93.92 19 334 114 10 554 l 246 686 j0 min b-FST (fl=2, a=l) "97.34 15 191 6 510 54 578 18 402 055 2 h 17 b-FST (fl=3, a=l) FST was not computable Language: English Corpora: 19 944 words for HMM training, 19 934 words for test Tag set: 36 tags, 181 classes * Multiple, i.e. ambiguous tagging results: Only first result retained Types of FST (Finite-State Transducers) : n0, nl n-type transducers (Kempe, 1997) s+nl (IM,FS) s-type transducer (Kempe, 1997), with subsequences of frequency > 8, from a training corpus of I 000 000 words, completed with nl-type b (fl=2,a=l) b-type transducer (sec.
P97-1059
The highest accuracy is obtained with a b-type FST with fl= 2 and a = 1 (b-FST (/3=2,~=1): 97.34 %) and with an s-type FST (Kempe, 1997) trained on 1 000 000 words (s+nl-FST (1M, F1): 97.33 %).
P97-1059
In some tests s-type FSTs (Kempe, 1997) and b-type FSTs reached equal tagging accuracy.
P97-1059
The training of the HMM can be done on either a tagged or untagged corpus, and is not a topic of this paper since it is exhaustively described in the literature (Bahl and Mercer, 1976; Church, 1988).
A88-1019
References Ait-Mokhtar, Salah and Chanod, Jean-Pierre (1997).
A97-1012
A b-type FST with $ = 0 and a = 0 is equivalent to an nO-type FST, and with $ = 1 and a = 0 it is equivalent to an nl-type FST (Kempe, 1997).
P97-1059
Roche, Emmanuel and Schabes, Yves (1995).
J95-2004
3). In figure 1, the tag t~ can be selected from the class ci because it is between two selected tags d which are t~_ 2 at a look-back distance of fl = 2 and t~2+2 at ZName given by the author, to distinguish the algorithm from n-type and s-type approximation (Kempe, 1997).
P97-1059
Chanod, Jean-Pierre and Tapanainen, Pasi (1995).
E95-1021
These rules can either be extracted automatically from a corpus (Brill, 1992) or written manually (Chanod and Tapanalnen, 1995).
A92-1021 E95-1021
Maxwell (p.c.), and n-type and stype approximation by Kempe (1997).
P97-1059
331-378. Karttunen, Lauri (1995).
P95-1003
The b-type FST with no look-back and no lookahead which is equivalent to an n0-type FST (Kempe, 1997), shows the lowest tagging accuracy (b-FST ()3=0, a=0): 87.21%).
P97-1059
2.4). 8This mode of retaining the first result only is not necessary with n-type and s-type transducers which are both sequential (Kempe, 1997).
P97-1059
* FSTs for light parsing, phrase extraction and other text analysis (Ait-Mokhtar and Chanod, 1997).
A97-1012
Ronneby. Brill, Eric (1992).
A92-1021
Among others, it can be composed with transducers that encode: • correction rules for the most frequent tagging errors which are automatically generated (Brill, 1992; Roche and Schabes, 1995) or manually written (Chanod and Tapanainen, 1995), in order to significantly improve tagging accuracy -9 . These rules may include long-distance dependencies not handled by ttMM taggers, and can conveniently be expressed by the replace operator (Kaplan and Kay, 1994; Karttunen, 1995; Kempe and Karttunen, 1996).
A92-1021 C96-2105 E95-1021 J94-3001 J95-2004 P95-1003
cmp-lg/9504032 Kempe, Andrd and Karttunen, Lauri (1996).
C96-2105
crap-lg/9607007 Kempe, Andrd (1997).
P97-1059
