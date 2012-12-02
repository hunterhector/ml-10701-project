To compare the proposed twin model with simple thresholding (Soon et al., 2001; Ng and Cardie, 2002b), 3The official evaluation document can be found at: www.nist.gov/speech/tests/ace/ace05/doc/ ace05-evalplan.v3.pdf.
C02-1139 J01-4004 P02-1014
Thus, we organize hypotheses into a Bell Tree (Luo et al., 2004) and use a beam search with the following pruning strategy: first, a maximum beam size (typically 20) S is set, and we keep only the top S hypotheses; Second, a relative threshold r (we use 10−5) is set to prune any hypothesis whose score divided by the maximum score falls below the threshold.
P04-1018
This is different from (Ng and Cardie, 2002a; Ng, 2004) where their anaphoricty models are trained independently of the coreference model, and it is either used as a pre-filter, or its output is used as features in the coreference model.
C02-1139 P02-1014 P04-1020
Ng and Cardie (2002a) trains a separate anaphoricity classifier in addition to a coreference model.
C02-1139 P02-1014
In a typical machine learning-based coreference resolution system (Soon et al., 2001; Ng and Cardie, 2002b; Yang et al., 2003; Luo et al., 2004), a statistical model is learned from training data and is used to measure how likely an anaphor 1 is coreferential to a candidate antecedent.
C02-1139 J01-4004 P02-1014 P03-1023 P04-1018 P04-1020
Bean and Riloff (1999) extracts rules from non-anaphoric noun phrases and noun phrases patterns, which are then applied to test data to identify existential noun phrases.
P99-1048
Poesio et al.(2004) contains a good summary of recent research work on discourse new or anaphoricity.
W04-0707
The creation model Pc( jEt, mt) proposed here bears similarity to the starting model 75 in (Luo et al., 2004).
P04-1018
We will concentrate on features used in the creation model since those in the link model can be found in the literature (Soon et al., 2001; Ng and Cardie, 2002b; Yang et al., 2003; Luo et al., 2004).
C02-1139 J01-4004 P02-1014 P03-1023 P04-1018 P04-1020
Work Some earlier work (Lappin and Leass, 1994; Kennedy and Boguraev, 1996) use heuristic to determine whether a phrase is anaphoric or not.
C96-1021 J94-4002
Nicolae and Nicolae (2006) constructs a graph where mentions are nodes and an edge represents the likelihood two mentions are in an entity, and then a graph-cut algorithm is employed to produce final coreference results.
W06-1633
But there is a crucial difference: the starting model in (Luo et al., 2004) is an ad-hoc use of the link scores and is not learned automatically, while Pc( jEt, mt) is fully trained.
P04-1018
Ng (2004) studies what is the best way to make use of anaphoricity information and concludes that the constrained-based and globallyoptimized approach works the best.
P04-1020
As an improvement, Ng and Cardie (2002a) and Ng (2004) train a separate model to classify an anaphor as either anaphoric or non-anaphoric.
C02-1139 P02-1014 P04-1020
Once the set of features functions are selected, algorithm such as improved iterative scaling (Berger et al., 1996) or sequential conditional generalized iterative scaling (Goodman, 2002) can be used to find the optimal parameter values of fλkg and fνig.
J96-1002 P02-1002
The output of this classifier can be used either as a pre-filter (Ng and Cardie, 2002a) so that non-anaphoric anaphors will not be precessed in the coreference system, or as a set of features in the coreference model (Ng, 2004).
C02-1139 P02-1014 P04-1020
In (Soon et al., 2001; Ng and Cardie, 2002b), the problem is treated by thresholding the scores returned by the coreference model.
C02-1139 J01-4004 P02-1014
Luo et al.(2004) uses a start model to determine whether a mention is the first one in a coreference chain, but it is computed ad hoc without training.
P04-1018
3.1 Feature Structure To implement the twin model, we adopt the log linear or maximum entropy (MaxEnt) model (Berger et al., 1996) for its flexibility of combining diverse sources of information.
J96-1002
See (Luo and Zitouni, 2005) and (Daum´e III and Marcu, 2005).
H05-1083
For example, syntactic features (Ng and Cardie, 2002b; Luo and Zitouni, 2005) can be computed this way and are used in our system.
C02-1139 H05-1083 P02-1014
