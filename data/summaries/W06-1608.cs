We therefore used an automatic POS tagger (Toutanova et al., 2003) trained on the complete training section of the Penn Treebank (sections 02–21).
N03-1033
We use a beam search decoder to find the best translation T∗ according to the log-linear combination of models: T∗ = argmaxT braceleftBigg ∑ f∈F λ f f(S,T,A) bracerightBigg (3) The models include inverted and direct channel models estimated by relative frequency, lexical weighting channel models following (Vogel et al., 2003), a trigram target language model using modified Kneser-Ney smoothing (Goodman, 2001), an order model following (Quirk et al., 2005), and word count and phrase count functions.
P05-1034
This dependency graph is partitioned into treelets; like (Koehn et al., 2003), we assume a uniform probability distribution over all partitions.
N03-1017
For comparable English text the figure is considerably less than one percent (Gamon et al., 2002).
C02-1036
In Englishto-German, this result produces results very comparable to a phrasal SMT system (Koehn et al., 2003) trained on the same data.
N03-1017
The weights for these models are determined using the method described in (Och, 2003).
P03-1021
For parser evaluation and for the machine translation experiments reported here, we used an automatic POS tagger (Toutanova et al., 2003) trained on sections 02–21 of the Penn Treebank.
N03-1033
The parser is trained on dependencies extracted from the English Penn Treebank version 3.0 (Marcus et al., 1993) by using the head-percolation rules of (Yamada and Matsumoto, 2003).
J93-2004
First the corpus is word-aligned using GIZA++ (Och and Ney, 2000), then the source sentence are parsed, and finally dependencies are projected onto the target side following the heuristics described in (Quirk et al., 2005).
P00-1056 P05-1034
translation For syntactically-informed translation, we follow the treelet translation approach described in (Quirk et al., 2005).
P05-1034
Collins. 2002.
W02-1001
quality Table 2 presents the impact of parse quality on a treelet translation system, measured using BLEU (Papineni et al., 2002).
P02-1040
To find the optimal parse given the weight vector w and feature vector f(i, j) we use the decoder described in (Eisner, 1996).
C96-1058
Eisner. 1996.
C96-1058
We use the parsing approach described in (Corston-Oliver et al., 2006).
N06-1021
It has been shown that phrasal machine translation systems are not affected by the quality of the input word alignments (Koehn et al., 2003).
N03-1017
To set the weight vector w, we train twenty averaged perceptrons (Collins, 2002) on different shuffles of data drawn from sections 02–21 of the Penn Treebank.
W02-1001
