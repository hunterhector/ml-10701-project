• Metrics based on syntactic similarities such as the head-word chain metric (HWCM) (Liu and Gildea, 2005).
W05-0904
Later approaches to improve sentence-level evaluation performance can be summarized as falling into four types: • Metrics based on common loose sequences of MT outputs and references (Lin and Och, 2004; Liu and Gildea, 2006).
P04-1077 P06-2070
Therefore, if we can somehow find the alignments between the source sentence and the reference/MT output, we could be smarter in selecting the overlapping words to be counted in the 1In metrics such as METEOR, ROUGE, SIA (Liu and Gildea, 2006), the positions of words do make difference, but it has nothing to do with the word itself.
P06-2070
The 45 stochastic word mapping is trained on a FrenchEnglish parallel corpus containing 700,000 sentence pairs, and, following Liu and Gildea (2005), we only keep the top 100 most similar words for each English word.
W05-0904
• Metrics based on word alignment between MT outputs and the references (Banerjee and Lavie, 2005).
W05-0909
Such metrics do well in adequacy evaluation, but are not as good in fluency evaluation, because of their unigram basis (Liu and Gildea, 2006).
P06-2070
We could also apply the stochastic word mapping proposed in SIA (Liu and Gildea, 2006) to replace the hard word matching in Figure 1, and the corresponding metrics are denoted as pSSCN1, pSSCN2, pSSCN u, pSSCN i, with the suffixed number denoting different constraints.
P06-2070
The most commonly used metric, BLEU, correlates well over large test sets with human judgments (Papineni et al., 2002), but does not perform as well on sentence-level evaluation (Blatz et al., 2003).
P02-1040
New Features for MT Evaluation Since our source-sentence constrained n-gram precision and discriminative unigram precision are both derived from the normal n-gram precision, it is worth describing the original n-gram precision metric, BLEU (Papineni et al., 2002).
P02-1040
Lita et al.(2005) proposed a log-linear model to combine features, but they only did preliminary experiments based on 2 features.
H05-1093
This type of direct optimization is known as Minimum Error Rate Training (Och, 2003) in the MT community, and is an essential component in building the stateof-art MT systems.
P03-1021
