Hence Bangalore and Joshi (1999), in the context of LTAG parsing, refer to supertagging as almost parsing.
J99-2004
We intend to explore other methods for pruning the space and agenda-based parsing, in particular A* parsing (Klein and Manning, 2003), which will allow only the most probablepartsofthecharttobebuilt,improvingefficiency while still ensuring the optimal derivation is found.
N03-1016
CCG supertagging can be performed accurately and efficiently by a Maximum Entropy tagger (Clark and Curran, 2004a).
C04-1041 P04-1014
The tagger is very similar to the Maximum Entropy POS tagger described in Curran and Clark (2003).
E03-1071
The supertagger uses a log-linear model to define a distribution over the lexical category set for each word and the previous two categories (Ratnaparkhi, 1996) and the forward backward algorithm efficiently sums over all histories to give a distribution for each word.
W96-0213
It is used in many parsers to reduce the search space, for example Collins (2003).
J03-4003
Curran School of Information Technologies University of Sydney NSW 2006, Australia {bojan,james}@it.usyd.edu.au Stephen Clark Computing Laboratory Oxford University Wolfson Building, Parks Road Oxford, OX1 3QD, UK stephen.clark@comlab.ox.ac.uk Abstract The C&C CCG parser is a highly efficient linguistically motivated parser.
P06-1088
The key to efficient CCG parsing is a finite-state supertagger which performs much of the parsing work (Bangalore and Joshi, 1999).
J99-2004
A recent theme in parsing research has been the application of statistical methods to linguistically motivated grammars, for example LFG (Kaplan et al., 2004; Cahill et al., 2004), HPSG (Toutanova et al., 2002; Malouf and van Noord, 2004), TAG (Sarkar and Joshi, 2003) and CCG (Hockenmaier andSteedman,2002; ClarkandCurran,2004b).
C04-1041 N04-1013 P04-1014 P04-1041
Clark and Curran (2004a) presents a novel method of integrating the supertagger and parser: initially only a small number of categories, on average, is assigned to each word, and the parser attempts to find a spanning analysis using the CKY chart-parsing algorithm.
C04-1041 P04-1014
CCG Parser Clark and Curran (2004b) describes the CCG parser.
C04-1041 P04-1014
The disadvantage of such parsers is that they are typically not very efficient, parsing a few sentences per second on commodity hardware (Kaplan et al., 2004).
N04-1013
The C&C CCG parser (Clark and Curran, 2004b) is an order of magnitude faster, but is still limited to around 25 sentences per second.
C04-1041 P04-1014
