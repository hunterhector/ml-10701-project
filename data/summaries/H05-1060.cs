1). The lattice-conditional estimation approach was first used by Kudo et al.(2004) for Japanese segmentation and hierarchical POS-tagging and by Smith and Smith (2004) for Korean morphological disambiguation.
W04-3207 W04-3230
Korean disambiguation results were also reported by Cha et al.(1998), who applied a deterministic morpheme pattern dictionary to segment words, then used a bigram HMM tagger.
W98-1110
Our system does not model this process except through the use of Buckwalter’s dictionary to define the set of analyses for each word (cf., Daya et al., 2004, who modeled interdigitation in Hebrew).
W04-3246
The morphological dictionary is Buckwalter’s analyzer (version 2), made available by the LDC (Buckwalter, 2004).7 This analyzer has total coverage of the corpus; there are no 7Arabic morphological processing was also addressed by Kiraz (2000), who gives a detailed review of symbolic work in that area, and by Darwish (2002).
J00-1006 W02-0506
LOPs were applied to CRFs (for named entity recognition and tagging) by Smith et al.(2005), with an eye toward regularization.
P05-1003
Both Diab et al.(2004) and Habash and Rambow (2005) use support-vector machines with local features; the former for tokenization, POS tagging, and base phrase chunking; the latter for full morphological disambiguation.
N04-4038 P05-1071
When training a CRF for POS tagging, IOB chunking (Sha and Pereira, 2003), or word segmentation (Peng et al., 2004), one typically structures the conditional probabilities (in the objective function) using domain knowledge: in POS tagging, the set of allowed tags for a word is used; in IOB chunking, the bigram “O I” is disallowed; and in segmentation, a lexicon is used to enumerate the possible word boundaries.4 4This refinement is in the same vein as the move from maximum likelihood estimation to conditional estimation.
C04-1081 N03-1028
Similar results were presented by Smith and Smith (2004), using a similar estimation strategy with a model that included far more feature templates.
W04-3207
Estimation. A unigram channel model defines 2Probabilistic modeling of what we call the morphological channel was first carried out by Levinger et al.(1995), who used unlabeled data to estimate p(vectory | x) for Hebrew, with the support defined by a dictionary.
J95-3004
Smith and Smith (2004) applied factored estimation to a bilingual weighted grammar, driven by data limitations.
W04-3207
