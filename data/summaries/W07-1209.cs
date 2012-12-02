A. Ratnaparkhi, 1996.
W96-0213
work In their psychological study, Clark and Krych (2004) showed that speakers alter their utterances midcourse while monitoring not only the listener?s vocal signals, but also the listener?s gestural signals as well as through other mutually visible events.
C04-1041
For automatic parsing, we made use of the wellknownCharniakparser(Charniak,2000).
A00-2018
One solution to this is to use a state-of-the-art probabilistic parser that accepts untokenized input (such as Charniak and Johnson, 2005) and retrain it as described in Section 4.
P05-1022
In Clark and Curran (2004b) we use a cluster of 45 machines, together with a parallel implementation of BFGS, to solve this problem, but need up to 20 GB of RAM.
C04-1041
A full system using the Lexical-Functional Grammar (LFG) parsing system XLE and the grammars from the Parallel Grammar development project (ParGram; (Butt et al., 2002)) has been implemented, and we present preliminary results on English-toGerman translation with a tree-labeling system trained on a small subsection of the Europarl corpus.
W02-1503
For the log-linear parsing model in Clark and Curran (2004b), the inside-outside algorithm is used to calculate feature expectations, which are then used by the BFGS algorithm to optimise the likelihood function.
C04-1041
Supertags were introduced by Bangalore (1999) as a way of increasing parsing efficiency by reducing the number of structures assigned to each word.
J99-2004
Constituency trees are provided by the Charniak-Johnson?s Max-Ent reranking parser (Charniak and Johnson, 2005).
P05-1022
We use the same feature representation (x,y) as in Clark and Curran (2004b), to allow comparison with the log-linear model.
C04-1041
2.2 Log-linear models for disambiguation Since Johnson et al.(1999), log-linear models of the following form have become standard as disambiguation devices for precision grammars: P(x|y) = e summationtextm j=1 jfj(x,y) summationtext xprime?X(y) e summationtextm j=1 jfj(xprime,y) They are used for parse selection in the English Resource Grammar (Toutanova et al., 2002), the English ParGram LFG (Riezler et al., 2002), the English Enju HPSG (Miyao and Tsujii, 2002), the HPSG-inspired Alpino parser for Dutch (Malouf and van Noord, 2004; van Noord, 2006) and the English CCG from Edinburgh (Clark and Curran, 2004).
C04-1041 P02-1035
We use a lexicalized phrase-structure parser, the CCG parser of Clark and Curran (2004b), together with a DP-based decoder.
C04-1041
used properties for disambiguation The first set of properties with which we conducted experiments was built on the model of the property set used for the disambiguation of English ParGram LFG parses (Riezler et al., 2002; Riezler and Vasserman, 2004).
P02-1035
For the experiments reported in this paper, we parsed the source language side of a parallel corpus (a small subsection of the English-German Europarl corpus; (Koehn, 2002)) with the XLE system, using 36 the ParGram LFG grammar and applying probabilistic disambiguation (Riezler et al., 2002) to obtain a single analysis (i.e., a c-structure [phrase structure tree] and an f-structure [an associated attributevalue matrix with morphosyntactic feature information and a shallow semantic interpretation]) for each sentence.
P02-1035
The CCG supertagger (Clark, 2002; Clark and Curran, 2004) was provided with the C&C Language Processing Tools3.
C04-1041
Finally, to assess the practical value of the conversion method and of the BioInfer syntactic annotation in the Stanford scheme, we compare the Charniak-Lease constituency parser2 (Charniak and Lease, 2005) and BioLG,3 an adaptation of LG (Pyysalo et al., 2006), on the newly unified dataset combining the constituency-annotated GENIA Treebank with the dependency-annotated BioInfer corpus.
P05-1022
Kaplan et al.(2004) compared time and accuracy of a version of the Collins parser tuned to maximize speed and accuracy to an earlier version of the XLE parser.
N04-1013
A feature forest is essentially a packed chart with only the feature information retained (see Miyao and Tsujii (2002) and Clark and Curran (2004b) for the details).
C04-1041
Previous discriminative models for CCG (Clark and Curran, 2004b) required cluster computing resources to train.
C04-1041
(Charniak, 2000; Briscoe et al., 2006), have wide coverage and yield grammatical representations capable of supporting various applications (e.g.
A00-2018
In Clark and Curran (2004b) we use a cluster of 45 machines, together with a parallel implementation of the BFGS training algorithm, to solve this problem.
C04-1041
Supertagging has been especially successful for CCG: Clark and Curran (2004a) demonstrates the considerable increases in speed that can be obtained through use of a supertagger.
C04-1041
Eugene Charniak. 2000. A maximum-entropy-inspired parser. In Proceedings of NAACL, pages 132139.
A00-2018
Though taggers based on dependency networks (Toutanova et al., 2003), SVM (Gimenez and M`arquez, 2003), MaxEnt (Ratnaparkhi, 1996), CRF (Smith et al., 2005), and other methods may reach slightly better results, their train/test cycle is orders of magnitude longer.
W96-0213
Hence 10 Bangalore and Joshi (1999) refer to supertagging as almost parsing.
J99-2004
Ratnaparkhi, 1996).
W96-0213
Our error reduction of 51.0% also compares favorably to the 36% error reduction on English LFG parses reported in Riezler et al.(2002). However, it is considerably lower than the error reduction of 78% reported for the Dutch Alpino parser (Malouf and van Noord, 2004), but this may be due to the fact that our lower bound is calculated on the basis of analyses that have already passed a prefilter and is thus relatively high.
P02-1035
A recent development in data-driven parsing is the use of discriminative training methods (Riezler et al., 2002; Taskar et al., 2004; Collins and Roark, 2004; Turian and Melamed, 2006).
P02-1035
Generally, the syntactic structure of a sentence is represented as a tree, and parsing is carried out by maximizing the likelihood of the tree (Charniak, 2000; Uchimoto et al., 1999).
A00-2018
In contrast, methods based on Maximum Entropy (Ratnaparkhi, 1996), Conditional Random Field (Shrivastav, 2006) etc.
W96-0213
In recent years, many accurate phrase-structure parsers have been developed (e.g., (Collins, 1999; Charniak, 2000)).
A00-2018
Clark and Curran (2004a) also shows how the supertagger can reduce the size of the packed charts to allow discriminative log-linear training.
C04-1041
Ratnaparkhi. 1996.
W96-0213 W96-0213
So, we pre-tagged the input to the Bikel parser using the MXPOST tagger (Ratnaparkhi, 1996).
W96-0213
The experiments reported in this paper use the English LFG grammar constructed as part of the ParGram project (Butt et al., 2002).
W02-1503
The key idea is to exploit the properties of lexicalized grammars by using a finite-state supertagger prior to parsing (Bangalore and Joshi, 1999; Clark and Curran, 2004a).
C04-1041 J99-2004
This was done to some extent in Riezler et al.(2002) to automatically generate training data for the log-linear disambiguation component of XLE.
P02-1035
The second parser is that described in Charniak and Johnson (2005).
P05-1022
The part-of-speech tagging uses the Curran and Clark POS tagger (Curran and Clark, 2003) trained on MedPost data (Smith et al., 2004), whilst the other preprocessing stages are all rule based.
C04-1041
Bangalore and Joshi (1999), Clark and Curran (2004) and Matsuzaki et al.(2007) show that by using a super tagger before (CCG and HPSG) parsing, the space required for discriminitive training is drastically reduced.
C04-1041 J99-2004
Supertagging was first defined for LTAG (Bangalore and Joshi, 1999), and was designed to increase parsing speed for lexicalized grammars by allowing a finite-state tagger to do some of the parsing work.
J99-2004
Eugene Charniak and Mark Johnson. 2005. Coarse-to-fine n-best parsing and maxent discriminative reranking. In ACL 43, pages 173180.
P05-1022
Supertagging is not widely used within the LFG framework, although there has been some work on using hypertags (Kinyon, 2000).
C00-1065
XLE selects the most probable analysis from the potentially large candidate set by means of a stochastic disambiguation component based on a log-linear probability model (Riezler et al., 2002) that works on the packed representations.
P02-1035
For sentences out of coverage, it employs the robustness techniques (fragment parsing, ?skimming?? implemented in XLE and described in Riezler et al.(2002), so that 100% of our corpus sentences receive at least some sort of analysis.
P02-1035
Charniak. 2005.
P05-1022
In taskmanipulation situations where the listener manipulates objects by following the speaker?s instructions, correct task manipulation by the listener serves as more direct evidence of understanding (Brennan 2000, Clark and Krych 2004), and affects the speaker?s dialogue control strategies.
C04-1041
In previous research on natural language processing, many methodologies for extracting various relations from corpora have been developed, such as the ?is-a??relation (Hearst 1992), ?part-of??relation (Berland and Charniak 1999), causal relation (Girju 2003), and entailment relation (Geffet and Dagan 2005).
P05-1022
A. Ratnaparkhi. 1996. A Maximum Entropy Model for Part-Of-Speech Tagging. In Proceedings of EMNLP, pages 133142.
W96-0213
That work relied on a phrase-structure statistical parser (Charniak, 2000) trained on the Penn Treebank, and the output of that parser had to be converted into CHILDES grammatical relations.
A00-2018
Used The experiments reported in this paper were carried out with the News Commentary (NC) corpus as made available for the SMT workshop4 of the ACL 2007 conference.5 The Czech part of the corpus was tagged and lemmatized using the tool by Haji?c and Hladka (1998), the English part was tagged MXPOST (Ratnaparkhi, 1996) and lemmatized using the Morpha tool (Minnen et al., 2001).
W96-0213
For comparison, Sagae et al.(2005) report 86.9% LAS on about 2,000 words of Eve data, using the Charniak (2000) parser with a separate dependency-labeling step.
A00-2018
E. Charniak, D. Blaheta, N. Ge, K. Hall, and M. Johnson. 2000. BLLIP 198789 WSJ Corpus Release 1, LD No. LDC2000T43. Linguistic Data Consortium.
A00-2018
Following Clark and Curran (2004b), accuracy is measured using F-score over the goldstandard predicate-argument dependencies in CCGbank.
C04-1041
In this paper, we use reranking architecture, which was successfully applied to the task of natural language parsing (Collins, 2000; Charniak and 209 Johnson, 2005), to address the problem.
P05-1022
Although the CHILDES annotation scheme proposed by Sagae et al.(2004) has been used in practice for automatic parsing of child language transcripts (Sagae et al., 2004; Sagae et al., 2005), such work relied mainly on a statistical parser (Charniak, 2000) trained on the Wall Street Journal portion of the Penn Treebank, since a large enough corpus of annotated CHILDES data was not available to train a domain-specific parser.
A00-2018
It uses a log-linear model to define a distribution over the lexical category set for each word and the previous two categories (Ratnaparkhi, 1996) and the forward backward algorithm efficiently sums over all histories to give a distibution for each word.
W96-0213
Clark and Curran (2004b) describe how a set of CCG derivations can be represented as a feature forest.
C04-1041
We applied the same normal-form restrictions used in Clark and Curran (2004b): categories can 12 only combine if they have been seen to combine in Sections 2-21 of CCGbank, and only if they do not violate the Eisner (1996a) normal-form constraints.
C04-1041
It is interesting to note that the inclusion of prefix and suffix for all words gives better result instead of using only for rare words as is described in Ratnaparkhi (1996).
W96-0213
parsers and corpora The Charniak-Lease parser is a statistical constituency parser developed by Charniak and Lease (2005).
P05-1022
One popular approach is to use a log-linear parsing model and maximise the conditional likelihood function (Johnson et al., 1999; Riezler et al., 2002; Clark and Curran, 2004b; Malouf and van Noord, 2004; Miyao and Tsujii, 2005).
C04-1041 P02-1035
In Clark and Curran (2004b) we use cluster computing resources to solve this problem.
C04-1041
This parser uses a discriminative reranker that selects the most probable parse from the 50-best parses returned by a generative parser based on Charniak (2000).
A00-2018
Ninomiya et al.(2006) propose a method for faster HPSG parsing while maintaining accuracy by only using the probabilities of lexical entry selections (i.e.
W06-1619
(unlab.) Total XLE Parses (/140) 119 0 86 135 139 139 F-Score of Subset 81.57 0 86.57 78.72 53.96 75.64 Overall F-Score 72.01 0 58.04 76.13 53.48 *74.98 Table 2: Bikel (2002) and Charniak and Johnson (2005) out-of-the-box baseline results the PARC 700 Dependency Bank.
P05-1022
CCG Parser Clark and Curran (2004b) describes the CCG parser.
C04-1041
The data is divided into two sets, a 140-sentence development set and a test set of 560 sentences (Kaplan et al., 2004).
N04-1013
BLLIP corpus (Charniak et al., 2000), which con-
A00-2018
