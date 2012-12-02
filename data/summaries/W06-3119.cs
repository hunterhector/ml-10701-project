The hierarchical translation operations introduced in these methods call for extensions to the traditional beam decoder (Koehn et al., 2003a).
N03-1017
138 2 Rule Generation We start with phrase translations on the parallel training data using the techniques and implementation described in (Koehn et al., 2003a).
N03-1017
Therefore, after annotating the initial rules from the current training sentence pair, we adhere to (Chiang, 2005) to recursively generalize each existing rule; however, we abstract on a per-sentence basis.
P05-1033
Recent work in machine translation has evolved from the traditional word (Brown et al., 1993) and phrase based (Koehn et al., 2003a) models to include hierarchical phrase models (Chiang, 2005) and bilingual synchronous grammars (Melamed, 2004).
J93-2003 N03-1017 P04-1083 P05-1033
We then use Charniak’s parser (Charniak, 2000) to generate the most likely parse tree for each English target sentence in the training corpus.
A00-2018
• Baseline Pharaoh with phrases extracted from IBM Model 4 training with maximum phrase length 7 and extraction method ‘diag-growthfinal’ (Koehn et al., 2003a) • Lex Phrase-decoder simulation: using only the initial lexical rules from the phrase table, all with LHS X, the Glue rule, and a binary reordering rule with its own reordering-feature • XCat All nonterminals merged into a single X nonterminal: simulation of the system Hiero (Chiang, 2005).
N03-1017 P05-1033
Given a source sentence f, the preferred translation output is determined by computing the lowest-cost derivation (combination of hierarchical and glue rules) yielding f as its source side, where the cost of a derivation R1 ◦···◦Rn with respective feature vectors v1,...,vn ∈ Rm is given by msummationdisplay i=1 λi nsummationdisplay j=1 (vj)i. Here, λ1,...,λm are the parameters of the loglinear model, which we optimize on a held-out portion of the training set (2005 development data) using minimum-error-rate training (Och, 2003).
P03-1021
While (Yamada and Knight, 2002) represent syntactical information in the decoding process through a series of transformation operations, we operate directly at the phrase level.
P02-1039
We present results that compare our system against the baseline Pharaoh implementation (Koehn et al., 2003a) and MER training scripts provided for this workshop.
N03-1017
At initial submission time we simply re-scored a K-Best list extracted after first best parsing using the lazy retrieval process in (Huang and Chiang, 2005).
P05-1033 W05-1506
(Chiang, 2005) generates synchronous contextfree grammar (SynCFG) rules from an existing phrase translation table.
P05-1033
We use the following features for our rules: • sourceand target-conditioned neg-log lexical weights as described in (Koehn et al., 2003b) • neg-log relative frequencies: left-handside-conditioned, target-phrase-conditioned, source-phrase-conditioned • Counters: n.o. rule applications, n.o. target words • Flags: IsPurelyLexical (i.e., contains only terminals), IsPurelyAbstract (i.e., contains only nonterminals), IsXRule (i.e., non-syntactical span), IsGlueRule 139 • Penalties: rareness penalty exp(1 − RuleFrequency); unbalancedness penalty |MeanTargetSourceRatio ∗ ‘n.o.
N03-1017
While (Chiang, 2005) uses only two nonterminal symbols in his grammar, we introduce multiple syntactic categories, taking advantage of a target language parser for this information.
P05-1033
Each cell of the parsing process in (J.Earley, 1970) contains a set of hypergraph nodes (Huang and Chiang, 2005).
P05-1033 W05-1506
