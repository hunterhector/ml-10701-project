Clark and Curran (2004b) describes the training procedure for the dependency model, which uses a discriminativeestimationmethodbymaximisingthe conditional likelihood of the model given the data (Riezler et al., 2002).
C04-1041 P02-1035 P04-1014 W04-3215
Riezler et al.(2002) describe a partial training method for a log-linear LFG parsing model in which the “correct” LFG derivations for a sentence are those consistent with the less detailed gold standard derivation from the Penn Treebank.
P02-1035
The definitions of the objective function (4) and the gradient (5) for training remain the same in the partial-data case; the only differences are that ∆(pi) isnowdefinedtobethosederivationswhichareconsistent with the partial dependency structure pi, and the gold-standard dependency structures pij are the partial structures extracted from the gold-standard lexical category sequences.2 Clark and Curran (2004b) gives an algorithm for finding all derivations in a packed chart which produce a particular set of dependencies.
C04-1041 P04-1014 W04-3215
In this paper we propose the use of annotated data in the new domain, but only partially annotated data, which reduces the annotation effort required (Hwa, 1999).
P99-1010
Another way to think of the estimation process is that it attempts to put as much mass as possible on the derivations leading to the gold-standard structures (Riezler et al., 2002).
P02-1035
The partial training method uses the log-linear dependency model described in Clark and Curran (2004b), which uses sets of predicate-argument de144 pendencies, ratherthanderivations, fortraining.
C04-1041 P04-1014 W04-3215
Parsing with Combinatory Categorial Grammar (CCG) takes place in two stages: first, CCG lexical categories are assigned to the words in the sentence, and then the categories are combined by the parser (Clark and Curran, 2004a).
C04-1041 P04-1014 W04-3215
Previous work has attempted parser adaptation without relying on treebank data from the new domain (Steedman et al., 2003; Lease and Charniak, 2005).
E03-1008
CCG Parsing Model Clark and Curran (2004b) describes two log-linear parsing models for CCG: a normal-form derivation model and a dependency model.
C04-1041 P04-1014 W04-3215
A similar idea is proposed by Carroll and Briscoe (2002) for producing high precision data for lexical acquisition.
C02-1013
The CCG parsing consists of two phases: first the supertagger assigns the most probable categories to each word, and then the small number of combinatory rules, plus the type-changing and punctuation rules, are used with the CKY algorithm to build a packedchart.5 WeusethemethoddescribedinClark and Curran (2004b) for integrating the supertagger with the parser: initially a small number of categories is assigned to each word, and more categories are requested if the parser cannot find a spanning analysis.
C04-1041 P04-1014 W04-3215
We define the probability ofadependencystructureasthesumoftheprobabilities of all those derivations leading to that structure (Clark and Curran, 2004b).
C04-1041 P04-1014 W04-3215
In this paper we use the dependency model, which requires sets of predicate-argument dependencies for training.1 1Hockenmaier and Steedman (2002) describe a generative model of normal-form derivations; one possibility for training this model on partial data, which has not been explored, is to use the EM algorithm (Pereira and Schabes, 1992).
P02-1043 P92-1017
The optimisation of the objective function is performed using the limited-memory BFGS numerical optimisation algorithm (Nocedal and Wright, 1999; Malouf, 2002), which requires calculation of the objective function and the gradient of the objective function at each iteration.
W02-2018
The derivations licenced by a lexical category sequence were created using the CCG parser described inClarkandCurran(2004b).
C04-1041 P04-1014 W04-3215
The dependency model uses the same set of features described in Clark and Curran (2004b): dependency features representing predicate-argument dependencies (with and without distance measures); rule instantiation features encoding the combining categories together with the result category (with and without a lexical head); lexical category features, consisting of word–category pairs at the leaf nodes; and root category features, consisting of headword–category pairs at the root nodes.
C04-1041 P04-1014 W04-3215
Clark and Curran (2003) shows how the sum over the complete derivation space can be performed efficiently using a packed chart and the inside-outside algorithm, and Clark and Curran (2004b) extends this method to sum over all derivations leading to a gold-standard dependency structure.
C04-1041 P04-1014 W03-1013 W04-3215
The formalism we use is Combinatory Categorial Grammar (Steedman, 2000), together with a parsing model described in Clark and Curran (2004b) which we adapt for use with partial data.
C04-1041 P04-1014 W04-3215
Full, correct dependency structures for the sentences in 2-21 were created by running our CCG parser (Clark and Curran, 2004b) over the gold-standard derivation for each sentence, outputting the dependencies.
C04-1041 P04-1014 W04-3215
The dependency parsing model of Clark and Curran (2004b) is extended to exploit this partial training data.
C04-1041 P04-1014 W04-3215
The “maximum-recall” algorithm described in Clark and Curran (2004b) is used to find the highest scoring dependency structure.
C04-1041 P04-1014 W04-3215
Our partial training regime only requires sentences to be annotated with lexical categories, rather than full parse trees; therefore the data can be produced much more quickly for a new domain or language (Clark et al., 2004).
C04-1041 P04-1014 W04-3215
Even robust parsers using linguistically sophisticated formalisms, such as TAG (Chiang, 2000), CCG (Clark and Curran, 2004b; Hockenmaier, 2003), HPSG (Miyao et al., 2004) and LFG (Riezler et al., 2002; Cahill et al., 2004), often use training data derived from the Penn Treebank.
C04-1041 P00-1058 P02-1035 P02-1043 P04-1014 P04-1041 W03-1013 W04-3215
Clark et al.(2004) describes a porting experiment 150 in which a CCG parser is adapted for the question domain.
C04-1041 P04-1014 W04-3215
of the Parser The training data for the dependency model was created by first supertagging the sentences in sections 2-21, using the supertagger described in Clark and Curran (2004b).4 The average number of categories 3Since our training method is intended to be applicable in the absence of derivation data, the use of such rules may appear suspect.
C04-1041 P04-1014 W04-3215
