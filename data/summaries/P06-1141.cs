Additionally, our approach makes it possible to do inference in just about twice the inference time with a single sequential CRF; in contrast, approaches like Gibbs Sampling that model the dependencies directly can increase inference time by a factor of 30 (Finkel et al., 2005).
P05-1045
Mikheev et al.(1999) exploit label consistency information within a document using relatively ad hoc multi-stage labeling procedures.
E99-1001
Malouf (2002) and Curran and Clark (2003) condition the label of a token at a particular position on the label of the most recent previous instance of that same token in a previous sentence of the same document.
W02-2019 W03-0424
Work Recent work looking to directly model non-local dependencies and do approximate inference are that of Bunescu and Mooney (2004), who use a Relational Markov Network (RMN) (Taskar et al., 2002) to explicitly model long-distance dependencies, Sutton and McCallum (2004), who introduce skip-chain CRFs, which add additional non-local edges to the underlying CRF sequence model (which Bunescu and Mooney (2004) lack) and Finkel et al.(2005) who hand-set penalties for inconsistency in labels based on the training data and then use Gibbs Sampling for doing approximate inference where the goal is to obtain the label sequence that maximizes the product of the CRF objective function and their penalty.
P04-1056 P05-1045
Chieu and Ng (2002) propose a solution to this problem: for each token, they define additional features based on known information, taken from other occurrences of the same token in the document.
C02-1025
We use the approximate randomization test (Yeh, 2000) for statistical significance of the difference between the basic sequential CRF and our second round CRF, which has additional features derived from the output of the first CRF.
C00-2137
• Most existing work to capture labelconsistency, has attempted to create all parenleftbign2parenrightbig pairwise dependencies between the different occurrences of an entity, (Finkel et al., 2005; Sutton and McCallum, 2004), where n is the number of occurrences of the given entity.
P05-1045
This also enables us to do inference efficiently since our inference time is merely the inference time of two sequential CRF’s; in contrast Finkel et al.(2005) reported an increase in running time by a factor of 30 over the sequential CRF, with their Gibbs sampling approximate inference.
P05-1045
At the same time, the simplicity of our two-stage approach keeps inference time down to just the inference time of two sequential CRFs, when compared to approaches such as those of Finkel et al.(2005) who report that their inference time with Gibbs sampling goes up by a factor of about 30, compared to the Viterbi algorithm for the sequential CRF.
P05-1045
Our approach helps correct many such errors based on occurrences of the token in other 1126 F1 scores on the CoNLL Dataset Approach LOC ORG MISC PER ALL Relative Error reduction Bunescu and Mooney (2004) (Relational Markov Networks) Only Local Templates 80.09 Global and Local Templates 82.30 11.1% Finkel et al.(2005)(Gibbs Sampling) Local+Viterbi 88.16 80.83 78.51 90.36 85.51 Non Local+Gibbs 88.51 81.72 80.43 92.29 86.86 9.3% Our Approach with the 2-stage CRF Baseline CRF 88.09 80.88 78.26 89.76 85.29 + Document token-majority features 89.17 80.15 78.73 91.60 86.50 + Document entity-majority features 89.50 81.98 79.38 91.74 86.75 + Document superentity-majority features 89.52 82.27 79.76 92.71 87.15 12.6% + Corpus token-majority features 89.48 82.36 79.59 92.65 87.13 + Corpus entity-majority features 89.72 82.40 79.71 92.65 87.23 + Corpus superentity-majority features (All features) 89.80 82.39 79.76 92.57 87.24 13.3% Table 3: Table showing improvements obtained with our additional features, over the baseline CRF.
P04-1056 P05-1045
• Most work has looked to model non-local dependencies only within a document (Finkel 1125 et al., 2005; Chieu and Ng, 2002; Sutton and McCallum, 2004; Bunescu and Mooney, 2004).
C02-1025 P04-1056 P05-1045
The approach of Finkel et al.(2005) makes it possible a to model a broader class of longdistance dependencies than Sutton and McCallum (2004), because they do not need to make any initial assumptions about which nodes should be connected and they too model dependencies between whole token sequences representing entities and between entity token sequences and their token supersequences that are entities.
P05-1045
Bunescu and Mooney (2004) define a Relational Markov Network (RMN) which explicitly models long-distance dependencies, and use it to represent relations between entities.
P04-1056
Random Fields We use a Conditional Random Field (Lafferty et al., 2001; Sha and Pereira, 2003) since it represents the state of the art in sequence modeling and has also been very effective at Named Entity Recognition.
N03-1028
Finkel et al.(2005) hand-set penalties for inconsistency in entity labeling at different occurrences in the text, based on some statistics from training data.
P05-1045
We also compare our performance against (Bunescu and Mooney, 2004) and (Finkel et al., 2005) and find that we manage higher relative improvement than existing work despite starting from a very competitive baseline CRF.
P04-1056 P05-1045
A very common case of this in the CoNLL dataset is that of documents containing references to both The China Daily, a newspaper, and China, the country (Finkel et al., 2005).
P05-1045
The simplicity of our approach makes it easy to incorporate dependencies across the whole corpus, which would be relatively much harder to incorporate in approaches like (Bunescu and Mooney, 2004) and (Finkel et al., 2005).
P04-1056 P05-1045
