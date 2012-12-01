Using the values computed above: p1 = k1n 1 p2 = k2n 2 p = k1+k2n 1+n2 Taking these probabilities to be binomially distributed, the log likelihood statistic (Dunning, 1993) is given by: 2 log = 2[log L(p1;k1;n1)+log L(p2;k2;n2) log L(p;k1;n2) log L(p;k2;n2)] where, log L(p;n;k)=k log p+(n k) log(1 p) According to this statistic, the greater the value of 2 log for a particular pair of observed frame and verb, the more likely that frame is to be valid SF of the verb.
J93-1003
We prepare the corpus by passing it through Adwait Ratnaparkhi’s part-of-speech tagger (Ratnaparkhi, 1996) (trained on the Penn Treebank WSJ corpus) and then running Steve Abney’s chunker (Abney, 1997) over the entire text.
W96-0213
This is often termed as the classification of verb diathesis roles or the lexical semantics of predicates in natural language (see (Levin, 1993; McCarthy and Korhonen, 1998; Stevenson and Merlo, 1999; Stevenson et al., 1999; Lapata, 1999; Lapata and Brew, 1999; Schulte im Walde, 2000)).
E99-1007 P98-2247 P99-1051 W99-0503 W99-0632
Following the method described in (Merlo and Stevenson, 2001; Stevenson and Merlo, 1999; Stevenson et This research was supported in part by NSF grant SBR-8920230.
E99-1007 J01-3003 W99-0503
This work shows that a subcategorization frame learning algorithm (Sarkar and Zeman, 2000) can be applied to the task of classifying verbs into verb alternation classes.
C00-2100
Our result can be compared to previous work (Merlo and Stevenson, 2001) which did not use SF learning but used a 65M word WSJ corpus which was tagged as well as automatically parsed with a Treebank trained statistical parser.
J01-3003
Our main contribution in this paper is to show that a subcategorization frame (SF) learning algorithm previously applied to Czech (Sarkar and Zeman, 2000) can be applied to English and evaluated by classifying verbs into verb alternation classes.
C00-2100
The discussion below clarifies 4See (Sarkar and Zeman, 2000) for information on how the threshold is selected.
C00-2100
We use the hypothesis introduced by (Stevenson and Merlo, 1999) that although a verb in a particular class can occur in all of the syntactic contexts as verbs from other classes the statistical distributions can be distinguished.
E99-1007 W99-0503
In future work, we would like to classify verbs into alternation classes on a per-token basis (as is done in the approach taken by Gildea (2002)) rather than the per-type we currently employ and also incorporate information about word senses in order to feasibly include verb alternation information in a statistical parser.
C02-1132
It is important to note that (Merlo and Stevenson, 2001) extract some features using the tagged information (in fact, those features that we use SF learning to extract) and other features using parse trees.
J01-3003
Note that the training and test data constructed from this set are produced by the classification of individual verbs into their respective classes taken from (Merlo and Stevenson, 2001).
J01-3003
ther background on this method of hypothesis testing the reader is referred to (Bickel and Doksum, 1977; Dunning, 1993).
J93-1003
Our results in this paper serve as a replication and extension of the results in (Merlo and Stevenson, 2001).
J01-3003 J01-3003
For example, in “John saw Mary yesterday at the station”, only “John” and “Mary” are required arguments while the other constituents are optional (adjuncts).3 The problem of SF identification using statistical methods has had a rich discussion in the literature (Ushioda et al., 1993; Manning, 1993; Briscoe and Carroll, 1997; Brent, 1994) (also see the refences cited in (Sarkar and Zeman, 2000)).
A97-1052 C00-2100 P93-1032 W93-0109
This work shows that a subcategorization frame (SF) learning algorithm previously applied to Czech (Sarkar and Zeman, 2000) is used to extract SFs in English.
C00-2100
The first four features were discussed and motivated in (Stevenson and Merlo, 1999; Merlo and Stevenson, 2001).
E99-1007 J01-3003 W99-0503
(Merlo and Stevenson, 2001) calculate the expert-based upper bound at this task to be an error rate of 13.5%.
J01-3003
1The examples are taken from (Merlo and Stevenson, 2001).
J01-3003
5Note that while (Stevenson and Merlo, 1999; Merlo and Stevenson, 2001) used a TRAN/INTRAN feature, in their case it was estimated in a completely di erent way using tagged data.
E99-1007 J01-3003 W99-0503
For example, (Stevenson and Merlo, 1999) show that a classifier can exploit these causativity facts to improve classifiction.
E99-1007 W99-0503
Following the method described in (Merlo and Stevenson, 2001), we exploit the distributions of some selected features from the local context of a verb.
J01-3003
Along with the techniques given in these papers, (Sarkar and Zeman, 2000; Korhonen et al., 2000) also discuss other methods for hypothesis testing such the use of the t-score statistic and the likelihood ratio test.
C00-2100 W00-1325
In comparison, (Merlo and Stevenson, 2001) obtain an error rate of 30.2% using a tagged and automatically parsed data set of 65M words of WSJ text.
J01-3003
We use some new features in addition to the ones proposed and used in (Merlo and Stevenson, 2001) for this task.
J01-3003
