The HWC metrics compare dependency and constituency trees for both reference and machine translations (Liu and Gildea, 2005).
W05-0904
ROUGE utilizes ’skip n-grams’, which allow for matches of sequences of words that are not necessarily adjacent (Lin and Och, 2004a).
C04-1072 P04-1077
In Proceedings of the 20th International Conference on Computational Linguistics (COLING 2004), August.
C04-1072 P04-1077
The well-known BLEU (Papineni et al., 2002) is based on the number of common n-grams between the translation hypothesis and human reference translations of the same sentence.
P02-1040
In addition to adapting the idea of Head Word Chains (Liu and Gildea, 2005), we also compared the input sentence’s argument structures against the treebank for certain syntactic categories.
W05-0904
BLEU is smoothed (Lin and Och, 2004b), and it considers only matching up to bigrams because this has higher correlations with human judgments than when higher-ordered n-grams are included.
C04-1072 P04-1077
METEOR uses the Porter stemmer and synonymmatching via WordNet to calculate recall and precision more accurately (Banerjee and Lavie, 2005).
W05-0909
Reference-based metrics such as BLEU (Papineni et al., 2002) have rephrased this subjective task as a somewhat more objective question: how closely does the translation resemble sentences that are known to be good translations for the same source?
P02-1040
Also relevant is previous work that applied machine learning approaches to MT evaluation, both with human references (Corston-Oliver et al., 2001; Kulesza and Shieber, 2004; Albrecht and Hwa, 2007; Liu and Gildea, 2007) and without (Gamon et al., 2005).
N07-1006 P01-1020 P07-1111 W05-0904
To compare the relative quality of different metrics, we apply bootstrapping re-sampling on the data, and then use paired t-test to determine the statistical significance of the correlation differences (Koehn, 2004).
W04-3250
