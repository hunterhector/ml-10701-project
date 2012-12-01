By generalizing and separating the overlap statistics from the function used to combine them, and by identifying the latter as a learnable component, BLANC subsumes the ngram based evaluation metrics as special cases and can better reflect the need of end applications for adequacy/fluency tradeoffs. 1.1 Related Work Initial work in evaluating translation quality focused on edit distance-based metrics (Su et al., 1992; Akiba et al., 2001).
C92-2067
The longest common subsequence statistic has also been successfully used for automatic machine translation evaluation in the ROUGE-L (Lin and Och, 2004) algorithm.
P04-1077
Preferred functions are various combinations of precision and recall (Soricut and Brill, 2004), including 1Since existing evaluation metrics (e.g.
P04-1078
(Lin and Och, 2004) recently proposed a set of metrics (ROUGE) for MT evaluation.
P04-1077
ROUGE-W (Lin and Och, 2004) relies on a weighted version of the longest common subsequence, under which longer contiguous subsequences are assigned a higher weight than subsequences that incorporate gaps.
P04-1077
the ACS only for skip-ngrams of size 2, the ACS algorithm is equivalent to the ROUGE-S metric (Lin and Och, 2004).
P04-1077
