2 β Table 1: Results of our baseline multi-agent coreference resolution system on MUC-6 and MUC-7 MUC-6 MUC-7 Performance R P F R P F Overall 65.8 84.7 73.9 55.7 82.8 66.5 • Agent for name alias coreference 32.7 (35) 92.3 33.6 (36) 89.0 • Agent for apposition coreference 4.3 (5) 95.5 2.6 (3) 84.6 • Agent for predicate nominal coreference 3 (2) (3) • Agent for pronominal coreference 18.6 (22) 77.5 10.8 (16) 72.3 • Agent for definite noun phrase coreference 9.4 (15) 80.0 7.0 (20) 85.0 • Agent for demonstrative noun phrase coreference 0.1 (2) 50.0 0.2 (2) 66.7 • Agent for bare noun phrase coreference 1.9 (19) 63.0 1.7 (20) 61.1 Table 2: Comparison of our system with the best-reported systems on MUC-6 and MUC-7 MUC-6 MUC-7 Performance Comparison R P F R P F Ours 65.8 84.7 73.9 55.7 82.8 66.5 Ng and Cardie 2002 (C4.5) 64.1 74.9 69.1 57.4 70.8 63.4 Ng and Cardie 2002 (RIPPER) 64.2 78.0 70.4 55.7 72.8 63.1 Table 1 shows that our system achieves Fmeasures of 73.9 and 66.5 on MUC-6 and MUC-7 standard test data, respectively.
P02-1014
However, the pressing need for the development of robust and inexpensive solutions encouraged the drive toward knowledge-poor strategies (Dagan and Itai 1990; Lappin and Leass 1994; Mitkov 1998; Soon, Ng and Lim 2001; Ng and Cardie 2002), which was further motivated by the emergence of cheaper and more reliable corpusbased NLP tools such as part-of-speech taggers and shallow parsers alongside the increasing availability of corpora and other resources (e.g.
C90-3063 J01-4004 J94-4002 P02-1014 P98-2143
In our system, the possible referring expressions are determined by a pipeline of NLP components: • Tokenization and sentence segmentation • Named entity recognition • Part-of-speech tagging • Noun phrase chunking Among them, named entity recognition, partof-speech tagging and noun phrase chunking apply the same Hidden Markov Model (HMM) based engine with error-driven learning capability (Zhou and Su 2000).
W00-1309
Many of the earlier works in coreference resolution heavily exploited domain and linguistic knowledge (Carter 1987; Rich and LuperFoy 1988; Carbonell and Brown 1988).
A88-1003
The HMM-based noun phrase chunking component (Zhou and Su 2000) determines various noun phrases based on the results of named entity recognition and part-ofspeech tagging.
W00-1309
Our system achieves significantly better precision rates by 6.7~10.0 percent over the best-reported systems (Ng and Cardie 2002) while keeping recall rates.
P02-1014
In this paper, it is tackled by a named entity recognition component, as in Zhou and Su (2002), using the following name alias algorithm in the ascending order of complexity: 1) The simplest case is to recognize full identity of strings.
P02-1060
The recall difference between our system and the RIPPER system in (Ng and Cardie 2002) maybe come from the predicate nominal coreference, which can be easily resolved using a machine learning algorithm, e.g.
P02-1014
Table 2 shows that our system achieves significantly better F-measures by 3.1~4.8 percent over the best-reported systems (Ng and Cardie 2002).
P02-1014
While a number of approaches use a similar set of factors, the computational strategies (the way antecedents are determined, i.e. the algorithm and formula for assigning antecedents) may differ, i.e. from simple co-occurrence rules (Dagan and Itai 1990) to decision trees (Soon, Ng and Lim 2001; Ng and Cardie 2002) to pattern induced rules (Ng and Cardie 2002) to centering algorithms (Grosz and Sidner 1986; Brennan, Friedman and Pollard 1987; Strube 1998; Tetreault 2001).
C90-3063 J01-4003 J01-4004 J86-3001 P02-1014 P87-1022 P98-2204
The named entity recognition component (Zhou and Su 2002) recognizes various types of MUC-style named entities, that is, organization, location, person, date, time, money and percentage.
P02-1060
