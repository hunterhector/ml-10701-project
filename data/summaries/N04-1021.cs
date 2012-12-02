1 Score We used IBM Model 1 (Brown et al., 1993) as one of the feature functions.
J93-2003
6 Tree-Based Feature Functions Syntax-based MT has shown promise in the work of, among others, Wu and Wong (1998) and Alshawi, Bangalore, and Douglas (2000).
J00-1004 P98-2230
However, certain properties of the BLEU metric can be exploited to speed up search, as described in detail by Och (2003).
P03-1021
We are given a source (‘Chinese’) sentence f = fJ1 = f1,...,fj,...,fJ, which is to be translated into a target (‘English’) sentence e = eI1 = e1,...,ei,...,eI Among all possible target sentences, we will choose the sentence with the highest probability: ˆeI1 = argmax eI1 {Pr(eI1|fJ1 )} (1) As an alternative to the often used source-channel approach (Brown et al., 1993), we directly model the posterior probability Pr(eI1|fJ1 ) (Och and Ney, 2002) using a log-linear combination of feature functions.
J93-2003 P02-1038
Here, we used a model defined by Yamada and Knight (2001) and Yamada and Knight (2002).
P01-1067 P02-1039
This is similar to the HMM Alignment model (Vogel, Ney, and Tillmann, 1996) but in this case movement is calculated on the basis of parts of speech.
C96-2141
We hope that such features can combine the strengths of tagand chunk-based translation systems (Schafer and Yarowsky, 2003) with our baseline system.
W03-1002
We began with the tree-to-tree alignment model presented by Gildea (2003).
P03-1011
The model is further extended to incorporate phrasal translations performed at each node of the input parse tree (Yamada and Knight, 2002).
P02-1039
MT System: Alignment Templates Our baseline MT system is the alignment template system described in detail by Och, Tillmann, and Ney (1999) and Och and Ney (2004).
J04-4002 W99-0604
As defined by Brown et al.(1993), Model 1 gives a probability of any given translation pair, which is p(f|e; M1) = epsilon1(l + 1)m mproductdisplay j=1 lsummationdisplay i=0 t(fj|ei).
J93-2003
