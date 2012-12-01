External information such as the discourse or domain dependency of each word sense (Guthrie et al.1991; Nasukawa 1993; Yarowsky 1995) is expected to lead to system improvement.
P91-1019 P95-1026
We reported on the performance of our sampling method by way of experiments in which we compared our method with random sampling, uncertainty sampling (Lewis and Gale 1994), and committee-based sampling (Engelson and Dagan 1996).
P96-1042
Engelson and Dagan (1996) criticized uncertainty sampling (Lewis and Gale 1994), which they call a "single model" approach, as distinct from their "multiple model" approach: sufficient statistics may yield an accurate 0.51 probability estimate for a class c in a given example, making it certain that c is the appropriate classificationJ 3 However, the certainty that c is the correct classification is low, since there is a 0.49 chance that c is the wrong class for the example.
J94-4003 P96-1042
As with most example-based systems (Fujii et al.1996; Kurohashi and Nagao 1994; Li, Szpakowicz, and Matwin 1995; Uramoto 1994b), our system uses an example database (database, hereafter) that contains example sentences associated with each verb sense.
C94-2114 C96-1012
Furthermore, since the restrictions imposed by the case fillers in choosing the verb sense are not equally selective, Fujii et al.(1996) proposed a weighted case contribution to disambiguation (CCD) of the verb senses.
C96-1012
Engelson and Dagan (1996) proposed a committee-based sampling method, which is currently applied to HMM training for part-of-speech tagging.
P96-1042
Predicate argument structures, which consist of complements (case filler nouns and case markers) and verbs, have also been used in the task of noun classification (Hindle 1990).
P90-1034
We adopted one typical implementation called the "vector space model" (VSM) (Frakes and Baeza-Yates 1992; Leacock, Towell, and Voorhees 1993; Salton and McGill 1983; Sch/itze 1992), which has a long history of application in information retrieval (IR) and text categorization (TC) tasks.
H93-1051
In committee-based sampling (Engelson and Dagan 1996), which follows the "query by committee" principle (Seung, Opper, and 592 Fujii, Inui, Tokunaga, and Tanaka Selective Sampling 85 8O 75 60 55 50 45 0 i i i i /.
P96-1042
Experimentation We estimated the performance of our verb sense disambiguation method through an experiment, in which we compared the following five methods: • lower bound (LB), in which the system systematically chooses the most frequently appearing verb sense in the database (Gale, Church, and Yarowsky 1992), • rule-based method (RB), in which the system uses a thesaurus to (automatically) identify appropriate semantic classes as selectional restrictions for each verb complement, • Naive-Bayes method (NB), in which the system interprets a given verb based on the probability that it takes each verb sense, • example-based method using the vector space model (VSM), in which the system uses the above mentioned co-occurrence data extracted from the RWC text base, • example-based method using the Bunruigoihyo thesaurus (BGH), in which the system uses Table 1 for the similarity computation.
C92-2070 P92-1032
This CCD factor is taken into account 2 Note that unlike the automatic acquisition of word sense definitions (Fukumoto and Tsujii 1994; Pustejovsky and Boguraev 1993; Utsuro 1996; Zernik 1989), the task of the system is to identify the best matched category with a given input, from predefined candidates.
C94-2122 C96-2163
In order to estimate the upper bound (limitation) of the disambiguation task, that is, to what extent a human expert makes errors in disambiguation (Gale, Church, and Yarowsky 1992), we analyzed incorrect outputs and found that roughly 30% of the system errors using the Bunruigoihyo thesaurus fell into this category.
C92-2070 P92-1032
Iterating between these two 1 Note that these problems are associated with corpus-based approaches in general, and have been identified by a number of researchers (Engelson and Dagan 1996; Lewis and Gale 1994; Uramoto 1994a; Yarowsky 1995).
C94-2114 J94-4003 P95-1026 P96-1042
This can be a critical problem for statistics-based approaches, as the reconstruction 12 Utsuro's method requires the constiuction of large-scale similarity templates prior to similarity computation (Utsuro et al.1994), and this is what we would like to avoid.
C94-2169
To avoid this problem, we could apply a method used in efficient database search techniques, by which the system can search for neighbor examples of x with optimal time complexity (Utsuro et al.1994). However, in this section, we will explain another efficient algorithm to identify neighbors of x, in which neighbors of case fillers are considered to be given directly by the thesaurus structure.
C94-2169
1. Introduction Word sense disambiguation is a potentially crucial task in many NLP applications, such as machine translation (Brown, Della Pietra, and Della Pietra 1991), parsing (Lytinen 1986; Nagao 1994) and text retrieval (Krovets and Croft 1992; Voorhees 1993).
P91-1034
Possible solutions would include one proposed by Uramoto, in which idiomatic expressions are described separately in the database so that the system can control their overgeneralization (Uramoto 1994b).
C94-2114
Various corpus-based approaches to word sense disambiguation have been proposed (Bruce and Wiebe 1994; Charniak 1993; Dagan and Itai 1994; Fujii et al.1996; Hearst 1991; Karov and Edelman 1996; Kurohashi and Nagao 1994; Li, Szpakowicz, and Matwin 1995; Ng and Lee 1996; Niwa and Nitta 1994; Sch~itze 1992; Uramoto 1994b; Yarowsky 1995).
C94-1049 C94-2114 C96-1012 J94-4003 P94-1020 P95-1026 P96-1006 W96-0104
When more than one verb sense is selected for any given method (or none of them remains, for the rule-based method), the system simply selects the verb sense that appears most frequently in the database, s In the experiment, we conducted sixfold cross-validation, that is, we divided the training/test data into six equal parts, and conducted six trials in which a different 7 A number of experimental results have shown the effectiveness of the Naive-Bayes method for word sense disambiguation (Gale, Church, and Yarowsky 1993; Leacock, Towell, and Voorhees 1993; Mooney 1996; Ng 1997; Pedersen, Bruce, and Wiebe 1997).
A97-1056 H93-1051 W96-0208 W97-0323
Similarly, in our case, each noun is represented by a vector comprising 4 Different types of application of hand-crafted thesauri to word sense disambiguation have been proposed, for example, by Yarowsky (1992).
C92-2070
2. Example-based Verb Sense Disambiguation System 2.1 The Basic Idea Our verb sense disambiguation system is based on the method proposed by Kurohashi and Nagao (1994) and later enhanced by Fujii et al.(1996). The system uses a database containing examples of collocations for each verb sense and its associated case frame(s).
C96-1012
Third, a number of existing NLP tools such as JUMAN (a morphological analyzer) (Matsumoto et al.1993) and QJP (a morphological and syntactic analyzer) (Kameda 1996) could broaden the coverage of our system, as inputs are currently limited to simple, morphologically analyzed sentences.
C96-2104
Therefore, the similarity between two given words is :represented by the length of the path between them in the thesaurus structure (Fujii et al.1996; Kurohashi and Nagao 1994; Li, Szpakowicz, and Matwin 1995; Uramoto 1994b).
C94-2114 C96-1012
With respect to the problem of overhead for search, possible solutions would include the generalization of similar examples (Kaji, Kida, and Morimoto 1992; Nomiyama 1993) or the reconstruction of the database using a small portion of useful instances selected from a given supervised example set (Aha, Kibler, and Albert 1991; Smyth and Keane 1995).
C92-2101
4. Evaluation 4.1 Comparative Experimentation ~n order to investigate the effectiveness of our example sampling method, we conducted an experiment in which we compared the following four sampling methods: • a control (random), in which a certain proportion of a given corpus is randomly selected for training, • uncertainty sampling (US), in which examples with minimum interpretation certainty are selected (Lewis and Gale 1994), • committee-based sampling (CBS) (Engelson and Dagan 1996), • our method based on the notion of training utility (TU).
P96-1042
