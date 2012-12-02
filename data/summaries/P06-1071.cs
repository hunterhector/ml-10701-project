Because the edit region identification results on the original Switchboard are not directly comparable with the results on the newly segmented data, the state-of-art results reported by Charniak and Johnson (2001) and Johnson and Charniak (2004) are repeated on this new corpus by Kahn et al.(2005). The re-segmented UW Switchboard corpus is labeled with a simplified subset of the ToBI prosodic system (Ostendorf et al., 2001).
H05-1030 N01-1016 P04-1005 P05-1022
The first three lines show that the TAG-based approach is outperformed by the new CME baseline (line 3) using all the features in Zhang and Weng (2005).
W05-1519
Recent improvements on the original incremental feature selection (IFS) algorithm, such as Malouf (2002) and Zhou et al.(2003), greatly speed up the feature selection process.
W02-2018 W03-1020
Conditional Maximum Entropy (CME) modeling has received a great amount of attention within natural language processing community for the past decade (e.g., Berger et al., 1996; Reynar and Ratnaparkhi, 1997; Koeling, 2000; Malouf, 2002; Zhou et al., 2003; Riezler and Vasserman, 2004).
A97-1004 J96-1002 W00-0729 W02-2018 W03-1020 W04-3223
One additional note is that some features are obtained after the rough copy procedure is performed, where we used the same procedure as the one by Zhang and Weng (2005).
W05-1519
Experimental results in edit region identification demonstrate the benefits of the progressive feature selection (PFS) algorithm: the PFS algorithm maintains the same accuracy performance as previous CME feature selection algorithms (e.g., Zhou et al., 2003) when the same feature spaces are used.
W03-1020
Based on the convention from Shriberg (1994) and Charniak and Johnson (2001), a disfluent spoken utterance is divided into three parts: the reparandum, the part that is repaired; the inter561 regnum, which can be filler words or empty; and the repair/repeat, the part that replaces or repeats the reparandum.
N01-1016
Memory limitation prevents us from including all of these features in experiments using the boosting method described in Johnson and Charniak (2004) and Zhang and Weng (2005).
P04-1005 P05-1022 W05-1519
Kahn. 2005.
H05-1030
with Oracle Oracle 100 86.9 87.92 -Kahn et al.(2005) 78.2 85.0 -1.90 PFS best results 82.05 -86.41 1.51 Table 7.
H05-1030
Re-segmented Switchboard Data In order to include prosodic features and be able to compare with the state-oft-art, we use the University of Washington re-segmented Switchboard corpus, described in Kahn et al.(2005). In this corpus, the Switchboard sentences were segmented into V5-style sentence-like units (SUs) (LDC, 2004).
H05-1030
The next four lines in Table 4 show that additional combinations of the feature variables used in Zhang and Weng (2005) give an absolute improvement of more than 1%.
W05-1519
The original SGC algorithm uses a technique proposed by Darroch and Ratcliff (1972) and elaborated by Goodman (2002): when considering a feature f i, the algorithm only modifies those un-normalized conditional probabilities: ()( ) ∑ j jj yxf,exp λ for (x, y) that satisfy f i (x, y)=1, and subsequently adjusts the corresponding normalizing factors Z(x) in (3).
P02-1002
Charniak and Johnson (2001) and Kahn et al.(2005) have shown that improved edit region identification leads to better parsing accuracy – they observe a relative reduction in parsing f-score error of 14% (2% absolute) between automatic and oracle edit removal.
H05-1030 N01-1016 P05-1022
In this work, we use a total of 62 variables, which include 16 1 variables from Charniak and Johnson (2001) and Johnson and Charniak (2004), an additional 29 variables from Zhang and Weng (2005), 11 hierarchical POS tag variables, and 8 prosody variables (labels and their confidence scores).
N01-1016 P04-1005 P05-1022 W05-1519
Furthermore, the experiments in Zhou et al.(2003) show no significant advantage for looking ahead beyond the first element in the feature list.
W03-1020
Furthermore, we explore 377 combinations of these 62 variables, which include 40 combinations from Zhang and Weng (2005).
W05-1519
The features used here are grouped according to variables, which define feature sub-spaces as in Charniak and Johnson (2001) and Zhang and Weng (2005).
N01-1016 P05-1022 W05-1519
When Gaussian smoothing (Chen and Rosenfeld, 1999), labeled as +Gau, and postprocessing (Zhang and Weng, 2005), labeled as +post, are added, we observe 17.66% relative improvement (or 3.85% absolute) over the previous best f-score of 78.2 from Kahn et al.(2005). To test hypothesis 3, we are constrained to the feature spaces that both PFS and SGC algorithms can process.
H05-1030 W05-1519
This leads to a good amount of work in this area (Ratnaparkhi et al., 1994; Berger et al., 1996; Pietra et al, 1997; Zhou et al., 2003; Riezler and Vasserman, 2004) In the most basic approach, such as Ratnaparkhi et al.(1994) and Berger et al.(1996), training starts with a uniform distribution over all values of y and an empty feature set.
H94-1048 J96-1002 W03-1020 W04-3223
565 Results on test data Feature Space Codes number of features Precision Recall F-Value TAG-based result on UW-SWBD reported in Kahn et al.(2005) 78.20 CME with all the variables from Zhang and Weng (2005) 2412382 89.42 71.22 79.29 CME with all the variables from Zhang and Weng (2005) + post 2412382 87.15 73.78 79.91 +HTag +HTagComb +WTComb +RCComb 17116957 90.44 72.53 80.50 +HTag +HTagComb +WTComb +RCComb +PL 0 … PL 3 17116981 88.69 74.01 80.69 +HTag +HTagComb +WTComb +RCComb +PComb: without cut 20445375 89.43 73.78 80.86 +HTag +HTagComb +WTComb +RCComb +PComb: cut2 19294583 88.95 74.66 81.18 +HTag +HTagComb +WTComb +RCComb +PComb: cut2 +Gau 19294583 90.37 74.40 81.61 +HTag +HTagComb +WTComb +RCComb +PComb: cut2 +post 19294583 86.88 77.29 81.80 +HTag +HTagComb +WTComb +RCComb +PComb: cut2 +Gau +post 19294583 87.79 77.02 82.05 Table 4.
H05-1030 W05-1519
Comparison between PFS and SGC with all the variables from Zhang and Weng (2005).
W05-1519
Therefore, we take all the variables from Zhang and Weng (2005) as the feature space for the experiments.
W05-1519
We apply the latest version of Charniak’s parser (2005-08-16) and the same procedure as Charniak and Johnson (2001) and Kahn et al.(2005) to the output from our best edit detector in this paper.
H05-1030 N01-1016 P05-1022
When additional features and their combinations are used, the PFS gives 17.66% relative improvement over the previously reported best result in edit region identification on Switchboard corpus (Kahn et al., 2005), which leads to a 20% relative error reduction in parsing the Switchboard corpus when gold edits are used as the upper bound.
H05-1030
The idea behind the SGC algorithm (Zhou et al., 2003) is to use the gains computed in the previous step as approximate upper bounds for the subsequent steps.
W03-1020
To make it more comparable with the results in Kahn et al.(2005), we repeat the same experiment with the gold edits, using the latest parser.
H05-1030
On the original Switchboard corpus, Zhang and Weng (2005) reported nearly 20% better results using the boosting method with a much larger feature space 2 . To allow comparison with the best past results, we create a new CME baseline with the same set of features as that used in Zhang and Weng (2005).
W05-1519
Maximum Entropy Model The goal of CME is to find the most uniform conditional distribution of y given observation x, ( )xyp, subject to constraints specified by a set of features ()yxf i,, where features typically take the value of either 0 or 1 (Berger et al., 1996).
J96-1002
In following experiments, to make the results comparable, the same data subsets described in Kahn et al.(2005) are used for training, developing and testing.
H05-1030
The algorithm is implemented on top of the Selective Gain Computation (SGC) algorithm (Zhou et al., 2003), which offers fast training and high quality models.
W03-1020
Parsing F-score Methods Edit F-score Reported in Kahn et al.(2005) Latest Charniak Parser Diff.
H05-1030
Experiments on edit region identification task have shown that the increased feature space leads to 17.66% relative improvement (or 3.85% absolute) over the best result reported by Kahn et al.(2005), and 10.65% relative improvement (or 2.14% absolute) over the new baseline SGC algorithm with all the variables from Zhang and Weng (2005).
H05-1030 W05-1519
The best result on the UW Switchboard for edit region identification uses a TAG-based approach (Kahn et al., 2005).
H05-1030
For a fair comparison with the work by Kahn et al.(2005), word fragment information is retained.
H05-1030
A feature can also be about a particular syntactic subtree, or a dependency relation (e.g., Charniak and Johnson, 2005).
P05-1022
Experiments in Zhou et al.(2003) also confirm the prediction that the gains become smaller when more and more features are added to the model, and the gains do not get unexpectively bigger or smaller as the model grows.
W03-1020
