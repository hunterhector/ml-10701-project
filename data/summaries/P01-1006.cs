Our paper discusses a particular configuration of this new evaluation environment incorporating three approaches sharing a common ”knowledge-poor philosophy”: Kennedy and Boguraev’s (1996) parser-free algorithm, Baldwin’s (1997) CogNiac and Mitkov’s (1998b) knowledge-poor approach.
C96-1021 P98-2143 W97-1306
Kennedy and Boguraev (1996) manually removed 30 occurrences of pleonastic pronouns (which could not be recognised by their pleonastic recogniser) as well as 6 occurrences of it which referred to a VP or prepositional constituent.
C96-1021
Kennedy and Boguraev (1996), for example, need additional information about whether a certain discourse referent is embedded or not, plus a pointer to the COREF class associated to the referent, while Mitkov’s approach needs a score associated to each noun phrase.
C96-1021
Since the original version of CogNiac is non-robust and resolves only anaphors that obey certain rules, for fairer and comparable results we implemented the ”resolve-all” version as described in (Baldwin, 1997).
W97-1306
2.1 Pre-processing tools Parser The current version of the evaluation workbench employs one of the high performance ”super-taggers” for English Conexor’s FDG Parser (Tapanainen and J¨arvinen, 1997).
A97-1011
It is logical to assume that good anaphora resolution approaches should 4This definition is slightly different from the one used in (Baldwin, 1997) and (Gaizauskas and Humphreys, 2000).
W97-1306
Baldwin’s Cogniac CogNiac (Baldwin, 1997) is a knowledgepoor approach to anaphora resolution based on a set of high confidence rules which are successively applied over the pronoun under consideration.
W97-1306
We selected for comparative evaluation three approaches extensively cited in the literature: Kennedy and Boguraev’s parserfree version of Lappin and Leass’ RAP (Kennedy and Boguraev, 1996), Baldwin’s pronoun resolution method (Baldwin, 1997) and Mitkov’s knowledge-poor pronoun resolution approach (Mitkov, 1998b).
C96-1021 P98-2143 W97-1306
We have implemented four measures for evaluation: precision and recall as defined by Aone and Bennett (1995)4 as well as success rate and critical success rate as defined in (Mitkov, 2000a).
P95-1017
Kennedy and Boguraev Kennedy and Boguraev (1996) describe an algorithm for anaphora resolution based on Lappin and Leass’ (1994) approach but without employing deep syntactic parsing.
C96-1021 J94-4002
Tetreault. 1999.
P99-1079
We have already voiced concern (Mitkov, 1998a), (Mitkov, 2000b) that the evaluation of anaphora resolution algorithms and systems is bereft of any common ground for comparison due not only to the difference of the evaluation data, but also due to the diversity of pre-processing tools employed by each anaphora resolution system.
P98-2143
Finally, Ge at al’s (1998) and Tetrault’s systems (1999) 1For instance, the accuracy of tasks such as robust parsing and identification of pleonastic pronouns is far below 100% See (Mitkov, 2001) for a detailed discussion.
W98-1119
In (Dagan and Itai, 1990; Dagan and Itai, 1991; Aone and Bennett, 1995; Kennedy and Boguraev, 1996) pleonastic pronouns are removed manually2, whereas in (Mitkov, 1998b; Ferrandez et al., 1997) the outputs of the part-ofspeech tagger and the NP extractor/ partial parser are post-edited similarly to Lappin and Leass (1994) where the output of the Slot Unification Grammar parser is corrected manually.
C90-3063 C96-1021 J94-4002 P95-1017 P98-2143
pronouns, referential distance, average number of candidates for antecedent per pronoun and types of anaphors.7 As expected, the results reported in Table 1 do not match the original results published by Kennedy and Boguraev (1996), Baldwin (1997) and Mitkov (1998b) where the algorithms were tested on different data, employed different pre-processing tools, resorted to different degrees of manual intervention and thus provided no common ground for any reliable comparison.
C96-1021 P98-2143 W97-1306
Mitkov’s approach Mitkov’s approach (Mitkov, 1998b) is a robust anaphora resolution method for technical texts which is based on a set of boosting and impeding indicators applied to each candidate for antecedent.
P98-2143
