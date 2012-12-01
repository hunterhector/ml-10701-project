To perform translation, state-of-the-art MT systems use a statistical phrase-based approach (Marcu and Wong, 2002; Koehn et al., 2003; Och and Ney, 2004) by treating phrases as the basic units of translation.
J04-4002 N03-1017 W02-1018 W04-3250
Note that comparing with the MT systems used in (Carpuat and Wu, 2005) and (Cabezas and Resnik, 2005), the Hiero system we are using represents a much stronger baseline MT system upon which the WSD system must improve.
P05-1048
This is higher than the score of 28.77 reported in (Chiang, 2005), perhaps due to differences in word segmentation, etc.
P05-1033
In this paper, we successfully integrate a stateof-the-art WSD system into the state-of-the-art hierarchical phrase-based MT system, Hiero (Chiang, 2005).
P05-1033
In another work (Vickrey et al., 2005), the WSD problem was recast as a word translation task.
H05-1097
We obtain accuracy that compares favorably to the best participating system in the task (Carpuat et al., 2004).
W04-0822
Carpuat and Wu (2005) integrated the translation predictions from a Chinese WSD system (Carpuat et al., 2004) into a ChineseEnglish word-based statistical MT system using the ISI ReWrite decoder (Germann, 2003).
N03-1010 P05-1048 W04-0822
Following (Chiang, 2005), we used the version 11a NIST BLEU script with its default settings to calculate the BLEU scores (Papineni et al., 2002) based on case-insensitive ngram matching, where n is up to 4.
P02-1040 P05-1033
Similar to (Chiang, 2005), we trained the Hiero system on the FBIS corpus, used the NIST MT 2002 evaluation test set as our development set to tune the feature weights, and the NIST MT 2003 evaluation test set as our test data.
P05-1033
Hiero uses a general log-linear model (Och and Ney, 2002) where the weight of a derivation D for a particular source sentence and its translation is w(D) = productdisplay i φi(D)λi (3) where φi is a feature function and λi is the weight for feature φi.
P02-1038
Och. 2003.
P03-1021
Sense Disambiguation Prior research has shown that using Support Vector Machines (SVM) as the learning algorithm for WSD achieves good results (Lee and Ng, 2002).
W02-1006
The word alignments of both directions are then combined into a single set of alignments using the “diag-and” method of Koehn et al.(2003). Based on these alignments, synchronous CFG rules are then extracted from the corpus.
N03-1017
The first eight features are those used by Hiero in (Chiang, 2005).
P05-1033
Our implemented WSD classifier uses the knowledge sources of local collocations, parts-of-speech (POS), and surrounding words, following the successful approach of (Lee and Ng, 2002).
W02-1006
A n-gram language model adds a dependence on (n−1) neighboring target-side words (Wu, 1996; Chiang, 2007), making decoding much more difficult but still polynomial; in this paper, we add features that depend on the neighboring source-side words, which does not affect decoding complexity at all because the source string is fixed.
P96-1021
Though the improvement is modest, it is statistically significant and this positive result is important in view of the negative findings in (Carpuat and Wu, 2005) that WSD does not help MT.
P05-1048
Note that the experiments in (Carpuat and Wu, 2005) did not use a state-of-the-art MT system, while the experiments in (Vickrey et al., 2005) were not done using a full-fledged MT system and the evaluation was not on how well each source sentence was translated as a whole.
H05-1097 P05-1048
The improvement of 0.57 is statistically significant at p < 0.05 using the sign-test as described by Collins et al.(2005), with 374 (+1), 318 (−1) and 227 (0).
P05-1066
Results Using the MT 2002 test set, we ran the minimumerror rate training (MERT) (Och, 2003) with the decoder to tune the weights for each feature.
P03-1021
Capitalizing on the strength of the phrase-based approach, Chiang (2005) introduced a hierarchical phrase-based statistical MT system, Hiero, which achieves significantly better translation performance than Pharaoh (Koehn, 2004a), which is a state-of-the-art phrasebased statistical MT system.
P05-1033 W04-3250
First, we performed word alignment on the FBIS parallel corpus using GIZA++ (Och and Ney, 2000) in both directions.
P00-1056
Hiero (Chiang, 2005) is a hierarchical phrase-based model for statistical machine translation, based on weighted synchronous context-free grammar (CFG) (Lewis and Stearns, 1968).
P05-1033
Recently, Cabezas and Resnik (2005) experimented with incorporating WSD translations into Pharaoh, a state-of-the-art phrase-based MT system (Koehn et al., 2003).
N03-1017
Using the bootstrap-sampling test described in (Koehn, 2004b), the improvement is statistically significant at p < 0.05.
W04-3250
