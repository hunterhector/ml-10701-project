Yarowsky. 1994.
P94-1013
172 one hand, WSD is very dependant to the domain of application (Gale et al., 1992b) --see also (Ng and Lee, 1996; Ng, 1997a), in which quite different accuracy figures are obtained when testing an exemplar-based WSD classifier on two different corpora.
P92-1032 P96-1006 W97-0201 W97-0323
Many standard M L algorithms for supervised learning have been applied, such as: Decision Lists (¥arowsky, 1994; Agirre and Martinez, 2000), Neural Networks (Towell and Voorhees, 1998), Bayesian learning (Bruce and Wiebe, 1999), Exemplar-Based learning (Ng, 1997a; Fujii et al., 1998), Boosting (Escudero et al., 2000a), etc.
J98-1005 J98-4002 J99-2002 W97-0201 W97-0323
To avoid the effect of zero counts when estimating probabilities, a very simple smoothing technique has been used, which was proposed in (Ng, 1997a).
W97-0201 W97-0323
Ng. 1997b.
W97-0201 W97-0323
Although this methodology could be valid for certain NLP problems, such as English Part-of-Speech tagging, we think that there exists reasonable evidence to say that, in WSD, accuracy results cannot be simply extrapolated to other domains (contrary to the opinion of other authors (Ng, 1997b)): On the aSupervised approaches, also known as data-driven or corpus-dmven, are those that learn from a previously semantically annotated corpus.
W97-0201 W97-0323
(Ng, 1997b) estimates that the manual annotation effort necessary to build a broad coverage semantically annotated English corpus is about 16 personyears.
W97-0201 W97-0323
Mooney. 1996.
W96-0208
Resolving the ambiguity of words is a central problem for large scale language understanding applications and their associate tasks (Ide and V4ronis, 1998), e.g., machine translation, information retrieval, reference resolution, parsing, etc.
J98-1001
This corpus was collected by Ng and colleagues (Ng and Lee, 1996) and it is available from the Linguistic Data Consortium (LDC) 5.
P96-1006
It is our belief that the research by (Leacock et al., 1998; Mihalcea and Moldovan, 1999) 2 provide enough evidence towards the "opening" of the bottleneck in the near future.
J98-1006
These weak 4In order to construct a real EB-based system for WSD, the k parameter should be estimated by crossvalidation using only the training set (Ng, 1997a), however, in our case, this cross-validation inside the cross-validation involved in the testing process would generate a prohibitive overhead.
W97-0201 W97-0323
Exemplar-based learning is said to be the best option for VSD (Ng, 1997a).
W97-0201 W97-0323
SThe second and third column correspond to the train and test sets used by (Ng and Lee, 1996; Ng, 1997a) • Regarding the portability of the systems, very disappointing results are obtained.
P96-1006 W97-0201 W97-0323
7The already described set of attributes contains those attributes used in (Ng and Lee, 1996), with the exception of the morphology of the target word and the verb-object syntactic relation.
P96-1006
To date, a thorough study of the domain dependence of WSD --in the style of other studies devoted to parsing (Sekine, 1997)-has not been carried out.
A97-1015
Black bars = A corpus; Grey bars = B corpus nouns MFC verbs total nouns LB verbs total Accuracy (%) A+B-A+B A+B-B A-A 48.75±0.91 48.22±1 68 48.55±1 16 62.82±1.43 66.82±1.53 64.35±1.16 A+B-A 48.90±1.69 48.22±1.90 48.64±1.04 64.26±2.07 69.33±2.92 66.20±2.12 48.61±0.96 48.22±3 06 48.46±1.21 61.38±2.08 64.32±3.27 62.50±1.47 48.87±1 68 48.22±1.90 48.62±1.09 63.19±1.65 68.51±2.45 65.22±1.50 B-B A-B B-A 48.61±0.96 48.99 48.99 48.22±3.06 48.22 48.22 48.46±1.21 48.70 48.70 60.65±1.01 53.45 55.27 63.49±2.27 60.44 62.55 61.74±1.18 56.12 58.05 Table 3: Accuracy results (5= standard deviation) of LazyBoosting on the sense-balanced corpora Furthermore, these results are in contradiction with the idea of "robust broad-coverage WSD" introduced by (Ng, 1997b), in which a supervised system trained on a large enough corpora (say a thousand examples per word) ~hould provide accurate disambiguation on any corpora (or, at least significantly better than MFS).
W97-0201 W97-0323
Despite its simplicity, Naive Bayes is claimed to obtain state-of-theart accuracy on supervised WSD in many papers (Mooney, 1996; Ng, 1997a; Leacock et al., 1998).
J98-1006 W96-0208 W97-0201 W97-0323
Additionally, supervised methods suffer from the "knowledge acquisition bottleneck" (Gale et al., 1992a).
P92-1032
