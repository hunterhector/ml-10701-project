The task of case prediction in Japanese has previously focused on recovering implicit case relations, which result when noun phrases are relativized or topicalized (e.g., Baldwin, 2000; Kawahara et al., 2004; Murata and Isahara, 2005).
W04-0907
(Carreras and Màrquez, 2005), whereas our 2 most frequent case markers (no and wo) account for only 43% of the case-marked phrases.
W05-0620
The parallel sentences were word-aligned using GIZA++ (Och and Ney, 2000), and submitted to a tree-to-string-based MT system (Quirk et al., 2005) which utilizes the dependency structure of the source language and projects dependency structure to the target language.
P00-1056 P05-1034
classifiers Following the standard practice in semantic role labeling, we divided the case prediction task into the tasks of identification and classification (Gildea and Jurafsky, 2002; Pradhan et al., 2004).
J02-3001 N04-1030
We formulated this task after the well-studied task of semantic role labeling in English (e.g., Gildea and Jurafsky, 2002; Carreras and Màrques, 2005), whose goal is to assign one of 20 semantic role labels to each phrase in a sentence with respect to a given predicate, based on the annotations provided by PropBank (Palmer et al., 2005).
J02-3001 J05-1004 W05-0620
In this setting, dependency information for the target language (Japanese) is available only through projection of a dependency structure from the source language (English) in a tree-to-string-based statistical MT system (Quirk et al., 2005).
P05-1034
The semantic role labeling task mentioned in Section 1 is one example; the task of function tag assignment in English (e.g., Blaheta and Charniak, 2000) is another.
A00-2031
We applied the joint classifiers in the framework of N-best reranking (Collins, 2000), following Toutanova et al.(2005). That is, we produced N-best (N=5 in our experiments) case assignment sequence candidates for a set of sister phrases using the local models, and trained a joint classifier that learns to choose the best candidate from the set of sisters.
P05-1073
For our monolingual experiments, we used the dependency structure annotation in the Kyoto Corpus; for our bilingual experiments, we used automatically derived dependency structure (Quirk et al., 2005).
P05-1034
In the context of sentence generation, Gamon et al.(2002) used a decision tree to classify nouns into one of the four cases in German, as part of their sentence realization from a semantic representation, achieving high accuracy (87% to 93.5%).
P02-1004
We employ this decomposition mainly for efficiency in training: that is, the decomposition allows us to train the classification models on a subset of training examples consisting only of those phrases that have a case marker, following Toutanova et al.(2005). Among various machine learning methods that can be used to train the classifiers, we chose log-linear models for both identification and classification tasks, as they produce probability distributions which allows chaining of the two component models and easy integration into an MT system.
P05-1073
Only one feature (GrandparentNounSubPos) currently refers to the grandparent of the phrase; all other features are between the phrase, its parent and its sibling nodes, and are a superset of the dependency-based features used by Hacioglu (2004) for the semantic labeling task.
C04-1186
classifiers Toutanova et al.(2005) report a substantial improvement in performance on the semantic role labeling task by building a joint classifier, which takes the labels of other phrases into account when classifying a given phrase.
P05-1073
Uchimoto et al.(2002), which is the work most related to ours, propose a model of generating function words (not limited to case markers) from "keywords" or headwords of phrases in Japanese.
C02-1064
