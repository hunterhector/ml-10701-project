Accordingly, it is not possible to draw a straigthforward quantitative 16 F R P (Haghighi et al., 2005) 83.4 83.1 83.7 (Pradhan et al., 2005) 83.3 83.0 83.5 (Punyakanok et al., 2005) 83.1 82.8 83.3 (Marquez et al., 2005) 83.1 82.8 83.3 (Surdeanu and Turmo, 2005) 82.7 82.5 83.0 PropBank SSN 81.6 81.3 81.9 Table 2: Percentage F-measure (F), recall (R), and precision (P) of our Propbank SSN parser and stateof-the-art semantic role labelling systems on the PropBank parsing task (1267 sentences from PropBank validating data sets; Propbank data sets are available at http://www.lsi.upc.edu/ srlconll/st05/st05.html).
W05-0623 W05-0634 W05-0635
We also thank James Henderson and Ivan Titov for allowing us to use and modify their SSN software, Xavier Carreras for providing the CoNLL-2005 shared task data sets and the anonymous reviewers for their valuable comments.
W05-0620
According to the original SSN model in (Henderson, 2003), only the information carried over by the leftmost child and the most recent child of a constituent directly flows to that constituent.
N03-1014
In particular, recent models of semantic role labelling separate input indicators of the correlation between the structural position in the tree and the semantic label, such as path, from those indicators that encode constraints on the sequence, such as the previously assigned role (Kwon et al., 2004).
W04-0832
Extending a technique presented in (Klein and Manning, 2003) and adopted in (Merlo and Musillo, 2005; Musillo and Merlo, 2005) for function labels, we split some part-of-speech tags into tags marked with semantic role labels.
H05-1078 P03-1054 W05-1509
The first five lines of Table 2 report such measures for the five best semantic role labelling systems (Haghighi et al., 2005; Pradhan et al., 2005; Punyakanok et al., 2005; Marquez et al., 2005; Surdeanu and Turmo, 2005) according to (CoNLL, 2005).
W05-0623 W05-0634 W05-0635
While some of these models are based on full parse trees (Gildea and Jurafsky, 2002; Gildea and Palmer, 2002), other methods have been proposed that eschew the need for a full 1There are thirteen semantic role labels for modifiers.
J02-3001 P02-1031
Our results also confirm the findings in (Palmer et al., 2005).
J05-1004
Basic Parsing Architecture To achieve the complex task of assigning semantic role labels while parsing, we use a family of statistical parsers, the Simple Synchrony Network (SSN) parsers (Henderson, 2003), which do not make any explicit independence assumptions, and are therefore likely to adapt without much modification to the current problem.
N03-1014
They use a neural network architecture, called Simple Synchrony Network (Henderson and Lane, 1998), to induce a finite history representation of an unbounded sequence of moves.
P98-1087
The third line of Table 1 gives the performance on the simpler PTB parsing task of the original SSN parser (Henderson, 2003), that was trained on the PTB data sets contrary to our SSN model trained on the PropBank data sets.
N03-1014
As with many other statistical parsers (Collins, 1999; Charniak, 2000), SSN parsers use a history-based model of parsing.
A00-2018
PropBank encodes propositional information by adding a layer of argument structure annotation to the syntactic structures of the Penn Treebank (Marcus et al., 1993).
J93-2004
These systems use (Charniak, 2000)’s parse trees both for training and testing as well as various other information sources including sets of n-best parse trees (Punyakanok et al., 2005; Haghighi et al., 2005) or chunks (Marquez et al., 2005; Pradhan et al., 2005) and named entities (Surdeanu and Turmo, 2005).
A00-2018 W05-0623 W05-0634 W05-0635
The partial trees output by these systems were merged with the parse trees returned by (Charniak, 2000)’s parser.
A00-2018
However, state-ofthe-art semantic role labelling systems (CoNLL, 2005) use parse trees output by state-of-the-art parsers (Collins, 1999; Charniak, 2000), both for training and testing, and return partial trees annotated with semantic role labels.
A00-2018
See (Palmer et al., 2005) for a detailed discussion of PropBank semantic roles labels.
J05-1004
For more information on this technique to capture domains induced by the c-command relation, see (Musillo and Merlo, 2005).
H05-1078 W05-1509
(Yi and Palmer, 2005) share the motivation of our work.
J05-1004 W05-0639
(Henderson, 2003) exploits this bias by directly inputting information which is considered relevant at a given step to the history representation of the constituent on the top of the stack before that step.
N03-1014
We present work to test the hypothesis that a current statistical parser (Henderson, 2003) can output richer information robustly, that is without any significant degradation of the parser’s accuracy on the original parsing task, by explicitly modelling semantic role labels as the interface between syntax and semantics.
N03-1014
The growing interest in learning deeper information is to a large extent supported and due to the recent development of semantically annotated databases such as FrameNet (Baker et al., 1998) or the Proposition Bank (Palmer et al., 2005), that can be used as training resources for a number of supervised learning paradigms.
J05-1004 P98-1013
JamesHendersonandPeterLane. 1998.
P98-1087
Training, validating and testing data sets consist of the PTB data annotated with PropBank semantic roles labels, as provided in the CoNLL-2005 shared task (Carreras and Marquez, 2005).
W05-0620
Recent successes in statistical syntactic parsing based on supervised learning techniques trained on a large corpus of syntactic trees (Collins, 1999; Charniak, 2000; Henderson, 2003) have brought forth the hope that the same approaches could be applied to the more ambitious goal of recovering the propositional content and the frame semantics of a sentence.
A00-2018 N03-1014
To reduce variability, we add some of the tag-verb pairs licensing these argumental labels to the vocabu15 F R P PropBank training and PropBank parsing task 82.3 82.1 82.4 PropBank training and PTB parsing task 88.8 88.6 88.9 PTB training and PTB parsing task (Henderson, 2003) 88.6 88.3 88.9 Table 1: Percentage F-measure (F), recall (R), and precision (P) of our SSN parser on two different tasks and the original SSN parser.
N03-1014
Semantic Role Labels Previous work on learning function labels during parsing (Merlo and Musillo, 2005; Musillo and Merlo, 2005) assumed that function labels represent the interface between lexical semantics and syntax.
H05-1078 W05-1509
