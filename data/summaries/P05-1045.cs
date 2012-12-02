We also provide the results from Bunescu and Mooney (2004) for comparison.
P04-1056
Abney. 1997.
J97-4005
1Prior uses in NLP of which we are aware include: Kim et al.(1995), Della Pietra et al.(1997) and Abney (1997).
E95-1008 J97-4005
Malouf (2002) and Curran and Clark (2003) condition the label of a token at a particular position on the label of the most recent previous instance of that same token in a prior sentence of the same document.
W02-2019 W03-0424
In contrast, the increases published by Bunescu and Mooney (2004) are relative to a baseline system which scores only 80.9% on the same task.
P04-1056
Chieu and Ng (2002) propose a solution to this problem: for each token, they define additional features taken from other occurrences of the same token in the document.
C02-1025
The most relevant prior works are Bunescu and Mooney (2004), who use a Relational Markov Network (RMN) (Taskar et al., 2002) to explicitly models long-distance dependencies, and Sutton and McCallum (2004), who introduce skip-chain CRFs, which maintain the underlying CRF sequence model (which (Bunescu and Mooney, 2004) lack) while adding skip edges between distant nodes.
P04-1056
Mikheev et al.(1999) and Finkel et al.(2004) incorporate label consistency information by using adhoc multi-stage labeling procedures that are effective but special-purpose.
E99-1001 W04-1217
