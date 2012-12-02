We propose a new method to answer definition questions, that combines and extends the technique of Prager et al.(2001, 2002), which relied on WordNet hypernyms, and that of Joho et al.(2001, 2002), which relied on manually crafted lexical patterns, sentence position, and word cooccurrence across candidate answers.
H01-1006 H01-1045
Single-snippet definitions can also be useful in information extraction, where the templates to be filled in often require short entity descriptions; see Radev and McKeown (1997).
A97-1033
Prager et al., our reimplementation does not use a ranking function (Radev et al., 2000).
A00-1021
Prager et al.’s method performed well with the definition questions and documents of TREC-9 (Prager et al., 2001).
H01-1006
We pick the five vectors whose confidence score for the category of definitions is highest, and report the corresponding snippets; in effect, we use the SVM as a ranker, rather than a classifier; see also Ravichandran et al.(2003). The imbalance between the two categories can be reduced by considering (during both training and classification) only the first three snippets of each document, which discards mostly non-definitions.
N03-2029 W03-1209
We did not implement the tests for orthographic variations and count ratios of Prager et al.When an input term occurs in multiple synsets, which produces multiple paths towards hypernyms, we select the hypernyms with the best overall LAC scores, instead of the best scores per path, unlike Prager et al.(2001). that have the term at their center.
H01-1006
techniques Prager et al.(2001, 2002) observe that definition questions can often be answered by hypernyms; for example, “schizophrenia” is a “mental illness”, where the latter is a hypernym of the former in WordNet.
H01-1006
This is essentially a combination of the approaches of Prager et al.and Joho et al.Unlike simple voting (Chu-Carroll et al., 2003), the two methods contribute attributes to the instance representations (vectors) of an overall learner (the SVM).
N03-1004
In Joho et al.(2001), this method was evaluated with 50 definition questions and the top 600 documents that Google returned for each definition term.
H01-1045
In TREC-2003, the answers to definition questions had to be lists of complementary snippets (Voorhees, 2003), as opposed to singlesnippet definitions.
N03-2037
They then short-list the passages that contain both the term and any of the best hypernyms, and rank them using measures similar to those of Radev et al.(2000). More precisely, given a term to define, they compute the level-adapted count (LAC) of each of its hypernyms, defined as the number of two-sentence passages where the hypernym co-occurs with the term divided by the distance between the term and the hypernym in WordNet’s hierarchy.
A00-1021
The second row contains the results reported by Prager et al.(2001, 2002), while the third one shows the results of our reimplementation.
H01-1006
Further improvements may be possible by using a sentence splitter instead of windows of fixed length, anaphora resolution, clustering of similar snippets to avoid ranking them separately, and identifying additional n-gram attributes by bootstrapping (Ravichandran et al.2003). We believe that it is possible to address the post2003 TREC task for definition questions with the same approach, but training the SVM learner to identify snippets that should be included in multisnippet definitions.
N03-2029 W03-1209
