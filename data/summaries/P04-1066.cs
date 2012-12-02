Franz Josef Och et al.2004. A smorgasbord of features for statistical machine translation.
N04-1021
Moore. 2001.
W01-1411
This sort of “add-n” smoothing has a poor reputation in statistical NLP, because it has repeatedly been shown to perform badly compared to other methods of smoothing higher-order n-gram models for statistical language modeling (e.g., Chen and Goodman, 1996).
P96-1041
possible exception is suggested by the results of Koehn et al.(2003), which show that phrase translations extracted from Model 1 alignments can perform almost as well in a phrase-based statistical translation system as those extracted from more sophisticated alignment models, provided enough training data is used.
N03-1017
The trial and test data had been manually aligned at the word level, noting particular pairs of words either as “sure” or “possible” alignments, as described by Och and Ney (2003).
J03-1002
• For each target sentence position j ∈ {1,...,m}: – A generating word s i in S (including a null word s 0 ) is selected, and – The target word t j at position j is generated depending on s i. Model 1 is defined as a particularly simple instance of this framework, by assuming all possible lengths for T (less than some arbitrary upper bound) have a uniform probability epsilon1, all possible choices of source sentence generating words are equally likely, and the translation probability tr(t j |s i ) of the generated target language word depends only on the generating source language word—which Brown et al.(1993a) show yields the following equation: p(T|S)= epsilon1 (l +1) m m productdisplay j=1 l summationdisplay i=0 tr(t j |s i ) (1) Equation 1 gives the Model 1 estimate for the probability of a target sentence, given a source sentence.
H93-1039 J93-2003
IBM Model 1 (Brown et al., 1993a) is a wordalignment model that is widely used in working with parallel bilingual corpora.
H93-1039 J93-2003
However, it is not clear that AER as defined by Och and Ney (2003) is always the appropriate way to evaluate the quality of the model, since the Viterbi word alignment that AER is based on is seldom used in applications of Model 1.
J03-1002
This may be due in part to the fact that Brown et al.(1993a) proved that the log-likelihood objective function for Model 1 is a strictly concave function of the model parameters, so that it has a unique local maximum.
H93-1039 J93-2003
Brown et al.(1993a) stopped after only one iteration of EM in using Model 1 to initialize their Model 2, and Och and Ney (2003) stop after five iterations in using Model 1 to initialize the HMM word-alignment model.
H93-1039 J03-1002 J93-2003
See Moore (2004) for details.
W04-3243
Moore. 2004.
W04-3243
Furthermore, at the 2003 Johns Hopkins summer workshop on statistical machine translation, a large number of features were tested to discover which ones could improve a state-of-the-art translation system, and the only feature that produced a “truly significant improvement” was the Model 1 score (Och et al., 2004).
N04-1021
We chose this statistic because it has previously been found to be effective for automatically constructing translation lexicons (e.g., Melamed, 2000; Moore, 2001).
J00-2004 W01-1411
It is interesting to contrast our heuristic model with the heuristic models used by Och and Ney (2003) as baselines in their comparative study of alignment models.
J03-1002
To test whether a better set of initial parameter estimates can improve Model 1 alignment accuracy, we use a heuristic model based on the loglikelihood-ratio (LLR) statistic recommended by Dunning (1993).
J93-1003
The first of these nonstructural problems with Model 1, as standardly trained, is that rare words in the source language tend to act as “garbage collectors” (Brown et al., 1993b; Och and Ney, 2004), aligning to too many words in the target language.
H93-1039 J93-2003 N04-1021
Among the applications of Model 1 are segmenting long sentences into subsentental units for improved word alignment (Nevado et al., 2003), extracting parallel sentences from comparable corpora (Munteanu et al., 2004), bilingual sentence alignment (Moore, 2002), aligning syntactictree fragments (Ding et al., 2003), and estimating phrase translation probabilities (Venugopal et al., 2003).
N04-1034 P03-1041
We report the performance of our different versions of Model 1 in terms of precision, recall, and alignment error rate (AER) as defined by Och and Ney (2003).
J03-1002
and Evaluation We trained and evaluated our various modifications to Model 1 on data from the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
W03-0301
