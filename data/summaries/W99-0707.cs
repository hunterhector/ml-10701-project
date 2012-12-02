The latter two use a transformation-based error-driven learning method \[Brill, 1992\].
A92-1021
As \[Argamon et al., 1998\] used only POS informaSubjects # subsequences • Method A,D&K .....
P98-1010
\[Ramshaw and Marcus, 1995\] L.A.
W95-0107
In \[Ramshaw and Marcus, 1995\], the method is used for NP chunking, and in \[Cardie and Pierce, 1998\] the approach is indirectly used to evaluate corpus-extracted NP chunking rules.
P98-1034 W95-0107
\[Daelemans et al., 1996\] W.
W96-0102
\[Brill, 1992\] E.
A92-1021
We also extensively compared our approach to a recently proposed new memory-based learning algorithm, memory-based sequence learning (MBSL, \[Argamon et al., 1998\] and showed that MBL, which is a computationally simpler algorithm than MBSL, is able to readl similar precision and recall when restricted to the MBSL definition of the NP chunking, subject detection and object detection tasks.
P98-1010
Similar cascading ideas have been explored in other approaches to text analysis: e.g. finite state partial parsing \[Abney, 1996, Grefenstette, 1996\], statistical decision tree parsing \[Magerman, 1994\], maximum entropy parsing \[Ratnaparkhi, 1997\], and memory-based learning \[Cardie, 1994, Daelemans et al., 1996\].
W96-0102
\[Zavrel and Daelemans, 1997\] J.
P97-1056 W97-1016
\[Cardie and Pierce, 1998\] C.
P98-1034
Moreover, the automatic feature weighting in the similarity metric of a memory-based learner makes the approach well-suited for domains with large numbers of features from heterogeneous sources, as it embodies a smoothing-by-similarity method when data is sparse \[Zavrel and Daelemans, 1997\].
P97-1056 W97-1016
Introduction Recently, there has been an increased interest in approaches to automatically learning to recognize shallow linguistic patterns in text \[Ramshaw and Marcus, 1995, Vilain and Day, 1996, Argamon et al., 1998, Buchholz, 1998, Cardie and Pierce, 1998, Veenstra, 1998, Daelemans et aI., 1999a\].
C96-1047 P98-1010 P98-1034 W95-0107
Combined with previous results on PP-attachment \[Zavrel et al., 1997\], the results presented here will be integrated into a complete shallow parser.
P97-1056 W97-1016
\[Argamon et al., 1998\] S.
P98-1010
In \[Daelemans et al., 1996\] both algorithms are explained in detail in the context ITiMBL is available from: http:\[/ilk.kub.nl/ of MBT, a memory-based POS tagger, which we presuppose as an available module in this paper.
W96-0102
We also present the results of \[Argamon et al., 1998\], \[Ramshaw and Marcus: 1995\] and \[Cardie and Pierce, 1998\] in Table 4.
P98-1010 P98-1034 W95-0107
\[Vilain and Day, 1996\] M.B.
C96-1047
\[Marcus et al., 1993\] M.
J93-2004
The approach is evaluated by cross-validation on the WSJ treebank corpus \[Marcus et al., 1993\].
J93-2004
Chunking For NP chunking, \[Argamon et al., 1998\] used data extracted from section 15-18 of the WS.J as a fixed train set and section 20 as a fixed test set, the same data as \[Ramshaw and Marcus, 1995\].
P98-1010 W95-0107
\[Zavrel et al., 1997\] J.
P97-1056 W97-1016
Since part of the chunking errors could be caused by POS errors, we also compared the same baseNP chunker on the santo corpus tagged with i) the Brill tagger as used in \[Ramshaw and Marcus, 1995\], ii) the Memory-Based Tagger (MBT) as described in \[Daelemans et al., 1996\].
W95-0107 W96-0102
Discussion and Related Research In \[Argamon et al., 1998\], an alternative approach to memox3'-based learning of shallow patterns, memorybased sequence learning (MBSL), is proposed.
P98-1010
