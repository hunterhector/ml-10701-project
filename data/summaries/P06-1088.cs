Our multi-tagging approach follows that of Clark and Curran (2004a) and Charniak et al.(1996): assign all categories to a word whose probabilities are within a factor, β, of the probability of the most probable category for that word: Ci = {c | P(Ci = c|S) > β P(Ci = cmax|S)} Ci is the set of categories assigned to the ith word; Ci istherandomvariablecorrespondingtothecategory of the ith word; cmax is the category with the highest probability of being the category of the ith word; andS is the sentence.
C04-1041 P04-1014
This leaves the parser the task of managing the very large parse space resulting from the high degree of lexical category ambiguity (Hockenmaier and Steedman, 2002; Hockenmaier, 2003).
P02-1043
We use the L-BFGS optimisation algorithm (Nocedal and Wright, 1999; Malouf, 2002) to perform the estimation.
W02-2018
This work can be seen as part of the larger goal of maintaining ambiguity and exploiting un703 certainty throughout language processing systems (Roth and Yih, 2004), which is important for coping with the compounding of errors that is a significant problem in language processing pipelines.
W04-2401
In fact, in Clark and Curran (2004b) we report that using automatically assigned, as opposed to gold-standard, POS tags as features results in a 2% loss in parsing accuracy.
C04-1041 P04-1014
We have shown that the resulting set has very high coverage on unseen data (Clark and Curran, 2004a).
C04-1041 P04-1014
In previous work we have shown that using automatically assigned, rather than gold standard, POS tags reduces the accuracy of our CCG parserbyalmost2%independencyF-score(Clark and Curran, 2004b).
C04-1041 P04-1014
In this paper we significantly improve our earlier approach (Clark and Curran, 2004a) by adapting the forward-backward algorithm to a Maximum Entropy tagger, which is used to calculate a probability distribution over lexical categories for each word.
C04-1041 P04-1014
The POS tagger uses the same contextual predicates as Ratnaparkhi (1996); the supertagger adds contextual predicates corresponding to POS tags and bigram combinations of POS tags (Curran and Clark, 2003).
E03-1071 W96-0213
Clark and Curran (2004a) found that performing CCG supertagging prior to parsing can significantly increase parsing efficiency with no loss in accuracy.
C04-1041 P04-1014
Clark and Curran (2004a) propose a simple method for calculating P(Ci = c|S): use the word and POS features in the local context to calculate the probability and ignore the previously assigned categories (the history).
C04-1041 P04-1014
However, one of the original motivations for supertagging was to significantly reduce the syntactic ambiguity before full parsing begins (Bangalore and Joshi, 1999).
J99-2004
One possible conclusion from the POS tagging literature is that accuracy is approaching the limit, and any remaining improvement is within the noise of the Penn Treebank training data (Ratnaparkhi, 1996; Toutanova et al., 2003).
N03-1033 W96-0213
In Clark and Curran (2004a) we described a novel approach to integrating the supertagger and parser: startwithaveryrestrictivesupertaggersetting, so that only a small number of lexical categories is assigned to each word, and only assign more categories if the parser cannot find a spanning analysis.
C04-1041 P04-1014
For example, when using the dependency-based evaluation in Clark and Curran (2004b), getting the lexical category wrong for a ditransitive verb automatically leads to three dependencies in the output being incorrect.
C04-1041 P04-1014
However, it is unclear whether multi-POS tagging will be useful in this context, since our single-tagger POS tagger is highly accurate: over 97% for WSJ text (Curran and Clark, 2003).
E03-1071
State-of-the-art part of speech (POS) tagging accuracy is now above 97% for newspaper text (Collins, 2002; Toutanova et al., 2003).
N03-1033 W02-1001
We found in Clark and Curran (2004b) that a large drop in parsing accuracy occurs if automatically assigned POS tags are used throughout the parsing process, rather than gold standard POS tags (almost 2% F-score over labelled dependencies).
C04-1041 P04-1014
The parser is described in Clark and Curran (2004b).
C04-1041 P04-1014
In 698 fact, when using a state-of-the-art single-tagger, the per-word accuracy for CCG supertagging is so low (around 92%) that wide coverage, high accuracy parsing becomes infeasible (Clark, 2002; Clark and Curran, 2004a).
C04-1041 P04-1014
