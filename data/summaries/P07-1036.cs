In many cases, improving semi-supervised models was done by seeding these models with domain information taken from dictionaries or ontology (Cohen and Sarawagi, 2004; Collins and Singer, 1999; Haghighi and Klein, 2006; Thelen and Riloff, 2002).
N06-1041 W02-1001 W02-1028 W99-0613
Another way to look the algorithm is from the self-training perspective (McClosky et al., 2006).
N06-1020
Therefore, an increasing attention has been recently given to semi-supervised learning, where large amounts of unlabeled data are used to improve the models learned from a small training set (Collins and Singer, 1999; Thelen and Riloff, 2002).
W02-1001 W02-1028 W99-0613
Since the elds are typically related and interdependent, these kinds of applications provide a good test case for an approach like ours.1 The rst task is to identify elds from citations (McCallum et al., 2000). The data originally included 500 labeled references, and was later extended with 5,000 unannotated citations collected from papers found on the Internet (Grenager et al., 2005).
P05-1046
For the citation domain, when 20 labeled and 300 unlabeled samples are available, (Grenager et al., 2005) observed an increase from 65.2% to 71.3%.
P05-1046
For example, (Grenager et al., 2005) proposes Diagonal Transition Models for sequential labeling tasks where neighboring words tend to have the same labels.
P05-1046
This decomposition applies both to discriminative linear models and to generative models such as HMMs and CRFs, in which case the linear sum corresponds to log likelihood assigned to the input/output pair by the model (for details see (Roth, 1999) for the classi cation case and (Collins, 2002) for the structured case).
W02-1001
(Punyakanok et al., 2005; Toutanova et al., 2005; Roth and Yih, 2005).
P05-1073
(Haghighi and Klein, 2006) extends the dictionarybased approach to sequential labeling tasks by propagating the information given in the seeds with contextual word similarity.
N06-1041
On the other hand, in the supervised setting, it has been shown that incorporating domain and problem speci c structured information can result in substantial improvements (Toutanova et al., 2005; Roth and Yih, 2005).
P05-1073
The second problem we consider is extracting elds from advertisements (Grenager et al., 2005).
P05-1046
We implement some global constraints and include unary constraints which were largely imported from the list of seed words used in (Haghighi and Klein, 2006).
N06-1041
We note that in the presence of constraints, the inference procedure (for nding the output y that maximizes the cost function) is usually done with search techniques (rather than Viterbi decoding, see (Toutanova et al., 2005; Roth and Yih, 2005) for a discussion), we chose beamsearch decoding.
P05-1073
(Haghighi and Klein, 2006) also worked on one of our data sets.
N06-1041
(Grenager et al., 2005) and (Haghighi and Klein, 2006) also report results for semi-supervised learning for these domains.
N06-1041 P05-1046
This was used, for example, by (Thelen and Riloff, 2002; Collins and Singer, 1999) in information extraction, and by (Smith and Eisner, 2005) in POS tagging.
P05-1044 W02-1028 W99-0613
