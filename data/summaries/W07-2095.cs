The second block shows the results of a re-ranking model using our best feature set but the original re-ranking Perceptron of Collins and Duffy (2002).
P02-1034
The paper introduces several novel issues: (a) for the SRL task, we propose a novel reranking algorithm based on the re-ranking Perceptron of Collins and Duffy (2002); and (b) for the same task we introduce a new set of global features that extract information not only at proposition level but also from the complete set of frame candidates.
P02-1034
Any single token with the np0000, W, or Z PoS tag is considered a strong entity and is classified using the (Atserias et al., 2006) implementation of a multi-label AdaBoost.MH algorithm, with a configuration similar to the NE classification module of Carreras et al.(2003). The classifier yields predictions for four classes (person, location, organization, misc).
W03-0421
Features from each candidate frame: (3) The complete sequence of argument labels, extended with the predicate lemma and voice, similar to Toutanova et al.(2005). (4) Maximal overlap with a frame from the verb lexicon.
P05-1073
The third block shows the performance of our re-ranking algorithm configured with the features proposed by Toutanova et al.(2005). We draw several conclusions from this experiment: (a) our re-ranking model 428 NER NSD SRL SC P R F1 P R F1 P R F1 F1 ca.CESS-ECE 79.92% 76.63% 78.24 87.47% 87.47% 87.47 82.16% 70.05% 75.62 85.71 es.CESS-ECE 72.53% 68.48% 70.45 83.30% 83.30% 83.30 86.24% 75.58% 80.56 87.74 ca.3LB 82.04% 79.42% 80.71 85.69% 85.53% 85.61 86.36% 85.30% 85.83 87.35 es.3LB 62.03% 53.85% 57.65 88.14% 88.14% 88.14 82.23% 80.78% 81.50 76.01 Table 1: Official results on the test data.
P05-1073
Frame candidates are generated using the dynamic programming algorithm of Toutanova et al.(2005), and then sorted in descending order of the log probability of the whole frame (i.e., the sum of all argument log probabilities as reported by the local model).
P05-1073
Global Model We base our re-ranking approach on a variant of the re-ranking Perceptron of Collins and Duffy (2002).
P02-1034
