The ISI ReWrite decoder (Germann, 2003), which implements an efficient greedy decoding algorithm, is used to translate the Chinese sentences, using the alignment model and language model previously described.
N03-1010
For instance, Ng et al.(2003) showed that it is possible to use word aligned parallel corpora to train accurate supervised WSD models.
P03-1058
Using our WSD model to constrain the translation candidates given to the decoder hurts translation quality, as measured by the automated BLEU metric (Papineni et al., 2002).
P02-1040
(Carpuat et al., 2004) showed that KPCAbased WSD models achieve close accuracies to the best individual WSD models, while having a significantly different bias.
W04-0822
The second voting model is a maximum entropy model (Jaynes, 1978), since Klein and Manning (2002) found that this model yielded higher accuracy than naive Bayes in a subsequent comparison of WSD performance.
W02-1002
The training scheme consists of IBM-1, HMM, IBM-3 and IBM-4, following (Och and Ney, 2003).
J03-1002
389 Table 1: Example of the translation candidates before and after mapping for the target word “a52” (lu) HowNet Sense ID HowNet glosses HowNet glosses + improved translations 56520 distance distance 56521 sort sort 56524 Lu Lu 56525, 56526, 56527, 56528 path, road, route, way path, road, route, way, circuit, roads 56530, 56531, 56532 line, means, sequence line, means, sequence, lines 56533, 56534 district, region district, region 4.1 Alignment model The alignment model was trained with GIZA++ (Och and Ney, 2003), which implements the most typical IBM and HMM alignment models.
J03-1002
A more grammatically structured statistical MT model that less ngram oriented, such as the ITG based “grammatical channel” translation model (Wu and Wong, 1998), might make more effective use of the WSD model’s predictions.
P98-2230
In Proceedings of the 40th Annual Meeting of the Association for Computational Linguistics, pages 343–351, 2002.
P02-1044
Other work includes Li and Li (2002) who propose a bilingual bootstrapping method to learn a translation disambiguation WSD model, and Diab (2004) who exploited large amounts of automatically generated noisy parallel data to learn WSD models in an unsupervised bootstrapping scheme.
P02-1044 P04-1039
The fourth voting model is a Kernel PCA-based model (Wu et al., 2004).
P04-1081
Brown et al.(1991) proposed a WSD algorithm to disambiguate English translations of French target words based on the single most informative context feature.
P91-1034
For example, the WSD model’s predictions could be employed in a Bracketing ITG translation model such as Wu (1996) or Zens et al.(2004), or alternatively they could be incorporated as features for reranking in a maximum-entropy SMT model (Och and Ney, 2002), instead of using them to constrain the sentence translation hypotheses as done here.
C04-1030 P02-1038 P04-1081 P96-1021
(Note, however, that a different subset of either Senseval-1 or Senseval-2 English lexical sample data was used for their comparison.) The third voting model is a boosting model (Freund and Schapire, 1997), since has consistently turned in very competitive scores on related tasks such as named entity classification (Carreras et al., 2002). Specifically, an AdaBoost.MH model was used (Schapire and Singer, 2000), which is a multiclass generalization of the original boosting algorithm, with boosting on top of decision stump classifiers (i.e., decision trees of depth one).
W02-2004
In Proceedings of the 40th Annual Meeting of the Association for Computational Linguistics, 2002.
P02-1044
388 3 The WSD system The WSD system used for the experiments is based on the model that achieved the best performance, by a large margin, on the Senseval-3 Chinese lexical sample task (Carpuat et al., 2004).
W04-0822
