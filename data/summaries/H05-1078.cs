Briefly, our method consists in augmenting a state-of-the-art statistical parser (Henderson, 2003), whose architecture and properties make it particularly adaptive to new tasks.
N03-1014
swering (Jijkoun et al., 2004) or shallow semantic interpretation systems (Collins and Miller, 1998; Ge and Mooney, 2005).
C04-1188 P04-1040 W05-0602 W98-1105
Extending (Klein and Manning, 2003)’s technique to function labelling, we split some part-of-speech tags into tags marked with semantic function labels.
P03-1054
We use a family of statistical parsers, the Simple Synchrony Network (SSN) parsers (Henderson, 2003), which crucially do not make any explicit independence assumptions, and learn to smooth across rare feature combinations.
N03-1014
SSN parsers, on the other hand, do not state any explicit independence assumptions: they induce a finite history representation of an unbounded sequence of moves, so that the representation of a move i−1 is included in the inputs to the represention of the next move i, as explained in more detail in (Henderson, 2003).
N03-1014
(Klein and Manning, 2003) and, to a much more limited extent, (Collins, 1999) are the only researchers we are aware of who used function labels for parsing.
P03-1054
As with many other statistical parsers (Collins, 1999; Charniak, 2000), the model of parsing is history-based.
A00-2018
In work that predates the availability of Framenet and Propbank, (Blaheta and Charniak, 2000) define the task of function labelling for the first time and highlight its relevance for NLP.
A00-2018 A00-2031
also recovers function labels (Jijkoun and de Rijke, 2004) and work that trains a parser on Propbank labels as the first stage of a semantic role labelling pipeline (Yi and Palmer, 2005).
C04-1188 J05-1004 P04-1040 W05-0639
(Jijkoun and de Rijke, 2004) approach the problem of enriching the output of a parser in several steps.
C04-1188 P04-1040
Like previous work (Blaheta and Charniak, 2000), we complete the sets of syntactic and semantic labels by labelling constituents that do not bear any function label with a NULL label.3 2.3 Evaluation To evaluate the performance of our function parsing experiments, we will use several measures.
A00-2018 A00-2031
(Yi and Palmer, 2005) share the motivation of our work, although they apply it to a different task.
J05-1004 W05-0639
With recent advances in speech recognition, parsing, and information extraction, some domain-specific interactive systems are now of practical use for tasks such as question-answering, flight booking, or restaurant reservation (Stallard, 2000).
A00-1010
Since the function parsing problem is more difficult than simple parsing, it is then interesting to observe that performance of the augmented parser increases significantly (FLABEL column) (p < .001) without losing accuracy on the parsing task 6This explains the little difference in performance between our results for H03 and those cited in (Henderson, 2003), where the best of three runs on the validation set is chosen.
N03-1014
Following (Blaheta and Charniak, 2000), incorrectly parsed constituents will be ignored (roughly 11% of the total) in the evaluation of the precision and recall of the function labels, but not in the evaluation of the parser.
A00-2018 A00-2031
Conversely, researchers interested in producing richer semantic outputs have concentrated on two-stage systems, where the semantic labelling task is performed on the output of a parser, in a pipeline architecture divided in several stages (Gildea and Jurafsky, 2002).
J02-3001
Our approach maintains state-of-the-art results in parsing, while also reaching state-of-the-art results in function labelling, by suitably extending a Simple Synchrony Network (SSN) parser (Henderson, 2003) into a single integrated system.
N03-1014
All our models, as well as the parser described in (Henderson, 2003), are run only once.
N03-1014
This observation is consistent with results reported in (Klein and Manning, 2003), who showed that part-of-speech tags occurring in the Treebank are not fine-grained enough to discriminate between 4Roughly, an OBJ non-terminal is an NP, SBAR or S whose parent is an S, VP or SBAR.
P03-1054
H03 indicates the model illustrated in (Henderson, 2003).
N03-1014
(Klein and Manning, 2003), for instance report a reduction in parsing accuracy of an unlexicalised PCFG from 77.8% to 72.9% if using function labels in training.
P03-1054
(Henderson, 2003) tested the effect of larger input vocabulary on SSN performance by changing the frequency cut-off that selects the input tag-word pairs.
N03-1014
First, they parse the Penn Treebank using a state-of-the-art parser (Charniak, 2000).
A00-2018
We will therefore discuss separately those pieces of work that have made limited use of function labels for parsing (Klein and Manning, 2003), and those that have concentrated on recovering function labels as a separate task (Blaheta and Charniak, 2000; Blaheta, 2004).
A00-2018 A00-2031 P03-1054
We think that our tag-word pairs are effective because they are selected by a linguistically meaning7Significance was measured with the randomized significance test described in (Yeh, 2000).
C00-2137
Statistical parsers trained on the Penn Treebank (PTB) (Marcus et al., 1993) produce trees annotated with bare phrase structure labels (Collins, 1999; Charniak, 2000).
A00-2018 J93-2004
(Klein and Manning, 2003) suggest the technique of tag splitting for the constituent bearing the label TMP.
P03-1054
Following (Blaheta and Charniak, 2000), we refer to the first class as syntactic function labels, and to the second class as semantic function labels.
A00-2018 A00-2031
tion labels are context-dependent and encode a shallow level of phrasal and lexical semantics, as observed first in (Blaheta and Charniak, 2000).1 To a large extent, they overlap with semantic role labels as defined in PropBank (Palmer et al., 2005).
A00-2018 A00-2031 J05-1004
While the function of a constituent and its structural position are often correlated, they some1(Blaheta and Charniak, 2000) talk of function tags.
A00-2018 A00-2031
