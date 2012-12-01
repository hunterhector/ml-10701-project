A recent direction in the development of metrics for sentence-level evaluation is to apply machine learning to create an improved composite metric out of less indicative ones (Corston-Oliver et al., 2001; Kulesza and Shieber, 2004).
P01-1020
One possibility is to examine whether the automatic metric ranks the human reference translations highly with respect to machine translations (Lin and Och, 2004b; Amig´o et al., 2006).
C04-1072 P04-1077
In Proceedings of the 20th International Conference on Computational Linguistics (COLING 2004), August.
C04-1072 P04-1077
In addition to the well-known word error rate (WER), more sophisticated modifications have been proposed (Tillmann et al., 1997; Snover et al., 2006; Leusch et al., 2006).
E06-1031
Since the introduction of BLEU (Papineni et al., 2002) the basic n-gram precision idea has been augmented in a number of ways.
P02-1040
Reframing sentence-level translation evaluation as a classification task was first proposed by Corston-Oliver et al.(2001). Interestingly, instead of recasting the classification problem as a “Human Acceptability” test (distinguishing good translations outputs from bad one), they chose to develop a Human-Likeness classifier (distinguishing outputs seem human-produced from machine-produced ones) to avoid the necessity of obtaining manually labeled training examples.
P01-1020
Metrics in the Rouge family allow for skip n-grams (Lin and Och, 2004a); Kauchak and Barzilay (2006) take paraphrasing into account; metrics such as METEOR (Banerjee and Lavie, 2005) and GTM (Melamed et al., 2003) calculate both recall and precision; METEOR is also similar to SIA (Liu and Gildea, 2006) in that word class information is used.
C04-1072 N03-2021 N06-1058 P04-1077 P06-2070 W05-0909
For example, Liu and Gildea (2005) developed the Sub-Tree Metric (STM) over constituent parse trees and the Head-Word Chain Metric (HWCM) over dependency parse trees.
W05-0904
One is the concern that a system under evaluation might try to explicitly “game the metric5.” This is a concern shared by all automatic evaluation metrics, and potential problems in stand-alone metrics have been analyzed (Callison-Burch et al., 2006).
E06-1032
0 0.05 0.1 0.15 0.2 0.25 0.3 0.35 0.4 45 50 55 60 65 70 75 80 85Correlation Coefficient with Human Judgement (R) Human-Likeness Classifier Accuracy (%) Figure 1: This scatter plot compares classifiers’ accuracy with their corresponding metrics’ correlations with human assessments been previously observed by Liu and Gildea (2005).
W05-0904
BLEU is smoothed to be more appropriate for sentencelevel evaluation (Lin and Och, 2004b), and the bigram versions of BLEU and HWCM are reported because they have higher correlations than when longer n-grams are included.
C04-1072 P04-1077
To evaluate the relative reliability of different metrics, we use bootstrapping re-sampling and paired t-test to determine whether the difference between the metrics’ correlation scores has statistical significance (at 99.8% confidence level)(Koehn, 2004).
W04-3250
We want to avoid training a metric that as5Or, in a less adversarial setting, a system may be performing minimum error-rate training (Och, 2003) signs a higher than deserving score to a sentence that just happens to have many n-gram matches against the target-language reference corpus.
P03-1021
