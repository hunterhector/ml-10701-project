Weischedel et al.(1993) report a 96.7% accuracy with 1,000,000 words of training corpus.
J93-2006
The performance of P 0.99 0.98 0.97 0.96 0.95 0.94 0.93 0.92 0.91 Recall Test Set Precision Ambiguity 97.94 96.70 1.012 98.27 95.29 1.031 98.48 93.63 1.052 98.65 91.63 1.076 98.78 90.21 1.095 98.98 88.92 1.113 99.03 88.05 1.124 99.10 87.19 1.136 99.13 86.68 1.143 Table 2: Recall and precision results on a WSJ test set with some tokens left ambiguous our system with Brown corpus is very close to that of Brill's transformation-based tagger, which can reach 97.2% accuracy with closed vocabulary assumption and 96.5% accuracy with open vocabulary assumption with no ambiguity (Brill, 1995).
J95-4004
In such a case, instead of accuracy, one needs to use ambiguity, recall, and precision (Voutilainen, 1995a).
E95-1022
These compare quite favorably with the k-best results of Brill(1995), but reduction in tagging speed is quite noticeable, especially for lower p's.
J95-4004
Tagging systems have used either a statistical approach where a large corpora is employed to train a probabilistic model which then is used to tag unseen text, (e.g., Church (1988), Cutting et al.(1992), DeRose (1988)), or a constraint-based approach which employs a large number of hand-crafted linguistic constraints that are used to eliminate impossible sequences or morphological parses for a given word in a given context, recently most prominently exemplified by the Constraint Grammar work (Karlsson et al., 1995; Voutilainen, 1995b; Voutilainen et al., 1992; Voutilainen and Tapanainen, 1993).
A88-1019 A92-1018 E93-1046 E95-1022 J88-1003
Church. 1988.
A88-1019
However, the observation that our constraints are localized to a window of a small number of tokens (say at most 5 tokens in a sequence), suggests a more efficient scheme originally used by Church (1988).
A88-1019
DeRose. 1988.
J88-1003
(see (Oflazer and Tiir, 1997)).
P97-1029
This paper extends a novel approach to constraint-based tagging first applied for Turkish (Oflazer and Tiir, 1997), which relieves the rule developer from worrying about conflicting rule ordering requirements and constraints.
P97-1029
