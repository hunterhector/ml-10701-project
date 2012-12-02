Finally, Pradhan et al.(2005b) followed a stacking approach by learning two individual systems based on full syntax, whose outputs are used to generate features to feed the training stage of a final chunk-by-chunk SRL system.
W05-0634
Tables 4, 5, and 6 present these features organized in the same three categories as the previous Models 1 and 2 — see (Surdeanu and Turmo, 2005) for more details.
W05-0635
Haghighi et al.(2005) implemented a double reranking model on top of the base SRL models to select the most probable solution among a set of candidates.
W05-0623
Constituent path as described in (Gildea and Jurafsky, 2002) and all 3/4/5-grams of path constituents beginning at the verb predicate or ending at the constituent.
J02-3001
On the other hand, probabilistic inference processes, which have been successfully used for SRL (Koomen et al., 2005), mandate that each individual candidate argument be associated with its raw activation, or confidence, in the given model.
W05-0625
Although none of them would rank in the top 3 in this year’s CoNLL evaluation (Carreras and M`arquez, 2005), their performance is comparable to the best individual systems presented at that evaluation exercise3.
W05-0620
Content words, which add informative lexicalized information different from the head word, were detected using the heuristics of (Surdeanu et al., 2003).
P03-1002
Governing category as in (Gildea and Jurafsky, 2002).
J02-3001
The task of Semantic Role Labeling (SRL), i.e. the process of detecting basic event structures such as who did what to whom, when and where, has received considerable interest in the past few years (Gildea and Jurafsky, 2002; Surdeanu et al., 2003; Xue and Palmer, 2004; Pradhan et al., 2005a; Carreras and M`arquez, 2005).
J02-3001 P03-1002 W04-3212 W05-0620 W05-0634 W05-0635
Koomen et al.(2005) used a 2 layer architecture similar to ours.
W05-0625
Instead, we develop our models using automatically-generated syntax and named-entity (NE) labels, made available by the CoNLL shared task evaluation (Carreras and M`arquez, 2005).
W05-0620
Most current SRL approaches can be classified in one of two classes: approaches that take advantage of complete syntactic analysis of text, pioneered by Gildea and Jurafsky (2002), and approaches that use partial syntactic analysis, championed by previous evaluations performed within the Conference on Computational Natural Language Learning (CoNLL) (Carreras and M`arquez, 2004).
J02-3001 W04-2412 W04-2415
Despite its simplicity, our approach obtains encouraging results: the combined system outperforms any of the individual systems and, using exactly the same data, it is also competitive with the best SRL systems that participated in the latest CoNLL shared task evaluation (Carreras and M`arquez, 2005).
W05-0620
Partial parsing path as described in (Carreras et al., 2004) and all 3/4/5-grams of path elements beginning at the verb predicate or ending at the constituent.
W04-2412 W04-2415
Syntactic frame as described by Xue and Palmer (2004) Table 3: Predicate–constituent features: Models 1/2 The syntactic label of the candidate constituent.
W04-3212
It was shown that the identification of such event frames has a significant contribution for many Natural Language Processing (NLP) applications such as Information Extraction (Surdeanu et al., 2003) and Question Answering (Narayanan and Harabagiu, 2004).
C04-1100 P03-1002
