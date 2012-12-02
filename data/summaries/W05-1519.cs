Early work in this field is primarily based on small and proprietary corpora, which makes the comparison of the proposed methods difficult [Young and Matessa 1991, Bear et al.1992, Heeman & Allen 1994].
P92-1008 P94-1041
These results are comparable with the results from [Charniak & Johnson 2001], i.e., 95.2%, 67.8%, and 79.2% for precision, recall, and f-score, correspondingly.
N01-1016
Compared with the reported best result, the same approach produced a 20.44% of relative error reduction on F-scores when punctuation is ignored in training and testing data [Johnson and Charniak 2004].
P04-1005
Because of the availability of the Switchboard corpus [Godfrey et al.1992] and other conversational telephone speech (CTS) corpora, there has been an increasing interest in improving the performance of identifying the edited regions for parsing disfluent sentences [Charniak and Johnson 2001, Johnson and Charniak 2004, Ostendorf et al.2004, Liu et al.2005]. In this paper we describe our effort towards the task of edited region identification with the intention of parsing disfluent sentences in the Switchboard corpus.
N01-1016 P04-1005
We observed a 43.98% relative error reduction on F-scores for the baseline with punctuation in both training and testing [Charniak and Johnson 2001].
N01-1016
These steps result in a significant improvement in F-score over the earlier best result reported in [Charniak and Johnson 2001], where punctuation is included in both the training and testing data of the Switchboard corpus, and a significant error reduction in F-score over the latest best result [Johnson and Charniak 2004], where punctuation is ignored in both the training and testing data of the Switchboard corpus.
N01-1016 P04-1005
Rough Copy We relax the definition for rough copy, because more than 94% of all edits have both reparandum and repair, while the rough copy defined in [Charniak and Johnson 2001] only covers 77.66% of such instances.
N01-1016
In the rest of the section, we first briefly introduce the boosting algorithm, then describe the method used in [Charniak and Johnson 2001], and finally we contrast our improvements with the baseline system.
N01-1016
Space Selection for Boosting We take as our baseline system the work by [Charniak and Johnson 2001].
N01-1016
[Engel et al.2002] also showed detailed distributions of the interregnum, including interjections and parentheticals.
W02-1007
Method codes Method description CJ’01 Charniak and Johnson 2001 JC’04 p Johnson and Charniak 2004, parser results R CJ’01 Duplicated results for Charniak and Johnson 2001 +d Distance + window sizes +d+h Distance + window sizes + POS hierarchy in rough copy +d+rh Distance + window sizes + relaxed POS hierarchy in rough copy +d+rw Distance + window sizes + relaxed word in rough copy +d+rw+rh Distance + window sizes + relaxed word and POS hierarchy in rough copy +d+rw+rt+wt Distance + window sizes + word & tag pairs + relaxed word and POS in rough copy +d+rw+rh+wt Distance + window sizes + word & tag pairs + relaxed word and POS hierarchy in rough copy +d+rw+rh+wt+ps Distance + window sizes + word & tag pairs + relaxed word and POS hierarchy in rough copy + pattern substitution Table 3.
N01-1016 P04-1005
We re-implement the boosting algorithm reported by [Charniak and Johnson 2001] as our baseline system in order to clearly identify contributing 1 “as to” is the edited region.
N01-1016
A clear benefit of having accurate edited regions for parsing has been demonstrated by a concurrent effort on parsing conversational speech [Kahn et al 2005].
H05-1030
[Kahn et al.2005] also showed that prosody information could help parse disfluent sentences.
H05-1030
3.2 Charniak-Johnson approach In [Charniak and Johnson 2001], identifying edited regions is considered as a classification problem, where each word is classified either as edited or normal.
N01-1016
We used the exactly same training and testing data from the Switchboard corpus as in [Charniak and Johnson 2001].
N01-1016
Since the original code from [Charniak and Johnson 2001] is not available, we conducted our first experiment to replicate the result of their baseline system described in section 3.
N01-1016
Kahn, Jeremy G., Matthew Lease, Eugene Charniak, Mark Johnson and Mari Ostendorf 2005.
H05-1030
When compared with the latest results from [Johnson and Charniak 2004], where no punctuations are used for either training or testing data, we also observe the same trend of the improved results.
P04-1005
These steps result in an improvement of 43.98% percent relative error reduction in F-score over an earlier best result in edited detection when punctuation is included in both training and testing data [Charniak and Johnson 2001], and 20.44% percent relative error reduction in F-score over the latest best result where punctuation is excluded from the training and testing data [Johnson and Charniak 2004].
N01-1016 P04-1005
We include the distributions with punctuation is to match with the baseline system reported in [Charniak and Johnson 2001], where punctuation is included to identify the edited regions.
N01-1016
Descriptions of the 18 conditioning variables from [Charniak and Johnson 2001] 182 rough copy if their corresponding major categories match.
N01-1016
