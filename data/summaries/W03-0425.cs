The particular setup in which fnTBL is used in this work is described in Florian (2002a): in a first phase, TBL is used to identify the entity boundaries, followed by a sequence classification stage, where the entities identified at the first step are classified using internal and external clues3.
W02-2010
This paper investigates the combination of a set of diverse statistical named entity classifiers, including a rule-based classifier – the transformation-based learning classifier (Brill, 1995; Florian and Ngai, 2001, henceforth fnTBL) with the forward-backward extension described in Florian (2002a), a hidden Markov model classifier (henceforth HMM), similar to the one described in Bikel et al.(1999), a robust risk minimization classifier, based on a regularized winnow method (Zhang et al., 2002) (henceforth RRM) and a maximum entropy classifier (Darroch and Ratcliff, 1972; Berger et al., 1996; Borthwick, 1999) (henceforth MaxEnt).
J95-4004 J96-1002 W02-2010
The model weights are trained using the improved iterative scaling algorithm (Berger et al., 1996).
J96-1002
To facilitate comparison with other classifiers for this task, most reported results 3 The method of retaining only the boundaries and reclassifying the entities was shown to improve the performance of 11 of the 12 systems participating in the CoNLL-2002 shared tasks, in both languages (Florian, 2002b).
W02-2010
A simple combination method is the equal voting method (van Halteren et al., 2001; Tjong Kim Sang et al., 2000), where the parameters are computed as λi (w) = 1n and Pi (C|w,Ci) = δ (C,Ci), where δ is the Kronecker operator (δ (x,y) := (x = y?1 : 0)) – each of the classifiers votes with equal weight for the class that is most likely under its model, and the class receiving the largest number of votes wins.
C00-2124 J01-2002
Robust Risk Minimization Classifier This classifier is described in detail in (Zhang and Johnson, 2003, this volume), along with a comprehensive evaluation of its performance, and therefore is not presented here.
W03-0434
