Another way for determiner deletion is described in (Lee, 2004).
N04-4015
More details about the baseline system can be found in (Zens and Ney, 2004; Zens et al., 2005).
N04-1033
Learning Approach (SL) (Diab et al., 2004) propose solutions to word segmentation and POS Tagging of Arabic text.
N04-4038
The model scaling factors λM1 are trained with respect to the final translation quality measured by an error criterion (Och, 2003).
P03-1021
In (Lee et al., 2003) a statistical approach for Arabic word segmentation was presented.
P03-1051
In (Lee et al., 2003), (Diab et al., 2004) and (Habash and Rambow, 2005) three supervised segmentation methods are introduced.
N04-4015 N04-4038 P03-1051 P05-1071
A comparable work was done by (Diab et al., 2004), where a POS tagging method for Arabic is also discussed.
N04-4038
We explained that the best of our proposed methods, the improved finite state automaton, has three advantages over the state-of-the-art Arabic word segmentation method (Diab, 2000), supervised learning.
W00-0801
Lee. 2004.
N04-4015
Prefix charf0 char09charac charbc charc8 char48char2e charc8char40 Transliteration w f k l b Al Meaning and and then as, like in order to with, in the (Habash and Rambow, 2005) a morphology analyzer was used for the segementation and POS tagging.
P05-1071
This method is very similar to the method used for splitting German compound words (Koehn and Knight, 2003).
E03-1076
Among all possible target language sentences, we will choose the sentence with the highest probability: ˆeˆI1 = argmax I,eI1 braceleftbigPr(eI 1|f J 1 ) bracerightbig (1) The posterior probability Pr(eI1|fJ1 ) is modeled directly using a log-linear combination of several models (Och and Ney, 2002): Pr(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 λmhm(e I1,fJ1 ) parenrightBig summationtext eprimeIprime1 exp parenleftBigsummationtextM m=1 λmhm(eprime Iprime1,fJ 1 ) parenrightBig (2) The denominator represents a normalization factor that depends only on the source sentence fJ1 . Therefore, we can omit it during the search process.
P02-1038
As a decision rule, we obtain: ˆeˆI1 = argmax I,eI1 braceleftBigg Msummationdisplay m=1 λmhm(eI1,fJ1 ) bracerightBigg (3) This approach is a generalization of the sourcechannel approach (Brown et al., 1990).
J90-2002
In the next subsections we will shortly describe the method of (Diab et al., 2004).
N04-4038
Metrics The commonly used criteria to evaluate the translation results in the machine translation community are: WER (word error rate), PER (positionindependent word error rate), BLEU (Papineni et al., 2002), and NIST (Doddington, 2002).
P02-1040
Och. 2003.
P03-1021
