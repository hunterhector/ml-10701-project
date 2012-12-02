This has roughly the same effect as the correction factor used in Bod (2003, 2006).
E03-1005 W06-2912
U-DOP therefore randomly samples a large subset from the total number of parse trees from the chart (see Bod 2006) and next converts the subtrees from these parse trees into a PCFG-reduction (Goodman 2003).
E03-1005 W06-2912
Moreover, Collins and Duffy (2002) show how a tree kernel can be applied to DOP1's all-subtrees representation.
P02-1034
Furthermore, we compared UML-DOP against a supervised binarized PCFG, i.e. a treebank PCFG whose simple relative frequency estimator corresponds to maximum likelihood (Chi and Geman 1998), and which we shall refer to as "ML-PCFG".
J98-2005
Previous models like Klein and Manning's (2002, 2005) CCM model limit the dependencies to "contiguous subsequences of a sentence".
P02-1017
And the hybrid approach of Klein and Manning (2004), which combines constituency and dependency models, yields 77.6% f-score.
P04-1061
The probability of a parse tree T is the sum of the 1 This subtree probability is redressed by a simple correction factor discussed in Goodman (2003: 136) and Bod (2003).
E03-1005
In order to check whether this difference is statistically significant, we additionally tested on 10 different 90/10 divisions of the WSJ40 (which were the same splits as in Bod 2006).
W06-2912
Bod (2006) reports that U-DOP not only outperforms previous unsupervised parsers but that its performance is as good as a binarized supervised parser (i.e.
W06-2912
(Interestingly, the top 10 most frequently learned constituents by UMLDOP were exactly the same as by U-DOP -see the relevant table in Bod 2006).
W06-2912
A possible drawback of U-DOP, however, is the statistical inconsistency of its estimator (Johnson 2002) which is inherited from the DOP1 model (Bod 1998).
J02-1005
As initial probabilities we use the subtrees' relative frequencies as described in section 2 (smoothed by Good-Turing -see Bod 1998), though it would also be interesting to see how the model works with other initial parameters, in particular with the usage frequencies proposed by Zuidema (2006).
W06-2905
Together with the high computational cost of reestimation we propose even more drastic pruning than we did in Bod (2006) for U-DOP.
W06-2912
Where van Zaanen (2000) achieved 39.2% unlabeled f-score on ATIS word strings, Clark (2001) reports 42.0% on the same data, and Klein and Manning (2002) obtain 51.2% f-score on ATIS part-of-speech strings using a constituent-context model called CCM.
C00-2139 P02-1017 W01-0713
3 U-DOP U-DOP extends DOP1 to unsupervised parsing (Bod 2006).
W06-2912
Bod (2003) or McClosky et al.(2006), and (2) that our treebank PCFG is binarized as in Klein and Manning (2005) to make results comparable.
E03-1005 N06-1020 W06-2912
We could also have used the more efficient k-best hypergraph parsing technique by Huang and Chiang (2005), but we have not yet incorporated this into our implementation.
W05-1506
Since the computation of the most probable parse tree is NP-complete (Sima'an 1996), U-DOP estimates the most probable tree from the 100 most probable derivations using Viterbi n-best parsing.
C96-2215
Johnson (2002: 76) argues in favor of a maximum likelihood estimator for DOP which is statistically consistent.
J02-1005
After computing the most probable parse trees, UML-DOP achieved an f-score of 82.9% which is a 20.5% error reduction compared to U-DOP's f-score of 78.5% on the same data (Bod 2006).
W06-2912
McClosky et al.2006). Thus if we modify our question as: does the exclusively supervised approach to parsing come to an end, we believe that the answer is certainly yes.
N06-1020
The currently most successful version of DOP1 uses a PCFG-reduction of the model with an n-best parsing algorithm (Bod 2003).
E03-1005
We next tested UML-DOP on two additional domains which were also used in Klein and Manning (2004) and Bod (2006): the German NEGRA10 (Skut et al.1997) and the Chinese CTB10 (Xue et al.2002) both containing 2200+ sentences ≤ 10 words after removing punctuation.
A97-1014 C02-1145 P04-1061 W06-2912
Table 1 shows the results of UML-DOP compared to U-DOP, the CCM model by Klein and Manning (2002), the DMV dependency learning model by Klein and Manning (2004) as well as their combined model DMV+CCM.
P02-1017 P04-1061
Bod (2006) shows that a further improvement on the WSJ10 can be achieved by an unsupervised generalization of the all-subtrees approach known as Data-Oriented Parsing (DOP).
W06-2912
On Penn Wall Street Journal po-s-strings ≤ 10 (WSJ10), Klein and Manning (2002) report 71.1% unlabeled f-score with CCM.
P02-1017
Although it is now known that DOP1's relative frequency estimator is statistically inconsistent (Johnson 2002), the model yields excellent empirical results and has been used in state-of-the-art systems.
J02-1005
As a consequence, parsing with ML-DOP is very costly and the model has hitherto never been tested on corpora larger than OVIS (Bonnema et al.1997). Yet, we will show that by clever pruning we can extend our experiments not only to the WSJ, but also to the German NEGRA and the Chinese CTB.
P97-1021
