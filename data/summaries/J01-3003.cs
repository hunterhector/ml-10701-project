For example, Merlo and Stevenson (1998) show that, contrary to the naive assumption, speakers' preferences in syntactic disambiguation are not simply directly related to frequency (i.e., a speaker's preference for one construction over another is not simply modelled by the frequency of the construction, or of the words in the construction).
W98-1116
In future research we plan to extend our method to the case of ambiguous tokens, by experimenting with the combination of several sources of information: the classification of each instance will be a function of a bias for the verb type (using the cross-corpus statistics we collect), but also of features of the usage of the instance being classified (cf., Lapata and Brew \[1999\]; Siegel \[1998\]).
P99-1051 W99-0632
McCarthy (2000) proposes a method to identify diathesis alternations.
A00-2034
Using combinations of seven statistical indicators (some morphological and some reflecting syntactic cooccurrences), it is possible to learn the distinction between events and states for 739 verb tokens with an improvement of 10% over the baseline (error rate reduction of 74%), and to learn the distinction between culminated and non-culminated events for 308 verb tokens with an improvement of 11% (error rate reduction of 29%) (Siegel 1999).
P99-1015
Others have tackled the problem of lexical semantic classification, but using only subcategorization frequencies as input data (Lapata and Brew 1999; Schulte im Walde 2000).
P99-1051 W99-0632
Because knowledge of argument structure captures fundamental participant/event relations, it is crucial in parsing and generation (e.g., Srinivas and Joshi \[1999\]; Stede \[1998\]), in machine translation (Dorr 1997), and in information retrieval (Klavans and Kan 1998) and extraction (Riloff and Schmelzenbach 1998).
J98-3003 P98-1112 W98-1106
In answering these questions, some approaches to lexical acquisition have focused on learning syntactic information about verbs, by automatically extracting subcategorization frames from a corpus or machine-readable dictionary (Brent 1993; Briscoe and Carroll 1997; Dorr 1997; Lapata 1999; Manning 1993; McCarthy and Korhonen 1998).
A97-1052 J93-2002 P93-1032 P98-2247 P99-1051 W99-0632
Moreover, recall that our training and testing sets are always disjoint (cf., Lapata and Brew \[1999\]; Siegel \[1999\]); in other words, we are predicting the classification of verbs that were never seen in the training corpus, the hardest situation for a classification algorithm.
P99-1015 P99-1051 W99-0632
Siegel's work on automatic aspectual classification (1998, 1999) also reveals a close relationship between verb-related syntactic and semantic information.
P99-1015
We think that many cases of ambiguous classification of the lexical entry for a verb can be addressed with the notion of intersective sets introduced by Dang et al.(1998). This is an important concept, which proposes that "regular" ambiguity in classification--i.e., sets of verbs that have the same multi-way classifications according to Levin (1993)--can be captured with a finer-grained notion of lexical semantic classes.
P98-1046
For example, Dorr (1997) summarizes a number of automatic classification experiments based on encoding Levin's alternations directly, as symbolic properties of a verb (Dorr, Garman, and Weinberg 1995; Dorr and Jones 1996).
C96-1055
McCarthy (2000) shows that a method very similar to ours can be used for identifying alternations.
A00-2034
Carletta (1996) cites the convention from the domain of content analysis indicating that .67 K K < .8 indicates marginal agreement, while K > .8 is an indication of good agreement.
J96-2004
On the other hand, our approach is similar to the approaches of Siegel, and Lapata and Brew (1999), in attempting to learn semantic notions from distributions of 12 A baseline of 5% is reported, based on a closest-neighbor pairing of verbs, but it is not straightforward to compare this task to the proposed clustering algorithm.
P99-1015 P99-1051 W99-0632
Other work has attempted to learn deeper semantic properties such as selectional restrictions (Resnik 1996; Riloff and Schmelzenbach 1998), verbal aspect (Klavans and Chodorow 1992; Siegel 1999), or lexical-semantic verb classes such as those proposed by Levin (1993) (Aone and McKee 1996; McCarthy 2000; Lapata and Brew 1999; Schulte im Walde 2000).
A00-2034 C92-4177 P99-1015 P99-1051 W98-1106 W99-0632
However, when we turn to consider ambiguity, we must also address the problem that individual instances of verbs may come from different classes, and we may (like Lapata and Brew \[1999\]) want to classify the individual tokens of a verb.
P99-1051 W99-0632
On the other hand, when learning of thematic role assignment has been the explicit goal, the text has been semantically annotated (Webster and Marcus 1989), or external semantic resources have been consulted (Aone and McKee 1996; McCarthy 2000).
A00-2034 P89-1022
To date, most work in this area has focused on learning of subcategorization from unannotated or syntactically annotated text (e.g., Brent \[1993\]; Sanfilippo and Poznanski \[1992\]; Manning \[1993\]; Collins \[1997\]).
A92-1011 J93-2002 P93-1032 P97-1003
We, like others in a computational framework, have extended this idea by showing that statistics over the alternants of a verb effectively capture information about its class (Lapata 1999; McCarthy 2000; Lapata and Brew 1999).
A00-2034 P99-1051 W99-0632
In work on lexical semantic verb classification, Lapata and Brew (1999) further support the thesis of a predictive correlation between syntax and semantics in a statistical framework, showing that the frequency distributions of subcategorization frames within and across classes can disambiguate the usages of a verb with more than one known lexical semantic class.
P99-1051 W99-0632
This corpus of 29 million words was provided to us by Michael Collins, and was automatically parsed with the parser described in Collins (1997).
P97-1003
Furthermore, in contrast to Siegel (1998) and Lapata and Brew (1999) our method applies successfully to previously unseen words--i.e., test cases that were not represented in the training set.
P99-1015 P99-1051 W99-0632
Methodology In pilot experiments on a subset of the features, we investigated a number of supervised machine learning methods that produce automatic classifiers (decision tree induction, rule learning, and two types of neural networks), as well as hierarchical clustering; see Stevenson et al.(1999) for more detail.
W99-0503
Our method was applied to 23 million words of the WSJ that were automatically tagged with Ratnaparkhi's maximum entropy tagger (Ratnaparkhi 1996) and chunked with the partial parser CASS (Abney 1996).
W96-0213
Furthermore, it appears that the classes capture typological distinctions that are useful for machine translation (for example, causative unergatives are ungrammatical in many languages), as well as processing distinctions that are useful for generating naturally occurring language (for example, reduced relatives with unergative verbs are awkward, but they are acceptable, and in fact often preferred to full relatives for unaccusative and object-drop verbs) (Stevenson and Merlo 1997b; Merlo and Stevenson 1998).
W98-1116
Many recent results, however, seem to converge in supporting the view that the relation between lexical syntax and semantics can be usefully exploited (Aone and McKee 1996; Dorr 1997; Dorr, Garman, and Weinberg 1995; Dorr and Jones 1996; Lapata and Brew 1999; Schulte im Walde 2000; Siegel 1998; Siegel 1999).
C96-1055 P99-1015 P99-1051 W99-0632
