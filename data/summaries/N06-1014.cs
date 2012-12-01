Using GIZA++ model 4 alignments and Pharaoh (Koehn et al., 2003), we achieved a BLEU score of 0.3035.
N03-1017
Word alignment is an important component of a complete statistical machine translation pipeline (Koehn et al., 2003).
N03-1017
Klein and Manning (2004) combine two complementary models for grammar induction, one that models constituency and one that models dependency, in a manner broadly similar to the current work.
P04-1061
Each model was trained for 5 iterations, using the same training regimen as in Och and Ney (2003).
J03-1002
Each z can be thought of as an element in the set of generalized alignments, where any subset of word pairs may be aligned (Och and Ney, 2003).
J03-1002
The classic approaches to unsupervised word alignment are based on IBM models 1–5 (Brown et al., 1994) and the HMM model (Ney and Vogel, 1996) (see Och and Ney (2003) for a systematic comparison).
C96-2141 J03-1002
In fact, these posteriors could be used more di4See Matusov et al.(2004) for an alternative use of these marginals.
C04-1032
As a result, many practitioners use the complex GIZA++ software package (Och and Ney, 2003) as a black box, selecting model 4 as a good compromise between alignment quality and efficiency.
J03-1002
For example, gains from the new model 6 of Och and Ney (2003) are modest.
J03-1002
Moore. 2005.
H05-1011
Moore. 2004.
P04-1066
The validation and test sentences have been hand-aligned (see Och and Ney (2003)) and are marked with both sure and possible alignments.
J03-1002
this example, COJO is a rare word that becomes a garbage collector (Moore, 2004) for the models in both directions.
P04-1066
models: IBM 1, 2 and HMM We briefly review the sequence-based word alignment models (Brown et al., 1994; Och and Ney, 2003) and describe some of the choices in our implementation.
J03-1002
In general, if both posterior distributions over the latent variables z decompose in the same tractable manner, as in the context-free grammar induction work of Klein and Manning (2004), the summation could be carried out efficiently, for example using dynamic programming.
P04-1061
Work Our approach is similar in spirit to co-training, where two classifiers, complementary by the virtue of having different views of the data, are trained jointly to encourage agreement (Blum and Mitchell, 1998; Collins and Singer, 1999).
W99-0613
The distortion parameters pd(aj = iprime | aj− = i) depend on the particular model (we write aj = 0 to denote the event that the j-th French word 2The dependence on aj − can in fact be implemented as afirst-order HMM (see Och and Ney (2003)).
J03-1002
