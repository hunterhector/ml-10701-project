Single-Candidate Model One way to utilize the semantic compatibility is to take it as a feature under the single-candidate learning model as employed by Ng and Cardie (2002).
P02-1014
Dagan and Itai (1990) proposed a heuristics-based approach to pronoun resolution.
C90-3063
Recently, Bean and Riloff (2004) presented an unsupervised approach to coreference resolution, which mined the co-referring NP pairs with similar predicatearguments from a large corpus using a bootstrapping method.
N04-1038
ParalStuct marks whether a candidate and an anaphor have similar surrounding words, which is also a salience factor for the candidate evaluation (Mitkov, 1998).
P98-2143
However, as the purpose of the predicate-argument statistics is to evaluate the preference of the candidates in semantics, it is possible that the statistics-based semantic feature could be more effectively applied in the twincandidate (Yang et al., 2003) that focusses on the preference relationships among candidates.
P03-1023
The larger size and the better counts of the web against the corpus, as reported in Section 4.2, 4The improvement against SC is higher than that reported in (Yang et al., 2003).
P03-1023
However, previous study (Keller and Lapata, 2003) reveals that the large amount of data available for the web counts could outweigh the noisy problems.
J03-3005
So far the web has been utilized in nominal anaphora resolution (Modjeska et al., 2003; Poesio et al., 2004) to determine the semantic relation between an anaphor and candidate pair.
P04-1019 W03-1023
Indeed, existing learning-based approaches to anaphor resolution have performed reasonably well using limited and shallow knowledge (e.g., Mitkov (1998), Soon et al.(2001), Strube and Muller (2003)).
J01-4004 P03-1022 P98-2143
Previous approaches to anaphora resolution adopt the singlecandidate model, in which the resolution is done on an anaphor and one candidate at a time (Soon et al., 2001; Ng and Cardie, 2002).
J01-4004 P02-1014
The noun phrase identification and the predicate-argument extraction were done based on the results of a chunk tagger, which was trained for the shared task of CoNLL-2000 and achieved 92% accuracy (Zhou et al., 2000).
W00-0737
Twin-Candidate Model Yang et al.(2003) proposed an alternative twincandidate model for anaphora resolution task.
P03-1023
Kehler et al.(2004), for example, explored the usage of the corpus-based statistics in supervised learning based systems, and found that such information did not produce apparent improvement for the overall pronoun resolution.
N04-1037
Consider the example given in the work of Dagan and Itai (1990): (1) They know full well that companies held tax money aside for collection later on the basis that the government said it1 was going to collect it2.
C90-3063
The recognition of NEs as well as their semantic categories was done by a HMM based NER, which was trained for the MUC NE task and obtained high F-scores of 96.9% (MUC-6) and 94.3% (MUC-7) (Zhou and Su, 2002).
P02-1060
These results not only affirm the claim by Yang et al.(2003) that the TC model is superior to the SC model for pronoun resolution, but also indicate that TC is more reliable than SC in applying the statistics-based semantic feature, for N-Pron resolution.
P03-1023
It is believed that the size of the web is thousands of times larger than normal large corpora, and the counts obtained from the web are highly correlated with the counts from large balanced corpora for predicate-argument bi-grams (Keller and Lapata, 2003).
J03-3005
Especially, it considerably outperforms (up to 11.5% success) the system with the Corpus+SC combination, which is commonly adopted in previous work (e.g., Kehler et al.(2004)). Personal pronoun resolution vs.
N04-1037
The POS properties could indicate whether a candidate refers to a hearerold entity that would have a higher preference to be selected as the antecedent (Strube, 1998).
P98-2204
