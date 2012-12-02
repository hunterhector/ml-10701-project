A similar argument applies to phrase-based translation methods (e.g., Koehn et al.(2003)). While phrase-based systems do take into account context within phrases, they are not able to use context across phrase boundaries.
N03-1017 P03-1040
An alternate way to optimize weights over translation features is described in Och and Ney (2002).
P02-1038
Work Berger et al.(1996) apply maximum entropy methods (equivalent to logistic regression) to, among other tasks, the word-translation task.
J96-1002
For example, in the IBM Models (Brown et al., 1993), each word ti independently generates 0, 1, or more 2Note that we refer to t as the target sentence, even though in the source-channel model, t is the source sentence which goes through the channel model P(s|t) to produce the observed sentence s.
J93-2003
For example, Carpuat and Wu (2005) obtain negative results for two methods of incorporating the output of a word-sense disambiguation system into a machine translation system.
P05-1048
Koehn and Knight (2003) focus on the task of noun-phrase translation.
N03-1017 P03-1040
A key part of pruning the search space is deciding on the set of words to consider in possible translations (Germann et al., 2001).
P01-1030
Diab and Resnik (2002) suggest using large bilingual corpora to improve performance on word sense disambiguation.
P02-1033
Ng et al.(2003) address word sense disambiguation by manually annotating WordNet senses with their translation in the target language (Chinese), and then automatically extracting labeled examples for word sense disambiguation by applying the IBM 777 Models to a bilingual corpus.
P03-1058
Carpuat and Wu (2005) recently observed that simpler integration approaches, such as forcing the machine translation system to use the word translation model’s first choice, do not improve translation results.
P05-1048
