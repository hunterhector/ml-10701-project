Since Mihalcea’s setting was kept unchanged, we just included in that table the same results presented in (Mihalcea, 2005), i.e., we did not run her systems all over again.
P05-3013
In our assessment, the same single-document summarization scenario posed by Mihalcea (2005) was adopted, namely: (a) we considered the Brazilian Portuguese TeMário corpus (Pardo and Rino, 2003); (b) we used the same baseline, which selects top-first sentences to include in the extract; (c) we adopted a 70-75% compression rate, making it compatible with the compression rate of the reference summaries; and (d) ROUGE was used for evaluation in its Ngram(1,1) 95% confidence rate setting, without stopwords removal.
P05-3013
For this reason Mihalcea (2005) could use it to evaluate AS on texts in Brazilian Portuguese, besides reporting results on texts in English.
P05-3013
Some of them correspond to full summarization methods by themselves: Lexical Chaining (Barzilay and Elhadad, 1997), Relationship Mapping (Salton et al., 1997), and Importance of Topics (Larocca Neto et al., 2000).
W97-0703
Usually, extractive AS does not take into account linguistic and semantic knowledge in order to be portable to distinct domains or languages (Mihalcea, 2005).
P05-3013
The discourse structure is intended to help retrieving, e.g., the main topics of the document (e.g, Barzilay and Elhadad, 1997; Larocca Neto et al., 2000) or its rhetorical structure (e.g., Marcu, 1999), in order to provide the means for AS.
W97-0703
Examples of such relations are word cooccurrence (e.g., Salton et al., 1997), synonyms and antonyms (e.g., Barzilay and Elhadad, 1997), logical relations, such as concordance or contradiction, and syntactic relations.
W97-0703
Finally, in tackling (c) and, thus, grading the importance of the relations for sentence similarity, we adopted the same weights proposed by Barzilay and Elhadad (1997) in their lexical chaining method, which is discussed in more detail below.
W97-0703
Concerning (a), synonyms, antonyms, and term repetition were all considered, as suggested by others (e.g., Barzilay and Elhadad, 1997).
W97-0703
Both methods and parameters are mapped onto the feature space and are defined as follows: (M) Lexical Chaining (Barzilay and Elhadad, 1997).
W97-0703
