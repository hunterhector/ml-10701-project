Our results confirm the findings in (Palmer et al., 2005).
J05-1004
The baseline called H03 refers to our runs of the parser described in (Henderson, 2003), which is not trained on input annotated with function labels.
N03-1014
Basic Architecture To achieve the complex task of assigning function labels while parsing, we use a family of statistical parsers, the Simple Synchrony Network (SSN) parsers (Henderson, 2003), which do not make any explicit independence assumptions, and are therefore likely to adapt without much modification to the current problem.
N03-1014
In particular, recent models of semantic role labelling separate input indicators of the correlation between the structural position in the tree and the semantic label, such as path, from those indicators that encode constraints on the sequence, such as the previously assigned role (Kwon et al., 2004).
W04-0832
(For more detail on this lexical semantics projection, see (Merlo and Musillo, 2005).) We report the effects of these augmentations on parsing results in the experiments described below.
H05-1078
duce trees annotated with bare phrase structure labels (Collins, 1999; Charniak, 2000).
A00-2018
Our results also provide some new insights into the discussion about the necessity of parsing for function or semantic role labelling (Gildea and Palmer, 2002; Punyakanok et al., 84 2005), showing that parsing is beneficial.
J02-3001 J05-1004 P02-1031
According to the original SSN model in (Henderson, 2003), only the information carried over by the leftmost child and the most recent child of a constituent di87 rectly flows to that constituent.
N03-1014
As shown in (Merlo, 2003; Merlo and Esteve-Ferrer, 2004) this difference does not correspond to the difference between arguments and adjuncts.
E03-1079
Individual performance on syntactic and semantic function labelling compare favourably to previous attempts (Blaheta, 2004; Blaheta and Charniak, 2000).
A00-2018 A00-2031
Conversely, researchers interested in producing richer semantic outputs have concentrated on two-stage systems, where the semantic labelling task is performed on the output of a parser, in a pipeline architecture divided in several stages (Gildea and Jurafsky, 2002; Nielsen and Pradhan, 2004; Xue and Palmer, 2004).
J02-3001 P02-1031 W04-3211 W04-3212
Following (Blaheta and Charniak, 2000), we concentrate on syntactic and semantic function labels.
A00-2018 A00-2031
As with many other statistical parsers (Collins, 1999; Charniak, 2000), SSN parsers use a history-based model of parsing.
A00-2018
(Yi and Palmer, 2005) share the motivation of our work, although they apply it to a different task.
J05-1004 W05-0639
The models, as well as the parser described in (Henderson, 2003), are run only once.
N03-1014
Following (Blaheta and Charniak, 2000), incorrectly parsed constituents will be ignored (roughly 11% of the total) in the evaluation of the precision and recall of the function labels, but not in the evaluation of the parser.
A00-2018 A00-2031
Both the model augmented only with lexical information (through tag splitting) and the one augmented both with finer-grained tags and representations of syntactic locality perform better than our comparison baseline H03, but only the latter is significantly better (p < .01, using (Yeh, 2000)’s randomised test).
C00-2137
To some extent, function labels overlap with semantic role labels as defined in PropBank (Palmer et al., 2005).
J05-1004
Yih. 2005.
W05-0639
While some of these models are based on full parse trees (Gildea and Jurafsky, 2002; Blaheta, 2004), other methods have been proposed that eschew the need for a full parse (CoNLL, 2004; CoNLL, 2005).
J02-3001 P02-1031
This explains the little difference in performance between our results for H03 in our table of results and those cited in (Henderson, 2003), where the best of three runs on the validation set is chosen.
N03-1014
(Henderson, 2003) exploits this bias by directly inputting information which is considered relevant at a given step to the history representation of the constituent on the top of the stack before that step.
N03-1014
Previous work that uses, like us, a single model for both types of labels reaches an F measure of 95.7% for syntactic labels and 79.0% for semantic labels (Blaheta and Charniak, 2000).
A00-2018 A00-2031
Our results also confirm the importance of lexical information, the lesson drawn from (Thompson et al., 2004), who find that correctly modelling sequence information is not sufficient.
W04-0857
(Klein and Manning, 2003), for instance report a reduction in parsing accuracy of an unlexicalised PCFG from 77.8% to 72.9% if using function labels in training.
P03-1054
On the one hand, extending a technique presented in (Klein and Manning, 2003), we split some part-of-speech tags into tags marked with semantic function labels.
P03-1054
We present work to test the hypothesis that a current statistical parser (Henderson, 2003) can output richer information robustly, that is without any degradation of the parser’s accuracy on the original parsing task, by explicitly modelling function labels as the locus where the lexical semantics of the elements in the sentence and syntactic locality domains interact.
N03-1014
SSN parsers, on the other hand, do not state any explicit independence assumptions: they use a neural network architecture, called Simple Synchrony Network (Henderson and Lane, 1998), to induce a finite history representation of an unbounded sequence of moves.
P98-1087
State-of-the-art statistical parsers trained on the Penn Treebank (PTB) (Marcus et al., 1993) proS a8a8 a8a8a8 a72a72 a72a72a72 NP-SBJ a16a16a16 a80a80a80the authority VP a16a16a16 a16a16a16a16 a0 a0a0 a64 a64a64 a80a80a80 a80a80a80a80 VBD dropped PP-TMP a8a8 a72a72IN at NP NN midnight NP-TMP NNP Tuesday PP-DIR a8a8 a72a72TO to NP QP a16a16a16 a80a80a80$ 2.80 trillion Figure 1: A sample syntactic structure with function labels.
J93-2004
Conversely, output annotated with more informative labels, such as function or semantic labels, underlies all domain-independent question answering (Jijkoun et al., 2004) or shallow semantic interpretation systems (Collins and Miller, 1998; Ge and Mooney, 2005).
C04-1188 W05-0602 W98-1105
Unlike phrase structure labels, function labels are contextdependent and encode a shallow level of phrasal and lexical semantics, as observed first in (Blaheta and Charniak, 2000).
A00-2018 A00-2031
In recent years, corpora annotated with semantic and function labels have seen the light (Palmer et al., 2005; Baker et al., 1998) and semantic role labelling has taken centre-stage as a challenging new task.
J05-1004 P98-1013
Specifically, the parser outputs additional labels indicating the function of a constituent in the tree, such as NP-SBJ or PP-TMP in the tree 1(Blaheta and Charniak, 2000) talk of function tags.We will instead use the term function label, to indicate function identifiers, as they can decorate any node in the tree.
A00-2018 A00-2031
