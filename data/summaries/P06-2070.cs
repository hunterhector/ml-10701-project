Our method is motivated by the phrase extraction method of Bannard and Callison-Burch (2005), which computes the similarity ratio of two words by looking at their relationship with words in another language.
P05-1074
Liu and Gildea (2005) also pointed out that due to the limited references for every MT output, using the overlapping ratio of n-grams longer than 2 did not improve sentence level evaluation performance of BLEU.
W05-0904
In order to improve sentence-level evaluation performance, several metrics have been proposed, including ROUGE-W, ROUGE-S (Lin and Och, 2004) and METEOR (Banerjee and Lavie, 2005).
P04-1077 W05-0909
of BLEU, ROUGE-W and METEOR The most commonly used automatic evaluation metrics, BLEU (Papineni et al., 2002) and NIST (Doddington, 2002), are based on the assumption that The closer a machine translation is to a promt1: Life is like one nice chocolate in box ref: Life is just like a box of tasty chocolate ref: Life is just like a box of tasty chocolate mt2: Life is of one nice chocolate in box Figure 1: Alignment Example for ROUGE-W fessional human translation, the better it is (Papineni et al., 2002).
P02-1040
To estimate the significance of the correlations, bootstrap resampling (Koehn, 2004) is used to randomly select 5514 sentences with replacement out of the whole test set of 5514 sentences, and then the correlation coef cients are computed based on the selected sentence set.
W04-3250
This con rms Liu and Gildea (2005)’s nding that in sentence level evaluation, long n-grams in BLEU are not bene cial.
W05-0904
BLEU and NIST have been shown to correlate closely with human judgments in ranking MT systems with different qualities (Papineni et al., 2002; Doddington, 2002).
P02-1040
If we consider these probabilities as a vector, the similarities of two English words can be obtained by computing the dot product of their corresponding vectors.2 The formula is described below: similarity(ei, ej) = Nsummationdisplay k=1 p(ei|fk)p(ej|fk) (3) Paraphrasing methods based on monolingual parallel corpora such as (Pang et al., 2003; Barzilay and Lee, 2003) can also be used to compute the similarity ratio of two words, but they don’t have as rich training resources as the bilingual methods do.
N03-1003 N03-1024
The corpus is aligned in the word level using IBM Model4 (Brown et al., 1993).
J93-2003
