LinandHovy(2003)aswellasSoricutandBrill (2004) present ways of extending the notion of ngram co-occurrence statistics over multiple references, such as those used in Bleu, to other natural language generation tasks such as summarization.
N03-1020 P04-1078
For example, work which failed to detect improvements in translation quality with the integration of word sense disambiguation (Carpuat and Wu, 2005), or work which attempted to integrate syntactic information but which failed to improve Bleu (Charniak et al., 2003; Och et al., 2004) may deserve a second look with a more targeted manual evaluation.
N04-1021 P05-1048
255 Meteor (Banerjee and Lavie, 2005), Precision and Recall (Melamed et al., 2003), and other such automatic metrics may also be affected to a greater or lesser degree because they are all quite rough measures of translation similarity, and have inexact models of allowable variation in translation.
N03-2021 W05-0909
Detailed The rationale behind the development of Bleu (Papinenietal., 2002)isthathumanevaluationofmachine translation can be time consuming and expensive.
P02-1040
Papineni et al.(2002) showed that Bleu correlated with human judgments in its rankings of five Chinese-to-English machine translation systems, and in its ability to distinguish between human and machine translations.
P02-1040
Banerjee and Lavie (2005) introduce the Meteor metric, which also incorporates recall on the unigram level and further provides facilities incorporating stemming, and WordNet synonyms as a more flexible match.
W05-0909
The remaining six entries were all fully automatic machine translation systems; in fact, they were all phrase-based statistical machine translation system that had been trained on the same parallel corpus and most used Bleubased minimum error rate training (Och, 2003) to optimize the weights of their log linear models’ feature functions (Och and Ney, 2002).
P02-1038 P03-1021
This problem is made worse by the fact that Bleu equally weights all items in the reference sentences (Babych and Hartley, 2004).
P04-1079
Over the past five years progress in machine translation, and to a lesser extent progress in natural language generation tasks such as summarization, has been driven by optimizing against n-grambased evaluation metrics such as Bleu (Papineni et al., 2002).
P02-1040
Melamed et al.(2003) formulate a metric which measures translation accuracy in terms of precision and recall directly rather than precision and a brevity penalty.
N03-2021
Papineni et al.(2002) calculate their modified precision score, pn, for each n-gram length by summing over the matches for every hypothesis sentence S in the complete corpus C as: pn = summationtext S∈C summationtext ngram∈S Countmatched(ngram)summationtext S∈C summationtext ngram∈S Count(ngram) Counting punctuation marks as separate tokens, the hypothesis translation given in Table 1 has 15 unigram matches, 10 bigram matches, 5 trigram matches (these are shown in bold in Table 2), and three 4-gram matches (not shown).
P02-1040
Babych and Hartley (2004) extend Bleu by adding frequency weighting to lexical items through TF/IDF as a way of placing greater emphasis on content-bearing words and phrases.
P04-1079
The statistical machine translation community relies on the Bleu metric for the purposes of evaluating incremental system changes and optimizing systems through minimum error rate training (Och, 2003).
P03-1021
