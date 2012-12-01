The features that define the constraints on the model are obtained by instantiation of feature templates as in Ratnaparkhi (1996).
W96-0213
Among recent top performing methods are Hidden Markov Models (Brants 2000), maximum entropy approaches (Ratnaparkhi 1996), and transformation-based learning (Brill 1994).
A00-1031 W96-0213
One conclusion that we can draw is that at present the additional word features used in Ratnaparkhi (1996) looking at words more than one position away from the current do not appear to be helping the overall performance of the models.
W96-0213
This presumably corresponds with Charniak's (2000: 136) observation that Section 23 of the Penn Treebank is easier than some others.
A00-2018
Model Overall Unknown Word Accuracy Accuracy Baseline, 96.72% 84.5% J Ratnaparkhi 96.63% 85.56% (1996) Table 3 Baseline model performance This table also shows the results reported in Ratnaparkhi (1996: 142)for COnvenience.
W96-0213
This may stem from the differences between the two models' feature templates, thresholds, and approximations of the expected values for the features, as discussed in the beginning of the section, or may just reflect differences in the choice of training and test sets (which are not precisely specified in Ratnaparkhi (1996)).
W96-0213
The feature templates in Ratnaparkhi (1996) that were left out were the ones that look at the previous word, the word two positions before the current, and the word two positions after the current.
W96-0213
Some are the result of inconsistency in labeling in the training data (Ratnaparkhi 1996), which usually reflects a lack of linguistic clarity or determination of the correct part of speech in context.
W96-0213
They are a subset of the features used in Ratnaparkhi (1996).
W96-0213
For a more extensive discussion of maximum entropy methods, see Berger et al.(1996) and Jelinek (1997).
J96-1002
A maximum entropy approach has been applied to partof-speech tagging before (Ratnaparkhi 1996), but the approach's ability to incorporate nonlocal and non-HMM-tagger-type evidence has not been fully explored.
W96-0213
Following Berger et al.(1996), we approximate p(h,t), the joint distribution of contexts and tags, by the product of ~(h), the empirical distribution of histories h, and the conditional distribution p(t l h): p(h,t) = ~(h).
J96-1002
Baseline Maximum Entropy Model We started with a maximum entropy based tagger that uses features very similar to the ones proposed in Ratnaparkhi (1996).
W96-0213
This stands in contrast to the (manually-built) EngCG tagger, which achieves better performance by using lexical and contextual information sources and generalizations beyond those available to such statistical taggers, as Samuelsson and Voutilainen (1997) demonstrate.
P97-1032
Ratnaparkhi (1996: 134) suggests use of an approximation summing over the training data, which does not sum over possible tags: " h E f j = 2 P( ~)p(ti l hi)f j(hi,ti) i=1 However, we believe this passage is in error: such an estimate is ineffective in the iterative scaling algorithm.
W96-0213
