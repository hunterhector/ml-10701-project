Using thesaurus categories directly as a coarse sense division may seem to be a viable alternative (Yarowsky 1995).
P95-1026
Sense Shift Ostler and Atkins (1991) contend that there is strong evidence to suggest that a large part of word sense ambiguity is not arbitrary but follows regular patterns.
W91-0208
TopSense is tested on 20 words extensively investigated in recent WSD literature (Schi~tze 1992; Yarowsky 1992; Luk 1995).
C92-2070 P95-1025 P95-1026
WSD has received increasing attention in recent literature on computational linguistics (Lesk 1986; Schi.itze 1992; Gale, Church, and Yarowsky 1992; Yarowsky 1992, 1995; Bruce and Wiebe 1995; Luk 1995; Ng and Lee 1996; Chang et al.1996). Given a polysemous word in running text, the task of WSD involves examining contextual information to determine the intended sense from a set of predetermined candidates.
C92-2070 P95-1025 P95-1026 P96-1006
As noted in Dolan (1994), it is possible to run a sense-clustering algorithm on several MRDs to build an integrated lexical database with more complete coverage of word senses.
C94-2113
Dolan (1994) describes a heuristic approach to forming unlabeled clusters of closely related senses in an MRD.
C94-2113
The semantic relations between the sense, the genus, and differentiae are reflected in what are termed categorical, functional, and situational clusters in McRoy (1992).
J92-1001
Krovetz (1992) observes that the LDOCE indicates explicit sense shifts via the deictic reference, which is a link to the previous sense created by such terms as this, these, that, those, its, itself, such a, and such an.
P92-1054
Much of the MRD-based research has focused on the analysis and exploitation of the sense definitions in MRDs (Amsler 1984a, 1984b, 1987; Alshawi 1987; Alshawi, Boguraev, and Carter 1989; Vossen, Meijs, and denBroeder 1989).
J87-3001 P84-1094 T87-1005
1. Introduction Word sense disambiguation (WSD) has been found useful in many natural language processing (NLP) applications, including information retrieval (Krovetz and Croft 1992; McRoy 1992), machine translation (Brown et al.1991; Dagan, Itai, and Schwall 1991; Dagan and Itai 1994), and speech synthesis (Yarowsky 1992).
C92-2070 J92-1001 J94-4003 P91-1017 P91-1034 P92-1054
Roget's has been used as the sense division in two recent WSD works (Yarowsky 1992; Luk 1995) more or less as is, except for a small number of senses added to fill gaps.
C92-2070 P95-1025 P95-1026
Chodorow, Byrd, and Heidom (1985) observe that many instances of intersense relations can be found in W7 that are not idiosyncratic, but rather exist among senses of many words.
P85-1037
In these works, the definitions are analyzed using either a parser (Montemagni and Vanderwende 1992) or a pattern matcher (Ahlswede and Evens 1988) into semantic relations.
C92-2083 P88-1027
(~ 1998 Association for Computational Linguistics Computational Linguistics Volume 24, Number 1 1995), (3) thesaurus categories (Yarowsky 1992; Chen and Chang 1994), (4) translation in another language (Gale, Church, and Yarowsky 1992; Dagan, Itai, and Schwall 1991; Dagan and Itai 1994), (5) automatically induced clusters with sublexical representation (Schiitze 1992), and (6) hand-crafted lexicons (McRoy 1992).
C92-2070 J92-1001 J94-4003 P91-1017
6. Other Approaches Sanfilippo and Poznanski (1992) propose a so-called dictionary correlation kit (DCK) in a dialogue-based environment for correlating word senses across a pair of MRDs such as the LDOCE and the LLOCE.
A92-1011
Along the same lines, Luk (1995) terms SP the definition-based concept (DBC) and proposes using DBC co-occurrence (DBCC) trained on a large corpus to disambiguate word senses.
P95-1025
The semantic relations and clusters have been shown to be very effective knowledge sources for such NLP tasks as WSD (McRoy 1992) and interpretation of noun sequences (Vanderwende 1994).
C94-2125 J92-1001
Lacking an automatic method, recent WSD works (Bruce and Wiebe 1995; Luk 1995; Yarowsky 1995) still resort to human intervention to identify and group closely related senses in an MRD.
P95-1025 P95-1026
These relations are then used for various tasks, ranging from the interpretation of a noun sequence (Vanderwende 1994) or a prepositional phrase (Ravin 1990), to resolving structural ambiguity (Jenson and Binot 1987), to merging dictionary senses for WSD (Dolan 1994).
C94-2113 C94-2125 P90-1033
It is a nontrivial task to divide the senses of a word and determine this set, for word sense is an abstract concept frequently based on subjective and subtle distinctions in topic, register, dialect, collocation, part of speech, and valency (McRoy 1992).
J92-1001
Details of extraction and disambiguation of the genus can be found in previous works (Guthrie et al.1990; Klavans, Chodorow, and Wacholder 1990; Copestake 1990; Ageno et al.1992). Disambiguated genus and differentiae terms can be used to construct a better taxonomy of word senses.
A92-1044 C90-3025
Yarowsky. 1992.
C92-2070
For instance, in Yarowsky (1992), the senses of star are divided into three Roget's categories, which roughly correspond to five LDOCE star senses labeled with LLOCE topics.
C92-2070
Yarowsky (1992) reports that there are uses not listed in Roget's for 3 of 12 nouns in his WSD study, while uses which a native speaker might consider as a single sense are often encoded in several Roget's categories.
C92-2070
Furthermore, as pointed out in Dolan (1994), the sense division in an MRD is frequently too fine-grained for the purpose of WSD.
C94-2113
Various approaches to word sense division have been proposed in the literature on WSD, including (1) sense numbers in every-day dictionaries (Lesk 1986; Cowie, Guthrie, and Guthrie 1992), (2) automatic or hand-crafted clusters of dictionary senses (Dolan 1994; Bruce and Wiebe 1995; Luk * Department of Computer Science, National Tsing Hua University, Hsinchu 30043, Taiwan, ROC.
C92-1056 C94-2113
82 Chen and Chang Topical Clustering Dolan (1994) maintains the position that intersense relations are mostly idiosyncratical, thereby making it difficult to characterize them in a general way so as to identify them.
C94-2113
For simplicity, we adopted the method proposed by Church (1988) to tag definition sentences.
A88-1019
Yarowsky (1992) describes a WSD method and an implementation based on Roget's Thesaurus and a very large corpus, the 10-million-word Grolier's Encyclopedia.
C92-2070
