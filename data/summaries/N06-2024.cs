Recently, sequential learning methods, such as hidden Markov models (HMMs) and conditional random fields (CRFs), have been used successfully for a number of applications, including NER (Sha and Pereira, 2003; Pinto et al., 2003; Mccallum and Lee, 2003).
N03-1028
Culotta and McCallum (2004) suggest several methods for doing this with CRFs.
N04-4028
Collins. 2002.
W02-1001
(Culotta and McCallum, 2004) suggest several ways to generate confidence estimation in this framework.
N04-4028
Further details about these datasets are available elsewhere (Minkov et al., 2005).
H05-1056
MUC-6 347 30 204,071 6.8 Enron 833 143 204,423 3.0 Mgmt-Groups 631 128 104,662 3.7 Table 1: Summary of the corpora used in the experiments We used an implementation of Collins’ votedpercepton method for discriminatively training HMMs (henceforth, VP-HMM) (Collins, 2002) as well as CRF (Lafferty et al., 2001) to learn a NER.
W02-1001
