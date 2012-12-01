The error corrector is a rule-based transformer 60 Lee, Cha, and Lee Syllable-Pattern-Based Unknown-Morpheme Estimation (Brill 1995), and it corrects mistagged morphemes by consulting lexical patterns and necessary contextual information.
J95-4004
The guessing rules are usually handcrafted using knowledge of morphology but sometimes are acquired automatically using lexicons and corpora (Brill 1995; Mikheev 1996; Oflazer and T ¨ur 1996).
J95-4004 P96-1043 W96-0207
Also, they usually perform no better than their statistical counterparts (Brill 1995).
J95-4004
The lexical probability Pr(t i jm i ) Pr(t i ) for unknown morphemes can be estimated using the frequency of syllable trigram products according to the formula in (11)–(13) (Nagata 1994), m = e 1 e 2 :::e n (11) Pr(tjm) Pr(t) Pr t (e 1 j#, #)Pr t (e 2 j#, e 1 ) n Y i=3 Pr t (e i je i−2, e i−1 ) 62 Lee, Cha, and Lee Syllable-Pattern-Based Unknown-Morpheme Estimation Pr(# je n−1, e n ) (12) Pr t (e i je i−2, e i−1 ) f t (e i je i−2, e i−1 ) + f t (e i je i−1 ) + f t (e i ) (13) where m is a morpheme, e is a syllable, t is a POS tag, “#” is a morpheme boundary symbol, and f t (e i je i−2, e i−1 ) is a frequency datum for tag t with co-occurrence syllables e i−2, e i−1, and e i . Trigram probabilities are smoothed by Equation (13) to cope with the data sparseness problem.
C94-1032
(1)) Eojeol 86.80 90.48 89.40 89.62 91.73 92.48 Morpheme 91.32 94.93 94.40 94.48 95.77 96.12 possible for training gives much better performance than unsupervised training using the Baum-Welch reestimation algorithm (Merialdo 1994).
J94-2001
Most of them employ the analysis of trailing characters and other features such as capitalization and hyphenation (Kupiec 1992; Weischedel et al.1993). Some of them use more morphologically oriented word features such as suffixes, prefixes, and character lengths (Brill 1995; Voutilainen 1995).
E95-1022 J93-2006 J95-4004
Instead, we adopted Brill’s approach (Brill 1995) whereby the error correction rules are learned automatically from a small amount of tagged corpus.
J95-4004
Our statistical tagging model is modified from the standard bigrams (Cutting et al.1992) using Viterbi search plus onthe-fly extra computing of lexical probabilities for unknown morphemes.
A92-1018
POS disambiguation has usually been performed by statistical approaches, mainly using the hidden Markov model (HMM) in English research communities (Cutting et al.1992; Kupiec 1992; Weischedel et al.1993). These approaches are also dominant for Korean, with slight improvements to accommodate the agglutinative nature of Korean.
A92-1018 J93-2006
This is the reason why we try to avoid conventional guessing rules using word morphology features such as those proposed in Mikheev (1996) and Oflazer and T ¨ur (1996).
P96-1043 W96-0207
Recently, rule-based approaches, which learn symbolic tagging rules automatically from a corpus, have been reconsidered, to overcome the limitations of statistical approaches (Brill 1995).
J95-4004
Similar hybrid methods have been tried for English, but they integrate HMM tagging and rule-based tagging at the same level (Tapanainen and Voutilainen 1994).
A94-1008
Some systems even perform POS tagging as part of a syntactic analysis process (Voutilainen 1995).
E95-1022
