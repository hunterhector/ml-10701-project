An additional advantage of linked chain patterns is that they do not cause an unwieldy number of candidate patterns to be generated unlike some other approaches for representing extraction patterns, such as the one proposed by Sudo et al.(2003) where any subtree of the dependency tree can act as a potential pattern.
P03-1029
(Sudo et al., 2003; Bunescu and Mooney, 2005)).
H05-1091 P03-1029
Yangarber et al.(2000) chose an approach motivated by the assumption that documents containing a large number of patterns already identified as relevant to a particular IE scenario are likely to contain further relevant patterns.
C00-2136
A chain can be defined as a path between a verb node and any other node in the dependency tree passing through zero or more intermediate nodes (Sudo et al., 2001).
H01-1009
We conducted experiments which compared the proposed pattern similarity metric with the vector space approach used by Stevenson and Greenwood (2005) (see Section 2).
P05-1047
While it has been found that these approaches are capable of learning useful IE patterns from a handful of examples (Yangarber et al., 2000; Stevenson and Greenwood, 2005) they are limited by the use of basic extraction patterns: SVO tuples.
C00-2136 P05-1047
2 Semi-Supervised Learning of Extraction Patterns We begin by outlining the general process of learning extraction patterns using a semi-supervised algorithm, similar to one presented by Yangarber (2003).
P03-1044
For example, Sudo et al.(2003) used patterns consisting of a path from a verb to any of its descendents (direct or indirect) while Bunescu and Mooney (2005) suggest the shortest path between the items being related.
H05-1091 P03-1029
All experiments used the seed patterns in Table 1 which are indicative of this extraction task and have been used in previous experiments into semi-supervised IE pattern acquisition (Stevenson and Greenwood, 2005; Yangarber et al., 2000).
C00-2136 P05-1047
Several previous kernels used for relation extraction have been based on trees and include methods based on shallow parse trees (Zelenko et al., 2003), dependency trees (Culotta and Sorensen, 2004) and part of a dependency tree which represents the shortest path between the items being related (Bunescu and Mooney, 2005).
H05-1091 P04-1054
Yangarber et al.(2000) suggested a method where patterns were compared based on their distribution across documents in a corpus.
C00-2136
Similarity Measure The remainder of this Section describes a similarity function for pairs of linked chains, based on the tree kernel proposed by Culotta and Sorensen (2004).
P04-1054
This version of the algorithm acts as a baseline which represents previously reported approaches (Stevenson and Greenwood, 2005; Stevenson and Greenwood, 2006b).
P05-1047
The algorithm makes use of a similarity function based on those which have been proposed for use with non-iterative learning algorithms (Zelenko et al., 2003; Culotta and Sorensen, 2004; Bunescu and Mooney, 2005).
H05-1091 P04-1054
Stevenson and Greenwood (2005) suggested an alternative method for ranking the candidate patterns.
P05-1047
One is the use of iterative learning algorithms to infer extraction patterns from a small number of seed examples (Yangarber et al., 2000; Stevenson and Greenwood, 2005).
C00-2136 P05-1047
Finally, we demonstrated that this similarity measure outperforms a previously proposed approach which was based on cosine similarity and a vector space representation of patterns (Stevenson and Greenwood, 2005).
P05-1047
This similarity function resembles the one introduced by Culotta and Sorensen (2004) but also 2In linked chain patterns the only nodes with multiple children are the root nodes so, in all but the first application, this formula can be simplified to simc (Cn1,Cn2) = sim(c1,c2).
P04-1054
The method makes use of more complex patterns than previous approaches and determines their similarity using a measure inspired by recent work using kernel methods (Culotta and Sorensen, 2004).
P04-1054
The extraction patterns used by both Yangarber et al.(2000) and Stevenson and Greenwood (2005) were based on SVO tuples extracted from dependency trees.
C00-2136 P05-1047
Culotta and Sorensen (2004) consider whether one node is the hypernym of the other while the approach introduced here makes use of existing techniques to measure semantic similarity.
P04-1054
In particular various approaches (Zelenko et al., 2003; Culotta and Sorensen, 2004; Bunescu and Mooney, 2005) have used kernel methods to determine the sentences in a corpus which contain instances of a particular relation.
H05-1091 P04-1054
Stop if an acceptable set of patterns has been learned, otherwise goto step 4 Previous algorithms which use this approach include those described by Yangarber et al.(2000) and Stevenson and Greenwood (2005).
C00-2136 P05-1047
However, iterative learning algorithms, such as the ones used by Yangarber et al.(2000) and Stevenson and Greenwood (2005), have not made use of these more complex extraction patterns.
C00-2136 P05-1047
The similarity function introduced by Culotta and Sorensen (2004) compares subsequences of child nodes which is not required for our measure since it is concerned only with linked chain extraction patterns.
P04-1054
The majority of previous semi-supervised approaches to IE have been evaluated over preliminary tasks such as the identification of event participants (Sudo et al., 2003) or sentence filtering (Stevenson and Greenwood, 2005).
P03-1029 P05-1047
