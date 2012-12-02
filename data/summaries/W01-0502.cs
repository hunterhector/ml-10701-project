Other word predictions tasks have also constructed manually the list of confusion sets (Lee and Pereira, 1999; Dagan et al., 1999; Lee, 1999) and justifications where given as to why this is a reasonable way to construct it.
P99-1004 P99-1005
Tagger Classifiers The domain in our experiment is defined using the following set of features, all of which are computed relative to the target word a127 a50 . Contextual Features (as in (Brill, 1995; Roth and Zelenko, 1998)): Let a128 a50a85a100 a28a22a19a75a83a85a128 a50a31a129 a28a80a89 be the tags of the word preceding, (following) the target word, respectively.
J95-4004 P98-2186
The results are only for known words and the results of Brill’s tagger (Brill, 1995) are presented for comparison.
J95-4004
All the classifiers in the sequential model, as well as the single classifier, use the SNoW learning architecture (Roth, 1998) with the Winnow update rule.
P98-2186
SNoW has already been used successfully on several tasks in natural language processing (Roth, 1998; Roth and Zelenko, 1998; Golding and Roth, 1999; Punyakanok and Roth, 2001).
P98-2186
In (Kudoh and Matsumoto, 2000) the methods of “all pairs” was used to learn phrase annotations for shallow parsing.
W00-0730
When trained as a single classifier (e.g., (Roth and Zelenko, 1998)), a8a27a141 uses each a128 -tagged example as a positive example for a128 and a negative example for all other tags.
P98-2186
(Even-Zohar and Roth, 2000) present a similar task in which the confusion sets generation was automated.
A00-2017
(In practice, one might want to use a more sophisticated baseline, as in (Dermatas and Kokkinakis, 1995).) a8a27a141 a8a69a142 a141 SM(a8a58a28a30a19a95a8 a38 a19a80a8a18a141 ) SM(a8a7a28a22a19a80a8 a38 a19a95a8a84a142 a141 ) a162a20a29a164a163 a44a6a163a20a29a31a21 a163a7a44a87a29a164a166 a166a39a137a87a29a164a5 Table 2: POS tagging of unknown words using contextual and lexical Features (accuracy in percent).
J95-2001
A partial list consists of Bayesian classifiers (Gale et al., 1993), decision lists (Yarowsky, 1994), Bayesian hybrids (Golding, 1995), HMMs (Charniak, 1993), inductive logic methods (Zelle and Mooney, 1996), memorya3 This research is supported by NSF grants IIS-9801638, IIS0085836 and SBR-987345.
P94-1013 W95-0104
Golding. 1995.
W95-0104
(iii) Lexical knowledge (for unknown words) and the word lemma (for known words) provide, w.h.p, one sided error (Mikheev, 1997).
J97-3003
based methods (Zavrel et al., 1997), linear classifiers (Roth, 1998; Roth, 1999) and transformationbased learning (Brill, 1995).
J95-4004 P98-2186 W97-1016
