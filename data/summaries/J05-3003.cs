In a similar way to that of Sarkar and Zeman (2000), Marinov and Hemming’s system collects both arguments and adjuncts.
C00-2100
Many lexicons, both automatically acquired and manually created, are more fine grained in their approaches to subcategorized clausal arguments, differentiating, for example, between a that-clause and a to + infinitive clause (Ushioda et al.1993). With only a slight modification, our system, along with the details provided by the automatically generated f-structures, allows us to extract frames with an equivalent level of detail.
W93-0109
Briscoe and Carroll (1997) predefine 163 verbal subcategorization frames, obtained by manually merging the classes exemplified in the COMLEX (MacLeod, Grishman, and Meyers 1994) and ANLT (Boguraev et al.1987) dictionaries and adding around 30 frames found by manual inspection.
A97-1052 C94-1042 P87-1027
Ushioda et al.(1993) employ an additional statistical method based on log-linear models and Bayes’ theorem to filter the extra noise introduced by the parser and were the first to induce relative frequencies for the extracted frames.
W93-0109
Sarkar and Zeman (2000) evaluate 914 Czech verbs against a custom-made gold standard and record a token recall of 88%.
C00-2100
We have also applied our more general unification grammar acquisition methodology to the TIGER Treebank (Brants et al.2002) and Penn Chinese Treebank (Xue, Chiou, and Palmer 2002), extracting wide-coverage, probabilistic LFG grammar 361 Computational Linguistics Volume 31, Number 3 approximations and lexical resources for German (Cahill et al.2003) and Chinese (Burke, Lam, et al.2004). The lexical resources, however, have not yet been evaluated.
C02-1145 P04-1041
Cahill, McCarthy, et al.(2004) provide four classes of annotation principles: one for noncoordinate configurations, one for coordinate configurations, one for traces (long-distance dependencies), and a final “catch all and clean up” phase.
P04-1041
The gold standard is either manually custom-made based on the test data or adapted from an existing external resource such as the OALD (Hornby 1980) or COMLEX (MacLeod, Grishman, and Meyers 1994).
C94-1042
The extracted frames are noisy as a result of parser errors and so are filtered using the binomial hypothesis theory (BHT), following Brent (1993).
J93-2002
More recently, Burke, Cahill, et al.(2004a) carried out an evaluation of the automatic annotation algorithm against the publicly available PARC 700 Dependency Bank (King et al.2003), a set of 700 randomly selected sentences from Section 23 which have been parsed, converted to dependency format, and manually corrected and extended by human validators.
P04-1041
In this article we show how the extraction process can be scaled to the complete Wall Street Journal (WSJ) section of the Penn-II Treebank, with about one million words in 50,000 sentences, based on the automatic LFG f-structure annotation algorithm described in Cahill et al.(2002) and Cahill, McCarthy, et al.(2004). More recently we have extended the extraction approach to the larger, domain-diverse Penn-III Treebank.
P04-1041
Manning (1993) argues that, aside from missing domain-specific complementation trends, dictionaries produced by hand will tend to lag behind real language use because of their static nature.
P93-1032
As noted above, it is well documented (Roland and Jurafsky 1998) that subcategorization frames (and their frequencies) vary across domains.
P98-2184
It is important to realize that the induction of lexical resources is part of a larger project on the acquisition of wide-coverage, robust, probabilistic, deep unification grammar resources from treebanks Burke, Cahill, et al.(2004b). We are already using the extracted semantic forms in parsing new text with robust, wide-coverage probabilistic LFG grammar approximations automatically acquired from the f-structure-annotated Penn-II treebank, specifically in the resolution of LDDs, as described in Cahill, Burke, et al.(2004). We hope to be able to apply our lexical acquisition methodology beyond existing parse-annotated corpora (Penn-II and Penn-III): New text is parsed by our probabilistic LFG approximations into f-structures from which we can then extract further semantic forms.
P04-1041
Our approach is based on earlier work on LFG semantic form extraction (van Genabith, Sadler, and Way 1999) and recent progress in automatically annotating the Penn-II and Penn-III Treebanks with LFG f-structures (Cahill et al.2002; Cahill, McCarthy, et al.2004). Our technique requires a treebank annotated with LFG functional schemata.
P04-1041
The first step is to label each node as either a head, complement, or adjunct based on the approaches of Magerman (1994) and Collins (1997).
P97-1003
Manually defined heuristics are used to automatically annotate each tree in the treebank with partially specified HPSG derivation trees: Head/argument/modifier distinctions are made for each node in the tree based on Magerman (1994) and Collins (1997); 336 O’Donovan et al.Large-Scale Induction and Evaluation of Lexical Resources the whole tree is then converted to a binary tree; heuristics are applied to deal with phenomena such as LDDs and coordination and to correct some errors in the treebank, and finally an HPSG category is assigned to each node in the tree in accordance with its CFG category.
P97-1003
We evaluate the complete induced lexicon against the COMLEX resource (Grishman, MacLeod, and Meyers 1994) and present the results in Section 6.
C94-1042
Sixth, we evaluate the complete set of semantic forms extracted (not just a selection) against the manually constructed COMLEX (MacLeod, Grishman, and Meyers 1994) resource.
C94-1042
from Section 23 of the Penn Treebank as described in Cahill, McCarthy, et al.(2004). For the full set of annotations they achieve precision of over 96.5% and recall of over 96.6%.
P04-1041
Grishman, MacLeod, and Meyers (1994) acknowledge that this can lead to a preposition list which is “a little rich” for a particular verb, but this is the approach they have chosen to take.
C94-1042
and adjectives which take complements (Grishman, MacLeod, and Meyers 1994).
C94-1042
It has been shown (Roland and Jurafsky 1998) that the subcategorization tendencies of verbs vary across linguistic domains.
P98-2184
The extraction procedure utilizes a head percolation table as introduced by Magerman (1995) in combination with a variation of Collins’s (1997) approach to the differentiation between complement and adjunct.
P95-1037 P97-1003
We utilize the automatic annotation algorithm of Cahill et al.(2002) and Cahill, McCarthy, et al.(2004) to derive a version of Penn-II in which each node in each tree is annotated with LFG functional annotations in the form of attribute-value structure equations.
P04-1041
The extraction procedure consists of three steps: First, the bracketing of the trees in the Penn Treebank is corrected and extended based on the approaches of Magerman (1994) and Collins (1997).
P97-1003
Briscoe and Carroll (1997), by comparison, employ 163 distinct predefined frames.
A97-1052
In Charniak (1996) and Krotov et al.(1998), it was observed that treebank grammars (CFGs extracted from treebanks) are very large and grow with the size of the treebank.
P98-1115
The algorithm of Cahill, McCarthy, et al.(2004) translates the traces into corresponding reentrancies in the f-structure representation by treating null constituents as full nodes and recording the traces in terms of index=i f-structure annotations (Figure 3).
P04-1041
Manning (1993) attempts to improve on the approach of Brent (1993) by passing raw text through a stochastic tagger and a finite-state parser (which includes a set of simple rules for subcategorization frame recognition) in order to extract verbs and the constituents with which they co-occur.
J93-2002 P93-1032
However, more recent work (Cahill et al.2002; Cahill, McCarthy, et al.2004) has presented efforts in evolving and scaling up annotation techniques to the Penn-II Treebank (Marcus et al.1994), containing more than 1,000,000 words and 49,000 sentences.
H94-1020 P04-1041
Sarkar and Zeman (2000) present an approach to learn previously unknown frames for Czech from the Prague Dependency Bank (Hajic 335 Computational Linguistics Volume 31, Number 3 1998).
C00-2100
Brent (1993) relies on morphosyntactic cues in the untagged Brown corpus as indicators of six predefined subcategorization frames.
J93-2002
We evaluate our induced semantic forms against COMLEX (MacLeod, Grishman, and Meyers 1994), a computational machine-readable lexicon containing syntactic information for approximately 38,000 English headwords.
C94-1042
Briscoe and Carroll (1997) report on manually analyzing an open-class vocabulary of 35,000 head words for predicate subcategorization information and comparing the results against the subcategorization details in COMLEX.
A97-1052
Briscoe and Carroll (1997) refine the BHT with a priori information about the probabilities of subcategorization frame membership and use it to filter the induced frames.
A97-1052
A detailed discussion of the issues inherent in this process and a full analysis of results is presented in Burke, Cahill, et al.(2004a). Results broken down by grammatical function for the DCU 105 evaluation are presented in Table 3.
P04-1041
Ushioda et al.(1993) run a finite-state NP parser on a POS-tagged corpus to calculate the relative frequency of the same six subcategorization verb classes.
W93-0109
