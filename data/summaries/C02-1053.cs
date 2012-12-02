Non-linear decision surfaces can be realized byreplacingtheinnerproductof(4)withakernel function K(x· x i ): g(x)= parenleftBigg lscript summationdisplay i=1 λ i y i K(x i,x)+b parenrightBigg . (5) In this paper, we use polynomial kernel functionsthathavebeenveryeﬀectivewhenapplied to other tasks, such as natural language processing(Joachims, 1998; Kudoand Matsumoto, 2001; Kudo and Matsumoto, 2000): K(x,y)=(x ·y+1) d . (6) 2.2 Sentence Ranking by using Support Vector Machines Important sentence extraction can be regarded as a two-class problem: important or unimportant.
N01-1025 W00-1303
Aone et al.(1998) and Kupiec et al.(1995) employed Bayesianclassiﬁers, Manietal.
P98-1009
Named Entities x[r]=1(1≤r≤8)indicatesthat a certainNamed Entity class appears in S i . The number of Named Entityclasses is 8 (Sekine and Eriguchi, 2000), e.g., PERSON, LOCATION.
C00-2167
Therefore, SVMs have shown good performance for text categorization (Joachims, 1998), chunking (Kudo and Matsumoto, 2001), and dependency structure analysis (Kudo and Matsumoto, 2000).
N01-1025 W00-1303
We use Isozaki’s NE recognizer (Isozaki, 2001).
P01-1041
We deﬁne the boolean features discussed below that are associated with sentence S i by taking past studies into account (Zechner, 1996; Nobata et al., 2001; Hirao et al., 2001; Nomoto and Matsumoto, 1997).
C96-2166
