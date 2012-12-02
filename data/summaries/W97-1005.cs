(Brill and Resnik, 1994) suggested a rule based approach where the antecedent of each rule specifies values for the feature variables in (4).
C94-2195
Analysis The approach of (Collins and Brooks, 1995) is simpler than MS1, since it doesn't consist of any learning part; the models were selected and grouped by its designers and ordered heuristically, which means classification requires prior knowledge specific to the domain.
W95-0103
Using a hierarchical log-linear model containing only second order interactions, he achieved a classification performance comparable to that of (Hindle and Rooth, 1993).
J93-1005
The performance differences between MS1 and C&B, the Back-off Model by (Collins and Brooks, 1995), are 0.4% for IBM data and 0.7% for B~R data.
W95-0103
For example, (Brill and Resnik, 1994) ordered rules to minimize the error-rate in PPA classification.
C94-2195
Both data were extracted from the Penn Treebank Wall Street Journal (WSJ) Corpus (Marcus et al., 1993).
J93-2004
CK:B:(Collins and Brooks, 1995); B~R: (data/classifier) by (Srill and Resnik, 1994); IBM: (data/classifier) by (Ratnaparkhi et al., 1994); Bayes: Naive Bayes with defaults, i.e., A/\[ = (AB.AC.AD.AE, A).
H94-1048 W95-0103
MS1 and the systems by (Ratnaparkhi et al., 1994) and (Brill and Resnik, 1994) consist of a training phase, where they form certain structures (such as rules, models, etc).
C94-2195 H94-1048
I~(A\]B, C, D, E) = I(A,B,C,D)+ I(A,B,D,E)+ \](A,C,D,E) \](B, C, D) + I(B, D, E) + \](C, D, E) (12) f(A = 1) f(A = 2) "1 max f(A=~)+~=2)' f(A--'~)~-?~--2) (10) The lower bound for the B&R data is 63% (Brill and Resnik, 1994) and for the IBM data is 52% (Ratnaparkhi et al., 1994).
C94-2195 H94-1048
While (Hindle and Rooth, 1993) stated that this approach was not successful in estimating PPA using small 2-tuple frequencies, which comprised a major portion of the PPA data, the accuracy reported was 79.7%, which is a substantial improvement over the lower bound of 65% (10): tions used in the function).
J93-1005
(Ratnaparkhi et al., 1994) reported that human experts could reach an accuracy of 93%, if cases were given as whole sentences out of context.
H94-1048
On the other hand in systems designed by (Hindle and Rooth, 1993), (Collins and Brooks, 1995), and (Franz, 1996), the forms of models were predetermined by their designers, as in the Naive Bayes approach.
J93-1005 W95-0103
(Collins and Brooks, 1995) ordered heuristic decision functions by complexity (arity) and classified test instances with the most complex applicable function.
W95-0103
Notice that this is also a type of model switching, where the forms of the models and the model list M = (AB.AC.AD.AE, A) are predetermined as done by (Collins.and Brooks, 1995).
W95-0103
(Ratnaparkhi et al., 1994) was the first to considered the full four feature set defined in (4).
H94-1048
MS1 is a machine learning alternative to the system developed by (Collins and Brooks, 1995), and the ordering of the models that it produces may provide insight into the data that could aid in developing a custom mixture model.
W95-0103
(Collins and Brooks, 1995) proposed a specific heuristic computation to predict PPAs.
W95-0103
The approach made use of a maximum entropy model (Berger et al., 1996) formulated from frequency information for various combinations of the observed features.
J96-1002
7(Ratnaparkhi et al., 1994) reported a decision tree experiment using mutual information with 77.7% accuracy.
H94-1048
They also duplicated the experiment of (Hindle and Rooth, 1993), which scored around 5% less than the rule-based approach.
J93-1005
Analysis Statistical (decomposable) model selection techniques were first applied to NLP problems by (Bruce and Wiebe, 1994).
P94-1020
This was one of the most important heuristic steps in formulating the approach used by (Collins and Brooks, 1995).
W95-0103
Statistical and information theoretic approaches (Hindle and Rooth, 1993), (Ratnaparkhi et al., 1994),(Collins and Brooks, 1995), (Franz, 1996) Using lexical collocations to determine PPA with statistical techniques was first proposed by (Hindle and Rooth, 1993).
H94-1048 J93-1005 W95-0103
We use the PPA data created by (Brill and Resnik, 1994) and (Ratnaparkhi et al., 1994) to objectively compare the performances of the systems.
C94-2195 H94-1048
Rule based systems (Boggess et al., 1991), (Brill and Resnik, 1994) 2.
C94-2195
