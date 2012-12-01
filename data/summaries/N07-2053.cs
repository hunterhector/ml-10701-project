Finally, to estimate the parameters λi of the weighted linear model, we adopt the popular minimum error rate training procedure (Och, 2003) which directly optimizes translation quality as measured by the BLEU metric.
P03-1021
The original approach (Marcu and Wong, 2002) was limited due to computational constraints but recent work (DeNero et al., 2006; Birch et al., 2006) has improved the efficiency by using word alignments as constraints on the set of possible phrase pairs.
W02-1018 W06-3105 W06-3123
In this work, we use a discriminatively trained word aligner (Moore et al., 2006) that has state of the art performance.
P06-1065
This scoring metric is used in a phrase pair selection algorithm inspired by competitive linking for word alignment (Melamed, 2000).
J00-2004
In this section, we report experiments conducted with Canadian Hansards data from the 2003 HLTNAACL word-alignment workshop (Mihalcea and Pedersen, 2003).
W03-0301
We use a version from Foster et al.(2006), modified from (Koehn et al., 2003), which is an average of pairwise word translation probabilities.
N03-1017 W06-1607
They provide pairs of phrases that are used to construct a large set of potential translations for each input sentence, along with feature values associated with each phrase pair that are used to select the best translation from this set.1 The most widely used method for building phrase translation tables (Koehn et al., 2003) selects, from a word alignment of a parallel bilingual training corpus, all pairs of phrases (up to a given length) that are consistent with the alignment.
N03-1017
In experiments, this approach reduced the size of the phrase tranlsation table by half, and improved the BLEU scoreoftheresultingtranslationsbyupto1.5points. 2 Background As a baseline, we present a relatively standard SMT approach, following Koehn et al.(2003). Potential translations are scored using a linear model where the best translation is computed as argmaxt,a nsummationdisplay i=1 λifi(s,a,t) where s is the input sentence, t is the output sentence, and a isaphrasalalignmentthatspecifieshow 2In one experiment, we managed to generate more than 117,000 English phrases for the the French word “de”.
N03-1017
The first two features, the log translation and inverse translation probabilities, are estimated by counting phrase cooccurrences, following Koehn et al.(2003). The third feature is the logarithm of a lexical score l(s,t) that provides a simple form of smoothing by weighting a phrase pair based on how likely individual words within the phrases are to be translations of each other.
N03-1017
