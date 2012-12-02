(2000), or to the domain-restricted Japanese dialogues of the ATR corpus (Lepage et al., 1998).32 Other relatively “easy” data sets are Portuguese (2nd highest average score but, interestingly, the third-longest parsing units), Bulgarian (3rd), German (4th) and Chinese (5th).
W98-0513
+, traces MLE [ME] d2c c2d − Table 2: Overview of parsing approaches taken by participating groups (identified by the first three letters of the first author): algorithm (Y&M: Yamada and Matsumoto (2003), ILP: Integer Linear Programming), vertical direction (irrelevant, mpf: most probable first, bottom-up-spans, bottom-up-trees), horizontal direction (irrelevant, mpf: most probable first, forward, backward), search (optimal, approximate, incremental, best-first exhaustive, deterministic), labeling (interleaved, separate and 1st step, separate and 2nd step), non-projective (ps-pr: through pseudo-projective approach), learner (ME: Maximum Entropy; learners in brackets were explored but not used in the official submission), preprocessing (projectivize, d2c: dependencies to constituents), postprocessing (deprojectivize, c2d: constituents to dependencies), learner parameter optimization per language anon-projectivity through approximate search, used for some languages b20 averaged perceptrons combined into a Bayes Point Machine cintroduced a single POS tag “aux” for all Swedish auxiliary and model verbs dby having no projectivity constraint eselective projectivity constraint for Japanese fseveral approaches to non-projectivity gusing some FEATS components to create some finer-grained POSTAG values hreattachment rules for some types of non-projectivity ihead automaton grammar jdetermined the maximally allowed distance for relations kthrough special parser actions lpseudo-projectivizing training data only mGreedy Prepend Algorithm nbut two separate learners used for unlabeled parsing versus labeling oboth foward and backward, then combined into a single tree with CLE pbut two separate SVMs used for unlabeled parsing versus labeling qforward parsing for Japanese and Turkish, backward for the rest rattaching remaining unattached tokens through exhaustive search (not for submitted runs) 156 sequence classifier can label all children of a token together (McDonald et al., 2006).
E06-1011 W06-2932
Attardi. 2006.
W06-2922
Stepwise approaches can use an explicit probability model over next steps, e.g. a generative one (Eisner, 1996; Dreyer et al., 2006), or train a machine learner to predict those.
C96-1058 W06-2929
which dependency to insert) can be based on information about, in theory all, previous steps and their results (in the context of generative probabilistic parsing, Black et al.(1993) call this the history).
P93-1005
Depending on the way the parser is trained, it might be necessary to at least projectivize the training data (Chang et al., 2006).
W06-2926
Nivre. 2005.
P05-1013
If the parse has to be projective, Eisner’s bottom-up-span algorithm (Eisner, 1996) can be used for the search.
C96-1058
Within the first approach, each dependency can be labeled independently (Corston-Oliver and Aue, 2006) or a 29Thanks to Joakim Nivre for explaining this.
W06-2928
For non-projective parses, McDonald et al.(2005b) propose using the Chu-Liu-Edmonds (CLE) algorithm (Chu and Liu, 1965; Edmonds, 1967) and McDonald and Pereira (2006) describe an approximate extension of Eisner’s algorithm.
E06-1011 H05-1066 P05-1012 W06-2932
• The pseudo-projective approach (Nivre and Nilsson, 2005): Transform non-projective training trees to projective ones but encode the information necessary to make the inverse transformation in the DEPREL, so that this inverse transformation can also be carried out on the test trees (Nivre et al., 2006).
P05-1013 W06-2933
Some relatively recent rule-based full dependency parsers are Kurohashi and Nagao (1994) for Japanese, Oflazer (1999) for Turkish, Tapanainen and J¨arvinen (1997) for English and Elworthy (2000) for English and Japanese.
A97-1011 P99-1033
Nivre and Scholz (2004) uses this term with reference to Yamada and Matsumoto (2003), whose parser has to find all children of a token before it can attach that token to its head.
C04-1010 W04-2407
Canisius et al.(2006) are six and Schiehlen and Spranger (2006) even eight ranks higher for Dutch than overall, while Riedel et al.(2006) are six ranks lower for Czech and Johansson and Nugues (2006) also six for Chinese.
W06-2924 W06-2930 W06-2934 W06-2935
Bick (2006) uses only case, mood and pronoun subclass and Attardi (2006) uses only gender, number, person and case.
W06-2922 W06-2923
In a variant of the “all pairs” approach, only those pairs of tokens are considered that are not too distant (Canisius et al., 2006).
W06-2924
Kudo and Matsumoto (2000) describe a dependency parser for Japanese and Yamada and Matsumoto (2003) an extension for English.
W00-1303
Its original PoS tag set is very coarse and the PoS and the word stem information is not very reliable.25 We therefore decided to retag the treebank automatically using the Memory-Based Tagger (MBT) (Daelemans et al., 1996) which uses a very fine-grained tag set.
W96-0102
For example, Johansson and Nugues (2006) and Yuret (2006) are seven ranks higher for Turkish than overall, while Riedel et al.(2006) are five ranks lower.
W06-2930 W06-2934 W06-2938
159 6 Results Table 5 shows the official results for submitted parser outputs.31 The two participant groups with the highest total score are McDonald et al.(2006) and Nivre et al.(2006). As both groups had much prior experience in multilingual dependency parsing (see Section 2), it is not too surprising that they both achieved good results.
E06-1011 W06-2932 W06-2933
There are also alternatives to MST which allow imposing additional constraints on the dependency structure, e.g. that at most one dependent of a token can have a certain label, such as “subject”, see Riedel et al.(2006) and Bick (2006).
W06-2923 W06-2934
Even though McDonald et al.(2006) and Nivre et al.(2006) obtained very similar overall scores, a more detailed look at their performance shows clear differences.
E06-1011 W06-2932 W06-2933
The same idea was used by Magerman (1995), who developed the first “head table” for the Penn Treebank (Marcus et al., 1994), and Collins (1996), whose constituent parser is internally based on probabilities of bilexical dependencies, i.e. dependencies between two words.
H94-1020 P95-1037 P96-1025
By contrast, Canisius et al.(2006) do not even enforce the tree constraint, i.e. they allow cycles.
W06-2924
• Allow during parsing under certain conditions, e.g. for tokens with certain properties (Riedel et al., 2006; Bick, 2006) or if no alternative projective arc has a score above the threshold 157 (Bick, 2006) or if the classifier chooses a special action (Attardi, 2006) or the parser predicts a trace (Schiehlen and Spranger, 2006).
W06-2922 W06-2923 W06-2934 W06-2935
Eisner (1996) introduced a data-driven dependency parser and compared several probability models on (English) Penn Treebank data.
C96-1058
Following Nivre and Nilsson (2005) we use the following definition: “an arc (i, j) is projective iff all nodes occurring between i and j are dominated by i (where dominates is the transitive closure of the arc rela26Many thanks to Montserrat Civit and Toni Mart´ı for allowing us to use Cast3LB for CoNLL-X and to Amit Dubey for converting the treebank.
P05-1013
• Always allow non-projective arcs, by not imposing any projectivity constraint (Shimizu, 2006; Canisius et al., 2006).
W06-2924 W06-2936
The search for the best parse can then be formalized as the search for the maximum spanning tree (MST) (McDonald et al., 2005b).
H05-1066 P05-1012
Another use of “bottom-up” is due to Eisner (1996), who introduced the notion of a “span”.
C96-1058
Collins (1997)’s parser and its reimplementation and extension by Bikel (2002) have by now been applied to a variety of languages: English (Collins, 1999), Czech (Collins et al., 1999), German (Dubey and Keller, 2003), Spanish (Cowan and Collins, 2005), French (Arun and Keller, 2005), Chinese (Bikel, 2002) and, according to Dan Bikel’s web page, Arabic.
H05-1100 P03-1013 P05-1038 P97-1003 P99-1065
Bick (2006) used the lowercased FORM if the LEMMA is not available, Corston-Oliver and Aue (2006) a prefix and Attardi (2006) a stem derived by a rule-based system for Danish, German and Swedish.
W06-2922 W06-2923 W06-2928
• Introduce through post-processing, e.g. through reattachment rules (Bick, 2006) or if the change increases overall parse tree probability (McDonald et al., 2006).
E06-1011 W06-2923 W06-2932
Nivre’s parser has been tested for Swedish (Nivre et al., 2004), English (Nivre and Scholz, 2004), Czech (Nivre and Nilsson, 2005), Bulgarian (Marinov and Nivre, 2005) and Chinese Cheng et al.(2005), while McDonald’s parser has been applied to English (McDonald et al., 2005a), Czech (McDonald et al., 2005b) and, very recently, Danish (McDonald and Pereira, 2006).
C04-1010 E06-1011 H05-1066 I05-3003 P05-1012 P05-1013 W04-2407 W06-2932
This approach is one of those described in Eisner (1996).
C96-1058
