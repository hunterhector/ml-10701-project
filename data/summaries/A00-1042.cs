The need to determine the importance of a particular concept within a document is motivated by a range of applications, including information retrieval \[Salton 1989\], 303 automatic determination of authorship \[Mosteller and Wallace 1963\], similarity metrics for cross-document clustering \[Hatzivassiloglou et al.1999\], automatic indexing \[Hodges et al.1996\] and input to summarization \[Paice 1990\].
W99-0625
It is also important in NLP, where, for example, \[Strzalkowski 1997\] and \[Evans and Zhai 1996\] have used the distinction between heads and modifiers to add query terms to information retrieval systems.
A97-1044 P96-1003
We compare three shallow processing methods for identifying index terms: • Keywords (KW) are terms identified by counting frequency of stemmed words in a document; Technical terms (TT) are noun phrases (NPs) or subparts of NPs repeated more than twice in a document \[Justeson and Katz 1995\]; Head sorted terms (HS) are identified by a method in which simplex noun phrases (as defined below) are sorted by head and then ranked in decreasing order of frequency \[Wacholder 1998\].
W98-0610
Others, such as \[Church 1988\], have discussed a similar concept, sometimes called simple or base NPs.
A88-1019
We therefore did not use, for example, tf*idf, the purely statistical technique that is the used by most information retrieval systems, or \[Smadja 1993\], a hybrid statistical and symbolic technique for identifying collocations.
J93-1007
\[Wacholder 1998\] proposed the method of Head Sorting for identifying significant topics that can be used to represent a source document.
W98-0610
However, in terms of a combined quality and coverage metric, the Head Sorting (HS) method, described in \[Wacholder 1998\], outperforms both other methods, keyword (KW) and TT.
W98-0610
