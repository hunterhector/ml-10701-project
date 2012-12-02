Present SMT systems have evolved from the original ones in such a way that mainly differ from them in two issues: first, word-based translation models have been replaced by phrasebased translation models (Zens et al., 2002) and (Koehn et al., 2003); and second, the noisy channel approach has been expanded to a more general maximum entropy approach in which a log-linear combination of multiple feature functions is implemented (Och and Ney, 2002).
P02-1038
11 • Its source or target side begins with a coordination conjunction (except “nor”, in English) • Its source or target side ends with an indefinite determiner English data have been POS-tagged using the TnT tagger (Brants, 2000), after the lemmas have been extracted with wnmorph, included in the Wordnet package (Miller et al., 1991).
A00-1031
More specifically, word-toword alignments are performed in both directions, source-to-target and target-to-source, by using GIZA++ (Och and Ney, 2003), and tuples are extracted from the union set of alignments according to the following constraints (de Gispert and Mari˜no, 2004): • a monotonous segmentation of each bilingual sentence pairs is produced, • no word inside the tuple is aligned to words outside the tuple, and • no smaller tuples can be extracted without violating the previous constraints.
J03-1002
Based on Bilingual Phrases Here we refer to Bilingual Phrase (BP) as the bilingual phrases used by Och and Ney (2004).
J04-4002
Despite the change from a word-based to a phrase-based translation approach, word to word approaches for inferring alignment models from bilingual data (Vogel et al., 1996; Och and Ney, 2003) continue to be widely used.
C96-2141 J03-1002
Since this is a statistical technique, and frequencies of multi-word expressions are low (Baldwin and Villavicencio, 2002), the size of the corpus is an important factor.
W02-2001
Statistical machine translation (SMT) was originally focused on word to word translation and was based on the noisy channel approach (Brown et al., 1993).
J93-2003
