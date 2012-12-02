Another important thread of investigation concerning preposition behavior is the task of semantic role (and perhaps semantic relation) labeling (Gildea & Jurafsky, 2002).
J02-3001
The systems for the other languages follow the successful models devised for English, (Gildea and Jurafsky, 2002; 95 Xue and Palmer, 2004; Pradhan et al., 2003).
J02-3001
increase [from $50] to $100) temporal topic 3 Semantic Parsing 3.1 Architecture and Classifier Following the architecture of earlier semantic parsers like Gildea and Jurafsky (2002), we treat the semantic parsing task as a 1-of-N classification problem.
J02-3001
As can be seen in 2b and 2c, the dependencies are augmented by thematic roles (Kipper et al., 2000) (e.g., Agent, Theme, Cause, Instrument?? produced by a semantic role labeling system (c.f., Gildea and Jurafsky, 2002).
J02-3001
This approach has been applied to problems like compound noun interpretation (Rosario and Hearst 2001) and semantic role labeling (Gildea and Jurafsky 2002).
J02-3001
One the best two teams in RTE-2 (Tatu et al., 2006) proposed a knowledge representation model which achieved about 10% better performance than the third (Zanzotto and Moschitti, 2006) based on their logic prover.
E06-1015 P06-1051
For classification we applied the updated tree-kernel package (Moschitti 2006), distributed with the svm-light tool (Joachims 1999) for learning Support Vector Machines (SVMs).
E06-1015
As described earlier, the reference answer facets are roughly extracted from the relations in a syntactic dependency parse (c.f., Nivre and Scholz, 2004) and a shallow semantic parse (Gildea and Jurafsky, 2002).
J02-3001
parse trees as in (Moschitti, 2004)) would be more successful.
P04-1043
Results 5.1 Experimental Setup We implemented the novel cross-similarity kernel in the SVM-light-TK (Moschitti, 2006) that encodes the basic syntactic kernel KT in SVM-light (Joachims, 1999).
E06-1015
For example, Gildea and Jurafsky (2002) found that identifying passives was important in training a semantic role classifier from FrameNet, using a parser trained on the Penn Treebank along with a set of templates to distinguish passive constructions from active ones.
J02-3001
The algorithm we used in our final submission is similar to recent systems which discover textual entailment relationships (Haghighi, Ng et al.2005; Zanzotto and Moschitti 2006).
E06-1015 H05-1049 P06-1051
In contrast, Zanzotto&Moschitti (2006) proposed a machine-learning based approach which reaches a high accuracy by only using the available RTE data.
E06-1015 P06-1051
Another group (Zanzotto and Moschitti, 2006) utilized a tree kernel method for cross-pair similarity, which showed an improvement, and this has motivated us to investigate kernel-based methods.
E06-1015 P06-1051
In 10-fold crossvalidation with this data we achieved an average fscore of 70.6, based on features similar to the subset trees used for semantic role labeling in (Moschitti 2004).
P04-1043
2 Cross-pair similarity and its limits 2.1 Learning entailment rules with syntactic cross-pair similarity The cross-pair similarity model (Zanzotto and Moschitti, 2006) proposes a similarity measure aiming at capturing rewrite rules from training examples, computing a cross-pair similarity KS((Tprime,Hprime),(Tprimeprime,Hprimeprime)).
E06-1015 P06-1051
In the original formulation for English in Gildea and Jurafsky (2002), it answers the question: Is the NP governed by IP or VP?
J02-3001
"the international Olympic Conference held in Paris" Figure 1 Example of DE construction Since the governing category information is encoded in the path feature, it may be redundant; indeed this redundancy might explain why the governing category feature was used in Gildea & Jurafsky(2002) but not in Gildea and Palmer(2002).
J02-3001
Moschitti (2006).
E06-1015
We have also begun to experiment with the tree kernels of Moschitti (2006), but are not yet in a position to report results.
E06-1015
