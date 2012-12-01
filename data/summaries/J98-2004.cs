8. Previous Work In an earlier version of this paper (Caraballo and Charniak 1996), we presented the results for several of these models using our original grammar.
W96-0212
Miller and Fox (1994) compare the performance of parsers using three different types of grammars, and show that a probabilistic context-free grammar using inside probability (unnormalized) as a figure of merit outperforms both a context-free grammar and a context-dependent grammar.
H94-1051
Bobrow (1990) and Chitrao and Grishman (1990) introduced statistical agendabased parsing techniques.
H90-1053
Magerman and Weir (1992) use a similar model with a different parsing algorithm.
P92-1006
We parsed 500 sentences of length 3 to 30 (including punctuation) from the Penn Treebank Wall Street Journal corpus (Marcus, Santorini, and Marcinkiewicz 1993) using a best-first parsing method and various estimates for P(N~i,k I t0,,~) as the figure of merit.
J93-2004
A method for calculating O~L more efficiently can be derived from the calculations given in Jelinek and Lafferty (1991).
J91-3004
This can result in a "thrashing" effect as noted in Chitrao and Grishman (1990), where the system parses short constituents, even very low-probability ones, while avoiding combining them into longer constituents.
H90-1053
292 Caraballo and Charniak Figures of Merit Magerman and Marcus (1991) use the geometric mean to compute a figure of merit that is independent of constituent length.
H91-1044
Kochman and Kupin (1991) propose a figure of merit closely related to our prefix estimate.
H91-1045
