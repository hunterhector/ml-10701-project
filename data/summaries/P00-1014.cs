Data Set As in ( Ratnaparkhi, 1998 ), we constructed a training data set consisting of only unambiguous Table 2 . Initial co-occurrence frequency table entries for A man in the park saw a dog with a telescope . V OR N 1 P N 2 F REQUENCY man in park 1.0 saw with telescope 0.5 dog with telescope 0.5 Table 3 . Co-occurrence frequency table entries for A man in the park saw a dog with a telescope after one iteration.
P98-2177
Excepts of entries in the collocation database for eat and salad . Table 1 . The top 20 most similar words of eat and salad as given by (Lin, 1998b).
P98-2127
Minipar outputs dependency trees (Lin, 1999) from the input sentences.
P99-1041
Human accuracy, given the full context of a sentence, is 93.2% and drops to 88.2% when given only tuples of the form ( V, N 1, P, N 2 ) (Ratnaparkhi et al., 1994).
H94-1048
In our experiments, we only considered features that contained P since the preposition is the most important lexical item (Collins and Brooks, 1995).
W95-0103
accuracy is reported in (Collins and Brooks, 1995).
W95-0103
Later, Collins and Brooks (1995) achieved 84.5% accuracy by employing a backed-off model to smooth for unseen events.
W95-0103
A non-statistical supervised approach by Brill and Resnik (1994) yielded 81.8% accuracy using a transformation-based approach (Brill, 1995) and incorporating word-class information.
C94-2195 J95-4004
Data The test data consists of 3097 examples derived from the manually annotated attachments in the Penn Treebank Wall Street Journal data (Ratnaparkhi et al., 1994) 4 . Each line in the test data consists of a 4-tuple and a target classification: V N 1 P N 2 target . 4 Available at ftp.cis.upenn.edu/pub/adwait/PPattachData.
H94-1048
One of the earliest corpus-based approaches to prepositional phrase attachment used lexical preference by computing co-occurrence frequencies (lexical associations) of verbs and nouns with prepositions (Hindle and Rooth, 1993).
J93-1005
Data Extraction We parsed a 125-million word newspaper corpus with Minipar 3, a descendent of Principar (Lin, 1994).
C94-1079
The state of the art is a supervised algorithm that employs a semantically tagged corpus (Stetina and Nagao, 1997).
W97-0109
The current unsupervised state of the art achieves 81.9% attachment accuracy (Ratnaparkhi, 1998).
P98-2177
2.2 Corpus-based thesaurus Using the collocation database, Lin (1998b) used an unsupervised method to construct a corpusbased thesaurus consisting of 11839 nouns, 3639 verbs and 5658 adjectives/adverbs.
P98-2127
Ratnaparkhi et al.(1994) used a maximum entropy model considering only lexical information from within the verb phrase (ignoring N 2).
H94-1048
database Given a word w in a dependency relationship (such as subject or object ), the collocation database is used to retrieve the words that occurred in that relationship with w, in a large corpus, along with their frequencies (Lin, 1998a).
P98-2127
We describe the different classifiers below: cl base : the baseline described in Section 7.2 cl R1 : uses a maximum entropy model (Ratnaparkhi et al., 1994) cl BR 5 : uses transformation-based learning (Brill and Resnik, 1994) cl CB : uses a backed-off model (Collins and Brooks, 1995) cl SN : induces a decision tree with a sense-tagged corpus, using a semantic dictionary (Stetina and Nagao, 1997) cl HR 6 : uses lexical preference (Hindle and Rooth, 1993) cl R2 : uses a heuristic extraction of unambiguous attachments (Ratnaparkhi, 1998) cl PL : uses the algorithm described in this paper Our classifier outperforms all previous unsupervised techniques and approaches the performance of supervised algorithm.
C94-2195 H94-1048 J93-1005 J95-4004 P98-2177 W95-0103 W97-0109
Recent work shows that it is generally sufficient to utilize lexical information (Brill and Resnik, 1994; Collins and Brooks, 1995; Hindle and Rooth, 1993; Ratnaparkhi et al., 1994).
C94-2195 H94-1048 J93-1005 J95-4004 W95-0103
M ETHOD L EARNING A CCURACY CL BASE --70.39% CL R1 supervised 81.6% CL BR supervised 81.9% CL CB supervised 84.5% CL SN supervised 88.1% CL HR unsupervised 75.8% CL R2 unsupervised 81.91% CL PL unsupervised 84.31% Table 10 . Accuracy of our reconstruction of (Hindle & Rooth, 1993) and (Ratnaparkhi, 1998).
J93-1005 P98-2177
They report 88.1% attachment accuracy approaching the human accuracy of 88.2% (Ratnaparkhi et al., 1994).
H94-1048
