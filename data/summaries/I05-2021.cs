The ISI ReWrite decoder (Germann, 2003), which implements an efficient greedy decoding algorithm, is used to translate the Chinese sentences, using the alignment model and language model previously described.
N03-1010
The system described in (Cabezas et al., 2004) is of particular interest as it uses an unsupervised approach.
W04-0821
The training scheme is IBM-1, HMM, IBM-3 and IBM-4, as specified in (Och and Ney, 2003).
J03-1002
For instance, Ng et al.(2003) showed that it is possible to use word aligned parallel corpora to train accurate supervised WSD models.
P03-1058
However, recent progress in machine translation and the continuous improvement on evaluation metrics such as BLEU (Papineni et al., 2002) suggest that SMT systems are already very good at choosing correct word translations.
P02-1040
In Proceedings of the 40th Annual Meeting of the Association for Computational Linguistics, pages 343–351, 2002.
P02-1044
The model consists of an ensemble of four highly accurate classifiers combined by majority vote: a naive Bayes classifier, a maximum entropy model (Jaynes, 1978), a boosting model (Freund and Schapire, 1997), and a Kernel PCA-based model (Wu et al., 2004), which has the advantage of having a signficantly different bias.
P04-1081
Other work includes Li and Li (2002) who propose a bilingual bootstrapping method to learn a translation disambiguation WSD model, and Diab (2004) who exploited large amounts of automatically generated noisy parallel data to learn WSD models in an unsupervised bootstrapping scheme.
P02-1044 P04-1039
Apart from the voted WSD system described in section 4, and the unsupervised system (Cabezas et al., 2004) mentioned in section 6.4, systems built and optimized for the Senseval-3 Chinese lexical sample task, include Niu et al.(2004). Many of the Senseval-type 124 WSD system are not language specific and the presentation of the results in the English lexical sample task (Midhalcea et al., 2004), English-Hindi multilingual task (Chklovski et al., 2004), or any of the lexical sample tasks defined in other languages, give a good overview of the variety of approaches to WSD.
W04-0802 W04-0821 W04-0847
In other work, we have been conducting comparative studies testing whether state-of-the-art WSD mod120 els can improve SMT translation quality (Carpuat and Wu, 2005).
P05-1048
model The alignment model was trained with GIZA++ (Och and Ney, 2003), which implements the most typical IBM and HMM alignment models.
J03-1002
Note that Senseval-3 also defined a translation or multilingual lexical sample task (Chklovski et al., 2004), which is just like the English lexical sample task, except that the WSD systems are expected to predict Hindi translations instead of WordNet senses.
W04-0802
In particular, more grammatically structured statistical MT models that are better equipped to handle long distance dependencies, such as the ITG based “grammatical channel” translation model (Wu and Wong, 1998), might make better use of the WSD predictions.
P98-2230
Puzzlingly, in converse experiments, using a state-of-theart WSD model to choose translation candidates for a typical IBM SMT system, we find that WSD does not yield significantly better translation quality than the SMT system alone (Carpuat and Wu, 2005).
P05-1048
WSD system The WSD system used here is based on the model that achieved the best performance on the Senseval-3 Chinese lexical sample task, outperforming other systems by a large margin (Carpuat et al., 2004).
W04-0822
In Proceedings of the 40th Annual Meeting of the Association for Computational Linguistics, 2002.
P02-1044
