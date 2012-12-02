*He handed in it) (Huddleston and Pullum, 2002; Villavicencio, 2003).
W03-1808
Data Freq P R F RASP f≥1 .959 .955 .957 B f≥1 1.0 .819 .901 f≥5 1.0 .919 .957 BA f≥1 f≥1 1.0 .959 .979 f≥5 f≥5 1.0 .962 .980 BC f≥1 f≥1 .809 .845 .827 f≥5 f≥1 .836 .922 .877 BAC f≥1 f≥1 f≥1 .962 .962 .962 f≥5 f≥5 f≥1 .964 .983 .974 Table 5: Results for VPC identification only (P = precision, R = recall, F = F-score) Data Freq Type P R F RASP f≥1 P+V .933 – – BC f≥1 f≥1 P+V .8068 .8033 .8051 f≥5 f≥1 P+V .8653 .8529 .8591 BAC f≥1 f≥1 P+V .8660 .8660 .8660 f≥5 f≥1 P+V .9272 .8836 .9054 Table 6: Results for VPC (=V) and verb-PP (=P) identification (P = precision, R = recall, F = Fscore) Also, we ignore the ambiguity between particles and adverbs, which is the principal reason for our evaluation being much higher than that reported by McCarthy et al.(2003). In Table 5, the precision (P) and recall (R) for VPCs are computed as follows: P = Data Correctly Tagged as VPCsData Retrieved as VPCs R = Data Correctly Tagged as VPCsAll VPCs in Data Set The performance of RASP in Table 6 shows how well it distinguishes between VPCs and verbPPs for ambiguous verb–preposition combinations.
W03-1810
In order to get a clearer sense of the impact of selectional preferences on the results, we investigated the relative performance over VPCs of varying semantic compositionality, based on 117 VPCs (f≥1 ) attested in the data set of McCarthy et al.(2003). According to our hypothesis from above, we would expect VPCs with low compositionality to have markedly different selectional preferences to the corresponding simplex verb, and VPCs with high compositionality to have similar selectional preferences to the simplex verb.
W03-1810
Li et al.(2003) identify English VPCs (or “phrasal verbs” in their parlance) using handcoded regular expressions.
P03-1065
McCarthy et al.(2003) evaluate the precision of RASP at identifying VPCs to be 87.6% and the recall to be 49.4%.
W03-1810
Collection We evaluated out method by running RASP over Brown Corpus and Wall Street Journal, as contained in the Penn Treebank (Marcus et al., 1993).
J93-2004
In particular, other than the reported results of McCarthy et al.(2003) targeting VPCs vs.
W03-1810
We achieved a slightly better result than the 95.8%-97.5% performance reported by Li et al.(2003). However, considering that Li et al.(2003) need considerable time and human labour to generate hand-coded rules, our method has advantages in terms of both raw performance and labour efficiency.
P03-1065
McCarthy et al.(2003) provides compositionality judgements from three human judges, which we take the average of and bin into 11 categories (with 0 = non-compositional and 10 = fully compositional).
W03-1810
Baldwin and Villavicencio (2002) extract a simple list of VPCs from corpus data, while Baldwin (2005) extracts VPCs with valence information under the umbrella of deep lexical acquisition.1 The method of Baldwin (2005) is aimed at VPC extraction and takes into account only the syntactic features of verbs.
W02-2001
McCarthy et al.(2004) found that 54% of word tokens are used with their first (or default) sense.
P04-1036
MWE research has focussed largely on their implications in language understanding, fluency and robustness (Pearce, 2001; Sag et al., 2002; Copestake and Lascarides, 1997; Bannard et al., 2003; McCarthy et al., 2003; Widdows and Dorow, 2005).
P97-1018 W03-1809 W03-1810 W05-1006
Bannard et al.(2003) and McCarthy et al.(2003) investigate methods for estimating the compositionality of VPCs based largely on distributional similarity of the head verb and VPC.
W03-1809 W03-1810
According to Baldwin et al.(2003), divergences in VPC and head verb semantics are often reflected in differing selectional preferences, as manifested in patterns of noun co-occurrence.
W03-1812
