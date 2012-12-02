The superiority of discriminative models has been shown on many tasks when the discriminative and generative models use exactly the same model structure (Klein and Manning, 2002).
W02-1002
State-of-the-art models for the subproblem of classification of core arguments additionally use other features of individual nodes (Xue and Palmer, 2004; Pradhan et al., 2005a), as well as global features including the labels of other nodes in parse tree.
J05-1004 P05-1072 W04-3212
Hybrid models have been proposed before and shown to perform very competitively (Raina et al., 2004; Och and Ney, 2002).
P02-1038
These include models for part-of-speech tagging (Toutanova et al., 2003), semantic-role labeling (Punyakanok et al., 2005; Pradhan et al., 2005b) and Penn Treebank parsing (Charniak and Johnson, 2005).
N03-1033 P05-1022 P05-1072 P05-1073
to Related Work Previous work has compared generative and discriminative models having the same structure, such as the Naive Bayes and Logistic regression models (Ng and Jordan, 2002; Klein and Manning, 2002) and other models (Klein and Manning, 2002; Johnson, 2001).
P01-1042 W02-1002
It is extracted from the the Penn Treebank Wall Street Journal data (Ratnaparkhi et al., 1994).
H94-1048
Following most of the literature on prepositional phrase attachment (e.g., (Hindle and Rooth, 1993; Collins and Brooks, 1995; Vanschoenwinkel and Manderick, 2003)), we focus on the most common configuration that leads to ambiguities: V NP PP.
J93-1005 W95-0103
Additionally, many discriminative models use a generative model as a base model and add discriminative features with reranking (Collins, 2000; Charniak and Johnson, 2005; Roark et al., 2004), or train discriminatively a small set of weights for features which are generatively estimated probabilities (Raina et al., 2004; Och and Ney, 2002).
P02-1038 P04-1007 P05-1022
To put our results in the context of previous work, other results on core arguments using the same input features have been reported, the best being 91.4% for an SVM with a degree 2 polynomial kernel (Pradhan et al., 2005a).3 The highest reported result for independent classification of core arguments is 96.0% for a log-linear model using more than 20 additional basic features (Toutanova et al., 2005).
P05-1072 P05-1073
parkhi et al., 1994; Collins and Brooks, 1995).
W95-0103
However, the advantage of the discriminative models can be very slight (Johnson, 2001) and for small training set sizes generative models can be better because they need fewer training samples to converge to the optimal parameter setting (Ng and Jordan, 2002).
P01-1042
The second task we concentrate on is semantic role labeling in the context of PropBank (Palmer et al., 2005).
J05-1004
In line with previous work (Ng and Jordan, 2002; Klein and Manning, 2002), we first compare Naive Bayes and Logistic regression on the two NLP tasks.
W02-1002
To avoid this problem, generative models for NLP tasks have often been manually designed to achieve an appropriate representation of the joint distribution, such as in the parsing models of (Collins, 1997; Charniak, 2000).
A00-2018 P97-1003
We use the standard training, development, and 580 Feature Types (Gildea and Jurafsky, 2002) PHRASE TYPE: Syntactic Category of node PREDICATE LEMMA: Stemmed Verb PATH: Path from node to predicate POSITION: Before or after predicate?
J02-3001
Initially, 7 features were proposed by (Gildea and Jurafsky, 2002), and all following research has used these features and some additional ones.
J02-3001
There has been plenty of work on machine learning models for semantic role labeling, starting with the work of Gildea and Jurafsky (2002), and including CoNLL shared tasks (Carreras and M`arquez, 2005).
J02-3001 W05-0620
This kind of smoothing has also been used in the generative parser of (Collins, 1997) and has been shown to have a relatively good performance for language modeling (Goodman, 2001).
P97-1003
Other researchers have also looked at this subproblem (Gildea and Jurafsky, 2002; Toutanova et al., 2005; Pradhan et al., 2005a; Xue and Palmer, 2004).
J02-3001 P05-1072 P05-1073 W04-3212
