We consider such tagging performances feasible with a dictionary-based tagger, since Morgan et al.(2003) report performance of 69 0.1 0.2 0.3 0.4 0.5 0.6 0.7 0.8 0 75 150 225 300 375 450 525 F-ling tokens_checked (in thousands) Active learning ave max random 0.1 0.2 0.3 0.4 0.5 0.6 0.7 0.8 0 75 150 225 300 375 450 525 F-ling tokens_checked (in thousands) AA vs AL AA-20% AA-50% AL-ave Figure 4: Left, comparison among various active learning methods.
W03-1301
D.PierceandC.Cardie. 2001.
W01-0501
The use of the disagreement between taggers for selecting candidates for manual correction is reminiscent of corrected co-training (Pierce and Cardie, 2001).
W01-0501
Active learning, as pointed out by Baldridge & Osborne (2004), while it reduces the amount of training material needed, it selects data that might not be useful to train a different learner.
W04-3202
Dickinson and Meuers (2003) proposed methods based on n-grams occurring with different labellings in the corpus.
E03-1068
A different approach could be the use of a dictionary-based tagger, as in Morgan et al.(2003). It must be noted that the unsupervised method used to provide the initial tagging does not need to generalize to any data (a common problem for such methods), it only needs to perform well on the data used during active annotation.
W03-1301
However, some criticism of active learning has been expressed recently, concerning the reusability of the data (Baldridge and Osborne, 2004).
W04-3202
In order to perform error-detection, we chose to adapt the approach of Nakagawa and Matsumoto (2002) which resembles uncertainty based sampling for active learning.
C02-1101
One option is to use an unsupervised learning algorithm, such the one presented by Collins & Singer (1999), where a seed set of rules is used to bootstrap a rulebased named entity recognizer.
W99-0613
M.DickinsonandW.D.Meurers. 2003.
E03-1068
It has been applied to various NLP/IE tasks, including named entity recognition (Shen et al., 2004) and parse selection (Baldridge and Osborne, 2004) with rather impressive results in reducing the amount of annotated training data.
P04-1075 W04-3202
Finally, an alternative that we did not explore in this work is the Field Confidence Estimation (Culotta and McCallum, 2004), which allows the estimation of confidence over sequences of tokens, instead of singleton tokens only.
N04-4028
