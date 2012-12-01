In both trees, the string-similarity features occur on the top portion, which supports the arguments by (Strube et al., 2002) and (Yang et al., 2004) that string-matching is a crucial factor for NP coreference resolution.
W02-1040
Among them, NE recognition, part-of-speech tagging and text chunking adopt the same HMM based engine with error-driven learning capability (Zhou and Su, 2002).
P02-1060
In the heuristic salience-based algorithm for pronoun resolution, Lappin and Leass (1994) introduce a procedure for identifying anaphorically linked NP as a cluster for which a global salience value is computed as the sum of the salience values of its elements.
J94-4002
Besides, the idea of clustering can be seen in the research of cross-document coreference, where NPs with high context similaritywouldbechainedtogetherbasedoncertain clustering methods (Bagga and Biermann, 1998; Gooi and Allan, 2004).
N04-1002 P98-1012
Aone and Bennett (1995); McCarthy and Lehnert (1995); Soon et al.(2001); Ng and Cardie (2002b)).
J01-4004 P02-1014 P95-1017 W02-1008
The NE recognition component trained on GENIA (Shen et al., 2003) can recognize up to 23 common biomedical entity types with an overall performance of 66.1 Fmeasure (P=66.5% R=65.7%).
W03-1307
Cardie and Wagstafi (1999) have proposed an unsupervised approach which also incorporates cluster information into consideration.
W99-0611
MRF (Soon et al., 2001) selects the candidate closest to the anaphor, while BF (Aone and Bennett, 1995; Ng 2The confldence value is obtained by using the smoothed ratio p+1t+2, where p is the number of positive instances and t is the total number of instances contained in the corresponding leaf node.
J01-4004 P95-1017
Inspired by the work of (Strube et al., 2002) and (Yang et al., 2004), we use two features, StrSim1 (f17) and StrSim2 (f18), to measure the string-matching degree of NPj and NPi.
W02-1040
2 Baseline: the NP-NP based approach 2.1 Framework description We built a baseline coreference resolution system, which adopts the common NP-NP based learning framework as employed in (Soon et al., 2001).
J01-4004
A similar flnding was also reported by Ng and Cardie (2002b) in the MUC data set.
P02-1014 W02-1008
The recall and precision were calculated automatically according to the scoring scheme proposed by Vilain et al.(1995). In Table 3 we compared the performance of difierent coreference resolution systems.
M95-1005
Most of the features come from Soon et al.(2001)’s system.
J01-4004
So far, several efiorts (Harabagiu et al., 2001; Ng and Cardie, 2002a; Ng and Cardie, 2002b) have attempted to address this problem by discarding the \hard" pairs and select only those confldent ones from the NP-pair pool.
N01-1008 P02-1014 W02-1008
