Next, the WSJ10 was parsed using the parsing table described above and a minimum spanning tree algorithm for dependency parsing (McDonald et al., 2005).
H05-1066
Klein and Manning (2004), on the other hand, have handily beaten a random baseline using a projective model over part of speech tags and evaluating on a subset of WSJ, WSJ10.
P04-1061
distributions Klein and Manning (2004) point their model in the right direction by initializing the probability of dependencies inversely proportional to the distance between the head and the dependent.
P04-1061
Although he reported beating the random baseline for that task, both Klein and Manning (2004) and we have repli46 Slikes NPJohn VPlikes John likes NPcheese string cheese Figure 2: A Lexicalized Tree cated the random baseline above Paskin’s results.
P04-1061
However, results from the speech recognition community show that the inclusion of latent semantic information can enhance the performance of their models (Coccaro and Jurafsky, 1998; Bellegarda, 2000; Deng and Khudanpur, 2003).
N03-1008
Brill and Marcus (1992).
H92-1030
Recent work (Klein and Manning, 2002; Klein and Manning, 2004) has renewed interest by using a UGI model to parse sentences from the Wall Street Journal section of the Penn Treebank (WSJ).
P02-1017 P04-1061
5.1 Materials The WSJ10 dataset was used for evaluation to be comparable to previous results (Klein and Manning, 2004).
P04-1061
Projectivity has been assumed in previous cases of English UGI (Klein and Manning, 2004; Paskin, 2001).
P04-1061
semantics Previous work has focused on syntax to the exclusion of semantics (Brill and Marcus, 1992; van Zaanen, 2000; Klein and Manning, 2002; Paskin, 2001; Klein and Manning, 2004; Solan et al., 2005).
C00-2139 H92-1030 P02-1017 P04-1061
The second thread is dependency-based UGI, used by Klein and Manning (2004), which nicely dovetails with our semantic approach.
P04-1061
English is a projective language, but other languages, such as Bulgarian, are not (Pericliev and Ilarionov, 1986).
C86-1011
McDonald et al.(2005). Prior distributions have been previously assumed as well (Klein and Manning, 2004).
H05-1066 P04-1061
Figure 3: A Nonprojective Dependency Graph 1 2 3 4 5 6 7 8 9 100 0.5 1 1.5 2 2.5 3 x 10 4 Words Distant Number of Dependencies Figure 4: Distance Between Dependents in WSJ10 4.3 Context The core of several UGI approaches is distributional analysis (Brill and Marcus, 1992; van Zaanen, 2000; Klein and Manning, 2002; Paskin, 2001; Klein and Manning, 2004; Solan et al., 2005).
C00-2139 H92-1030 P02-1017 P04-1061
Dependencies have been used for UGI before with mixed success (Paskin, 2001; Klein and Manning, 2004).
P04-1061
While other contemporary research in this area is promising, the case for real-world English UGI has not been as convincingly made (van Zaanen, 2000; Solan et al., 2005).
C00-2139
Subsequently, either SVDPACK or the LSI tools were used by the majority of researchers in this area (Sch¨utze, 1995; Landauer and Dumais, 1997; Landauer et al., 1998; Coccaro and Jurafsky, 1998; Foltz et al., 1998; Bellegarda, 2000; Deng and Khudanpur, 2003).
N03-1008
of speech Klein and Manning (2004) used part of speech tags as basic elements instead of words.
P04-1061
Some of these may be motivated from the Klein and Manning (2004) model, while others may be motivated from research efforts outside the UGI community.
P04-1061
