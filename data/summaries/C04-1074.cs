(1) Given an anaphor and an antecedent, decide if the antecedent is the correct one (Ge et al., 1998; Soon et al., 2001; Ng and Cardie, 2002).
J01-4004 P02-1014 W98-1119
Apart from agreement, only two of Soon et al.(2001)’s features apply to pronominal anaphora: Sentence Recency, and NP Form (with personal pronouns only).
J01-4004
With regard to interaction of preferences, many algorithms (Hobbs, 1978; Strube, 1998; Tetreault, 2001) subscribe to a scheme, which, though completely rigid, performs surprisingly well: The chosen preferences are applied one after the other in a certain pre-defined order.
J01-4003 P98-2204
Like Lappin and Leass (1994), we replaced this implementation by our own mechanism to check binding constraints, which raised the success rate.
J94-4002
A cheap way to model information status is to consider the form of an antecedent (Tetreault, 2001; Soon et al., 2001; Strube and Müller, 2003).
J01-4003 J01-4004 P03-1022
There is less consensus on the preference order: (sentence-wise) left-to-right (Hobbs, 1978; Strube, 1998; Strube and Hahn, 1999; Tetreault, 1999) or right-to-left (recency) (Lappin and Leass, 1994).
J94-4002 J99-3001 P98-2204 P99-1079
For one, we used every possible antecedent 4On our data, Maximum Entropy (Kehler et al., 2004) had problems with the high baseline, i.e. proposed no antecedents.
N04-1037
To construct the training set, Soon et al.(2001) take the nearest correct antecedent in the previous context as a positive example, while all possible antecedents between this antecedent and the pronoun serve as negative examples.
J01-4004
Strube and Hahn (1999) extend the context to more than the last sentence, but switch preference order between the last and the current sentence so that an antecedent is determined in the last sentence, whenever possible.
J99-3001
(2) Given an anaphor and two antecedents, decide which antecedent is more likely to be the correct one (Yang et al., 2003).
P03-1023
Role Parallelism (Ng and Cardie, 2002) degraded performance (by 0.3% F-value).
P02-1014
Other proposals provide a more realistic picture in that they work as a backend to a parser (Lappin and Leass, 1994) or noun chunker (Mitkov, 1998; Soon et al., 2001; Ng and Cardie, 2002)).
J01-4004 J94-4002 P02-1014 P98-2143
Other Machine Learning approaches (Soon et al., 2001; Ng and Cardie, 2002; Yang et al., 2003) make use of decision tree learning4; we used C4.5 (Quinlan, 1993).
J01-4004 P02-1014 P03-1023
Lappin and Leass (1994) also adopt such a principle.
J94-4002
We considered two proposals for orderings of form: preferring pronouns and proper names over other NPs over indefinite NPs (Tetreault, 2001) (NF) or preferring pronouns over all other NPs (Tetreault, 2001) (NP).
J01-4003
In general, however, the required knowledge sources are lacking, so they must be hand-coded and can only be applied in restricted domains (Strube and Hahn, 1999).
J99-3001
The factors used in the algorithms and the algorithms themselves are evaluated on a German corpus annotated with syntactic and coreference information (Negra) (Skut et al., 1997).
A97-1014
Since only 1.6% of all pronouns are cataphoric, it seems reasonable to neglect cataphora, as is mostly done (Strube and Hahn, 1999; Hobbs, 1978).
J99-3001
Like (Ge et al., 1998), Strube (1998) evaluates on ideal hand annotated data.
P98-2204 W98-1119
Strube (1998)’s S-list algorithm is also restricted to the current and last sentence.
P98-2204
Strube (1998) and Strube and Hahn (1999) argue that the information status of an antecedent is more important than the grammatical role in which it occurs.
J99-3001 P98-2204
Ge et al.(1998)’s probabilistic approach combines three factors (aside from the agreement filter): the result of the Hobbs algorithm, Mention Count dependent on the position of the sentence in the article, and the probability of the antecedent occurring in the local context of the pronoun.
W98-1119
They supplement older heuristic approaches (Hobbs, 1978; Lappin and Leass, 1994).
J94-4002
(of up to 3%) by ranking embedding antecedents higher than embedded ones (Tetreault, 2001).
J01-4003
Learning Approaches Machine Learning approaches (Ge et al., 1998; Soon et al., 2001; Ng and Cardie, 2002) do not distinguish between filters and preferences.
J01-4004 P02-1014 W98-1119
Perhaps most obvious is the strategy implicit in Lappin and Leass (1994)’s algorithm: The antecedent is searched in a sentence that is as recent as possible, beginning with the already uttered part of the current sentence, continuing in the last sentence, in the one but last sentence, and so forth.
J94-4002
They provide restrictions on co-indexation of pronouns with clause siblings, and therefore can only be applied with systems that determine clause boundaries, i.e. parsers (Mitkov, 1998).
P98-2143
Thus the size of the annotated data (3,115 personal pronouns1, 2,198 possessive pronouns, 928 demonstrative pronouns) compares favourably with the size of evaluation data in other proposals (619 German pronouns in (Strube and Hahn, 1999), 2,477 English pronouns in (Ge et al., 1998), about 5,400 English coreferential expressions in (Ng and Cardie, 2002)).
J99-3001 P02-1014 P98-2204 W98-1119
We also used fractional numbers to express intrasentential word distance in addition to Soon et al.(2001)’s sentential distance.
J01-4004
Quality of linguistic input: Some proposals were evaluated on hand annotated (Strube and Hahn, 1999) or tree bank input (Ge et al., 1998; Tetreault, 2001).
J01-4003 J99-3001 P98-2204 W98-1119
Arguably, the free word-order of German arguably leads to a clearer distinction between grammatical function, surface order, and information status (Strube and Hahn, 1999).
J99-3001
Approaches Compared with the serialization approaches, the algorithm of Lappin and Leass (1994) is more sophisticated: It uses a system of hand-selected weights to control interaction among preferences, so that in principle the order of preference application can Algorithm Definition F-Scores – treebank F-Score total PPER PPOSAT PDS Parser (Hobbs, 1978) SRa0 CPa0 DEa0 LR 59.9 65.1 70.5 17.4 45.4 (Tetreault, 1999) SR2a0 DEa0 LR 57.0 64.1 61.9 17.2 43.3 (Strube, 1998) ISa0 SR2a0 LR 57.9 65.9 63.7 12.0 39.1 optimal algor.
J94-4002 P98-2204 P99-1079
Lappin and Leass (1994) motivate this preference as a dynamic expression of the attentional state of the human hearer: Memory capability for storage of discourse referents degrades rapidly.
J94-4002
Ge et al.(1998) try to factorize the same principle by counting the number of times a discourse entities has been mentioned in the discourse already.
W98-1119
The same corpus was also processed with a finite-state parser, performing at 80% dependency f-score (Schiehlen, 2003).
P03-1015
Selectional restrictions can also be modelled by collocational data extracted by a parser, which have, however, only a very small impact on overall performance (Kehler et al., 2004).
N04-1037
(parsed) SRa0 CPa0 GRa0 ISa0 DEa0 LR 67.7 74.3 82.0 10.6 50.6 (Lappin and Leass, 1994) EQa0 SRa0 RL 65.4 71.0 78.0 16.6 50.8 (Ge et al., 1998) Hobbs+MC 43.4 45.7 53.6 12.1 36.3 (Soon et al., 2001) (SR+NP)a0 RL 24.8 30.8 23.6 0.0 26.8 optimal algor.
J01-4004 J94-4002 W98-1119
The most notable exception to this equivalence are fronting constructions, where grammatical roles outperform surface order (Tetreault, 2001).
J01-4003
Lappin and Leass (1994) make use of a mechanism based on equivalence classes of discourse referents which manages the attentional properties of the individual entities referred to.
J94-4002
The role hierarchy used in centering (Brennan et al., 1987; Grosz et al., 1995) ranks subjects over direct objects over indirect objects over others.
J95-2003 P87-1022
Soon et al.(2001)’s algorithm performs below its potential.
J01-4004
The Left-Right Centering algorithm of Tetreault (1999) is similar to Hobbs’s algorithm, and is composed of the preferences Sentence Recency (without cataphora), Depth of Embedding, and left-to-right Surface Order.
P99-1079
Exceptions are existant but few (2.5%): abstract pronouns (such as that in English) referring to nonneuter or plural NPs, plural pronouns co-referring with singular collective NPs (Ge et al., 1998), antecedent and anaphor matching in natural gender 1Here, we only count anaphoric pronouns, i.e. third person pronouns not used expletively.
W98-1119
Some of them are based on centering theory (Strube, 1998; Strube and Hahn, 1999; Tetreault, 2001), others on Machine Learning (Aone and Bennett, 1995; Ge et al., 1998; Soon et al., 2001; Ng and Cardie, 2002; Yang et al., 2003).
J01-4003 J01-4004 J99-3001 P02-1014 P03-1023 P95-1017 P98-2204 W98-1119
Strube (1998)’s centering approach (whose sentence ordering is designated as SR2 in Table 2) also deals with and even prefers intrasentential anaphora, which raises the upper limit to a more acceptable 80.2%.
P98-2204
Scope of application: Some approaches only deal with personal and possessive pronouns (centering and heuristic), while others consider coreference links in general (Soon et al., 2001; Ng and Cardie, 2002; Yang et al., 2003).
J01-4004 P02-1014 P03-1023
Hard-core centering approaches only deal with the last sentence (Brennan et al., 1987).
P87-1022
Lappin and Leass (1994) provide a more elaborate model which ranks NP complements and NP adjuncts lowest.
J94-4002
The most important criterion in pronoun resolution (Lappin and Leass, 1994) is the textual distance between anaphor and antecedent measured in sentences.
J94-4002
