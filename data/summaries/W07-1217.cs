Malouf (2002) and Sha and Pereira (2003) show that gradient-based algorithms, particularly limited memory variable metric (LMVM), require much less time to reach convergence, for some NLP tasks, than the iterative scaling methods (Della Pietra et al., 1997) previously used for log-linear optimisation problems.
W02-2018
The system tokenizes, tags, lemmatizes and parses input sentences using the recent (second) release of the RASP (Robust Accurate Statistical Parsing) system (Briscoe et al., 2006) which parses arbitrary English text with state-of-the-art levels of accuracy.
P06-2006 P06-4020
Briscoe. 2006.
P06-2006 P06-4020
Often the (Johnson and Charniak, 2004) method identified disfluent regions overlapped with identified fragments found in the partial parse, the removal of which would yield a fluent sentence.
P04-1005
Specifically, we use the open-source Toolkit for Advanced Discriminative Modeling (TADM:2 Malouf, 2002) for training, using its limited-memory variable metric as the optimization method and determining best-performing convergence thresholds and prior sizes experimentally.
W02-2018
Both corpora were lemmatised, tagged and parsed with RASP (Briscoe et al., 2006).
P06-2006 P06-4020
2.2 Log-linear models for disambiguation Since Johnson et al.(1999), log-linear models of the following form have become standard as disambiguation devices for precision grammars: P(x|y) = e summationtextm j=1 jfj(x,y) summationtext xprime?X(y) e summationtextm j=1 jfj(xprime,y) They are used for parse selection in the English Resource Grammar (Toutanova et al., 2002), the English ParGram LFG (Riezler et al., 2002), the English Enju HPSG (Miyao and Tsujii, 2002), the HPSG-inspired Alpino parser for Dutch (Malouf and van Noord, 2004; van Noord, 2006) and the English CCG from Edinburgh (Clark and Curran, 2004).
P02-1035 P99-1069
used properties for disambiguation The first set of properties with which we conducted experiments was built on the model of the property set used for the disambiguation of English ParGram LFG parses (Riezler et al., 2002; Riezler and Vasserman, 2004).
P02-1035
By demonstrating that property design is the key to good log-linear models for ?deep??syntactic disambiguation, our work confirms that ?specifying the features of a SUBG [stochastic unification-based grammar] is as much an empirical matter as specifying the grammar itself??(Johnson et al., 1999).
P99-1069
For the experiments reported in this paper, we parsed the source language side of a parallel corpus (a small subsection of the English-German Europarl corpus; (Koehn, 2002)) with the XLE system, using 36 the ParGram LFG grammar and applying probabilistic disambiguation (Riezler et al., 2002) to obtain a single analysis (i.e., a c-structure [phrase structure tree] and an f-structure [an associated attributevalue matrix with morphosyntactic feature information and a shallow semantic interpretation]) for each sentence.
P02-1035
This definition of partial parse is effectively the same to the view of partial analyses in (Kasper et al., 1999).
P99-1052
This report uses an iterative procedure to demonstrate that what appears to be near magical could result mostly from mechanisms that do not require the existence of innate principles of grammar, as they are based on children?s inherent capacities for perception, 7; Saffran, Johnson, Aslin, & Newport, 1999).
P99-1069
Finally, word similarity can be computed from structural features like head-modifier relationships (Grefenstette 1994b; Ruge 1992; Dagan, Marcus, and Markovitch 1993; Pereira, Tishby, and Lee 1993; Dagan, Pereira, and Lee 1994).
J93-2004
This was done to some extent in Riezler et al.(2002) to automatically generate training data for the log-linear disambiguation component of XLE.
P02-1035
With the evolution of the grammar, the treebank as the output from the grammar changes over time (Oepen et al., 2002).
C02-2025
Tag sets for English are derived from the Penn Treebank (Marcus et al., 1993).
J93-2004
annotation For manual syntactic annotation of collected data (see Section 4), we followed the syntactic annotation conventions of the well-known Penn Treebank (Marcusetal., 1993).
J93-2004
Mitchell P. Marcus, Beatrice Santorini, and Mary Ann Marcinkiewicz. 1993. Building a large annotated corpus of English: The Penn Treebank. Computational Linguistics, 19(2):313330.
J93-2004
A similar approach has also been reported in (Johnson et al., 1999; Riezler et al., 2002; Malouf and van Noord, 2004).
P02-1035 P04-1005 P99-1069
Though not explicitly pointed out by (Kasper et al., 1999), such an algorithm allows the weights of the edges to be of any real value (no assumption of positive weights) as long as the graph is a Directed Acyclic Graph (DAG).
P99-1052
For instance, (Riezler et al., 2002) uses the fewest chunk method to choose the best fragment analyses for sentences without full analysis.
P02-1035
Our error reduction of 51.0% also compares favorably to the 36% error reduction on English LFG parses reported in Riezler et al.(2002). However, it is considerably lower than the error reduction of 78% reported for the Dutch Alpino parser (Malouf and van Noord, 2004), but this may be due to the fact that our lower bound is calculated on the basis of analyses that have already passed a prefilter and is thus relatively high.
P02-1035
gions and potentially capturing meaningful text is a shallow parsing method described in (Johnson and Charniak, 2004), which searches the text string for approximately repeated constituents.
P04-1005
Path (Kasper et al., 1999) proposed an alternative solution to the problem.
P99-1052
1w 2w 3w 4w0 1 2 3 4 b c e g h d f a :2 :2 :2:2 :1 :1 :1 i 8:1 : Figure 2: Shortest path partial parses with heuristically assigned edge weights However, (Kasper et al., 1999) did not provide any sophisticated estimation functions based on the shortest path approach.
P99-1052
The parameters can be efficiently estimated from a treebank, as shown by (Malouf, 2002).
W02-2018
2http://www.gate.ac.uk 3http://nlp.stanford.edu/software/tagger.shtml 166 We adopted a similar strategy with the domain independent full parsing system RASP (Briscoe et al., 2006).
P06-2006 P06-4020
Oepen. 2002.
C02-2025
Penn treebank (PTB) (Marcus et al., 1993). We used
J93-2004
Penn Treebank (Marcus et al., 1993), using a stan-
J93-2004
Following the definition of partial parses in (Kasper et al., 1999), different partial parse selection methods are presented and evaluated on the basis of multiple metrics, from both the syntactic and semantic viewpoints.
P99-1052
M.P. Marcus, B. Santorini, and M. Marcinkiewicz. 1993. Building a Large Annotated Corpus of English: The Penn Treebank. ComputationalLinguistics, 19(2):313330.
J93-2004
XLE selects the most probable analysis from the potentially large candidate set by means of a stochastic disambiguation component based on a log-linear probability model (Riezler et al., 2002) that works on the packed representations.
P02-1035
For sentences out of coverage, it employs the robustness techniques (fragment parsing, ?skimming?? implemented in XLE and described in Riezler et al.(2002), so that 100% of our corpus sentences receive at least some sort of analysis.
P02-1035
Empirical evaluation has been done with the ERG on a small set of texts from the Wall Street Journal Section 22 of the Penn Treebank (Marcus et al., 1993).
J93-2004
However, as pointed out in (Kasper et al., 1999), not all passive edges are good candidates, as not all of them provide useful syntactic/semantic information.
P99-1052
To compare with, we used RASP 2 (Briscoe et al., 2006), a domain-independent robust parsing system for English.
P06-2006 P06-4020
A recent development in data-driven parsing is the use of discriminative training methods (Riezler et al., 2002; Taskar et al., 2004; Collins and Roark, 2004; Turian and Melamed, 2006).
P02-1035
Its main components are the Conditional Random Fields toolkit MALLET2 (McCallum, 2002) and the RASP syntactic parsing toolkit3 (Briscoe et al., 2006), which are both publicly available.
P06-2006 P06-4020
(Charniak, 2000; Briscoe et al., 2006), have wide coverage and yield grammatical representations capable of supporting various applications (e.g.
P06-2006 P06-4020
(Kasper et al., 1999) did point out that the weights of the edges can be assigned by an estimation function.
P99-1052
(Kasper et al., 1999) rely on another scoring function in order to re-rank the partial parses.
P99-1052
In recent empirical studies on maximum entropy models and CRFs, limited memory variable metric (LMVM) has proven to be the most efficient method (Malouf, 2002; Wallach, 2002); accordingly, we have used LMVM for CRF estimation.
W02-2018
In brief, the abstracts of 16,609 articles curated by FlyBase were retrieved and tokenized by RASP (Briscoe et al., 2006).
P06-2006 P06-4020
According to (Briscoe and Carroll, 2006), the parser achieves fairly good accuracy around 80%.
P06-2006 P06-4020
Finally, of the nine well-segmented utterances, two partial parses potentially catch deeper speaker errors that cannot be caught by (Johnson and Charniak, 2004).
P04-1005
The evaluation in this paper was based solely on CCGbank, but we have shown in Clark and Curran (2007) that the CCG parser gives state-of-the-art performance, outperforming the RASP parser (Briscoe et al., 2006) by over 5% on DepBank.
P06-2006 P06-4020
This is essentially similar to the approach in (Osborne, 2000), where there is an infeasibly large number of training events, only part of which is used in the estimation step.
C00-1085
One popular approach is to use a log-linear parsing model and maximise the conditional likelihood function (Johnson et al., 1999; Riezler et al., 2002; Clark and Curran, 2004b; Malouf and van Noord, 2004; Miyao and Tsujii, 2005).
P02-1035 P04-1005 P99-1069
In this paper, we adopt the same definition for partial parse as in (Kasper et al., 1999) and define the task of partial parse selection.
P99-1052
For example, the current reported coverage figures on spoken dialogue corpora are close to 90% (Oepen et al., 2002).
C02-2025
To compare the RMRS from the RASP and the partial parse selection models, we used the similarity measurement proposed in (Dridan and Bond, 2006).
W06-1106
In three cases, simple repeated phrases caught by (Johnson and Charniak, 2004) were also caught in some form by the partial parse partitioning.
P04-1005
