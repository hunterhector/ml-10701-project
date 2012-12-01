However, we would like to note that by a combination of suffix analysis and smoothing, Dubey (2005) was able to obtain an F-score of 85.2 for Negra.
P05-1039
To investigate the first issue, the Stanford Parser (Klein and Manning, 2003b), a state-of-the-art probabilistic parser, was trained with both lexicalized and unlexicalized versions of the two treebanks (Experiment I).
P03-1054
There have been a number of recent studies on probabilistic treebank parsing of German (Dubey, 2005; Dubey and Keller, 2003; Schiehlen, 2004; Schulte im Walde, 2003), using the Negra treebank (Skut et al., 1997) as their underlying data source.
A97-1014 C04-1056 P03-1013 P05-1039
An empirical proof for the assumption that flat phrase structures and the omission of unary nodes decrease parsing results is presented by K¨ubler (2005) and Maier (2006).
P06-3004
In fact, this assumption is by now so widely held that Schiehlen (2004) does not even consider lexicalization as a possible 1For English, see Collins (1999).
C04-1056
See Levy and Manning (2003) for a similar discussion of Chinese and the Penn Chinese Treebank.
P03-1056
Experiment II also confirms the finding of Klein and Manning (2003a) and of Schiehlen (2004) that horizontal and vertical markovization has a positive effect on parser performance.
C04-1056 P03-1054
For this reason, K¨ubler (2005) and Maier (2006) tested a version of Negra which contained information of the original attachment site of these discontinuous constituents.
P06-3004
There is evidence that the use of topological fields is advantageous also for other parsing approaches (Frank et al., 2003; K¨ubler, 2005; Maier, 2006).
P03-1014 P06-3004
Previous work, such as Dubey (2005), Dubey and Keller (2003), and Schiehlen (2004), uses the version of Negra in which the standard approach to resolving crossing branches has been applied.
C04-1056 P03-1013 P05-1039
The comparison of the experiments with (line 2) and without grammatical functions (line 1) confirms the findings of Dubey and Keller (2003) that the task of assigning correct grammatical functions is harder than mere constituent-based parsing.
P03-1013
This directly contradicts the findings reported by Dubey and Keller (2003) that lexicalization has a negative effect on probabilistic parsing models for German.
P03-1013
For other work in the area of treebank refinement using the German treebanks see K¨ubler (2005), Maier (2006), and Ule (2003).
P06-3004
This naturally raises the question whether German is just harder to parse or whether it is just hard to parse the Negra treebank.2 The purpose of this paper is to address precisely this question by training the Stanford parser (Klein and Manning, 2003b) and the LoPar parser (Schmid, 2000) on the two major treebanks available for German, Negra and T¨uBa-D/Z, the T¨ubingen treebank of written German (Telljohann et al., 2005).
P03-1054
