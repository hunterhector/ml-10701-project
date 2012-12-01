First, we associated a binary seed relation a0a2a1 for each each sub-topic a3 a1. (Seed relations were created both by hand and using the method presented in (Harabagiu, 2004)).
C04-1084
Later work by (Harabagiu, 2004) demonstrated that topic signatures can be further enhanced by discovering the most relevant relations that exist between pairs of concepts.
C04-1084
a0 Approach 2: Since individual documents may contain discourse segments pertaining to different sub-topics, we first used TextTiling (Hearst, 1994) to automatically segment all of the documents in the CNS collection into individual text tiles.
P94-1002
The notion of topic signatures was first introduced in (Lin and Hovy, 2000).
C00-1072
Once extraction relations were obtained for a particular set of documents, the resulting set of relations were ranked according to a method proposed in (Yangarber, 2003).
P03-1044
Since seed relations are by definition relevant to a particular subtopic, they can be used to determine a binary partition of the document collection a4 into (1) a relevant set of documents a5a6a1 (that is, the documents relevant to relation a0 a1 ) and (2) a set of non-relevant documents a4 -a5a6a1 . Inspired by the method presented in (Yangarber et al., 2000), a topic signature (as calculated by (Harabagiu, 2004)) is then produced for the set of documents in a5a7a1 . For each subtopic a3 a1 defined as part of the dialogue scenario, documents relevant to a corresponding seed relation a0 a1 are added to a5 iff the relation a0a8a1 meets the density criterion (as defined in (Yangarber et al., 2000)).
C00-2136 C04-1084
We use a semantic parser (described in (Surdeanu et al., 2003)) that recognizes predicate-argument structures.
P03-1002
“when” and (2) the relation between predicates, question stem and the words that determine the answer type (Narayanan and Harabagiu, 2004).
C04-1084 C04-1100
a0 Problem 2: We have found that the identification of the association between a candidate answer and a question depends on (a) the recognition of predicates and entities based on both the output of a named entity recognizer and a semantic parser (Surdeanu et al., 2003) and their structuring into predicate-argument frames, (b) the resolution of reference (addressed in Problem 1), (c) the recognition of implicit relations between predications stated in the answer.
P03-1002
(Salience-based relations are discovered using a technique first reported in (Harabagiu, 2004) which approximates a Centering Theory-style approach (Kameyama, 1997) to the resolution of coreference.) Subtopic: Egypt’s production of toxins and BW agents Topic Signature: produce − phosphorous trichloride (TOXIN) house − ORGANIZATION cultivate − non−pathogenic Bacilus Subtilis (TOXIN) produce − mycotoxins (TOXIN) acquire − FACILITY Subtopic: Egypt’s allies and partners Topic Signature: provide − COUNTRY cultivate − COUNTRY supply − precursors cooperate − COUNTRY train − PERSON supply − know−how Figure 3: Example of two topic signatures acquired for the scenario illustrated in Figure 2.
C04-1084 W97-1307
