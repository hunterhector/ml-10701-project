Unknown words were not identified in (McClosky et al., 2006a) as a useful predictor for the benefit of self-training.
N06-1020 P06-1043
The table shows that for both seed sizes our self training protocol outperforms both the selftraining and co-training protocols of (Steedman et al, 20003a; 2003b).
E03-1008 N03-1031
Indeed, in the II scenario, (Steedman et al., 2003a; McClosky et al., 2006a; Charniak, 1997) reported no improvement of the base parser for small (500 sentences, in the first paper) and large (40K sentences, in the last two papers) seed datasets respectively.
E03-1008 N03-1031 N06-1020 P06-1043
As a result, the good results of (McClosky et al, 2006a; 2006b) with large seed sets do not immediately imply success with small seed sets.
N06-1020 P06-1043
David McClosky, Eugene Charniak, and Mark Johnson, 2006b.
N06-1020 P06-1043
622 We also identified a length effect similar to that studied by (McClosky et al., 2006a) for self-training (using a reranker and large seed, as detailed in Section 2).
N06-1020 P06-1043
3 (Steedman et al., 2003a) used the first 500 sentences of WSJ training section as seed data.
E03-1008 N03-1031
For the Brown corpus, we based our division on (Bacchiani et al., 2006; McClosky et al., 2006b).
N06-1020 P06-1043
Recently, (McClosky et al., 2006a; McClosky et al., 2006b) have successfully applied self-training to various parser adaptation scenarios using the reranking parser of (Charniak and Johnson, 2005).
N06-1020 P05-1022 P06-1043
The only previous work that adapts a parser trained on a small dataset between domains is that of (Steedman et al., 2003a), which used co-training (no self-training results were reported there or elsewhere).
E03-1008 N03-1031
This protocol and that of Steedman et al (2003a) were applied to the problem, with the same seed, self-training and test sets.
E03-1008 N03-1031
Terry Koo and Michael Collins, 2005.
H05-1064
Mark Steedman, Anoop Sarkar, Miles Osborne, Rebecca Hwa, Stephen Clark, Julia Hockenmaier, Paul Ruhlen, Steven Baker, and Jeremiah Crim, 2003a.
W03-0407
A reranking parser (see also (Koo and Collins, 2005)) is a layered model: the base layer is a generative statistical PCFG parser that creates a ranked list of k parses (say, 50), and the second layer is a reranker that reorders these parses using more detailed features.
H05-1064
self-training (ST) and co-training (CT) of (Steedman et al, 20003a; 2003b).
E03-1008 N03-1031
David McClosky, Eugene Charniak, and Mark Johnson, 2006a.
N06-1020 P06-1043
The self-training protocol of (Steedman et al., 2003a) does not actually improve over the baseline of using only the seed data.
E03-1008 N03-1031
In the II, OO, and OI scenarios, (McClosky et al, 2006a; 2006b) succeeded in improving the parser performance only when a reranker was used to reorder the 50-best list of the generative parser, with a seed size of 40K sentences.
N06-1020 P06-1043
Mark Steedman, Rebecca Hwa, Stephen Clark, Miles Osborne, Anoop Sarkar, Julia Hockenmaier, Paul Ruhlen,Steven Baker, and Jeremiah Crim, 2003b.
W03-0407
The authors test two novel methods, along with the tree entropy (TE) method of (Hwa, 2004).
J04-3001
Indeed, (Clark et al., 2003) applied selftraining to POS-tagging with poor results, and (Charniak, 1997) applied it to a generative statistical PCFG parser trained on a large seed set (40K sentences), without any gain in performance.
W03-0407
McClosky et al (2006a) use sections 2-21 of the WSJ PennTreebank as seed data and between 50K to 2,500K unlabeled NANC corpus sentences as self-training data.
N06-1020 P06-1043
617 A work closely related to ours is (Steedman et al., 2003a), which applied co-training (Blum and Mitchell, 1998) and self-training to Collins’ parsing model using a small seed dataset (500 sentences for both methods and 1,000 sentences for co-training only).
E03-1008 N03-1031
Table 2 compares our results with self-training and co-training results reported by (Steedman et al, 20003a; 2003b).
E03-1008 N03-1031
Steedman et al (2003b) and Hwa et al, (2003) also used several versions of corrected co-training which are not comparable to ours and other suggested methods because their evaluation requires different measures (e.g.
E03-1008 N03-1031
State of the art statistical parsers (Collins, 1999; Charniak, 2000; Koo and Collins, 2005; Charniak and Johnson, 2005) are trained on manually annotated treebanks that are highly expensive to create.
A00-2018 H05-1064 P05-1022
For example, the fscore of WSJ data parsed by the base PCFG parser of (Charniak and Johnson, 2005) when trained on the training sections of WSJ is between 89% to 90%, while the f-score of WSJ data parsed with the Collins’ model that we use, and a small seed, is between 40% and 80%.
P05-1022
Seed size our II our IO Steedman ST Steedman CT Steedman CT 2003a 2003b 500 sent.
E03-1008 N03-1031
Steedman et al (2003b) followed a similar co-training protocol except that the selection function (three functions were explored) considered the differences between the confidence scores of the two parsers.
E03-1008 N03-1031
Eugene Charniak and Mark Johnson, 2005.
P05-1022
Eugene Charniak, 2000.
A00-2018
Rebecca Hwa, 2004.
J04-3001
Stephen Clark, James Curran, and Miles Osborne, 2003.
W03-0407
Rebecca Hwa, Miles Osborne, Anoop Sarkar and Mark Steedman, 2003.
E03-1008 N03-1031
