The existence of nontopical senses also limits the applicability of the "one sense per discourse" generalization of Gale, Church, and Yarowsky (1992b), who observed that, within a document, a repeated word is almost always used in the same sense.
C92-2070 H92-1045
Obtaining training materials for statistical methods is costly and timeconsuming--it is a "knowledge acquisition bottleneck" (Gale, Church, and Yarowsky 1992a).
C92-2070 H92-1045
Of course, the sparse data problem affects these probabilities too, and so TLC uses the Good-Turing formula (Good 1953; Chiang, Lin, and Su 1995), to smooth the values of p(cj I si), including providing probabilities for cues that did not occur in the training.
J95-3002
When local context is combined with topical, TLC is superior to the topical classifiers compared in the Leacock, Towell, and Voorhees (1993) study.
H93-1051 W93-0102
Dagan and Itai (1994) also describe a way to make the threshold dynamic so that it adjusts for the amount of evidence used to estimate pl and p2.
J94-4003
Leacock, Towell, and Voorhees (1993) report that the three topical classifiers tested averaged 74% accuracy on six senses of the noun line.
H93-1051 W93-0102
In the Gale, Church, and Yarowsky (1992a) study, training and testing materials were automatically acquired using an aligned French-English bilingual corpus by searching for English words that have two different French translations.
C92-2070 H92-1045
Bruce and Wiebe (1994a, 1994b) have developed a classifier that represents local context by morphology (the inflection on the target word), the syntactic category of words within a window of ±2 words from the target, and collocation-specific items found in the sentence.
H94-1047 P94-1020
Leacock, Towell, and Voorhees (1993) compared this Bayesian classifier with a content vector classifier as used in information retrieval and a neural network with backpropagation.
H93-1051 W93-0102
In addition, Yarowsky (1993) used homophones (e.g., cellar~seller) and Yarowsky (1994) created homographs by stripping accents from French and Spanish words.
H93-1052 P94-1013
Yarowsky (1993) also found that template-like structures are very powerful indi148 Leacock, Chodorow, and Miller Corpus Statistics and WordNet Relations cators of sense.
H93-1052
Thus, Leacock, Towell, and Voorhees (1993) found that some senses of the noun line are not susceptible to disambiguation with topical context.
H93-1051 W93-0102
on WordNet's Monosemous Relatives The approach we have used is related to that of Yarowsky (1992) in that training materials are collected using a knowledge base, but it differs in other respects, notably in the selection of training and testing materials, the choice of a knowledge base, and use of both topical and local classifiers.
C92-2070
They range from dictionary-based approaches that rely on definitions (V~ronis and Ide 1990; Wilks et al.1993) to corpus-based approaches that use only word cooccurrence frequencies extracted from large textual corpora (Sch~itze 1995; Dagan and Itai 1994).
J94-4003
These results are consistent with those of Yarowsky (1993), based on his experiments with pseudowords, homophones, and homonyms (discussed below).
H93-1052
Yarowsky (1992) used a thesaurus to collect training materials.
C92-2070
"Ck \[ si)p(si) p(C-k, . . .,Ck) As Golding (1995) points out, the term p(c-k,..., Ck I Si) is difficult to estimate because of the sparse data problem, but if we assume, as is often done, that the occurrence of each cue is independent of the others, then this term can be replaced with: k p(C-k ....
W95-0104
Several artificial techniques have been used so that classifiers can be developed and tested without having to invest in manually tagging the data: Yarowsky (1993) and Sch/itze (1995) have acquired training and testing materials by creating pseudowords from existing nonhomographic forms.
H93-1052 P95-1026
Leacock, Towell, and Voorhees (1993) found that the response patterns of the three classifiers converged, suggesting that each of the classifiers was extracting as much data as is available in purely topical approaches that look only at word counts from training examples.
H93-1051 W93-0102
Gale, Church, and Yarowsky (1992a) developed a topical classifier based on Bayesian decision theory.
C92-2070 H92-1045
The results of disambiguation strategies reported for pseudowords and the like are consistently above 95% overall accuracy, far higher than those reported for disambiguating three or more senses of polysemous words (Wilks et al.1993; Leacock, Towell, and Voorhees 1993).
H93-1051 W93-0102
Following the approach of Dagan and Itai (1994), we use the log of the ratio of the probabilities ln(pl/p2) for this purpose.
J94-4003
Yarowsky (1995) has proposed automatically augmenting a small set of experimenter-supplied seed collocations (e.g., manufacturing plant and plant life for two different senses of the noun plant) into a much larger set of training materials.
P95-1026
Yarowsky (1994), building on his earlier work, designed a classifier that looks at words within :kk positions from the target; lemma forms are obtained through morphological analysis; and a coarse part-of-speech assignment is performed by dictionary lookup.
P94-1013
2. Corpus-based Statistical Sense Identification Work on automatic sense identification from the 1950s onward has been well summarized by Hirst (1987) and Dagan and Itai (1994).
J94-4003
In order to compare our results with those reported in Yarowsky (1992), we trained and tested on the same two senses of the noun duty that Yarowsky had tested ('obligation' and 'tax').
C92-2070
