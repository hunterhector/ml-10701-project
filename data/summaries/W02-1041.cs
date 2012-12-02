Like Huang et al.(2001), we count a proposed caller phrase as correct if and only if it matches the annotation of the evaluation data perfectly.
P01-1039
Also, for most phone numbers the labeling is uncontroversial, so we expect the corpora used by Huang et al.(2001) and ourselves to be extremely similar in terms of mark-up of phone numbers.
P01-1039
P R F HZP log-linear .89 .80 .84 Col log-linear .83 .78 .81 JA classifiers .73 .68 .71 Table 1: Performance of caller phrase extraction (manual transcriptions) While the results for the approach proposed here appear clearly worse than those reported by Huang et al.(2001), we hasten to point out that this is most likely not due to any difference in the corpora that were used.
P01-1039
P R F HZP strict .24 .16 .19 HZP containment .73 .41 .52 JA containment .74 .66 .70 Table 2: Performance of caller phrase extraction (automatic transcriptions) The difference between the approach in (Huang et al., 2001) and ours may be partly due to the performance of the ASR components: Huang et al.(2001) report a word error rate of ‘about 35%’, whereas we used a recognizer (Bacchiani, 2001) with a word error rate of only 23%.
P01-1039
We shall see that hand-crafted rules achieve very good recall, just as Huang et al.(2001) had observed, and the pruning phase successfully eliminates most undesirable candidates without affecting recall too much.
P01-1039
• The combined performance of our simple extraction grammar and the second-phase classifier exceeded the performance of all other methods, including the current state of the art (Huang et al., 2001).
P01-1039
This places less of a burden on the grammar developers than having to write an accurate set of rules like the baseline of (Huang et al., 2001).
P01-1039
Huang et al.(2001) discuss three approaches: hand-crafted rules; grammatical inference of subsequential transducers; and log-linear classifiers with bigram and trigram features used as taggers (Ratnaparkhi, 1996).
P01-1039 W96-0213
Rows HZP rules and HZP log-linear refer to the rule-based baseline and the best log-linear model of (Huang et al., 2001) and the figures are simply taken from that paper; row Col log-linear refers to the same named entity tagger we used in the previous section and is included for comparison with the HZP models; row JA digits refers to the simple baseline where we extract strings of spoken digits of plausible lengths.
P01-1039
Since a direct comparison to the log-linear named entity tagger described in (Huang et al., 2001) (we refer to this approach as HZP log-linear below) is not possible due to the use of different corpora and annotation standards, we applied a similar named entity tagger based on a log-linear model with trigram features to our data (we refer to this approach as Col log-linear as the tagger was provided by Michael Collins).
P01-1039
This is corroborated by the fact that we were able to obtain performance much closer to that of the best, finely tuned log-linear model from (Huang et al., 2001) by using a generic named entity tagger that was not adapted in any way to the particular task at hand.
P01-1039
The results are summarized in Table 5, which also repeats the best results from (Huang et al., 2001), using the same terminology as earlier: rows HZP strict and HZP containment refer to the best model from (Huang et al., 2001) – corresponding to row HZP log-linear in Table 4 – when evaluated using the strict criterion and containment, respectively; and row JA containment refers to our own best model – corresponding to row JA extract + classify in Table 4.
P01-1039
Rows HZP strict and HZP containment repeat the figures for the best model from (Huang et al., 2001) when evaluated on automatic transcriptions.
P01-1039
Restricting our attention to voicemail transcripts means that our focus and goals are similar to those of Huang et al.(2001), but the features and techniques we use are very different.
P01-1039
Generic methods like the named entity tagger used by Huang et al.(2001) may not be the best tools for particular tasks; in fact, we do not expect the bigram and trigram features used by such taggers to be sufficient for accurately extracting phone numbers.
P01-1039
While this is less of a problem when evaluating on manual transcriptions, the experience reported in (Huang et al., 2001) suggests that the relatively high error rate of speech recognizers may negatively affect performance of caller name extraction on automatically generated transcripts.
P01-1039
Table 1 summarizes precision (P), recall (R), and F-measure (F) for three approaches evaluated on manual transcriptions: row HZP loglinear repeats the results of the best model from (Huang et al., 2001); row Col log-linear contains the results we obtained using a similar named entity tagger on our own data; and row JA classifiers shows the performance of the classifier method proposed in this section.
P01-1039
