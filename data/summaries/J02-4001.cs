They present a linear time algorithm to extract lexical chains from a source document (the lexical-chain approach was originally developed by Barzilay and Elhadad [1997] but used an exponential time algorithm).
W97-0703
But the interpretation of the results is not simple; studies (Jing et al.1998; Donaway, Drummey, and Mather 2000; Radev, Jing, and Budzikowska 2000) 404 Computational Linguistics Volume 28, Number 4 show how the same summaries receive different scores under different measures or when compared to different (but presumably equivalent) ideal summaries created by humans.
W00-0403 W00-0408
To avoid misleading the reader when juxtaposed passages from different dates all say “yesterday,” some systems add explicit time stamps (Lin and Hovy 2002a).
P02-1058
Other research rewards passages that include topic words, that is, words that have been determined to correlate well with the topic of interest to the user (for topic-oriented summaries) or with the general theme of the source text (Buckley and Cardie 1997; Strzalkowski et al.1999; Radev, Jing, and Budzikowska 2000).
W00-0403
Alternatively, a summarizer may reward passages that occupy important positions in the discourse structure of the text (Ono, Sumita, and Miike 1994; Marcu 1997b).
C94-1056 W97-0713
In this special issue, Jing (2002) reports on automated techniques to build a corpus representing the cut-and-paste process used by humans; such a corpus can then be used to train an automated summarizer.
J02-4006
A common approach is to measure similarity between all pairs of sentences and then use clustering to identify themes of common information (McKeown et al.1999; Radev, Jing, and Budzikowska 2000; Marcu and Gerber 2001).
W00-0403
The final article in the issue (Zechner 2002) is distinct from the other articles in that it addresses problems in summarization of speech.
J02-4003
Recently, Otterbacher, Radev, and Luo (2002) have focused on discourse-based revisions of multidocument clusters as a means for improving summary coherence.
W02-0404
Other 403 Radev, Hovy, and McKeown Summarization: Introduction systems use a combination of temporal and coherence constraints to order sentences (Barzilay, Elhadad, and McKeown 2001).
H01-1065
Some research uses the degree of lexical connectedness between potential passages and the remainder of the text; connectedness may be measured by the number of shared words, synonyms, or anaphora (e.g., Salton et al.1997; Mani and Bloedorn 1997; Barzilay and Elhadad 1999).
P99-1071 P99-1072
Saggion and Lapalme (2002) describe a system, SumUM, that generates indicativeinformative summaries from technical documents.
J02-4005
Machine learning has also been applied to learning individual features; for example, Lin and Hovy (1997) applied machine learning to the problem of determining how sentence position affects the selection of sentences, and Witbrock and Mittal (1999) used statistical approaches to choose important words and phrases and their syntactic context.
A97-1042
The largest task-oriented evaluation to date, the Summarization Evaluation Conference (SUMMAC) (Mani et al.1998; Firmin and Chrzanowski 1999) included three tests: the categorization task (how well can humans categorize a summary compared to its full text?), the ad hoc task (how well can humans determine whether a full text is relevant to a query just from reading the summary)? and the question task (how well can humans answer questions about the main thrust of the source text from reading just the summary?).
P99-1072
Other commonly used measures include kappa (Carletta 1996) and relative utility (Radev, Jing, and Budzikowska 2000), both of which take into account the performance of a summarizer that randomly picks passages from the original document to produce an extract.
J96-2004 W00-0403
The volume of papers edited by Mani and Maybury (1999) and a book (Mani 2001) provide good introductions to the state of the art in this rapidly evolving subfield.
P99-1072
This technique is the focus of one of the articles in this special issue (Teufel and Moens 2002), which shows how particular types of rhetorical relations in the genre of scientific journal articles can be reliably identified through the use of classification.
J02-4002
Two of the articles focus on the extraction stage (Teufel and Moens 2002; Silber and McCoy 2002), whereas Jing (2002) examines tools for automatically constructing resources that can be used for the second stage.
J02-4002 J02-4004 J02-4006
Rather than simply listing all similar sentences (a lengthy solution), some approaches will select a representative passage to convey information in each cluster (Radev, Jing, and Budzikowska 2000), whereas other approaches use information fusion techniques to identify repetitive phrases from the clusters and combine the phrases into the summary (Barzilay, McKeown, and Elhadad 1999).
P99-1071 W00-0403
Recent work also follows this approach, using enhanced information extraction and additional forms of contrasts (White and Cardie 2002).
W02-0402
Marcu (1997a) provides some evidence that other genres will deliver less consistency.
W97-0713
Mani, Gates, and Bloedorn (1999) describe the use of human-generated compression and reformulation rules.
P99-1072
Later work merged information extraction approaches with regeneration of extracted text to improve summary generation (Radev and McKeown 1998).
J98-3005
Simply using a variant of the Bilingual Evaluation Understudy (BLEU) scoring method (based on a linear combination of matching n-grams between the system output and the ideal summary) developed for machine translation (Papineni et al.2001) is promising but not sufficient (Lin and Hovy 2002b).
P02-1058
