(Fox, 2002) studied the extent to which the cohesion constraint holds in a parallel corpus and the reasons for the violations, but did not apply the constraint to an alignment algorithm.
W02-1039
We trained our alignment programs with the same 50K pairs of sentences as (Och and Ney, 2000) and tested it on the same 500 manually aligned sentences.
P00-1056
The reboot causes the host to discover all the devices det subj det subj aux pre det obj comp à la Suite réinitialisation, l' hôte repère tous les périphériques 1 2 3 4 5 6 7 8 9 10 1 2 3 4 5 6 7 8 9 10 11 after to the reboot the host locate all the peripherals Figure 2: An example pair of aligned sentence The cohesion constraint (Fox, 2002) uses the dependency tree TE (Mel’ˇcuk, 1987) of the English sentence to restrict possible link combinations.
W02-1039
Fox. 2002.
W02-1039
The details of this algorithm are described in (Cherry and Lin, 2003).
P03-1012
We use a sentence-aligned corpus to compute the 2 correlation metric (Gale and Church, 1991) between all English-French word pairs.
H91-1026
We parsed the training and testing corpora with Minipar.1 We adopted the evaluation methodology in (Och and Ney, 2000), which defines three metrics: precision, recall and alignment error rate (AER).
P00-1056
Methods such as (Wu, 1997), (Alshawi et al., 2000) and (Lopez et al., 2002) employ a synchronous parsing procedure to constrain a statistical alignment.
J00-1004 J97-3002
As a reference point, we also provide the results reported in (Och and Ney, 2000).
P00-1056
More recently, there have been many proposals to introduce syntactic knowledge into SMT models (Wu, 1997; Alshawi et al., 2000; Yamada and Knight, 2001; Lopez et al., 2002).
J00-1004 J97-3002 P01-1067
Given a head node eh and its modifier em, a head-modifier overlap occurs when: spanH(eh;TE;A)\spanP(em;TE;A)6=; Given two nodes em1 and em2 which both modify the same head node, a modifier-modifier overlap occurs when: spanP(em1;TE;A)\spanP(em2;TE;A)6=; Following (Fox, 2002), we say an alignment is cohesive with respect to TE if it does not introduce any headmodifier or modifier-modifier overlaps.
W02-1039
The work done in (Yamada and Knight, 2001) measures statistics on operations that transform a parse tree from one language into another.
P01-1067
With these definitions of phrase and head spans, we define two notions of overlap, originally introduced in (Fox, 2002) as crossings.
W02-1039
The first algorithm is similar to Competitive Linking (Melamed, 1997).
P97-1063
