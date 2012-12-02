The third baseline (Sporleder) is a reimplementation of Sporleder & Lapata’s 2006 algorithm with the following features: Word and Sentence Distances from the current sentence to the previous paragraph break; Sentence Length and Relative Position (relPos) of the sentence in a text; Quotes encodes whether this and the previous sentences contain a quotation, and whether the quotation is continued in the current sentence or not; Final Punctuation of the previous sentence; Words – the first (word1), the first two (word2), the first three and all words from the sentence; Parsed has positive value in case the sentence is parsed, negative otherwise; Number of S, VP, NP and PP nodes in the sentence; Signature is the sequence of PoS tags with and without punctuation; 269 Children of Top-Level Nodes are two features representing the sequence of syntactic labels of the children of the root of the parse tree and the children of the highest S-node; Branching Factor features express the average number of children of S, VP, NP and PP nodes in the parse; Tree Depth is the average length of the path from the root to the leaves; Per-word Entropy is a feature based on Genzel & Charniak’s (2003) observation that paragraph-initial sentences have lower entropy than non-initial ones; Sentence Probability according to a language model computed from the training data; Character-level n-gram models are built using the CMU toolkit (Clarkson & Rosenfeld, 1997).
W03-1009
The TnT tagger (Brants, 2000) and the TreeTagger (Schmid, 1997) are used for tagging and lemmatizing.
A00-1031
Marciniak, Tomacz & Michael Strube (2005).
W05-0618
Sporleder, Caroline & Mirella Lapata (2004).
W04-3210
LCseg: Apart from the overlap, a boolean feature based on LCseg (Galley et al., 2003) marked whether the tool suggests that a new topic begins with the current sentence.
P03-1071
Genzel, Dmitriy & Eugene Charniak (2003).
W03-1009
Power, Richard, Donia Scott & Nadjet BouayadAgha (2003).
J03-2003
158–166. Brants, Thorsten (2000).
A00-1031
Still, there is an important difference: While work on topic segmentation mainly depends on content words (Hearst, 1997) and relations between them which are computed using lexical chains (Galley et al., 2003), paragraph segmentation as a stylistic phenomenon may depend equally likely on function words.
J97-1003 P03-1071
136–145. Pevzner, Lev & Marti Hearst (2002).
J02-1002
Finally, the texts are parsed with the CDG dependency parser (Foth & Menzel, 2006).
W06-2305
Foth, Kilian & Wolfgang Menzel (2006).
W06-2305
In order to create the layout of the output, the document structure (Power et al., 2003) has to be regenerated.
J03-2003
The best decision would probably be to decide simultaneously on both using optimization methods (Roth & Yih, 2004; Marciniak & Strube, 2005).
W04-2401 W05-0618
The latter metric, WindowDiff (Pevzner & Hearst, 2002), is supposed to overcome the disadvantage of the F-measure which penalizes near misses as harsh as more serious mistakes.
J02-1002
Though related to the task of topic segmentation which stimulated a large number of studies (Hearst, 1997; Choi, 2000; Galley et al., 2003, inter alia), paragraph segmentation has not been thoroughly investigated so far.
A00-2004 J97-1003 P03-1071
The second baseline (Galley) hypothesizes that paragraph breaks coincide with topic boundaries and utilizes Galley et al.’s (2003) topic boundary identification tool LCseg.
P03-1071
Previous work (Sporleder & Lapata, 2004; 2006) mainly focused on superficial and easily obtainable surface features like punctuation, quotes, distance and words in the sentence.
W04-3210
Roth, Dan & Wen-tau Yih (2004).
W04-2401
The algorithm of Sporleder & Lapata (2004, 2006) uses surface, syntactic and language model features and is applied to three different languages and three domains (fiction, news, parliament).
W04-3210
