(Moldovan et al., 2000) details the empirical methods used in our system for transforming a natural language question into an IR query.
P00-1071
By implementing our own version of the publicly available Collins parser (Collins, 1996), we also learned a dependency model that enables the mapping of parse trees into sets of binary relations between the head-word of each constituent and its sibling-words.
P96-1025
For the parse of question Q210 the propagation is: NP (sled) DT NN DTIN manyHow WRB dogs NNSJJ NP (dogs) VBP pull a sled in the Iditarod NNP (Iditarod) NP (Iditarod) PP (Iditarod) NP (sled) VP (pull) S (pull) When the propagation is over, head-modifier relations are extracted, generating the following dependency structure, called question semantic form in (Harabagiu et al., 2000).
C00-1043
The expected answer type is determined based on the question stem, e.g. who, where or how much and eventually one of the question concepts, when the stem is ambiguous (for example what), as described in (Harabagiu et al., 2000) (Radev et al., 2000) (Srihari and Li, 2000).
A00-1021 A00-1023 C00-1043
For example, the parse tree of TREC-9 question Q210: “How many dogs pull a sled in the Iditarod ?” is: JJ S Iditarod VP NP PP NP NNPDTINNN NP DTVBPNNS NP manyHow WRB dogs pull a sled in the For each possible constituent in a parse tree, rules first described in (Magerman, 1995) and (Jelinek et al., 1994) identify the head-child and propagate the head-word to its parent.
H94-1052 P95-1037
Recent results from the TREC evaluations ((Kwok et al., 2000) (Radev et al., 2000) (Allen 1The Text REtrieval Conference (TREC) is a series of workshops organized by the National Institute of Standards and Technology (NIST), designed to advance the state-ofthe-art in information retrieval (IR) et al., 2000)) show that Information Retrieval (IR) techniques alone are not sufficient for finding answers with high precision.
A00-1021
Two classes of similar dependencies are considered for the abduction of answers, performed in a manner similar to the justifications described in (Harabagiu et al., 2000).a26 Class L3-1: is characterized by the need for contextual information, brought forward by reference resolution.
C00-1043
Answer extractions based on NE recognizers were also developed in the Q&A presented in (Abney et al., 2000) (Radev et al., 2000) (Gaizauskas and Humphreys, 2000).
A00-1021 A00-1041
Some Q&A systems, like (Moldovan et al., 2000) relied both on NE recognizers and some empirical indicators.
P00-1071
The first one, presented in (Harabagiu et al., 2000), the answer type is derived from a large answer taxonomy.
C00-1043
(Abney et al., 2000)).
A00-1041
Assuming that it is very likely that the answer is a named entity, (Srihari and Li, 2000) describes a NE-supported Q&A system that functions quite well when the expected answer type is one of the categories covered by the NE recognizer.
A00-1023
A different approach, based on statistical techniques was proposed in (Radev et al., 2000).
A00-1021
(Gaizauskas and Humphreys, 2000) (Harabagiu et al., 2000)) and used later in extracting the answer (cf.
C00-1043
(Cardie et al., 2000) presents a method of extracting answers as noun phrases in a novel way.
A00-1025
To decide which keywords should be expanded and what form of alternations should be used we rely on a set of heuristics which complement the heuristics that select the question keywords and generate the queries (as described in (Moldovan et al., 2000)): Heuristic 1: Whenever the first feedback loop requires the addition of the main verb of the question as a query keyword, generate all verb conjugations as well as its nominalizations.
P00-1071
