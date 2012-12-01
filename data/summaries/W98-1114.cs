However, although Resnik (1992), Schabes (1992), Carroll & Weir (1997) and others have proposed 'lexicalised' probabilistic grammars to improve the accuracy of parse rank~This work was funded by UK EPSRC project GR/L53175 'PSET: Practical Simplification of English Text', CEC Telematics Applications Programme project LE1-2111 'SPARKLE: Shallow PARsing and Knowledge extraction for Language Engineering', and by an EPSRC Advanced Fellowship to the first author.
C92-2065 C92-2066
Briscoe & Carroll (1997) present a small-scale experiment in which subcategorisation class frequency information for individual verbs w~us integrated into a robust statistical (non-lexicalised) parser.
A97-1052
So although it is now possible to extract at least subcategorisation data from large corpora 2 with 2Grishman & Sterling (1992), Poznanski & Sanfilippo (1993), Resnik (1993), Pdbas (1994), McCarthy (1997) and others have shown that it is possible also to a¢119 some degree of reliability, it would be difficult to integrate the data into this type of parsing system.
A92-1022 C92-2099 C94-1042 W93-0108 W97-0808
Gahl (1998) presents an extraction tool for use with the BNC that is able to create subcorpora containing different subcategorisation frames for verbs, nouns and adjectives, given the frames expected for each predicate.
P98-1071
The experiment used a test corpus of 250 sentences, and used the standard GEIG bracket precision, recall and crossing measures (Grishman, Macleod & Sterling, 1992) for evaluation.
A92-1022 C92-2099
Manning (1993) reports a larger experiment, also using a PoS tagged corpus and a finite-state NP parser, attempting to recognise sixteen distinct complementation patterns--although not with relative frequencies.
P93-1032
Future work will include: investigating more principled probabilistic models; addressing immediate lower-level shortcomings in the current system as discussed in section 3.4 above; adding mod(ification) GR annotations to the test corpus and extending the parser to also return these; and working on incorporating selectional preference information that we are acquiring in other, related work (McCarthy, 1997).
W97-0808
Magerman (1995), Collins (1996), Ratnaparkhi (1997), Charniak (1997) and others describe implemented systems with impressive accuracy on parsing unseen data from the Penn Treebank (Marcus, Santorini & Marcinkiewicz, 1993).
J93-2004 P95-1037 P96-1025 W97-0301
Inui et al.(1997) have recently proposed a novel model for probabilistic LR parsing which they justify as theoretically more consistent and principled than the Briscoe & Carroll (1993) model.
J93-1002
Briscoe & Carroll (1997) describe a system capable of distinguishing 160 verbal subcategorisation classes--a superset of those found in the ANLT and COMLEX Syntax dictionaries-returning relative frequencies for each frame found for each verb.
A97-1052
In this paper we address this issue, describing an experiment with an existing wide-coverage statistical grammar and parser for English (Carroll & Briscoe, 1996) in conjunction with subcategorisation frequencies acquired from 10 million words of text from the British National Corpus (BNC; Leech, 1992).
W96-0209
Briscoe & Carroll, 1997; Gahl, 1998; Carroll & Rooth, 1998) has opened up the possibility of producing largescale computational lexicons containing data on the relative frequencies of subcategorisation alternatives for individual verbal predicates.
A97-1052 P98-1071
They consider systematically a number of alternative probao bilistic formulations, including those of Resnik (1992) and Schabes (1992) and implemented systems based on other underlying grammatical frameworks, evaluating their adequacy from both a theoretical and empirical perspective in terms of their ability to model particular distributions of data that occur in existing treebanks.
C92-2065 C92-2066
Systems which are able to acquire a small number of verbal subcategorisation classes automatically from corpus text have been described by Brent (1991, 1993), and Ushioda et al.(1993). Ushioda et al.also derive relative subcategorisation frequency information for individual predicates.
J93-2002 P91-1027 W93-0109
• a fast generalised Lit parser using this grammar, taking the results of the tagger as input, and performing disambiguation using a probabilistic model similar to that of Briscoe & Carroll (1993); and • training and test treebanks (of 4600 and 500 sentences respectively) derived semiautomatically from the SUSANNE corpus (Sampson, 1995); The grammar consists of 455 phrase structure rule schemata in the format accepted by the parser (a syntactic variant of a Definite Clause Grammar with iterative (Kleene) operators).
J93-1002
Experiment 3.1 The Baseline Parser The baseline parsing system comprises: • an HMM part-of-speech tagger (Elworthy, 1994), which produces either the single highest-ranked tag for each word, or multiple tags with associated forward-backward probabilities (which are used with a threshold to prune lexical ambiguity); • a robust finite-state lemmatiser for English, an extended and enhanced version of the University of Sheffield GATE system morphological analyser (Cunningham et al., 1995); • a wide-coverage unification-based 'phrasal' grammar of English PoS tags and punctuation; quire selection preferences automatically from (partially) parsed data.
A94-1009
(%) (%) 'Baseline' 57.2 1.11 82.5 83.0 With subcat 56.6 1.10 83.1 83.1 Table 2: Bracketing evaluation measures, before and after incorporation of subcat information and zero crossings, the percentage of sentences for which the analysis returned has zero crossings (see Grishman, Macleod & Sterling, 1992).
A92-1022 C92-2099
We ran the Briscoe & Carroll (1997) subcategorisation acquisition system on the first 10 million words of the BNC, for each of these verbs saving the first 1000 cases in which a possible instance of a subcategorisation frame 120 AP NP_PP_PP PP_WHPP NONE NP_SCOMP PP_WHS NP NP_WHPP PP_WHVP NP_AP PP SCOMP NP_NP PP_AP S INF NP_NP_SCOMP PP_PP SING NP_PP PP_SCOMP SING_PP NP_PPOF PP_VPINF VPBSE VPINF VPING VPING_PP VPPRT WHPP Table h VSUBCAT values in the grammar.
A97-1052
the Alvey NL Tools (ANLT) dictionary, Boguraev et al.(1987); the COMLEX Syntax dictionary, Grishman, Macleod & Meyers (1994)).
C94-1042 P87-1027
In experiments measuring the coverage of our system (Carroll & Briscoe, 1996), we found that the mean length of failing sentences was little different to that of successfully parsed ones.
W96-0209
