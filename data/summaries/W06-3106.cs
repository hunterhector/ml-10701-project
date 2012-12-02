Although the results are not directly comparable, (Quirk et al., 2005) report much larger improvements over a phrase-based statistical engine with their translation engine that employs a source parser.
P05-1034
We define the source and target projection of a hypothesis h by the proj operator which collects in order the words of a hypothesis along one language: projF(h) = braceleftBig fp : p∈uniontextui=1jin}n∈[1,ni] bracerightBig projE(h) = braceleftBig ep : p∈uniontextui=1lim}m∈[1,mi] bracerightBig If we denote by Hf the set of hypotheses that have f as a source projection (that is, Hf = {h : projF(h) ≡ f}), then our translation engine seeks ˆe = projE(ˆh) where: ˆh = argmax h∈Hf s(h) The function we seek to maximize s(h) is a loglinear combination of 9 components, and might be better understood as the numerator of a maximum entropy model popular in several statistical MT systems(OchandNey, 2002; Bertoldietal., 2004; Zens and Ney, 2004; Simard et al., 2005; Quirk et al., 2005).
H05-1095 N04-1033 P02-1038 P05-1034
As mentioned in (Ding and Palmer, 2005), most of these approaches require some assumptions on the level of isomorphism (lexical and/or structural) between two languages.
P05-1067
On a comparable test set (Canadian Hansard texts), (Simard et al., 2005) report improvements by adding non-contiguous bi-phrases to their engine without requiring a parser at all.
H05-1095
A TP can be seen as a simplification of the treelet pairs manipulated in (Quirk et al., 2005).
P05-1034
This includes the standard notion of phrase, popular with phrasedbased SMT (Koehn et al., 2003; Vogel et al., 2003) aswellassequencesofwordsthatcontaingaps(possibly of arbitrary size).
N03-1017
The parameters of the word models (IBM model 2) were trained with the GIZA++ package (Och and Ney, 2000).
P00-1056
(Simard et al., 2005) detail an approach where the standard phrases are extended to account for “gaps” either on the target or source side.
H05-1095
We know from (Och and Ney, 2002) that not using the noisy-channel approach does not impact the quality of the translation produced.
P02-1038
(Chiang, 2005) proposes an heuristic way of acquiring context free transfer rules that significantly improves upon a standard phrase-based model.
P05-1033
The training corpus has been aligned at the word level by two Viterbi word-alignments (French2English and English2French) that we combined in a heuristic way similar to the refined method described in (Och and Ney, 2003).
J03-1002
(Melamed, 2004; Ding and Palmer, 2005)) and several algorithms have been proposed to learn the underlying production rule probabilities (Graehl and Knight, 2004; Ding and Palmer, 2004).
N04-1014 P04-1083 P05-1067
The format we use to represent the treelets is similar to the one proposed in (Quirk et al., 2005).
P05-1034
Two error rates: the sentence error rate (SER) and the word error rate (WER) that we seek to minimize, and BLEU (Papineni et al., 2002), that we seek to maximize.
P02-1040
PP-model WecollectedthePPparametersbysimply reading the alignment matrices resulting from the word alignment, in a way similar to the one described in (Koehn et al., 2003).
N03-1017
It has the advantage of naturally capturing local reorderings and is shown to outperform word-based machine translation (Koehn et al., 2003).
N03-1017
