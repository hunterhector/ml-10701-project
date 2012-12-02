Zhang et al.(2006) and Mauser et al.(2006) use adapted language model for SMT re-ranking.
W06-1626
SIGIR-1999: 74-81 Franz Josef Och 2003.
P03-1021
EMNLP-2006:216-223 Bing Zhao, Matthias Eck, Stephan Vogel 2004.
C04-1059
LNAI 2479: 18-32 Ying Zhang, Almut Silja Hildebrand, Stephan Vogel 2006.
W06-1626
Zhao et al.(2004) and Eck et al.(2004) introduce information retrieval method for language model adaptation.
C04-1059
The translation quality is evaluated by BLEU metric (Papineni et al., 2002), as calculated by mteval-v11b.pl 6 with case-sensitive matching of n-grams.
P02-1040
In training process, we use GIZA++ 4 toolkit for word alignment in both translation directions, and apply “grow-diag-final” method to refine it (Koehn et al., 2003).
N03-1017
Proceedings of International Workshop on Spoken Language Translation.:103-110 Dragos Stefan Munteanu and Daniel Marcu 2005.
J05-4003
Computational Linguistics, 31 (4): 477-504 Dragos Stefan Munteanu and Daniel Marcu 2006.
P06-1011
Some work tries to acquire parallel sentences from web (Nie et al.1999; Resnik and Smith 2003; Chen et al.2004). Others extract parallel sentences from comparable or non-parallel corpora (Munteanu and Marcu 2005, 2006).
J03-3002 J05-4003 P06-1011
This is different from the common language model adaptation methods, which have to do at lease one pass machine translation to get the candidate English translation as query(Zhao 2004, Zhang 2006).
C04-1059 W06-1626
For the log-linear model training, we take minimum-error-rate training method as described in (Och, 2003).
P03-1021
