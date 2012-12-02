This produces a segmentation view of the arabic source words (Lee et al., 2003).
P03-1051
The translation model is estimated via the EM algorithm or approximations that are bootstrapped from the previous model in the sequence as introduced in (Brown et al., 1993).
J93-2003
More recently, (Chiang, 2005) extended phrase-pairs (or blocks) to hierarchical phrase-pairs where a grammar with a single non-terminal allows the embedding of phrases-pairs, to allow for arbitrary embedding and capture global reordering though this approach still has the high overlap problem.
P05-1033
In (Tillmann and Zhang, 2006) the model is optimized to produce a block orientation and the target sentence is used only for computing a sentence level BLEU.
P06-1091
Following the perspective of (Brown et al., 1993), a minimal set of phrase blocks with lengths (m, n) where either m or n must be greater than zero results in the following types of blocks: 1.
J93-2003
This model is a special case of the Direct Translation Model proposed in (Papineni et al., 1997; Papineni et al., 1998) for language understanding; (Foster, 2000) demostrated perplexity reductions by using direct models; and (Och and Ney, 2002) employed it very successfully for language translation by using about ten feature functions: p(TjS) = 1Z exp summationdisplay i λiφi(S, T) Many of the feature functions used for translation are MLE models (or smoothed variants).
P00-1006 P02-1038
The λf are trained using a held-out corpus using maximum BLEU training (Och, 2003).
P03-1021
However, in (Quirk and Menezes, 2006), the authors investigate minimum translation units (MTU) which is a refinement over a similar approach by (Banchs et al., 2005) to eliminate the overlap issue.
N06-1002
using a MaxEnt aligner (Ittycheriah and Roukos, 2005) or an HMM aligner (Ge, 2004)).
H05-1012
(Liang et al., 2006) demonstrates a discriminatively trained system for machine translation that has the following characteristics: 1) requires a varying update strategy (local vs.
P06-1096
This latter point is a critical difference that contrasts to the major weakness of the work of (Liang et al., 2006) which uses a top-N list of translations to select the maximum BLEU sentence as a target for training (so called local update).
P06-1096
Decoder A beam search decoder similar to phrase-based systems (Tillmann and Ney, 2003) is used to translate the Arabic sentence into English.
J03-1005
Most phrasebased systems, including the baseline decoder used in this work use feature functions: a target word n-gram model (e.g., n = 5), a target part-of-speech n-gram model (n 5), various translation models such as a block inventory with the following three varieties: 1) the unigram block count, 2) a model 1 score p(sijti) on the phrase-pair, and 3)a model 1 score for the other direction p(tijsi), a target word count penalty feature jTj, a phrase count feature, a distortion model (Al-Onaizan and Papineni, 2006).
P06-1067
Recently, there have been several discriminative approaches at training large parameter sets including (Tillmann and Zhang, 2006) and (Liang et al., 2006).
P06-1091 P06-1096
Unlike MaxEnt training, the method (Och, 2003) used for estimating the weight vector for BLEU maximization are not computationally scalable for a large number of feature functions.
P03-1021
selection Recent statistical machine translation (SMT) algorithms generate such a translation by incorporating an inventory of bilingual phrases (Och and Ney, 2000).
C00-2163
modeling for translation Earlier work in statistical machine translation (Brown et al., 1993) is based on the “noisy-channel” formulation where T∗ = arg max T p(TjS) = argmax T p(T)p(SjT) (1) where the target language model p(T) is further decomposed as p(T) / productdisplay i p(tijti−1, . . ., ti−k+1) where k is the order of the language model and the translation model p(SjT) has been modeled by a sequence of five models with increasing complexity (Brown et al., 1993).
J93-2003
Also, slightly restating the advantages of phrase-pairs identified in (Quirk and Menezes, 2006), these blocks are effective at capturing context including the encoding of non-compositional phrase pairs, and capturing local reordering, but they lack variables (e.g.
N06-1002
Categorization of Block Styles In (Brown et al., 1993), multi-word “cepts” (which are realized in our block concept) are discussed and the authors state that when a target sequence is sufficiently different from a word by word translation, only then should the target sequence should be promoted to a cept.
J93-2003
