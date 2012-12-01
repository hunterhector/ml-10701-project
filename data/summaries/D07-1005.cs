(2) We note that these posterior probabilities can be computed efficiently for some alignment models such as the HMM (Vogel et al., 1996; Och and Ney, 2003), Models 1 and 2 (Brown et al., 1993).
C96-2141 J03-1002 J93-2003 P03-1021
5.4 Phrase-based SMT system Our phrase-based SMT system is similar to the alignment template system described in Och and Ney (2004).
J04-4002
An alternate criterion is the Maximum A-Posteriori (MAP) framework (Ge, 2004; Matusov et al., 2004).
C04-1032
In the final six rows of Table 4, we show the performance of a consensus decoding technique that produces a single output hypothesis by combining translation hypotheses from multiple systems; this is an MBR-like candidate selection procedure based on BLEU correlation matrices and is described in Macherey and Och (2007).
D07-1105
Our human word alignments do not distinguish between Sure and Probable links (Och and Ney, 2003).
J03-1002 P03-1021
Minimum Error Rate Training (MERT) (Och, 2003) under BLEU criterion is used to estimate 20 feature function weights over the larger development set (dev1).
J03-1002 P03-1021
Given a sentence-pair (f,e), the most likely (Viterbi) word alignment is found as (Brown et al., 1993): ˆa = argmaxa P(f,a|e).
J93-2003
Alignment Framework A statistical translation model (Brown et al., 1993; Och and Ney, 2003) describes the relationship between a pair of sentences in the source and target languages (f = fJ1,e = eI1) using a translation probability P(f|e).
J03-1002 J93-2003 P03-1021
Bridge languages have been used by NLP researchers as a means to induce translation lexicons between distant languages without the need for parallel corpora (Schafer and Yarowsky, 2002; Mann and Yarowsky, 2001).
N01-1020 W02-2026
Much of the recent work in word alignment has focussed on improving the word alignment quality through better modeling (Och and Ney, 2003; Deng and Byrne, 2005; Martin et al., 2005) or alternative approaches to training (Fraser and Marcu, 2006b; Moore, 2005; Ittycheriah and Roukos, 2005).
H05-1011 H05-1012 H05-1022 J03-1002 P03-1021 P06-1097 W05-0809
Various feature functions (Och and Ney, 2004) are then computed over the entries in the phrase table.
J04-4002
This list is then rescored using Minimum Bayes-Risk (MBR) decoding (Kumar and Byrne, 2004).
N04-1022
There has been recent work by Ayan and Dorr (2006) on combining word alignments from different alignment systems; this paper describes a maximumentropyframeworkforthiscombination.
N06-1013
Onesolutionistocreate such parallel data by automatic translation and then retaining reliable translations by using confidence metrics (Ueffing and Ney, 2005).
H05-1096
5-gram word language models in English are trained on a variety of monolingual corpora (Brants et al., 2007).
D07-1090
All entries marked with an asterisk are better than the None baseline with 95% statistical significance computed using paired bootstrap resampling (Koehn, 2004).
W04-3250
Borin (2000) describes a non-statistical approach where a pivot alignment is used to combine direct translation and indirect translation via a third language.
C00-1015
Such an approach contrasts with the log-linear HMM/Model-4 combination proposed by Och and Ney (2003).
J03-1002 P03-1021
We observe that AER is loosely correlated to BLEU (ρ = 0.81) though the relation is weak, as observed earlier by Fraser and Marcu (2006a).
P06-1097
Simard (1999) describes a sentence aligner of this type that improves alignment on a trilingual parallel text.
W99-0602
Given any word alignment model, posterior probabilities can be computed as (Brown et al., 1993) P(aj = i|e,f) =summationdisplay a P(a|f,e)δ(i,aj), (1) where i ∈ {0,1,...,I}.
J93-2003
Koehn. 2004.
W04-3250
High quality word alignments can yield more accurate phrase-pairs which improve quality of a phrase-based SMT system (Och and Ney, 2003; Fraser and Marcu, 2006b).
J03-1002 P03-1021 P06-1097
Moore. 2005.
H05-1011
This provides a diverse collection of translation hypotheses for MT system combination (Bangalore et al., 2002; Sim et al., 2007; Matusov et al., 2006; Macherey and Och, 2007).
C02-1134 D07-1105 E06-1005
All entries marked with an asterisk (plus) are better than the Union (Direct) baseline with 95% statistical significance computed using paired bootstrap resampling (Koehn, 2004).
W04-3250
Translation is performed using a standard dynamicprogrammingbeam-searchdecoder (Ochand Ney, 2004).
J04-4002
