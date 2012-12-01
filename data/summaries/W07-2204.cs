Table 1 shows that parser accuracy increases with the size of the in-domain selftraining material.3 The figures confirm the claim of McClosky et al.(2006a) that self-training with a reranking parsing model is effective for improving parser accuracy in general, and the claim of Gildea (2001) that training on in-domain data is effective for parser adaption.
N06-1020 P06-1043 W01-0521
Selftraining is the process of training a parser on its own output, and earlier self-training experiments using generative statistical parsers did not yield encouraging results (Steedman et al., 2003).
E03-1008
A breakthrough has come in the form of research by McClosky et al.(2006a; 2006b) who show that self-training can be used to improve parser performance when combined with a two-stage reranking parser model (Charniak and Johnson, 2005).
N06-1020 P05-1022 P06-1043
The f-score of 83.7% is lower than the f-score of 85.2% reported by McClosky et al.(2006b) for the same parser on Brown corpus data.
N06-1020 P06-1043
McClosky et al.(2006a; 2006b) proceed as follows: sentences ∗Now affiliated to Lalic, Universit´e Paris 4 La Sorbonne.
N06-1020 P06-1043
Given the success of statistical parsing models on the Wall Street Journal (WSJ) section of the Penn Treebank (PTB) (Charniak, 2000; Collins, 2003, for example), there has been a change in focus in recent years towards the problem of replicating this success on genres other than American financial news stories.
A00-2018 J03-4003
In the experiments of McClosky et al.(2006a; 2006b), the parse trees used for self-training come from the same domain (American newspaper text) as the parser’s original seed training material.
N06-1020 P06-1043
The reranking parser of Charniak and Johnson (2005) was used to parse the BNC.
P05-1022
The sentences included in the gold standard were chosen at random from the BNC, subject to the condition that they contain a verb which does not occur in the training sections of the WSJ section of the PTB (Marcus et al., 1993).
J93-2004
33 using the reranking parser of Charniak and Johnson (2005).
P05-1022
