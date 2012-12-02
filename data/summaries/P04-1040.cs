89% reported in (Blaheta and Charniak, 2000)).
A00-2018 A00-2031
Johnson (2002) and Jijkoun (2003) used pattern-matching on local phrase or dependency structures.
P02-1018 P03-2006
TiMBL performed well on tasks where structured, more complicated and task-specific statistical models have been used previously (Blaheta and Charniak, 2000).
A00-2018 A00-2031
In the experiments we used the parsers described in (Charniak, 2000) and (Collins, 1999).
A00-2018
The evaluation of the transformed output of the parsers of Charniak (2000) and Collins (1999) gives 90% unlabelled and 84% labelled accuracy with respect to dependencies, when measured against a dependency corpus derived from the Penn Treebank.
A00-2018
Below are the overall precision, recall, and f-score for our method and the scores reported in (Dienes and Dubey, 2003) for antecedent recovery using Collins’ parser.
W03-1005
Their method achieves a considerable improvement over the results reported in (Johnson, 2002) and gives the best evaluation results published to date.
P02-1018
Johnson (2002) was the first to address recovery of non-local dependencies in a parser’s output.
P02-1018
Thus, it is informative to compare our results with those reported in (Blaheta and Charniak, 2000) for this same task.
A00-2018 A00-2031
This is important, since making parsers aware of non-local relations need not improve the overall performance: Dienes and Dubey (2003) report a decrease in PARSEVAL fscore from 88.2% to 86.4% after modifying Collins’ parser to resolve traces internally, although this allowed them to achieve high accuracy for traces.
W03-1005
Pattern-matching approaches were used in (Johnson, 2002) and (Jijkoun, 2003) to recover non-local dependencies in phrase trees.
P02-1018 P03-2006
Building on these ideas, Jijkoun (2003) used a machine learning classifier to detect matches.
P03-2006
For traces, this corresponds to the evaluation using the head-based antecedent representation described in (Johnson, 2002), and for empty nodes without antecedents (e.g., NP PRO) this is the measure used in Section 7.1.
P02-1018
Method P R f Dienes and Dubey 81.5 68.7 74.6 This paper 82.8 67.8 74.6 Interestingly, the overall performance of our postprocessing method is very similar to that of the preand in-processing methods of Dienes and Dubey (2003).
W03-1005
For this task, the best published results (using Johnson’s metric) were reported by Dienes and Dubey (2003), who used shallow tagging to insert empty elements.
W03-1005
Currently, there are no parsers trained on the Penn Treebank that use the structure of the treebank in full and that are thus 1Some notable exceptions are the CCG parser described in (Hockenmaier, 2003), which incorporates non-local dependencies into the parser’s statistical model, and the parser of Collins (1999), which uses WH traces and argument/modifier distinctions.
P03-1046
Dienes and Dubey (2003) used shallow preprocessing to insert empty elements in raw sentences, making the parser itself capable of finding non-local dependencies.
W03-1005
Klein and Manning (2003), for example, mention that using functional tags of the Penn Treebank (temporal, location, subject, predicate, etc).
P03-1054
to Earlier Work A procedure for empty node recovery was first described in (Johnson, 2002), along with an evaluation criterion: an empty node is correct if its category and position in the sentence are correct.
P02-1018
As an alternative to hardcoded heuristics, Blaheta and Charniak (2000) proposed to recover the Penn functional tags automatically.
A00-2018 A00-2031
Furthermore, experiments described in (Dienes and Dubey, 2003) show that the latter task can be successfully addressed by shallow preprocessing methods.
W03-1005
It is not clear whether the PARSEVAL evaluation can be easily extended to take non-local relations into account (see (Johnson, 2002) for examples of such extension).
P02-1018
Blaheta and Charniak (2000) presented the first method for assigning Penn functional tags to constituents identified by a parser.
A00-2018 A00-2031
It has been successfully applied to the identification of semantic relations (Ahn et al., 2004), using FrameNet as the training corpus.
W04-0814
Finally, the independence from the details of the parser and the corpus suggests that our method can be applied to systems based on other formalisms, e.g., (Hockenmaier, 2003), to allow a meaningful dependency-based comparison of very different parsers.
P03-1046
