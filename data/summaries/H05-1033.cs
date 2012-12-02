1A similar approach has been proposed for syntactic chunking, e.g., Tjong Kim Sang (2000).
W00-0733
Discourse processing could further enhance question answering systems by interpreting the user’s question either in isolation or in the context of preceding questions (Chai and Jing, 2004).
W04-2504
We applied the same strategy to derive compressed sentences from the output of Spade (Soricut and Marcu, 2003), and also produced human compressions.
N03-1030
Previous datadriven approaches (Knight and Marcu, 2003; Riezler et al., 2003) relied on parallel corpora to determine what is important in a sentence.
N03-1026
We employ lexical and low-level syntactic information (e.g., parts of speech, syntactic chunks) and show that the performance of our discourse chunker on the two subtasks (mentioned above) is comparable to that of a stateof-the-art sentence-level discourse parser (Soricut and Marcu, 2003).
N03-1030
Soricut and Marcu (2003) introduce a syntax-based sentencelevel discourse parser, which consists of two components: a statistical segmentation model and a parser working on the output of the segmenter.
N03-1030
In information extraction, discourse-level knowledge can be used to identify co-referring events (Humphreys et al., 1997) and to determine their temporal order.
W97-1311
In summarisation, for example, the extraction of sentences to include in a summary crucially depends on their rhetorical status (Marcu, 2000; Teufel and Moens, 2002); one might want to extract contrastive or explanatory statements while omitting sentences that contain background information.
J02-4002
For example, Soricut and Marcu (2003) show that perfect discourse segmentation delivers an error reduction of 29% in the performance of their discourse parser.
N03-1030
To facilitate comparison with our models we report inter-annotator agreement in terms of accuracy and F-score.3 For the unlabelled case we also report Window Difference (WDiff), a commonly used evaluation measure for segmentation tasks (Pevzner and Hearst, 2002).
J02-1002
We also applied Spade5, Soricut and Marcu’s (2003) sentence-level discourse parser (see Section 2) to our test set.
N03-1030
Both the baseline and Spade operate on parse trees which were obtained from Charniak’s (2000) parser.
A00-2018
Table 3: Example compressions Compression AvgLen Rating Baseline 9.70 1.93 BT-2-Step 22.06 3.21 Spade 19.09 3.10 Humans 20.07 3.83 Table 4: Mean ratings for automatic compressions nally, we added a simple baseline compression algorithm proposed by Jing and McKeown (2000) which removed all prepositional phrases, clauses, toinfinitives, and gerunds.
A00-2024
Another important reason is the development of robust syntactic parsers (e.g., Charniak, 2000) that can be used to provide critical structural and lexical information to the discourse parser.
A00-2018
Even though discourse parsing at the document-level still poses a significant challenge to data-driven methods, sentence-level discourse models (e.g., Soricut and Marcu, 2003) trained on the RST-DT have attained accuracies comparable to human performance.
N03-1030
We adopted the chunk representation proposed by Ramshaw and Marcus (1995) and used four different tags: B-NUC and B-SAT for nucleus and satellite-initial tokens, and I-NUC and I-SAT for non-initial tokens, i.e., tokens inside a nucleus and satellite span.
W95-0107
