The two existing systems that use function labels sucessfully, either inherit Collins’ modelling of the notion of complement (Gabbard, Kulick and Marcus, 2006) or model function labels directly (Musillo and Merlo, 2005).
H05-1078 N06-1024 W05-1509
Merlo. 2005.
H05-1078
Recent successes in statistical syntactic parsing based on supervised techniques trained on a large corpus of syntactic trees (Collins, 1999; Charniak, 2000; Henderson, 2003) have brought the hope that the same approach could be applied to the more ambitious goal of recovering the propositional content and the frame semantics of a sentence.
A00-2018 N03-1014
Acknowledgements We thank the Swiss NSF for supporting this research under grant number 101411-105286/1, James Henderson and Ivan Titov for sharing their SSN software, and Xavier Carreras for providing the CoNLL-2005 data.
W05-0620
These systems all use (Charniak, 2000)’s parse trees both for training and testing, as well as various other information sources including sets of n-best parse trees, chunks, or named entities.
A00-2018
Thus, the partial trees output by these systems were merged with the parse trees returned by Charniak’s parser (second line, PropBank column).3 These results jointly confirm our initial hypothe1(Shen and Joshi, 2005) use PropBank labels to extract LTAG spinal trees to train an incremental LTAG parser, but they do not parse PropBank.
H05-1102
Methodologically, these initial results on a joint solution to parsing and semantic role labelling provide the first direct test of whether parsing is necessary for semantic role labelling (Gildea and Palmer, 2002; Punyakanok et al., 2005a).
J02-3001 J05-1004 P02-1031
For more information on this technique to capture structural domains, see (Musillo and Merlo, 2005) where the technique was applied to function parsing.
H05-1078 W05-1509
Musillo. 2005.
W05-1509
Testing data are section 23 from the CoNLL-2005 shared task (Carreras and Marquez, 2005).
W05-0620
Comparing semantic role labelling based on chunked input to the better semantic role labels retrieved based on parsed trees, (Gildea and Palmer, 2002) conclude that parsing is necessary.
J02-3001 P02-1031
Consider, for example, a sentence such as The authority dropped at midnight Tuesday to $ 2.80 trillion (taken from section 00 of PropBank (Palmer et al., 2005)).
J05-1004
We present work to test the hypothesis that a current statistical parser (Henderson, 2003) can output rich information comprising both a parse tree and semantic role labels robustly, that is without any significant degradation of the parser’s accuracy on the original parsing task.
N03-1014
The third line, PropBank column of Table 1 reports such measures summarised for the five best semantic role labelling systems (Punyakanok et al., 2005b; Haghighi et al., 2005; Pradhan et al., 2005; Marquez et al., 2005; Surdeanu and Turmo, 2005) in the CoNLL 2005 shared task.
W05-0623 W05-0634 W05-0635
(Gildea and Jurafsky, 2002) define this shallow semantic task as a classification problem where the semantic role to be assigned to each constituent is inferred on the basis of probability distributions of syntactic features extracted from parse trees.
J02-3001 P02-1031
PropBank encodes propositional information by adding a layer of argument structure annotation to the syntactic structures of the Penn Treebank (Marcus et al., 1993).
J93-2004
However, state-of-theart semantic role labelling systems (CoNLL, 2005) use parse trees output by state-of-the-art parsers (Collins, 1999; Charniak, 2000), both for training and testing, and return partial trees annotated with semantic role labels.
A00-2018
Extending a technique presented in (Klein and Manning, 2003) and adopted in (Merlo and Musillo, 2005) for function labels with stateof-the-art results, we split some part-of-speech tags into tags marked with AM-X semantic role labels.
H05-1078 P03-1054 W05-1509
To achieve the complex task of assigning semantic role labels while parsing, we use a family of state-of-the-art history-based statistical parsers, the Simple Synchrony Network (SSN) parsers (Henderson, 2003), which use a form of left-corner parse strategy to map parse trees to sequences of derivation steps.
N03-1014
(Klein and Manning, 2003) report a reduction in parsing accuracy of an unlexicalised PCFG from 77.8% to 72.9% in using Penn Treebank function labels in training.
P03-1054
