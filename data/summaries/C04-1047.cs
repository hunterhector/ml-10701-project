In (Akiba et al., 2002), this multiple scoring technique was shown to select the best translation better than a single scoring technique that uses TM and LM trained from a full corpus.
C02-1076
As Akiba et al.(2002) reported, the products of TM-scores and LM-scores are statistical variables.
C02-1076
D3 (DP-match Driven transDucer) is an example-based MT system using onlinegenerated translation patterns (Doi and Sumita, 2003).
W03-0318
C0 TM0LM0 Parallel corpus Figure 4: Method for training multiple pairs of Language Models (LMs) and Translation Models (TMs) (Akiba et al., 2002).
C02-1076
HPAT (Hierarchical Phrase Alignment based Translation) is a pattern-based system using automatically generated syntactic transfer (Imamura et al., 2003).
P03-1057
For scoring MT outputs, the proposed RSCM uses a score based on a translation model called IBM4 (Brown et al., 1993) (TM-score) and a score based on a language model for the translation target language (LM-score).
J93-2003
Next, it sorts the mixture of the MT outputs in all M-best lists in the order of the average product (Section 3.2) of the scores of a language model and a translation model (Akiba et al., 2002).
C02-1076
Figure 1 shows the differences among the performances, indicated by the Receiver Operating Characteristics (ROC) curve (Section 4.1), of the existing RSCM on each of three MT systems (Section 4.2.1): D3, HPAT, and SAT (Doi and Sumita, 2003; Imamura et al., 2003; Watanabe et al., 2003).
P03-1057 W03-0318
The translation models and language models were learned by using GIZA++ (Och and Ney, 2000) and the CMU-Cambridge Toolkit (Clarkson and Rosenfeld, 1997), respectively.
P00-1056
For robust scoring, the authors adopt the multiple scoring technique presented in (Akiba et al., 2002).
C02-1076
The elimination system is intended to be used in the selector architecture, as in (Akiba et al., 2002).
C02-1076
Next the proposed RSCM sorts the mixture of all the MT outputs in the order of the average product of the scores of a language model and a translation model (Akiba et al., 2002).
C02-1076
