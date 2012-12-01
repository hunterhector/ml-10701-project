Vector Similarity Model: Corpus-Based Modelling of Plausibility 3.1 Model Architecture Our model builds on the architecture of Erk (2007).
P07-1028
We build on a recent selectional preference model (Erk, 2007) that bases its generalisations on word similarity in a vector space.
P07-1028
Rooth et al.(1999) present a fundamentally different approach to selectional preference induction which uses soft clustering to form classes for generalisation and does not take recourse to any hand-crafted resource.
P99-1014
In addition, we discuss in detail which properties of the vector space are crucial for the prediction of plausibility ratings, a much more fine-grained task than the pseudo-word disambiguation task presented in Erk (2007) that is more closely related to semantic role labelling.
P07-1028
In cognitive science, they have been used to account for the influence of context on human lexical processing (McDonald and Brew, 2004), and to model lexical priming (Lowe and McDonald, 2000).
P04-1003
In computational linguistics, a multitude of tasks is sensitive to selectional preferences, such as the resolution of ambiguous attachments (Hindle and Rooth, 1993), word sense disambiguation (McCarthy and Carroll, 2003), semantic role labelling (Gildea and Jurafsky, 2002), or testing the applicability of inference rules (Pantel et al., 2007).
J02-3001 J03-4004 J93-1005 N07-1071
One is a coverage problem due to the limited size of the resource (see the task-based evaluation in Gildea and Jurafsky (2002)).
J02-3001
A number of approaches has been proposed to model selectional preference data (Padó et al., 2006; Resnik, 1996; Clark and Weir, 2002; Abe and Li, 1996).
J02-2003
Other models also relying on the WordNet resource include Abe and Li (1996) and Clark and Weir (2002).
J02-2003
We experiment with two distance measures to compute vector similarity, namely the Jaccard Coefficient and Cosine Distance, both of which have been shown to yield good performance in NLP tasks (Lee, 1999; McDonald and Lowe, 1998).
P99-1004
This is in contrast to recent results on predominant sense acquisition, the task of identifying the most frequent sense for a given word in an unsupervised manner (McCarthy et al., 2004).
P04-1036
To construct the parsed model (Parsed), we dependency-parsed the BNC with Minipar (Lin, 1993).
P93-1016
We have extended a recent proposal (Erk, 2007) which combines ideas from selectional preference induction and vector space models.
P07-1028
We have demonstrated that the successful evaluation of the model in Erk (2007) on the coarse-grained pseudo-word disambiguation task carries over to the prediction of human plausibility judgments which requires relatively fine-grained, relation-based distinctions.
P07-1028
Examples in NLP include information retrieval (Salton et al., 1975), automatic thesaurus extraction (Grefenstette, 1994), and predominant sense identification (McCarthy et al., 2004).
P04-1036
The strategy of our model to derive generalisations directly from corpus data, without recourse to resources, is similar to another family of corpus-driven selectional preference models, namely EM-based clustering models (Rooth et al., 1999).
P99-1014
Erk (2007) extracted the set of seen head words from corpora with semantic role annotation, and used only a single vector space representation.
P07-1028
Fortunately, the state of the art in broad-coverage (Lin, 1993) and unsupervised (Klein and Manning, 2004) dependency parsing allows us to treat dependency parsing merely as a preprocessing step.
P04-1061 P93-1016
