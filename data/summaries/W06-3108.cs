The approach presented here has some resemblance to the bracketing transduction grammars (BTG) of (Wu, 1997), which have been applied to a phrase-based machine translation system in (Zens et al., 2004).
C04-1030 J97-3002 N04-1033
We use a state-of-the-art phrase-based translation system (Zens and Ney, 2004; Zens et al., 2005) including the following models: an n-gram language model, a phrase translation model and a word-based lexicon model.
C04-1030 N04-1033
Och. 2003.
J03-1002 P03-1021
Then the alignments are symmetrized using a refined heuristic as described in (Och and Ney, 2003).
J03-1002 P03-1021
A reordering model in the framework of weighted finite state transducers is described in (Kumar and Byrne, 2005).
H05-1021
The model scaling factors λM1 are trained with respect to the final translation quality measured by an error criterion (Och, 2003).
J03-1002 P03-1021
This very simple reordering model is widely used, for instance in (Och et al., 1999; Koehn, 2004; Zens et al., 2005).
E99-1010 W99-0604
The idea of predicting the orientation is adopted from (Tillmann and Zhang, 2005) and (Koehn et al., 2005).
P05-1069
Among all possible target language sentences, we will choose the sentence with the highest probability: ˆeˆI1 = argmax I,eI1 braceleftbigPr(eI 1|f J 1 ) bracerightbig (1) The posterior probability Pr(eI1|fJ1 ) is modeled directly using a log-linear combination of several models (Och and Ney, 2002): Pr(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 λmhm(e I1,fJ1 ) parenrightBig summationtext I′,e′I′1 exp parenleftBigsummationtextM m=1 λmhm(e′ I′ 1,fJ1 ) parenrightBig (2) The denominator represents a normalization factor that depends only on the source sentence fJ1 . Therefore, we can omit it during the search process.
P02-1038
Usually, the costs for phrase movements are linear in the distance, e.g. see (Och et al., 1999; Koehn, 2004; Zens et al., 2005).
E99-1010 W99-0604
Results For the translation experiments on the BTEC task, we report the two accuracy measures BLEU (Papineni et al., 2002) and NIST (Doddington, 2002) as well as the two error rates: word error rate (WER) and position-independent word error rate (PER).
P02-1040
As a decision rule, we obtain: ˆeˆI1 = argmax I,eI1 braceleftBigg Msummationdisplay m=1 λmhm(eI1,fJ1 ) bracerightBigg (3) This approach is a generalization of the sourcechannel approach (Brown et al., 1990).
J90-2002
In the case of two orientation classes, cj,j′ is defined as: cj,j′ = braceleftbigg left, if j′ < j right, if j′ > j (4) Then, the reordering model has the form p(cj,j′|fJ1,eI1,i,j) A well-founded framework for directly modeling the probability p(cj,j′|fJ1,eI1,i,j) is maximum entropy (Berger et al., 1996).
J96-1002
Och. 1999.
E99-1010 W99-0604
Recently, in (Tillmann and Zhang, 2005) and in (Koehn et al., 2005), a reordering model has been described that tries to predict the orientation of a phrase, i.e. it answers the question ’should the next phrase be to the left or to the right of the current phrase?’ This phrase orientation probability is conditioned on the current source and target phrase and relative frequencies are used to estimate the probabilities.
P05-1069
We train IBM Model 4 with GIZA++ (Och and Ney, 2003) in both translation directions.
J03-1002 P03-1021
The word classes for the class-based features are trained using the mkcls tool (Och, 1999).
E99-1010 W99-0604
