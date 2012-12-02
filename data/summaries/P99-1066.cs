The introduction of statistical parsing brought with an obvious tactic for ranking the agenda: (Bobrow, 1990) and (Chitrao and Grishman, 1990) first used probabilistic context free grammars (PCFGs) to generate probabilities for use in a figure of merit (FOM).
H90-1053
Later work introduced other FOMs formed from PCFG data (Kochman and Kupin, 1991); (Magerman and Marcus, 1991); and (Miller and Fox, 1994).
H91-1044 H91-1045 H94-1051
Given a few basic independence assumptions (Caraballo and Charniak, 1998), this value can be calculated as i i fl( N,k) P(NJ'k\]t°'~) = P(to,n), (2) with fl and a representing the well-known "inside" and "outside" probability functions: fl(Nj, k) = P(tj,klNj,,) (3) a(N,k) = P(tod, N,k, tk,n).
J98-2004 W98-1115
The (Caraballo and Charniak, 1998) article considers a number of different figures of merit for ordering the agenda, and ultimately recommends one that reduces the number of edges required for a full parse into the thousands.
J98-2004 W98-1115
This approximation, as given in (Caraballo and Charniak, 1998), is P(Nj, kltj-1)/3(N~,k)P(tklNj, k) P(tj,klt~-1)P(tklt~-l) (5) Of the five values required, P(N~.,kltj), P(tkltk_l), and P(tklN~,k) can be observed directly from the training data; the inside probability is estimated using the most probable parse for Nj, k, and the tag sequence probability is estimated using a bitag approximation.
J98-2004 W98-1115
of independent merit (Caraballo and Charniak, 1998) and \[Gold98\] use a figure which indicates the merit of a given constituent or edge, relative only to itself and its children but independent of the progress of the parse we will call this the edge's independent merit (IM).
J98-2004 W98-1115
