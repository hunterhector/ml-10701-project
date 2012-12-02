On the one hand, terms are recognized in both source and target language and then they are mapped to each other (Daille, Gaussier and Langé, 1994).
C94-1084
Finally, Arhenberg, Andersson and Merkel (2000) as well as Lin and Cherry (2003) addressed the problem of full word alignment without restricting themselves to content words.
W03-0302
In this respect, the alignment method proposed is different from the ones developed by Wu (2000) as well as Lin and Cherry (2003): the former is based on synchronous parsing while the letter uses a dependency tree generated only in the source language.
W03-0302
Daille, Gaussier and Langé (1994), as well as Gaussier (1998) and Hull (2001), were interested in bilingual terminology extraction so that word alignment could not be considered as an end in itself but rather as a basis for term alignment.
C94-1084 P98-1074
Most alignment systems working on parallel corpora rely on statistical models, in particular the EM ones (Brown, Della Pietra and Mercer, 1993).
J93-2003
2003a. Linguistic Heuristics in Word Alignment, Proceedings of PACLing 2003.
W03-0302
The alignment between terms is obtained either by computing association probabilities (Gaussier, 1998 ; Daille, Gaussier and Langé, 1994) or by identifying, for a given source term, a sequence of words in the target language which is likely to contain or to correspond to its translation (Hull, 2001).
C94-1084 P98-1074
However, as pointed out by Arhenberg, Andersson and Merkel (2000) as well as Lin and Cherry (2003), the introduction of linguistic knowledge leads to a significant improvement in alignment quality.
W03-0302
Indeed, it is even often diffult for a human to determine which source unit correspond to which target unit within aligned sentences (Och and Ney, 2003).
J03-1002
However, concerning the approach proposed by Lin and Cherry (2003), it should be pointed out that linguistic knowledge is considered secondary to statistical information.
W03-0302
This kind of knowledge is quite rarely taken into account within the very alignment process, except for the approach implemented by Daille, Gaussier and Langé (1994), which try to take advantage of correspondences between the syntactic patterns defined for each language.
C94-1084
On the other hand, only source terms are extracted and the target ones are discovered through the alignment process (Gaussier, 1998; Hull, 2001).
P98-1074
Various and more or less complex sources of linguistic knowledge are exploited: morphological, lexical (Arhenberg, Andersson and Merkel, 2000) and syntactic knowledge (Wu, 2000; Lin and Cherry, 2003).
W03-0302
In so far as the precision rate may be affected by the number of alignments obtained (Daille, Gaussier and Langé, 1994; Gaussier, 1998), the results achieved basically range between 80% and 90%, for the first 500 alignments.
C94-1084 P98-1074
INRA JOC aligned sentences 7056 8774 anchor pairs 42570 58771 words/source sentence 21 25 words/target sentence 24 30 anchor pairs/sentence 6.38 6.77 precision (%) 98 99.3 5 Identification of anchor pairs To derive a list of words which are likely to be used to initiate the syntactic propagation process out of the corpus, we implemented a widely used method described notably in (Gale and Church, 1991; Ahrenberg, Andersson and Merkel, 2000) which is based on the assumption that the words which appear frequently in aligned text segments are potential translation equivalents.
H91-1026
