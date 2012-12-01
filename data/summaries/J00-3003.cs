We estimate the distribution of likely DA types for a given utterance using the entire conversation E as evidence, and then use a sentence-level mixture (Iyer, Ostendorf, and Rohlicek 1994) of DA-specific LMs in a single recognizer run.
H94-1014
Levin et al.(1999) couple DA classification with dialogue game classification; dialogue games are units above the DA level, i.e., short DA sequences such as question-answer pairs.
W99-0306
It maximizes the probability of getting the entire DA sequence correct, but it does not necessarily find the DA sequence that has the most DA labels correct (Dermatas and Kokkinakis 1995).
J95-2001
In related work DAs are used as a first processing step to infer dialogue games (Carlson 1983; Levin and Moore 1977; Levin et al.1999), a slightly higher level unit that comprises a small number of DAs.
W99-0306
(Indeed, with the exception of Samuel, Carberry, and Vijay-Shanker (1998), all models listed in Table 14 rely on some version of this HMM metaphor).
P98-2188
It is known that certain cue words and phrases (Hirschberg and Litman 1993) can serve as explicit indicators of discourse structure.
J93-3003
Second, we built a discourse grammar that incorporated constraints on DA sequences in a nonhierarchical way, using maximum entropy (ME) estimation (Berger, Della Pietra, and Della Pietra 1996).
J96-1002
Jurafsky, Shriberg, Fox, and Curl (1998) show that the grammar of some DAs, such as appreciations, can be captured by finite-state automata over part-of-speech tags.
W98-0319
For example, a context-free discourse grammar could potentially account for the nested structures proposed in Grosz and Sidner (1986).
J86-3001
When applied to a discourse model with locally decomposable likelihoods and Markovian discourse grammar, it will therefore find precisely the DA 348 Stolcke et al.Dialogue Act Modeling sequence with the highest posterior probability: U* = argmaxP(UIE ) (4) u The combination of likelihood and prior modeling, HMMs, and Viterbi decoding is fundamentally the same as the standard probabilistic approaches to speech recognition (Bahl, Jelinek, and Mercer 1983) and tagging (Church 1988).
A88-1019
A nonprobabilistic approach for DA labeling proposed by Samuel, Carberry, and Vijay-Shanker (1998) is transformation-based learning (Brill 1993).
H93-1047 P98-2188
A number of the DA m6deling algorithms described below were developed for VERBMOBIL, including those of Mast et al.(1996), Warnke et al.(1997), Reithinger et al.(1996), Reithinger and Klesen (1997), and Samuel, Carberry, and Vijay-Shanker (1998).
P98-2188
Note The research described here is based on a project at the 1997 Workshop on Innovative Techniques in LVCSR at the Center for Speech and Language Processing at Johns Hopkins University (Jurafsky et al.1997; Jurafsky et al.1998). The DA-labeled Switchboard transcripts as well as other project-related publications are available at http://www.colorado.
W98-0319
1988). As argued in Carletta (1996), Kappa values of 0.8 or higher are desirable for detecting associations between several coded variables; we were thus satisfied with the level of agreement achieved.
J96-2004
