Collins (2002) augmented a baseline NE tagger with a re-ranker that used only local, NE-oriented features.
P02-1034 P02-1062
Using SVMRank, (Shen and Joshi, 2003) achieved significant improvement on parse reranking.
W03-0402
Roth and Yih (2004) combined information from named entities and semantic relation tagging, adopting a similar overall goal but using a quite different approach based on linear programming.
W04-2401
Roth and Yih (2002) combined NE and semantic relation tagging, but within a quite different framework (using a linear programming model for joint inference).
C02-1151
(Charniak and Johnson, 2005) applied MaxEnt to improve the performance of a state-of-art parser; also in (Ji and Grishman, 2005) we used it to improve a Chinese name tagger.
P05-1022 P05-1051
Collins (2002) also applied re-ranking to improve name tagging.
P02-1034 P02-1062
Various supervised learning algorithms have been adapted to the task of reranking for NLP systems, such as MaxEnt-Rank (Charniak and Johnson, 2005; Ji and Grishman, 2005), SVMRank (Shen and Joshi, 2003), Voted Perceptron (Collins, 2002; Collins and Duffy, 2002; Shen and Joshi, 2004), Kernel Based Methods (Henderson and Titov, 2005), and RankBoost (Collins, 2002; Collins and Koo, 2003; Kudo et al., 2005).
J05-1003 P02-1034 P02-1062 P05-1022 P05-1023 P05-1024 P05-1051 W03-0402
Named Entity Taggers There have been a very large number of NE tagger implementations since this task was introduced at MUC-6 (Grishman and Sundheim, 1996).
C96-1079
We have applied the method described in (Shen and Joshi, 2003), to map SVM’s results to probabilities via a sigmoid.
W03-0402
for Re-Ranking 4.1 Inferences From Subsequent Stages Information extraction is a potentially symbiotic pipeline with strong dependencies between stages (Roth and Yih, 2002&2004; Ji and Grishman, 2005).
C02-1151 P05-1051 W04-2401
The HMM tagger generally follows the Nymble model (Bikel et al, 1997), and uses bestfirst search to generate N-Best hypotheses.
A97-1029
The complete set of detailed features is listed in (Ji and Grishman, 2006).
P06-2055
Additionally, we incorporate the pruning techniques used in (Chiang 2005), by which any hypothesis with a probability lower thanαtimes the highest probability for one sentence is discarded.
P05-1033
