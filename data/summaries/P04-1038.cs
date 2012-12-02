Assuming a verb has l senses, the clustering model assigns n instances of the verb into k clusters, i n is the size of the ith cluster, j n is the number of instances hand-tagged with the jth sense, and j i n is the number of instances with the jth sense in the ith cluster, purity is defined in equation (4): ∑ = = k i j i j n n purity 1 max 1 (4) 10 The sense-tagged PDN data we used here are the same as in (Dang et al., 2002).
C02-1143
The EM clustering algorithm (Hofmann and Puzicha, 1998) used here is an unsupervised machine learning algorithm that has been applied in many NLP tasks, such as inducing a semantically labeled lexicon and determining lexical choice in machine translation (Rooth et al., 1998), automatic acquisition of verb semantic classes (Schulte im Walde, 2000) and automatic semantic labeling (Gildea and Jurafsky, 2002).
J02-3001
Five verbs, the first five listed in Table 1, are both highly polysemous and difficult for a supervised word sense classifier (Dang et al., 2002).
C02-1143
