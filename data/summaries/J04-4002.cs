Compared to the word-based statistical translation models in Brown et al.(1993), this model is based on a (statistical) phrase lexicon instead of a single-word-based lexicon.
J93-2003
An efficient algorithm for performing this tuning for a larger number of model parameters can be found in Och (2003).
J03-1002 P03-1021
An especially well-founded framework for doing this is the maximum-entropy framework (Berger, Della Pietra, and Della Pietra 1996).
J96-1002
A promising avenue is to gradually extend the model to take into account to some extent the recursive structure of natural languages using ideas from Wu and Wong (1998) or Alshawi, Bangalore, and Douglas (2000).
J00-1004 P98-2230
This is an important advantage compared to syntax-based translation models (Yamada and Knight 2001; Gildea 2003; Charniak, Knight, and Yamada 2003) that require a parser for source or target language.
P01-1067 P03-1011
Concept In general, the search problem for statistical MT even using only Model 1 of Brown et al.(1993) is NP-complete (Knight 1999).
J93-2003 J99-4005
Heuristic functions for search in statistical MT have been used in Wang and Waibel (1997) and Och, Ueffing, and Ney (2001).
H01-1062 P97-1047 W01-1408
A comparison of the two approaches can be found in Koehn, Och, and Marcu (2003).
J03-1002 N03-1017 P03-1021
More details of the training procedure can be found in Och and Ney (2002).
P02-1038
Looking at the results of the recent machine translation evaluations, this approach seems currently to give the best results, and an increasing number of researchers are working on different methods for learning phrase translation lexica for machine translation purposes (Marcu and Wong 2002; Venugopal, Vogel, and Waibel 2003; Tillmann 2003; Koehn, Och, and Marcu 2003).
J03-1002 J03-1005 N03-1017 P03-1021 P03-1041 W02-1018 W03-1001
The classes used in F J prime 1 and E I prime 1 are automatically trained bilingual classes using the method described in Och (1999) and constitute a partition of the vocabulary of source and target language.
E99-1010
The alignment ˆa J 1 that has the highest probability (under a certain model) is also called the Viterbi alignment (of that model): ˆa J 1 = argmax a J 1 p ˆ θ (f J 1, a J 1 | e I 1 ) (8) A detailed comparison of the quality of these Viterbi alignments for various statistical alignment models compared to human-made word alignments can be found in Och and Ney (2003).
J03-1002 P03-1021
Wang and Waibel (1997) have described a simple heuristic function for Model 2 of Brown et al.(1993) that was not admissible.
J93-2003 P97-1047
We call this selection of highly probable words observation pruning (Tillmann and Ney 2000).
C00-2123
As an alternative to the often used source–channel approach (Brown et al.1993), we directly model the posterior probability Pr(e I 1 | f J 1 ) (Och and Ney 2002).
J93-2003 P02-1038
Therefore, we integrate an admissible estimation of the remaining probabilities to arrive at a complete translation (Section 5.6) Many of the other search approaches suggested in the literature do not meet the described aims: • Neither optimal A* search (Och, Ueffing, and Ney 2001) nor optimal integer programming (Germann et al.2001) for statistical MT allows efficient search for long sentences.
H01-1062 P01-1030 W01-1408
An alternative training criterion therefore directly optimizes translation quality as measured by an automatic evaluation criterion (Och 2003).
J03-1002 P03-1021
• Greedy search algorithms (Wang 1998; Germann et al.2001) typically commit severe search errors (Germann et al.2001). • Other approaches to solving the search problem obtain polynomial time algorithms by assuming monotone alignments (Tillmann et al.1997) or imposing a simplified recombination structure (Nießen et al.1998). Others make simplifying assumptions about the search space (Garc´ıa-Varea, Casacuberta, and Ney 1998; Garc´ıa-Varea et al.2001), as does the original IBM stack search decoder (Berger et al.1994). All these simplifications ultimately make the search problem simpler but introduce fundamental search errors.
H01-1062 H94-1028 P01-1030 P97-1037
Och, Ueffing, and Ney (2001) have described an admissible heuristic function for Model 4 of Brown et al.(1993) and an almost-admissible heuristic function that is empirically obtained.
H01-1062 J93-2003 W01-1408
For single-word-based search in MT, a similar algorithm has been described in Tillmann and Ney (2003).
J03-1005 W03-1001
Here, we use the hidden Markov model (HMM) alignment model (Vogel, Ney, and Tillmann 1996) and Model 4 of Brown et al.(1993) to compute the word alignment for the parallel training corpus.
C96-2141 J93-2003
There, the alignment-template-based system achieved a significantly larger number of “approximately correct” translations than the competing translation systems (Ney, Och, and Vogel 2001).
H01-1062 W01-1408
To express the dependence of the model on the parameter set, we use the following notation: Pr(f J 1, a J 1 | e I 1 )=p θ (f J 1, a J 1 | e I 1 ) (6) A detailed description of different specific statistical alignment models can be found in Brown et al.(1993) and Och and Ney (2003).
J03-1002 J93-2003 P03-1021
The joint translation model suggested by Marcu and Wong (2002) tries to learn phrases as part of a full EM algorithm, which leads to very large memory requirements and a rather complicated training algorithm.
W02-1018
Yet the modeling, training, and search methods have also improved since the field of statistical machine translation was pioneered by IBM in the late 1980s and early 1990s (Brown et al.1990; Brown et al.1993; Berger et al.1994). This article focuses on an important improvement, namely, the use of (generalized) phrases instead of just single words as the core elements of the statistical translation model.
H94-1028 J90-2002 J93-2003
