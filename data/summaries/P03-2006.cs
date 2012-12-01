Obviously, because of parsing errors the performance drops significantly: e.g., in the experiments reported in (Johnson, 2002) the overall fscore decreases from 0.75 to 0.68 when evaluating on parser output (see Table 4).
P02-1018
In (Clark et al., 2002) long-range dependencies are included in parser’s probabilistic model, while Johnson (2002) presents a method for recovering non-local dependencies after parsing has been performed.
P02-1018 P02-1042
The results presented in the previous section show that it is possible to improve over the simple pattern matching algorithm of (Johnson, 2002), using dependency rather than phrase structure information, more skeletal patterns, as was suggested by Johnson, and a set of features associated with instances of patterns.
P02-1018
The evaluation of our algorithm on data automatically derived from the Penn Treebank shows an increase in both precision and recall in recovery of non-local dependencies by approximately 10% over the results reported in (Johnson, 2002).
P02-1018
This corresponds to rows 2, 3 and 4 of Table 4 in (Johnson, 2002).
P02-1018
In order to compare our results to the results presented in (Johnson, 2002), we measured the overall performance of the algorithm across patterns and non-local dependency labels.
P02-1018
It is difficult to make a strict comparison of our results and those in (Johnson, 2002).
P02-1018
The corpus was automatically derived from the Penn Treebank II corpus (Marcus et al., 1993), by means of the script chunklink.pl (Buchholz, 2002) that we modified to fit our purposes.
J93-2004
More specifically, Johnson (2002) describes a pattern-matching algorithm for inserting empty nodes and identifying their antecedents in phrase structure trees or, to put it differently, for recovering non-local dependencies.
P02-1018
Evaluating the algorithm on the Penn Treebank shows an improvement of both precision and recall, compared to the results presented in (Johnson, 2002).
P02-1018
On section 23 On parser output P R f P R f Overall 0.80 0.70 0.75 0.73 0.63 0.68 Table 4: Results from (Johnson, 2002).
P02-1018
The patternmatching approach proposed by Johnson (2002) for a similar task for phrase structure trees is extended with machine learning techniques.
P02-1018
Eisner. 1996.
C96-1058
As in (Johnson, 2002), our patterns are minimal connected fragments containing both nodes involved in a non-local dependency.
P02-1018
For every occurrence of a pattern and for every word of this occurrence, we extract the following features: a17 pos, the POS tag of the word; a17 class, the simplified word class (similar to (Eisner, 1996)); a17 fin, whether the word is a verb and a head of a finite verb cluster (as opposed to infinitives, gerunds or participles); a17 subj, whether the word has a dependent (probably not included in the pattern) with a dependency label NP-SBJ; and a17 obj, the same for NP-OBJ label.
C96-1058
The definition of a structure matching a pattern, and the algorithms for pattern matching and pattern extraction from a corpus are straightforward and similar to those described in (Johnson, 2002).
P02-1018
A similar modification was used by Eisner (1996) for the study of dependency parsing models.
C96-1058
In (Johnson, 2002) the author notes that the biggest weakness of the algorithm seems to be that it fails to robustly distinguish co-indexed and free empty nodes and it is lexicalization that may be needed to solve this problem.
P02-1018
We extend the pattern matching approach of Johnson (2002) with machine learning techniques, and use dependency structures instead of constituency trees.
P02-1018
This corresponds to the row “Overall” of Table 4 in (Johnson, 2002), repeated here in Table 4.
P02-1018
