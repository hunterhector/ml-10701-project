The bottom panel of table 1 lists the results for the two lexicalized models (SSN-Freq a1 200 and SSN-Freq a1 20) and five recent statistical parsers (Ratnaparkhi, 1999; Collins, 1999; Charniak, 2000; Collins, 2000; Bod, 2001).
A00-2018 P01-1010
Ratnaparkhi (1999) defines a very general set of features for the histories of a shift-reduce parsing model, but the results are not as good as models which use a more linguistically informed set of features for a top-down parsing model (Collins, 1999; Charniak, 2000).
A00-2018
Many statistical parsers (Ratnaparkhi, 1999; Collins, 1999; Charniak, 2000) are based on a history-based model of parser actions.
A00-2018
For right-branching structures, the left-corner ancestor is the parent, conditioning on which has been found to be beneficial (Johnson, 1998), as has conditioning on the left-corner child (Roark and Johnson, 1999).
J98-4004 P99-1054
Collins and Duffy (2002) define a kernel over parse trees and apply it to re-ranking the output of a parser, but the resulting feature space is restricted by the need to compute the kernel efficiently, and the results are not as good as Collins’ previous work on re-ranking using a finite set of features (Collins, 2000).
P02-1034
The standard way to handle this problem is to hand-craft a finite set of features which provides a sufficient summary of the history (Ratnaparkhi, 1999; Collins, 1999; Charniak, 2000).
A00-2018
Previous approaches have used a hand-crafted finite set of features to represent the parse history (Ratnaparkhi, 1999; Collins, 1999; Charniak, 2000).
A00-2018
Experimental Results We used the Penn Treebank (Marcus et al., 1993) to perform empirical experiments on this parsing model.
J93-2004
We then tested the best models for each vocabulary size on the testing set.4 Standard measures of performance are shown in table 1.5 3We used a publicly available tagger (Ratnaparkhi, 1996) to provide the tags used in these experiments, rather than the handcorrected tags which come with the corpus.
W96-0213
Work Most previous work on statistical parsing has used a history-based probability model with a hand-crafted set of features to represent the derivation history (Ratnaparkhi, 1999; Collins, 1999; Charniak, 2000).
A00-2018
The concept of lexical head is central to theories of syntax, and has often been used in designing hand-crafted history features (Collins, 1999; Charniak, 2000).
A00-2018
