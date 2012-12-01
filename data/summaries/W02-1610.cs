GIZA++/RW As a second baseline, we used an off-the-shelf statistical MT system, consisting of the ISI ReWrite Decoder (Germann et al., 2001) together with a translation model produced by GIZA++ (Och and Ney, 2000) and a language model produced by the CMU Statistical Language Modeling Toolkit (Clarkson and Rosenfeld, 1997).
P00-1056 P01-1030
We suggest that alignment constraints such as this one can be used to define most of the possible syntactic divergences between languages (Dorr, 1994), and that only a handful of them are necessary for two given languages (we have identified 11 general alignment constraints @KOREAN: $X1 [aid=$1] ( $R1 $X2 [aid=$2] ) @ENGLISH: $Y1 [aid=$1] ( $R2 $Y2 ( $R3 $Y3 [aid=$2] ) ) Figure 4: Alignment constraint Each node of a candidate transfer rule must have its relation attribute (relationship with its governor) specified if it is an internal node, otherwise this relation must not be specified: e.g.
J94-4004
The proposed approach is inspired by examplebased machine translation (EBMT; Nagao, 1984; Sato and Nagao, 1990; Maruyama and Watanabe, 1992) and is similar to the recent works of (Meyers et al., 1998) and (Richardson et al., 2001) where transfer rules are also derived after aligning the source and target nodes of corresponding parses.
C90-3044 P98-2139 W01-1402
To enable the surface realization of the English parses via RealPro, we automatically converted the phrase structures of the English Tree Bank into deep-syntactic dependency structures (DSyntSs) of the Meaning-Text Theory (MTT) (Mel’ˇcuk, 1988) using Xia’s converter (Xia and Palmer, 2001) and our own conversion grammars.
H01-1014
We processed and combined these resources as follows: AF First, we replaced the inflected words with uninflected lexemes using Yoon’s morphological analyzer and a wide coverage English morphological database (Karp and Schabes, 1992).
C92-3145
Transfer component For transfer of the Korean parses to English structures, we used the same lexico-structural transfer framework as (Lavoie et al., 2000).
A00-1009
However, while (Meyers et al., 1998) and (Richardson et al., 2001) only consider parses and rules with lexical labels and syntactic roles, our approach uses parses containing any syntactic information provided by parsers (lexical labels, syntactic roles, tense, number, person, etc.), and derives rules consisting of any source and target tree sub-patterns matching a subset of the parse features.
P98-2139 W01-1402
Realizer For surface realization of the transferred English syntactic structures, we used the RealPro English realizer (Lavoie and Rambow, 1997).
A97-1039
