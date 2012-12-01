It is usually estimated from statistics on word co-occurrences in large corpora (Hindle and Rooth, 1993).
J93-1005
For instance, Church and Hanks (1990) calculated SA in terms of mutual information between two words wl and w2: N * f(wl,w2) I(wl, w2) = log2 (1) f(wl)f(w2) here N is the size of the corpus used in the estimation, f(Wl, w2) is the frequency of the cooccurrence, f(wl) and f(w2) that of each word.
J90-1003
There are two main approaches to estimate the probability: smoothing methods (e.g., Church and Gale, 1991; Jelinek and Mercer, 1985; Katz, 1987) and class-based methods (e.g., Brown et al., 1992; Pereira and Tishby, 1992; Resnik, 1992; Yarowsky, 1992).
C92-2070
Some classbased methods (e.g., Yarowsky, 1992) associate each word with a single class without considcring the other words in the co-occurrence.
C92-2070
Weischedel et al.(1993) chose the lowest classes in a taxonomy 1416 for which the association for the co-occurrence can be estimated.
J93-2006
'The t-score (Church and Mercer, 1993) compares the hypothesis that a co-occurrence is significan~ against the null hypothesis that the co-occurrence can be attributed to chance.
J93-1001
Here, (1) indicates the performance obtained using the principle of Closest Attachment (Kimball, 1973); (2) shows the performance obtained using the lowest observed class co-occurrence (Weischedel et al., 1993); (3) is the result from the maximum mutual information over all pairs of classes corresponding to the words in the co-occurrence (Resnik, 1993; Alves, 1996); and (4) shows the performance of our method 7.
J93-2006
