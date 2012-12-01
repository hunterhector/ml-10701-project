The phrase length model is motivated by Toutanova et al.(2002) who introduced ‘stay’ probabilities in HMM alignment as an alternative to word fertility.
W02-1012
170 2.1 Properties of the Model and Prior Work The formulation of the WtoP alignment model was motivated by both the HMM word alignment model (Vogel et al., 1996) and IBM Model-4 with the goal of building on the strengths of each.
C96-2141
Brown et al.1993. The mathematics of machine translation: Parameter estimation.
J93-2003
Alignment performance is measured by the Alignment Error Rate (AER) (Och and Ney, 2003) AER(B;B′) = 1−2×|B ∩B′|/(|B′|+|B|) where B is a set reference word links, and B′ are the word links generated automatically.
J03-1002 P03-1021
Pooling the sets to form two large C→E and A→E test sets, the A→E system improvements are significant at a 95% level (Och, 2003); the C→E systems are only equivalent.
J03-1002 P03-1021
We begin with 10 iterations of EM to train Model-1, followed by 5 EM iterations to train Model-2 (Brown and others, 1993).
J93-2003
Pair Induction A common approach to phrase-based translation is to extract an inventory of phrase pairs (PPI) from bitext (Koehn et al., 2003), For example, in the phraseextract algorithm (Och, 2002), a word alignment ˆam1 is generated over the bitext, and all word subsequences ei2i1 and fj2j1 are found that satisfy : ˆam1 : ˆaj ∈ [i1,i2] iff j ∈ [j1,j2] . (1) The PPI comprises all such phrase pairs (ei2i1,fj2j1 ).
N03-1017
Model-1 can also be used in this way (Venugopal et al., 2003), although it is a relatively weak alignment model.
P03-1041
Currently, Model-4 alignments (Brown and others, 1993) as produced by GIZA++ (Och and Ney, 2000) are often the best that can be obtained, especially with large bitexts.
J93-2003 P00-1056
We use a simple, single parameter distribution, with η = 8.0 throughout P(K|m,e) = P(K|m,l) ∝ ηK Word-to-Phrase Alignment Alignment is a Markov process that specifies the lengths of phrases and their alignment with source words P(aK1,hK1,φK1 |K,m,e) = Kproductdisplay k=1 P(ak,hk,φk|ak−1,φk−1,e) = Kproductdisplay k=1 p(ak|ak−1,hk;l)d(hk)n(φk;eak) The actual word-to-phrase alignment (ak) is a firstorder Markov process, as in HMM-based word-toword alignment (Vogel et al., 1996).
C96-2141
The hallucination process is motivated by the use of NULL alignments into Markov alignment models as done by (Och and Ney, 2003).
J03-1002 P03-1021
The bigram translation probability relies on word context, known to be helpful in translation (Berger et al., 1996), to improve the identification of target phrases.
J96-1002
Marcu and Wong (2002) propose a model to learn lexical correspondences at the phrase level.
W02-1018
