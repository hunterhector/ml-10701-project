Berger et al.1996 presented a way of computing conditional maximum entropy models directly by modifying equation 6 as follows (now instead of w we will explicitly use (x, y) ): i ~Cx~) = ~ f~(~, y) * ~(~, y) ~ ~ .~(~, y) * ~(~) * pCy I ~) = p(xk) (9) x6X yEY xEX yEY where ~(x, y) is an empirical probability of a joint configuration (w) of certain instantiated factor I variables with certain instantiated behavior variables.
J96-1002
Reynar&Ratnaparkhi 1997 J.
A97-1004
For the evaluation we usecl the same 27,294 sentences as in PaimerSzHearst 1994 and Palmer&Hearst 1997 I° which were also used by Reynar&Ratnaparkhi 1997 in the evaluation of their system.
A97-1004 J97-2002
Our method uses assumptions similar to Berger et al.1996 but is naturally suitable for distributed parallel computations.
J96-1002
First as the configuration space we can use only the reference nodes (w) from the lattice which makes it similar to the method of Berger et al.1996 described in section 2.1.
J96-1002
228 and abbreviations at the end of sentence as, for instance, the Wall Street Journal (WSJ) corpus ( Marcus et ai.1993 ).
J93-2004
We collected training samples from the Brown Corpus distributed with the Penn Treebank (Marcus et al.1993 ).
J93-2004
References Berger et al.1996 A.
J96-1002
In Computational Linguistics, vol 19/2 pp.313-329 Palmer&Hearst 1994 D.
A94-1013
We adopted the stop condition suggested in Berger et al.1996 the maximization of the likelihood on a cross-validation set of samples which is unseen at the parameter esti~_tion.
J96-1002
In IEEE Transactions on Acoustics, Speech and Signal Processing, ASSP-35 Marcus et a1.1993 M.
J93-2004
To make feature ranking computationally tractable in Della Pietra et al.1995 and Berger et al.1996 a simplified process proposed: at the feature ranking stage when adding a new feature to the model all previously computed parameters are kept fixed and, thus, we have to fit only one new constraint imposed by a candidate feature.
J96-1002
