Early work by Yarowsky (1995) falls within this framework.
P95-1026
In the same vein, for the case of entity/relation extraction and classification (Collins and Singer, 1999; Zhang, 2004; Chen et al., 2006) the context of the entity or entities in consideration provides a highly relevant feature space.
P06-1017 W99-0613
To further elucidate the nature of the task and improve annotation consistency, we have developed a new set of guidelines, building on the work of Light et al.(2004). As noted by Light et al., speculative assertions are to be identified on the basis of judgements about the author’s intended meaning, rather than on the presence of certain designated hedge terms.
W04-3103
Other relevant recent work includes (Zhang, 2004), in which random feature projection and a committee of SVM classifiers is used in a hybrid co/self-training strategy for weakly supervised relation classification and (Chen et al., 2006) where a graph based algorithm called label propagation is employed to perform weakly supervised relation extraction.
P06-1017
Banko and Brill (2001) use ‘bagging’ and agreement to measure confidence on unlabelled samples, and more recently McClosky et al.(2006) use selftraining for improving parse reranking.
N06-1020 P01-1005
Hedging is sometimes classed under the umbrella conceptofsubjectivity, whichcoversavarietyoflinguistic phenomena used to express differing forms ofauthorialopinion(Wiebeetal.,2004). Riloffetal.
J04-3002
Co-training has also been used for named entity recognition (NER) (Collins and Singer, 1999), coreference resolution (Ng and Cardie, 2003), text categorization (Nigam and Ghani, 2000) and improving gene name data (Wellner, 2005).
N03-1023 W05-1301 W99-0613
997 0.58 0.6 0.62 0.64 0.66 0.68 0.7 0.72 0.74 0.76 0.78 0.8 0 20 40 60 80 100 120 140 BEP Iteration Prob (Prob)Prob (SVM) SVM (Prob)SVM (SVM) Baseline Prob (Prob) denotes our probabilistic learning model and classifier (§9) Prob (SVM) denotes probabilistic learning model with SVM classifier SVM (Prob) denotes committee-based model (§10.4) with probabilistic classifier SVM (SVM) denotes committee-based model with SVM classifier Baseline denotes substring matching classifier of (Light et al., 2004) Figure 1: Learning curves 10.4 Baselines As a baseline classifier we use the substring matching technique of (Light et al., 2004), which labels a sentence as spec if it contains one or more of the following: suggest, potential, likely, may, at least, in part, possibl, further investigation, unlikely, putative, insights, point toward, promise and propose.
W04-3103
Perhaps the most well known of such approaches is expectation maximization (EM), used by Nigam et al.(2000) for text categorization and by Ng and Cardie (2003) in combination with a meta-level feature selection procedure.
N03-1023
The most clearly relevant study is Light et al.(2004) where the focus is on introducing the problem, exploring annotation issues and outlining potential applications rather than on the specificities of the ML approach, though they do present some results using a manually crafted substring matching classifier and a supervised SVM on a collection of Medline abstracts.
W04-3103
For similar work see (Banko and Brill, 2001; Zhang, 2004).
P01-1005
Variousmethodshavebeeninvestigatedtoaddress this problem, such as ‘counter-training’ (Yangarber, 2003) and committee agreement (Zhang, 2004); how such ideas can be adapted for this task is one of many avenues for future research.
P03-1044
