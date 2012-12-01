To compute Precision, Recall, and Alignment Error Rate (AER), we adhere to the formulae listed in Och & Ney (2003).
J03-1002
Barzilay & Lee (2003) employ Multiple Sequence Alignment (MSA, e.g., Durbin et al., 1998) to align strings extracted from closely related news articles.
N03-1003
A growing body of recent research has focused on the problems of identifying and generating paraphrases, e.g., Barzilay & McKeown (2001), Lin & Pantel (2002), Shinyama et al, (2002), Barzilay & Lee (2003), and Pang et al.(2003). One promising approach extends standard Statistical Machine Translation (SMT) techniques (e.g., Brown et al., 1993; Och & Ney, 2000, 2003) to the problems of monolingual paraphrase identification and generation.
J03-1002 J93-2003 N03-1003 N03-1024 P00-1056 P01-1008
It seems probable that the effect of the 10K training corpus can be greatly augmented by adding sentence pairs that have been aligned from multiple translations using the techniques described in, e.g., Barzilay & McKeown (2001) and Pang et al.(2003). 6 Conclusions We have shown that supervised machine learning techniques such as SVMs can significantly expand available paraphrase corpora, and achieve a reduction of noise as measured by AER on non-identical words.
N03-1003 N03-1024 P01-1008
Although the MSA approach can produce dramatic results, it is chiefly effective in extracting highly templatic data, and appears to be of limited extensibility to broad domain application (Quirk et al.2004). Recent work by Dolan, et al.(2004) describes the construction of broad-domain corpora of aligned paraphrase pairs extracted from newscluster data on the World Wide Web using two heuristic strategies: 1) pairing sentences based on a word-based edit distance heuristic; and 2) a naive text-feature-based heuristic in which the first two sentences of each article in a cluster are cross-matched with each other, their assumption being that the early sentences of a news article will tend to summarize the whole article and are thus likely to contain the same information as other early sentences of other articles in the cluster.
C04-1051 W04-3219
Dolan & Brockett (2005) report extraction precision of 67% using a similar classifier, but with the explicit intention of creating a corpus that contained a significant number of naturallyoccuring paraphrase-like negative examples.
I05-5002
Following the practice of Och & Ney (2000, 2003), the annotators each created an initial annotation, categorizing alignments as either SURE (necessary) or POSSIBLE (allowed, but not required).
J03-1002 P00-1056
One 1 approach utilizes multiple translations of a single source language text, where the source language text guarantees semantic equivalence in the target language texts (e.g., Barzilay & McKeown, 2001; Pang et al., 2003).
N03-1003 N03-1024 P01-1008
Barzilay & Lee (2003) and Quirk et al.(2004) use human evaluations of end-to-end generation, but these are not very useful here, since they add an additional layer of uncertainty into the evaluation, and depend to a significant extent on the quality and functionality of the decoder.
N03-1003 W04-3219
The fact that the MSR training data does not perform as well as the 10 K training set probably reflects its derivative nature, since it was originally constructed with data collected using the 10K training set, as described in Dolan & Brockett (2005).
I05-5002
Since our purpose in the present work is nonapplication specific corpus construction, we apply an automated technique that is widely used for reporting intermediate results in the SMT community, and is being extended in other fields such as summarization (Daumé and Marcu, forthcoming), namely word-level alignment using an off-the-shelf implementation of the SMT system GIZA++ (Och & Ney, 2003).
J03-1002
operation|procedure operation|work Word Association Pairs: To augment the above resources, we dynamically extracted from the L12 corpus a lexicon of 13001 possibly-synonymous word pairs using a log-likelihood algorithm described in Moore (2001) for machine translation.
W01-1411
The word-based edit distance heuristic yields pairs that are relatively clean but offer relatively minor rewrites in generation, especially when compared to the MSA model of (Barzilay & Lee, 2003).
N03-1003
Quirk et al.(2004) describe an end-to-end paraphrase identification and generation system using GIZA++ (Och & Ney, 2003) and a monotone decoder to generate informationpreserving paraphrases.
J03-1002 W04-3219
The F2 dataset was constructed from the first two sentences of the corpus on the same assumptions as those used in Dolan et al.(2004). To avoid conflating the two data types, however, sentence pairs with an edit distance of 12 or less were excluded.
C04-1051
Moore. 2001.
W01-1411
Dolan. 2004.
C04-1051
