In this study we compare a naive Bayesian classifier that relies on a uniform prior (see (20)) against two classifiers that make use of nonuniform prior models: The classifier in (22) effectively uses as prior the baseline model P(c) from Section 2, whereas the classifier in (23) relies on the more informative model P(c, f, v).Asa baseline for the disambiguation task, we simply assign the most common class in the training data to every instance in the test data, ignoring context and any form of prior information (Pedersen 2001; Gale, Church, and Yarowsky 1992a).
N01-1011 P92-1032
A different grouping might, for example, have occurred if finer or coarser semantic distinctions were taken into account (see Merlo and Stevenson [2001] and Dang, Rosenzweig, and Palmer [1997] for alternative classifications) or if the containment of ambiguity was one of the classification objectives.
J01-3003
Dorr and Jones (1996) use Levin’s (1993) classification to show that there is a predictable relationship between verbal meaning and syntactic behavior.
C96-1055
Following Hindle and Rooth (1993), we smooth the observed frequencies as shown in Table 7.
J93-1005
We employ Levin’s inventory of semantic classes, arriving at a finer-grained classification than Merlo and Stevenson (2001).
J01-3003
We have presented in this article a general framework that could be extended to related classifications such as the semantic hierarchy proposed by Dang et al.(1998). In fact the latter may be more appropriate than Levin’s original classification for our disambiguation experiments, as it is based on a tighter correspondence between syntactic frames and semantic components and contains links to the WordNet taxonomy.
P98-1046
Merlo and Stevenson (2001) use grammatical features (acquired from corpora) to classify verbs into three semantic classes: unergative, unaccusative, and object drop.
J01-3003
The models proposed by Chao and Dyer (2000) and Ciaramita and Johnson (2000) are not directly applicable to Levin’s classification, as the latter is not a hierarchy (and therefore not a DAG) and cannot be straightforwardly mapped into a Bayesian network.
C00-1023 C00-1028
These exploit syntactic cues, or at least cues that are plausibly related to syntax (Merlo and Stevenson 2001; Schulte im Walde 2000; Lapata 1999; McCarthy 2000).
A00-2034 J01-3003 P99-1051
Prior knowledge about the likelihood of different senses or semantic classes is derived heuristically by submitting queries (e.g., great hurricane) to the AltaVista search engine and extrapolating from the number of returned documents the frequency of the adjective-noun pair (see Mihalcea and Moldovan [1998] for details of this technique).
W98-0703
Such information can be also incorporated into the prior model in the form of conditional probabilities, where the verb is, for example, conditioned on the thematic role of its arguments if this is known (see Gildea and Jurafsky [2000] for a method that automatically labels thematic roles).
P00-1065
Other work has used Levin’s classification (in conjunction with other lexical resources) to create dictionaries that express the systematic correspondence between syntax and meaning (Dorr 1997; Dang, Rosenzweig, and Palmer 1997; Dorr and Jones 1996).
C96-1055
Chao and Dyer (2000) propose a method for the disambiguation of polysemous adjectives in adjective-noun combinations that also uses Bayesian networks and WordNet’s taxonomic information.
C00-1023
We evaluated the performance of the model on all verbs listed in Levin (1993) that are polysemous (i.e., members of more than one class) and take frames characteristic of the widely studied dative and benefactive alternations (Pinker 1989; Boguraev and Briscoe 1989; Levin 1993; Goldberg 1995; Briscoe and Copestake 1999) and of the less well-known conative and possessor object alternations (see examples (1)–(4)).
J99-4002
The problem is ignored by Merlo and Stevenson (2001), who focus only on monosemous verbs.
J01-3003
Similar issues arise in almost all efforts to make use of preexisting lexical resources for computational purposes (Briscoe and Carroll 1997), so none of the above comments should be taken as criticisms of Levin’s achievement.
A97-1052
Unlike Schulte im Walde (2000) and Merlo and Stevenson (2001), we ignore information about the arguments of a given verb in the form of either selectional restrictions or argument structure while building our prior models.
J01-3003
Cooccurrences and windows of large sizes traditionally work well for topical distinctions (Gale, Church, and Yarowsky 1992b).
P92-1032
Another approach put forward by Dorr and Jones (1996) utilizes WordNet (Miller and Charles 1991) to find similarities (via synonymy) between unknown verbs and verbs listed in Levin.
C96-1055
Unlike Stevenson and Merlo, Schulte im Walde, and Dorr and Jones (1996), we provide a general probabilistic model that assigns a probability to each class of a given verb by calculating the probability of a complex expression in terms of the probability of simpler expressions that compose it.
C96-1055
Levin’s inventory of verbs and classes has been also useful for applications such as machine translation (Dorr 1997; Palmer and Wu 1995), generation (Stede 1998), information retrieval (Levow, Dorr, and Lin 2000), and document classification (Klavans and Kan 1998).
J98-3003 P98-1112
66 Computational Linguistics Volume 30, Number 1 Dang et al.(1998) observe that verbs in Levin’s (1993) database are listed in more than one class.
P98-1046
Previous work in word sense disambiguation has not tackled explicitly the ambiguity problems arising from Levin’s classification, although methods for deriving informative priors in an unsupervised manner have been proposed by Ciaramita and Johnson (2000) and Chao and Dyer (2000) within the context of noun and adjective sense disambiguation, respectively.
C00-1023 C00-1028
A variety of classifiers have been employed for this task (see Mooney [1996] and Ide and Veronis [1998] for overviews), the most popular being decision lists (Yarowsky 1994, 1995) and naive Bayesian classifiers (Pedersen 2000; Ng 1997; Pedersen and Bruce 1998; Mooney 1996; Cucerzan and Yarowsky 2002).
A00-2009 J98-1001 P94-1013 P95-1026 W02-1005 W96-0208 W97-0323
Ciaramita and Johnson (2000) propose an unsupervised Bayesian model for disambiguating verbal objects that uses WordNet’s inventory of senses.
C00-1028
Palmer (2000) and Dang et al.(1998) argue that syntactic frames and verb classes are useful for developing principled classifications of verbs.
P98-1046
8. Related Work Levin’s (1993) seminal study on diathesis alternations and verb semantic classes has recently influenced work in dictionary creation (Dorr 1997; Dang et al.1998; Dorr and Jones 1996) and notably lexicon acquisition on the basis of the assumption that verbal meaning can be gleaned from corpora using cues pertaining to syntactic structure (Merlo and Stevenson 2001; Schulte im Walde 2000; Lapata 1999; McCarthy 2000).
A00-2034 C96-1055 J01-3003 P98-1046 P99-1051
