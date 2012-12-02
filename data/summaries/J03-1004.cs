Following much recent work that applies the tools of machine learning to linguistic problems (Brill 1995; Pedersen 2000; van Halteren, Zavrel, and Daelemans 2001; Soon, Ng, and Lim 2001), we will treat the prediction of quantifier scope as an example of a classification task.
A00-2009 J01-2002 J01-4004 J95-4004
Systems such as the SRI Core Language Engine (Moran 1988; Moran and Pereira 1992), LUNAR (Woods 1986), and TEAM (Martin, Appelt, and Pereira 1986) have employed scope critics that use heuristics to decide between alternative scopings.
P88-1005
The data on which the quantifier scope classifiers are trained and tested is an extract from the Penn Treebank (Marcus, Santorini, and Marcinkiewicz 1993) that we have tagged to indicate the most salient scope interpretation of each sentence in context.
J93-2004
These include the naive Bayes classifier (Manning and Sch ¨utze 1999; Jurafsky and Martin 2000), maximum-entropy models (Berger, Della Pietra, and Della Pietra 1996; Ratnaparkhi 1997), and the single-layer perceptron (Bishop 1995).
J96-1002
Approaches to Quantifier Scope in Computational Linguistics Many studies, such as Pereira (1990) and Park (1995), have dealt with the issue of scope generation from a computational perspective.
J90-1001 P95-1028
LUNAR (Woods 1986), TEAM (Martin, Appelt, and Pereira 1986), and the SRI Core Language Engine as described by Moran (1988; Moran and Pereira 1992) all employ scope rules of this sort.
P88-1005
Hobbs and Shieber (1987) discuss the possibility of incorporating some sort of ordering heuristics into the SRI scope generation system, in the hopes of producing a ranked list of possible scope readings, but ultimately are forced to acknowledge that “[t]he modifications turn out to be quite complicated if we wish to order quantifiers according to lexical heuristics, such as having each out-scope some.
J87-1005
Krotov et al.[1998]; Belz [2001]) to facilitate the construction of a rule list.
P98-1115
For example, Moran (1988) incorporates rules from other NLP systems and from VanLehn (1978), such as a preference for a logically weaker interpretation, the tendency for each to take wide scope, and a ban on raising a quantifier across multiple major clause boundaries.
P88-1005
As Carletta (1996) notes, many tasks in computational linguistics are simply more difficult than the content analysis classifications addressed by Krippendorff, and according to Fleiss (1981), kappa values between .4 and .75 indicate fair to good agreement anyhow.
J96-2004
Another popular technique is to percolate scope information up through the syntactic tree using Cooper storage (Cooper 1983; Hobbs and Shieber 1987; Pollard 1989; Nerbonne 1993; Park 1995; Pollard and Yoo 1998).
J87-1005 P95-1028
Appendix: Selected Codes Used to Annotate Syntactic Categories in the Penn Treebank, from Marcus et al.(1993) and Bies et al.(1995) Part-of-speech tags Tag Meaning Tag Meaning CC Conjunction RB Adverb CD Cardinal number RBR Comparative adverb DT Determiner RBS Superlative adverb IN Preposition TO “to” JJ Adjective UH Interjection JJR Comparative adjective VB Verb in base form JJS Superlative adjective VBD Past-tense verb NN Singular or mass noun VBG Gerundive verb NNS Plural noun VBN Past participial verb NNP Singular proper noun VBP Non-3sg, presentNNPS Plural proper noun tense verb PDT Predeterminer VBZ 3sg, present-tense verb PRP Personal pronoun WP WH pronoun PRP$ Possessive pronoun WP$ Possessive WH pronoun 95 Higgins and Sadock Modeling Scope Preferences Phrasal categories Code Meaning Code Meaning ADJP Adjective phrase SBAR Clause introduced by ADVP Adverb phrase a subordinating INTJ Interjection conjunction NP Noun phrase SBARQ Clause introduced by PP Prepositional phrase a WH phrase QP Quantifier phrase (i.e., SINV Inverted declarative measure/amount sentence phrase) SQ Inverted yes/no S Declarative clause question following the WH phrase in SBARQ VP Verb phrase Acknowledgments The authors are grateful for an Academic Technology Innovation Grant from the University of Chicago, which helped to make this work possible, and to John Goldsmith, Terry Regier, Anne Pycha, and Bob Moore, whose advice and collaboration have considerably aided the research reported in this article.
J93-2004
