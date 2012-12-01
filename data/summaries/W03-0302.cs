Vogel and Tillmann, 1996).
C96-2141
This is similar to the competitive linking process (Melamed, 2000).
J00-2004
Fox. 2002.
W02-1039
We can rewrite P(lk|Ck) as: P(lk|Ck) = P(lk,Ck)P(C k) = P(Ck|lk)P(lk)P(C k,eik,fjk) = P(lk|eik,fjk)× P(Ck|lk)P(C k|eik,fjk) Here P(lk|eik,fjk) is link probability given a cooccurrence of the two words, which is similar in spirit to Melamed’s explicit noise model (Melamed, 2000).
J00-2004
This produces a tractable formulation for P(A|E,F): tproductdisplay k=1  P(lk|ei k,fjk)× productdisplay ft∈FTk P(ft|lk) P(ft|eik,fjk)   More details on the probability model used by ProAlign are available in (Cherry and Lin, 2003).
N03-2017 P03-1012
More details on the cohesion constraint can be found in (Lin and Cherry, 2003).
N03-2017 P03-1012
ProAlign models P(A|E,F) directly, using a different decomposition of terms than the model used by IBM (Brown et al., 1993).
J93-2003
Given a head node eh and its modifier em, a head-modifier overlap occurs when: spanH(eh,TE,A)∩ spanP(em,TE,A) negationslash= ∅ Given two nodes em1 and em2 which both modify the same head node, a modifier-modifier overlap occurs when: spanP(em1,TE,A)∩ spanP(em2,TE,A) negationslash= ∅ Following (Fox, 2002), we say an alignment is cohesive with respect to TE if it does not introduce any head-modifier or modifier-modifier overlaps.
W02-1039
However, the experiments conducted in (Fox, 2002) indicate that dependency trees demonstrate a higher degree of phrasal cohesion during translation than other structures.
W02-1039
To avoid this problem, we sample from a space of probable alignments, as is done in IBM models 3 and above (Brown et al., 1993), and weight counts based on the likelihood of each alignment sampled under the current probability model.
J93-2003
The algorithm creates an initial alignment using search, constraints, and summed φ2 correlation-based scores (Gale and Church, 1991).
H91-1026
With these definitions of phrase and head spans, we define two notions of overlap, originally introduced in (Fox, 2002) as crossings.
W02-1039
The first constraint is the one-to-one constraint (Melamed, 2000): every word (except the null words e0 and f0) participates in exactly one link.
J00-2004
The second constraint, known as the cohesion constraint (Fox, 2002), uses the dependency tree (Mel’ˇcuk, 1987) of the English sentence to restrict possible link combinations.
W02-1039
