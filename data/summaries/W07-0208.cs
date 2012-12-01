In this section we apply the graph transformation method to the task of identification of semantic roles as annotated in the Proposition Bank (Palmer et al., 2005), PropBank for short.
J05-1004
roles labeling with the output of Charniak’s parser to the state-of-the-art system of (Pradhan et al., 2005).
P05-1072
(Jijkoun and de Rijke, 2004) described an extension of the pattern-matching method with a classifier trained on the dependency graphs derived from the Penn Treebank data.
P04-1040
The system was evaluated on the development corpus with respect to non-local dependencies using the “strict” evaluation measure of (Johnson, 2002): the F1 score of precision and recall of correctly identified empty nodes and antecedents.
P02-1018
Consider the task of recovering non-local dependencies (such as control, WH-extraction, topicalization) in the surface syntactic phrase trees produced by the state-of-the-art parser of (Charniak, 2000).
A00-2018
Availability of linguistically annotated corpora such as the Penn Treebank (Bies et al., 1995), Proposition Bank (Palmer et al., 2005), and FrameNet (Johnson et al., 2003) has stimulated much research on methods for automatic syntactic and semantic analysis of text.
J05-1004
Our method combines pattern matching on graphs and machine learning (classification) and can be viewed as an extension of the TransformationBased Learning paradigm (Brill, 1995).
J95-4004
(Campbell, 2004) presents a rulebased algorithm for empty node identification in syntactic trees, competitive with the machine learning methods we mention next.
P04-1082
Most state-of-the-art methods for the latter two tasks use a cascaded architecture: they employ syntactic parsers and re-cast the corresponding tasks as pattern matching (Johnson, 2002) or classification (Pradhan et al., 2005) problems.
P02-1018 P05-1072
In Table 4 we compare our system for semantic System P R F1 (Pradhan et al., 2005) 80.9 76.8 78.8 Here 81.0 70.4 75.3 Table4: Evaluationofourmethodsforsemanticrole identification with Propbank (12 first iterations).
P05-1072
Rich annotations of corpora has allowed for the development of techniques for recovering deep linguistic structures: syntactic non-local dependencies (Johnson, 2002; Hockenmaier, 2003; Dienes, 2004; Jijkoun and de Rijke, 2004) and semantic arguments (Gildea, 2001; Pradhan et al., 2005; Toutanovaetal., 2005; GiugleaandMoschitti, 2006).
P02-1018 P03-1046 P04-1040 P05-1072 P05-1073 P06-1117
Our method for learning graph transformations follows the structure of Transformation-Based Learning (Brill, 1995) and proceeds iteratively, as shown in Figure 4.
J95-4004
Other methods (Jijkoun and de Rijke, 2004) use combinations of pattern matching and classification.
P04-1040
Here, solid lines correspond to surface syntactic structure, produced by Charniak’s parser (Charniak, 2000), and dashed lines are an encoding of the Proposition Bank annotation of the semantic roles with respect to the verb stopped.
A00-2018
In (Johnson, 2002) a simple pattern-matching algorithm was proposed for inserting empty nodes into syntactic trees, with patterns extracted from the Penn Treebank.
P02-1018
