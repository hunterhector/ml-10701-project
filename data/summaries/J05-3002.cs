For example, all summary sentences may contain the full description of a named entity (e.g., President of Columbia University Lee Bollinger), while the use of shorter descriptions such as Bollinger or anaphoric expressions in some summary sentences would increase the summary’s readability (Schiffman, Nenkova, and McKeown 2002; Nenkova and McKeown 2003).
N03-2024
While this approach exploits only syntactic and lexical information, Jing and McKeown (2000) also rely on cohesion information, derived from word distribution in a text: Phrases that are linked to a local context are retained, while phrases that have no such links are dropped.
A00-2024
Knight and Marcu (2000) treat reduction as a translation process using a noisychannel model (Brown et al.1993). In this model, a short (compressed) string is treated as a source, and additions to this string are considered to be noise.
J93-2003
The first two of these scores are produced by Simfinder, and the salience score is computed using lexical chains (Morris and Hirst 1991; Barzilay and Elhadad 1997) as described below.
J91-1002 W97-0703
A straightforward approach for approximating sentence fusion can be found in the use of sentence extraction for multidocument summarization (Carbonell and Goldstein 1998; Radev, Jing, and Budzikowska 2000; Marcu and Gerber 2001; Lin and Hovy 2002).
A00-1021 A00-2024 P02-1058 W00-0403
This restriction is necessary because the problem of optimizing many-to-many alignments 5 Our preliminary experiments with n-gram-based overlap measures, such as BLEU (Papineni et al.2002) and ROUGE (Lin and Hovy 2003), show that these metrics do not correlate with human judgments on the fusion task, when tested against two reference outputs.
N03-1020 P02-1040
In addition to reducing the original sentences, Jing and McKeown (2000) use a number of manually compiled rules to aggregate reduced sentences; for example, reduced clauses might be conjoined with and.
A00-2024
Analysis of human-written summaries reveals that most sentences combine information drawn from multiple documents (Banko and Vanderwende 2004).
N04-4001
In fact, previous applications of multisequence alignment have been shown to increase the accuracy of the comparison in other NLP tasks (Barzilay and Lee 2002; Bangalore, Murdock, and Riccardi 2002; Lacatusu, Maiorano, and Harabagiu 2004); unlike our work these approaches operate on strings, not trees, and with the exception of (Lacatusu, Maiorano, and Harabagiu 2004), they apply alignment to parallel data, not comparable texts.
C02-1134 W02-1022
As previously observed in the literature (Mani, Gates, and Bloedorn 1999; Jing and McKeown 2000), such components include a clause in the clause conjunction, relative clauses, and some elements within a clause (such as adverbs and prepositions).
A00-2024 P99-1072
At the other extreme, previous approaches (Radev and McKeown 1998) have demonstrated that this task is feasible when a detailed semantic representation of the input sentences is available.
J98-3005
Evaluation involving human judges revealed that Simfinder identifies similar sentences with 49.3% precision at 52.9% recall (Hatzivassiloglou, Klavans, and Eskin 1999).
W99-0625
We believe that corpus-based algorithms for automatic restoration of punctuation developed for speech recognition applications (Beeferman, Berger, and Lafferty 1998; Shieber and Tao 2003) could help in our task, and we plan to experiment with them in the future.
N03-1029
On the other hand, redundancy can be exploited to identify important and accurate information for applications such as summarization and question answering (Mani and Bloedorn 1997; Radev and McKeown 1998; Radev, Prager, and Samn 2000; Clarke, Cormack, and Lynam 2001; Dumais et al.2002; Chu-Carroll et al.2003). Clearly, it would be highly desirable to have a mechanism that could identify common information among multiple related documents and fuse it into a coherent text.
A00-1021 J98-3005 N03-1004 W00-0403
Our linearizer lacks the completeness of existing application-independent linearizers, such as the unificationbased FUF/SURGE (Elhadad and Robin 1996) and the probabilistic Fergus (Bangalore and Rambow 2000).
C00-1007
We automatically constructed the paraphrasing dictionary from a large comparable news corpus using the co-training method described in Barzilay and McKeown (2001).
P01-1008
This approach, originally proposed by Knight and Hatzivassiloglou (1995) and Langkilde and Knight (1998), is a standard method used in statistical generation.
P95-1034
While earlier approaches for text compression were based on symbolic reduction rules (Grefenstette 1998; Mani, Gates, and Bloedorn 1999), more recent approaches use an aligned corpus of documents and their human written summaries to determine which constituents can be reduced (Knight and Marcu 2002; Jing and McKeown 2000; Reizler et al.2003). The summary sentences, which have been manually compressed, are aligned with the original sentences from which they were drawn.
A00-2024 P99-1072
In International Conference on Computational Linguistics (COLING 2002), Tapei, Taiwan.
P02-1058
From the overlap data, we computed weighted recall and precision based on fractional count (Hatzivassiloglou and McKeown 1993).
P93-1023
In addition to sentence fusion, compression algorithms (Chandrasekar, Doran, and Bangalore 1996; Grefenstette 1998; Mani, Gates, and Bloedorn 1999; Knight and Marcu 2002; Jing and McKeown 2000; Reizler et al.2003) and methods for expansion of a multiparallel corpus (Pang, Knight, and Marcu 2003) are other instances of such methods.
A00-2024 C00-1007 C02-1134 C96-2183 N03-1024 P99-1072
The main difference between the two methods is in the type of the alignment: Our algorithm performs local alignment, while the algorithm of Pang, Knight, and Marcu (2003) performs global alignment.
N03-1024
The only other text-to-text generation approach able to produce new utterances is that of Pang, Knight, and Marcu (2003).
N03-1024
In the previous version of the system (Barzilay, McKeown, and Elhadad 1999), we performed linearization of a fusion dependency structure using the language generator FUF/SURGE (Elhadad and Robin 1996).
P99-1071
To increase the coherence of the output text, we identify blocks of topically related themes and then apply chronological ordering on blocks of themes using theme time stamps (Barzilay, Elhadad, and McKeown 2002).
W02-1022
Since each of these scores has a different range of values, we perform ranking based on each score separately, then induce total ranking by summing ranks from individual categories: Rank (theme) = Rank (Number of sentences in theme) + Rank (Similarity of sentences in theme) + Rank (Sum of lexical chain scores in theme) Lexical chains—sequences of semantically related words—are tightly connected to the lexical cohesive structure of the text and have been shown to be useful for determining which sentences are important for single-document summarization (Barzilay and Elhadad 1997; Silber and McCoy 2002).
J02-4004 W02-1022 W97-0703
The analysis component of the system, Simfinder (Hatzivassiloglou, Klavans, and Eskin 1999) clusters sentences of input documents into themes, groups of sentences that convey similar information (Section 2.1).
W99-0625
In the NLP context, this class of algorithms has been used previously in examplebased machine translation, in which the goal is to find an optimal alignment between the source and the target sentences (Meyers, Yangarber, and Grishman 1996).
C96-1078
Second, our method is an instance of a multisequence alignment, 15 in contrast to the pairwise alignment described in Meyers, Yangarber, and Grishman (1996).
C96-1078
In fact, we have developed a rule-based component that transforms the phrase structure output of Collins’s (2003) parser into a representation in which a node has a direct link to its dependents.
J03-4003
