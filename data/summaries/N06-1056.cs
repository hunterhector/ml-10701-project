Synchronous parsing has seen a surge of interest recently in the machine translation community as a way of formalizing syntax-based translation models (Melamed, 2004; Chiang, 2005).
P04-1083 P05-1033
Using word alignments to induce a lexicon is not a new idea (Och and Ney, 2003).
J03-1002
In this work, we use the GIZA++ implementation (Och and Ney, 2003) of IBM Model 5 (Brown et al., 1993).
J03-1002 J93-2003
S.Miller, D.Stallard, R.Bobrow, andR.Schwartz. 1996.
P96-1008
An Earley chart is used for keeping track of all derivations that are consistent with the input (Stolcke, 1995).
J95-2002
Figure 6 shows the performance of WASP compared to four other algorithms: SILT (Kate et al., 2005), COCKTAIL (Tang and Mooney, 2001), SCISSOR (Ge and Mooney, 2005) and Zettlemoyer and Collins (2005).
W05-0602
More specifically, a statistical word alignment model (Brown et al., 1993) is used to acquire a bilingual lexicon consisting of NL substrings coupled with their translations in the target MRL.
J93-2003
Our method is like many phrasebased translation models, which require a simpler, word-based alignment model for the acquisition of a phrasal lexicon (Och and Ney, 2003).
J03-1002
It is also similar to the hierarchical phrase-based model of Chiang (2005), in which hierarchical phrase pairs, essentially SCFG rules, are learned through the use of a simpler, phrase-based alignment model.
P05-1033
Prior research in semantic parsing has mainly focused on relatively simple domains such as ATIS (AirTravelInformationService)(Milleretal., 1996; Papineni et al., 1997; Macherey et al., 2001), in which a typcial MR is only a single semantic frame.
P96-1008
Melamed. 2004.
P04-1083
Complete MRs are then formed by combining these NL substrings and their translations under a parsing framework called the synchronous CFG (Aho and Ullman, 1972), which forms the basis of most existing statistical syntax-based translation models (Yamada and Knight, 2001; Chiang, 2005).
P01-1067 P05-1033
Other learning methods involve the use of fullyannotated augmented parse trees (Ge and Mooney, 2005) or prior knowledge of the NL syntax (Zettlemoyer and Collins, 2005) in training, and hence require extensive human efforts when porting to a new domain or language.
W05-0602
Here we use a version of im443 proved iterative scaling (IIS) coupled with EM (Riezler et al., 2000) for finding an optimal set of parameters.1 Unlike the fully-supervised case, the conditional likelihood is not concave with respect to λ, so the estimation algorithm is sensitive to initial parameters.
P00-1061
