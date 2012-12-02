Algorithm Our method is modeled on the approach developed by Stevenson and Greenwood (2005) but uses a different technique for ranking candidate patterns.
P05-1047
We set α to 5, β to 20, γ to 15, δ to 5, and used the following linguistic processing tools: (1) the OpenNLP library (opennlp.sourceforge.net) for sentence splitting and named-entity recognition, and (2) Connexor for syntactic parsing (Tapanainen and J�rvinen, 1997).
A97-1011
Stevenson and Greenwood (2005) propose a weakly supervised approach to sentence filtering that uses semantic similarity and bootstrapping to acquire IE patterns.
P05-1047
For the classifier, we used the OpenNLP MaxEnt implementation (maxent.sourceforge.net) of the maximum entropy classification algorithm (Berger et al.1996). We used the MUC-6 data set as the testing ground for our proposed approach.
J96-1002
For example, Aone and Ramos-Santacruz (2000) present a rule-based IE system which handles 100 types of relations and events.
A00-1011
This is a significant improvement over the 0.58 F-measure score 171 reported by Stevenson and Greenwood (2005) for the same task.
P05-1047
Riloff (1996), Yangarber et al.(2000), and Sekine (2006).
C00-2136 P06-2094
of Features Used Stevenson and Greenwood (2005) use subjectverb-object triples for their features.
P05-1047
