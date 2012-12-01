It seems likely that automatic acquisition of such information must await successful techniques for robust parsing of, at least, phrases in corpora (though Brent \[1991\] claims to be able to recognize some subcategorization patterns using large quantities of untagged text).
P91-1027
However, it should be possible to restrict the set of features that are considered in category-valued features in an analogous way to Shieber's (1985) restrictors for Earley's (1970) algorithm, so that a parse table can still be constructed.
P85-1018
Church and Hanks 1989), because these apply to adjacent words in unanalyzed text.
P89-1010
Garside, Leech, and Sampson 1987; de Rose 1988; Meteer, Schwartz, and Weischedel 1991; Cutting et al.1992). Fujisaki et al.(1989) describe a corpus analysis experiment using a probabilistic CNF CFG containing 7550 rules on a corpus of 4206 sentences (with an average sentence length of approximately 11 words).
A92-1018
To avoid asking the user about lexical ambiguity, we use the technique of preterminal delaying (Shieber 1983), in which the assignment of an atomic preterminal category to a lexical item is not made until the choice is forced by the use of a particular production in a later reduce action.
P83-1017
Pollack and Pereira 1988).
P88-1010
We have, therefore, not found it necessary to use Schabes' (1991a) LR-like tables (with number of states guaranteed to be polynomial even in the worst case).
P91-1014
Results comparable to those obtained by Fujisaki et al.(1989) and Sharman, Jelinek, and Mercer (1990) are possible on the basis of a quite modest amount of manual effort and a very much smaller training corpus, because the parse histories contain little 'noise' and usefully reflect the semantically and pragmatically appropriate analysis in the training corpus, and because the number of failures of coverage were reduced to some extent by adding the rules specifically motivated by the training corpus.
H90-1054
A more promising approach with similar potential robustness would be to infer a probabilistic grammar using Baum-Welch re-estimation from a given training corpus and predefined category set, following Lari and Young (1990) and Pereira and Schabes (1992).
P92-1017
Kupiec (1991) extends Baum-Welch re-estimation to arbitrary (nonCNF) CFGs.
H91-1046
The existing chart parser, although slower, has been retained since it is more suited to grammar development, because of the speed with which modifications to the grammar can be compiled and its better debugging facilities (Boguraev et al.1988). Our nondeterministic LR parser is based on Kipps' (1989) reformulation of Tomita's (1987) parsing algorithm and uses a graph-structured stack in the same way.
C88-1012 J87-1004
Sharman, Jelinek, and Mercer (1990) conducted a similar experiment with a grammar in ID/LP format (Gazdar et al.1985; Sharman 1989).
H90-1054
For example, in noun compounds analyzed using a recursive binary-branching rule (N --* N N) the number of analyses correlates with the Catalan series (Church and Patil, 1982), 4 so a 3-word compound has 2 analyses, 4 has 5, 5 has 14, 9 has 1430, and so forth.
J82-3004
Our parser is thus similar to Tomita's (1987), except that it performs unifications rather than invoking CF rule augmentations; however, the main difference between our approach and Tomita's is the way in which the CF grammar that drives the parser comes into being.
J87-1004
Hindle and Rooth (1991) report good results using a mutual information measure of collocation applied within such a structurally defined context, and their approach should carry over to our framework straightforwardly.
P91-1030
We compare the performance of an optimized variant of Tomita's (1987) generalized LR parsing algorithm to an (efficiently indexed and optimized) chart parser.
J87-1004
Pereira and Schabes (1992) report an experiment using Baum-Welch re-estimation to infer a grammar and associated rule probabilities from a category set containing 15 nonterminals and 48 terminals, corresponding to the Penn Treebank lexical tagset (Santorini 1990).
P92-1017
By combining such techniques and relaxing the CNF constraint, for example, by adopting the trellis algorithm version of Baum-Welch re-estimation (Kupiec 1991), it might be possible to create a computationally tractable system operating with a realistic NL grammar that would only infer a new rule from a finite space of linguistically motivated possibilities in the face of parse failure or improbability.
H91-1046
From these figures, the ANLT grammar is more than twice the size of Tomita's (combined morphological and syntactic) grammar for Japanese (Tomita 1987:45).
J87-1004
Gale and Church 1990) and easier to gather from a corpus.
H90-1056
In this case, the LR parse table would be based on complex categories, with unification of complex categories taking the place of equality of atomic ones in the standard LR parse table construction algorithm (Osborne 1990; Nakazawa 1991).
E91-1013
Jensen et al.(1983) describe an approach to parsing such examples based on parse 'fitting' or rule 'relaxation' to deal with 'ill-formed' input.
J83-3002
One implication of this finding is that an approach to conflict resolution such as that of Shieber (1983) where reduce-reduce conflicts are resolved in favor of the longer reduction may not suffice to select a unique analysis for realistic NL grammars.
P83-1017
Pollack, M., and Pereira, E (1988).
P88-1010
Magerman and Marcus 1991) and the lexical category of the next word; for example, it would be possible to create a grammatical representation of the probabilistic model that emerges from a LR(0) table by assigning a set of probabilities associated with rule numbers to each right-hand side category in each rule of a CFG that would encode the probability of a rule being used to expand that category in that context.
E91-1004
Magerman and Marcus 1991), but only one global probability can be associated with the relevant CF production.
E91-1004
The 10,600 resultant entries were loaded into the ANLT morphological system (Ritchie et al.1987) and this sublexicon and the full ANLT grammar formed the starting point for the training process.
J87-3008
Grammars written in other, more low-level unification grammar formalisms, such as PATR-I1 (Shieber 1984), commonly employ treatments of the type just described to deal with phenomena such as gapping, coordination, and compounding.
P84-1075
Secondly, Church and Patil (1982) demonstrate that for a realistic grammar parsing realistic input, the set of possible analyses licensed by the grammar can be in the thousands.
J82-3004
Gotos State N NP PP S S' VP ....................................... 0 7 1 15 ....................................... 1 ....................................... 2 ....................................... 3 5 ....................................... 4 ....................................... 5 6 ....................................... 6 6 ....................................... 7 I0 14 ....................................... 8 9 ....................................... 9 i0 ....................................... i0 ....................................... ii 12 ....................................... 12 i0 ....................................... 13 ....................................... 14 ....................................... 15 31 Computational Linguistics Volume 19, Number 1 3.1 Creating LR Parse Tables from Unification Grammars Tomita (1987) describes a system for nondeterministic LR parsing of context-free grammars consisting of atomic categories, in which each CF production may be augmented with a set of tests (which perform similar types of operations to those available in a unification grammar).
J87-1004
Schabes 1991b).
P91-1014
Taylor, Grover, and Briscoe (1989) demonstrate that an earlier version of this grammar was capable of assigning the correct analysis to 96.8% of a corpus of 10,000 noun phrases extracted (without regard for their internal form) from a variety of corpora.
E89-1035
In addition, it violates the principle that grammatical formalisms should be declarative and defined independently of parsing procedure, since different definitions of the CF portion of the grammar will, at least, effect the efficiency of the resulting parser and might, in principle, lead to nontermination on certain inputs in a manner similar to that described by Shieber (1985).
P85-1018
We have implemented a unification version of Schabes' (1991a) chart-based LR-like parser (which is polynomial in sentence length for CF grammars), but experiments with the ANLT grammar suggest that it offers no practical advantages over our Tomita-style parser, and Schabes' table construction algorithm yields less fine-grained and, therefore, less predictive parse tables.
P91-1014
Although Tomita (1984:357) anticipates LR parsing techniques being applied to large NL grammars written in formalisms such as GPSG, the sizes of parse tables for such grammars grow more rapidly than he predicts.
P84-1073
