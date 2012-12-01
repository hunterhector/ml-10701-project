For a given pair of words X and Y and a search window W, let a be the number of windows in which X and Y co-occur, let b be the number of windows in which only X occurs, let c be the number of windows in which only Y occurs, and let d be the number of windows in which none of them occurs, then G 2 = 2 (alna + blnb + clnc + dlnd (a+b)ln(a+b) (a+c)ln(a+c) (b+d)ln(b+d) (c+d)ln(c+d)) + (a+b+c+d)ln(a+b+c+d)) In addition to the log-likelihood, the t-score is used to filter out insignificant co-occurrence word pairs (Fung and Church, 1994), which is calculated as follows: ),( 1 )()(),( ba baba WWprob M WprobWprobWWprob t − = In order to filter out weak collocates, a threshold is often used, i.e. in the stage of collocation extraction, any pairs of items producing word affinity scores lower than a given threshold are excluded from the MWE searching process.
C94-2178
Tanaka, T., Baldwin, T., 2003.
W03-1803 W03-1812
Fung, P., Church, K., 1994.
C94-2178
89–96. Dagan, I., Church, K., 1994.
A94-1006
Dias, G., 2003.
W03-1806
Directly related to our work is the development of a statistical MWE tool at Lancaster for searching and identifying English MWEs in running text (Piao et al., 2003, 2005).
W03-1807
Work The issue of MWE processing has attracted much attention from the Natural Language Processing (NLP) community, including Smadja, 1993; Dagan and Church, 1994; Daille, 1995; 1995; McEnery et al., 1997; Wu, 1997; Michiels and Dufour, 1998; Maynard and Ananiadou, 2000; Merkel and Andersson, 2000; Piao and McEnery, 2001; Sag et al., 2001; Tanaka and Baldwin, 2003; Dias, 2003; Baldwin et al., 2003; Nivre and Nilsson, 2004 Pereira et al,.
A94-1006 J93-1007 J97-3002 W03-1803 W03-1806 W03-1807 W03-1812
Smadja, F., 1993.
J93-1007
Wu, D., 1997.
J97-3002
Dunning, T., 1993.
J93-1003
