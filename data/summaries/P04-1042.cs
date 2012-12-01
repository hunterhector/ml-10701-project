Gildea and Jurafsky (2002) is to our knowledge the first use of such a feature for classification tasks on syntactic trees; they found it important for the related task of semantic role identification.
J02-3001
Knowledge of these hidden relationships is in turn essential to semantic interpretation of the kind practiced in the semantic parsing (Gildea and Jurafsky, 2002) and QA (Pasca and Harabagiu, 2001) literatures.
J02-3001
This approach contrasts with Johnson (2002), who treats empty/antecedent identification as a joint task, and with Dienes and Dubey (2003a,b), who always identify empties first and determine antecedents later.
P02-1018 P03-1013 P03-1055 W03-1005
This was the approach taken by Dienes and Dubey (2003a,b) and Dienes (2003); it is also practiced in recent work on broad-coverage CCG parsing (Hockenmaier, 2003).
P03-1013 P03-1055 W03-1005
Jn is Johnson (2002); DD is Dienes and Dubey (2003b); Pres is the present work.
P02-1018 P03-1013 P03-1055 W03-1005
Traditional LFG parsing, in both non-stochastic (Kaplan and Maxwell, 1993) and stochastic (Riezler et al., 2002; Kaplan et al., 2004) incarnations, also divides the labor of local and nonlocal dependency identification into two phases, starting with context-free parses and continuing by augmentation with functional information.
N04-1013 P02-1035
style (Gazdar et al., 1985) parsers, and in concrete terms it closely matches the information derived from Johnson (2002)’s connected local tree set patterns.
P02-1018
The datasets used for this study consist of the Wall Street Journal section of the Penn Treebank of English (WSJ) and the context-free version of the NEGRA (version 2) corpus of German (Skut et al., 1997b).
A97-1014
Johnson (2002) was the first post-processing approach to non-local dependency recovery, using a simple pattern-matching algorithm on context-free trees.
P02-1018
The italicized node is the node for which a given feature is recorded; underscores indicate variables that can match any category; and the angle-bracketed parts of the tree fragment, together with an index for the pattern, determine the feature value.8 4 Evaluation 4.1 Comparison with previous work Our algorithm’s performance can be compared with the work of Johnson (2002) and Dienes and Dubey (2003a) on WSJ.
P02-1018 P03-1013 P03-1055 W03-1005
Note that the dependency figures of Dienes lag behind even the parsed results for Johnson’s model; this may well be due to the fact that Dienes built his model as an extension of Collins (1999), which lags behind Charniak (2000) by about 1.3-1.5%.
A00-2018
To further compare the results of our algorithm with previous work, we obtained the output trees produced by Johnson (2002) and Dienes (2003) and evaluated them on typed dependency performance.
P02-1018 P03-1055 W03-1005
3For a detailed description of the algorithm for creating the context-free version of NEGRA, see Skut et al.(1997a). S VAFIN VP $, $.
A97-1014
P is parser, G is string-to-context-free-gold-tree mapping, A is present remapping algorithm, J is Johnson 2002, D is the COMBINED model of Dienes 2003.
P02-1018 P03-1055 W03-1005
Dienes and Dubey (2003a,b) and Dienes (2003) approached the problem by preidentifying empty categories using an HMM on unparsed strings and threaded the identified empties into the category structure of a context-free parser, finding that this method compared favorably with both Collins’ and Johnson’s.
P03-1013 P03-1055 W03-1005
State-of-the-art statistical parsing is far better on WSJ (Charniak, 2000) than on NEGRA (Dubey and Keller, 2003), so for comparison of parser-composed dependency performance we used vanilla PCFG models for both WSJ and NEGRA trained on comparably-sized datasets; in addition to making similar types of independence assumptions, these models performed relatively comparably on labeled bracketing measures for our development sets (73.2% performance for WSJ versus 70.9% for NEGRA).
A00-2018 P03-1013
Our motivation is that it should generally be easier to determine whether an overt element is dislocated than whether a given position is the origin of some yet unknown dislocated element (particularly in the absence of a sophisticated model of argument expression); but control loci are highly predictable from local context, such as the subjectless non-finite S in Figure 1’s S-2.5 Indeed this difference seems to be implicit in the nonlocal feature templates used by Dienes and Dubey (2003a,b) in their empty element tagger, in particular lookback for whwords preceding a candidate verb.
P03-1013 P03-1055 W03-1005
We note that Klein and Manning (2003) independently found retention of temporal NP marking useful for PCFG parsing.
P03-1054
Experiments described in Section 4.3 used the same development and test sets but files 200-959 of WSJ as a smaller training set; for NEGRA we followed Dubey and Keller (2003) in using the first 18,602 sentences for training, the last 1,000 for development, and the previous 1,000 for testing.
P03-1013
In Table 2 we present comparative results, using the PARSEVAL-based evaluation metric introduced by Johnson (2002) – a correct empty category inference requires the string position of the empty category, combined with the left and right boundaries plus syntactic category of the antecedent, if any, for purposes of comparison.9,10 Note that this evaluation metric does not require correct attachment of the empty category into 8A complete description of feature templates can be found at http://nlp.stanford.edu/˜rog/acl2004/templates/index.html 9For purposes of comparability with Johnson (2002) we used Charniak’s 2000 parser as P.
A00-2018 P02-1018
