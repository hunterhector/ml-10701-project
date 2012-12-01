The different lines for the second and the third methods correspond to different values ofa121 . The third method outperforms the other two methods unless the parse time is very limited (i.e., a122 1 4The PCFG used in creating the candidate parses is roughly the same as the one that Klein and Manning (2003) call a ‘markovised PCFG with vertical order = 2 and horizontal order = 1’ and was extracted from Section 02-20.
P03-1054
Several parsing algorithms that also use insideoutside calculation on packed chart have been proposed (Goodman, 1996b; Sima´an, 2003; Clark and Curran, 2004).
P04-1014 P96-1024 W96-0214
In those parsers, the strong conditional independence assumption made in vanilla treebank PCFGs is weakened by annotating non-terminal symbols with many ‘features’ (Goodman, 1997; Johnson, 1998).
J98-4004
Although we omit the details, we can prove the NP-hardness by observing that a stochastic tree substitution grammar (STSG) can be represented by a PCFG-LA model in a similar way to one described by Goodman (1996a), and then using the NP-hardness of STSG parsing (Sima´an, 2002).
P96-1024 W96-0214
The derivation of the estimation algorithm is largely omitted; see Pereira and Schabes (1992) for details.
P92-1017
Our result is lower than the state-of-the-art lexicalized PCFG parsers (Collins, 1999; Charniak, 1999), but comparable to the unlexicalized PCFG parser of Klein and Manning (2003).
P03-1054
Variants of PCFGs form the basis of several broadcoverage and high-precision parsers (Collins, 1999; Charniak, 1999; Klein and Manning, 2003).
P03-1054
This PCFG was also used in the experiment in Section 4.4. 81 a123 40 words LR LP CB 0 CB This paper 86.7 86.6 1.19 61.1 Klein and Manning (2003) 85.7 86.9 1.10 60.3 Collins (1999) 88.5 88.7 0.92 66.7 Charniak (1999) 90.1 90.1 0.74 70.1 a123 100 words LR LP CB 0 CB This paper 86.0 86.1 1.39 58.3 Klein and Manning (2003) 85.1 86.3 1.31 57.2 Collins (1999) 88.1 88.3 1.06 64.0 Charniak (1999) 89.6 89.5 0.88 67.6 Table 2: Comparison with other parsers.
P03-1054
Several recent work also use similar estimation algorithm as ours, i.e, inside-outside re-estimation on parse trees (Chiang and Bikel, 2002; Shen, 2004).
C02-1126
The algorithm is a special variant of the inside-outside algorithm of Pereira and Schabes (1992).
P92-1017
Henderson’s parsing model (Henderson, 2003) has a similar motivation as ours in that a derivation history of a parse tree is compactly represented by induced hidden variables (hidden layer activation of a neural network), although the details of his approach is quite different from ours.
N03-1014
