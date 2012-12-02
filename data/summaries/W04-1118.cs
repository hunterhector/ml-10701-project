Palmer. 1997.
P97-1041
of the Baseline System for Statistical Machine Translation 2.1 Principle In statistical machine translation, we are given a source language (‘French’) sentence fJ1 = f1 :::fj :::fJ, which is to be translated into a target language (‘English’) sentence eI1 = e1 :::ei :::eI: Among all possible target language sentences, we will choose the sentence with the highest probability: ˆeI1 = argmax eI1 'Pr(eI 1jf J 1 ) “ (1) = argmax eI1 'Pr(eI 1)¢Pr(f J 1 je I 1) “ (2) The decomposition into two knowledge sources in Equation 2 is known as the source-channel approach to statistical machine translation (Brown et al., 1990).
J90-2002
The relationship between the translation model and the alignment model is given by: Pr(fJ1 jeI1) = X aJ1 Pr(fJ1 ;aJ1jeI1) (3) In this paper, we use the models IBM-1, IBM4 from (Brown et al., 1993) and the HiddenMarkovalignmentmodel(HMM)from(Vogelet al., 1996).
C96-2141 J93-2003
The extraction algorithm (Och et al., 1999) uses the word alignment information obtained from the models in Section 2.2.
W99-0604
(Sproat and Shih, 1990) and (Sun et al., 1998) used a method that does not rely on a dictionary or a manually segmented corpus.
P98-2206
Further details on the alignment template approach are described in (Och et al., 1999; Och and Ney, 2002).
P02-1038 W99-0604
For example, (Palmer, 1997) developed a Chinese word segmenter using a manually segmented corpus.
P97-1041
A detailed description of these models can be found in (Och and Ney, 2003).
J03-1002
A Viterbi alignment ˆaJ1 of a specific model is an alignment for which the following equation holds: ˆaJ1 = argmax aJ1 Pr(fJ1 ;aJ1jeI1): (4) The alignment models are trained on a bilingual corpus using GIZA++(Och et al., 1999; Och and Ney, 2003).
J03-1002 W99-0604
The key elements of this translation approach (Och et al., 1999) are the alignment templates.
W99-0604
