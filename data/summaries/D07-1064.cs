The external function f(x,y) returns a vector (called the global feature vector in (Sha and Pereira, 2003)) of the number of feature occurrences along the alignment path y.
N03-1028
We used several publicly available full parsers as baselines: (i) the Bikel parser (Bikel, 2005) version 0.9.9c with configuration file bikel.properties (denoted as Bikel/Bikel), (ii) the Bikel parser in the Collins parser emulation mode (using collins.properties file) (Bikel/Collins), and (iii) Charniak and Johnson’s reranking parser (Charniak-Johnson) (Charniak and Johnson, 2005).
P05-1022
Previous work on coordinations includes (Agarwal and Boggess, 1992; Chantree et al., 2005; Kuro∗ Equal contribution.
P92-1003
As mentioned earlier, both of these methods are based on Collins’s averaged-perceptron algorithm for sequence labeling (Collins, 2002).
W02-1001
Earlier studies (Agarwal and Boggess, 1992; Okumura and Muraki, 1994) attempted to find heuristic rules to disambiguate coordinations.
A94-1007 P92-1003
Collins’s method, like the linear-chain conditional random fields (CRFs) (Lafferty et al., 2001; Sha and Pereira, 2003), seeks for a complete path from the initial vertex to the terminal using the Viterbi algorithm.
N03-1028
The state space of our model resembles that of Kurohashi and Nagao’s Japanese coordination detection method (Kurohashi and Nagao, 1994).
J94-4001
in Charniak and Johnson’s recent work (Charniak and Johnson, 2005), for instance, two of the features incorporated in their parse reranker are aimed specifically at resolving coordination ambiguities.
P05-1022
Our learning method is an extension of Collins’s perceptron-based method for sequence labeling (Collins, 2002).
W02-1001
More recent research are concerned with capturing structural similarity between conjuncts using thesauri and corpora (Chantree et al., 2005), or web-based statistics (Nakov and Hearst, 2005).
H05-1105
This is contrastive to the one dimensional models used by Collins’s perceptronbased sequence method (Collins, 2002) which our algorithms are based upon, and by the linear-chain CRFs.
W02-1001
hashi and Nagao, 1994; Nakov and Hearst, 2005; Okumura and Muraki, 1994; Resnik, 1999).
A94-1007 H05-1105
