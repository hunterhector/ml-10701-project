Of course, it is well-known that a supervised parser’s f-score decreases if it is transferred to another domain: for example, the (non-binarized) WSJ-trained DOP model in Bod (2003) decreases from around 91% to 85.5% fscore if tested on the Brown corpus.
E03-1005
While a similar result was obtained in Bod (2006), the absolute difference between unsupervised parsing and the treebank grammar was extremely small in Bod (2006): 1.8%, while the difference in table 5 is 7.2%, corresponding to 19.7% error reduction.
P06-1109
Bod (2006) reports 82.9% unlabeled f-score on the same WSJ10 as used by Klein and Manning (2002, 2004).
P02-1017 P04-1061 P06-1109
We have incorporated the technique by Huang and Chiang (2005) into our implementation which allows for efficient Viterbi n-best parsing.
P05-1033 W05-1506
Moreover, as in Bod (1998, 2000), we use an extension of Good-Turing to smooth the subtrees and to deal with ‘unknown’ subtrees.
C00-1011
We used the technique in Bod (1998, 2000) to include ‘unknown’ subtrees.
C00-1011
We used the same evaluation metrics for unlabeled precision (UP) and unlabeled recall (UR) as in Klein and Manning (2002, 2004).
P02-1017 P04-1061
Where van Zaanen (2000) and Clark (2001) induced unlabeled phrase structure for small domains like the ATIS, obtaining around 40% unlabeled f-score, Klein and Manning (2002) report 71.1% f-score on Penn WSJ part-of-speech strings ≤ 10 words (WSJ10) using a constituentcontext model called CCM.
C00-2139 P02-1017 W01-0713
It was next p-o-s tagged with the the TnT tagger (Brants 2000) which was trained on the Penn Treebank such that the same tag set was used.
A00-1031
Table 1 shows the f-scores for U-DOP* and UML-DOP against the f-scores for U-DOP reported in Bod (2006), the CCM model in Klein and Manning (2002), the DMV dependency model in Klein and Manning (2004) and their combined model DMV+CCM.
P02-1017 P04-1061 P06-1109
All trees in the test set were binarized beforehand, in the same way as in Bod (2006).
P06-1109
Moreover, DOP*’s estimation procedure is very efficient, while the EM training procedure for UML-DOP 401 proposed in Bod (2006) is particularly time consuming and can only operate by randomly sampling trees.
P06-1109
In Bod (2007), we compared U-DOP* and DOP* in a syntax-based MT system known as Data-Oriented Translation or DOT (Poutsma 2000; Groves et al.2004). The DOT model starts with a bilingual treebank where each tree pair constitutes an example translation and where translationally equivalent constituents are linked.
C00-2092 C04-1154
Bod (2006) reports that an unbinarized treebank grammar achieves an average 72.3% f-score on WSJ sentences ≤ 40 words, while the binarized version achieves only 64.6% f-score.
P06-1109
Chiang 2005.
P05-1033
While efficient algorithms have been developed for this DOP model by converting it into a PCFG reduction (Goodman 2003), DOP’s estimator was shown to be inconsistent by Johnson (2002).
J02-1005
While Klein and Manning’s approach may be described as an “all-substrings” approach to unsupervised parsing, an even richer model consists of an “all-subtrees” approach to unsupervised parsing, called U-DOP (Bod 2006).
P06-1109
The NANC corpus contains approximately 2 million WSJ sentences that do not overlap with Penn’s WSJ and has been previously used by McClosky et al.(2006) in improving a supervised parser by selftraining.
N06-1020
While we do not achieve as high an f-score as the UML-DOP model in Bod (2006), we will show that U-DOP* can operate without subtree sampling, and that the model can be trained on corpora that are two orders of magnitude larger than in Bod (2006).
P06-1109
This is a huge reduction compared to Bod (2006) where 402 the number of subtrees of all trees increases with the Catalan number, and only ad hoc sampling could make the method work.
P06-1109
While UDOP* is punished for this ‘incorrect’ prediction if evaluated on the Penn Treebank, it may be rewarded for this prediction if evaluated in the context of machine translation using the Bleu score (Papineni et al.2002). Thus similar to Chiang (2005), U-DOP can discover non-syntactic phrases, or simply “phrases”, which are typically neglected by linguistically syntax-based MT systems.
P05-1033
on hand-annotated corpora To evaluate U-DOP* against UML-DOP and other unsupervised parsing models, we started out with three corpora that are also used in Klein and Manning (2002, 2004) and Bod (2006): Penn’s WSJ10 which contains 7422 sentences ≤ 10 words after removing empty elements and punctuation, the German NEGRA10 corpus and the Chinese Treebank CTB10 both containing 2200+ sentences ≤ 10 words after removing punctuation.
P02-1017 P04-1061 P06-1109
While most parsing methods are currently supervised or semi-supervised (McClosky et al.2006; Henderson 2004; Steedman et al.2003), they depend on hand-annotated data which are difficult to come by and which exist only for a few languages.
E03-1008 N06-1020 P04-1013
But equally important is the fact that this new DOP* model does not suffer from a decrease in parse accuracy if larger subtrees are included, whereas the original DOP model needs to be redressed by a correction factor to maintain this property (Bod 2003).
E03-1005
This assumption is in consonance with the principle of simplicity, but there are also empirical reasons for the shortest derivation assumption: in Bod (2003) and Hearne and Way (2006), it is shown that DOP models that select the preferred parse of a test sentence using the shortest derivation criterion perform very well.
E03-1005 P06-1109
We will use the same allsubtrees methodology as in Bod (2006), but now by applying the efficient and consistent DOP*based estimator.
P06-1109
The equal weights follow from the fact that the shortest derivation is equivalent to the most probable derivation if all subtrees are assigned equal probability (see Bod 2000; Goodman 2003).
C00-1011 E03-1005
Note that the direct conversion of parse forests into a PCFG reduction also allows us to efficiently implement the maximum likelihood extension of U-DOP known as UML-DOP (Bod 2006).
P06-1109
Klein and Manning (2004) further show that a hybrid approach which combines constituency and dependency models, yields 77.6% f-score on WSJ10.
P04-1061
