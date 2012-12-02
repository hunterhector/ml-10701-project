For search, we use a dynamic programming beam-search algorithm to explore a subset of all possible translations (Och et al., 1999) and extract a46 best candidate translations using A* search (Ueffing et al., 2002).
P02-1038 W02-1021 W99-0604
In the field of natural language processing this approach has been applied for example in parsing (Goodman, 1996) and word alignment (Kumar and Byrne, 2002).
P96-1024 W02-1019
Work The use of log-linear models for statistical machine translation was suggested by Papineni et al.(1997) and Och and Ney (2002).
P02-1038
In addition to the feature functions described in (Och and Ney, 2002), our system includes a phrase penalty (the number of alignment templates used) and special alignment features.
P02-1038
It is straightforward to refine this algorithm to also handle the BLEU and NIST scores instead of sentence-level error counts by accumulating the relevant statistics for computing these scores (n-gram precision, translation length and reference length) . 6 Baseline Translation Approach The basic feature functions of our model are identical to the alignment template approach (Och and Ney, 2002).
P02-1038
Examples of such methods are word error rate, position-independent word error rate (Tillmann et al., 1997), generation string accuracy (Bangalore et al., 2000), multi-reference word error rate (Nießen et al., 2000), BLEU score (Papineni et al., 2001), NIST score (Doddington, 2002).
W00-1401
