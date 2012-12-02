Of particular relevance is other work on parsing the Penn WSJ Treebank (Jelinek et al.1994; Magerman 1995; Eisner 1996a, 1996b; Collins 1996; Charniak 1997; Goodman 1997; Ratnaparkhi 1997; Chelba and Jelinek 1998; Roark 2001).
C96-1058 H94-1052 J01-2004 P01-1017 P95-1037 P96-1025 P97-1003 P98-1035 W97-0301
As a preprocessing step, the 14 In Collins (1999) we erroneously stated that all words occuring less than five times in training data were classified as “unknown.” Thanks to Dan Bikel for pointing out this error.
P99-1065
We first analyze the model of Magerman (1995) through three common examples of ambiguity: PP attachment, coordination, and appositives.
P95-1037
The precision and recall of the traces found by Model 3 were 93.8% and 90.1%, respectively (out of 437 cases in section 23 of the treebank), where three criteria must be met for a trace to be “correct”: (1) It must be an argument to the correct headword; (2) It must be in the correct position in relation to that headword (preceding or following); 15 Magerman (1995) collapses ADVP and PRT into the same label; for comparison, we also removed this distinction when calculating scores.
P95-1037
See Brill (1993) and Hermjakob and Mooney (1997) for rule-based learning systems.
P93-1035 P97-1062
The models of Magerman (1995) and Ratnaparkhi (1997) use contextual predicates that would most likely need to be modified given a different annotation style.
P95-1037 W97-0301
See Resnik (1992), Schabes (1992), and Schabes and Waters (1993) for work on stochastic tree-adjoining grammars.
C92-2065 C92-2066
We give a 1 Much of this article is an edited version of chapters 7 and 8 of Collins (1999).
P99-1065
Ratnaparkhi (1997) has an additional chunking stage, which means that the head noun does fall within the contextual window for the coordination and appositive cases.
W97-0301
We use the smoothing method described in Bikel et al.(1997), which is derived from a method described in Witten and Bell (1991).
A97-1029
Two models (Collins 2000; Charniak 2000) outperform models 2 and 3 on section 23 of the treebank.
A00-2018
Gildea (2001) reports on experiments investigating the utility of different features in bigram lexical-dependency models for parsing.
W01-0521
Appendix A of Collins (1999) for a description of how the head rules treat phrases involving coordination.
P99-1065
(See Collins [2002] for a discussion of other ways of conceptualizing the parsing problem.) In the Penn Treebank (Marcus, Santorini, and Marcinkiewicz 1993), which is the source of data for our experiments, the rules are either internal to the tree, where LHS is a nonterminal and RHS is a string of one or more nonterminals, or lexical, where LHS is a part-of-speech tag and RHS is a word.
J93-2004
Blaheta and Charniak (2000) describe methods for the recovery of the semantic tags in the Penn Treebank annotations, a significant step forward from the complement/adjunct distinction recovered in model 2 of the current article.
A00-2018 A00-2031
Finally, Bod (2001) describes a very different approach (a DOP approach to parsing) that gives excellent results on treebank parsing, comparable to the results of Charniak (2000) and Collins (2000).
A00-2018 P01-1010
Comparison to the Models of Jelinek et al.(1994), Magerman (1995), and Ratnaparkhi (1997) We now make a detailed comparison of our models to the history-based models of Ratnaparkhi (1997), Jelinek et al.(1994), and Magerman (1995).
H94-1052 P95-1037 W97-0301
See Hindle and Rooth (1991) for one of the earliest pieces of research on this topic in the context of prepositional-phrase attachment ambiguity.
P91-1030
(Note that these results show a slight improvement over those in (Collins 97); the main model changes were the improved treatment of punctuation (section 4.3) together with the addition of the P p and P cc parameters.) Model ≤ 40 Words (2,245 sentences) LR LP CBs 0 CBs ≤ 2 CBs Magerman 1995 84.6% 84.9% 1.26 56.6% 81.4% Collins 1996 85.8% 86.3% 1.14 59.9% 83.6% Goodman 1997 84.8% 85.3% 1.21 57.6% 81.4% Charniak 1997 87.5% 87.4% 1.00 62.1% 86.1% Model 1 87.9% 88.2% 0.95 65.8% 86.3% Model 2 88.5% 88.7% 0.92 66.7% 87.1% Model 3 88.6% 88.7% 0.90 67.1% 87.4% Charniak 2000 90.1% 90.1% 0.74 70.1% 89.6% Collins 2000 90.1% 90.4% 0.73 70.7% 89.6% Model ≤ 100 Words (2,416 sentences) LR LP CBs 0 CBs ≤ 2 CBs Magerman 1995 84.0% 84.3% 1.46 54.0% 78.8% Collins 1996 85.3% 85.7% 1.32 57.2% 80.8% Charniak 1997 86.7% 86.6% 1.20 59.5% 83.2% Ratnaparkhi 1997 86.3% 87.5% 1.21 60.2% — Model 1 87.5% 87.7% 1.09 63.4% 84.1% Model 2 88.1% 88.3% 1.06 64.0% 85.1% Model 3 88.0% 88.3% 1.05 64.3% 85.4% Charniak 2000 89.6% 89.5% 0.88 67.6% 87.7% Collins 2000 89.6% 89.9% 0.87 68.3% 87.7% and (3) It must be dominated by the correct nonterminal label.
A00-2018 P95-1037 P96-1025 P97-1003 W97-0301
Eisner and Satta (1999) also describe an O(n 3 ) algorithm for a restricted class of lexicalized grammars; it is an open question whether this restricted class includes the models in this article.
P99-1059
The rules are a modified version of a head table provided by David Magerman and used in the parser described in Magerman (1995).
P95-1037
find lexical heads in Penn Treebank data using the rules described in Appendix A of Collins (1999).
P99-1065
In the next two sections we give a detailed comparison of the models in this article to the lexicalized PCFG model of Charniak (1997) and the history-based models of Jelinek et al.(1994), Magerman (1995), and Ratnaparkhi (1997).
H94-1052 P95-1037 W97-0301
See Collins (1999) for a full description of the parsing algorithms.
P99-1065
Joshi and Srinivas (1994) describe an alternative “supertagging” model for tree-adjoining grammars.
C94-1024
We use the PARSEVAL measures (Black et al.1991) to compare performance: Labeled precision = number of correct constituents in proposed parse number of constituents in proposed parse Labeled recall = number of correct constituents in proposed parse number of constituents in treebank parse Crossing brackets = number of constituents that violate constituent boundaries with a constituent in the treebank parse For a constituent to be “correct,” it must span the same set of words (ignoring punctuation, i.e., all tokens tagged as commas, colons, or quotation marks) and have the same label 15 as a constituent in the treebank parse.
H91-1060
See Marcus et al.(1994) for an explanation of what these tags signify.
H94-1020
Punctuation Constraint As a final step, we use the rule concerning punctuation introduced in Collins (1996) to impose a constraint as follows.
P96-1025
Previous work—the generative models described in Collins (1996) and the earlier version of these models described in Collins (1997)—conditioned on punctuation as surface features of the string, treating it quite differently from lexical items.
P96-1025 P97-1003
Charniak (2000) describes a parsing model that also uses Markov processes to generate rules.
A00-2018
In particular, the model in Collins (1997) failed to generate punctuation, a deficiency of the model.
P97-1003
Collins et al.(1999) describe how the models in the current article were applied to parsing Czech.
P99-1065
See Alshawi (1996) for work on stochastic head-automata, and Lafferty, Sleator, and Temperley (1992) for a stochastic version of link grammar.
P96-1023
Charniak (2000) shows that using the POS tags as word class information in the model is important for parsing accuracy.
A00-2018
• Section 8 discussed relationships to the generative model of Charniak (1997) and the history-based (conditional) models of Ratnaparkhi (1997), Jelinek et al.(1994), and Magerman (1995).
H94-1052 P95-1037 W97-0301
justification for this is that there is an estimated 3% error rate in the hand-assigned POS tags in the treebank (Ratnaparkhi 1996), and we didn’t want this noise to contribute to dependency errors.
W96-0213
History-based approaches were introduced to parsing in Black et al.(1992). Roark (2001) describes a generative probabilistic model of an incremental parser, with good results in terms of both parse accuracy on the treebank and also perplexity scores for language modeling.
H92-1026 J01-2004
(Figure 3 gives an example that illustrates this.) The models in Collins (1996) showed that the distance between words standing in head-modifier relationships was important, in particular, that it is important to capture a preference for right-branching structures (which almost translates into a preference for dependencies between adjacent words) and a preference for dependencies not to cross a verb.
P96-1025
Eisner (2002) develops a sophisticated generative model for lexicalized context-free rules, making use of a probabilistic model of lexicalized transformations between rules.
W02-1009
Similar observations have been made in the context of tagging problems using maximum-entropy models (Lafferty, McCallum, and Pereira 2001; Klein and Manning 2002).
W02-1002
Charniak (2000) describes a series of enhancements to the earlier model of Charniak (1997).
A00-2018
Black et al.(1992) originally introduced history-based models for parsing.
H92-1026
Words in test data that have not been seen in training are deterministically assigned the POS tag that is assigned by the tagger described in Ratnaparkhi (1996).
W96-0213
We describe evaluation of the three models on the Penn Wall Street Journal Treebank (Marcus, Santorini, and Marcinkiewicz 1993).
J93-2004
For discussion of additional related work, chapter 4 of Collins (1999) attempts to give a comprehensive review of work on statistical parsing up to around 1998.
P99-1065
Section 6 gives results evaluating the performance of the models on the Penn Wall Street Journal Treebank (Marcus, Santorini, and Marcinkiewicz 1993).
J93-2004
In recent work, Chiang (2000) has shown that the models in the current article can be implemented almost unchanged in a stochastic tree-adjoining grammar.
P00-1058
For work that uses lexical relations for parse disambiguation— all with very promising results—see Sekine et al.(1992), Jones and Eisner (1992a, 1992b), and Alshawi and Carter (1994).
A92-1014 J94-4005
Miller et al.(2000) develop generative, lexicalized models for information extraction of relations.
A00-2030
Bikel 629 Collins Head-Driven Statistical Models for NL Parsing (2000) has developed generative statistical models that integrate word sense information into the parsing process.
W00-1320
The models were originally introduced in Collins (1997); the current article 1 gives considerably more detail about the models and discusses them in greater depth.
P97-1003
Seneff (1992) describes the use of Markov models for rule generation, which is closely related to the Markov-style rules in the models in the current article.
J92-1004
Charniak (2001) gives measurements of perplexity for a lexicalized PCFG.
P01-1017
The appendices of Collins (1999) give a precise description of the parsing algorithms, an analysis of their computational complexity, and also a description of the pruning methods that are employed.
P99-1065
Collins (1996) also describes a dependency-based model applied to treebank parsing.
P96-1025
the models described in Collins (1997), there was a third question concerning punctuation: (3) Does the string contain 0, 1, 2 or more than 2 commas?
P97-1003
See Eisner and Satta (1999) for an O(n 4 ) algorithm for lexicalized grammars that could be applied to the models in this paper.
P99-1059
A strength of these models is undoubtedly the powerful estimation techniques that they use: maximum-entropy modeling (in Ratnaparkhi 1997) or decision trees (in Jelinek et al.1994 and Magerman 1995).
H94-1052 P95-1037 W97-0301
Eisner (1996a, 1996b) describes several dependency-based models that are also closely related to the models in this article.
C96-1058
Chelba and Jelinek (1998) describe an incremental, history-based parsing approach that is applied to language modeling for speech recognition.
P98-1035
This hypothesis is suggested by previous work on specific cases of attachment ambiguity such as PP attachment (see, e.g., Collins and Brooks 1995), which has showed that models will perform better given lexical statistics, and that a straight structural preference is merely a fallback.
W95-0103
6. Results The parser was trained on sections 2–21 of the Wall Street Journal portion of the Penn Treebank (Marcus, Santorini, and Marcinkiewicz 1993) (approximately 40,000 sentences) and tested on section 23 (2,416 sentences).
J93-2004
Eisner (1996b) originally used POS tags to smooth a generative model in this way.
C96-1058
(Another important difference—the ability of models 1, 2, and 3 to generalize to produce context-free rules not seen in training data—was described in section 7.4.) Section 8.2 showed that the parsing models of Ratnaparkhi (1997), Jelinek et al.(1994), and Magerman (1995) can suffer from very similar problems to the “label bias” or “observation bias” problem observed in tagging models, as described in Lafferty, McCallum, and Pereira (2001) and Klein and Manning (2002).
H94-1052 P95-1037 W02-1002 W97-0301
The distance measure is similar to that in Collins (1996), a vector with the following two elements: (1) Is the string of zero length?
P96-1025
