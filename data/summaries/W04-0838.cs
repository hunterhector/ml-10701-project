For learning, we are using the Timbl memory based learning algorithm (Daelemans et al., 2001), which was previously found useful for the task of word sense disambiguation (Mihalcea, 2002).
C02-1039
For some natural language processing tasks, such as part of speech tagging or named entity recognition, regardless of the approach considered, there is a consensus on what makes a successful algorithm (Resnik and Yarowsky, 1997).
W97-0213
We are therefore using (1) SemCor (Miller et al., 1993) – a balanced, semantically annotated dataset, with all content words manually tagged by trained lexicographers – to learn a seAssociation for Computational Linguistics for the Semantic Analysis of Text, Barcelona, Spain, July 2004 SENSEVAL-3: Third International Workshop on the Evaluation of Systems mantic language model for the words seen in the training corpus; and (2) information drawn from WordNet (Miller, 1995), to derive semantic generalizations for those words that did not appear in the annotated corpus.
H93-1061
On the other hand, (Lin, 1997) proposes a disambiguation algorithm that relies on the basic intuition that if two occurrences of the same word have identical meanings, then they should have similar local context.
P97-1009
(Hoste et al., 2002) – the models can only handle words that were previously seen in the training corpus, and therefore their coverage is not 100%.
W02-0814
During the evaluations on the SENSEVAL-3 English all-words data set, 1,782 words were tagged using the semantic language model, resulting in an average coverage of 85.6%. 3.2 Semantic Generalizations using Syntactic Dependencies and a Conceptual Network Similar to (Lin, 1997), we consider the syntactic dependency of words, but we also consider the conceptual hierarchy of a word obtained through the WordNet semantic network – as a means for generalization, capable to handle unseen words.
P97-1009
For example, according to (Gomez, 2001), the syntax of many verbs is determined by their semantics, and thus it is possible to get the later from the former.
N01-1012
