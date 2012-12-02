Interestingly, existing machine learning approaches to coreference resolution have performed reasonably well without anaphoricity determination (e.g., Soon et al.(2001), Ng and Cardie (2002b), Strube and M¨uller (2003), Yang et al.(2003)). Nevertheless, there is empirical evidence that resolution systems might further be improved with anaphoricity information.
C02-1139 J01-4004 P02-1014 P03-1022 P03-1023
One common approach involves the design of heuristic rules to identify specific types of (non-)anaphoric NPs such as pleonastic pronouns (e.g., Paice and Husk (1987), Lappin and Leass (1994), Kennedy and Boguraev (1996), Denber (1998)) and definite descriptions (e.g., Vieira and Poesio (2000)).
C96-1021 J00-4003 J94-4002
Interestingly, most existing work employs constraintbased, locally-optimized methods (e.g., Mitkov et al.(2002) and Ng and Cardie (2002a)), leaving the remaining three possibilities largely unexplored.
C02-1139 P02-1014
Locally-Optimized Approach In this approach, the anaphoricity model is simply a classifier that is trained and optimized independently of the coreference system (e.g., Evans (2001), Ng and Cardie (2002a)).
C02-1139 P02-1014
Results using RIPPER and MaxEnt as the underlying learners are shown in rows 1 and 2 of Table 2 where performance is reported in terms of recall, precision, and F-measure using the model-theoretic MUC scoring program (Vilain et al., 1995).
M95-1005
More recently, the problem has been tackled using unsupervised (e.g., Bean and Riloff (1999)) and supervised (e.g., Evans (2001), Ng and Cardie (2002a)) approaches.
C02-1139 P02-1014 P99-1048
Details can be found in Soon et al.(2001) or Ng and Cardie (2002b).
C02-1139 J01-4004 P02-1014
(In our experiments, we use maximum entropy classification (MaxEnt) (Berger et al., 1996) to train this probability model).
J96-1002
For instance, our coreference system mistakenly identifies an antecedent for many non-anaphoric common nouns in the absence of anaphoricity information (Ng and Cardie, 2002a).
C02-1139 P02-1014
Space limitations preclude a description of these features; see Ng and Cardie (2002a) for details.
C02-1139 P02-1014
In all of our experiments, we use our learning-based coreference system (Ng and Cardie, 2002b).
C02-1139 P02-1014
