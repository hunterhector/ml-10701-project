We also want to bootstrap on different word aligners; in particular, one possibility is to use the flexible HMM word-to-phrase model of Deng and Byrne (2005) in place of IBM model 4.
H05-1022
They can be seen as extensions of the simpler IBM models 1 and 2 (Brown et al., 1993).
J93-2003
(Wu, 1997)).
J97-3002
The 307 relationship between word alignments and their impact on MT is also investigated in (Ayan and Dorr, 2006; Lopez and Resnik, 2006; Fraser and Marcu, 2006).
P06-1002
The log-linear model is also based on standard features: conditional probabilities and lexical smoothing of phrases in both directions, and phrase penalty (Zens and Ney, 2004).
N04-1033
Similarly, Deng and Byrne (2005) propose an HMM framework capable of dealing with 1-to-n alignment, which is an extension of the original model of (Vogel et al., 1996).
C96-2141 H05-1022
Most current statistical models (Brown et al., 1993; Vogel et al., 1996; Deng and Byrne, 2005) treat the aligned sentences in the corpus as sequences of tokens that are meant to be words; the goal of the alignment process is to find links between source and target words.
C96-2141 H05-1022 J93-2003
In this case, our approach would be similar to the approach of (Xu et al., 2004), except for the estimation of candidates.
W04-1118
We use a bootstrap approach in which we first extract 1-to-n word alignments using an existing word aligner, and then estimate the confidence of those alignments to decide whether or not the n words have to be grouped; if so, this group is conwould thus be completely driven by the bilingual alignment process (see also (Wu, 1997; Tiedemann, 2003) for related considerations).
E03-1026 J97-3002
To quickly (and approximately) evaluate this phenomenon, we trained the statistical IBM wordalignment model 4 (Brown et al., 1993),1 using the GIZA++ software (Och and Ney, 2003) for the following language pairs: Chinese–English, Italian– English, and Dutch–English, using the IWSLT-2006 corpus (Takezawa et al., 2002; Paul, 2006) for the first two language pairs, and the Europarl corpus (Koehn, 2005) for the last one.
J03-1002 J93-2003 P03-1021
The quality of the translation output is evaluated using BLEU (Papineni et al., 2002).
P02-1040
We use a standard log-linear phrase-based statistical machine translation system as a baseline: GIZA++ implementation of IBM word alignment model 4 (Brown et al., 1993; Och and Ney, 2003),8 the refinement and phrase-extraction heuristics described in (Koehn et al., 2003), minimum-error-rate training 7More specifically, we choose the first English reference from the 7 references and the Chinese sentence to construct new sentence pairs.
J03-1002 J93-2003 N03-1017 P03-1021
Sentences 200 (7 refs.) Running words 1,864 14,437 Vocabulary size 569 1,081 Table 2: Chinese–English corpus statistics (Och, 2003) using Phramer (Olteanu et al., 2006), a 3-gram language model with Kneser-Ney smoothing trained with SRILM (Stolcke, 2002) on the English side of the training data and Pharaoh (Koehn, 2004) with default settings to decode.
J03-1002 P03-1021 W06-3121
Second, an increase in AER does not necessarily imply an improvement in translation quality (Liang et al., 2006) and vice-versa (Vilar et al., 2006).
N06-1014
4Interestingly, this is actually even the case for approaches that directly model alignments between phrases (Marcu and Wong, 2002; Birch et al., 2006).
W02-1018 W06-3123
有: there is 想要: want to 不必: need not 前面: in front of 一: as soon as 看: look at Figure 2: Examples of entries from the manually developed dictionary 4 Experimental Setting 4.1 Evaluation The intrinsic quality of word alignment can be assessed using the Alignment Error Rate (AER) metric (Och and Ney, 2003), that compares a system’s alignment output to a set of gold-standard alignment.
J03-1002 P03-1021
This very simple measure is frequently used in associative approaches (Melamed, 1997; Tiedemann, 2003).
E03-1026 W97-0311
We evaluate the reliability of these candidates, using simple metrics based on co-occurence frequencies, similar to those used in associative approaches to word alignment (Kitamura and Matsumoto, 1996; Melamed, 2000; Tiedemann, 2003).
E03-1026 J00-2004 W96-0107
Note that the need to consider segmentation and alignment at the same time is also mentioned in (Tiedemann, 2003), and related issues are reported in (Wu, 1997).
E03-1026 J97-3002
In other words, AC(aj) measures how often the 5Consequently, if we compare our approach to the problem of collocation identification, we may say that we are more interested in precision than recall (Smadja et al., 1996).
J96-1001
