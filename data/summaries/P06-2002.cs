From the mid-nineties, there are systems that learn extraction patterns from partially annotated and unannotated data (Huffman, 1995; Riloff, 1996; Riloff and Schmelzenbach, 1998; Soderland, 1999).
W98-1106
pseudocode In order to identify the portions in common between the patterns, and to generalize them, we apply the following pseudocode (Ruiz-Casado et al., in press): 1All the PoS examples in this paper are done with Penn Treebank labels (Marcus et al., 1993).
J93-2004
Several similar approaches have been proposed (Brin, 1998; Agichtein and Gravano, 2000; Ravichandran and Hovy, 2002), with various applications: Question-Answering (Ravichandran and Hovy, 2002), multi-document Named Entity Coreference (Mann and Yarowsky, 2003), and generating 15 biographical information (Mann and Yarowsky, 2005).
P02-1006 P05-1060 W03-0405
An interesting approach is that of rote extractors (Brin, 1998; Agichtein and Gravano, 2000; Ravichandran and Hovy, 2002), which look for textual contexts that happen to convey a certain relationship between two concepts.
P02-1006
This is in line with Mann and Yarowsky (2003)’s modification, consisting in replacing all numbers in the patterns with the symbol ####.
W03-0405
In this case, Ravichandran and Hovy (2002)’s patterns resulted more precise as they do not contain disjunctions or wildcards.
P02-1006
For instance, Ravichandran and Hovy (2002) report the following patterns for the relationships Inventor, Discoverer and Location: Relation Prec.
P02-1006
This may just be the m characters to the left or to the right, (Brin, 1998), the longest common substring of several contexts (Agichtein and Gravano, 2000), or all substrings obtained with a suffix tree constructor (Ravichandran and Hovy, 2002).
P02-1006
On the other hand, we have rerun Ravichandran and Hovy (2002)’s algorithm on our corpus.
P02-1006
extractors According to the traditional definition of rote extractors (Mann and Yarowsky, 2005), they estimate the probability of a relationship r(p,q) given the surrounding contextA1pA2qA3.
P05-1060
It is interesting to note that, as could be expected, for those targets for which there is no entity type defined (films, books and pictures), Ravichandran and Hovy (2002)’s extracts many errors, because it is not possible to apply the Named Entity Recognizer to clean up the results, and the accuracy remains below 10%.
P02-1006
Generalizing textual patterns (both manually and automatically) for the identification of relationships has been proposed since the early nineties (Hearst, 1992), and it has been applied to extending ontologies with hyperonymy and holonymy relationships (Kietz et al., 2000; Cimiano et al., 2004; Berland and Charniak, 1999), with overall precision varying between 0.39 and 0.68.
C92-2082 P99-1008
We may consider it as mini-biographies as in Mann and Yarowsky (2005)’s system.
P05-1060
(1) HOOK,/, returned|travelled|born/VBN to|in/IN TARGET It is interesting that, among the three relationships with the smaller number of extracted patterns, one of them did not produce any result, and Ravichandran Relation Our approach and Hovy’s Actor-film 76.84% 1.71% Writer-book 28.13% 8.55% Birth-year 79.67% 49.49% Birth-place 14.56% 88.66% Country-capital 72.43% 24.79% Country-president 81.40% 16.13% Death-year 96.71% 35.35% Director-film 84.91% 1.01% Painter-picture 0.85% Player-team 52.50% 44.44% Table 5: Inclusion precision on the same test corpus for our approach and Ravichandran and Hovy (2002)’s.
P02-1006
Because of the difficulty of collecting annotated data, several procedures have been described that can be trained on unannotated textual corpora (Riloff and Schmelzenbach, 1998; Soderland, 1999; Mann and Yarowsky, 2005).
P05-1060 W98-1106
to related approaches Although the above results are not comparable to Mann and Yarowsky (2005), as the corpora used are different, in most cases the precision is equal or higher to that reported there.
P05-1060
Ravichandran and Hovy (2002) have noted that this might be dangerous if the wildcard matches unrestrictedly incorrect sentences.
P02-1006
In order to train a Rote extractor from the web, this procedure is usually followed (Ravichandran and Hovy, 2002): 1.
P02-1006
Hearst. 1992.
C92-2082
