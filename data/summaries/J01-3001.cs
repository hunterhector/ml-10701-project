The translation contains only 36,869 words tagged with LDOCE senses; however, this is a reasonable size for an evaluation corpus for the task, and it is several orders of magnitude larger than those used by other researchers working in large vocabulary WSD, for example Cowie, Guthrie, and Guthrie (1992), Harley and Glennon (1997), and Mahesh et al.(1997). This corpus was also constructed without the excessive cost of additional hand-tagging and does not introduce any of the inconsistencies that can occur with a poorly controlled tagging strategy.
C92-1056 W97-0212
This is consistent with the work of Resnik (1997), who reported that many words do not have strong enough selectional restrictions to carry out WSD.
W97-0209 W97-0213
The TiMBL algorithm has already been used for various NLP tasks including part-of-speech tagging and PP-attachment (Daelemans et al.1996; Zavrel, Daelemans, and Veenstra 1997).
W96-0102 W97-1016
Test corpora in which each ambiguous token has exactly two senses were used by Brown et al.(1991), Yarowsky (1995) and others.
P91-1034 P95-1026
These differences between the structures of LDOCE and Roget meant that we had to adapt the original algorithm reported in Yarowsky (1992).
C92-2070
324 Stevenson and Wilks Interaction of Knowledge Sources in WSD Yarowsky (1993) also examined the discriminatory power of the individual knowledge sources.
H93-1052
Gale, Church, and Yarowsky (1992a) suggest that the lowest level of performance which can be reasonably expected from a WSD system is that achieved by assigning the most likely sense in all cases.
C92-2070 H92-1045 P92-1032
The approach was made practical by Cowie, Guthrie, and Guthrie (1992) (see also (Wilks, Slator, and Guthrie 1996)).
C92-1056
1. Introduction Word sense disambiguation (WSD) is a problem long recognised in computational linguistics (Yngve 1955) and there has been a recent resurgence of interest, including a special issue of this journal devoted to the topic (Ide and V4ronis 1998).
J98-1001
Resnik and Yarowsky (1997) dubbed this the exact match metric, which is usually expressed 341 Computational Linguistics Volume 27, Number 3 as a percentage calculated according to the formula in (12).
W97-0209 W97-0213
Some researchers have concentrated on producing WSD systems that base results on a limited number of words, for example Yarowsky (1995) and Schtitze (1992) who quoted results for 12 words, and a second group, including Leacock, Towell, and Voorhees (1993) and Bruce and Wiebe (1994), who gave results for just one, namely interest.
C92-2070 H93-1051 P94-1020 P95-1026
In Section 4.3 we noted that Cowie et al.(1992) reported 47% correct disambiguation to the sense level using this technique, while in our adaptation over 17% more words are correctly disambiguated.
C92-1056
this result may seem intuitively obvious, there have, we believe, been no other attempts to quantify the benefit to be gained from the application of a part-ofspeech tagger in WSD (see Wilks and Stevenson 1998a).
P98-2228
Like Cowie, Guthrie, and Guthrie (1992), we shall give results at both levels, but it is worth pointing out that the targets of, say, work using translation equivalents (e.g., Brown et al.1991; Gale, Church, and Yarowsky 1992c; and see Section 2.3) and Roget categories (Yarowsky 1992; Masterman 1957) correspond broadly to the wider, homograph, distinctions.
C92-1056 C92-2070 H92-1045 P91-1034 P92-1032
Some of these types of collocation were also used by Brown et al.(1991) and Yarowsky (1993) (see Section 2.3).
H93-1052 P91-1034
Yarowsky (1992) reports that his algorithm achieves 92% correct disambiguation, which is nearly 13% higher than achieved in our implementation.
C92-2070
This consisted of 192,800 occurrences of the 121 nouns and 70 verbs that are "the most frequently occurring and ambiguous words in English" (Ng and Lee 1996, 44).
P96-1006
Resnik and Yarowsky (1997) noted that, for the most part, part-of-speech tagging is tackled using the noisy channel model, although transformation rules and grammaticostatistical methods have also had some success.
W97-0209 W97-0213
2.1 McRoy's System Early work on coarse-grained WSD based on combining knowledge sources was undertaken by McRoy (1992).
J92-1001
Learning applied to WSD An early application of machine learning to the WSD problem was carried out by Brown et al.(1991). Several different disambiguation cues, such as first noun to the left/right and second word to the left/right, were extracted from parallel text.
P91-1034
The approach was based on the hypothesis that words exhibited "one sense per collocation" (Yarowsky 1993).
H93-1052
Further details may be found in Yarowsky (1992).
C92-2070
Others, such as Harley and Glennon (1997) and ourselves Wilks and Stevenson (1998a, 1998b; Stevenson and Wilks 1999), have concentrated on approaches that disambiguate all content words.
P98-2228 W97-0212
Codes Our final partial tagger is a re-implementation of the algorithm developed by Yarowsky (1992).
C92-2070
Currently, machine learning methods (Yarowsky 1995; Rigau, Atserias, and Agirre 1997) and combinations of classifiers (McRoy 1992) have been popular.
C92-2070 J92-1001 P95-1026 P97-1007
Yarowsky (1995) dealt with this problem largely by producing an unsupervised learning algorithm that generates probabilistic decision list models of word senses from seed collocates.
P95-1026
Ng and Lee (1996) explored an approach to WSD in which a word is assigned the sense of the most similar example already seen.
P96-1006
Brill tagger uses the 48-tag set from the Penn Tree Bank (Marcus, Santorini, and Marcinkiewicz 1993), while LDOCE uses a set of 17 more general tags.
J93-2004
Gale, Church, and Yarowsky (1992a), Resnik and Yarowsky (1997), and Melamed and Resnik (2000) each presented arguments for adopting various evaluation strategies, with Resnik and Yarowsky's proposal directly influencing the set-up of SENSEVAL (Kilgarriff 1998).
C92-2070 H92-1045 P92-1032 W97-0209 W97-0213
We can see that, in this case, there is one correct sense, influence_l_la, the definition of which is "power to gain an effect on the mind of 5 An earlier version of this system (Stevenson and Wilks 1999) used TiMBL version 1.0 (Daelemans et al.1998), which supports only symbolic features.
P98-2228
Resnik and Yarowsky (1997) proposed to evaluate large vocabulary WSD systems by choosing a set of test words and providing annotated test and training examples for just these words, allowing supervised and unsupervised algorithms to be tested on the same vocabulary.
W97-0209 W97-0213
The CLS also produced a semantic tagger (Harley and Glennon 1997), a commercial product that tags words in text with senses from their MRD.
W97-0212
Bruce and Guthrie (1992) manually identified relations between the LDOCE semantic classes, grouping the codes into small sets with roughly the same meaning and attached descriptions; for example M, K are grouped as a pair described as "human male".
C92-4189
Both Ng and Lee (1996) and Yarowsky (1993) reported some results in the area.
H93-1052 P96-1006
2. Background A comprehensive review of WSD is beyond the scope of this paper but may be found in Ide and V4ronis (1998).
J98-1001
Yarowsky used smoothing procedures to compensate for data sparseness in the training corpus (detailed in Gale, Church, and Yarowsky \[1992b\]), which we did not implement.
C92-2070 H92-1045 P92-1032
Pragmatic information was used by Yarowsky (1992) whose approach relied upon statistical models of categories from Roget's Thesaurus (Chapman, 1977), a resource that had been used in much earlier approaches to WSD such as Masterman (1957).
C92-2070
This level of semantic disambiguation is frequently sufficient for choosing the correct target word in an English-to-French Machine Translation system and is at a similar level of granularity to the sense distinctions explored by other researchers in WSD, for example Brown et al.(1991), Yarowsky (1996), and McRoy (1992) (see Section 2).
C92-2070 J92-1001 P91-1034
Stevenson (1998) describes an evaluation of this system in which the relations identified were compared with those derived from Penn TreeBank parses (Marcus, Santorini, and Marcinkiewicz 1993).
J93-2004
The texts were then part-of-speech tagged using Brill's transformation-based learning tagger (Brill, 1995).
J95-4004
The common data set was the interest corpus constructed by Bruce and Wiebe (1994) consisting of 2,639 sentences from the Wall Street Journal, each containing an occurrence of the noun interest.
P94-1020
