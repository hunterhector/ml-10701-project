However, the accuracy of those parsers was still below PCFG parsers (Collins, 1999; Charniak, 2000) in terms of the PARSEVAL score, i.e., labeled bracketing accuracy of CFG-style parse trees.
A00-2018
Interestingly, several studies suggested that the identification of PropBank annotations would require linguistically-motivated features that can be obtained by deep linguistic analysis (Gildea and Hockenmaier, 2003; Chen and Rambow, 2003).
P03-1046 W03-1006 W03-1008
Table 2 shows specifications of the grammar and the disambiguation model, where the size of the training data shows the file size of a compressed training data and the estimation time represents a user time required for estimating a52 a14a16a12a18a17a23 a8a10a13a26a20 . We prepared two grammars for the evaluation: a1 penn was extracted from the Penn Treebank with the original algorithm (Miyao et al., 2004), and a1 prop was extracted using the PropBank annotations for argument/modifier distinction by a method similar to Chen and Rambow (2003).
W03-1006
Since one advantage of deep parsers is that they can output a sort of semantic representation, e.g. predicateargument structures, several studies have reported the accuracy of predicate-argument relations (Hockenmaier and Steedman, 2002b; Clark et al., 2002; Hockenmaier, 2003; Miyao et al., 2003).
P02-1042 P02-1043 P03-1046 W03-1013
Recent progress in deep linguistic analysis has mainly depended on the acquisition of lexicalized grammars from annotated corpora (Xia, 1999; Chen and Vijay-Shanker, 2000; Chiang, 2000; Hockenmaier and Steedman, 2002a; Cahill et al., 2002; Frank et al., 2003; Miyao et al., 2004).
P00-1058 P02-1043 P03-1046
They employed a CCG (Steedman, 2000) or LTAG (Schabes et al., 1988) parser to acquire syntactic/semantic structures, which would be passed to statistical classifier as features.
C88-2121
Although the results cannot directly be compared with another work using LTAG (Chen and Rambow, 2003) because their target annotations were limited to those localized in an elementary tree, considering that their target annotations were 87% of corearguments, our results are competitive with their results (82.57/71.41).
W03-1006
Several studies proposed the use of deep linguistic features, such as predicate-argument relations output by a CCG parser (Gildea and Hockenmaier, 2003) and derivation trees output by an LTAG parser (Chen and Rambow, 2003).
P03-1046 W03-1006 W03-1008
linguistic analysis and semantically annotated corpora Riezler et al.(2002) reported the successful application of a hand-crafted LFG (Bresnan, 1982) grammar to the parsing of the Penn Treebank (Marcus et al., 1994) by exploiting various techniques for robust parsing.
H94-1020 P02-1035
S the window He NP NP VP ARG0-broke ARG1-broke broke REL-broke S the window NP VP ARG1-broke broke REL-broke Figure 4: Annotation of an ergative verb in the PropBank S the window NP VP ARG1-broke broke into PP NP a million pieces ARG3-broke REL-broke Figure 5: Annotation of another usage of “broke” the other features are 0: a67 head comp a68a70a69a71a68 transa68 VBa68 VPa68 nouna68 NNSa68 NPa72 a67 head comp a68 a68 transa68 VBa68 VPa68 nouna68 NNSa68 NPa72 a67 head comp a68a73a69a42a68 a68 VBa68 VPa68 a68 NNSa68 NPa72 a67 head comp a68 a68 a68 VBa68 VPa68 a68 NNSa68 NPa72 a67 head comp a68a73a69a42a68 transa68 VBa68 a68 nouna68 NNSa68 a72 a67 head comp a68 a68 transa68 VBa68 a68 nouna68 NNSa68 a72 a67 head comp a68a70a69a71a68 a68 VBa68 a68 a68 NNSa68 a72 a67 head comp a68 a68 a68 VBa68 a68 a68 NNSa68 a72 Given the HPSG treebank as training data, the model parameters a43 a41 are efficiently estimated using a dynamic programming algorithm for maximum entropy estimation (Miyao and Tsujii, 2002; Geman and Johnson, 2002).
P02-1036
As shown in Table 4, despite not employing the PropBank for the machine learning of a disambiguation model, the labeled precision/recall attained by a1 prop were superior to an existing study using the Collins parser (75.9/69.6) (Gildea and Hockenmaier, 2003), and the results were approaching existing studies on the same task using a CCG parser (76.1/73.5) (Gildea and Hockenmaier, 2003).
P03-1046 W03-1008
Features of a statistical model were defined as a pattern on a partial structure of the syntactic tree output by an automatic parser (Gildea and Palmer, 2002; Gildea and Jurafsky, 2002).
J02-3001 P02-1031
Another possibility is to directly extract PropBank-style semantic representations by reforming the grammar extraction algorithm (Chen and Rambow, 2003), and to estimate a disambiguation model using the PropBank.
W03-1006
PropBank (Kingsbury and Palmer, 2002) and FrameNet (Baker et al., 1998) are large English corpora annotated with the semantic relations of words in a sentence.
P98-1013
Following recent research about disambiguation models on linguistic grammars (Abney, 1997; Johnson et al., 1999; Riezler et al., 2002; Clark and Curran, 2003; Miyao et al., 2003; Malouf and van Noord, 2004), we apply a log-linear model or maximum entropy model (Berger et al., 1996) on HPSG derivations.
J96-1002 J97-4005 P02-1035 P99-1069 W03-1013
To date, accurate parsers have been developed for LTAG (Chiang, 2000), CCG (Hockenmaier and Steedman, 2002b; Clark et al., 2002; Hockenmaier, 2003), and LFG (Cahill et al., 2002; Burke et al., 2004).
P00-1058 P02-1042 P02-1043 P03-1046 W03-1013
Several parsers have been implemented in various grammar formalisms and empirical evaluation has been reported: LFG (Riezler et al., 2002; Cahill et al., 2002; Burke et al., 2004), LTAG (Chiang, 2000), CCG (Hockenmaier and Steedman, 2002b; Clark et al., 2002; Hockenmaier, 2003), and HPSG (Miyao et al., 2003; Malouf and van Noord, 2004).
P00-1058 P02-1035 P02-1042 P02-1043 P03-1046 W03-1013
However, their accuracy was still below the state-of-theart PCFG parsers (Collins, 1999; Charniak, 2000) in terms of the PARSEVAL score.
A00-2018
