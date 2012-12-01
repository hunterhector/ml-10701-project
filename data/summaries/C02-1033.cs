Thus, Table 1 confirms the fact reported in (Jobbins and Evett, 1998) that using collocations together with word recurrence is an interesting approach for text segmentation.
P98-1100
Collocations were extracted according to the method described in (Church and Hanks, 1990) by moving a window on texts.
J90-1003
This significance is defined as in (Kozima, 1993) as its normalized information in a reference corpus2: )1(log )(log)( 2 2 c cw S Sfwsignif − −= (2) where fw is the number of occurrences of the word w in the corpus and Sc, the size of the corpus.
P93-1041
corpus For English, we used the artificial corpus built by Choi (Choi, 2000) for comparing several segmentation systems.
A00-2004
0.14 0.21 0.10 0.18 0.13 0.17 w5w4w3w2w1 0.48 = pw3x0.18+pw4x0.13 +pw5x0.17 selected word from the collocation network (with its weight) 1.0 word from text (with p its weight in the window, equal to 0.21 link in the collocation network (with its cohesion value) 1.0 1.0 1.0 1.0 1.0 wi, n1 n2 1.0 for all words of the window in this example) 0.48 Figure 1 – Selection and weighting of words from the collocation network The building of the collocation vector for the window’s context comes from the procedure presented in (Ferret, 1998) for evaluating the lexical cohesion of a text.
P98-2243
As (Choi, 2000) or (Kaufmann, 1999), we use the cosine measure for evaluating the similarity between a vector of the context window (Vw) and the equivalent vector in the segment context (Vs): ∑∑ ∑ ⋅ ⋅ = i ix i ix ix i ix xx CwwwgCswwg CwwgwCswwg VwVssim 22 ),(),( ),(),( ),( (5) where wgx(wi,Cs,w}) is the weight of the word wi in the vector x (txt or coll) of the context Cs,w}.
A00-2004 P99-1077
SEGCOHLEX and SEGAPSITH are the systems described in (Ferret, 1998) and (Ferret and Grau, 2000).
P98-2243
Systems 3-11 3-5 6-8 9-11 baseline 0.45 0.38 0.39 0.36 CWM 0.09 0.10 0.07 0.05 U00 0.10 0.09 0.07 0.05 C99 0.12 0.11 0.09 0.09 DotPlot 0.18 0.20 0.15 0.12 Segmenter 0.36 0.23 0.33 0.43 TextTiling 0.46 0.44 0.43 0.48 TOPICOLL1 0.30 0.28 0.27 0.34 TOPICOLL2 0.31 0.28 0.28 0.34 Table 3 – Pk for C99 corpus The first seven lines of Table 3 results from Choi’s experiments (Choi, 2001).
W01-0514
Some systems exploit domain-independent knowledge about lexical cohesion: a network of words built from a dictionary in (Kozima, 1993); a large set of collocations collected from a corpus in (Ferret, 1998), (Kaufmann, 1999) and (Choi, 2001).
P93-1041 P98-2243 P99-1077 W01-0514
But work such as (Kozima, 1993), (Ferret, 1998) or (Kaufmann, 1999) showed that using a domainindependent source of knowledge for text segmentation doesn’t necessarily lead to get better results than work that is only based on word distribution in texts.
P93-1041 P98-2243 P99-1077
CWM is described in (Choi, 2001), U00 in (Utiyama and Isahara, 2001), C99 in (Choi, 2000), DotPlot in (Reynar, 1998) and Segmenter in (Kan et al., 1998).
A00-2004 P01-1064 W01-0514 W98-1123
Hybrid systems that combine the approaches we have presented were also developed and illustrated the interest of such a combination: (Jobbins and Evett, 1998) combined word recurrence, collocations and a thesaurus; (Beeferman et al., 1999) relied on both collocations and linguistic cues.
P98-1100
Most of those that achieve text segmentation only rely on the intrinsic characteristics of texts: word distribution, as in (Hearst, 1997), (Choi, 2000) and (Utiyama and Isahara, 2001), or linguistic cues as in (Passonneau and Litman, 1997).
A00-2004 J97-1003 J97-1005 P01-1064 W01-0514
