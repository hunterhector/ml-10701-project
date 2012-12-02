Instead of relying on manual rules, (Xia and McCord, 2004) propose a method in learning patterns of rewriting SL sentences.
C04-1073
For example, the distancebased reordering model (Koehn et al., 2003) allows a decoder to translate in non-monotonous order, under the constraint that the distance between two phrases translated consecutively does not exceed a limit known as distortion limit.
N03-1017
The translation table is obtained as described in (Koehn et al., 2003), i.e. the alignment tool GIZA++ is run over the training data in both translation directions, and the two alignTest Setting BLEU B1 standard phrase-based SMT 29.22 B2 (B1) + clause splitting 29.13 Table 2: Experiment Baseline Test Setting BLEU BLEU 2-ary 2,3-ary 1 rule 29.77 30.31 2 ME (phrase label) 29.93 30.49 3 ME (left,right) 30.10 30.53 4 ME ((3)+head) 30.24 30.71 5 ME ((3)+phrase label) 30.12 30.30 6 ME ((4)+context) 30.24 30.76 Table 3: Tests on Various Reordering Models The 3rd column comprises the BLEU scores obtained by reordering binary nodes only, the 4th column the scores by reordering both binary and 3-ary nodes.
N03-1017
Our method is inspired by previous preprocessing approaches like (Xia and McCord, 2004), (Collins et al., 2005), and (Costa-juss`a and Fonollosa, 2006), which split translation into two stages: S → Sprime → T (1) where a sentence of the source language (SL), S, is first reordered with respect to the word order of the target language (TL), and then the reordered SL sentence Sprime is translated as a TL sentence T by monotonous translation.
C04-1073 P05-1066
As pointed out in (Al-Onaizan and Papineni, 2006), these strategies make hard decisions in reordering which cannot be undone during decoding.
P06-1067
All the feature weights (λs) were trained using our implementation of Minimum Error Rate Training (Och, 2003).
P03-1021
For the first question, we adopt a similar method as in (Fox, 2002): given an SL phrase ps = s1...si ...sn and a word alignment matrix A, we can enumerate the set of TL words {ti : tiepsilon1A(si)}, and then arrange the words in the order as they appear in the TL sentence.
W02-1039
(Xia and McCord, 2004) propose a way to learn rewriting patterns, nevertheless the units of such patterns are words and their POSs.
C04-1073
(Case-sensitive) BLEU-4 (Papineni et al., 2002) is used as the evaluation metric.
P02-1040
The Chinese side of all corpora are segmented into words by our implementation of (Gao et al., 2003).
P03-1035
The most notable ones are (Xia and McCord, 2004) and (Collins et al., 2005), both of which make use of linguistic syntax in the preprocessing stage.
C04-1073 P05-1066
Och. 2003.
P03-1021
Work There have been various attempts to syntaxbased SMT, such as (Yamada and Knight, 2001) and (Quirk et al., 2005).
P01-1067 P05-1034
(Collins et al., 2005) analyze German clause structure and propose six types 721 of rules for transforming German parse trees with respect to English word order.
P05-1066
The implementation is similar to the idea of lexical weight in (Koehn et al., 2003): all points in the alignment matrices of the entire training corpus are collected to calculate the probabilistic distribution, P(t|s), of some TL word 3Some readers may prefer the expression the subtree rooted at node N to node N.
N03-1017
Jianfeng Gao, Mu Li, and Chang-Ning Huang 2003.
P03-1035
(Collins et al., 2005) count on manual rules and it is suspicious if reordering rules for other language pairs can be easily made.
P05-1066
Fei Xia, and Michael McCord 2004.
C04-1073
A notable approach is lexicalized reordering (Koehn et al., 2005) and (Tillmann, 2004).
N04-4026
We use the Stanford parser (Klein and Manning, 2003) with its default Chinese grammar, the GIZA++ (Och and Ney, 2000) alignment package with its default settings, and the ME tool developed by (Zhang, 2004).
P00-1056 P03-1054
