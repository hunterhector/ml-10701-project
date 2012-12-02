We viewed the seed word as a classified “sentence,” following a similar proposal in Yarowsky (1995).
P95-1026
2: Yarowsky’s Words We also conducted translation on seven of the twelve English words studied in Yarowsky (1995).
P95-1026
They include those using naive Bayes (Gale, Church, and Yarowsky 1992a), decision lists (Yarowsky 1994), nearest neighbor (Ng and Lee 1996), transformation-based learning (Mangu and Brill 1997), neural networks (Towell and Voorhees 1998), Winnow (Golding and Roth 1999), boosting (Escudero, Marquez, and Rigau 2000), and naive Bayesian ensemble (Pedersen 2000).
A00-2009 H92-1045 J98-1005 P94-1013 P96-1006
Yarowsky (1995) has proposed a bootstrapping method for word sense disambiguation.
P95-1026
Yarowsky (1995) proposed such a method for word sense disambiguation, which we refer to as monolingual bootstrapping.
P95-1026
It actually employs naive Bayesian ensemble rather than naive Bayes, because naive Bayesian ensemble generally performs better than naive Bayes (Pedersen 2000).
A00-2009
Banko and Brill 2001; Pierce and Cardie 2001).
P01-1005 W01-0501
For other related work on translation disambiguation, see Brown et al.(1991), Bruce and Weibe (1994), Dagan and Itai (1994), Lin (1997), Pedersen and Bruce (1997), Schutze (1998), Kikui (1999), Mihalcea and Moldovan (1999), Koehn and Knight (2000), and Zhou, Ding, and Huang (2001).
A00-2009 J94-4003 P91-1034 P94-1020 P97-1009 P99-1020 W97-0322 W99-0905
Lists Let us first consider the use of decision lists, as proposed in Yarowsky (1994).
P94-1013
Pedersen 2000).
A00-2009
data set consists mainly of articles from the Wall Street Journal and is prepared for conducting word sense disambiguation (WSD) on the two words (e.g., Pedersen 2000).
A00-2009
This implementation is exactly the one proposed in Yarowsky (1995).
P95-1026
2.5 Co-training Monolingual bootstrapping augmented with the one-sense-per-discourse heuristic can be viewed as a special case of co-training, as proposed by Blum and Mitchell (1998) (see also Collins and Singer 1999; Nigam et al.2000; and Nigam and Ghani 2000).
W99-0613
Note that the results of MB-D here cannot be directly compared with those in Yarowsky (1995), because the data used are different.
P95-1026
After line 17, we can employ the one-sense-per-discourse heuristic to further classify unclassified data, as proposed in Yarowsky (1995).
P95-1026
The naive Bayesian ensemble method for word sense disambiguation, as proposed in Pedersen (2000), employs a linear combination of several naive Bayesian classifiers constructed on the basis of a number of nested surrounding contexts 4 P(t ε | e ε )= 1 h h summationdisplay i=1 P(t ε | e prime ε,i ) e prime ε,1 ⊂···⊂e prime ε,i ···⊂e prime ε,h = e prime ε (i = 1,..., h) The naive Bayesian ensemble is reported to perform the best for word sense disambiguation with respect to a benchmark data set (Pedersen 2000).
A00-2009
It also adopts the one-sense-per-discourse heuristic (Gale, Church, and Yarowsky 1992b) in classifying unclassified sentences.
H92-1045
