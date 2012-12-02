Cardie and Wagstaff (1999) report a performance of 53,6% F-measure (evaluated according to Vilain et al.(1995)). 2.2 Our Features We consider the features we use for our weakly supervised approach to be domain-independent.
M95-1005 W99-0611
Supervised machine learning algorithms were used for pronoun resolution with good results (Ge et al., 1998), and for definite NPs with fairly good results (Aone and Bennett, 1995; McCarthy and Lehnert, 1995; Soon et al., 2001).
J01-4004 P95-1017 W98-1119
They only used pairs of anaphors and their closest antecedents as positive examples in training, but evaluated according to Vilain et al.(1995). Cardie and Wagstaff (1999) describe an unsupervised clustering approach to noun phrase coreference resolution in which features are assigned to single noun phrases only.
M95-1005 W99-0611
McCarthy and Lehnert (1995) achieved results of about 86% F-measure (evaluated according to Vilain et al.(1995)) on the MUC-5 data set.
M95-1005
Hence, our results are only indirectly comparable with the ones obtained by an evaluation according to Vilain et al.(1995). However, in this paper we only compare results of this direct binary antecedentanaphor pair decision.
M95-1005
Soon et al.(2001) use twelve features (see Table 1).
J01-4004
Features like the string ident and substring match features were used by other researchers (Soon et al., 2001), while the features ante med and ana med were used by Strube et al.(2002) in order to improve the performance for definite NPs.
J01-4004 W02-1040
Aone and Bennett (1995), working on reference resolution in Japanese newspaper articles, use 66 features.
P95-1017
Among others Co-Training was applied to document classification (Blum and Mitchell, 1998), namedentity recognition (Collins and Singer, 1999), noun phrase bracketing (Pierce and Cardie, 2001), and statistical parsing (Sarkar, 2001).
N01-1023 W01-0501 W99-0613
– position (NPs are numbered sequentially) – pronoun type (nom., acc., possessive, ambiguous) – article (indefinite, definite, none) – appositive (yes, no) – number (singular, plural) – proper name (yes, no) – semantic class (based on WordNet: time, city, animal, human, object; based on a separate algorithm: number, money, company) – gender (masculine, feminine, either, neuter) – animacy (anim, inanim) Table 2: Features used by Cardie and Wagstaff The feature semantic class used by Cardie and Wagstaff (1999) seems to be a domain-dependent one which can only be used for the MUC domain and similar ones.
W99-0611
Aone and Bennett (1995) report that their best classifier achieved an F-measure of about 77% after training on 250 documents.
P95-1017
In Strube et al.(2002) we report results from other experiments for definite noun phrase reference resolution.
W02-1040
In previous work (Strube et al., 2002) we obtained quite different results for different types of anaphora, i.e. if we split the data according to the ana np feature into personal and possessive pronouns (PPER PPOS), proper names (NE), and definite NPs (def NP).
W02-1040
Decision tree algorithms were used for reference resolution by Aone and Bennett (1995, C4.5), McCarthy and Lehnert (1995, C4.5) and Soon et al.(2001, C5.0).
J01-4004 P95-1017
The texts were POS-tagged using TnT (Brants, 2000).
A00-1031
The reliability of the annotations was checked using the kappa statistic (Carletta, 1996).
J96-2004
It was criticized (Soon et al., 2001) that the features used by McCarthy and Lehnert (1995) are highly idiosyncratic and applicable only to one particular domain.
J01-4004
However, reference resolution algorithms based on these classifiers achieve reasonable performance of about 60 to 63% F-measure (Soon et al., 2001).
J01-4004
However, the cost is the decrease in performance to about 53% F-measure on the same data (Cardie and Wagstaff, 1999) which may be unsuitable for a lot of tasks.
W99-0611
A Co-Training classifier is complex in the sense that it consists of two simple classifiers (most often Naive Bayes, e.g. by Blum and Mitchell (1998) and Pierce and Cardie (2001)).
W01-0501
NPs) was obtained by using the NP-Chunker Chunkie (Skut and Brants, 1998).
W98-1117
Soon et al.(2001) include all noun phrases returned by their NP identifier and report an F-measure of 62.6% for MUC-6 data and 60.4% for MUC-7 data.
J01-4004
