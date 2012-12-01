In addition, we exploit syntactic constructions shown to be useful by other studies — lists and conjunctions (Roark and Charniak, 1998), and adjacent words (Riloff and Shepherd, 1997).
P98-2182 W97-0313
of EM, co-training, and co-EM Naive Bayes classifier To instantiate EM, co-training, and co-EM, we use a standard Naive Bayes classifier, as it is often used for co-training experiments, e.g., (Nigam and Ghani, 2000; Pierce and Cardie, 2001).
W01-0501
Pierce and Cardie (2001) investigate the scalability of co-training on the base noun phrase bracketing task, which typically requires a larger number of labeled examples than text categorization.
W01-0501
Abney (2002) presents an analysis to relax the (fairly strong) conditional independence assumption to weak rule dependence.
P02-1046
(Riloff and Shepherd, 1997; Roark and Charniak, 1998; Thelen and Riloff, 2002; Phillips and Riloff, 2002).
P98-2182 W02-1017 W02-1028 W97-0313
9We also tested Pierce and Cardie (2001)’s modification to choose examples according to the label distribution, but it did not make any significant difference.
W01-0501
In Section 5, we report experiments using syntactic features shown to be useful by the above studies, and compare performance with Thelen and Riloff (2002)’s bootstrapping method.
W02-1028
algorithms We use the following algorithms as baseline: EM, cotraining, and co-EM, as established techniques for learning from unlabeled data in general; the bootstrapping method proposed by Thelen and Riloff (2002) (hereafter, TRB and TR) as a state-of-the-art bootstrapping method designed for semantic lexicon construction.
W02-1028
methods for constructing semantic lexicons A common trend for the semantic lexicon construction task is that of bootstrapping, exploiting strong syntactic cues — such as a bootstrapping method that iteratively grows seeds by using cooccurrences in lists, conjunctions, and appositives (Roark and Charniak, 1998); metabootstrapping which repeatedly finds extraction patterns and extracts words from the found patterns (Riloff and Jones, 1999); a co-training combination of three bootstrapping processes each of which exploits appositives, compound nouns, and ISA-clauses (Phillips and Riloff, 2002).
P98-2182 W02-1017
We also note that there are a number of bootstrapping methods successfully applied to text – e.g., word sense disambiguation (Yarowsky, 1995), named entity instance classification (Collins and Singer, 1999), and the extraction of ‘parts’ word given the ‘whole’ word (Berland and Charniak, 1999).
P95-1026 P99-1008 W99-0613
Thelen and Riloff (2002)’s bootstrapping method iteratively performs feature selection and word selection for each class.
W02-1028
