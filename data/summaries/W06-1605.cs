We used ASD cp (α BP 0BM99), Cos cp, JSD cp,andLin pmi 4 to populate corresponding concept–concept distance matrices and 4 Whereas Lin (1998) used relation-constrained DPs, in our experiments all DPs are relation-free.
P98-2127
Cooper. 2005.
J05-2004
A new bootstrapped WCCM is created, after a second pass of the corpus, in which the cell m ij contains the number of times any word used in sense c j co-occurs with w i .We have shown (Mohammad and Hirst, 2006) that the bootstrapped WCCM captures word–category cooccurrences much more accurately than the base WCCM, using the task of determining word sense dominance 3 as a test bed.
E06-1016
Using coarse senses from a known inventory means that the senses can be represented unambiguously by a large number of possibly ambiguous words (conveniently available in the thesaurus)—a feature that we exploited in our earlier work (Mohammad and Hirst, 2006) to determine useful estimates of the strength of association between a concept and co-occurring words.
E06-1016
While any of the measures of DP distance may be used with any of the measures of strength of association (see Table 1), in practice α-skew divergence (ASD), cosine, and Jensen–Shannon divergence (JSD) are used with conditional probability (CP), whereas Lin is used with PMI, resulting in the distributional measures ASD cp (Lee, 2001), Cos cp (Sch¨utze and Pedersen, 1997), JSD cp,andLin pmi (Lin, 1998), respectively.
P98-2127
On the other hand, published thesauri, such as Roget’s and Macquarie, group near-synonymous and semantically related words into a relatively small number of categories—typically between 800 and 1100—that roughly correspond to very coarse concepts or senses (Yarowsky, 1992).
C92-2070
Usually in 1 In our experiments, we set negative PMI values to 0, because Church and Hanks (1990), in their seminal paper on word association ratio, show that negative PMI values are not expected to be accurate unless co-occurrence counts are made from an extremely large corpus.
J90-1003
This is in contrast to studies, such as that of Cooper (2005), that attempt to make a principled distinction between them.
J05-2004
Typical relation-free DPs are those of Sch¨utze and Pedersen (1997) and Yoshida et al.(2003). Typical relation-constrained DPs are those of Lin (1998) and Lee (2001).
P98-2127
Work Patwardhan and Pedersen (2006) create aggregate co-occurrence vectors for a WordNet sense by adding the co-occurrence vectors of the words in its WordNet gloss.
W06-2501
Pantel (2005) also provides a way to create co-occurrence vectors for WordNet senses.
P05-1016
In an earlier paper (Mohammad and Hirst, 2006), we showed how this can be done with simple word sense disambiguation and bootstrapping techniques.
E06-1016
