D.Bean and E.Riloff. 1999.
P99-1048
MUC-6 MUC-7 R P F R P F Strube (1998) 76.1 74.3 75.1 62.9 60.3 61.6 Ng and Cardie (2002a) 75.4 73.8 74.6 58.9 56.8 57.8 Connolly et al.(1997) 57.2 57.2 57.2 50.1 50.1 50.1 Our approach 79.3 77.5 78.3 64.4 62.1 63.2 Table 2: Results for the pronoun resolution MUC-6 MUC-7 R P F R P F Ng and Cardie (2002a) 51.0 89.9 65.0 39.1 86.4 53.8 Connolly et al.(1997) 52.2 52.2 52.2 43.7 43.7 43.7 Our approach 51.3 90.4 65.4 39.7 87.6 54.6 Table 3: Results for the non-pronoun resolution MUC-6 MUC-7 R P F R P F Ng and Cardie (2002a) 62.2 78.8 69.4 48.4 74.6 58.7 Our approach 64.0 80.5 71.3 50.1 75.4 60.2 Table 4: Results for the coreference resolution Compared with the gains in pronoun resolution, the improvement in non-pronoun resolution is slight.
C02-1139 P02-1014 P98-2204
In our future work, we intend to adopt a looser filter together with an anaphoricity determination module (Bean and Riloff, 1999; Ng and Cardie, 2002b).
C02-1139 P02-1014 P99-1048
And centering algorithms (Brennan et al., 1987; Strube, 1998; Tetreault, 2001), sort the antecedent candidates based on the ranking of the forward-looking or backwardlooking centers.
J01-4003 P87-1022 P98-2204
2. Ng and Cardie’s machine learning approach to coreference resolution (Ng and Cardie, 2002a).
C02-1139 P02-1014
Mitkov’s knowledge-poor pronoun resolution method (Mitkov, 1998), for example, uses the scores from a set of antecedent indicators to rank the candidates.
P98-2143
To determine the boundary of the noun phrases, a pipeline of Nature Language Processing components are applied to an input raw text: null Tokenization and sentence segmentation null Named entity recognition null Part-of-speech tagging null Noun phrase chunking Among them, named entity recognition, part-ofspeech tagging and text chunking apply the same Hidden Markov Model (HMM) based engine with error-driven learning capability (Zhou and Su, 2000 & 2002).
P02-1060 W00-1309
References Chinatsu Aone and Scott W.Bennett. 1995.
P95-1017
Tetreault. 2001.
J01-4003
In recent years, supervised machine learning approaches have been widely used in coreference resolution (Aone and Bennett, 1995; McCarthy, 1996; Soon et al., 2001; Ng and Cardie, 2002a), and have achieved significant success.
C02-1139 J01-4004 P02-1014 P95-1017
Strube’s S-list algorithm for pronoun resolution (Stube, 1998).
P98-2204
For example, the “Best-First” selection algorithms (Aone and Bennett, 1995; Ng and Cardie, 2002a) link the anaphor to the candidate with the maximal confidence value (above 0.5).
C02-1139 P02-1014 P95-1017
For this purpose, we obtain the recall, the precision and the F-measure using the standard MUC scoring program (Vilain et al.1995) for the coreference resolution task.
M95-1005
For example, “Closest-First” (Soon et al., 2001) selects the candidate closest to the anaphor, while “Best-First” (Aone and Bennett, 1995; Ng and Cardie, 2002a) selects the candidate with the maximal confidence value.
C02-1139 J01-4004 P02-1014 P95-1017
