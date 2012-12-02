In this paper we discuss how the variation n-gram error detection approach (Dickinson and Meurers, 2003a) can be extended to discontinuous structural annotation.
E03-1068
variation n-gram method Our approach builds on the variation n-gram algorithm introduced in Dickinson and Meurers (2003a,b).
E03-1068
Given the estimated 3% error rate of the WSJ tagging (Marcus et al., 1993), they argue that the difference in performance is not sufficient to establish which of the two taggers is actually better.
J93-2004
variation in syntactic annotation In Dickinson and Meurers (2003b), we decompose the variation n-gram detection for syntactic annotation into a series of runs with different nucleus sizes.
E03-1068
As a consequence, the treebanks that have been created for German (NEGRA, Skut et al., 1997; VERBMOBIL, Hinrichs et al., 2000; TIGER, Brants et al., 2002) have relaxed the requirement that constituents have to be contiguous.
A97-1014
On the other hand, structural annotation such as that used in syntactic treebanks (e.g., Marcus et al., 1993) assigns a syntactic category to a contiguous sequence of corpus positions.
J93-2004
While this works for treebanks with continuous constituents, a one-to-one mapping is more complicated to establish for syntactic annotation involving discontinuous constituents (NEGRA, Skut et al., 1997; TIGER, Brants et al., 2002).
A97-1014
Illustrating the negative impact of annotation errors on computational uses of annotated corpora, van Halteren et al.(2001) compare taggers trained and tested on the Wall Street Journal (WSJ, Marcus et al., 1993) and the Lancaster-Oslo-Bergen (LOB, Johansson, 1986) corpora and find that the results for the WSJ perform significantly worse.
J01-2002 J93-2004
As discussed below, this heuristic turns out to be a good predictor of which variations are annotation errors; expanding to the longest possible context, as in Dickinson and Meurers (2003a), is not necessary.
E03-1068
Following Dickinson and Meurers (2003b), we only look for non-constituent occurrences of those strings which also occur at least once as a constituent.
E03-1068
Note that this precision is comparable to the estimates for continuous syntactic annotation in Dickinson and Meurers (2003b) of 71% (with null elements) and 78.9% (without null elements).
E03-1068
The idea that variation in annotation can indicate annotation errors has been explored to detect errors in part-of-speech (POS) annotation (van Halteren, 2000; Eskin, 2000; Dickinson and Meurers, 2003a) and syntactic annotation (Dickinson and Meurers, 2003b).
E03-1068
7–12. Wojciech Skut, Brigitte Krenn, Thorsten Brants and Hans Uszkoreit, 1997.
A97-1014
In Dickinson and Meurers (2003a), contexts are composed of words, and identity of the context is required.
E03-1068
variation in POS annotation In Dickinson and Meurers (2003a), we explore this idea for part-of-speech annotation.
E03-1068
To be able to efficiently calculate all variation nuclei of a treebank, in Dickinson and Meurers (2003b) we make use of the fact that a variation necessarily involves at least one constituent occurrence of a nucleus and calculate the set of nuclei for a window of length i by first finding the constituents of that length.
E03-1068
constituents In Dickinson and Meurers (2003b), we argued that null elements need to be ignored as variation nuclei because the variation in the annotation of a null element as the nucleus is largely independent of the local environment.
E03-1068
Luxembourg. Hans van Halteren, Walter Daelemans and Jakub Zavrel, 2001.
J01-2002
