Och. 2002.
P02-1038
(Mihalcea and Pedersen, 2003).
W03-0301
The parameters of the MT system were optimized on MTEval’02 data using minimum error rate training (Och, 2003).
J03-1002 P03-1021
Given a collection of facts, ME chooses a model consistent with all the facts, but otherwise as uniform as possible (Berger et al., 1996).
J96-1002
MT output is evaluated using the standard MT evaluation metric BLEU (Papineni et al., 2002).
P02-1040
Based on the observations in (Koehn et al., 2003), we also limited the phrase length to 3 for computational reasons.
N03-1017
Once the feature functions are extracted, we learn the model parameters using the YASMET ME package (Och, 2002), which is an efficient implementation of the GIS algorithm.
P02-1038
Maximum entropy (ME) models have been used in bilingual sense disambiguation, word reordering, and sentence segmentation (Berger et al., 1996), parsing, POS tagging and PP attachment (Ratnaparkhi, 1998), machine translation (Och and Ney, 2002), and FrameNet classification (Fleischman et al., 2003).
J03-1002 J96-1002 P02-1038 P03-1021 W03-1007
Word alignment—detection of corresponding words between two sentences that are translations of each other—is usually an intermediate step of statistical machine translation (MT) (Brown et al., 1993; Och and Ney, 2003; Koehn et al., 2003), but also has been shown useful for other applications such as construction of bilingual lexicons, word-sense disambiguation, projection of resources, and crosslanguage information retrieval.
J03-1002 J93-2003 N03-1017 P03-1021
(Ittycheriah and Roukos, 2005).
H05-1012
In a later study, Och and Ney (2003) present a loglinear combination of the HMM and IBM Model 4 that produces better alignments than either of those.
J03-1002 P03-1021
An alternative ME approach models alignment directly as a log-linear combination of feature functions (Liu et al., 2005).
P05-1057
Och. 2003.
J03-1002 P03-1021
stance, the IBM models (Brown et al., 1993) can be improved by adding more context dependencies into the translation model using a ME framework rather than using only p(f j |e i ) (Garcia-Varea et al., 2002).
J93-2003
For comparison purposes, three additional heuristically-induced alignments are generated for each system: (1) Intersection of both directions (Aligner(int)); (2) Union of both directions (Aligner(union)); and (3) The previously bestknown heuristic combination approach called growdiag-final (Koehn et al., 2003) (Aligner(gdf)).
N03-1017
Partitioning Data: Previous work showed that partitioning the data into disjoint subsets and learning a different model for each partition improves the performance of the alignment systems (Ayan et al., 2005).
H05-1009
Moore (2005) and Taskar et al.(2005) represent alignments with several feature functions that are then combined in a weighted sum to model word alignments.
H05-1010 H05-1011
A discussion of these two contrasting approaches can be found in (Tillmann and Zhang, 2005).
P05-1069
and SAHMM (Lopez and Resnik, 2005).
W05-0812
The alignment process can be modeled as a product of a transition model and an observation model, where ME models the observations (Ittycheriah and Roukos, 2005).
H05-1012
A recent attempt to combine outputs of different alignments views the combination problem as a classifier ensemble in the neural network framework 102 (Ayan et al., 2005).
H05-1009
Moore. 2005.
H05-1011
(Ayan et al., 2005).
H05-1009
They have also been used to solve the word alignment problem (Garcia-Varea et al., 2002; Ittycheriah and Roukos, 2005; Liu et al., 2005), but a sentence-level approach to combining knowledge sources is used rather than a word-level approach.
H05-1012 P05-1057
