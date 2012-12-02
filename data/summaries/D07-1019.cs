For example, both the work of (Cucerzan and Brill, 2004; Li et al., 2006) used n-gram statistical language models trained from search engine’s query logs to estimate the query string probability.
P06-1129 W04-3238
Via explicit modeling of phonetic information of English words, (Toutanova and Moore, 2002) further investigated this issue.
P02-1019
Both of them require misspelled/correct word pairs for training, and the latter also needs a pronunciation lexicon, but recently (Ahmad and Kondrak, 2005) demonstrated that it is also possible to learn such models automatically from query logs with the EM algorithm, which is similar to work of (Martin, 2004), learning from a very large corpus of raw text for removing non-word spelling errors in large corpus.
H05-1120
Cucerzan and Brill (2004) first investigated this issue and proposed to use query logs to infer correct spellings of misspelled terms.
W04-3238
This subset can be efficiently generated as shown in (Li et al., 2006).
P06-1129
model We denote the maximum entropy model based on baseline model feature set as M0 and the feature set S0 derived from the latest state of the art works of (Li et al., 2006), where S0 includes the features mostly concerning the statistics of the query terms and the similarities between query terms and their correction candidates.
P06-1129
This task can leverage conventional spelling correction methods such as generating candidates based on edit distance (Cucerzan and Brill, 2004) or phonetic similarity (Philips, 1990).
W04-3238
The complexity of query spelling correction task requires the combination of these types of evidence, as done in (Cucerzan and Brill, 2004; Li et al., 2006).
P06-1129 W04-3238
One is how to learn a statistical model to estimate the conditional probability 𝑃 𝑟 𝑐 𝑞, and the other is how to generate confusion set C of a given query q 4.1 Maximum Entropy Model for Query Spelling Correction We take a feature-based approach to model the posterior probability 𝑃 𝑟 𝑐 𝑞 . Specifically we use the maximum entropy model (Berger et al., 1996) for this task: 𝑃 𝑟 𝑐 𝑞 = exp 𝜆 𝑖 𝑓 𝑖 𝑐, 𝑞 𝑁𝑖 =1 exp( 𝜆 𝑖 𝑓 𝑖 (𝑐, 𝑞 )𝑁𝑖 =1 )𝑐 (2) where exp( 𝜆 𝑖 𝑓 𝑖 (𝑐,𝑞 )𝑁𝑖 =1 )𝑐 is the normalization factor; 𝑓 𝑖 𝑐,𝑞 is a feature function defined over query q and correction candidate c, while 𝜆 𝑖 is the corresponding feature weight.
J96-1002
(Brill and Moore, 2000) presented an improved error model over the one proposed by (Kernighan et al., 1990) by allowing generic string-to-string edit operations, which helps with modeling major cognitive errors such as the confusion between le and al.
P00-1037
Actually misspelled queries are rather commonly observed in query logs, as shown in previous investigations into the search engine’s log data that around 10%~15% queries were misspelled (Cucerzan and Brill, 2004).
W04-3238
