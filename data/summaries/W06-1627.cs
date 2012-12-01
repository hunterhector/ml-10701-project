4 A* Decoding The of ITG decoding algorithm of Wu (1996) can be viewed as a variant of the Viterbi parsing algorithm for alignment selection.
P96-1021
Some estimate of this outside probability is a common element of modern statistical (monolingual) parsers (Charniak et al., 1998; Collins, 1999), and recent work has developed heuristics that are admissible for A* search, guaranteeing that the optimal parse will be found (Klein and Manning, 2003).
N03-1016 W98-1115
ITG imposes constraints on which alignments are possible, and these constraints have been shown to be a good match for real bitext data (Zens and Ney, 2003).
P03-1019
While polynomial-time algorithms are a major improvement over the NPcomplete problems posed by the alignment models of Brown et al.(1993), the degree of these polynomials is high, making both alignment and decoding infeasible for realistic sentences without very signi cant pruning.
J93-2003
For bilexical parsing, Eisner and Satta (1999) pointed out we can reduce the complexity of parsing from O(n5) to O(n4) by combining the non-head constituents with the bilexical rules rst, and then combining the resultant hook constituents with the head constituents.
P99-1059
In this paper, we explore use of the hook trick (Eisner and Satta, 1999; Huang et al., 2005) to reduce the asymptotic complexity of decoding, and the use of heuristics to guide the search.
P99-1059 W05-1507
The Inversion Transduction Grammar (ITG) of Wu (1997) is a syntactically motivated algorithm for producing word-level alignments of pairs of translationally equivalent sentences in two languages.
J97-3002
Alignment, whether for training a translation model using EM or for nding the Viterbi alignment of test data, is O(n6) (Wu, 1997), while translation (decoding) is O(n7) using a bigram language model, and O(n11) with trigrams.
J97-3002
We describe the bigram-integrated decoding case here, and refer to Huang et al.(2005) for more detailed discussion.
W05-1507
These measures have been used to guide search in wordor phrase-based MT systems (Wang and Waibel, 1997; Och et al., 2001), but in such models optimal search is generally not practical even with good heuristics.
P97-1047 W01-1408
nature of the cells, we can compute values for the inside and outside components of each cell using dynamic programming in O(n4) time (Zhang and Gildea, 2005).
P05-1059
