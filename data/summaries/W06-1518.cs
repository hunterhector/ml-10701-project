(Xue and Palmer, 2004)) and our experiments show that 91% of the SRL targets can be recovered despite this aggressive pruning.
W04-3212
The rationale for using a simple DL learner is given in (Gildea and Jurafsky, 2002) where essentially it based on their experience with the setting of backoff weights for smoothing, it is stated that the most specific single feature matching the training data is enough to predict the SRL on test data.
J02-3001
(Gildea and Jurafsky, 2002; Punyakanok, Roth and Yih, 2005; Pradhan et al, 2005; Toutanova et al., 2005)), the focus has been on two different aspects of the SRL task: (a) finding appropriate features, and (b) resolving the parsing accuracy problem by combining multiple parsers/predictions.
J02-3001 P05-1073 W05-0634
Instead of using the typical parse tree features used in typical SRL models, (Chen and Rambow, 2003) uses the path within the elementary tree from the predicate to the constituent argument.
W03-1006
and Results We use the PropBank corpus of predicateargument structures (Palmer, Gildea and Kingsbury, 2005) as our source of annotated data for the dev = Sec24 p(%) r(%) f(%) test = Sec23 M1: dev 78.42 77.03 77.72 M1: test 80.52 79.40 79.96 M2: dev 81.11 79.39 80.24 M2: test 83.47 81.82 82.64 M3: dev 80.98 79.56 80.26 M3: test 81.86 83.34 82.60 Table 1: Results on the CoNLL 2005 shared task using gold standard parse trees.
J05-1004
As a result some of the features that undo longdistance movement via trace information in the TreeBank as used in (Chen and Rambow, 2003) cannot be exploited in our model.
W03-1006
In this paper, we use the PropBank corpus of predicate-argument structures (Palmer, Gildea and Kingsbury, 2005).
J05-1004
As a result, if we do not compare the machine learning methods involved in the two approaches, but rather the features used in learning, our features are a natural generalization of (Chen and Rambow, 2003).
W03-1006
(Chen and Rambow, 2003) discuss a model for SRL that uses LTAG-based decomposition of parse trees (as is typically done for statistical LTAG parsing).
W03-1006
Here, the arguments for the predicate gave are defined in the PropBank Frame Scheme (Palmer, Gildea and Kingsbury, 2005) as: V: verb A2: beneficiary A0: giver AM-TMP: temporal A1: thing given Recognizing and labeling semantic arguments is a key task for answering “Who”, “When”,“What”, “Where”, “Why”, etc.
J05-1004
Different from the widely used 127 feature functions that are based on the syntactic parse tree (Gildea and Jurafsky, 2002), we explore the use of LTAG-based features in a simple discriminative decision-list learner.
J02-3001
