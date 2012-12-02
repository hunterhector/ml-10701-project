Och. 2002.
P02-1038
in (Toutanova et al., 2002).
W02-1012
It is promising to optimize the model parameters directly with respect to AER as suggested in statistical machine translation (Och, 2003).
J03-1002 P03-1021
I. Dan Melamed 2000.
J00-2004
We used GIZA++ package (Och and Ney, 2003) to train IBM translation models.
J03-1002 P03-1021
Statistical approaches, which depend on a set of unknown parameters that are learned from training data, try to describe the relationship between a bilingual sentence pair (Brown et al., 1993; Vogel and Ney, 1996).
C96-2141 J93-2003
460 3.1 IBM Translation Models Brown et al.(1993) proposed a series of statistical models of the translation process.
J93-2003
Syntax-based translation models, such as tree-to-string model (Yamada and Knight, 2001) and tree-to-tree model (Gildea, 2003), may be very suitable to be added into log-linear models.
P01-1067 P03-1011
An especially well-founded framework is maximum entropy (Berger et al., 1996).
J96-1002
To avoid this problem, we iteratively combine n-best lists to train model parameters until the resulting n-best list does not change, as suggested by Och (2002).
P02-1038
In order to incorporate a new dependency which contains extra information other than the bilingual sentence pair, we modify Eq.2 by adding a new variable v: Pr(a|e,f,v) = exp[ summationtextM m=1 λmhm(a,e,f,v)]summationtext aprime exp[ summationtextM m=1 λmhm(aprime,e,f,v)](4) Accordingly, we get a new decision rule: ˆa = argmax a braceleftbigg Msummationdisplay m=1 λmhm(a,e,f,v) bracerightbigg (5) Note that our log-linear models are different from Model 6 proposed by Och and Ney (2003), which defines the alignment problem as finding the alignment a that maximizes Pr(f, a|e) given e.
J03-1002 P03-1021
Och. 2003.
J03-1002 P03-1021
Studies reveal that statistical alignment models outperform the simple Dice coefficient (Och and Ney, 2003).
J03-1002 P03-1021
Cherry and Lin (2003) developed a 459 statistical model to find word alignments, which allow easy integration of context-specific features.
P03-1012
Tiedemann (2003) introduced a word alignment approach based on combination of association clues.
E03-1026
Log-linear models, which are very suitable to incorporate additional dependencies, have been successfully applied to statistical machine translation (Och and Ney, 2002).
P02-1038
After that, we used three types of methods for performing a symmetrization of IBM models: intersection, union, and refined methods (Och and Ney, 2003).
J03-1002 P03-1021
The Chinese sentences in both the development and test corpus are segmented and POS tagged by ICTCLAS (Zhang et al., 2003).
W03-1730
Och and Ney (2003) proposed Model 6, a log-linear combination of IBM translation models and HMM model.
J03-1002 P03-1021
The direct alignment probability is given by: Pr(a|e,f) = exp[ summationtextM m=1 λmhm(a,e,f)]summationtext aprime exp[ summationtextM m=1 λmhm(aprime,e,f)](2) This approach has been suggested by (Papineni et al., 1997) for a natural language understanding task and successfully applied to statistical machine translation by (Och and Ney, 2002).
P02-1038
The English sentences are tokenized by a simple tokenizer of ours and POS tagged by a rule-based tagger written by Eric Brill (Brill, 1995).
J95-4004
If e has length l and f has length m, there are possible 2lm alignments between e and f (Brown et al., 1993).
J93-2003
Word alignment, which can be defined as an object for indicating the corresponding words in a parallel text, was first introduced as an intermediate result of statistical translation models (Brown et al., 1993).
J93-2003
Heuristic approaches obtain word alignments by using various similarity functions between the types of the two languages (Smadja et al., 1996; Ker and Chang, 1997; Melamed, 2000).
J00-2004 J96-1001 J97-2004
