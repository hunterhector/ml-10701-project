For the present study, we applied the procedure used by Lapata, McDonald, and Keller (1999) and Lapata, Keller, and McDonald (2001) to noun-noun bigrams and to verb-object bigrams, creating a set of 90 seen and 90 unseen bigrams for each type of predicate-argument relationship.
E99-1005 N01-1009 P01-1046
It was assumed that PPs adjacent to the verb headed by any of the prepositions in, to, for, with, on, at, from, of, into, through, and upon were prepositional objects (see Lapata [2001] for details on the filtering process).
N01-1009 P01-1046
Finally, recall that the results for the EM-based approaches in Tables 13 and 14 were obtained on the development set (as pseudodisambiguation was used as a means of parameter tuning by Rooth et al.[1999] and Prescher, Riezler, and Rooth [2000]).
C00-2094 P99-1014
Rooth et al.(1999) used pseudodisambiguation to evaluate a class-based model that is derived from unlabeled data using the expectation maximization (EM) algorithm.
P99-1014
At this point, it is important to note that neither Rooth et al.(1999) nor Prescher, Riezler, and Rooth (2000) used pseudodisambiguation for the final evaluation of their models.
C00-2094 P99-1014
In the smoothing literature, re-created frequencies are typically evaluated using pseudodisambiguation (Clark and Weir 2001; Dagan, Lee, and Pereira 1999; Lee 1999; Pereira, Tishby, and Lee 1993; Prescher, Riezler, and Rooth 2000; Rooth et al.1999). 477 Keller and Lapata Web Frequencies for Unseen Bigrams The aim of the pseudodisambiguation task is to decide whether a given algorithm re-creates frequencies that make it possible to distinguish between seen and unseen bigrams in a given corpus.
C00-2094 N01-1013 P93-1024 P99-1004 P99-1014
Table 10 shows the descriptive statistics for all six judgment experiments: the original experiments by Lapata, McDonald, and Keller (1999) and Lapata, Keller, and McDonald (2001) for adjective-noun bigrams, and our new ones for noun-noun and verb-object bigrams.
E99-1005 N01-1009 P01-1046
Other smoothing approaches such as discounting (Katz 1987) and distance-weighted averaging (Grishman and Sterling 1994; Dagan, Lee, and Pereira 1999) re-create counts of unseen word combinations by exploiting only corpus-internal evidence, without relying on taxonomic information.
C94-2119 P99-1004
Lapata, McDonald, and Keller used the part-of-speech-tagged version that is made available with the BNC and was tagged using CLAWS4 (Leech, Garside, and Bryant 1994), a probabilistic partof-speech tagger, with error rate ranging from 3% to 4%.
C94-1103
The data sets were constructed as proposed by Rooth et al.(1999). The procedure for creating the second data set was identical, but this time only verbs that occurred between 100 and 1,000 times were considered.
P99-1014
Figure 3 of Rooth et al.(1999) shows that a performance of more than 75% is obtained for every reasonable choice of classes.
P99-1014
We applied Lapata, Keller, and McDonald’s (2001) technique to the unseen bigrams for all three bigram types.
N01-1009 P01-1046
They also show that this class-based approach outperforms distance-weighted averaging (Dagan, Lee, and Pereira 1999), a smoothing method that re-creates unseen word co-occurrences on the basis of distributional similarity (without relying on a predefined taxonomy), in predicting plausibility.
P99-1004
In the following, we will first describe in some detail the experiments that Rooth et al.(1999) and Clark and Weir (2001) conducted.
N01-1013 P99-1014
In the current study, we used the smoothing technique of Lapata, Keller, and McDonald (2001) to re-create not only adjective-noun bigrams, but also noun-noun 475 Keller and Lapata Web Frequencies for Unseen Bigrams Table 12 Correlation of counts re-created using class-based smoothing with Web counts.
N01-1009 P01-1046
retrieved from the Web therefore provide enormous potential for training NLP algorithms, if Banko and Brill’s (2001a, 2001b) findings for spelling corrections generalize; potential applications include tasks that involve word n-grams and simple surface syntax.
H01-1052 P01-1005
The NANTC corpus was parsed using MINIPAR (Lin 1994, 2001), a broad-coverage parser for English.
C94-1079 H01-1046
Prescher, Riezler, and Rooth (2000) reported pseudodisambiguation results with two clustering models: (1) Rooth et al.’s (1999) clustering approach, which models the semantic fit between a verb and its argument (VA model), and (2) a refined version of this approach that models only the fit between a verb and its object (VO model), disregarding other arguments of the verb.
C00-2094 P99-1014
We also applied our Web-based method to the pseudodisambiguation data set of Clark and Weir (2002).
J02-2003
However, Keller, Lapata, and Ourioupina (2002) used AltaVista match counts (instead of page counts) on the same data sets; their results agree with the ones reported in the present article very closely.
J02-3004 W02-1030
Clark and Weir (2002) report pseudodisambiguation results on two data sets, with an experimental setup similar to that of Rooth et al.(1999). For the first data set, 3,000 pairs were randomly chosen from 1.3 million (v, n) tuples extracted from the BNC (using the parser of Briscoe and Carroll [1997]).
A97-1052 J02-2003 P99-1014
The performance on the whole data set is 77.7%, which is below the performance of 80.0% reported by Rooth et al.(1999). However, the difference is not found to be significant using a chi-square test comparing the number of correct and incorrect classifications (χ 2 (1)=2.02, p = .16).
P99-1014
We obtained the data sets of Rooth et al.(1999), Prescher, Riezler, and Rooth (2000), and Clark and Weir (2002) described above.
C00-2094 J02-2003 P99-1014
The joint probability model performs consistently worse than the conditional probability model: It achieves an overall accuracy of 72.7%, which is significantly lower than the accuracy of the Rooth et al.(1999) model (χ 2 (1)=19.50, p <.01).
P99-1014
The queries were carried out in January 2003 (and thus the counts are higher than those reported in Keller, Lapata, and Ourioupina [2002], which were generated about a year earlier).
J02-3004 W02-1030
We re-created co-occurrence frequencies for predicate-argument bigrams using a simplified version of Resnik’s (1993) selectional association measure proposed by Lapata, Keller, and McDonald (2001).
N01-1009 P01-1046
We evaluated our Web counts by applying the pseudodisambiguation procedure that Rooth et al.(1999), Prescher, Riezler, and Rooth (2000), and Clark and Weir (2001) employed for evaluating re-created verb-object bigram counts.
C00-2094 N01-1013 P99-1014
To summarize, we demonstrated that the simple Web-based approach proposed in this article yields results for pseudodisambiguation that outperform class-based smoothing techniques, such as the ones proposed by Resnik (1993), Li and Abe (1998), and Clark and Weir (2002).
J02-2003 J98-2002
Prescher, Riezler, and Rooth (2000) evaluated Rooth et al.’s (1999) EM-based clustering model again using pseudodisambiguation, but on a separate data set using a Table 13 Percentage of correct disambiguations on the pseudodisambiguation task using Web counts and counts re-created using EM-based clustering (Rooth et al.1999). Data Set N AltaVista AltaVista Rooth et al.Conditional Probability Joint Probability Subject 717 71.2 68.5 — Objects 620 85.2 77.5 — Subjects and objects 1,337 77.7 72.7 80.0 478 Computational Linguistics Volume 29, Number 3 Table 14 Percentage of correct disambiguations on the pseudodisambiguation task using Web counts and counts re-created using EM-based clustering (Prescher, Riezler, and Rooth 2000).
C00-2094 P99-1014
For the seen adjective-noun bigrams, we used the data of Lapata, McDonald, and Keller (1999), who compiled a set of 90 bigrams as follows.
E99-1005
Grefenstette and Nioche (2000) and Jones and Ghani (2000) use the Web to generate corpora for languages for which electronic resources are scarce, and Resnik (1999) describes a method for mining the Web in order to obtain bilingual texts.
P99-1068
Banko and Brill (2001a, 2001b) experiment with context-sensitive spelling correction, a task for which large amounts of data can be obtained straightforwardly, as no manual annotation is required.
H01-1052 P01-1005
They used a set of 298 (v, n, n prime ) BNC triples in which (v, n) was chosen as in Rooth et al.(1999) but paired with a randomly chosen noun n prime . Given the set of (v, n, n prime ) triples, the task was to decide whether (v, n) or (v, n prime ) was the correct pair in each triple.
P99-1014
The lemmatized version of the corpus was obtained using Karp et al.’s (1992) morphological analyzer.
C92-3145
Several statistical models employ frequencies obtained from the output of partial parsers and other heuristic methods; these include models for disambiguating the attachment site of prepositional phrases (Hindle and Rooth 1993; Ratnaparkhi 1998), models for interpreting compound nouns (Lauer 1995; Lapata 2002) and polysemous adjectives (Lapata 2001), models for the induction of selectional preferences (Abney and Light 1999), methods for automatically clustering words according to their distribution in particular syntactic contexts (Pereira, Tishby, and Lee 1993), automatic thesaurus extraction (Grefenstette 1994; Curran 2002), and similarity-based models of word co-occurrence probabilities (Lee 1999; Dagan, Lee, and Pereira 1999).
E99-1005 J02-3004 J93-1005 N01-1009 P01-1046 P02-1030 P93-1024 P98-2177 P99-1004 W99-0901
The combined performance of 68.5% is significantly lower than the performance of both the VA model (χ 2 (1)=7.78, p <.01) and the VO model (χ 2 (1)=33.28, p <.01) reported by Prescher, Riezler, and Rooth (2000).
C00-2094
The joint probability model achieved 85.3% on this data set, also significantly outperforming Clark and Weir (2002) (χ 2 (1)=119.35, p <.01).
J02-2003
and Weir (2002) use a setting similar to that of Rooth et al.(1999) and Prescher, Riezler, and Rooth (2000); here pseudodisambiguation is employed to evaluate the performance of a class-based probability estimation method.
C00-2094 P99-1014
460 Computational Linguistics Volume 29, Number 3 and Zhu and Rosenfeld (2001) use Web-based n-gram counts to improve language modeling.
H01-1046
This result holds both for seen bigrams (Lapata, McDonald, and Keller 1999) and for unseen bigrams whose counts have been re-created using smoothing techniques (Lapata, Keller, and McDonald 2001).
E99-1005 N01-1009 P01-1046
For instance, Clark and Weir’s (2002) data set is substantially less noisy than Rooth et al.’s (1999) and Prescher, Riezler, and Rooth’s (2000), as it contains only words and nouns that occur in WordNet.
C00-2094 J02-2003 P99-1014
This is significantly higher than the highest performance of 72.4% reported by Clark and Weir (2002) on the same data set (χ 2 (1)=115.50, p <.01).
J02-2003
1. Introduction In two recent papers, Banko and Brill (2001a, 2001b) criticize the fact that current NLP algorithms are typically optimized, tested, and compared on fairly small data sets (corpora with millions of words), even though data sets several orders of magnitude larger are available, at least for some NLP tasks.
H01-1052 P01-1005
The probabilities were re-created using Rooth et al.’s (1999) EM-based clustering model on a training set from which all seen pairs (v, n) had been removed.
P99-1014
The procedure described by Lapata, Keller, and McDonald (2001) was followed for creating sets of unseen noun-noun and verb-object bigrams: for each noun or verb, we compiled a list of all nouns with which it did not co-occur within a noun-noun or verbobject bigram in the BNC.
N01-1009 P01-1046
Mihalcea and Moldovan (1999) and Agirre and Martinez (2000) use the Web for word sense disambiguation, Volk (2001) proposes a method for resolving PP attachment ambiguities based on Web data, Markert, Nissim, and Modjeska (2003) use the Web for the resolution of nominal anaphora, ∗ School of Informatics, 2 Buccleuch Place, Edinburgh EH8 9LW, UK.
P99-1020
The experiments reported in this article were carried out using the WebExp software package (Keller et al.1998). A series of previous studies has shown that data obtained using WebExp closely replicate results obtained in a controlled laboratory setting; this has been demonstrated for acceptability judgments (Keller and Alexopoulou 2001), coreference judgments (Keller and Asudeh 2001), and sentence completions (Corley and Scheepers 2002).
W02-1030
Other, more sophisticated class-based methods do away with the simplifying assumption that the argument co-occurring with a given predicate (adjective, noun, verb) is distributed evenly across its conceptual classes and attempt to find the right level of generalization in a concept hierarchy, by discounting, for example, the contribution of very general classes (Clark and Weir 2001; McCarthy 2000; Li and Abe 1998).
A00-2034 J98-2002 N01-1013
Lapata, Keller, and McDonald (2001) compiled a set of 90 unseen adjective-noun bigrams using the same 30 adjectives.
N01-1009 P01-1046
However, this is still significantly better than the best result of Clark and Weir (2002) (χ 2 (1)=63.14, p <.01).
J02-2003
Lin (1998) evaluated the parser on the SUSANNE corpus (Sampson 1995), a domain-independent corpus of British English, and achieved a recall of 79% and precision of 89% on the dependency relations.
J98-2002
This procedure is well-justified in the context of Rooth et al.’s (1999) and Prescher, Riezler, and Rooth’s (2000) work, which aimed at building models of lexical semantics, not of pseudodisambiguation.
C00-2094 P99-1014
If a bigram is unseen in a given corpus, conventional approaches re-create its frequency using techniques such as back-off, linear interpolation, class-based smoothing or distanceweighted averaging (see Dagan, Lee, and Pereira [1999] and Lee [1999] for overviews).
P99-1004
For seen and unseen adjective-noun bigrams, we used the two sets of plausibility judgments collected by Lapata, McDonald, and Keller (1999) and Lapata, Keller, and McDonald (2001), respectively.
E99-1005 N01-1009 P01-1046
Clark and Weir (2002) further compared their approach with Resnik’s (1993) selectional association model and Li and Abe’s (1998) tree cut model on the same data sets.
J02-2003 J98-2002
Therefore, they carried out their final evaluations on unseen test sets for the tasks of lexicon induction (Rooth et al.1999) and target language disambiguation (Prescher, Riezler, and Rooth 2000), once the model parameters had been fixed using the pseudodisambiguation development set.
C00-2094 P99-1014
The same pattern is observed for the high-frequency data set, on which the conditional probability model achieves 87.7% correct and thus significantly outperforms Clark and Weir (2002), who obtained 73.9% (χ 2 (1)=283.73, p <.01).
J02-2003
The selected pairs con8 Stefan Riezler (personal communication, 2003) points out that the main variance in Rooth et al.’s (1999) pseudodisambiguation results comes from the class cardinality parameter (start values account for only 2% of the performance, and iterations do not seem to make a difference at all).
P99-1014
The present article is an extended and revised version of Keller, Lapata, and Ourioupina (2002).
J02-3004 W02-1030
480 Computational Linguistics Volume 29, Number 3 A similar picture emerges with regard to Prescher, Riezler, and Rooth’s (2000) data set (see Table 14).
C00-2094
479 Keller and Lapata Web Frequencies for Unseen Bigrams Table 15 Percentage of correct disambiguations on the pseudodisambiguation task using Web counts and counts re-created using class-based smoothing (Clark and Weir 2002).
J02-2003
This technique is a special case of n-fold cross-validation (Weiss and Kulikowski 1991) and has been previously used for measuring how well humans agree in judging semantic similarity (Resnik 1999, 2000).
P99-1068
In order to address the problem of estimating conditional probabilities in the face of sparse data, Clark and Weir (2002) define probabilities in terms of classes in a semantic hierarchy and propose hypothesis testing as a means of determining a suitable level of generalization in the hierarchy.
J02-2003
The results for Rooth et al.’s (1999) data set are given in Table 13.
P99-1014
Because a given word is not always represented by a single class in the taxonomy (i.e., the argument co-occurring with a predicate can generally be the realization of one of several conceptual classes), Lapata, Keller, and McDonald (2001) constructed the frequency counts for a predicate-argument bigram for each conceptual class by dividing the contribution from the argument by the number of classes to which it belongs.
N01-1009 P01-1046
We were also able to show that a Web-based approach is able to achieve the same performance as an EM-based smoothing model proposed by Rooth et al.(1999). However, the Web-based approach was not able to outperform the more sophisticated EM-based model of Prescher, Riezler, and Rooth (2000).
C00-2094 P99-1014
