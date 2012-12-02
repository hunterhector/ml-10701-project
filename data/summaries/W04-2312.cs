In our experimental setup each user-turn in the dialogue corresponded to a single illocution, e.g. route request or sights information request as described by Gurevych et al.(2002a). The second data set was used for testing the dataand ontology-based systems and thusly will be called the test corpus.
W02-0207
Supervised For the purpose of evaluating a supervised learning approach on our data we used the efficient and general statistical TnT tagger, the short form for Trigrams’n’Tags (Brants, 2000).
A00-1031
In general, following Ide and Veronis (1998) the various WSD approaches of the past can be divided into two types, i.e., dataand knowledge-based approaches.
J98-1001
Collection The first data set was used for training the supervised model is described in Gurevych et al.(2002b) and was collected using the so-called Hidden Operator Test (Rapp and Strube, 2002).
W02-0207
Existing spoken language understanding systems, that are not shallow and thusly produce deep syntactic and semantic representations for multiple domains, e.g. the production system approach described by Engel (2002) or unification-based approaches described by Crysmann et al.(2002), have shown to be more suitable for well-formed input but less robust in case of imperfect input.
P02-1056
The ontology-based system has been successfully used for a set of tasks such as finding the best speech recognition hypotheses from sets of competing SRHs, labeling SRHs as correct or incorrect representations of the users intention and for scoring their degree of contextual coherence (Gurevych et al., 2003a; Porzel and Gurevych, 2003; Porzel et al., 2003).
N03-1012 W03-0903
For our experiments we took the general purpose statistical tagger (Brants, 2000), which is generally used for part-of-speech tagging.
A00-1031
Following Ide and Veronis (1998) we can distinguish between dataand knowledge-driven word sense disambiguation (WSD).
J98-1001
For example, Yarowsky (1992) used a thesaurus to generate 1042 statistical models of the most general categories.
C92-2070
The knowledge-based approach employed herein (Gurevych et al., 2003a) operates on an ontology partially derived from FrameNet data (Baker et al., 1998) and described by Gurevych et al.(2003b). In a comparable approach Sussna (1993) worked with the lexical reference system WordNet and used a similar metric for the calculation of semantic distance of a number of input lexemes.
N03-1012 P98-1013 W03-0903
Compared to the gold-standard, the original method of Gurevych et al.(2003a) reached a precision of 63.76a0 (f-measure = .78)8 as compared to 64.75a0 (f-measure = .79) for the new method described herein (baseline 52.48a0 ).
N03-1012 W03-0903
For a datadriven approach we employed a highly supervised learning algorithm introduced by Brants (2000) and trained it on a corpus of annotated data.
A00-1031
The class-based kappa statistic of (Cohen, 1960; Carletta, 1996) cannot be applied here, as the classes vary depending on the number of ambiguities per entry in the lexicon.
J96-2004
2.1 Data-based Methods Data-based approaches extract their information directly from texts and are divided into supervised and unsupervised methods (Yarowsky, 1995; Stevenson, 2003).
P95-1026
For this evaluation, therefore, we treat any concept occurring in a not-decidable slot as correct.7 7Such SRHs usually score below the consistency thresholds described by Gurevych et al.(2003a) and are not passed on.
N03-1012 W03-0903
the Baselines For calculating the majority class baseline, which in our case corresponds to the performance of a unigram tagger, we applied the method described in (Porzel and Malaka, 2004).
W04-2802
Yarowsky (1995) used both supervised and unsupervised WSD for correct phonetizitation of words in speech synthesis.
P95-1026
of the Art After work on WSD had overcome so-called early doubts (Ide and Veronis, 1998) in the 1960’s, it was applied to various NLP tasks, such as machine translation, information retrieval, content and grammatical analysis and text processing.
J98-1001
One example is the algorithm for clustering by committee described by Pantel and Lin (2003), which automatically discovers word senses from text.
N03-4011
For knowledge-driven disambiguation we examined whether the ontology-based method for computing semantic coherence introduced by Gurevych et al.(2003a) can be employed to disambiguate between alternative interpretations, i.e. concept representations, of a given speech recognition hypothesis (SRH) at hand.
N03-1012 W03-0903
It currently comprises nearly 50 modules running on a parallel virtual machine-based integration software called Multiplatform3 described in Herzog et al.(2003). 4.1 The Knowledge-driven System The ontology employed for the evaluation has about 800 concepts and 200 relations (apart from the isarelations defining the general taxonomy) and is described by Gurevych et al.(2003b). It includes a generic toplevel ontology whose purpose is to provide a basic structure of the world, i.e. abstract classes to divide the universe in distinct parts as resulting from the ontological analysis.4 The modeling of Processes and Physical Objects as a kind of event that is continuous and homogeneous in nature, follows the frame semantic analysis used for generating the FRAMENET data (Baker et al., 1998).
N03-1012 P98-1013 W03-0811 W03-0903
